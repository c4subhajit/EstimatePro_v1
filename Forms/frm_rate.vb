Imports System.Data
Imports System.Data.SqlClient

Public Class frm_rate
    Dim con_cls As New class_connect_string
    Dim dr As SqlDataReader
    Dim valid As New class_validation_functions
    Public tempRefNo As Integer
    Public empty_field_status As String
    Public typeWork As String

    Private Sub frm_rate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call reset_fields_RN()
        Call reset_fields_RM()
        Call reset_fields_RMN()
        Call reset_fields_RD()
    End Sub

    '==================================================================================
    '==================================================================================
    '                       CODE FOR NEW TAB IN THE RATE FORM
    '==================================================================================
    '==================================================================================

    Private Sub cmb_TW_RN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TW_RN.SelectedIndexChanged
        typeWork = cmb_TW_RN.SelectedItem
    End Sub

    Private Sub cmd_add_RN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_add_RN.Click
        Call emptyFieldCheck_RN()
        If empty_field_status = "OK" Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "INSERT INTO Estimate_RateData (refDataNo,typeWork,descActivity,unit,rate) VALUES (" & _
                txt_refno_RN.Text & ",'" & cmb_TW_RN.SelectedItem & "','" & txt_desc_RN.Text & "','" & txt_unit_RN.Text & "'," & txt_rate_RN.Text & ")"
                con_cls.cmd.ExecuteNonQuery()
                MsgBox("Rate data saved successful", MsgBoxStyle.OkOnly, "Information")
                Call reset_fields_RN()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Rate data saving not successful, Sql querry error")
            End Try
            con_cls.disconnect()
        End If
    End Sub

    Private Sub cmd_reset_RN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset_RN.Click
        Call reset_fields_RN()
    End Sub

    '-----------------------------------------------------------------
    '                   EMPTY FIELD VALIDATION OF DATA FIELDS
    '-----------------------------------------------------------------

    Public Sub emptyFieldCheck_RN()
        empty_field_status = ""
        If txt_desc_RN.Text = "" Then
            MsgBox("Please enter activity description", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_desc_RN.Focus()
            Exit Sub
        ElseIf txt_unit_RN.Text = "" Then
            MsgBox("Please enter unit", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_unit_RN.Focus()
            Exit Sub
        ElseIf typeWork = "" Then
            MsgBox("Please select type of work", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmb_TW_RN.Focus()
            Exit Sub
        ElseIf txt_rate_RN.Text = "" Then
            MsgBox("Please enter rate info.", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_rate_RN.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

    '-----------------------------------------------------------------
    '                   TEXT VALIDATION OF DATA FIELDS
    '-----------------------------------------------------------------
    Private Sub cmb_TW_RN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_TW_RN.Validating
        Try
            Call valid.typeWork_validate(cmb_TW_RN)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_desc_RN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_desc_RN.Validating
        Try
            Call valid.actDesc_validate(txt_desc_RN.Text, txt_desc_RN, "New Rate")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_rate_RN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_rate_RN.Validating
        Try
            Call valid.rate_validate(txt_rate_RN.Text, txt_rate_RN)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_unit_RN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_unit_RN.Validating
        Try
            Call valid.unit_validate(txt_unit_RN.Text, txt_unit_RN)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    '-----------------------------------------------------------------
    '             USER DEFINED FUNCTIONS FOR NEW RATE TAB
    '-----------------------------------------------------------------

    Public Sub reset_fields_RN()
        txt_desc_RN.Clear()
        txt_rate_RN.Clear()
        txt_unit_RN.Clear()
        cmb_TW_RN.SelectedIndex = 0
        Call updateDataRefNo_newrate()
        Call updateDataRefNo_others()
    End Sub

    '==================================================================================
    '==================================================================================
    '                       CODE FOR MODIFY TAB IN THE RATE FORM 
    '==================================================================================
    '==================================================================================

    Private Sub cmb_refno_RM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_refno_RM.SelectedIndexChanged
        tempRefNo = cmb_refno_RM.SelectedItem
        con_cls.connect()
        'updating the datarate details from the DB
        Try
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE refDataNo=" & tempRefNo
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txt_desc_RM.Text = dr.Item("descActivity")
                txt_rate_RM.Text = dr.Item("rate")
                txt_unit_RM.Text = dr.Item("unit")
                cmb_TW_RM.SelectedItem = dr.Item("typeWork")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching Rate Details from DB")
        End Try
        dr.Close()
        con_cls.disconnect()
    End Sub

    Private Sub cmb_TW_RM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TW_RM.SelectedIndexChanged
        typeWork = cmb_TW_RM.SelectedItem
    End Sub

    Private Sub cmd_edit_RM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_RM.Click
        Call field_edit_RM()
    End Sub

    Private Sub cmd_update_RM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update_RM.Click
        Call emptyFieldCheck_RM()
        If empty_field_status = "OK" Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "UPDATE Estimate_RateData SET typeWork='" & cmb_TW_RM.SelectedItem & "',descActivity='" & _
                txt_desc_RM.Text & "',unit='" & txt_unit_RM.Text & "',rate=" & txt_rate_RM.Text & _
                " WHERE refDataNo=" & cmb_refno_RM.SelectedItem
                con_cls.cmd.ExecuteNonQuery()
                MsgBox("Rate data Updated successful", MsgBoxStyle.OkOnly, "Information")
                Call reset_fields_RM()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Rate data modify not successful, Sql querry error")
            End Try
            con_cls.disconnect()
        End If
    End Sub

    Private Sub cmd_reset_RM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset_RM.Click
        Call reset_fields_RM()
    End Sub

    '-----------------------------------------------------------------
    '                   EMPTY FIELD VALIDATION OF DATA FIELDS
    '-----------------------------------------------------------------

    Public Sub emptyFieldCheck_RM()
        empty_field_status = ""
        If txt_desc_RM.Text = "" Then
            MsgBox("Please enter activity description", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_desc_RM.Focus()
            Exit Sub
        ElseIf txt_unit_RM.Text = "" Then
            MsgBox("Please enter unit", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_unit_RM.Focus()
            Exit Sub
        ElseIf typeWork = "" Then
            MsgBox("Please select type of work", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmb_TW_RM.Focus()
            Exit Sub
        ElseIf txt_rate_RM.Text = "" Then
            MsgBox("Please enter rate info.", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_rate_RM.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

    '-----------------------------------------------------------------
    '                   TEXT VALIDATION OF DATA FIELDS
    '-----------------------------------------------------------------

    Private Sub cmb_TW_RM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_TW_RM.Validating
        Try
            Call valid.typeWork_validate(cmb_TW_RM)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_desc_RM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_desc_RM.Validating
        Try
            Call valid.actDesc_validate(txt_desc_RM.Text, txt_desc_RM, "Modify Rate")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_rate_RM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_rate_RM.Validating
        Try
            Call valid.rate_validate(txt_rate_RM.Text, txt_rate_RM)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_unit_RM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_unit_RM.Validating
        Try
            Call valid.unit_validate(txt_unit_RM.Text, txt_unit_RM)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    '-----------------------------------------------------------------
    '             USER DEFINED FUNCTIONS FOR MODIFY RATE TAB
    '-----------------------------------------------------------------

    Public Sub reset_fields_RM()
        txt_desc_RM.Clear()
        txt_rate_RM.Clear()
        txt_unit_RM.Clear()
        cmb_TW_RM.SelectedIndex = 0
        Call updateDataRefNo_newrate()
        Call updateDataRefNo_others()
        Call field_editlock_RM()
    End Sub

    Public Sub field_edit_RM()
        txt_desc_RM.Enabled = True
        txt_rate_RM.Enabled = True
        txt_unit_RM.Enabled = True
        cmb_TW_RM.Enabled = True
        cmb_refno_RM.Enabled = False
        cmd_update_RM.Enabled = True
    End Sub

    Public Sub field_editlock_RM()
        txt_desc_RM.Enabled = False
        txt_rate_RM.Enabled = False
        txt_unit_RM.Enabled = False
        cmb_TW_RM.Enabled = False
        cmb_refno_RM.Enabled = True
        cmd_update_RM.Enabled = False
    End Sub

    '==================================================================================
    '==================================================================================
    '                       CODE FOR MODIFY TO NEW TAB IN THE RATE FORM 
    '==================================================================================
    '==================================================================================

    Private Sub cmb_refno_RMN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_refno_RMN.SelectedIndexChanged
        tempRefNo = cmb_refno_RMN.SelectedItem
        con_cls.connect()
        'updating the datarate details from the DB
        Try
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE refDataNo=" & tempRefNo
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txt_desc_RMN.Text = dr.Item("descActivity")
                txt_rate_RMN.Text = dr.Item("rate")
                txt_unit_RMN.Text = dr.Item("unit")
                cmb_TW_RMN.SelectedItem = dr.Item("typeWork")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching Rate Details from DB")
        End Try
        dr.Close()
        con_cls.disconnect()
    End Sub

    Private Sub cmb_TW_RMN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TW_RMN.SelectedIndexChanged
        typeWork = cmb_TW_RMN.SelectedItem
    End Sub

    Private Sub cmd_edit_RMN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_edit_RMN.Click
        Call field_edit_RMN()
    End Sub

    Private Sub cmd_crtnew_RMN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_crtnew_RMN.Click
        Call emptyFieldCheck_RMN()
        If empty_field_status = "OK" Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "INSERT INTO Estimate_RateData (refDataNo,typeWork,descActivity,unit,rate) VALUES (" & _
                txt_refno_RN.Text & ",'" & cmb_TW_RMN.SelectedItem & "','" & txt_desc_RMN.Text & "','" & txt_unit_RMN.Text & "'," & txt_rate_RMN.Text & ")"
                con_cls.cmd.ExecuteNonQuery()
                MsgBox("New Rate data saved successful", MsgBoxStyle.OkOnly, "Information")
                Call reset_fields_RMN()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Modify to new rate data saving not successful, Sql querry error")
            End Try
            con_cls.disconnect()
        End If
    End Sub

    Private Sub cmd_reset_RMN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset_RMN.Click
        Call reset_fields_RMN()
    End Sub

    '-----------------------------------------------------------------
    '                   EMPTY FIELD VALIDATION OF DATA FIELDS
    '-----------------------------------------------------------------

    Public Sub emptyFieldCheck_RMN()
        empty_field_status = ""
        If txt_desc_RMN.Text = "" Then
            MsgBox("Please enter activity description", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_desc_RMN.Focus()
            Exit Sub
        ElseIf txt_unit_RMN.Text = "" Then
            MsgBox("Please enter unit", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_unit_RMN.Focus()
            Exit Sub
        ElseIf typeWork = "" Then
            MsgBox("Please select type of work", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmb_TW_RMN.Focus()
            Exit Sub
        ElseIf txt_rate_RMN.Text = "" Then
            MsgBox("Please enter rate info.", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_rate_RMN.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

    '-----------------------------------------------------------------
    '                   TEXT VALIDATION OF DATA FIELDS
    '-----------------------------------------------------------------

    Private Sub cmb_TW_RMN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_TW_RMN.Validating
        Try
            Call valid.typeWork_validate(cmb_TW_RMN)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_desc_RMN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_desc_RMN.Validating
        Try
            Call valid.actDesc_validate(txt_desc_RMN.Text, txt_desc_RMN, "Modify to New")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_rate_RMN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_rate_RMN.Validating
        Try
            Call valid.rate_validate(txt_rate_RMN.Text, txt_rate_RMN)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_unit_RMN_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_unit_RMN.Validating
        Try
            Call valid.unit_validate(txt_unit_RMN.Text, txt_unit_RMN)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    '-----------------------------------------------------------------
    '       USER DEFINED FUNCTIONS FOR MODIFY TO NEW RATE TAB
    '-----------------------------------------------------------------

    Public Sub reset_fields_RMN()
        txt_desc_RMN.Clear()
        txt_rate_RMN.Clear()
        txt_unit_RMN.Clear()
        cmb_TW_RMN.SelectedIndex = 0
        Call updateDataRefNo_newrate()
        Call updateDataRefNo_others()
        Call field_editlock_RMN()
    End Sub

    Public Sub field_edit_RMN()
        txt_desc_RMN.Enabled = True
        txt_rate_RMN.Enabled = True
        txt_unit_RMN.Enabled = True
        cmb_TW_RMN.Enabled = True
        cmb_refno_RMN.Enabled = False
        cmd_crtnew_RMN.Enabled = True
    End Sub

    Public Sub field_editlock_RMN()
        txt_desc_RMN.Enabled = False
        txt_rate_RMN.Enabled = False
        txt_unit_RMN.Enabled = False
        cmb_TW_RMN.Enabled = False
        cmb_refno_RMN.Enabled = True
        cmd_crtnew_RMN.Enabled = False
    End Sub

    '==================================================================================
    '==================================================================================
    '                       CODE FOR DELETE TAB IN THE RATE FORM 
    '==================================================================================
    '==================================================================================

    Private Sub cmb_refno_RD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_refno_RD.SelectedIndexChanged
        tempRefNo = cmb_refno_RD.SelectedItem
        con_cls.connect()
        'updating the datarate details from the DB
        Try
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE refDataNo=" & tempRefNo
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txt_desc_RD.Text = dr.Item("descActivity")
                txt_rate_RD.Text = dr.Item("rate")
                txt_unit_RD.Text = dr.Item("unit")
                txt_TW_RD.Text = dr.Item("typeWork")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching Rate Details from DB")
        End Try
        dr.Close()
        con_cls.disconnect()
    End Sub

    Private Sub cmd_delete_RD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_delete_RD.Click
        If MessageBox.Show("Confirm Record Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "DELETE FROM Estimate_RateData WHERE refDataNo=" & cmb_refno_RD.SelectedItem
                con_cls.cmd.ExecuteNonQuery()
                MsgBox("Rate data deleted successful", MsgBoxStyle.OkOnly, "Information")
                Call reset_fields_RD()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Rate data delete not successful, Sql querry error")
            End Try
            con_cls.disconnect()
        End If
    End Sub

    '-----------------------------------------------------------------
    '             USER DEFINED FUNCTIONS FOR MODIFY RATE TAB
    '-----------------------------------------------------------------

    Public Sub reset_fields_RD()
        txt_desc_RD.Clear()
        txt_rate_RD.Clear()
        txt_unit_RD.Clear()
        txt_TW_RD.Clear()
        Call updateDataRefNo_newrate()
        Call updateDataRefNo_others()
    End Sub

    '==================================================================================
    '==================================================================================
    '                     USER DEFINED FUNCTIONS FOR ALL TABS
    '==================================================================================
    '==================================================================================

    Public Sub updateDataRefNo_newrate()
        con_cls.connect()

        'updating the datarate reference number on the New tab of the datarate form
        Try
            con_cls.cmd.CommandText = "SELECT MAX(refDataNo) FROM Estimate_RateData"
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If Not dr.IsDBNull(0) Then
                    tempRefNo = CInt(dr.Item(0))
                    tempRefNo += 1
                Else
                    tempRefNo = 1
                End If
            End If
            txt_refno_RN.Text = tempRefNo
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching DataRate reference number from DB to New Rate")
        End Try
        dr.Close()
    End Sub

    Public Sub updateDataRefNo_others()
        'updating the datarate reference number on all the comboboxs in the datarate form
        cmb_refno_RM.Items.Clear()
        cmb_refno_RMN.Items.Clear()
        cmb_refno_RD.Items.Clear()
        Try
            con_cls.cmd.CommandText = "SELECT refDataNo FROM Estimate_RateData"
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                Try
                    While dr.Read
                        cmb_refno_RM.Items.Add(dr.Item("refDataNo"))
                        cmb_refno_RMN.Items.Add(dr.Item("refDataNo"))
                        cmb_refno_RD.Items.Add(dr.Item("refDataNo"))
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in updating datarate reference number onto the form")
                End Try
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching DataRate reference number from DB to all except New Rate")
        End Try
        con_cls.disconnect()
    End Sub

End Class