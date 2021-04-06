<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rate))
        Me.TC_rate = New System.Windows.Forms.TabControl
        Me.TC_rate_new = New System.Windows.Forms.TabPage
        Me.cmd_reset_RN = New System.Windows.Forms.Button
        Me.cmd_add_RN = New System.Windows.Forms.Button
        Me.txt_rate_RN = New System.Windows.Forms.TextBox
        Me.txt_unit_RN = New System.Windows.Forms.TextBox
        Me.txt_refno_RN = New System.Windows.Forms.TextBox
        Me.txt_desc_RN = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_TW_RN = New System.Windows.Forms.ComboBox
        Me.TC_rate_modify = New System.Windows.Forms.TabPage
        Me.cmd_edit_RM = New System.Windows.Forms.Button
        Me.cmb_refno_RM = New System.Windows.Forms.ComboBox
        Me.cmd_reset_RM = New System.Windows.Forms.Button
        Me.cmd_update_RM = New System.Windows.Forms.Button
        Me.txt_rate_RM = New System.Windows.Forms.TextBox
        Me.txt_unit_RM = New System.Windows.Forms.TextBox
        Me.txt_desc_RM = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmb_TW_RM = New System.Windows.Forms.ComboBox
        Me.TC_rate_modnew = New System.Windows.Forms.TabPage
        Me.cmd_crtnew_RMN = New System.Windows.Forms.Button
        Me.cmb_refno_RMN = New System.Windows.Forms.ComboBox
        Me.cmd_reset_RMN = New System.Windows.Forms.Button
        Me.cmd_edit_RMN = New System.Windows.Forms.Button
        Me.txt_rate_RMN = New System.Windows.Forms.TextBox
        Me.txt_unit_RMN = New System.Windows.Forms.TextBox
        Me.txt_desc_RMN = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.cmb_TW_RMN = New System.Windows.Forms.ComboBox
        Me.TC_rate_delete = New System.Windows.Forms.TabPage
        Me.txt_TW_RD = New System.Windows.Forms.TextBox
        Me.cmb_refno_RD = New System.Windows.Forms.ComboBox
        Me.cmd_delete_RD = New System.Windows.Forms.Button
        Me.txt_rate_RD = New System.Windows.Forms.TextBox
        Me.txt_unit_RD = New System.Windows.Forms.TextBox
        Me.txt_desc_RD = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TC_rate.SuspendLayout()
        Me.TC_rate_new.SuspendLayout()
        Me.TC_rate_modify.SuspendLayout()
        Me.TC_rate_modnew.SuspendLayout()
        Me.TC_rate_delete.SuspendLayout()
        Me.SuspendLayout()
        '
        'TC_rate
        '
        Me.TC_rate.Controls.Add(Me.TC_rate_new)
        Me.TC_rate.Controls.Add(Me.TC_rate_modify)
        Me.TC_rate.Controls.Add(Me.TC_rate_modnew)
        Me.TC_rate.Controls.Add(Me.TC_rate_delete)
        Me.TC_rate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC_rate.Location = New System.Drawing.Point(0, 0)
        Me.TC_rate.Name = "TC_rate"
        Me.TC_rate.SelectedIndex = 0
        Me.TC_rate.Size = New System.Drawing.Size(594, 237)
        Me.TC_rate.TabIndex = 1
        '
        'TC_rate_new
        '
        Me.TC_rate_new.Controls.Add(Me.cmd_reset_RN)
        Me.TC_rate_new.Controls.Add(Me.cmd_add_RN)
        Me.TC_rate_new.Controls.Add(Me.txt_rate_RN)
        Me.TC_rate_new.Controls.Add(Me.txt_unit_RN)
        Me.TC_rate_new.Controls.Add(Me.txt_refno_RN)
        Me.TC_rate_new.Controls.Add(Me.txt_desc_RN)
        Me.TC_rate_new.Controls.Add(Me.Label7)
        Me.TC_rate_new.Controls.Add(Me.Label4)
        Me.TC_rate_new.Controls.Add(Me.Label3)
        Me.TC_rate_new.Controls.Add(Me.Label2)
        Me.TC_rate_new.Controls.Add(Me.Label1)
        Me.TC_rate_new.Controls.Add(Me.cmb_TW_RN)
        Me.TC_rate_new.Location = New System.Drawing.Point(4, 22)
        Me.TC_rate_new.Name = "TC_rate_new"
        Me.TC_rate_new.Padding = New System.Windows.Forms.Padding(3)
        Me.TC_rate_new.Size = New System.Drawing.Size(586, 211)
        Me.TC_rate_new.TabIndex = 0
        Me.TC_rate_new.Text = "New"
        Me.TC_rate_new.UseVisualStyleBackColor = True
        '
        'cmd_reset_RN
        '
        Me.cmd_reset_RN.Location = New System.Drawing.Point(416, 176)
        Me.cmd_reset_RN.Name = "cmd_reset_RN"
        Me.cmd_reset_RN.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset_RN.TabIndex = 24
        Me.cmd_reset_RN.Text = "&Reset"
        Me.cmd_reset_RN.UseVisualStyleBackColor = True
        '
        'cmd_add_RN
        '
        Me.cmd_add_RN.Location = New System.Drawing.Point(196, 176)
        Me.cmd_add_RN.Name = "cmd_add_RN"
        Me.cmd_add_RN.Size = New System.Drawing.Size(75, 23)
        Me.cmd_add_RN.TabIndex = 23
        Me.cmd_add_RN.Text = "&Add"
        Me.cmd_add_RN.UseVisualStyleBackColor = True
        '
        'txt_rate_RN
        '
        Me.txt_rate_RN.Location = New System.Drawing.Point(380, 141)
        Me.txt_rate_RN.MaxLength = 9
        Me.txt_rate_RN.Name = "txt_rate_RN"
        Me.txt_rate_RN.Size = New System.Drawing.Size(145, 20)
        Me.txt_rate_RN.TabIndex = 20
        '
        'txt_unit_RN
        '
        Me.txt_unit_RN.Location = New System.Drawing.Point(170, 141)
        Me.txt_unit_RN.Name = "txt_unit_RN"
        Me.txt_unit_RN.Size = New System.Drawing.Size(145, 20)
        Me.txt_unit_RN.TabIndex = 19
        '
        'txt_refno_RN
        '
        Me.txt_refno_RN.Location = New System.Drawing.Point(122, 13)
        Me.txt_refno_RN.Name = "txt_refno_RN"
        Me.txt_refno_RN.ReadOnly = True
        Me.txt_refno_RN.Size = New System.Drawing.Size(125, 20)
        Me.txt_refno_RN.TabIndex = 18
        '
        'txt_desc_RN
        '
        Me.txt_desc_RN.Location = New System.Drawing.Point(170, 50)
        Me.txt_desc_RN.Multiline = True
        Me.txt_desc_RN.Name = "txt_desc_RN"
        Me.txt_desc_RN.Size = New System.Drawing.Size(356, 80)
        Me.txt_desc_RN.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Reference number *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Rate *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Unit *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Activity description *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Type of work *"
        '
        'cmb_TW_RN
        '
        Me.cmb_TW_RN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TW_RN.FormattingEnabled = True
        Me.cmb_TW_RN.Items.AddRange(New Object() {"", "Earth Work", "Concrete Work", "R.C.C.  Work", "Brick Work", "Finishing Work", "Flooring", "Steel Work", "Wood Work", "Roofing", "Road Work", "SPT and Temporary Bridges and Culverts", "River Training Work", "Repairs of Building", "Dismanting and Demolishing", "Sinking of M-II / M-III Tubewell", "Roof Treatment", "Miscellaneous"})
        Me.cmb_TW_RN.Location = New System.Drawing.Point(347, 13)
        Me.cmb_TW_RN.Name = "cmb_TW_RN"
        Me.cmb_TW_RN.Size = New System.Drawing.Size(215, 21)
        Me.cmb_TW_RN.TabIndex = 9
        '
        'TC_rate_modify
        '
        Me.TC_rate_modify.Controls.Add(Me.cmd_edit_RM)
        Me.TC_rate_modify.Controls.Add(Me.cmb_refno_RM)
        Me.TC_rate_modify.Controls.Add(Me.cmd_reset_RM)
        Me.TC_rate_modify.Controls.Add(Me.cmd_update_RM)
        Me.TC_rate_modify.Controls.Add(Me.txt_rate_RM)
        Me.TC_rate_modify.Controls.Add(Me.txt_unit_RM)
        Me.TC_rate_modify.Controls.Add(Me.txt_desc_RM)
        Me.TC_rate_modify.Controls.Add(Me.Label8)
        Me.TC_rate_modify.Controls.Add(Me.Label11)
        Me.TC_rate_modify.Controls.Add(Me.Label12)
        Me.TC_rate_modify.Controls.Add(Me.Label13)
        Me.TC_rate_modify.Controls.Add(Me.Label14)
        Me.TC_rate_modify.Controls.Add(Me.cmb_TW_RM)
        Me.TC_rate_modify.Location = New System.Drawing.Point(4, 22)
        Me.TC_rate_modify.Name = "TC_rate_modify"
        Me.TC_rate_modify.Padding = New System.Windows.Forms.Padding(3)
        Me.TC_rate_modify.Size = New System.Drawing.Size(586, 211)
        Me.TC_rate_modify.TabIndex = 1
        Me.TC_rate_modify.Text = "Modify"
        Me.TC_rate_modify.UseVisualStyleBackColor = True
        '
        'cmd_edit_RM
        '
        Me.cmd_edit_RM.Location = New System.Drawing.Point(196, 176)
        Me.cmd_edit_RM.Name = "cmd_edit_RM"
        Me.cmd_edit_RM.Size = New System.Drawing.Size(75, 23)
        Me.cmd_edit_RM.TabIndex = 42
        Me.cmd_edit_RM.Text = "&Edit"
        Me.cmd_edit_RM.UseVisualStyleBackColor = True
        '
        'cmb_refno_RM
        '
        Me.cmb_refno_RM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_refno_RM.FormattingEnabled = True
        Me.cmb_refno_RM.Location = New System.Drawing.Point(122, 13)
        Me.cmb_refno_RM.Name = "cmb_refno_RM"
        Me.cmb_refno_RM.Size = New System.Drawing.Size(137, 21)
        Me.cmb_refno_RM.TabIndex = 41
        '
        'cmd_reset_RM
        '
        Me.cmd_reset_RM.Location = New System.Drawing.Point(416, 176)
        Me.cmd_reset_RM.Name = "cmd_reset_RM"
        Me.cmd_reset_RM.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset_RM.TabIndex = 40
        Me.cmd_reset_RM.Text = "&Reset"
        Me.cmd_reset_RM.UseVisualStyleBackColor = True
        '
        'cmd_update_RM
        '
        Me.cmd_update_RM.Location = New System.Drawing.Point(290, 176)
        Me.cmd_update_RM.Name = "cmd_update_RM"
        Me.cmd_update_RM.Size = New System.Drawing.Size(105, 23)
        Me.cmd_update_RM.TabIndex = 39
        Me.cmd_update_RM.Text = "&Update"
        Me.cmd_update_RM.UseVisualStyleBackColor = True
        '
        'txt_rate_RM
        '
        Me.txt_rate_RM.Location = New System.Drawing.Point(381, 141)
        Me.txt_rate_RM.MaxLength = 9
        Me.txt_rate_RM.Name = "txt_rate_RM"
        Me.txt_rate_RM.Size = New System.Drawing.Size(145, 20)
        Me.txt_rate_RM.TabIndex = 36
        '
        'txt_unit_RM
        '
        Me.txt_unit_RM.Location = New System.Drawing.Point(170, 141)
        Me.txt_unit_RM.Name = "txt_unit_RM"
        Me.txt_unit_RM.Size = New System.Drawing.Size(145, 20)
        Me.txt_unit_RM.TabIndex = 35
        '
        'txt_desc_RM
        '
        Me.txt_desc_RM.Location = New System.Drawing.Point(170, 50)
        Me.txt_desc_RM.Multiline = True
        Me.txt_desc_RM.Name = "txt_desc_RM"
        Me.txt_desc_RM.Size = New System.Drawing.Size(356, 80)
        Me.txt_desc_RM.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Reference number *"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(338, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Rate *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(134, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Unit *"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(62, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Activity description *"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(265, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Type of work *"
        '
        'cmb_TW_RM
        '
        Me.cmb_TW_RM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TW_RM.FormattingEnabled = True
        Me.cmb_TW_RM.Items.AddRange(New Object() {"", "Earth Work", "Concrete Work", "R.C.C.  Work", "Brick Work", "Finishing Work", "Flooring", "Steel Work", "Wood Work", "Roofing", "Road Work", "SPT and Temporary Bridges and Culverts", "River Training Work", "Repairs of Building", "Dismanting and Demolishing", "Sinking of M-II / M-III Tubewell", "Roof Treatment", "Miscellaneous"})
        Me.cmb_TW_RM.Location = New System.Drawing.Point(347, 13)
        Me.cmb_TW_RM.Name = "cmb_TW_RM"
        Me.cmb_TW_RM.Size = New System.Drawing.Size(215, 21)
        Me.cmb_TW_RM.TabIndex = 25
        '
        'TC_rate_modnew
        '
        Me.TC_rate_modnew.Controls.Add(Me.cmd_crtnew_RMN)
        Me.TC_rate_modnew.Controls.Add(Me.cmb_refno_RMN)
        Me.TC_rate_modnew.Controls.Add(Me.cmd_reset_RMN)
        Me.TC_rate_modnew.Controls.Add(Me.cmd_edit_RMN)
        Me.TC_rate_modnew.Controls.Add(Me.txt_rate_RMN)
        Me.TC_rate_modnew.Controls.Add(Me.txt_unit_RMN)
        Me.TC_rate_modnew.Controls.Add(Me.txt_desc_RMN)
        Me.TC_rate_modnew.Controls.Add(Me.Label22)
        Me.TC_rate_modnew.Controls.Add(Me.Label25)
        Me.TC_rate_modnew.Controls.Add(Me.Label26)
        Me.TC_rate_modnew.Controls.Add(Me.Label27)
        Me.TC_rate_modnew.Controls.Add(Me.Label28)
        Me.TC_rate_modnew.Controls.Add(Me.cmb_TW_RMN)
        Me.TC_rate_modnew.Location = New System.Drawing.Point(4, 22)
        Me.TC_rate_modnew.Name = "TC_rate_modnew"
        Me.TC_rate_modnew.Size = New System.Drawing.Size(586, 211)
        Me.TC_rate_modnew.TabIndex = 3
        Me.TC_rate_modnew.Text = "Modify to new"
        Me.TC_rate_modnew.UseVisualStyleBackColor = True
        '
        'cmd_crtnew_RMN
        '
        Me.cmd_crtnew_RMN.Location = New System.Drawing.Point(290, 176)
        Me.cmd_crtnew_RMN.Name = "cmd_crtnew_RMN"
        Me.cmd_crtnew_RMN.Size = New System.Drawing.Size(105, 23)
        Me.cmd_crtnew_RMN.TabIndex = 59
        Me.cmd_crtnew_RMN.Text = "&Create New"
        Me.cmd_crtnew_RMN.UseVisualStyleBackColor = True
        '
        'cmb_refno_RMN
        '
        Me.cmb_refno_RMN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_refno_RMN.FormattingEnabled = True
        Me.cmb_refno_RMN.Location = New System.Drawing.Point(122, 13)
        Me.cmb_refno_RMN.Name = "cmb_refno_RMN"
        Me.cmb_refno_RMN.Size = New System.Drawing.Size(137, 21)
        Me.cmb_refno_RMN.TabIndex = 58
        '
        'cmd_reset_RMN
        '
        Me.cmd_reset_RMN.Location = New System.Drawing.Point(416, 176)
        Me.cmd_reset_RMN.Name = "cmd_reset_RMN"
        Me.cmd_reset_RMN.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset_RMN.TabIndex = 57
        Me.cmd_reset_RMN.Text = "&Reset"
        Me.cmd_reset_RMN.UseVisualStyleBackColor = True
        '
        'cmd_edit_RMN
        '
        Me.cmd_edit_RMN.Location = New System.Drawing.Point(196, 176)
        Me.cmd_edit_RMN.Name = "cmd_edit_RMN"
        Me.cmd_edit_RMN.Size = New System.Drawing.Size(75, 23)
        Me.cmd_edit_RMN.TabIndex = 56
        Me.cmd_edit_RMN.Text = "&Edit"
        Me.cmd_edit_RMN.UseVisualStyleBackColor = True
        '
        'txt_rate_RMN
        '
        Me.txt_rate_RMN.Location = New System.Drawing.Point(381, 141)
        Me.txt_rate_RMN.MaxLength = 9
        Me.txt_rate_RMN.Name = "txt_rate_RMN"
        Me.txt_rate_RMN.Size = New System.Drawing.Size(145, 20)
        Me.txt_rate_RMN.TabIndex = 53
        '
        'txt_unit_RMN
        '
        Me.txt_unit_RMN.Location = New System.Drawing.Point(170, 141)
        Me.txt_unit_RMN.Name = "txt_unit_RMN"
        Me.txt_unit_RMN.Size = New System.Drawing.Size(145, 20)
        Me.txt_unit_RMN.TabIndex = 52
        '
        'txt_desc_RMN
        '
        Me.txt_desc_RMN.Location = New System.Drawing.Point(170, 50)
        Me.txt_desc_RMN.Multiline = True
        Me.txt_desc_RMN.Name = "txt_desc_RMN"
        Me.txt_desc_RMN.Size = New System.Drawing.Size(356, 80)
        Me.txt_desc_RMN.TabIndex = 51
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 13)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Reference number *"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(338, 144)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 13)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Rate *"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(134, 144)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(33, 13)
        Me.Label26.TabIndex = 46
        Me.Label26.Text = "Unit *"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(62, 80)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 13)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Activity description *"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(265, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(76, 13)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "Type of work *"
        '
        'cmb_TW_RMN
        '
        Me.cmb_TW_RMN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TW_RMN.FormattingEnabled = True
        Me.cmb_TW_RMN.Items.AddRange(New Object() {"", "Earth Work", "Concrete Work", "R.C.C.  Work", "Brick Work", "Finishing Work", "Flooring", "Steel Work", "Wood Work", "Roofing", "Road Work", "SPT and Temporary Bridges and Culverts", "River Training Work", "Repairs of Building", "Dismanting and Demolishing", "Sinking of M-II / M-III Tubewell", "Roof Treatment", "Miscellaneous"})
        Me.cmb_TW_RMN.Location = New System.Drawing.Point(347, 13)
        Me.cmb_TW_RMN.Name = "cmb_TW_RMN"
        Me.cmb_TW_RMN.Size = New System.Drawing.Size(215, 21)
        Me.cmb_TW_RMN.TabIndex = 43
        '
        'TC_rate_delete
        '
        Me.TC_rate_delete.Controls.Add(Me.txt_TW_RD)
        Me.TC_rate_delete.Controls.Add(Me.cmb_refno_RD)
        Me.TC_rate_delete.Controls.Add(Me.cmd_delete_RD)
        Me.TC_rate_delete.Controls.Add(Me.txt_rate_RD)
        Me.TC_rate_delete.Controls.Add(Me.txt_unit_RD)
        Me.TC_rate_delete.Controls.Add(Me.txt_desc_RD)
        Me.TC_rate_delete.Controls.Add(Me.Label15)
        Me.TC_rate_delete.Controls.Add(Me.Label18)
        Me.TC_rate_delete.Controls.Add(Me.Label19)
        Me.TC_rate_delete.Controls.Add(Me.Label20)
        Me.TC_rate_delete.Controls.Add(Me.Label21)
        Me.TC_rate_delete.Location = New System.Drawing.Point(4, 22)
        Me.TC_rate_delete.Name = "TC_rate_delete"
        Me.TC_rate_delete.Size = New System.Drawing.Size(586, 211)
        Me.TC_rate_delete.TabIndex = 2
        Me.TC_rate_delete.Text = "Delete"
        Me.TC_rate_delete.UseVisualStyleBackColor = True
        '
        'txt_TW_RD
        '
        Me.txt_TW_RD.Location = New System.Drawing.Point(347, 13)
        Me.txt_TW_RD.Name = "txt_TW_RD"
        Me.txt_TW_RD.ReadOnly = True
        Me.txt_TW_RD.Size = New System.Drawing.Size(200, 20)
        Me.txt_TW_RD.TabIndex = 43
        '
        'cmb_refno_RD
        '
        Me.cmb_refno_RD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_refno_RD.FormattingEnabled = True
        Me.cmb_refno_RD.Location = New System.Drawing.Point(122, 13)
        Me.cmb_refno_RD.Name = "cmb_refno_RD"
        Me.cmb_refno_RD.Size = New System.Drawing.Size(137, 21)
        Me.cmb_refno_RD.TabIndex = 42
        '
        'cmd_delete_RD
        '
        Me.cmd_delete_RD.Location = New System.Drawing.Point(290, 176)
        Me.cmd_delete_RD.Name = "cmd_delete_RD"
        Me.cmd_delete_RD.Size = New System.Drawing.Size(75, 23)
        Me.cmd_delete_RD.TabIndex = 39
        Me.cmd_delete_RD.Text = "&Delete"
        Me.cmd_delete_RD.UseVisualStyleBackColor = True
        '
        'txt_rate_RD
        '
        Me.txt_rate_RD.Location = New System.Drawing.Point(381, 141)
        Me.txt_rate_RD.MaxLength = 9
        Me.txt_rate_RD.Name = "txt_rate_RD"
        Me.txt_rate_RD.ReadOnly = True
        Me.txt_rate_RD.Size = New System.Drawing.Size(145, 20)
        Me.txt_rate_RD.TabIndex = 36
        '
        'txt_unit_RD
        '
        Me.txt_unit_RD.Location = New System.Drawing.Point(170, 141)
        Me.txt_unit_RD.Name = "txt_unit_RD"
        Me.txt_unit_RD.ReadOnly = True
        Me.txt_unit_RD.Size = New System.Drawing.Size(145, 20)
        Me.txt_unit_RD.TabIndex = 35
        '
        'txt_desc_RD
        '
        Me.txt_desc_RD.Location = New System.Drawing.Point(170, 50)
        Me.txt_desc_RD.Multiline = True
        Me.txt_desc_RD.Name = "txt_desc_RD"
        Me.txt_desc_RD.ReadOnly = True
        Me.txt_desc_RD.Size = New System.Drawing.Size(356, 80)
        Me.txt_desc_RD.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(14, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Reference number *"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(338, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Rate *"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(134, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "Unit *"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(62, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 13)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Activity description *"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(265, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Type of work *"
        '
        'frm_rate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 237)
        Me.Controls.Add(Me.TC_rate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(610, 275)
        Me.MinimumSize = New System.Drawing.Size(610, 275)
        Me.Name = "frm_rate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rates"
        Me.TC_rate.ResumeLayout(False)
        Me.TC_rate_new.ResumeLayout(False)
        Me.TC_rate_new.PerformLayout()
        Me.TC_rate_modify.ResumeLayout(False)
        Me.TC_rate_modify.PerformLayout()
        Me.TC_rate_modnew.ResumeLayout(False)
        Me.TC_rate_modnew.PerformLayout()
        Me.TC_rate_delete.ResumeLayout(False)
        Me.TC_rate_delete.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TC_rate As System.Windows.Forms.TabControl
    Friend WithEvents TC_rate_new As System.Windows.Forms.TabPage
    Friend WithEvents TC_rate_modify As System.Windows.Forms.TabPage
    Friend WithEvents txt_desc_RN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_TW_RN As System.Windows.Forms.ComboBox
    Friend WithEvents TC_rate_delete As System.Windows.Forms.TabPage
    Friend WithEvents txt_unit_RN As System.Windows.Forms.TextBox
    Friend WithEvents txt_refno_RN As System.Windows.Forms.TextBox
    Friend WithEvents TC_rate_modnew As System.Windows.Forms.TabPage
    Friend WithEvents txt_rate_RN As System.Windows.Forms.TextBox
    Friend WithEvents cmd_reset_RN As System.Windows.Forms.Button
    Friend WithEvents cmd_add_RN As System.Windows.Forms.Button
    Friend WithEvents cmb_refno_RM As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_reset_RM As System.Windows.Forms.Button
    Friend WithEvents cmd_update_RM As System.Windows.Forms.Button
    Friend WithEvents txt_rate_RM As System.Windows.Forms.TextBox
    Friend WithEvents txt_unit_RM As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc_RM As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_TW_RM As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_edit_RM As System.Windows.Forms.Button
    Friend WithEvents cmd_crtnew_RMN As System.Windows.Forms.Button
    Friend WithEvents cmb_refno_RMN As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_reset_RMN As System.Windows.Forms.Button
    Friend WithEvents cmd_edit_RMN As System.Windows.Forms.Button
    Friend WithEvents txt_rate_RMN As System.Windows.Forms.TextBox
    Friend WithEvents txt_unit_RMN As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc_RMN As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cmb_TW_RMN As System.Windows.Forms.ComboBox
    Friend WithEvents txt_TW_RD As System.Windows.Forms.TextBox
    Friend WithEvents cmb_refno_RD As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_delete_RD As System.Windows.Forms.Button
    Friend WithEvents txt_rate_RD As System.Windows.Forms.TextBox
    Friend WithEvents txt_unit_RD As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc_RD As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
