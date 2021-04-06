<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report_reservoirEst
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
        Me.components = New System.ComponentModel.Container
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_report_reservoirEst))
        Me.Estimate_pondBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Report_PondEstDataSet = New EstimatePro_v2.Report_PondEstDataSet
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Estimate_pondTableAdapter = New EstimatePro_v2.Report_PondEstDataSetTableAdapters.Estimate_pondTableAdapter
        CType(Me.Estimate_pondBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Report_PondEstDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Estimate_pondBindingSource
        '
        Me.Estimate_pondBindingSource.DataMember = "Estimate_pond"
        Me.Estimate_pondBindingSource.DataSource = Me.Report_PondEstDataSet
        '
        'Report_PondEstDataSet
        '
        Me.Report_PondEstDataSet.DataSetName = "Report_PondEstDataSet"
        Me.Report_PondEstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Report_PondEstDataSet_Estimate_pond"
        ReportDataSource1.Value = Me.Estimate_pondBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EstimatePro_v2.Report_ReservoirEst.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(684, 462)
        Me.ReportViewer1.TabIndex = 0
        '
        'Estimate_pondTableAdapter
        '
        Me.Estimate_pondTableAdapter.ClearBeforeFill = True
        '
        'frm_report_reservoirEst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "frm_report_reservoirEst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Report of Reservoir Estimate"
        CType(Me.Estimate_pondBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Report_PondEstDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Estimate_pondBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Report_PondEstDataSet As EstimatePro_v2.Report_PondEstDataSet
    Friend WithEvents Estimate_pondTableAdapter As EstimatePro_v2.Report_PondEstDataSetTableAdapters.Estimate_pondTableAdapter
End Class
