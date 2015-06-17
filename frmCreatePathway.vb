Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.net
Imports System.text

Public Class frmCreatePathway

    Private Class Coordinate
        Public X As Integer
        Public Y As Integer
        Public PaintPassesMade As Integer
        Public PaintPassesNeeded As Integer
        Public ReadOnly Property NeedsPainting() As Boolean
            Get
                Return (PaintPassesNeeded > PaintPassesMade)
            End Get
        End Property
    End Class
    Private Class RankedCoordinate
        Inherits Coordinate
        Implements IComparable

        Public Rank As Integer

        Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo
            If TypeOf obj Is RankedCoordinate Then
                Dim Compare As RankedCoordinate = CType(obj, RankedCoordinate)
                Return Rank.CompareTo(Compare.Rank)
            End If
        End Function
    End Class


    Public Enum eSTYLE
        RANDOM
        HORIZONTAL
        VERTICAL
    End Enum


    Private Enum eKNOBSTATES
        CCW
        NONE
        CW
    End Enum
    Public Enum eSTARTPOSITIONS
        UL
        UM
        UR
        ML
        MM
        MR
        LL
        LM
        LR
    End Enum

    Public Enum eDIRECTION
        UP
        DOWN
        LEFT
        RIGHT
    End Enum

    Private _PathwayDataFile As String
    Private _PromptForUserInput As Boolean
    Private _InterferenceThreshold As Integer
    Private _BitmapImage As String
    Private _Cycles As Integer = 0
    Private Const _CyclesBetweenReEvaluation As Integer = 100
    Private _PathwayData As New StringBuilder
    Private Const X_DIMENSION As Integer = 400
    Private Const Y_DIMENSION As Integer = 300
    Private _BurstPause As Integer = 2
    Private totalPixelsNeedingPaint As Integer
    Private g As Graphics
    Private drawingBitmap As Bitmap
    Private blackpen As New Pen(Color.Black)
    Private graypen As New Pen(Color.DarkGray)
    Private penXPos As Integer = 0
    Private penYPos As Integer = 0
    Private canvasData(X_DIMENSION, Y_DIMENSION) As Coordinate
    Private _OverrideMode As Boolean
    Private _OverrideX As Integer
    Private _OverrideY As Integer
    Private _UserAssistanceQueryX As Integer
    Private _UserAssistanceQueryY As Integer
    Private _PulseCount As Integer
    Private _LastTick As Long
    Private _PenPositionPen As New Pen(Color.Red, 2)
    Private _QueriedPositionPen As New Pen(Color.Cyan, 3)
    Private _YKnobPlay As Integer = 5
    Private _XKnobPlay As Integer = 7
    Private _lastYDirection As eKNOBSTATES
    Private _lastXDirection As eKNOBSTATES
    Private _Style As eSTYLE
    Private _CurrentMicroDirection As eDIRECTION
    Private _CurrentMacroDirection As eDIRECTION

    Private _UserAssistance As Boolean

    Public Property Style() As eSTYLE
        Get
            Return _Style
        End Get
        Set(ByVal value As eSTYLE)
            _Style = value
        End Set
    End Property


    Public Property UserAssistance() As Boolean
        Get
            Return _UserAssistance
        End Get
        Set(ByVal value As Boolean)
            _UserAssistance = value
            If Me.TimerPulse.Enabled Then
                Me.TimerPulse.Enabled = False
                Me.grpUserAssistanceNeeded.Visible = True
                pnlUserInputInstructions.Visible = True
            Else
                Me.TimerPulse.Enabled = True
                Me.grpUserAssistanceNeeded.Visible = False
                pnlUserInputInstructions.Visible = False
            End If


        End Set
    End Property
    Public Sub New(ByVal PathwayDataFile As String, ByVal PromptForUserInput As Boolean, ByVal InterferenceThreshold As Integer, ByVal BitmapFile As String, ByVal StartPosition As eSTARTPOSITIONS, ByVal Style As eSTYLE)
        InitializeComponent()
        Me._PathwayDataFile = PathwayDataFile
        Me._PromptForUserInput = PromptForUserInput
        Me._InterferenceThreshold = InterferenceThreshold
        Me._BitmapImage = BitmapFile
        Me._Style = Style

        Me.drawingBitmap = New Bitmap(X_DIMENSION, Y_DIMENSION)
        g = Graphics.FromImage(drawingBitmap)

        'Me.picTarget.Image = Image.FromFile(IMG)
        For i As Integer = 0 To X_DIMENSION - 1
            For j As Integer = 0 To Y_DIMENSION - 1
                canvasData(i, j) = New Coordinate
                canvasData(i, j).X = i
                canvasData(i, j).Y = j
            Next
        Next

        Select Case StartPosition
            Case eSTARTPOSITIONS.UL
                Me.penXPos = 0
                Me.penYPos = 0
            Case eSTARTPOSITIONS.UM
                Me.penXPos = CInt(X_DIMENSION / 2)
                Me.penYPos = 0
            Case eSTARTPOSITIONS.UR
                Me.penXPos = X_DIMENSION - 1
                Me.penYPos = 0
            Case eSTARTPOSITIONS.ML
                Me.penXPos = 0
                Me.penYPos = CInt(Y_DIMENSION / 2)
            Case eSTARTPOSITIONS.MM
                Me.penXPos = CInt(X_DIMENSION / 2)
                Me.penYPos = CInt(Y_DIMENSION / 2)
            Case eSTARTPOSITIONS.MR
                Me.penXPos = X_DIMENSION - 1
                Me.penYPos = CInt(Y_DIMENSION / 2)
            Case eSTARTPOSITIONS.LL
                Me.penXPos = 0
                Me.penYPos = Y_DIMENSION - 1
            Case eSTARTPOSITIONS.LM
                Me.penXPos = CInt(X_DIMENSION / 2)
                Me.penYPos = Y_DIMENSION - 1
            Case eSTARTPOSITIONS.LR
                Me.penXPos = X_DIMENSION - 1
                Me.penYPos = Y_DIMENSION - 1
        End Select
        LoadImageData()
    End Sub





    Private Sub LoadImageData()
        Dim mybitmap As New Bitmap(Me._BitmapImage, False)

        For i As Integer = 0 To mybitmap.Height - 1
            For j As Integer = 0 To mybitmap.Width - 1
                Dim newcoord As Coordinate = canvasData(j, i)
                Dim px As System.Drawing.Color = mybitmap.GetPixel(j, i)
                If px.GetBrightness = Color.Black.GetBrightness Then
                    newcoord.PaintPassesNeeded = 1
                    totalPixelsNeedingPaint = totalPixelsNeedingPaint + 1
                    'ElseIf px.GetBrightness > Color.Black.GetBrightness And px.GetBrightness < Color.White.GetBrightness Then
                    '    newcoord.PaintPassesNeeded = 1
                    '    totalPixelsNeedingPaint = totalPixelsNeedingPaint + 1
                End If
            Next
        Next

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Arduino.Close()
    End Sub


    Private Function GetImageDisruptionRanking(ByVal StartX As Integer, ByVal StartY As Integer, ByVal EndX As Integer, ByVal EndY As Integer)
        Dim ranking As Integer = 0
        Dim nextX As Integer = StartX
        Dim nextY As Integer = StartY

        'if its immediately adjacent then run this loop 
        If Math.Abs(nextX - EndX) <= 1 And Math.Abs(nextY - EndY) <= 1 Then
            Return 0
        End If

        Do Until nextX = EndX And nextY = EndY
            If nextX < EndX Then
                nextX = nextX + 1
            ElseIf nextX > EndX Then
                nextX = nextX - 1
            End If

            If nextY < EndY Then
                nextY = nextY + 1
            ElseIf nextY > EndY Then
                nextY = nextY - 1
            End If

            If canvasData(nextX, nextY).PaintPassesNeeded = 0 Then
                ranking = ranking + 1
            End If
        Loop

        Return ranking

    End Function
    Private Function FindImmediatelyAdjacentUnpaintedPixel(ByVal X As Integer, ByVal Y As Integer) As Coordinate
        Dim rv As Coordinate = Nothing

        Dim unpaintedLeft As Boolean
        Dim unpaintedRight As Boolean
        Dim unpaintedAbove As Boolean
        Dim unpaintedBelow As Boolean

        If X = 0 Then
            unpaintedLeft = False
        Else
            If Me.canvasData(X - 1, Y).NeedsPainting Then
                unpaintedLeft = True
            Else
                unpaintedLeft = False
            End If
        End If

        If X = X_DIMENSION - 1 Then
            unpaintedRight = False
        Else
            If Me.canvasData(X + 1, Y).NeedsPainting Then
                unpaintedRight = True
            Else
                unpaintedRight = False
            End If
        End If

        If Y = 0 Then
            unpaintedAbove = False
        Else
            If Me.canvasData(X, Y - 1).NeedsPainting Then
                unpaintedAbove = True
            Else
                unpaintedAbove = False
            End If
        End If

        If Y = Y_DIMENSION - 1 Then
            unpaintedBelow = False
        Else
            If Me.canvasData(X, Y + 1).NeedsPainting Then
                unpaintedBelow = True
            Else
                unpaintedBelow = False
            End If
        End If

        If unpaintedLeft Or unpaintedRight Or unpaintedAbove Or unpaintedBelow Then
            Randomize()
            Do
                Dim randomAdjacency As Integer = CInt(Rnd() * 4) + 1
                If randomAdjacency = 1 And unpaintedLeft Then
                    Return Me.canvasData(X - 1, Y)
                ElseIf randomAdjacency = 2 And unpaintedRight Then
                    Return Me.canvasData(X + 1, Y)
                ElseIf randomAdjacency = 3 And unpaintedAbove Then
                    Return Me.canvasData(X, Y - 1)
                ElseIf randomAdjacency = 4 And unpaintedBelow Then
                    Return Me.canvasData(X, Y + 1)
                End If
            Loop
        Else
            Return Nothing
        End If

    End Function
    Private Function FindNNRandom(ByVal SearchingForPaintedPixels As Boolean, ByVal X As Integer, ByVal Y As Integer) As Coordinate
        'start at X,Y and radiate outwards until we find a painted coordinate
        Dim radius As Integer = 1
        Dim degree As Decimal
        Dim checkX, checkY As Integer
        Dim rankedCoordinates As New ArrayList


        Do
            If SearchingForPaintedPixels Then
                For degree = 0 To 6.283 Step (6.283 / (radius * 4))
                    checkX = CInt(radius * Math.Sin(degree)) + X
                    checkY = CInt(radius * Math.Cos(degree)) + Y
                    If checkX > X_DIMENSION - 1 Then checkX = X_DIMENSION - 1
                    If checkY > Y_DIMENSION - 1 Then checkY = Y_DIMENSION - 1
                    If checkX < 0 Then checkX = 0
                    If checkY < 0 Then checkY = 0


                    If canvasData(checkX, checkY).PaintPassesMade >= 1 Then
                        Return canvasData(checkX, checkY)
                    End If
                Next
            Else
                Dim rankedCoord As New RankedCoordinate
                'see if the immediately adjacent pixels need painting
                Dim adjacentUnpainted As Coordinate = FindImmediatelyAdjacentUnpaintedPixel(X, Y)
                If Not adjacentUnpainted Is Nothing Then
                    Return adjacentUnpainted
                End If
                For degree = 0 To 6.283 Step (6.283 / (radius * 4))
                    checkX = CInt(radius * Math.Sin(degree)) + X
                    checkY = CInt(radius * Math.Cos(degree)) + Y
                    If checkX > X_DIMENSION - 1 Then checkX = X_DIMENSION - 1
                    If checkY > Y_DIMENSION - 1 Then checkY = Y_DIMENSION - 1
                    If checkX < 0 Then checkX = 0
                    If checkY < 0 Then checkY = 0
                    'System.Threading.Thread.Sleep(10)


                    If canvasData(checkX, checkY).NeedsPainting Then
                        'g.DrawRectangle(Pens.Aqua, checkX, checkY, 1, 1)
                        rankedCoord.X = checkX
                        rankedCoord.Y = checkY
                        rankedCoord.Rank = GetImageDisruptionRanking(X, Y, checkX, checkY)
                        If rankedCoord.Rank = 0 Then
                            Return canvasData(checkX, checkY)
                        Else
                            rankedCoordinates.Add(rankedCoord)
                        End If

                        If rankedCoordinates.Count > 250 Then
                            rankedCoordinates.Sort()
                            Dim targetCoord = canvasData(rankedCoordinates(0).x, rankedCoordinates(0).y)
                            If Me._PromptForUserInput And CType(rankedCoordinates(0), RankedCoordinate).Rank > Me._InterferenceThreshold Then
                                Me.UserAssistance = True
                                Dim targetPicGraphics As Graphics = Me.picTarget.CreateGraphics
                                targetPicGraphics.DrawEllipse(Me._QueriedPositionPen, rankedCoordinates(0).x, rankedCoordinates(0).y, 4, 4)
                                targetPicGraphics.DrawEllipse(Me._PenPositionPen, Me.penXPos, Me.penYPos, 4, 4)
                                Me.lblUserAssistance3.Text = CType(rankedCoordinates(0), RankedCoordinate).Rank
                                _UserAssistanceQueryX = targetCoord.x
                                _UserAssistanceQueryY = targetCoord.y
                                Return Nothing
                            Else
                                Return targetCoord
                            End If

                        End If
                    Else
                        'g.DrawRectangle(Pens.Maroon, checkX, checkY, 1, 1)
                    End If

                    If radius = X_DIMENSION Then
                        rankedCoordinates.Sort()
                        If rankedCoordinates.Count = 0 Then
                            Me.TimerPulse.Enabled = False
                            Me.btnBegin.Visible = True
                            If Me._PathwayDataFile <> "" Then
                                Me.SaveTextToFile(Me._PathwayData.ToString, Me._PathwayDataFile)
                            End If
                            Me.Close()
                            Return Nothing
                        End If
                        Dim targetCoord = canvasData(rankedCoordinates(0).x, rankedCoordinates(0).y)
                        If Me._PromptForUserInput And CType(rankedCoordinates(0), RankedCoordinate).Rank > Me._InterferenceThreshold Then
                            Me.UserAssistance = True
                            Dim targetPicGraphics As Graphics = Me.picTarget.CreateGraphics
                            targetPicGraphics.DrawEllipse(Me._QueriedPositionPen, rankedCoordinates(0).x, rankedCoordinates(0).y, 3, 3)
                            targetPicGraphics.DrawEllipse(Me._PenPositionPen, Me.penXPos, Me.penYPos, 3, 3)
                            Me.lblUserAssistance3.Text = CType(rankedCoordinates(0), RankedCoordinate).Rank
                            _UserAssistanceQueryX = targetCoord.x
                            _UserAssistanceQueryY = targetCoord.y
                            Return Nothing
                        Else
                            Return targetCoord
                        End If

                    End If
                Next
            End If

            radius = radius + 1

            If radius > X_DIMENSION Then Return Nothing
        Loop

    End Function
    Public Sub SaveTextToFile(ByVal strData As String, _
        ByVal FullPath As String)

        Dim sw As StreamWriter
        Try
            sw = New StreamWriter(FullPath)
            sw.Write(strData)
            sw.Close()

        Catch Ex As Exception
        End Try

    End Sub

    Private Function FindNNVertical(ByVal X As Integer, ByVal Y As Integer) As Coordinate
        If Me._CurrentMicroDirection = eDIRECTION.UP Then
            If Y = 0 Then
                If Me._CurrentMacroDirection = eDIRECTION.RIGHT Then
                    If X = X_DIMENSION Then
                        GoTo Radiate
                    Else
                        If canvasData(X + 1, Y).NeedsPainting Then
                            Me._CurrentMicroDirection = eDIRECTION.DOWN
                            Return canvasData(X + 1, Y)
                        Else
                            GoTo Radiate
                        End If
                    End If
                ElseIf Me._CurrentMacroDirection = eDIRECTION.LEFT Then
                    If X = 0 Then
                        GoTo Radiate
                    Else
                        If canvasData(X - 1, Y).NeedsPainting Then
                            Me._CurrentMicroDirection = eDIRECTION.DOWN
                            Return canvasData(X - 1, Y)
                        Else
                            GoTo radiate
                        End If
                    End If
                End If
            Else
                If canvasData(X, Y - 1).NeedsPainting Then
                    Return canvasData(X, Y - 1)
                Else
                    GoTo Radiate
                End If
            End If
        ElseIf Me._CurrentMicroDirection = eDIRECTION.DOWN Then
            If Y = Y_DIMENSION Then
                If Me._CurrentMacroDirection = eDIRECTION.RIGHT Then
                    If X = X_DIMENSION Then
                        GoTo Radiate
                    Else
                        If canvasData(X + 1, Y).NeedsPainting Then
                            Me._CurrentMicroDirection = eDIRECTION.UP
                            Return canvasData(X + 1, Y)
                        Else
                            GoTo Radiate
                        End If
                    End If
                ElseIf Me._CurrentMacroDirection = eDIRECTION.LEFT Then
                    If X = 0 Then
                        GoTo Radiate
                    Else
                        If canvasData(X - 1, Y).NeedsPainting Then
                            Me._CurrentMicroDirection = eDIRECTION.UP
                            Return canvasData(X - 1, Y)
                        Else
                            GoTo radiate
                        End If
                    End If
                End If
            Else
                If canvasData(X, Y + 1).NeedsPainting Then
                    Return canvasData(X, Y + 1)
                Else
                    GoTo Radiate
                End If
            End If
        End If


