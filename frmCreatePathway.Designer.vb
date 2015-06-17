<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreatePathway
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
        Me.components = New System.ComponentModel.Container()
        Me.picCanvas = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPenPos = New System.Windows.Forms.Label()
        Me.picTarget = New System.Windows.Forms.PictureBox()
        Me.TimerPulse = New System.Windows.Forms.Timer(Me.components)
        Me.lblUserAssistance2 = New System.Windows.Forms.Label()
        Me.lblUserAssistance3 = New System.Windows.Forms.Label()
        Me.grpUserAssistanceNeeded = New System.Windows.Forms.GroupBox()
        Me.btnSkipAll = New System.Windows.Forms.Button()
        Me.btnUseProposed = New System.Windows.Forms.Button()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.lblPPS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLegendRed = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlUserInputInstructions = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRemaining = New System.Windows.Forms.Label()
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUserAssistanceNeeded.SuspendLayout()
        Me.pnlUserInputInstructions.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCanvas
        '
        Me.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picCanvas.Location = New System.Drawing.Point(16, 58)
        Me.picCanvas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picCanvas.Name = "picCanvas"
        Me.picCanvas.Size = New System.Drawing.Size(533, 369)
        Me.picCanvas.TabIndex = 3
        Me.picCanvas.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 592)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Pen Position:"
        '
        'lblPenPos
        '
        Me.lblPenPos.AutoSize = True
        Me.lblPenPos.Location = New System.Drawing.Point(120, 592)
        Me.lblPenPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPenPos.Name = "lblPenPos"
        Me.lblPenPos.Size = New System.Drawing.Size(0, 17)
        Me.lblPenPos.TabIndex = 14
        '
        'picTarget
        '
        Me.picTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picTarget.Location = New System.Drawing.Point(665, 58)
        Me.picTarget.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picTarget.Name = "picTarget"
        Me.picTarget.Size = New System.Drawing.Size(533, 369)
        Me.picTarget.TabIndex = 19
        Me.picTarget.TabStop = False
        '
        'TimerPulse
        '
        Me.TimerPulse.Interval = 1
        '
        'lblUserAssistance2
        '
        Me.lblUserAssistance2.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserAssistance2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserAssistance2.Location = New System.Drawing.Point(8, 20)
        Me.lblUserAssistance2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserAssistance2.Name = "lblUserAssistance2"
        Me.lblUserAssistance2.Size = New System.Drawing.Size(125, 27)
        Me.lblUserAssistance2.TabIndex = 23
        Me.lblUserAssistance2.Text = "Interference:"
        Me.lblUserAssistance2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserAssistance3
        '
        Me.lblUserAssistance3.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserAssistance3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserAssistance3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserAssistance3.Location = New System.Drawing.Point(141, 20)
        Me.lblUserAssistance3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserAssistance3.Name = "lblUserAssistance3"
        Me.lblUserAssistance3.Size = New System.Drawing.Size(85, 27)
        Me.lblUserAssistance3.TabIndex = 24
        Me.lblUserAssistance3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpUserAssistanceNeeded
        '
        Me.grpUserAssistanceNeeded.Controls.Add(Me.btnSkipAll)
        Me.grpUserAssistanceNeeded.Controls.Add(Me.btnUseProposed)
        Me.grpUserAssistanceNeeded.Controls.Add(Me.btnSkip)
        Me.grpUserAssistanceNeeded.Controls.Add(Me.lblUserAssistance2)
        Me.grpUserAssistanceNeeded.Controls.Add(Me.lblUserAssistance3)
        Me.grpUserAssistanceNeeded.Location = New System.Drawing.Point(515, 453)
        Me.grpUserAssistanceNeeded.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUserAssistanceNeeded.Name = "grpUserAssistanceNeeded"
        Me.grpUserAssistanceNeeded.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpUserAssistanceNeeded.Size = New System.Drawing.Size(235, 155)
        Me.grpUserAssistanceNeeded.TabIndex = 25
        Me.grpUserAssistanceNeeded.TabStop = False
        Me.grpUserAssistanceNeeded.Text = "User Assistance"
        Me.grpUserAssistanceNeeded.Visible = False
        '
        'btnSkipAll
        '
        Me.btnSkipAll.Location = New System.Drawing.Point(8, 119)
        Me.btnSkipAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSkipAll.Name = "btnSkipAll"
        Me.btnSkipAll.Size = New System.Drawing.Size(219, 28)
        Me.btnSkipAll.TabIndex = 27
        Me.btnSkipAll.Text = "Skip ALL"
        Me.btnSkipAll.UseVisualStyleBackColor = True
        '
        'btnUseProposed
        '
        Me.btnUseProposed.Location = New System.Drawing.Point(7, 69)
        Me.btnUseProposed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUseProposed.Name = "btnUseProposed"
        Me.btnUseProposed.Size = New System.Drawing.Size(127, 28)
        Me.btnUseProposed.TabIndex = 26
        Me.btnUseProposed.Text = "Use Proposed"
        Me.btnUseProposed.UseVisualStyleBackColor = True
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(141, 69)
        Me.btnSkip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(85, 28)
        Me.btnSkip.TabIndex = 25
        Me.btnSkip.Text = "Skip"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'lblPPS
        '
        Me.lblPPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPS.Location = New System.Drawing.Point(161, 507)
        Me.lblPPS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPPS.Name = "lblPPS"
        Me.lblPPS.Size = New System.Drawing.Size(71, 26)
        Me.lblPPS.TabIndex = 26
        Me.lblPPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 512)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Pulses Per Second:"
        '
        'lblLegendRed
        '
        Me.lblLegendRed.AutoSize = True
        Me.lblLegendRed.BackColor = System.Drawing.Color.Red
        Me.lblLegendRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLegendRed.Location = New System.Drawing.Point(11, 10)
        Me.lblLegendRed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLegendRed.Name = "lblLegendRed"
        Me.lblLegendRed.Size = New System.Drawing.Size(22, 19)
        Me.lblLegendRed.TabIndex = 29
        Me.lblLegendRed.Text = "   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Current Pen Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Proposed Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Cyan
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(11, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 19)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "   "
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(188, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 59)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Click on a location in the image above to move the pen to that location"
        '
        'pnlUserInputInstructions
        '
        Me.pnlUserInputInstructions.Controls.Add(Me.Label6)
        Me.pnlUserInputInstructions.Controls.Add(Me.lblLegendRed)
        Me.pnlUserInputInstructions.Controls.Add(Me.Label4)
        Me.pnlUserInputInstructions.Controls.Add(Me.Label2)
        Me.pnlUserInputInstructions.Controls.Add(Me.Label5)
        Me.pnlUserInputInstructions.Location = New System.Drawing.Point(779, 505)
        Me.pnlUserInputInstructions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlUserInputInstructions.Name = "pnlUserInputInstructions"
        Me.pnlUserInputInstructions.Size = New System.Drawing.Size(409, 76)
        Me.pnlUserInputInstructions.TabIndex = 34
        Me.pnlUserInputInstructions.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 28)
        Me.MenuStrip1.TabIndex = 45
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpToolStripMenuItem, Me.DownToolStripMenuItem, Me.LeftToolStripMenuItem, Me.RightToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.EditToolStripMenuItem.Text = "Pen Control"
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.UpToolStripMenuItem.Text = "Up"
        '
        'DownToolStripMenuItem
        '
        Me.DownToolStripMenuItem.Name = "DownToolStripMenuItem"
        Me.DownToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DownToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.DownToolStripMenuItem.Text = "Down"
        '
        'LeftToolStripMenuItem
        '
        Me.LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        Me.LeftToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LeftToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.LeftToolStripMenuItem.Text = "Left"
        '
        'RightToolStripMenuItem
        '
        Me.RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        Me.RightToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RightToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.RightToolStripMenuItem.Text = "Right"
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(557, 58)
        Me.btnBegin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(100, 28)
        Me.btnBegin.TabIndex = 46
        Me.btnBegin.Text = "BEGIN"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 545)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Remaining:"
        '
        'lblRemaining
        '
        Me.lblRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemaining.Location = New System.Drawing.Point(161, 540)
        Me.lblRemaining.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(71, 26)
        Me.lblRemaining.TabIndex = 47
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCreatePathway
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 629)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.pnlUserInputInstructions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPPS)
        Me.Controls.Add(Me.grpUserAssistanceNeeded)
        Me.Controls.Add(Me.picTarget)
        Me.Controls.Add(Me.lblPenPos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picCanvas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCreatePathway"
        Me.Text = "Form1"
        CType(Me.picCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUserAssistanceNeeded.ResumeLayout(False)
        Me.pnlUserInputInstructions.ResumeLayout(False)
        Me.pnlUserInputInstructions.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPenPos As System.Windows.Forms.Label
    Friend WithEvents picTarget As System.Windows.Forms.PictureBox
    Friend WithEvents TimerPulse As System.Windows.Forms.Timer
    Friend WithEvents lblUserAssistance2 As System.Windows.Forms.Label
    Friend WithEvents lblUserAssistance3 As System.Windows.Forms.Label
    Friend WithEvents grpUserAssistanceNeeded As System.Windows.Forms.GroupBox
    Friend WithEvents btnSkip As System.Windows.Forms.Button
    Friend WithEvents btnUseProposed As System.Windows.Forms.Button
    Friend WithEvents lblPPS As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLegendRed As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlUserInputInstructions As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents UpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents btnSkipAll As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblRemaining As System.Windows.Forms.Label

End Class
