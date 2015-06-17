Public Class frmStartup


    Private Sub btnLaunchCreatePathway_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunchCreatePathway.Click
        'todo: verify dimensions 400w x 300h

        Dim PathwayDataFile As String = Me.txtSavePathwayFile.Text
        Dim BitmapFile As String = Me.txtBitmapFile.Text
        Dim startposition As frmCreatePathway.eSTARTPOSITIONS
        If Me.chkStartUL.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.UL
        If Me.chkStartUM.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.UM
        If Me.chkStartUR.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.UR
        If Me.chkStartML.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.ML
        If Me.chkStartMM.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.MM
        If Me.chkStartMR.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.MR
        If Me.chkStartLL.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.LL
        If Me.chkStartLM.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.LM
        If Me.chkStartLR.Checked Then startposition = frmCreatePathway.eSTARTPOSITIONS.LR

        Dim style As frmCreatePathway.eSTYLE
        If Me.cboStyle.SelectedItem = "Random" Then style = frmCreatePathway.eSTYLE.RANDOM
        If Me.cboStyle.SelectedItem = "Horizontal" Then style = frmCreatePathway.eSTYLE.HORIZONTAL
        If Me.cboStyle.SelectedItem = "Vertical" Then style = frmCreatePathway.eSTYLE.VERTICAL

        Dim createPathway As New frmCreatePathway(PathwayDataFile, Me.chkPromptForUserInput.Checked, Me.lblInterferenceThresholdValue.Text, BitmapFile, startposition, style)
        createPathway.Show(Me)
    End Sub

    Private Sub btnBrowseBitmap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseBitmap.Click
        OpenFileDialog1.Filter = "Bitmap files (*.bmp)|(*.bmp)"
        OpenFileDialog1.FileName = "*.bmp"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtBitmapFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub tbrInterference_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbrInterference.Scroll        
        Me.lblInterferenceThresholdValue.Text = Me.tbrInterference.Value
    End Sub

    Private Sub frmStartup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblInterferenceThresholdValue.Text = 10
        Me.tbrInterference.Value = 10
        Me.cboStyle.SelectedIndex = 0
    End Sub

    Private Sub btnBrowsePathway_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePathway.Click
        OpenFileDialog1.Filter = "Pathway files (*.pth)|(*.pth)"
        OpenFileDialog1.FileName = "*.pth"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.txtPathwayFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim runPath As New frmRunPath(Me.txtPathwayFile.Text, Me.txtComPort.Text)
        runPath.Show(Me)
    End Sub

    Private Sub chkStartUM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartUM.CheckedChanged
        If chkStartUM.Checked Then
            Me.chkStartUL.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub chkStartUL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartUL.CheckedChanged
        If chkStartUL.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub txtBitmapFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBitmapFile.TextChanged
        Me.txtSavePathwayFile.Text = Me.txtBitmapFile.Text.Replace(".bmp", ".pth")
    End Sub

    Private Sub chkStartUR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartUR.CheckedChanged
        If chkStartUR.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUL.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub chkStartML_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartML.CheckedChanged
        If chkStartML.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartUL.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub chkStartMM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartMM.CheckedChanged
        If chkStartMM.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartUL.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub chkStartMR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartMR.CheckedChanged
        If chkStartMR.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartUL.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub chkStartLL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartLL.CheckedChanged
        If chkStartLL.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartUL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub chkStartLM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartLM.CheckedChanged
        If chkStartLM.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartUL.Checked = False
            Me.chkStartLR.Checked = False
        End If
    End Sub

    Private Sub chkStartLR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartLR.CheckedChanged
        If chkStartLR.Checked Then
            Me.chkStartUM.Checked = False
            Me.chkStartUR.Checked = False
            Me.chkStartML.Checked = False
            Me.chkStartMM.Checked = False
            Me.chkStartMR.Checked = False
            Me.chkStartLL.Checked = False
            Me.chkStartLM.Checked = False
            Me.chkStartUL.Checked = False
        End If
    End Sub
End Class