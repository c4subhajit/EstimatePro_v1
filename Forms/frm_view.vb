Imports System.Data
Imports System.Data.SqlClient

Public Class frm_view
    Dim con_cls As New class_connect_string
    Dim dr As SqlDataReader
    Public viewClickStatus As String

    Private Sub cmb_estType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_estType.SelectedIndexChanged
        cmb_refNo.Items.Clear()
        If cmb_estType.SelectedItem = "Reservoir" Then
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "SELECT refNo FROM Estimate_reservoir"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    Try
                        While dr.Read
                            cmb_refNo.Items.Add(dr.Item("refNo"))
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read error")
                    End Try
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching estimate details onto the form")
            End Try
            con_cls.disconnect()
        End If
        If cmb_estType.SelectedItem = "Pond" Then
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "SELECT refNo FROM Estimate_pond"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    Try
                        While dr.Read
                            cmb_refNo.Items.Add(dr.Item("refNo"))
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Data reader item read error")
                    End Try
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching estimate details onto the form")
            End Try
            con_cls.disconnect()
        End If
    End Sub

    Private Sub cmd_viewEst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_viewEst.Click
        viewClickStatus = ""
        If cmb_estType.SelectedItem = "" Then
            MsgBox("Please select type of estimate first.", MsgBoxStyle.OkOnly, "Data reader item read error")
            Exit Sub
        ElseIf cmb_refNo.SelectedItem = "" Then
            MsgBox("Please select reference number to view.", MsgBoxStyle.OkOnly, "Data reader item read error")
            Exit Sub
        End If

        If (Not cmb_refNo.SelectedItem = "") And cmb_estType.SelectedItem = "Reservoir" Then
            Try
                Dim form As New frm_report_reservoirEst
                form.MdiParent = frm_Estimate_home
                frm_Estimate_home.refNo_reservoirEst = cmb_refNo.SelectedItem
                form.Show()
                viewClickStatus = "TRUE"
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        End If

        If (Not cmb_refNo.SelectedItem = "") And cmb_estType.SelectedItem = "Pond" Then
            Try
                Dim form As New frm_report_pondEst
                form.MdiParent = frm_Estimate_home
                frm_Estimate_home.refNo_pondEst = cmb_refNo.SelectedItem
                form.Show()
                viewClickStatus = "TRUE"
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        End If
    End Sub

    Private Sub frm_view_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not viewClickStatus = "TRUE" Then
            frm_Estimate_home.refNo_reservoirEst = ""
            frm_Estimate_home.refNo_pondEst = ""
            frm_Estimate_home.parentEstimateForm = ""
        End If
    End Sub

    Private Sub cmd_deleteEst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_deleteEst.Click
        If cmb_estType.SelectedItem = "" Then
            MsgBox("Please select type of estimate first.", MsgBoxStyle.OkOnly, "Data reader item read error")
            Exit Sub
        ElseIf cmb_refNo.SelectedItem = "" Then
            MsgBox("Please select reference number to view.", MsgBoxStyle.OkOnly, "Data reader item read error")
            Exit Sub
        End If
        If MessageBox.Show("Confirm delete of current estimate details?", "Sure to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cmb_estType.SelectedItem = "Reservoir" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & cmb_refNo.SelectedItem & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoirRate WHERE refNoEst='" & cmb_refNo.SelectedItem & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                    frm_Estimate_home.refNo_reservoirEst = ""
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
            If cmb_estType.SelectedItem = "Pond" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_pond WHERE refNo='" & cmb_refNo.SelectedItem & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                    frm_Estimate_home.refNo_pondEst = ""
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
            cmb_refNo.Items.Clear()
            cmb_estType.SelectedIndex = 0
            con_cls.disconnect()
        End If
    End Sub

End Class