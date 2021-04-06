<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new_reservoir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_new_reservoir))
        Me.GB_TVP = New System.Windows.Forms.GroupBox
        Me.cmb_unit = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_dp = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_bl = New System.Windows.Forms.TextBox
        Me.txt_tl = New System.Windows.Forms.TextBox
        Me.txt_bb = New System.Windows.Forms.TextBox
        Me.txt_tb = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_continue = New System.Windows.Forms.Button
        Me.txt_vol = New System.Windows.Forms.TextBox
        Me.cmd_calculate = New System.Windows.Forms.Button
        Me.txt_slope = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.txt_refNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DTP_dateEst = New System.Windows.Forms.DateTimePicker
        Me.txt_dateEst = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GB_TVP.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_TVP
        '
        Me.GB_TVP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GB_TVP.Controls.Add(Me.cmb_unit)
        Me.GB_TVP.Controls.Add(Me.Label5)
        Me.GB_TVP.Controls.Add(Me.txt_dp)
        Me.GB_TVP.Controls.Add(Me.Label7)
        Me.GB_TVP.Controls.Add(Me.txt_bl)
        Me.GB_TVP.Controls.Add(Me.txt_tl)
        Me.GB_TVP.Controls.Add(Me.txt_bb)
        Me.GB_TVP.Controls.Add(Me.txt_tb)
        Me.GB_TVP.Controls.Add(Me.Label4)
        Me.GB_TVP.Controls.Add(Me.Label3)
        Me.GB_TVP.Controls.Add(Me.Label2)
        Me.GB_TVP.Controls.Add(Me.Label1)
        Me.GB_TVP.Location = New System.Drawing.Point(32, 67)
        Me.GB_TVP.Name = "GB_TVP"
        Me.GB_TVP.Size = New System.Drawing.Size(238, 181)
        Me.GB_TVP.TabIndex = 48
        Me.GB_TVP.TabStop = False
        Me.GB_TVP.Text = "Parameters"
        '
        'cmb_unit
        '
        Me.cmb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unit.FormattingEnabled = True
        Me.cmb_unit.Items.AddRange(New Object() {"", "Metre"})
        Me.cmb_unit.Location = New System.Drawing.Point(106, 22)
        Me.cmb_unit.Name = "cmb_unit"
        Me.cmb_unit.Size = New System.Drawing.Size(100, 21)
        Me.cmb_unit.Sorted = True
        Me.cmb_unit.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Unit"
        '
        'txt_dp
        '
        Me.txt_dp.Location = New System.Drawing.Point(106, 148)
        Me.txt_dp.MaxLength = 20
        Me.txt_dp.Name = "txt_dp"
        Me.txt_dp.Size = New System.Drawing.Size(100, 20)
        Me.txt_dp.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(30, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Depth of pond"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_bl
        '
        Me.txt_bl.Location = New System.Drawing.Point(106, 123)
        Me.txt_bl.MaxLength = 20
        Me.txt_bl.Name = "txt_bl"
        Me.txt_bl.Size = New System.Drawing.Size(100, 20)
        Me.txt_bl.TabIndex = 8
        '
        'txt_tl
        '
        Me.txt_tl.Location = New System.Drawing.Point(106, 98)
        Me.txt_tl.MaxLength = 20
        Me.txt_tl.Name = "txt_tl"
        Me.txt_tl.Size = New System.Drawing.Size(100, 20)
        Me.txt_tl.TabIndex = 7
        '
        'txt_bb
        '
        Me.txt_bb.Location = New System.Drawing.Point(106, 73)
        Me.txt_bb.MaxLength = 20
        Me.txt_bb.Name = "txt_bb"
        Me.txt_bb.Size = New System.Drawing.Size(100, 20)
        Me.txt_bb.TabIndex = 6
        '
        'txt_tb
        '
        Me.txt_tb.Location = New System.Drawing.Point(106, 48)
        Me.txt_tb.MaxLength = 20
        Me.txt_tb.Name = "txt_tb"
        Me.txt_tb.Size = New System.Drawing.Size(100, 20)
        Me.txt_tb.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(30, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bottom length"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(30, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Top length"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bottom breadth"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Top breadth"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_continue
        '
        Me.cmd_continue.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_continue.Location = New System.Drawing.Point(14, 353)
        Me.cmd_continue.Name = "cmd_continue"
        Me.cmd_continue.Size = New System.Drawing.Size(75, 23)
        Me.cmd_continue.TabIndex = 51
        Me.cmd_continue.Text = "&Continue"
        Me.cmd_continue.UseVisualStyleBackColor = True
        '
        'txt_vol
        '
        Me.txt_vol.Location = New System.Drawing.Point(114, 321)
        Me.txt_vol.MaxLength = 20
        Me.txt_vol.Name = "txt_vol"
        Me.txt_vol.ReadOnly = True
        Me.txt_vol.Size = New System.Drawing.Size(100, 20)
        Me.txt_vol.TabIndex = 52
        Me.txt_vol.TabStop = False
        '
        'cmd_calculate
        '
        Me.cmd_calculate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_calculate.Location = New System.Drawing.Point(97, 258)
        Me.cmd_calculate.Name = "cmd_calculate"
        Me.cmd_calculate.Size = New System.Drawing.Size(98, 23)
        Me.cmd_calculate.TabIndex = 49
        Me.cmd_calculate.Text = "Calc&ulate"
        Me.cmd_calculate.UseVisualStyleBackColor = True
        '
        'txt_slope
        '
        Me.txt_slope.Location = New System.Drawing.Point(114, 291)
        Me.txt_slope.MaxLength = 20
        Me.txt_slope.Name = "txt_slope"
        Me.txt_slope.ReadOnly = True
        Me.txt_slope.Size = New System.Drawing.Size(100, 20)
        Me.txt_slope.TabIndex = 50
        Me.txt_slope.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Volume"
        '
        'cmd_reset
        '
        Me.cmd_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_reset.Location = New System.Drawing.Point(107, 353)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 53
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(201, 353)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 54
        Me.cmd_cancel.Text = "Ca&ncel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'txt_refNo
        '
        Me.txt_refNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_refNo.Location = New System.Drawing.Point(120, 11)
        Me.txt_refNo.MaxLength = 255
        Me.txt_refNo.Name = "txt_refNo"
        Me.txt_refNo.Size = New System.Drawing.Size(150, 20)
        Me.txt_refNo.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Reference number"
        '
        'DTP_dateEst
        '
        Me.DTP_dateEst.Location = New System.Drawing.Point(252, 36)
        Me.DTP_dateEst.Name = "DTP_dateEst"
        Me.DTP_dateEst.Size = New System.Drawing.Size(18, 20)
        Me.DTP_dateEst.TabIndex = 46
        '
        'txt_dateEst
        '
        Me.txt_dateEst.Location = New System.Drawing.Point(120, 36)
        Me.txt_dateEst.MaxLength = 255
        Me.txt_dateEst.Name = "txt_dateEst"
        Me.txt_dateEst.ReadOnly = True
        Me.txt_dateEst.Size = New System.Drawing.Size(124, 20)
        Me.txt_dateEst.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Date of estimate"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 294)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Slope"
        '
        'frm_new_reservoir
        '
        Me.AcceptButton = Me.cmd_continue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(289, 387)
        Me.Controls.Add(Me.GB_TVP)
        Me.Controls.Add(Me.cmd_continue)
        Me.Controls.Add(Me.txt_vol)
        Me.Controls.Add(Me.cmd_calculate)
        Me.Controls.Add(Me.txt_slope)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.txt_refNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DTP_dateEst)
        Me.Controls.Add(Me.txt_dateEst)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(305, 425)
        Me.MinimumSize = New System.Drawing.Size(305, 425)
        Me.Name = "frm_new_reservoir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Reservoir parameters"
        Me.GB_TVP.ResumeLayout(False)
        Me.GB_TVP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_TVP As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_unit As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_dp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_bl As System.Windows.Forms.TextBox
    Friend WithEvents txt_tl As System.Windows.Forms.TextBox
    Friend WithEvents txt_bb As System.Windows.Forms.TextBox
    Friend WithEvents txt_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_continue As System.Windows.Forms.Button
    Friend WithEvents txt_vol As System.Windows.Forms.TextBox
    Friend WithEvents cmd_calculate As System.Windows.Forms.Button
    Friend WithEvents txt_slope As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_refNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTP_dateEst As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_dateEst As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