Radiate:
        Dim radius As Integer = 1
        Dim degree As Decimal
        Dim checkX, checkY As Integer
        Dim rankedCoordinates As New ArrayList
        Dim rankedCoord As New RankedCoordinate

        Do

            For degree = 0 To 6.283 Step (6.283 / (radius * 4))
                checkX = CInt(radius * Math.Sin(degree)) + X
                checkY = CInt(radius * Math.Cos(degree)) + Y
                If checkX > X_DIMENSION - 1 Then checkX = X_DIMENSION - 1
                If checkY > Y_DIMENSION - 1 Then checkY = Y_DIMENSION - 1
                If checkX < 0 Then checkX = 0
                If checkY < 0 Then checkY = 0
                'System.Threading.Thread.Sleep(10)


                If canvasData(checkX, checkY).NeedsPainting Then
                    'g.DrawRectangle(Pens.Aqua, checkX, checkY, 1, 1)
                    rankedCoord.X = checkX
                    rankedCoord.Y = checkY
                    rankedCoord.Rank = GetImageDisruptionRanking(X, Y, checkX, checkY)
                    If rankedCoord.Rank = 0 Then
                        Return canvasData(checkX, checkY)
                    Else
                        rankedCoordinates.Add(rankedCoord)
                    End If

                    If rankedCoordinates.Count > 250 Then
                        rankedCoordinates.Sort()
                        Dim targetCoord = canvasData(rankedCoordinates(0).x, rankedCoordinates(0).y)
                        If Me._PromptForUserInput And CType(rankedCoordinates(0), RankedCoordinate).Rank > Me._InterferenceThreshold Then
                            Me.UserAssistance = True
                            Dim targetPicGraphics As Graphics = Me.picTarget.CreateGraphics
                            targetPicGraphics.DrawEllipse(Me._QueriedPositionPen, rankedCoordinates(0).x, rankedCoordinates(0).y, 4, 4)
                            targetPicGraphics.DrawEllipse(Me._PenPositionPen, Me.penXPos, Me.penYPos, 4, 4)
                            Me.lblUserAssistance3.Text = CType(rankedCoordinates(0), RankedCoordinate).Rank
                            _UserAssistanceQueryX = targetCoord.x
                            _UserAssistanceQueryY = targetCoord.y
                            Return Nothing
                        Else
                            Return targetCoord
                        End If

                    End If
                Else
                    'g.DrawRectangle(Pens.Maroon, checkX, checkY, 1, 1)
                End If

                If radius = X_DIMENSION Then
                    rankedCoordinates.Sort()
                    If rankedCoordinates.Count = 0 Then
                        Me.TimerPulse.Enabled = False
                        Me.btnBegin.Visible = True
                        If Me._PathwayDataFile <> "" Then
                            Me.SaveTextToFile(Me._PathwayData.ToString, Me._PathwayDataFile)
                        End If
                        Me.Close()
                        Return Nothing
                    End If
                    Dim targetCoord = canvasData(rankedCoordinates(0).x, rankedCoordinates(0).y)
                    If Me._PromptForUserInput And CType(rankedCoordinates(0), RankedCoordinate).Rank > Me._InterferenceThreshold Then
                        Me.UserAssistance = True
                        Dim targetPicGraphics As Graphics = Me.picTarget.CreateGraphics
                        targetPicGraphics.DrawEllipse(Me._QueriedPositionPen, rankedCoordinates(0).x, rankedCoordinates(0).y, 3, 3)
                        targetPicGraphics.DrawEllipse(Me._PenPositionPen, Me.penXPos, Me.penYPos, 3, 3)
                        Me.lblUserAssistance3.Text = CType(rankedCoordinates(0), RankedCoordinate).Rank
                        _UserAssistanceQueryX = targetCoord.x
                        _UserAssistanceQueryY = targetCoord.y
                        Return Nothing
                    Else
                        Return targetCoord
                    End If

                End If
            Next

            radius = radius + 1
        Loop

        'Return Nothing
    End Function


    Private Sub TimerPulse_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimerPulse.Tick
        Dim gotoCoord As Coordinate
        If _OverrideMode Then
            gotoCoord = canvasData(_OverrideX, _OverrideY)
            PulseMovePenTo(gotoCoord.X, gotoCoord.Y)
            _OverrideMode = False
        Else
            If Me.Style = eSTYLE.RANDOM Then
                gotoCoord = FindNNRandom(False, Me.penXPos, Me.penYPos)
            ElseIf Me.Style = eSTYLE.VERTICAL Then
                gotoCoord = FindNNVertical(Me.penXPos, Me.penYPos)
            End If

            If Not gotoCoord Is Nothing Then
                PulseMovePenTo(gotoCoord.X, gotoCoord.Y)
            End If
        End If


        Me.picCanvas.BackgroundImage = Me.drawingBitmap
        Me._Cycles = Me._Cycles + 1
        If _Cycles = _CyclesBetweenReEvaluation Then
            _Cycles = 0
            Me.ReEvaluateUnpainted()
        End If
    End Sub

    Private Sub PulseMovePenTo(ByVal X As Integer, ByVal Y As Integer)
        Dim steps As Integer = 0
        Do Until penXPos = X And penYPos = Y
            If X > Me.penXPos Then
                Pulse("X", eKNOBSTATES.CW)
                steps = steps + 1
            ElseIf X < Me.penXPos Then
                Pulse("X", eKNOBSTATES.CCW)
                steps = steps + 1
            End If

            If Y > Me.penYPos Then
                Pulse("Y", eKNOBSTATES.CW)
                steps = steps + 1
            ElseIf Y < Me.penYPos Then
                Pulse("Y", eKNOBSTATES.CCW)
                steps = steps + 1
            End If
        Loop
    End Sub

    Private Sub Pulse(ByVal Axis As String, ByVal Direction As eKNOBSTATES)
        Me.lblPenPos.Text = "(" & Me.penXPos & ", " & Me.penYPos & ")"
        Dim newXPos As Integer = Me.penXPos
        Dim newYPos As Integer = Me.penYPos
        If _LastTick = 0 Then
            _LastTick = Now.Ticks
        End If
        Dim thisTick As Long = Now.Ticks
        If thisTick - _LastTick > 10000000 Then
            Me.lblPPS.Text = _PulseCount
            _PulseCount = 0
            _LastTick = thisTick
        End If
        _PulseCount = _PulseCount + 1





        If Axis = "X" Then
            If Direction = eKNOBSTATES.CW Then
                newXPos = Me.penXPos + 1
                Me._PathwayData.Append("D")
                Me._lastXDirection = eKNOBSTATES.CW
            ElseIf Direction = eKNOBSTATES.CCW Then
                newXPos = Me.penXPos - 1
                Me._PathwayData.Append("C")
                Me._lastXDirection = eKNOBSTATES.CCW
            End If
        End If

        If Axis = "Y" Then
            If Direction = eKNOBSTATES.CW Then
                newYPos = Me.penYPos + 1
                Me._PathwayData.Append("B")
                Me._lastYDirection = eKNOBSTATES.CW
            ElseIf Direction = eKNOBSTATES.CCW Then
                newYPos = Me.penYPos - 1
                Me._PathwayData.Append("A")
                Me._lastYDirection = eKNOBSTATES.CCW
            End If
        End If

        If canvasData(penXPos, penYPos).PaintPassesMade = 1 Then
            'g.DrawLine(graypen, penXPos, penYPos, newXPos, newYPos)
            'Else
            g.DrawLine(blackpen, penXPos, penYPos, newXPos, newYPos)
        End If

        Me.picCanvas.BackgroundImage = Me.drawingBitmap
        Me.picCanvas.Refresh()

        Me.penXPos = newXPos
        Me.penYPos = newYPos

        If penYPos < 0 Or penYPos > Y_DIMENSION - 1 Or penXPos < 0 Or penXPos > X_DIMENSION - 1 Then
            Exit Sub
        End If


        canvasData(penXPos, penYPos).PaintPassesMade = canvasData(penXPos, penYPos).PaintPassesMade + 1
        If canvasData(penXPos, penYPos).PaintPassesMade = canvasData(penXPos, penYPos).PaintPassesNeeded Then
            totalPixelsNeedingPaint = totalPixelsNeedingPaint - 1
        End If


    End Sub


    Private Sub picTarget_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picTarget.MouseUp
        If Me.grpUserAssistanceNeeded.Visible Then
            Me.picTarget.Image = Image.FromFile(Me._BitmapImage)
            Me.grpUserAssistanceNeeded.Visible = False
            pnlUserInputInstructions.Visible = False
            If Me.TimerPulse.Enabled = False Then
                _OverrideMode = True
                _OverrideX = e.X
                _OverrideY = e.Y
                Me.TimerPulse.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkip.Click
        Me.picTarget.Image = Image.FromFile(Me._BitmapImage)
        Me.canvasData(_UserAssistanceQueryX, _UserAssistanceQueryY).PaintPassesMade = Me.canvasData(_UserAssistanceQueryX, _UserAssistanceQueryY).PaintPassesMade + 1
        Me.grpUserAssistanceNeeded.Visible = False
        pnlUserInputInstructions.Visible = False
        Me.TimerPulse.Enabled = True
    End Sub

    Private Sub btnUseSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUseProposed.Click
        Me.picTarget.Image = Image.FromFile(Me._BitmapImage)
        _OverrideMode = True
        _OverrideX = _UserAssistanceQueryX
        _OverrideY = _UserAssistanceQueryY
        Me.TimerPulse.Enabled = True
        Me.grpUserAssistanceNeeded.Visible = False
        pnlUserInputInstructions.Visible = False
        Me.TimerPulse.Enabled = True
    End Sub

    Private Sub ReEvaluateUnpainted()
        'For i As Integer = 1 To X_DIMENSION - 2
        '    For j As Integer = 1 To Y_DIMENSION - 2
        '        If Me.canvasData(i, j).NeedsPainting Then
        '            If Not Me.canvasData(i - 1, j).NeedsPainting And Not Me.canvasData(i + 1, j).NeedsPainting And _
        '               Not Me.canvasData(i, j - 1).NeedsPainting And Not Me.canvasData(i, j + 1).NeedsPainting Then
        '                canvasData(i, j).PaintPassesMade = canvasData(i, j).PaintPassesNeeded
        '            End If
        '        End If
        '    Next
        'Next
        'RefreshRemaining()
    End Sub
    Private Sub LoadImage(ByVal filepath As String)

        Me.picTarget.Image = Image.FromFile(Me._BitmapImage)
        For i As Integer = 0 To X_DIMENSION - 1
            For j As Integer = 0 To Y_DIMENSION - 1
                canvasData(i, j) = New Coordinate
                canvasData(i, j).X = i
                canvasData(i, j).Y = j
            Next
        Next

        LoadImageData()
    End Sub

    Private Sub RefreshRemaining()
        Dim count As Integer = 0
        For i As Integer = 0 To X_DIMENSION - 1
            For j As Integer = 0 To Y_DIMENSION - 1
                If canvasData(i, j).NeedsPainting = True Then
                    count = count + 1
                End If
            Next
        Next
        Me.lblRemaining.Text = count
        Application.DoEvents()
    End Sub

    Private Sub BeginAutomationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBegin.Click
        Me.TimerPulse.Enabled = True
        Me.btnBegin.Visible = False
    End Sub


    Private Sub UpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpToolStripMenuItem.Click
        Pulse("Y", eKNOBSTATES.CCW)
    End Sub

    Private Sub DownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownToolStripMenuItem.Click
        Pulse("Y", eKNOBSTATES.CW)
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        Pulse("X", eKNOBSTATES.CCW)
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        Pulse("X", eKNOBSTATES.CW)
    End Sub



    Private Sub btnSkipAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkipAll.Click
        For i As Integer = 0 To X_DIMENSION - 1
            For j As Integer = 0 To Y_DIMENSION - 1
                canvasData(i, j).PaintPassesMade = canvasData(i, j).PaintPassesMade + 1
            Next
        Next
        Me.grpUserAssistanceNeeded.Visible = False
        pnlUserInputInstructions.Visible = False

        Me.TimerPulse.Enabled = True

    End Sub

    Private Sub frmCreatePathway_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.picTarget.Image = Image.FromFile(Me._BitmapImage)
    End Sub
End Class



