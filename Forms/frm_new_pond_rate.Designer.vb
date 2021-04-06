<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new_pond_rate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_new_pond_rate))
        Me.txt_cont_cost = New System.Windows.Forms.TextBox
        Me.txt_dispBord_cost = New System.Windows.Forms.TextBox
        Me.txt_tot_estCost = New System.Windows.Forms.TextBox
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.txt_est_cost = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_contRate = New System.Windows.Forms.TextBox
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_continue = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_desc = New System.Windows.Forms.TextBox
        Me.txt_qty = New System.Windows.Forms.TextBox
        Me.txt_unit_rate = New System.Windows.Forms.TextBox
        Me.txt_rate = New System.Windows.Forms.TextBox
        Me.txt_amt = New System.Windows.Forms.TextBox
        Me.cmb_rateItemNo = New System.Windows.Forms.ComboBox
        Me.GB_TVP = New System.Windows.Forms.GroupBox
        Me.txt_totVolEEW = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_30_pond = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_unit_pond = New System.Windows.Forms.TextBox
        Me.txt_70_pond = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_cut_area = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_totVol_drain = New System.Windows.Forms.TextBox
        Me.txt_turf_area = New System.Windows.Forms.TextBox
        Me.txt_totVol_pond = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmd_confirm = New System.Windows.Forms.Button
        Me.GB_TVP.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_cont_cost
        '
        Me.txt_cont_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cont_cost.Location = New System.Drawing.Point(305, 439)
        Me.txt_cont_cost.Name = "txt_cont_cost"
        Me.txt_cont_cost.ReadOnly = True
        Me.txt_cont_cost.Size = New System.Drawing.Size(151, 20)
        Me.txt_cont_cost.TabIndex = 52
        Me.txt_cont_cost.TabStop = False
        Me.txt_cont_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_dispBord_cost
        '
        Me.txt_dispBord_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dispBord_cost.Location = New System.Drawing.Point(305, 417)
        Me.txt_dispBord_cost.Name = "txt_dispBord_cost"
        Me.txt_dispBord_cost.Size = New System.Drawing.Size(151, 20)
        Me.txt_dispBord_cost.TabIndex = 3
        Me.txt_dispBord_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_tot_estCost
        '
        Me.txt_tot_estCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_estCost.Location = New System.Drawing.Point(305, 461)
        Me.txt_tot_estCost.Name = "txt_tot_estCost"
        Me.txt_tot_estCost.ReadOnly = True
        Me.txt_tot_estCost.Size = New System.Drawing.Size(151, 20)
        Me.txt_tot_estCost.TabIndex = 53
        Me.txt_tot_estCost.TabStop = False
        Me.txt_tot_estCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(144, 499)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 6
        Me.cmd_cancel.Text = "Canc&el"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'txt_est_cost
        '
        Me.txt_est_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_est_cost.Location = New System.Drawing.Point(305, 395)
        Me.txt_est_cost.Name = "txt_est_cost"
        Me.txt_est_cost.ReadOnly = True
        Me.txt_est_cost.Size = New System.Drawing.Size(151, 20)
        Me.txt_est_cost.TabIndex = 50
        Me.txt_est_cost.TabStop = False
        Me.txt_est_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(170, 442)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Contingency @"
        '
        'txt_contRate
        '
        Me.txt_contRate.Location = New System.Drawing.Point(252, 439)
        Me.txt_contRate.MaxLength = 7
        Me.txt_contRate.Name = "txt_contRate"
        Me.txt_contRate.Size = New System.Drawing.Size(29, 20)
        Me.txt_contRate.TabIndex = 4
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(337, 499)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 7
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_continue
        '
        Me.cmd_continue.Location = New System.Drawing.Point(240, 499)
        Me.cmd_continue.Name = "cmd_continue"
        Me.cmd_continue.Size = New System.Drawing.Size(75, 23)
        Me.cmd_continue.TabIndex = 4
        Me.cmd_continue.Text = "&Continue"
        Me.cmd_continue.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(202, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Estimate cost"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(282, 442)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "%"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(202, 421)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Display board cost"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(173, 465)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(128, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Total estimated cost"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Unit"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Rate (Rs)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(85, 443)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Amount (Rs)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_desc
        '
        Me.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_desc.Location = New System.Drawing.Point(59, 284)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.ReadOnly = True
        Me.txt_desc.Size = New System.Drawing.Size(397, 95)
        Me.txt_desc.TabIndex = 64
        Me.txt_desc.TabStop = False
        '
        'txt_qty
        '
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Location = New System.Drawing.Point(12, 414)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(91, 20)
        Me.txt_qty.TabIndex = 2
        '
        'txt_unit_rate
        '
        Me.txt_unit_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unit_rate.Location = New System.Drawing.Point(107, 414)
        Me.txt_unit_rate.Name = "txt_unit_rate"
        Me.txt_unit_rate.ReadOnly = True
        Me.txt_unit_rate.Size = New System.Drawing.Size(59, 20)
        Me.txt_unit_rate.TabIndex = 66
        Me.txt_unit_rate.TabStop = False
        '
        'txt_rate
        '
        Me.txt_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rate.Location = New System.Drawing.Point(12, 459)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.ReadOnly = True
        Me.txt_rate.Size = New System.Drawing.Size(59, 20)
        Me.txt_rate.TabIndex = 67
        Me.txt_rate.TabStop = False
        '
        'txt_amt
        '
        Me.txt_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amt.Location = New System.Drawing.Point(76, 459)
        Me.txt_amt.Name = "txt_amt"
        Me.txt_amt.ReadOnly = True
        Me.txt_amt.Size = New System.Drawing.Size(90, 20)
        Me.txt_amt.TabIndex = 68
        '
        'cmb_rateItemNo
        '
        Me.cmb_rateItemNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_rateItemNo.FormattingEnabled = True
        Me.cmb_rateItemNo.Location = New System.Drawing.Point(11, 284)
        Me.cmb_rateItemNo.Name = "cmb_rateItemNo"
        Me.cmb_rateItemNo.Size = New System.Drawing.Size(42, 21)
        Me.cmb_rateItemNo.TabIndex = 1
        '
        'GB_TVP
        '
        Me.GB_TVP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GB_TVP.Controls.Add(Me.txt_totVolEEW)
        Me.GB_TVP.Controls.Add(Me.Label9)
        Me.GB_TVP.Controls.Add(Me.txt_30_pond)
        Me.GB_TVP.Controls.Add(Me.Label20)
        Me.GB_TVP.Controls.Add(Me.txt_unit_pond)
        Me.GB_TVP.Controls.Add(Me.txt_70_pond)
        Me.GB_TVP.Controls.Add(Me.Label19)
        Me.GB_TVP.Controls.Add(Me.Label7)
        Me.GB_TVP.Controls.Add(Me.txt_cut_area)
        Me.GB_TVP.Controls.Add(Me.txt_totVol_drain)
        Me.GB_TVP.Controls.Add(Me.Label8)
        Me.GB_TVP.Controls.Add(Me.txt_totVol_pond)
        Me.GB_TVP.Controls.Add(Me.Label13)
        Me.GB_TVP.Controls.Add(Me.Label17)
        Me.GB_TVP.Controls.Add(Me.txt_turf_area)
        Me.GB_TVP.Controls.Add(Me.Label15)
        Me.GB_TVP.Location = New System.Drawing.Point(11, 12)
        Me.GB_TVP.Name = "GB_TVP"
        Me.GB_TVP.Size = New System.Drawing.Size(445, 242)
        Me.GB_TVP.TabIndex = 69
        Me.GB_TVP.TabStop = False
        Me.GB_TVP.Text = "Current pond parameters"
        '
        'txt_totVolEEW
        '
        Me.txt_totVolEEW.Location = New System.Drawing.Point(257, 100)
        Me.txt_totVolEEW.MaxLength = 22
        Me.txt_totVolEEW.Name = "txt_totVolEEW"
        Me.txt_totVolEEW.ReadOnly = True
        Me.txt_totVolEEW.Size = New System.Drawing.Size(150, 20)
        Me.txt_totVolEEW.TabIndex = 83
        Me.txt_totVolEEW.TabStop = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(40, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 15)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "Total volume of earth excavation"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_30_pond
        '
        Me.txt_30_pond.Location = New System.Drawing.Point(257, 156)
        Me.txt_30_pond.Name = "txt_30_pond"
        Me.txt_30_pond.ReadOnly = True
        Me.txt_30_pond.Size = New System.Drawing.Size(150, 20)
        Me.txt_30_pond.TabIndex = 80
        Me.txt_30_pond.TabStop = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(13, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(238, 17)
        Me.Label20.TabIndex = 81
        Me.Label20.Text = "30% of earth excavation by Mannual means"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_unit_pond
        '
        Me.txt_unit_pond.Location = New System.Drawing.Point(257, 19)
        Me.txt_unit_pond.Name = "txt_unit_pond"
        Me.txt_unit_pond.ReadOnly = True
        Me.txt_unit_pond.Size = New System.Drawing.Size(150, 20)
        Me.txt_unit_pond.TabIndex = 79
        Me.txt_unit_pond.TabStop = False
        '
        'txt_70_pond
        '
        Me.txt_70_pond.Location = New System.Drawing.Point(257, 128)
        Me.txt_70_pond.Name = "txt_70_pond"
        Me.txt_70_pond.ReadOnly = True
        Me.txt_70_pond.Size = New System.Drawing.Size(150, 20)
        Me.txt_70_pond.TabIndex = 75
        Me.txt_70_pond.TabStop = False
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(10, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(241, 17)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "70% of earth excavation by Mechanical means"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Base unit"
        '
        'txt_cut_area
        '
        Me.txt_cut_area.Location = New System.Drawing.Point(257, 183)
        Me.txt_cut_area.MaxLength = 22
        Me.txt_cut_area.Name = "txt_cut_area"
        Me.txt_cut_area.ReadOnly = True
        Me.txt_cut_area.Size = New System.Drawing.Size(150, 20)
        Me.txt_cut_area.TabIndex = 9
        Me.txt_cut_area.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(146, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Jungle cutting area"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_totVol_drain
        '
        Me.txt_totVol_drain.Location = New System.Drawing.Point(257, 73)
        Me.txt_totVol_drain.MaxLength = 22
        Me.txt_totVol_drain.Name = "txt_totVol_drain"
        Me.txt_totVol_drain.ReadOnly = True
        Me.txt_totVol_drain.Size = New System.Drawing.Size(150, 20)
        Me.txt_totVol_drain.TabIndex = 7
        Me.txt_totVol_drain.TabStop = False
        '
        'txt_turf_area
        '
        Me.txt_turf_area.Location = New System.Drawing.Point(257, 211)
        Me.txt_turf_area.MaxLength = 22
        Me.txt_turf_area.Name = "txt_turf_area"
        Me.txt_turf_area.ReadOnly = True
        Me.txt_turf_area.Size = New System.Drawing.Size(150, 20)
        Me.txt_turf_area.TabIndex = 6
        Me.txt_turf_area.TabStop = False
        '
        'txt_totVol_pond
        '
        Me.txt_totVol_pond.Location = New System.Drawing.Point(257, 46)
        Me.txt_totVol_pond.MaxLength = 22
        Me.txt_totVol_pond.Name = "txt_totVol_pond"
        Me.txt_totVol_pond.ReadOnly = True
        Me.txt_totVol_pond.Size = New System.Drawing.Size(150, 20)
        Me.txt_totVol_pond.TabIndex = 5
        Me.txt_totVol_pond.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(30, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(221, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Volume of earth excavation for side drains"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(146, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Turfing surface area"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(40, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(211, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Volume of earth excavation for pond"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_confirm
        '
        Me.cmd_confirm.Location = New System.Drawing.Point(43, 499)
        Me.cmd_confirm.Name = "cmd_confirm"
        Me.cmd_confirm.Size = New System.Drawing.Size(82, 23)
        Me.cmd_confirm.TabIndex = 3
        Me.cmd_confirm.Text = "Co&nfirm"
        Me.cmd_confirm.UseVisualStyleBackColor = True
        '
        'frm_new_pond_rate
        '
        Me.AcceptButton = Me.cmd_continue
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(469, 537)
        Me.Controls.Add(Me.cmd_confirm)
        Me.Controls.Add(Me.GB_TVP)
        Me.Controls.Add(Me.cmb_rateItemNo)
        Me.Controls.Add(Me.txt_amt)
        Me.Controls.Add(Me.txt_rate)
        Me.Controls.Add(Me.txt_unit_rate)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cont_cost)
        Me.Controls.Add(Me.txt_dispBord_cost)
        Me.Controls.Add(Me.txt_tot_estCost)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.txt_est_cost)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_contRate)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_continue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(485, 575)
        Me.MinimumSize = New System.Drawing.Size(485, 575)
        Me.Name = "frm_new_pond_rate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rate chart for pond estimation"
        Me.GB_TVP.ResumeLayout(False)
        Me.GB_TVP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cont_cost As System.Windows.Forms.TextBox
    Friend WithEvents txt_dispBord_cost As System.Windows.Forms.TextBox
    Friend WithEvents txt_tot_estCost As System.Windows.Forms.TextBox
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_est_cost As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_contRate As System.Windows.Forms.TextBox
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_continue As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents txt_unit_rate As System.Windows.Forms.TextBox
    Friend WithEvents txt_rate As System.Windows.Forms.TextBox
    Friend WithEvents txt_amt As System.Windows.Forms.TextBox
    Friend WithEvents cmb_rateItemNo As System.Windows.Forms.ComboBox
    Friend WithEvents GB_TVP As System.Windows.Forms.GroupBox
    Friend WithEvents txt_unit_pond As System.Windows.Forms.TextBox
    Friend WithEvents txt_70_pond As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_cut_area As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_totVol_drain As System.Windows.Forms.TextBox
    Friend WithEvents txt_turf_area As System.Windows.Forms.TextBox
    Friend WithEvents txt_totVol_pond As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmd_confirm As System.Windows.Forms.Button
    Friend WithEvents txt_30_pond As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_totVolEEW As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
