<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_view))
        Me.cmb_estType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_refNo = New System.Windows.Forms.ComboBox
        Me.cmd_viewEst = New System.Windows.Forms.Button
        Me.cmd_deleteEst = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmb_estType
        '
        Me.cmb_estType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estType.FormattingEnabled = True
        Me.cmb_estType.Items.AddRange(New Object() {"", "Reservoir", "Pond"})
        Me.cmb_estType.Location = New System.Drawing.Point(141, 6)
        Me.cmb_estType.Name = "cmb_estType"
        Me.cmb_estType.Size = New System.Drawing.Size(231, 21)
        Me.cmb_estType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select estimate type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select reference number"
        '
        'cmb_refNo
        '
        Me.cmb_refNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_refNo.FormattingEnabled = True
        Me.cmb_refNo.Location = New System.Drawing.Point(141, 44)
        Me.cmb_refNo.Name = "cmb_refNo"
        Me.cmb_refNo.Size = New System.Drawing.Size(231, 21)
        Me.cmb_refNo.TabIndex = 3
        '
        'cmd_viewEst
        '
        Me.cmd_viewEst.Location = New System.Drawing.Point(206, 79)
        Me.cmd_viewEst.Name = "cmd_viewEst"
        Me.cmd_viewEst.Size = New System.Drawing.Size(150, 23)
        Me.cmd_viewEst.TabIndex = 4
        Me.cmd_viewEst.Text = "&View Estimate Details"
        Me.cmd_viewEst.UseVisualStyleBackColor = True
        '
        'cmd_deleteEst
        '
        Me.cmd_deleteEst.Location = New System.Drawing.Point(27, 79)
        Me.cmd_deleteEst.Name = "cmd_deleteEst"
        Me.cmd_deleteEst.Size = New System.Drawing.Size(150, 23)
        Me.cmd_deleteEst.TabIndex = 5
        Me.cmd_deleteEst.Text = "&Delete Estimate Details"
        Me.cmd_deleteEst.UseVisualStyleBackColor = True
        '
        'frm_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 112)
        Me.Controls.Add(Me.cmd_deleteEst)
        Me.Controls.Add(Me.cmd_viewEst)
        Me.Controls.Add(Me.cmb_refNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_estType)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 150)
        Me.MinimumSize = New System.Drawing.Size(400, 150)
        Me.Name = "frm_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "View previous estimate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_estType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_refNo As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_viewEst As System.Windows.Forms.Button
    Friend WithEvents cmd_deleteEst As System.Windows.Forms.Button
End Class
