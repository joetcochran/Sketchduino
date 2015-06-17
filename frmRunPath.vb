Imports System.IO
Imports System.Text
Public Class frmRunPath

    Private _PathwayData As New StringBuilder
    Private _ConvertedPathway As New StringBuilder
    Private _Comport As String
    Private _Paused As Boolean

    Public Sub New(ByVal PathwayDataFile As String, ByVal Comport As String)
        InitializeComponent()
        LoadPathway(PathwayDataFile)
        Me._Comport = Comport
    End Sub


    Private Sub LoadPathway(ByVal filename As String)
        Me._PathwayData.Append(GetFileContents(filename))        
    End Sub


    Public Function GetFileContents(ByVal FullPath As String) As String

        Dim strContents As String
        Dim objReader As StreamReader

        objReader = New StreamReader(FullPath)
        strContents = objReader.ReadToEnd()
        objReader.Close()
        Return strContents

    End Function


    Private Sub btnBegin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBegin.Click
        ConvertPathway()

        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Maximum = Me._ConvertedPathway.Length

        Arduino.Comport = Me._Comport
        Arduino.Connect()
        SendSignalBursts()

        Me.btnBegin.Visible = False
    End Sub

    Private Sub ConvertPathway()
        'Y uses A/B commands
        'X uses C/D commands
        Dim lastXCommand As String = ""
        Dim lastYCommand As String = ""
        For Each c As Char In Me._PathwayData.ToString.ToCharArray
            If c = "A" Then
                If lastYCommand <> "A" Then
                    For i As Integer = 1 To Me.nudYPlay.Value
                        Me._ConvertedPathway.Append("A")
                    Next
                End If
                Me._ConvertedPathway.Append("A")
                If Me.optPulse2.Checked Then
                    Me._ConvertedPathway.Append("A")
                End If
                lastYCommand = "A"
            ElseIf c = "B" Then
                If lastYCommand <> "B" Then
                    For i As Integer = 1 To Me.nudYPlay.Value
                        Me._ConvertedPathway.Append("B")
                    Next
                End If
                Me._ConvertedPathway.Append("B")
                If Me.optPulse2.Checked Then
                    Me._ConvertedPathway.Append("B")
                End If
                lastYCommand = "B"
            ElseIf c = "C" Then
                If lastXCommand <> "C" Then
                    For i As Integer = 1 To Me.nudXPlay.Value
                        Me._ConvertedPathway.Append("C")
                    Next
                End If
                Me._ConvertedPathway.Append("C")
                If Me.optPulse2.Checked Then
                    Me._ConvertedPathway.Append("C")
                End If
                lastXCommand = "C"
            ElseIf c = "D" Then
                If lastXCommand <> "D" Then
                    For i As Integer = 1 To Me.nudXPlay.Value
                        Me._ConvertedPathway.Append("D")
                    Next
                End If
                Me._ConvertedPathway.Append("D")
                If Me.optPulse2.Checked Then
                    Me._ConvertedPathway.Append("D")
                End If
                lastXCommand = "D"
            End If
        Next
    End Sub
    Private Sub SendSignalBursts()

        Dim buffer As String

        Do Until Me._ConvertedPathway.ToString = ""
            If Me._Paused Then
                System.Threading.Thread.Sleep(1000)
            End If

            buffer = Microsoft.VisualBasic.Left(Me._ConvertedPathway.ToString(), Me.nudBufferSize.Value)

            Try
                Arduino.SendData(buffer)
            Catch ex As Exception
                Me.Close()
                Exit Sub
            End Try

            If Me._ConvertedPathway.Length < Me.nudBufferSize.Value Then
                Me._ConvertedPathway = New StringBuilder
            Else
                Me._ConvertedPathway.Remove(0, Me.nudBufferSize.Value)
            End If

            Try
                Me.ProgressBar1.Value = Me.ProgressBar1.Value + Me.nudBufferSize.Value
            Catch ex As Exception
            End Try

            Application.DoEvents()

            System.Threading.Thread.Sleep(Me.nudBufferPause.Value)
        Loop
        Me.Close()
    End Sub

    Private Sub frmRunPath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjust.Click
        Me._Paused = Not Me._Paused
        If Me._Paused Then
            Me.btnAdjust.Text = "RESUME"
            Me.btnAdjustUp.Enabled = True
            Me.btnAdjustDown.Enabled = True
            Me.btnAdjustLeft.Enabled = True
            Me.btnAdjustRight.Enabled = True
            Me.btnBufferStep.Enabled = True
        Else
            Me.btnAdjust.Text = "PAUSE/ADJUST"
            Me.btnAdjustUp.Enabled = False
            Me.btnAdjustDown.Enabled = False
            Me.btnAdjustLeft.Enabled = False
            Me.btnAdjustRight.Enabled = False
            Me.btnBufferStep.Enabled = False
        End If
    End Sub

    Private Sub btnAdjustUp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdjustUp.Click
        Arduino.SendData("A")
    End Sub

    Private Sub btnAdjustDown_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdjustDown.Click
        Arduino.SendData("B")
    End Sub

    Private Sub btnAdjustLeft_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdjustLeft.Click
        Arduino.SendData("C")
    End Sub

    Private Sub btnAdjustRight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdjustRight.Click
        Arduino.SendData("D")
    End Sub

    Private Sub btnBufferStep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBufferStep.Click
        Dim buffer As String

        buffer = Microsoft.VisualBasic.Left(Me._ConvertedPathway.ToString(), Me.nudBufferSize.Value)

        Try
            Arduino.SendData(Buffer)
        Catch ex As Exception
            Me.Close()
            Exit Sub
        End Try

        If Me._ConvertedPathway.Length < Me.nudBufferSize.Value Then
            Me._ConvertedPathway = New StringBuilder
        Else
            Me._ConvertedPathway.Remove(0, Me.nudBufferSize.Value)
        End If

        Try
            Me.ProgressBar1.Value = Me.ProgressBar1.Value + Me.nudBufferSize.Value
        Catch ex As Exception
        End Try

    End Sub
End Class