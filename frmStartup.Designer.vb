<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStartup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStartup))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkStartLL = New System.Windows.Forms.CheckBox
        Me.chkStartML = New System.Windows.Forms.CheckBox
        Me.chkStartUL = New System.Windows.Forms.CheckBox
        Me.chkStartLM = New System.Windows.Forms.CheckBox
        Me.chkStartMM = New System.Windows.Forms.CheckBox
        Me.chkStartLR = New System.Windows.Forms.CheckBox
        Me.chkStartMR = New System.Windows.Forms.CheckBox
        Me.chkStartUR = New System.Windows.Forms.CheckBox
        Me.chkStartUM = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSavePathwayFile = New System.Windows.Forms.TextBox
        Me.btnLaunchCreatePathway = New System.Windows.Forms.Button
        Me.lblInterferenceThresholdValue = New System.Windows.Forms.Label
        Me.tbrInterference = New System.Windows.Forms.TrackBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkPromptForUserInput = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBitmapFile = New System.Windows.Forms.TextBox
        Me.btnBrowseBitmap = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtPathwayFile = New System.Windows.Forms.TextBox
        Me.btnBrowsePathway = New System.Windows.Forms.Button
        Me.txtComPort = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.cboStyle = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbrInterference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStyle)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chkStartLL)
        Me.GroupBox1.Controls.Add(Me.chkStartML)
        Me.GroupBox1.Controls.Add(Me.chkStartUL)
        Me.GroupBox1.Controls.Add(Me.chkStartLM)
        Me.GroupBox1.Controls.Add(Me.chkStartMM)
        Me.GroupBox1.Controls.Add(Me.chkStartLR)
        Me.GroupBox1.Controls.Add(Me.chkStartMR)
        Me.GroupBox1.Controls.Add(Me.chkStartUR)
        Me.GroupBox1.Controls.Add(Me.chkStartUM)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSavePathwayFile)
        Me.GroupBox1.Controls.Add(Me.btnLaunchCreatePathway)
        Me.GroupBox1.Controls.Add(Me.lblInterferenceThresholdValue)
        Me.GroupBox1.Controls.Add(Me.tbrInterference)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkPromptForUserInput)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBitmapFile)
        Me.GroupBox1.Controls.Add(Me.btnBrowseBitmap)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 291)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create Pathway"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(360, 85)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'chkStartLL
        '
        Me.chkStartLL.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartLL.Location = New System.Drawing.Point(96, 259)
        Me.chkStartLL.Name = "chkStartLL"
        Me.chkStartLL.Size = New System.Drawing.Size(18, 18)
        Me.chkStartLL.TabIndex = 57
        Me.chkStartLL.UseVisualStyleBackColor = True
        '
        'chkStartML
        '
        Me.chkStartML.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartML.Location = New System.Drawing.Point(96, 235)
        Me.chkStartML.Name = "chkStartML"
        Me.chkStartML.Size = New System.Drawing.Size(18, 18)
        Me.chkStartML.TabIndex = 56
        Me.chkStartML.UseVisualStyleBackColor = True
        '
        'chkStartUL
        '
        Me.chkStartUL.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartUL.Checked = True
        Me.chkStartUL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkStartUL.Location = New System.Drawing.Point(96, 214)
        Me.chkStartUL.Name = "chkStartUL"
        Me.chkStartUL.Size = New System.Drawing.Size(18, 18)
        Me.chkStartUL.TabIndex = 55
        Me.chkStartUL.UseVisualStyleBackColor = True
        '
        'chkStartLM
        '
        Me.chkStartLM.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartLM.Location = New System.Drawing.Point(120, 259)
        Me.chkStartLM.Name = "chkStartLM"
        Me.chkStartLM.Size = New System.Drawing.Size(18, 18)
        Me.chkStartLM.TabIndex = 54
        Me.chkStartLM.UseVisualStyleBackColor = True
        '
        'chkStartMM
        '
        Me.chkStartMM.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartMM.Location = New System.Drawing.Point(120, 235)
        Me.chkStartMM.Name = "chkStartMM"
        Me.chkStartMM.Size = New System.Drawing.Size(18, 18)
        Me.chkStartMM.TabIndex = 53
        Me.chkStartMM.UseVisualStyleBackColor = True
        '
        'chkStartLR
        '
        Me.chkStartLR.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartLR.Location = New System.Drawing.Point(144, 259)
        Me.chkStartLR.Name = "chkStartLR"
        Me.chkStartLR.Size = New System.Drawing.Size(18, 18)
        Me.chkStartLR.TabIndex = 52
        Me.chkStartLR.UseVisualStyleBackColor = True
        '
        'chkStartMR
        '
        Me.chkStartMR.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartMR.Location = New System.Drawing.Point(144, 235)
        Me.chkStartMR.Name = "chkStartMR"
        Me.chkStartMR.Size = New System.Drawing.Size(18, 18)
        Me.chkStartMR.TabIndex = 51
        Me.chkStartMR.UseVisualStyleBackColor = True
        '
        'chkStartUR
        '
        Me.chkStartUR.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartUR.Location = New System.Drawing.Point(144, 214)
        Me.chkStartUR.Name = "chkStartUR"
        Me.chkStartUR.Size = New System.Drawing.Size(18, 18)
        Me.chkStartUR.TabIndex = 50
        Me.chkStartUR.UseVisualStyleBackColor = True
        '
        'chkStartUM
        '
        Me.chkStartUM.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkStartUM.Location = New System.Drawing.Point(120, 214)
        Me.chkStartUM.Name = "chkStartUM"
        Me.chkStartUM.Size = New System.Drawing.Size(18, 18)
        Me.chkStartUM.TabIndex = 49
        Me.chkStartUM.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Start Position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Save PTH File:"
        '
        'txtSavePathwayFile
        '
        Me.txtSavePathwayFile.Location = New System.Drawing.Point(3, 159)
        Me.txtSavePathwayFile.Name = "txtSavePathwayFile"
        Me.txtSavePathwayFile.Size = New System.Drawing.Size(283, 20)
        Me.txtSavePathwayFile.TabIndex = 1
        '
        'btnLaunchCreatePathway
        '
        Me.btnLaunchCreatePathway.Location = New System.Drawing.Point(292, 254)
        Me.btnLaunchCreatePathway.Name = "btnLaunchCreatePathway"
        Me.btnLaunchCreatePathway.Size = New System.Drawing.Size(75, 23)
        Me.btnLaunchCreatePathway.TabIndex = 4
        Me.btnLaunchCreatePathway.Text = "Next"
        Me.btnLaunchCreatePathway.UseVisualStyleBackColor = True
        '
        'lblInterferenceThresholdValue
        '
        Me.lblInterferenceThresholdValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInterferenceThresholdValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterferenceThresholdValue.Location = New System.Drawing.Point(335, 206)
        Me.lblInterferenceThresholdValue.Name = "lblInterferenceThresholdValue"
        Me.lblInterferenceThresholdValue.Size = New System.Drawing.Size(31, 27)
        Me.lblInterferenceThresholdValue.TabIndex = 43
        Me.lblInterferenceThresholdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbrInterference
        '
        Me.tbrInterference.Location = New System.Drawing.Point(202, 206)
        Me.tbrInterference.Maximum = 200
        Me.tbrInterference.Minimum = 1
        Me.tbrInterference.Name = "tbrInterference"
        Me.tbrInterference.Size = New System.Drawing.Size(127, 45)
        Me.tbrInterference.TabIndex = 3
        Me.tbrInterference.TickFrequency = 20
        Me.tbrInterference.Value = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Interference Threshold:"
        '
        'chkPromptForUserInput
        '
        Me.chkPromptForUserInput.AutoSize = True
        Me.chkPromptForUserInput.Checked = True
        Me.chkPromptForUserInput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPromptForUserInput.Location = New System.Drawing.Point(5, 185)
        Me.chkPromptForUserInput.Name = "chkPromptForUserInput"
        Me.chkPromptForUserInput.Size = New System.Drawing.Size(129, 17)
        Me.chkPromptForUserInput.TabIndex = 2
        Me.chkPromptForUserInput.Text = "Prompt For User Input"
        Me.chkPromptForUserInput.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Load Bitmap:"
        '
        'txtBitmapFile
        '
        Me.txtBitmapFile.Location = New System.Drawing.Point(3, 117)
        Me.txtBitmapFile.Name = "txtBitmapFile"
        Me.txtBitmapFile.Size = New System.Drawing.Size(283, 20)
        Me.txtBitmapFile.TabIndex = 0
        '
        'btnBrowseBitmap
        '
        Me.btnBrowseBitmap.Location = New System.Drawing.Point(292, 115)
        Me.btnBrowseBitmap.Name = "btnBrowseBitmap"
        Me.btnBrowseBitmap.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseBitmap.TabIndex = 0
        Me.btnBrowseBitmap.Text = "Browse"
        Me.btnBrowseBitmap.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.txtPathwayFile)
        Me.GroupBox2.Controls.Add(Me.btnBrowsePathway)
        Me.GroupBox2.Controls.Add(Me.txtComPort)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 309)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 127)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Load Pathway"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(144, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "9600-N-8-1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Load PTH file:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(295, 98)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtPathwayFile
        '
        Me.txtPathwayFile.Location = New System.Drawing.Point(6, 42)
        Me.txtPathwayFile.Name = "txtPathwayFile"
        Me.txtPathwayFile.Size = New System.Drawing.Size(283, 20)
        Me.txtPathwayFile.TabIndex = 0
        '
        'btnBrowsePathway
        '
        Me.btnBrowsePathway.Location = New System.Drawing.Point(295, 40)
        Me.btnBrowsePathway.Name = "btnBrowsePathway"
        Me.btnBrowsePathway.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePathway.TabIndex = 2
        Me.btnBrowsePathway.Text = "Browse"
        Me.btnBrowsePathway.UseVisualStyleBackColor = True
        '
        'txtComPort
        '
        Me.txtComPort.Location = New System.Drawing.Point(68, 68)
        Me.txtComPort.Name = "txtComPort"
        Me.txtComPort.Size = New System.Drawing.Size(70, 20)
        Me.txtComPort.TabIndex = 1
        Me.txtComPort.Text = "COM4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "COM Port:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cboStyle
        '
        Me.cboStyle.FormattingEnabled = True
        Me.cboStyle.Items.AddRange(New Object() {"Random", "Vertical", "Horizontal"})
        Me.cboStyle.Location = New System.Drawing.Point(190, 254)
        Me.cboStyle.Name = "cboStyle"
        Me.cboStyle.Size = New System.Drawing.Size(96, 21)
        Me.cboStyle.TabIndex = 59
        '
        'frmStartup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 448)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStartup"
        Me.Text = "frmStartup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbrInterference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPromptForUserInput As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBitmapFile As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseBitmap As System.Windows.Forms.Button
    Friend WithEvents btnLaunchCreatePathway As System.Windows.Forms.Button
    Friend WithEvents lblInterferenceThresholdValue As System.Windows.Forms.Label
    Friend WithEvents tbrInterference As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtPathwayFile As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowsePathway As System.Windows.Forms.Button
    Friend WithEvents txtComPort As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSavePathwayFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkStartLL As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartML As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartUL As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartLM As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartMM As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartLR As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartMR As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartUR As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartUM As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboStyle As System.Windows.Forms.ComboBox
End Class
