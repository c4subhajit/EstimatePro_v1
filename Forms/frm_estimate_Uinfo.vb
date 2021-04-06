Imports System.Data
Imports System.Data.SqlClient

Public Class frm_estimate_Uinfo
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions
    Dim dr As SqlDataReader
    Public empty_field_status, clickStatus, saveStatus As String

    Private Sub frm_new_pond_Uinfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
        con_cls.connect()
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            Try
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    txt_totCost.Text = dr.Item("totEstCost")
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching estimate details onto the form")
            End Try
        End If
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            Try
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    txt_totCost.Text = dr.Item("totEstCost")
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching estimate details onto the form")
            End Try
        End If
        con_cls.disconnect()
    End Sub

    Private Sub frm_new_pond_Uinfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not clickStatus = "OK" Then
            If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoirRate WHERE refNoEst='" & frm_Estimate_home.refNo_reservoirEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If

            If frm_Estimate_home.parentEstimateForm = "POND" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If

            frm_Estimate_home.refNo_reservoirEst = ""
            frm_Estimate_home.refNo_pondEst = ""
            Call resetFields()
            con_cls.disconnect()
        Else
            frm_Estimate_home.refNo_reservoirEst = ""
            frm_Estimate_home.refNo_pondEst = ""
            frm_Estimate_home.parentEstimateForm = ""
            Call resetFields()
        End If
        frm_Estimate_home.MS_Home.Items(0).Enabled = True
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
    End Sub

    Private Sub cmd_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_save.Click
        Call check_empty_fields()
        If empty_field_status = "OK" Then
            If MessageBox.Show("Confirm saving of current estimate details?", "Sure to save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
                    Try
                        con_cls.connect()
                        con_cls.cmd.CommandText = "UPDATE Estimate_reservoir SET nameWork='" & Trim(txt_nameWork.Text) & _
                        "',nameBen='" & Trim(txt_nameBen.Text) & "',locationWork='" & Trim(txt_locationWork.Text) & "',finYear='" & Trim(txt_finYear.Text) & _
                        "',nameIO='" & Trim(txt_nameIO.Text) & "',nameSO='" & Trim(txt_nameSO.Text) & "',nameEE='" & Trim(txt_nameEE.Text) & _
                        "',durWork='" & Trim(txt_durWork.Text) & "',prog_Name='" & txt_prog.Text & "' WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                        con_cls.cmd.ExecuteNonQuery()
                        MsgBox("Reservoir Estimate " & frm_Estimate_home.refNo_reservoirEst & " saved successfully.", MsgBoxStyle.OkOnly, "Estimate save information.")
                        con_cls.disconnect()
                        clickStatus = "OK"
                        saveStatus = "OK"
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in updating pond estimate info.")
                    End Try
                End If
                If frm_Estimate_home.parentEstimateForm = "POND" Then
                    Try
                        con_cls.connect()
                        con_cls.cmd.CommandText = "UPDATE Estimate_pond SET nameWork='" & Trim(txt_nameWork.Text) & _
                        "',nameBen='" & Trim(txt_nameBen.Text) & "',locationWork='" & Trim(txt_locationWork.Text) & "',finYear='" & Trim(txt_finYear.Text) & _
                        "',nameIO='" & Trim(txt_nameIO.Text) & "',nameSO='" & Trim(txt_nameSO.Text) & "',nameEE='" & Trim(txt_nameEE.Text) & _
                        "',durWork='" & Trim(txt_durWork.Text) & "',prog_Name='" & txt_prog.Text & "' WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                        con_cls.cmd.ExecuteNonQuery()
                        MsgBox("Pond Estimate " & frm_Estimate_home.refNo_pondEst & " saved successfully.", MsgBoxStyle.OkOnly, "Estimate save information.")
                        con_cls.disconnect()
                        clickStatus = "OK"
                        saveStatus = "OK"
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in updating pond estimate info.")
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub cmd_genRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_genRep.Click
        If saveStatus = "OK" Then
            If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
                Try
                    Dim form As New frm_report_reservoirEst
                    form.MdiParent = frm_Estimate_home
                    form.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Open Child")
                End Try
            End If
            If frm_Estimate_home.parentEstimateForm = "POND" Then
                Try
                    Dim form As New frm_report_pondEst
                    form.MdiParent = frm_Estimate_home
                    form.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Open Child")
                End Try
            End If
        Else
            MsgBox("Save current estimate's user info first.", MsgBoxStyle.OkOnly, "Error in generating estimate report.")
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        If MessageBox.Show("Current estimate data will be lost, continue?", "Sure to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoirRate WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                    frm_Estimate_home.refNo_reservoirEst = ""
                    Call resetFields()
                    Me.Close()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
            If frm_Estimate_home.parentEstimateForm = "POND" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                    frm_Estimate_home.refNo_pondEst = ""
                    Call resetFields()
                    Me.Close()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
            frm_Estimate_home.MS_Home.Items(0).Enabled = True
        End If
    End Sub

    '=================================================================
    '                       USER DEFINED FUNCTIONS
    '=================================================================
    Public Sub resetFields()
        txt_nameBen.Clear()
        txt_locationWork.Clear()
        txt_finYear.Clear()
        txt_nameIO.Clear()
        txt_nameSO.Clear()
        txt_nameEE.Clear()
        txt_durWork.Clear()
        With txt_nameWork
            .Clear()
            .Focus()
        End With
        saveStatus = ""
        clickStatus = ""
    End Sub

    '=================================================================
    '              EMPTY FIELD VALIDATION OF DATA FIELDS
    '=================================================================

    'Public Sub check_empty_fields()
    '    empty_field_status = ""
    '    If txt_nameWork.Text = "" Then
    '        MsgBox("Please enter name of work", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_nameWork.Focus()
    '        Exit Sub
    '    ElseIf txt_nameBen.Text = "" Then
    '        MsgBox("Please enter name of beneficiary", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_nameBen.Focus()
    '        Exit Sub
    '    ElseIf txt_locationWork.Text = "" Then
    '        MsgBox("Please enter location of work", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_locationWork.Focus()
    '        Exit Sub
    '    ElseIf txt_finYear.Text = "" Then
    '        MsgBox("Please enter financial year", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_finYear.Focus()
    '        Exit Sub
    '    ElseIf txt_nameIO.Text = "" Then
    '        MsgBox("Please enter name of Implementing Officer", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_nameIO.Focus()
    '        Exit Sub
    '    ElseIf txt_nameSO.Text = "" Then
    '        MsgBox("Please enter name of Supervising Officer", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_nameSO.Focus()
    '        Exit Sub
    '    ElseIf txt_nameEE.Text = "" Then
    '        MsgBox("Please enter name of Estimator", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_nameEE.Focus()
    '        Exit Sub
    '    ElseIf txt_durWork.Text = "" Then
    '        MsgBox("Please enter duration of work", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_durWork.Focus()
    '        Exit Sub
    '    ElseIf txt_prog.Text = "" Then
    '        MsgBox("Please enter program name", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
    '        txt_prog.Focus()
    '        Exit Sub
    '    Else
    '        empty_field_status = "OK"
    '    End If
    'End Sub

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_nameWork.Text = "" Then
            txt_nameWork.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_nameBen.Text = "" Then
            txt_nameBen.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_locationWork.Text = "" Then
            txt_locationWork.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_finYear.Text = "" Then
            txt_finYear.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_nameIO.Text = "" Then
            txt_nameIO.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_nameSO.Text = "" Then
            txt_nameSO.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_nameEE.Text = "" Then
            txt_nameEE.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_durWork.Text = "" Then
            txt_durWork.Text = "-- N.A. --"
            Call check_empty_fields()
        ElseIf txt_prog.Text = "" Then
            txt_prog.Text = "Report Generated By Estimate Pro v2.0, KVK Dhalai."
            Call check_empty_fields()
        Else
            empty_field_status = "OK"
        End If
    End Sub


    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_nameWork_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nameWork.Validating
        Try
            Call valid.work_validate(txt_nameWork.Text, txt_nameWork)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_nameBen_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nameBen.Validating
        Try
            Call valid.personName_validate(txt_nameBen.Text, txt_nameBen)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_locationWork_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_locationWork.Validating
        Try
            Call valid.work_validate(txt_locationWork.Text, txt_locationWork)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_finYear_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_finYear.Validating
        Try
            Call valid.finYear_validate(txt_finYear.Text, txt_finYear)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_nameIO_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nameIO.Validating
        Try
            Call valid.personName_validate(txt_nameIO.Text, txt_nameIO)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_nameSO_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nameSO.Validating
        Try
            Call valid.personName_validate(txt_nameSO.Text, txt_nameSO)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_nameEE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nameEE.Validating
        Try
            Call valid.personName_validate(txt_nameEE.Text, txt_nameEE)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_durWork_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_durWork.Validating
        Try
            Call valid.durWork_validate(txt_durWork.Text, txt_durWork)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_prog_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_prog.Validating
        Try
            Call valid.prog_validate(txt_prog.Text, txt_prog)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class