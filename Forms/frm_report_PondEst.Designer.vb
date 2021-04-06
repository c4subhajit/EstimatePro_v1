<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report_pondEst
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_report_pondEst))
        Me.EstDetails_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Report_PondEst = New EstimatePro_v2.Report_PondEst
        Me.DataTable_PondEstDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.DataTable_PondEstDetailsTableAdapter = New EstimatePro_v2.Report_PondEstTableAdapters.DataTable_PondEstDetailsTableAdapter
        Me.EstDetails_ReportTableAdapter = New EstimatePro_v2.Report_PondEstTableAdapters.EstDetails_ReportTableAdapter
        CType(Me.EstDetails_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Report_PondEst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable_PondEstDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstDetails_ReportBindingSource
        '
        Me.EstDetails_ReportBindingSource.DataMember = "EstDetails_Report"
        Me.EstDetails_ReportBindingSource.DataSource = Me.Report_PondEst
        '
        'Report_PondEst
        '
        Me.Report_PondEst.DataSetName = "Report_PondEst"
        Me.Report_PondEst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable_PondEstDetailsBindingSource
        '
        Me.DataTable_PondEstDetailsBindingSource.DataMember = "DataTable_PondEstDetails"
        Me.DataTable_PondEstDetailsBindingSource.DataSource = Me.Report_PondEst
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Report_PondEst_EstDetails_Report"
        ReportDataSource1.Value = Me.EstDetails_ReportBindingSource
        ReportDataSource2.Name = "Report_PondEst_DataTable_PondEstDetails"
        ReportDataSource2.Value = Me.DataTable_PondEstDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "EstimatePro_v2.Report_PondEstData.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(684, 462)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataTable_PondEstDetailsTableAdapter
        '
        Me.DataTable_PondEstDetailsTableAdapter.ClearBeforeFill = True
        '
        'EstDetails_ReportTableAdapter
        '
        Me.EstDetails_ReportTableAdapter.ClearBeforeFill = True
        '
        'frm_report_pondEst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 500)
        Me.Name = "frm_report_pondEst"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Report of Pond Estimate"
        CType(Me.EstDetails_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Report_PondEst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable_PondEstDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable_PondEstDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Report_PondEst As EstimatePro_v2.Report_PondEst
    Friend WithEvents EstDetails_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable_PondEstDetailsTableAdapter As EstimatePro_v2.Report_PondEstTableAdapters.DataTable_PondEstDetailsTableAdapter
    Friend WithEvents EstDetails_ReportTableAdapter As EstimatePro_v2.Report_PondEstTableAdapters.EstDetails_ReportTableAdapter
End Class
