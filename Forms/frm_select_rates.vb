Imports System.Data
Imports System.Data.SqlClient

Public Class frm_select_rates
    Dim con_cls As New class_connect_string
    Dim dr As SqlDataReader
    Public tempRefNo As Integer
    Public totRefNoCount, emptyRefNo As Integer
    Public empty_field_status, continueClickStatus, undoSelectClickStatus As String
    Public selectArray(10) As Integer

    Private Sub frm_select_rates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            'updating the datarate reference number
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "SELECT refDataNo FROM Estimate_RateData"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    Try
                        While dr.Read
                            cmb_refno_SR.Items.Add(dr.Item("refDataNo"))
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in updating datarate reference number onto the form")
                    End Try
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching DataRate reference number from DB")
            End Try
            dr.Close()
            con_cls.disconnect()
            totRefNoCount = 0
            For i = 1 To 4
                selectArray(i) = 0.0
            Next
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            'updating the datarate reference number
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "SELECT refDataNo FROM Estimate_RateData"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    Try
                        While dr.Read
                            cmb_refno_SR.Items.Add(dr.Item("refDataNo"))
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in updating datarate reference number onto the form")
                    End Try
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching DataRate reference number from DB")
            End Try
            dr.Close()
            con_cls.disconnect()
            totRefNoCount = 0
            For i = 1 To 10
                selectArray(i) = 0.0
            Next
        End If
    End Sub

    Private Sub frm_select_rates_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not continueClickStatus = "OK" Then
            '======================================================
            '                       RESERVOIR
            '======================================================
            If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    frm_Estimate_home.refNo_pondEst = ""
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
            '======================================================
            '                       POND
            '======================================================
            If frm_Estimate_home.parentEstimateForm = "POND" Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    frm_Estimate_home.refNo_pondEst = ""
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
            frm_Estimate_home.MS_Home.Items(0).Enabled = True
        End If
    End Sub

    Private Sub cmb_refno_SR_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_refno_SR.SelectedIndexChanged
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            tempRefNo = cmb_refno_SR.SelectedItem
            con_cls.connect()
            'updating the datarate details from the DB
            Try
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE refDataNo=" & tempRefNo
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    txt_desc_SR.Text = dr.Item("descActivity")
                    txt_rate_SR.Text = dr.Item("rate")
                    txt_unit_SR.Text = dr.Item("unit")
                    txt_TW_SR.Text = dr.Item("typeWork")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching Rate Details from DB")
            End Try
            dr.Close()
            con_cls.disconnect()
            Call checkSelect()
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            tempRefNo = cmb_refno_SR.SelectedItem
            con_cls.connect()
            'updating the datarate details from the DB
            Try
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE refDataNo=" & tempRefNo
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    txt_desc_SR.Text = dr.Item("descActivity")
                    txt_rate_SR.Text = dr.Item("rate")
                    txt_unit_SR.Text = dr.Item("unit")
                    txt_TW_SR.Text = dr.Item("typeWork")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching Rate Details from DB")
            End Try
            dr.Close()
            con_cls.disconnect()
            Call checkSelect()
        End If
    End Sub

    Private Sub cmd_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_back.Click
        ' Send to previous forms of respective estimate types by checking parentEstimateForm parameter.
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            Try
                Dim form As New frm_new_reservoir
                form.MdiParent = frm_Estimate_home
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
            Me.Dispose()
            Me.Close()
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            Try
                Dim form As New frm_new_pond
                form.MdiParent = frm_Estimate_home
                form.Show()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub cmd_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_select.Click
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            con_cls.connect()
            Call emptyFieldCheck_SR()
            If empty_field_status = "OK" And totRefNoCount < 4 Then
                Try
                    totRefNoCount += 1
                    For i = 1 To 4
                        If selectArray(i) = 0.0 Then
                            selectArray(i) = cmb_refno_SR.SelectedItem
                            Exit For
                        End If
                    Next
                    Call checkSelect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in adding rate reference to Reservoir Estimate")
                End Try
            Else
                MsgBox("Maximum 4 schedule items can be selected.", MsgBoxStyle.OkOnly, "Information")
            End If
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            con_cls.connect()
            Call emptyFieldCheck_SR()
            If empty_field_status = "OK" And totRefNoCount < 10 Then
                Try
                    totRefNoCount += 1
                    For i = 1 To 10
                        If selectArray(i) = 0.0 Then
                            selectArray(i) = cmb_refno_SR.SelectedItem
                            Exit For
                        End If
                    Next
                    Call checkSelect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in adding rate reference to Pond Estimate")
                End Try
            Else
                MsgBox("Maximum 10 schedule items can be selected.", MsgBoxStyle.OkOnly, "Information")
            End If
        End If
    End Sub

    Private Sub cmd_undoselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_undoselect.Click
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            con_cls.connect()
            Call emptyFieldCheck_SR()
            If empty_field_status = "OK" Then
                Try
                    totRefNoCount -= 1
                    For i = 1 To 4
                        If selectArray(i) = cmb_refno_SR.SelectedItem Then
                            selectArray(i) = 0.0
                            Exit For
                        End If
                    Next
                    For i = 1 To 3
                        If selectArray(i) = 0.0 Then
                            selectArray(i) = selectArray(i + 1)
                            selectArray(i + 1) = 0.0
                        End If
                    Next
                    Call checkSelect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in adding rate reference to Reservoir Estimate")
                End Try
            End If
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            con_cls.connect()
            Call emptyFieldCheck_SR()
            If empty_field_status = "OK" Then
                Try
                    totRefNoCount -= 1
                    For i = 1 To 10
                        If selectArray(i) = cmb_refno_SR.SelectedItem Then
                            selectArray(i) = 0.0
                            Exit For
                        End If
                    Next
                    For i = 1 To 9
                        If selectArray(i) = 0.0 Then
                            selectArray(i) = selectArray(i + 1)
                            selectArray(i + 1) = 0.0
                        End If
                    Next
                    Call checkSelect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in adding rate reference to Pond Estimate")
                End Try
            End If
        End If
    End Sub

    Private Sub cmd_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_continue.Click
        continueClickStatus = "OK"
        Dim i As Integer
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            Try
                con_cls.connect()
                For i = 1 To 4
                    If Not selectArray(i) = 0.0 Then
                        con_cls.cmd.CommandText = "UPDATE Estimate_reservoir SET refno" & i & "='" & selectArray(i) & "' WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                        con_cls.cmd.ExecuteNonQuery()
                    Else
                        Exit For
                    End If
                Next
                If i = 1 Then
                    MsgBox("Please select some reference to continue.", MsgBoxStyle.OkOnly, "Error in Continue.")
                    Exit Sub
                End If
                con_cls.cmd.CommandText = "UPDATE Estimate_reservoir SET totRateRef=" & i - 1 & " WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in adding rate reference to Reservoir Estimate")
            End Try

            Try
                Dim form As New frm_new_reservoir_rate
                form.MdiParent = frm_Estimate_home
                form.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            Try
                con_cls.connect()
                For i = 1 To 10
                    If Not selectArray(i) = 0.0 Then
                        con_cls.cmd.CommandText = "UPDATE Estimate_pond SET refno" & i & "='" & selectArray(i) & "' WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                        con_cls.cmd.ExecuteNonQuery()
                    Else
                        Exit For
                    End If
                Next
                If i = 1 Then
                    MsgBox("Please select some reference to continue.", MsgBoxStyle.OkOnly, "Error in Continue.")
                    Exit Sub
                End If
                con_cls.cmd.CommandText = "UPDATE Estimate_pond SET totRateRef=" & i - 1 & " WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in adding rate reference to Pond Estimate")
            End Try

            Try
                Dim form As New frm_new_pond_rate
                form.MdiParent = frm_Estimate_home
                form.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Open Child")
            End Try
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            If MessageBox.Show("Current estimate data will be lost, continue?", "Sure to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    Me.Close()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            If MessageBox.Show("Current estimate data will be lost, continue?", "Sure to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "DELETE FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    Me.Close()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
                End Try
            End If
        End If
    End Sub

    Public Sub emptyFieldCheck_SR()
        empty_field_status = ""
        If txt_desc_SR.Text = "" Then
            MsgBox("Please enter activity description", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_desc_SR.Focus()
            Exit Sub
        ElseIf txt_unit_SR.Text = "" Then
            MsgBox("Please enter unit", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_unit_SR.Focus()
            Exit Sub
        ElseIf txt_TW_SR.Text = "" Then
            MsgBox("Please select type of work", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_TW_SR.Focus()
            Exit Sub
        ElseIf txt_rate_SR.Text = "" Then
            MsgBox("Please enter rate info.", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_rate_SR.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

    Public Sub checkSelect()
        '======================================================
        '                       RESERVOIR
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "RESERVOIR" Then
            tempRefNo = cmb_refno_SR.SelectedItem
            For i = 1 To 4
                If selectArray(i) = tempRefNo Then
                    lbl_selectStatus.Text = "Selected"
                    cmd_select.Enabled = False
                    cmd_undoselect.Enabled = True
                    Exit For
                Else
                    lbl_selectStatus.Text = "Not Selected"
                    cmd_select.Enabled = True
                    cmd_undoselect.Enabled = False
                End If
            Next
        End If
        '======================================================
        '                       POND
        '======================================================
        If frm_Estimate_home.parentEstimateForm = "POND" Then
            tempRefNo = cmb_refno_SR.SelectedItem
            For i = 1 To 10
                If selectArray(i) = tempRefNo Then
                    lbl_selectStatus.Text = "Selected"
                    cmd_select.Enabled = False
                    cmd_undoselect.Enabled = True
                    Exit For
                Else
                    lbl_selectStatus.Text = "Not Selected"
                    cmd_select.Enabled = True
                    cmd_undoselect.Enabled = False
                End If
            Next
        End If
    End Sub

End Class