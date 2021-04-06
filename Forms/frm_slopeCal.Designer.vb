<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_slopeCal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_slopeCal))
        Me.GPB_slopeCal = New System.Windows.Forms.GroupBox
        Me.cmd_reset = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmd_calSlope = New System.Windows.Forms.Button
        Me.txt_slope_percent = New System.Windows.Forms.TextBox
        Me.txt_slope_base = New System.Windows.Forms.TextBox
        Me.txt_slope_perp = New System.Windows.Forms.TextBox
        Me.GPB_slopeCal.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPB_slopeCal
        '
        Me.GPB_slopeCal.Controls.Add(Me.cmd_reset)
        Me.GPB_slopeCal.Controls.Add(Me.Label29)
        Me.GPB_slopeCal.Controls.Add(Me.Label23)
        Me.GPB_slopeCal.Controls.Add(Me.Label17)
        Me.GPB_slopeCal.Controls.Add(Me.cmd_calSlope)
        Me.GPB_slopeCal.Controls.Add(Me.txt_slope_percent)
        Me.GPB_slopeCal.Controls.Add(Me.txt_slope_base)
        Me.GPB_slopeCal.Controls.Add(Me.txt_slope_perp)
        Me.GPB_slopeCal.Location = New System.Drawing.Point(12, 12)
        Me.GPB_slopeCal.Name = "GPB_slopeCal"
        Me.GPB_slopeCal.Size = New System.Drawing.Size(240, 129)
        Me.GPB_slopeCal.TabIndex = 1
        Me.GPB_slopeCal.TabStop = False
        Me.GPB_slopeCal.Text = "Slope percent calculator"
        '
        'cmd_reset
        '
        Me.cmd_reset.Location = New System.Drawing.Point(144, 95)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(75, 23)
        Me.cmd_reset.TabIndex = 5
        Me.cmd_reset.Text = "&Reset"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(44, 69)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Slope in %"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(129, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(17, 22)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(5, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Slope"
        '
        'cmd_calSlope
        '
        Me.cmd_calSlope.Location = New System.Drawing.Point(38, 95)
        Me.cmd_calSlope.Name = "cmd_calSlope"
        Me.cmd_calSlope.Size = New System.Drawing.Size(75, 23)
        Me.cmd_calSlope.TabIndex = 4
        Me.cmd_calSlope.Text = "&Calculate"
        Me.cmd_calSlope.UseVisualStyleBackColor = True
        '
        'txt_slope_percent
        '
        Me.txt_slope_percent.Location = New System.Drawing.Point(103, 66)
        Me.txt_slope_percent.Name = "txt_slope_percent"
        Me.txt_slope_percent.ReadOnly = True
        Me.txt_slope_percent.Size = New System.Drawing.Size(83, 20)
        Me.txt_slope_percent.TabIndex = 1
        '
        'txt_slope_base
        '
        Me.txt_slope_base.Location = New System.Drawing.Point(151, 19)
        Me.txt_slope_base.Multiline = True
        Me.txt_slope_base.Name = "txt_slope_base"
        Me.txt_slope_base.Size = New System.Drawing.Size(80, 40)
        Me.txt_slope_base.TabIndex = 3
        Me.txt_slope_base.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_slope_perp
        '
        Me.txt_slope_perp.Location = New System.Drawing.Point(45, 19)
        Me.txt_slope_perp.Multiline = True
        Me.txt_slope_perp.Name = "txt_slope_perp"
        Me.txt_slope_perp.Size = New System.Drawing.Size(80, 40)
        Me.txt_slope_perp.TabIndex = 2
        Me.txt_slope_perp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_slopeCal
        '
        Me.AcceptButton = Me.cmd_calSlope
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 152)
        Me.Controls.Add(Me.GPB_slopeCal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(280, 190)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(280, 190)
        Me.Name = "frm_slopeCal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slope percent calculator"
        Me.GPB_slopeCal.ResumeLayout(False)
        Me.GPB_slopeCal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GPB_slopeCal As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmd_calSlope As System.Windows.Forms.Button
    Friend WithEvents txt_slope_percent As System.Windows.Forms.TextBox
    Friend WithEvents txt_slope_base As System.Windows.Forms.TextBox
    Friend WithEvents txt_slope_perp As System.Windows.Forms.TextBox
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
End Class
