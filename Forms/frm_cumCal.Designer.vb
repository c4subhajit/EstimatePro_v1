<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cumCal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cumCal))
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_bottomBreadth = New System.Windows.Forms.TextBox
        Me.txt_bottomLength = New System.Windows.Forms.TextBox
        Me.cmd_calculate = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.txt_cumRate = New System.Windows.Forms.TextBox
        Me.txt_volume = New System.Windows.Forms.TextBox
        Me.txt_slope = New System.Windows.Forms.TextBox
        Me.txt_depth = New System.Windows.Forms.TextBox
        Me.txt_breadth = New System.Windows.Forms.TextBox
        Me.txt_length = New System.Windows.Forms.TextBox
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(225, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Bottom breadth"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Bottom length"
        '
        'txt_bottomBreadth
        '
        Me.txt_bottomBreadth.Location = New System.Drawing.Point(310, 40)
        Me.txt_bottomBreadth.Name = "txt_bottomBreadth"
        Me.txt_bottomBreadth.ReadOnly = True
        Me.txt_bottomBreadth.Size = New System.Drawing.Size(100, 20)
        Me.txt_bottomBreadth.TabIndex = 35
        Me.txt_bottomBreadth.TabStop = False
        '
        'txt_bottomLength
        '
        Me.txt_bottomLength.Location = New System.Drawing.Point(310, 14)
        Me.txt_bottomLength.Name = "txt_bottomLength"
        Me.txt_bottomLength.ReadOnly = True
        Me.txt_bottomLength.Size = New System.Drawing.Size(100, 20)
        Me.txt_bottomLength.TabIndex = 34
        Me.txt_bottomLength.TabStop = False
        '
        'cmd_calculate
        '
        Me.cmd_calculate.Location = New System.Drawing.Point(235, 116)
        Me.cmd_calculate.Name = "cmd_calculate"
        Me.cmd_calculate.Size = New System.Drawing.Size(75, 23)
        Me.cmd_calculate.TabIndex = 6
        Me.cmd_calculate.Text = "&Calculate"
        Me.cmd_calculate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Excavation rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(263, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Volume"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Slope percent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Depth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Breadth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Length"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(310, 92)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.ReadOnly = True
        Me.txt_amount.Size = New System.Drawing.Size(100, 20)
        Me.txt_amount.TabIndex = 25
        Me.txt_amount.TabStop = False
        '
        'txt_cumRate
        '
        Me.txt_cumRate.Location = New System.Drawing.Point(99, 118)
        Me.txt_cumRate.MaxLength = 18
        Me.txt_cumRate.Name = "txt_cumRate"
        Me.txt_cumRate.Size = New System.Drawing.Size(100, 20)
        Me.txt_cumRate.TabIndex = 5
        '
        'txt_volume
        '
        Me.txt_volume.Location = New System.Drawing.Point(310, 66)
        Me.txt_volume.Name = "txt_volume"
        Me.txt_volume.ReadOnly = True
        Me.txt_volume.Size = New System.Drawing.Size(100, 20)
        Me.txt_volume.TabIndex = 23
        Me.txt_volume.TabStop = False
        '
        'txt_slope
        '
        Me.txt_slope.Location = New System.Drawing.Point(99, 92)
        Me.txt_slope.MaxLength = 18
        Me.txt_slope.Name = "txt_slope"
        Me.txt_slope.Size = New System.Drawing.Size(100, 20)
        Me.txt_slope.TabIndex = 4
        '
        'txt_depth
        '
        Me.txt_depth.Location = New System.Drawing.Point(99, 66)
        Me.txt_depth.MaxLength = 18
        Me.txt_depth.Name = "txt_depth"
        Me.txt_depth.Size = New System.Drawing.Size(100, 20)
        Me.txt_depth.TabIndex = 3
        '
        'txt_breadth
        '
        Me.txt_breadth.Location = New System.Drawing.Point(99, 40)
        Me.txt_breadth.MaxLength = 18
        Me.txt_breadth.Name = "txt_breadth"
        Me.txt_breadth.Size = New System.Drawing.Size(100, 20)
        Me.txt_breadth.TabIndex = 2
        '
        'txt_length
        '
        Me.txt_length.Location = New System.Drawing.Point(99, 14)
        Me.txt_length.MaxLength = 18
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(100, 20)
        Me.txt_length.TabIndex = 1
        '
        'cmd_reset
        '
        Me.cmd_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_reset.Location = New System.Drawing.Point(335, 116)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 7
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'frm_cumCal
        '
        Me.AcceptButton = Me.cmd_calculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_reset
        Me.ClientSize = New System.Drawing.Size(424, 152)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_bottomBreadth)
        Me.Controls.Add(Me.txt_bottomLength)
        Me.Controls.Add(Me.cmd_calculate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.txt_cumRate)
        Me.Controls.Add(Me.txt_volume)
        Me.Controls.Add(Me.txt_slope)
        Me.Controls.Add(Me.txt_depth)
        Me.Controls.Add(Me.txt_breadth)
        Me.Controls.Add(Me.txt_length)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(440, 190)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(440, 190)
        Me.Name = "frm_cumCal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Excavation calculator utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_bottomBreadth As System.Windows.Forms.TextBox
    Friend WithEvents txt_bottomLength As System.Windows.Forms.TextBox
    Friend WithEvents cmd_calculate As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_cumRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_volume As System.Windows.Forms.TextBox
    Friend WithEvents txt_slope As System.Windows.Forms.TextBox
    Friend WithEvents txt_depth As System.Windows.Forms.TextBox
    Friend WithEvents txt_breadth As System.Windows.Forms.TextBox
    Friend WithEvents txt_length As System.Windows.Forms.TextBox
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
End Class
