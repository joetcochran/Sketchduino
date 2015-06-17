<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRunPath
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optPulse1 = New System.Windows.Forms.RadioButton()
        Me.optPulse2 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudYPlay = New System.Windows.Forms.NumericUpDown()
        Me.nudXPlay = New System.Windows.Forms.NumericUpDown()
        Me.nudBufferSize = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudBufferPause = New System.Windows.Forms.NumericUpDown()
        Me.btnAdjust = New System.Windows.Forms.Button()
        Me.btnAdjustUp = New System.Windows.Forms.Button()
        Me.btnAdjustDown = New System.Windows.Forms.Button()
        Me.btnAdjustRight = New System.Windows.Forms.Button()
        Me.btnAdjustLeft = New System.Windows.Forms.Button()
        Me.btnBufferStep = New System.Windows.Forms.Button()
        CType(Me.nudYPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBufferSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudBufferPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 222)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(309, 28)
        Me.ProgressBar1.TabIndex = 0
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(128, 186)
        Me.btnBegin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(100, 28)
        Me.btnBegin.TabIndex = 5
        Me.btnBegin.Text = "BEGIN"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pulse Size:"
        '
        'optPulse1
        '
        Me.optPulse1.AutoSize = True
        Me.optPulse1.Location = New System.Drawing.Point(115, 135)
        Me.optPulse1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optPulse1.Name = "optPulse1"
        Me.optPulse1.Size = New System.Drawing.Size(37, 21)
        Me.optPulse1.TabIndex = 3
        Me.optPulse1.Text = "1"
        Me.optPulse1.UseVisualStyleBackColor = True
        '
        'optPulse2
        '
        Me.optPulse2.AutoSize = True
        Me.optPulse2.Checked = True
        Me.optPulse2.Location = New System.Drawing.Point(164, 135)
        Me.optPulse2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optPulse2.Name = "optPulse2"
        Me.optPulse2.Size = New System.Drawing.Size(37, 21)
        Me.optPulse2.TabIndex = 4
        Me.optPulse2.TabStop = True
        Me.optPulse2.Text = "2"
        Me.optPulse2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "X-Knob Play:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Y-Knob Play:"
        '
        'nudYPlay
        '
        Me.nudYPlay.Location = New System.Drawing.Point(328, 37)
        Me.nudYPlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudYPlay.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudYPlay.Name = "nudYPlay"
        Me.nudYPlay.Size = New System.Drawing.Size(65, 22)
        Me.nudYPlay.TabIndex = 1
        Me.nudYPlay.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudXPlay
        '
        Me.nudXPlay.Location = New System.Drawing.Point(115, 37)
        Me.nudXPlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudXPlay.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudXPlay.Name = "nudXPlay"
        Me.nudXPlay.Size = New System.Drawing.Size(65, 22)
        Me.nudXPlay.TabIndex = 0
        Me.nudXPlay.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'nudBufferSize
        '
        Me.nudBufferSize.Location = New System.Drawing.Point(115, 78)
        Me.nudBufferSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudBufferSize.Maximum = New Decimal(New Integer() {4096, 0, 0, 0})
        Me.nudBufferSize.Name = "nudBufferSize"
        Me.nudBufferSize.Size = New System.Drawing.Size(79, 22)
        Me.nudBufferSize.TabIndex = 3
        Me.nudBufferSize.Value = New Decimal(New Integer() {32, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 80)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Buffer Size:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 80)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Buffer Pause (ms):"
        '
        'nudBufferPause
        '
        Me.nudBufferPause.Location = New System.Drawing.Point(328, 78)
        Me.nudBufferPause.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudBufferPause.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudBufferPause.Name = "nudBufferPause"
        Me.nudBufferPause.Size = New System.Drawing.Size(80, 22)
        Me.nudBufferPause.TabIndex = 4
        Me.nudBufferPause.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'btnAdjust
        '
        Me.btnAdjust.Location = New System.Drawing.Point(361, 186)
        Me.btnAdjust.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdjust.Name = "btnAdjust"
        Me.btnAdjust.Size = New System.Drawing.Size(140, 28)
        Me.btnAdjust.TabIndex = 12
        Me.btnAdjust.Text = "PAUSE/ADJUST"
        Me.btnAdjust.UseVisualStyleBackColor = True
        '
        'btnAdjustUp
        '
        Me.btnAdjustUp.Enabled = False
        Me.btnAdjustUp.Location = New System.Drawing.Point(416, 222)
        Me.btnAdjustUp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdjustUp.Name = "btnAdjustUp"
        Me.btnAdjustUp.Size = New System.Drawing.Size(28, 28)
        Me.btnAdjustUp.TabIndex = 13
        Me.btnAdjustUp.UseVisualStyleBackColor = True
        '
        'btnAdjustDown
        '
        Me.btnAdjustDown.Enabled = False
        Me.btnAdjustDown.Location = New System.Drawing.Point(416, 273)
        Me.btnAdjustDown.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdjustDown.Name = "btnAdjustDown"
        Me.btnAdjustDown.Size = New System.Drawing.Size(28, 28)
        Me.btnAdjustDown.TabIndex = 14
        Me.btnAdjustDown.UseVisualStyleBackColor = True
        '
        'btnAdjustRight
        '
        Me.btnAdjustRight.Enabled = False
        Me.btnAdjustRight.Location = New System.Drawing.Point(452, 246)
        Me.btnAdjustRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdjustRight.Name = "btnAdjustRight"
        Me.btnAdjustRight.Size = New System.Drawing.Size(28, 28)
        Me.btnAdjustRight.TabIndex = 15
        Me.btnAdjustRight.UseVisualStyleBackColor = True
        '
        'btnAdjustLeft
        '
        Me.btnAdjustLeft.Enabled = False
        Me.btnAdjustLeft.Location = New System.Drawing.Point(380, 246)
        Me.btnAdjustLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdjustLeft.Name = "btnAdjustLeft"
        Me.btnAdjustLeft.Size = New System.Drawing.Size(28, 28)
        Me.btnAdjustLeft.TabIndex = 16
        Me.btnAdjustLeft.UseVisualStyleBackColor = True
        '
        'btnBufferStep
        '
        Me.btnBufferStep.Enabled = False
        Me.btnBufferStep.Location = New System.Drawing.Point(361, 309)
        Me.btnBufferStep.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBufferStep.Name = "btnBufferStep"
        Me.btnBufferStep.Size = New System.Drawing.Size(140, 28)
        Me.btnBufferStep.TabIndex = 17
        Me.btnBufferStep.Text = "Buffer Step"
        Me.btnBufferStep.UseVisualStyleBackColor = True
        '
        'frmRunPath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 364)
        Me.Controls.Add(Me.btnBufferStep)
        Me.Controls.Add(Me.btnAdjustLeft)
        Me.Controls.Add(Me.btnAdjustRight)
        Me.Controls.Add(Me.btnAdjustDown)
        Me.Controls.Add(Me.btnAdjustUp)
        Me.Controls.Add(Me.btnAdjust)
        Me.Controls.Add(Me.nudBufferPause)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.nudBufferSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudXPlay)
        Me.Controls.Add(Me.nudYPlay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.optPulse2)
        Me.Controls.Add(Me.optPulse1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRunPath"
        Me.Text = "frmRunPath"
        CType(Me.nudYPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBufferSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudBufferPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnBegin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optPulse1 As System.Windows.Forms.RadioButton
    Friend WithEvents optPulse2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudYPlay As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudXPlay As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudBufferSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nudBufferPause As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAdjust As System.Windows.Forms.Button
    Friend WithEvents btnAdjustUp As System.Windows.Forms.Button
    Friend WithEvents btnAdjustDown As System.Windows.Forms.Button
    Friend WithEvents btnAdjustRight As System.Windows.Forms.Button
    Friend WithEvents btnAdjustLeft As System.Windows.Forms.Button
    Friend WithEvents btnBufferStep As System.Windows.Forms.Button
End Class
