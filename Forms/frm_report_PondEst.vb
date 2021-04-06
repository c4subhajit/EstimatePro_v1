Imports System.Data
Imports System.Data.SqlClient

Public Class frm_report_pondEst
    Dim con_cls As New class_connect_string
    Dim dr As SqlDataReader
    Public refAmount(10), refQuantity(10), refRate(10) As Double
    Public refNoAmt(10) As Integer
    Public totRefNo As Integer
    Public refDescAct(10), refUnit(10) As String

    Private Sub frm_report_pondEst_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'UPDATING THE ESTIMATE DETAILS FOR REPORT
        '============================================

        'BLOCK 1: DELETING ALL PREVIOUS ESTIMATE RECORDS FROM ESTDETAILS_REPORT.
        '-----------------------------------------------------------------------
        Try
            con_cls.connect()
            con_cls.cmd.CommandText = "DELETE FROM EstDetails_Report"
            con_cls.cmd.ExecuteNonQuery()
            con_cls.disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error in Estimate Detail table delete Block 1")
        End Try
        '-----------------------------------------------------------------------


        'BLOCK 2: READING SELECTED REFERENCE NUMBERS AND THEIR RESPECTIVE QUANTITIES.
        '----------------------------------------------------------------------------
        Try
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
            dr = con_cls.cmd.ExecuteReader()
            If dr.HasRows Then
                Try
                    dr.Read()
                    totRefNo = dr.Item("totRateRef")
                    For i = 1 To totRefNo
                        refNoAmt(i) = dr.Item("refno" & i)
                        refQuantity(i) = CDbl(dr.Item("qty" & i))
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Dataread error in Estimate Detail Update Block 2")
                End Try
                dr.Close()
            End If
            con_cls.disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error in Estimate Detail Update Block 2")
        End Try
        '------------------------------------------------------------------------------------


        'BLOCK 3: READING SELECTED REFERENCE'S 
        '--------------------------------------
        Try
            con_cls.connect()
            For i = 1 To totRefNo
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE refDataNo=" & refNoAmt(i)
                dr = con_cls.cmd.ExecuteReader()
                If dr.HasRows Then
                    Try
                        dr.Read()
                        refDescAct(i) = dr.Item("descActivity")
                        refUnit(i) = dr.Item("unit")
                        refRate(i) = CDbl(dr.Item("rate"))
                        refAmount(i) = Math.Round(CDbl(refQuantity(i) * refRate(i)), 2)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Dataread error in Estimate Detail Update Block 3")
                    End Try
                    dr.Close()
                End If
            Next
            con_cls.disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error in Estimate Detail Update Block 3")
        End Try
        '--------------------------------------


        'BLOCK 4:UPDATING ALL DETAILS IN ESTDETAILS_POND.
        '------------------------------------------------
        Try
            con_cls.connect()
            For i = 1 To totRefNo
                con_cls.cmd.CommandText = "INSERT INTO EstDetails_Report (itemNo,descAct,unit,rate,quantity,amount) VALUES (" & i & ",'" & _
                refDescAct(i) & "','" & refUnit(i) & "'," & refRate(i) & "," & refQuantity(i) & "," & refAmount(i) & ")"
                con_cls.cmd.ExecuteNonQuery()
            Next
            con_cls.connect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error in Estimate Detail Update Block 4")
        End Try
        '------------------------------------------------


        'BLOCK 5:REFRESHING THE REPORT VIEWER WITH VARIABLES
        '============================================
        Try
            Me.DataTable_PondEstDetailsTableAdapter.Fill(Me.Report_PondEst.DataTable_PondEstDetails, frm_Estimate_home.refNo_pondEst)
            Me.EstDetails_ReportTableAdapter.Fill(Me.Report_PondEst.EstDetails_Report)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in report update Block 5")
        End Try
        
    End Sub

    Private Sub frm_report_pondEst_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frm_Estimate_home.refNo_pondEst = ""
        frm_Estimate_home.parentEstimateForm = ""
    End Sub

End Class