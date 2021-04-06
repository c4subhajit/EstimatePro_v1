<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_new_pond
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_new_pond))
        Me.GB_PP = New System.Windows.Forms.GroupBox
        Me.txt_vol_pp = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_slope_pp = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_depth_pp = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_length_pp = New System.Windows.Forms.TextBox
        Me.txt_breadth_pp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_refNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DTP_dateEst = New System.Windows.Forms.DateTimePicker
        Me.txt_dateEst = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_calculate = New System.Windows.Forms.Button
        Me.cmd_continue = New System.Windows.Forms.Button
        Me.GPB_BP = New System.Windows.Forms.GroupBox
        Me.txt_vol_bp = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_slope_bp = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txt_height_bp = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_berm_bp = New System.Windows.Forms.TextBox
        Me.txt_topWidth_bp = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.chk_sideDrain = New System.Windows.Forms.CheckBox
        Me.chk_turfing = New System.Windows.Forms.CheckBox
        Me.GPB_DP = New System.Windows.Forms.GroupBox
        Me.txt_slope_dp = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_depth_dp = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_length_dp = New System.Windows.Forms.TextBox
        Me.txt_vol_dp = New System.Windows.Forms.TextBox
        Me.txt_breadth_dp = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.GPB_TP = New System.Windows.Forms.GroupBox
        Me.txt_totArea_tp = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txt_length_tp = New System.Windows.Forms.TextBox
        Me.txt_totWidth_tp = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.chk_bund = New System.Windows.Forms.CheckBox
        Me.cmb_unit = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chk_cutting = New System.Windows.Forms.CheckBox
        Me.GPB_CP = New System.Windows.Forms.GroupBox
        Me.txt_totAreaCut_cp = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_length_cp = New System.Windows.Forms.TextBox
        Me.txt_breadth_cp = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GB_PP.SuspendLayout()
        Me.GPB_BP.SuspendLayout()
        Me.GPB_DP.SuspendLayout()
        Me.GPB_TP.SuspendLayout()
        Me.GPB_CP.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_PP
        '
        Me.GB_PP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GB_PP.Controls.Add(Me.txt_vol_pp)
        Me.GB_PP.Controls.Add(Me.Label9)
        Me.GB_PP.Controls.Add(Me.txt_slope_pp)
        Me.GB_PP.Controls.Add(Me.Label6)
        Me.GB_PP.Controls.Add(Me.txt_depth_pp)
        Me.GB_PP.Controls.Add(Me.Label7)
        Me.GB_PP.Controls.Add(Me.txt_length_pp)
        Me.GB_PP.Controls.Add(Me.txt_breadth_pp)
        Me.GB_PP.Controls.Add(Me.Label3)
        Me.GB_PP.Controls.Add(Me.Label1)
        Me.GB_PP.Location = New System.Drawing.Point(5, 125)
        Me.GB_PP.Name = "GB_PP"
        Me.GB_PP.Size = New System.Drawing.Size(238, 157)
        Me.GB_PP.TabIndex = 4
        Me.GB_PP.TabStop = False
        Me.GB_PP.Text = "Pond parameters"
        '
        'txt_vol_pp
        '
        Me.txt_vol_pp.Location = New System.Drawing.Point(116, 125)
        Me.txt_vol_pp.MaxLength = 18
        Me.txt_vol_pp.Name = "txt_vol_pp"
        Me.txt_vol_pp.ReadOnly = True
        Me.txt_vol_pp.Size = New System.Drawing.Size(100, 20)
        Me.txt_vol_pp.TabIndex = 37
        Me.txt_vol_pp.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Volume"
        '
        'txt_slope_pp
        '
        Me.txt_slope_pp.Location = New System.Drawing.Point(116, 99)
        Me.txt_slope_pp.MaxLength = 5
        Me.txt_slope_pp.Name = "txt_slope_pp"
        Me.txt_slope_pp.Size = New System.Drawing.Size(100, 20)
        Me.txt_slope_pp.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Slope in percentage"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_depth_pp
        '
        Me.txt_depth_pp.Location = New System.Drawing.Point(116, 73)
        Me.txt_depth_pp.MaxLength = 18
        Me.txt_depth_pp.Name = "txt_depth_pp"
        Me.txt_depth_pp.Size = New System.Drawing.Size(100, 20)
        Me.txt_depth_pp.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(40, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Depth of pond"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_length_pp
        '
        Me.txt_length_pp.Location = New System.Drawing.Point(116, 22)
        Me.txt_length_pp.MaxLength = 18
        Me.txt_length_pp.Name = "txt_length_pp"
        Me.txt_length_pp.Size = New System.Drawing.Size(100, 20)
        Me.txt_length_pp.TabIndex = 9
        '
        'txt_breadth_pp
        '
        Me.txt_breadth_pp.Location = New System.Drawing.Point(116, 48)
        Me.txt_breadth_pp.MaxLength = 18
        Me.txt_breadth_pp.Name = "txt_breadth_pp"
        Me.txt_breadth_pp.Size = New System.Drawing.Size(100, 20)
        Me.txt_breadth_pp.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Length"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Breadth"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_refNo
        '
        Me.txt_refNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_refNo.Location = New System.Drawing.Point(115, 11)
        Me.txt_refNo.MaxLength = 50
        Me.txt_refNo.Name = "txt_refNo"
        Me.txt_refNo.Size = New System.Drawing.Size(128, 20)
        Me.txt_refNo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(102, 16)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Reference number"
        '
        'DTP_dateEst
        '
        Me.DTP_dateEst.Location = New System.Drawing.Point(221, 36)
        Me.DTP_dateEst.Name = "DTP_dateEst"
        Me.DTP_dateEst.Size = New System.Drawing.Size(18, 20)
        Me.DTP_dateEst.TabIndex = 2
        '
        'txt_dateEst
        '
        Me.txt_dateEst.Location = New System.Drawing.Point(115, 36)
        Me.txt_dateEst.MaxLength = 255
        Me.txt_dateEst.Name = "txt_dateEst"
        Me.txt_dateEst.ReadOnly = True
        Me.txt_dateEst.Size = New System.Drawing.Size(100, 20)
        Me.txt_dateEst.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Date of estimate"
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(345, 463)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 43
        Me.cmd_cancel.Text = "Ca&ncel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_reset.Location = New System.Drawing.Point(65, 463)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 42
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_calculate
        '
        Me.cmd_calculate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_calculate.Location = New System.Drawing.Point(250, 421)
        Me.cmd_calculate.Name = "cmd_calculate"
        Me.cmd_calculate.Size = New System.Drawing.Size(238, 23)
        Me.cmd_calculate.TabIndex = 40
        Me.cmd_calculate.Text = "Calc&ulate"
        Me.cmd_calculate.UseVisualStyleBackColor = True
        '
        'cmd_continue
        '
        Me.cmd_continue.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_continue.Location = New System.Drawing.Point(205, 462)
        Me.cmd_continue.Name = "cmd_continue"
        Me.cmd_continue.Size = New System.Drawing.Size(75, 23)
        Me.cmd_continue.TabIndex = 41
        Me.cmd_continue.Text = "&Continue"
        Me.cmd_continue.UseVisualStyleBackColor = True
        '
        'GPB_BP
        '
        Me.GPB_BP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GPB_BP.Controls.Add(Me.txt_vol_bp)
        Me.GPB_BP.Controls.Add(Me.Label8)
        Me.GPB_BP.Controls.Add(Me.txt_slope_bp)
        Me.GPB_BP.Controls.Add(Me.Label30)
        Me.GPB_BP.Controls.Add(Me.txt_height_bp)
        Me.GPB_BP.Controls.Add(Me.Label12)
        Me.GPB_BP.Controls.Add(Me.txt_berm_bp)
        Me.GPB_BP.Controls.Add(Me.txt_topWidth_bp)
        Me.GPB_BP.Controls.Add(Me.Label14)
        Me.GPB_BP.Controls.Add(Me.Label16)
        Me.GPB_BP.Location = New System.Drawing.Point(250, 125)
        Me.GPB_BP.Name = "GPB_BP"
        Me.GPB_BP.Size = New System.Drawing.Size(238, 157)
        Me.GPB_BP.TabIndex = 45
        Me.GPB_BP.TabStop = False
        Me.GPB_BP.Text = "Bund parameters"
        '
        'txt_vol_bp
        '
        Me.txt_vol_bp.Location = New System.Drawing.Point(118, 125)
        Me.txt_vol_bp.MaxLength = 18
        Me.txt_vol_bp.Name = "txt_vol_bp"
        Me.txt_vol_bp.ReadOnly = True
        Me.txt_vol_bp.Size = New System.Drawing.Size(100, 20)
        Me.txt_vol_bp.TabIndex = 39
        Me.txt_vol_bp.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(70, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Volume"
        '
        'txt_slope_bp
        '
        Me.txt_slope_bp.Location = New System.Drawing.Point(118, 99)
        Me.txt_slope_bp.MaxLength = 5
        Me.txt_slope_bp.Name = "txt_slope_bp"
        Me.txt_slope_bp.Size = New System.Drawing.Size(100, 20)
        Me.txt_slope_bp.TabIndex = 23
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(10, 101)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(107, 15)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Slope in percentage"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_height_bp
        '
        Me.txt_height_bp.Location = New System.Drawing.Point(118, 73)
        Me.txt_height_bp.MaxLength = 18
        Me.txt_height_bp.Name = "txt_height_bp"
        Me.txt_height_bp.Size = New System.Drawing.Size(100, 20)
        Me.txt_height_bp.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(34, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 15)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Height of bund"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_berm_bp
        '
        Me.txt_berm_bp.Location = New System.Drawing.Point(118, 23)
        Me.txt_berm_bp.MaxLength = 18
        Me.txt_berm_bp.Name = "txt_berm_bp"
        Me.txt_berm_bp.Size = New System.Drawing.Size(100, 20)
        Me.txt_berm_bp.TabIndex = 20
        '
        'txt_topWidth_bp
        '
        Me.txt_topWidth_bp.Location = New System.Drawing.Point(118, 48)
        Me.txt_topWidth_bp.MaxLength = 18
        Me.txt_topWidth_bp.Name = "txt_topWidth_bp"
        Me.txt_topWidth_bp.Size = New System.Drawing.Size(100, 20)
        Me.txt_topWidth_bp.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(42, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Berm"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(42, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Top width"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_sideDrain
        '
        Me.chk_sideDrain.AutoSize = True
        Me.chk_sideDrain.Location = New System.Drawing.Point(61, 95)
        Me.chk_sideDrain.Name = "chk_sideDrain"
        Me.chk_sideDrain.Size = New System.Drawing.Size(75, 17)
        Me.chk_sideDrain.TabIndex = 6
        Me.chk_sideDrain.Text = "Side &Drain"
        Me.chk_sideDrain.UseVisualStyleBackColor = True
        '
        'chk_turfing
        '
        Me.chk_turfing.AutoSize = True
        Me.chk_turfing.Location = New System.Drawing.Point(136, 95)
        Me.chk_turfing.Name = "chk_turfing"
        Me.chk_turfing.Size = New System.Drawing.Size(59, 17)
        Me.chk_turfing.TabIndex = 7
        Me.chk_turfing.Text = "&Turfing"
        Me.chk_turfing.UseVisualStyleBackColor = True
        '
        'GPB_DP
        '
        Me.GPB_DP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GPB_DP.Controls.Add(Me.txt_slope_dp)
        Me.GPB_DP.Controls.Add(Me.Label2)
        Me.GPB_DP.Controls.Add(Me.txt_depth_dp)
        Me.GPB_DP.Controls.Add(Me.Label18)
        Me.GPB_DP.Controls.Add(Me.txt_length_dp)
        Me.GPB_DP.Controls.Add(Me.txt_vol_dp)
        Me.GPB_DP.Controls.Add(Me.txt_breadth_dp)
        Me.GPB_DP.Controls.Add(Me.Label20)
        Me.GPB_DP.Controls.Add(Me.Label21)
        Me.GPB_DP.Controls.Add(Me.Label22)
        Me.GPB_DP.Location = New System.Drawing.Point(5, 290)
        Me.GPB_DP.Name = "GPB_DP"
        Me.GPB_DP.Size = New System.Drawing.Size(238, 160)
        Me.GPB_DP.TabIndex = 48
        Me.GPB_DP.TabStop = False
        Me.GPB_DP.Text = "Drainage parameters"
        '
        'txt_slope_dp
        '
        Me.txt_slope_dp.Location = New System.Drawing.Point(122, 100)
        Me.txt_slope_dp.MaxLength = 5
        Me.txt_slope_dp.Name = "txt_slope_dp"
        Me.txt_slope_dp.Size = New System.Drawing.Size(100, 20)
        Me.txt_slope_dp.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Slope in percentage"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_depth_dp
        '
        Me.txt_depth_dp.Location = New System.Drawing.Point(121, 74)
        Me.txt_depth_dp.MaxLength = 18
        Me.txt_depth_dp.Name = "txt_depth_dp"
        Me.txt_depth_dp.Size = New System.Drawing.Size(100, 20)
        Me.txt_depth_dp.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(45, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 15)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Depth of drain"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_length_dp
        '
        Me.txt_length_dp.Location = New System.Drawing.Point(121, 23)
        Me.txt_length_dp.MaxLength = 18
        Me.txt_length_dp.Name = "txt_length_dp"
        Me.txt_length_dp.Size = New System.Drawing.Size(100, 20)
        Me.txt_length_dp.TabIndex = 25
        '
        'txt_vol_dp
        '
        Me.txt_vol_dp.Location = New System.Drawing.Point(121, 126)
        Me.txt_vol_dp.MaxLength = 18
        Me.txt_vol_dp.Name = "txt_vol_dp"
        Me.txt_vol_dp.ReadOnly = True
        Me.txt_vol_dp.Size = New System.Drawing.Size(100, 20)
        Me.txt_vol_dp.TabIndex = 6
        Me.txt_vol_dp.TabStop = False
        '
        'txt_breadth_dp
        '
        Me.txt_breadth_dp.Location = New System.Drawing.Point(121, 49)
        Me.txt_breadth_dp.MaxLength = 18
        Me.txt_breadth_dp.Name = "txt_breadth_dp"
        Me.txt_breadth_dp.Size = New System.Drawing.Size(100, 20)
        Me.txt_breadth_dp.TabIndex = 26
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(45, 26)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 15)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Length"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(34, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 15)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Volume"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(45, 51)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Breadth"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GPB_TP
        '
        Me.GPB_TP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GPB_TP.Controls.Add(Me.txt_totArea_tp)
        Me.GPB_TP.Controls.Add(Me.Label24)
        Me.GPB_TP.Controls.Add(Me.txt_length_tp)
        Me.GPB_TP.Controls.Add(Me.txt_totWidth_tp)
        Me.GPB_TP.Controls.Add(Me.Label26)
        Me.GPB_TP.Controls.Add(Me.Label28)
        Me.GPB_TP.Location = New System.Drawing.Point(250, 290)
        Me.GPB_TP.Name = "GPB_TP"
        Me.GPB_TP.Size = New System.Drawing.Size(238, 120)
        Me.GPB_TP.TabIndex = 50
        Me.GPB_TP.TabStop = False
        Me.GPB_TP.Text = "Turfing parameters"
        '
        'txt_totArea_tp
        '
        Me.txt_totArea_tp.Location = New System.Drawing.Point(118, 83)
        Me.txt_totArea_tp.MaxLength = 18
        Me.txt_totArea_tp.Name = "txt_totArea_tp"
        Me.txt_totArea_tp.ReadOnly = True
        Me.txt_totArea_tp.Size = New System.Drawing.Size(100, 20)
        Me.txt_totArea_tp.TabIndex = 9
        Me.txt_totArea_tp.TabStop = False
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(42, 84)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 15)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Surface area"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_length_tp
        '
        Me.txt_length_tp.Location = New System.Drawing.Point(118, 24)
        Me.txt_length_tp.MaxLength = 18
        Me.txt_length_tp.Name = "txt_length_tp"
        Me.txt_length_tp.Size = New System.Drawing.Size(100, 20)
        Me.txt_length_tp.TabIndex = 30
        '
        'txt_totWidth_tp
        '
        Me.txt_totWidth_tp.Location = New System.Drawing.Point(118, 53)
        Me.txt_totWidth_tp.MaxLength = 18
        Me.txt_totWidth_tp.Name = "txt_totWidth_tp"
        Me.txt_totWidth_tp.Size = New System.Drawing.Size(100, 20)
        Me.txt_totWidth_tp.TabIndex = 31
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(42, 27)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 15)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Length"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(10, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(107, 20)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Total width of patch"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chk_bund
        '
        Me.chk_bund.AutoSize = True
        Me.chk_bund.Location = New System.Drawing.Point(9, 95)
        Me.chk_bund.Name = "chk_bund"
        Me.chk_bund.Size = New System.Drawing.Size(51, 17)
        Me.chk_bund.TabIndex = 5
        Me.chk_bund.Text = "&Bund"
        Me.chk_bund.UseVisualStyleBackColor = True
        '
        'cmb_unit
        '
        Me.cmb_unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unit.FormattingEnabled = True
        Me.cmb_unit.Items.AddRange(New Object() {"", "Metre"})
        Me.cmb_unit.Location = New System.Drawing.Point(115, 61)
        Me.cmb_unit.Name = "cmb_unit"
        Me.cmb_unit.Size = New System.Drawing.Size(100, 21)
        Me.cmb_unit.Sorted = True
        Me.cmb_unit.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Unit"
        '
        'chk_cutting
        '
        Me.chk_cutting.AutoSize = True
        Me.chk_cutting.Location = New System.Drawing.Point(196, 95)
        Me.chk_cutting.Name = "chk_cutting"
        Me.chk_cutting.Size = New System.Drawing.Size(59, 17)
        Me.chk_cutting.TabIndex = 8
        Me.chk_cutting.Text = "Cuttin&g"
        Me.chk_cutting.UseVisualStyleBackColor = True
        '
        'GPB_CP
        '
        Me.GPB_CP.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GPB_CP.Controls.Add(Me.txt_totAreaCut_cp)
        Me.GPB_CP.Controls.Add(Me.Label13)
        Me.GPB_CP.Controls.Add(Me.txt_length_cp)
        Me.GPB_CP.Controls.Add(Me.txt_breadth_cp)
        Me.GPB_CP.Controls.Add(Me.Label15)
        Me.GPB_CP.Controls.Add(Me.Label17)
        Me.GPB_CP.Location = New System.Drawing.Point(261, 9)
        Me.GPB_CP.Name = "GPB_CP"
        Me.GPB_CP.Size = New System.Drawing.Size(227, 108)
        Me.GPB_CP.TabIndex = 51
        Me.GPB_CP.TabStop = False
        Me.GPB_CP.Text = "Cutting parameters"
        '
        'txt_totAreaCut_cp
        '
        Me.txt_totAreaCut_cp.Location = New System.Drawing.Point(109, 78)
        Me.txt_totAreaCut_cp.MaxLength = 18
        Me.txt_totAreaCut_cp.Name = "txt_totAreaCut_cp"
        Me.txt_totAreaCut_cp.ReadOnly = True
        Me.txt_totAreaCut_cp.Size = New System.Drawing.Size(100, 20)
        Me.txt_totAreaCut_cp.TabIndex = 9
        Me.txt_totAreaCut_cp.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(7, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 15)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Jungle cutting area"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_length_cp
        '
        Me.txt_length_cp.Location = New System.Drawing.Point(109, 19)
        Me.txt_length_cp.MaxLength = 18
        Me.txt_length_cp.Name = "txt_length_cp"
        Me.txt_length_cp.Size = New System.Drawing.Size(100, 20)
        Me.txt_length_cp.TabIndex = 30
        '
        'txt_breadth_cp
        '
        Me.txt_breadth_cp.Location = New System.Drawing.Point(109, 48)
        Me.txt_breadth_cp.MaxLength = 18
        Me.txt_breadth_cp.Name = "txt_breadth_cp"
        Me.txt_breadth_cp.Size = New System.Drawing.Size(100, 20)
        Me.txt_breadth_cp.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(33, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Length"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(24, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 20)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Breadth"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_new_pond
        '
        Me.AcceptButton = Me.cmd_calculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(494, 497)
        Me.Controls.Add(Me.GPB_CP)
        Me.Controls.Add(Me.chk_cutting)
        Me.Controls.Add(Me.cmb_unit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GPB_TP)
        Me.Controls.Add(Me.chk_bund)
        Me.Controls.Add(Me.GPB_DP)
        Me.Controls.Add(Me.chk_turfing)
        Me.Controls.Add(Me.chk_sideDrain)
        Me.Controls.Add(Me.GPB_BP)
        Me.Controls.Add(Me.GB_PP)
        Me.Controls.Add(Me.txt_refNo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DTP_dateEst)
        Me.Controls.Add(Me.txt_dateEst)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_calculate)
        Me.Controls.Add(Me.cmd_continue)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(510, 535)
        Me.MinimumSize = New System.Drawing.Size(510, 535)
        Me.Name = "frm_new_pond"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pond parameters"
        Me.GB_PP.ResumeLayout(False)
        Me.GB_PP.PerformLayout()
        Me.GPB_BP.ResumeLayout(False)
        Me.GPB_BP.PerformLayout()
        Me.GPB_DP.ResumeLayout(False)
        Me.GPB_DP.PerformLayout()
        Me.GPB_TP.ResumeLayout(False)
        Me.GPB_TP.PerformLayout()
        Me.GPB_CP.ResumeLayout(False)
        Me.GPB_CP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GB_PP As System.Windows.Forms.GroupBox
    Friend WithEvents txt_depth_pp As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_length_pp As System.Windows.Forms.TextBox
    Friend WithEvents txt_breadth_pp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_refNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTP_dateEst As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_dateEst As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_calculate As System.Windows.Forms.Button
    Friend WithEvents cmd_continue As System.Windows.Forms.Button
    Friend WithEvents GPB_BP As System.Windows.Forms.GroupBox
    Friend WithEvents txt_height_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_berm_bp As System.Windows.Forms.TextBox
    Friend WithEvents txt_topWidth_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chk_sideDrain As System.Windows.Forms.CheckBox
    Friend WithEvents chk_turfing As System.Windows.Forms.CheckBox
    Friend WithEvents GPB_DP As System.Windows.Forms.GroupBox
    Friend WithEvents txt_depth_dp As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_length_dp As System.Windows.Forms.TextBox
    Friend WithEvents txt_vol_dp As System.Windows.Forms.TextBox
    Friend WithEvents txt_breadth_dp As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GPB_TP As System.Windows.Forms.GroupBox
    Friend WithEvents txt_totArea_tp As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_length_tp As System.Windows.Forms.TextBox
    Friend WithEvents txt_totWidth_tp As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chk_bund As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_unit As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_slope_pp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chk_cutting As System.Windows.Forms.CheckBox
    Friend WithEvents txt_vol_pp As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_vol_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_slope_bp As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_slope_dp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GPB_CP As System.Windows.Forms.GroupBox
    Friend WithEvents txt_totAreaCut_cp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_length_cp As System.Windows.Forms.TextBox
    Friend WithEvents txt_breadth_cp As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
