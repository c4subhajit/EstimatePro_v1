Public Class frm_report_reservoirEst
   
    Private Sub frm_report_reservoirEst_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_Estimate_home.refNo_reservoirEst = ""
        frm_Estimate_home.parentEstimateForm = ""
    End Sub

    Private Sub frm_report_reservoirEst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'REFRESHING THE REPORT VIEWER WITH VARIABLES
        '============================================
        Try
            Me.Estimate_pondTableAdapter.Fill(Me.Report_PondEstDataSet.Estimate_pond, frm_Estimate_home.refNo_reservoirEst)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Info")
        End Try
    End Sub

End Class