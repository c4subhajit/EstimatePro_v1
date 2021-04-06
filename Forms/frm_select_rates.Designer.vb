<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_rates
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_select_rates))
        Me.cmd_select = New System.Windows.Forms.Button
        Me.cmb_refno_SR = New System.Windows.Forms.ComboBox
        Me.txt_rate_SR = New System.Windows.Forms.TextBox
        Me.txt_unit_SR = New System.Windows.Forms.TextBox
        Me.txt_desc_SR = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmd_undoselect = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_selectStatus = New System.Windows.Forms.Label
        Me.txt_TW_SR = New System.Windows.Forms.TextBox
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_back = New System.Windows.Forms.Button
        Me.cmd_continue = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmd_select
        '
        Me.cmd_select.Location = New System.Drawing.Point(176, 187)
        Me.cmd_select.Name = "cmd_select"
        Me.cmd_select.Size = New System.Drawing.Size(75, 23)
        Me.cmd_select.TabIndex = 2
        Me.cmd_select.Text = "&Select"
        Me.cmd_select.UseVisualStyleBackColor = True
        '
        'cmb_refno_SR
        '
        Me.cmb_refno_SR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_refno_SR.FormattingEnabled = True
        Me.cmb_refno_SR.Location = New System.Drawing.Point(120, 12)
        Me.cmb_refno_SR.Name = "cmb_refno_SR"
        Me.cmb_refno_SR.Size = New System.Drawing.Size(137, 21)
        Me.cmb_refno_SR.TabIndex = 1
        '
        'txt_rate_SR
        '
        Me.txt_rate_SR.Location = New System.Drawing.Point(380, 122)
        Me.txt_rate_SR.Name = "txt_rate_SR"
        Me.txt_rate_SR.ReadOnly = True
        Me.txt_rate_SR.Size = New System.Drawing.Size(145, 20)
        Me.txt_rate_SR.TabIndex = 53
        Me.txt_rate_SR.TabStop = False
        '
        'txt_unit_SR
        '
        Me.txt_unit_SR.Location = New System.Drawing.Point(169, 122)
        Me.txt_unit_SR.Name = "txt_unit_SR"
        Me.txt_unit_SR.ReadOnly = True
        Me.txt_unit_SR.Size = New System.Drawing.Size(145, 20)
        Me.txt_unit_SR.TabIndex = 52
        Me.txt_unit_SR.TabStop = False
        '
        'txt_desc_SR
        '
        Me.txt_desc_SR.Location = New System.Drawing.Point(169, 43)
        Me.txt_desc_SR.Multiline = True
        Me.txt_desc_SR.Name = "txt_desc_SR"
        Me.txt_desc_SR.ReadOnly = True
        Me.txt_desc_SR.Size = New System.Drawing.Size(356, 70)
        Me.txt_desc_SR.TabIndex = 51
        Me.txt_desc_SR.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Reference number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(344, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Rate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(137, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Unit"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Activity description"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(283, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Type of work"
        '
        'cmd_undoselect
        '
        Me.cmd_undoselect.Location = New System.Drawing.Point(257, 187)
        Me.cmd_undoselect.Name = "cmd_undoselect"
        Me.cmd_undoselect.Size = New System.Drawing.Size(105, 23)
        Me.cmd_undoselect.TabIndex = 3
        Me.cmd_undoselect.Text = "&Undo Select"
        Me.cmd_undoselect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Status"
        '
        'lbl_selectStatus
        '
        Me.lbl_selectStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_selectStatus.Location = New System.Drawing.Point(264, 155)
        Me.lbl_selectStatus.Name = "lbl_selectStatus"
        Me.lbl_selectStatus.Size = New System.Drawing.Size(133, 21)
        Me.lbl_selectStatus.TabIndex = 61
        Me.lbl_selectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_TW_SR
        '
        Me.txt_TW_SR.Location = New System.Drawing.Point(358, 12)
        Me.txt_TW_SR.Name = "txt_TW_SR"
        Me.txt_TW_SR.ReadOnly = True
        Me.txt_TW_SR.Size = New System.Drawing.Size(239, 20)
        Me.txt_TW_SR.TabIndex = 62
        Me.txt_TW_SR.TabStop = False
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(449, 187)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 63
        Me.cmd_cancel.Text = "&Cancel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_back
        '
        Me.cmd_back.Location = New System.Drawing.Point(95, 187)
        Me.cmd_back.Name = "cmd_back"
        Me.cmd_back.Size = New System.Drawing.Size(75, 23)
        Me.cmd_back.TabIndex = 64
        Me.cmd_back.Text = "&Back"
        Me.cmd_back.UseVisualStyleBackColor = True
        '
        'cmd_continue
        '
        Me.cmd_continue.Location = New System.Drawing.Point(368, 187)
        Me.cmd_continue.Name = "cmd_continue"
        Me.cmd_continue.Size = New System.Drawing.Size(75, 23)
        Me.cmd_continue.TabIndex = 65
        Me.cmd_continue.Text = "Co&ntinue"
        Me.cmd_continue.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(518, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Attention Please !! Rate selection is not possible after continuing to the next s" & _
            "tep."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_select_rates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(609, 252)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_continue)
        Me.Controls.Add(Me.cmd_back)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.txt_TW_SR)
        Me.Controls.Add(Me.lbl_selectStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_select)
        Me.Controls.Add(Me.cmb_refno_SR)
        Me.Controls.Add(Me.cmd_undoselect)
        Me.Controls.Add(Me.txt_rate_SR)
        Me.Controls.Add(Me.txt_unit_SR)
        Me.Controls.Add(Me.txt_desc_SR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(625, 290)
        Me.MinimumSize = New System.Drawing.Size(625, 290)
        Me.Name = "frm_select_rates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Select necessary estimate rates"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_select As System.Windows.Forms.Button
    Friend WithEvents cmb_refno_SR As System.Windows.Forms.ComboBox
    Friend WithEvents txt_rate_SR As System.Windows.Forms.TextBox
    Friend WithEvents txt_unit_SR As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc_SR As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmd_undoselect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_selectStatus As System.Windows.Forms.Label
    Friend WithEvents txt_TW_SR As System.Windows.Forms.TextBox
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_back As System.Windows.Forms.Button
    Friend WithEvents cmd_continue As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
