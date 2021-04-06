<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estimate_Uinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estimate_Uinfo))
        Me.cmd_cancel = New System.Windows.Forms.Button
        Me.cmd_save = New System.Windows.Forms.Button
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.cmd_genRep = New System.Windows.Forms.Button
        Me.txt_nameIO = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_durWork = New System.Windows.Forms.TextBox
        Me.txt_nameEE = New System.Windows.Forms.TextBox
        Me.txt_nameSO = New System.Windows.Forms.TextBox
        Me.txt_totCost = New System.Windows.Forms.TextBox
        Me.txt_finYear = New System.Windows.Forms.TextBox
        Me.txt_locationWork = New System.Windows.Forms.TextBox
        Me.txt_nameBen = New System.Windows.Forms.TextBox
        Me.txt_nameWork = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_prog = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmd_cancel
        '
        Me.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancel.Location = New System.Drawing.Point(225, 295)
        Me.cmd_cancel.Name = "cmd_cancel"
        Me.cmd_cancel.Size = New System.Drawing.Size(75, 23)
        Me.cmd_cancel.TabIndex = 13
        Me.cmd_cancel.Text = "&Cancel"
        Me.cmd_cancel.UseVisualStyleBackColor = True
        '
        'cmd_save
        '
        Me.cmd_save.Location = New System.Drawing.Point(131, 295)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(75, 23)
        Me.cmd_save.TabIndex = 10
        Me.cmd_save.Text = "&Save"
        Me.cmd_save.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(36, 295)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 12
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'cmd_genRep
        '
        Me.cmd_genRep.Location = New System.Drawing.Point(116, 262)
        Me.cmd_genRep.Name = "cmd_genRep"
        Me.cmd_genRep.Size = New System.Drawing.Size(114, 25)
        Me.cmd_genRep.TabIndex = 11
        Me.cmd_genRep.Text = "&Generate report"
        Me.cmd_genRep.UseVisualStyleBackColor = True
        '
        'txt_nameIO
        '
        Me.txt_nameIO.Location = New System.Drawing.Point(172, 159)
        Me.txt_nameIO.MaxLength = 250
        Me.txt_nameIO.Name = "txt_nameIO"
        Me.txt_nameIO.Size = New System.Drawing.Size(150, 20)
        Me.txt_nameIO.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(21, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(145, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Duration of work"
        '
        'txt_durWork
        '
        Me.txt_durWork.Location = New System.Drawing.Point(172, 234)
        Me.txt_durWork.MaxLength = 100
        Me.txt_durWork.Name = "txt_durWork"
        Me.txt_durWork.Size = New System.Drawing.Size(150, 20)
        Me.txt_durWork.TabIndex = 9
        '
        'txt_nameEE
        '
        Me.txt_nameEE.Location = New System.Drawing.Point(172, 209)
        Me.txt_nameEE.MaxLength = 250
        Me.txt_nameEE.Name = "txt_nameEE"
        Me.txt_nameEE.Size = New System.Drawing.Size(150, 20)
        Me.txt_nameEE.TabIndex = 8
        '
        'txt_nameSO
        '
        Me.txt_nameSO.Location = New System.Drawing.Point(172, 184)
        Me.txt_nameSO.MaxLength = 250
        Me.txt_nameSO.Name = "txt_nameSO"
        Me.txt_nameSO.Size = New System.Drawing.Size(150, 20)
        Me.txt_nameSO.TabIndex = 7
        '
        'txt_totCost
        '
        Me.txt_totCost.Location = New System.Drawing.Point(172, 134)
        Me.txt_totCost.Name = "txt_totCost"
        Me.txt_totCost.ReadOnly = True
        Me.txt_totCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_totCost.Size = New System.Drawing.Size(150, 20)
        Me.txt_totCost.TabIndex = 53
        Me.txt_totCost.TabStop = False
        '
        'txt_finYear
        '
        Me.txt_finYear.Location = New System.Drawing.Point(172, 109)
        Me.txt_finYear.MaxLength = 50
        Me.txt_finYear.Name = "txt_finYear"
        Me.txt_finYear.Size = New System.Drawing.Size(150, 20)
        Me.txt_finYear.TabIndex = 5
        '
        'txt_locationWork
        '
        Me.txt_locationWork.Location = New System.Drawing.Point(172, 84)
        Me.txt_locationWork.MaxLength = 250
        Me.txt_locationWork.Name = "txt_locationWork"
        Me.txt_locationWork.Size = New System.Drawing.Size(150, 20)
        Me.txt_locationWork.TabIndex = 4
        '
        'txt_nameBen
        '
        Me.txt_nameBen.Location = New System.Drawing.Point(172, 59)
        Me.txt_nameBen.MaxLength = 250
        Me.txt_nameBen.Name = "txt_nameBen"
        Me.txt_nameBen.Size = New System.Drawing.Size(150, 20)
        Me.txt_nameBen.TabIndex = 3
        '
        'txt_nameWork
        '
        Me.txt_nameWork.Location = New System.Drawing.Point(172, 34)
        Me.txt_nameWork.MaxLength = 250
        Me.txt_nameWork.Name = "txt_nameWork"
        Me.txt_nameWork.Size = New System.Drawing.Size(150, 20)
        Me.txt_nameWork.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(21, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Name of estimator"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(21, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(145, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Name of supervising officer"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(21, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(145, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Name of implementing officer"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(21, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(145, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Total cost"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(21, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Financial year"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(145, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Location of work"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Name of benificiary"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Name of work"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(21, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(145, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Name of program"
        '
        'txt_prog
        '
        Me.txt_prog.Location = New System.Drawing.Point(172, 8)
        Me.txt_prog.MaxLength = 250
        Me.txt_prog.Name = "txt_prog"
        Me.txt_prog.Size = New System.Drawing.Size(150, 20)
        Me.txt_prog.TabIndex = 1
        '
        'frm_estimate_Uinfo
        '
        Me.AcceptButton = Me.cmd_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmd_cancel
        Me.ClientSize = New System.Drawing.Size(344, 327)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_prog)
        Me.Controls.Add(Me.cmd_cancel)
        Me.Controls.Add(Me.cmd_save)
        Me.Controls.Add(Me.cmd_reset)
        Me.Controls.Add(Me.cmd_genRep)
        Me.Controls.Add(Me.txt_nameIO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_durWork)
        Me.Controls.Add(Me.txt_nameEE)
        Me.Controls.Add(Me.txt_nameSO)
        Me.Controls.Add(Me.txt_totCost)
        Me.Controls.Add(Me.txt_finYear)
        Me.Controls.Add(Me.txt_locationWork)
        Me.Controls.Add(Me.txt_nameBen)
        Me.Controls.Add(Me.txt_nameWork)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(360, 365)
        Me.MinimumSize = New System.Drawing.Size(360, 365)
        Me.Name = "frm_estimate_Uinfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Project details of estimate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_save As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents cmd_genRep As System.Windows.Forms.Button
    Friend WithEvents txt_nameIO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_durWork As System.Windows.Forms.TextBox
    Friend WithEvents txt_nameEE As System.Windows.Forms.TextBox
    Friend WithEvents txt_nameSO As System.Windows.Forms.TextBox
    Friend WithEvents txt_totCost As System.Windows.Forms.TextBox
    Friend WithEvents txt_finYear As System.Windows.Forms.TextBox
    Friend WithEvents txt_locationWork As System.Windows.Forms.TextBox
    Friend WithEvents txt_nameBen As System.Windows.Forms.TextBox
    Friend WithEvents txt_nameWork As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_prog As System.Windows.Forms.TextBox
End Class
