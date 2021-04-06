Imports System.Data
Imports System.Data.SqlClient

Public Class frm_new_reservoir_rate
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions
    Dim dr As SqlDataReader
    Public empty_field_status, temprefnoamt, clickStatus As String
    Dim tempRefNo, tempRefNoIndex, count, itemRef, countRateItem As Integer
    Dim tempqty, temprate, countAmtUpd As Double
    Public tempAmt As Double
    Dim updateValueStatus As String


    Private Sub frm_new_reservoir_rate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con_cls.connect()
        '===========================================
        '=======Adding selected data rate references
        '===========================================
        updateValueStatus = "NOT UPDATED"
        countRateItem = 0
        Try
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                Try
                    dr.Read()
                    count = 0
                    txt_unit_pond.Text = dr.Item("unit")
                    txt_dp.Text = dr.Item("dp")
                    txt_slope.Text = dr.Item("slope")
                    txt_vol.Text = dr.Item("vol")
                    txt_bb.Text = dr.Item("bb")
                    txt_bl.Text = dr.Item("bl")
                    txt_tb.Text = dr.Item("tb")
                    txt_tl.Text = dr.Item("tl")
                    For i = 1 To 5
                        If Not dr.IsDBNull(18 + i) Then
                            If Not dr.Item("refno" & i) = "" Then
                                cmb_rateItemNo.Items.Add(dr.Item("refno" & i))
                            End If
                        End If
                    Next
                    dr.Close()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in updating datarate reference number onto the form")
                End Try
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching DataRate reference number from DB")
        End Try
        '==========================================================
        '======== Reset all fields value in Estimate_reservoirRate table
        '==========================================================
        Try
            con_cls.connect()
            con_cls.cmd.CommandText = "INSERT INTO Estimate_reservoirRate (refNoEst) VALUES ('" & frm_Estimate_home.refNo_reservoirEst & "')"
            con_cls.cmd.ExecuteNonQuery()
            con_cls.cmd.CommandText = "UPDATE Estimate_reservoirRate SET ref1des='-- NIL --',ref1unit='-- NIL --',ref1rate=0.00,ref1amt=0.00, " & _
            "ref2des='-- NIL --',ref2unit='-- NIL --',ref2rate=0.00,ref2amt=0.00, ref3des='-- NIL --',ref3unit='-- NIL --',ref3rate=0.00,ref3amt=0.00, " & _
            "ref4des='-- NIL --',ref4unit='-- NIL --',ref4rate=0.00,ref4amt=0.00, ref5des='-- NIL --',ref5unit='-- NIL --',ref5rate=0.00,ref5amt=0.00 WHERE (refNoEst='" & frm_Estimate_home.refNo_reservoirEst & "')"
            con_cls.cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Pond Rate table, record creat error.")
        End Try
        con_cls.disconnect()
    End Sub

    Private Sub frm_new_pond_rate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not clickStatus = "OK" Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoirRate WHERE refNoEst='" & frm_Estimate_home.refNo_reservoirEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
                Call resetFields()
                frm_Estimate_home.refNo_reservoirEst = ""
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
            End Try
            frm_Estimate_home.MS_Home.Items(0).Enabled = True
        End If
    End Sub

    Private Sub cmb_rateItemNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_rateItemNo.SelectedIndexChanged
        Try
            tempAmt = 0.0
            con_cls.connect()
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_reservoirRate WHERE refNoEst='" & frm_Estimate_home.refNo_reservoirEst & "'"
            dr = con_cls.cmd.ExecuteReader
            '----------------------------------------------------------
            '      In case of updating previously entered amount
            '      this try block takes previous amount value
            '----------------------------------------------------------
            If dr.HasRows Then
                dr.Read()
                If Not dr.Item("ref" & (cmb_rateItemNo.SelectedIndex + 1) & "amt") = "0.00" Then
                    tempAmt = CDbl(dr.Item("ref" & (cmb_rateItemNo.SelectedIndex + 1) & "amt"))
                    dr.Close()
                    con_cls.disconnect()
                End If
            End If
            dr.Close()
            con_cls.disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching Rate Details from Estimate pond rate details table")
        End Try
        tempRefNo = cmb_rateItemNo.SelectedItem
        tempRefNoIndex = cmb_rateItemNo.SelectedIndex
        cmd_confirm.Enabled = True
        txt_qty.Clear()
        txt_desc.Clear()
        txt_rate.Clear()
        txt_unit_rate.Clear()
        txt_amt.Clear()
        con_cls.connect()
        '=================================================
        '======= Updating the datarate details from the DB
        '=================================================
        Try
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_RateData WHERE refDataNo=" & tempRefNo
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                txt_desc.Text = dr.Item("descActivity")
                txt_rate.Text = dr.Item("rate")
                txt_unit_rate.Text = dr.Item("unit")
                txt_qty.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in fetching Rate Details from DB")
        End Try
        dr.Close()
        con_cls.disconnect()
    End Sub

    Private Sub cmd_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_confirm.Click
        If MessageBox.Show("Confirm quantity update in estimate?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If (Not txt_qty.Text = "") Then
                txt_amt.Text = CDbl(txt_qty.Text) * CDbl(txt_rate.Text)
            Else
                MsgBox("Quantity field cannot be null.", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            End If
            '==================================================
            '==== Update quantity values in Estimate_reservoir table
            '==================================================
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "UPDATE Estimate_reservoir SET qty" & tempRefNoIndex + 1 & "=" & _
                CDbl(txt_qty.Text) & " WHERE (refNo='" & frm_Estimate_home.refNo_reservoirEst & _
                "' AND refno" & tempRefNoIndex + 1 & "='" & tempRefNo & "')"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Updating quantity error")
                Exit Sub
            End Try
            '==================================================
            '=========== Refresh all values in form
            '==================================================
            If txt_est_cost.Text = "" Then
                txt_est_cost.Text = txt_amt.Text
                txt_tot_estCost.Text = txt_est_cost.Text
                txt_qty.Focus()
            ElseIf (Not txt_est_cost.Text = "") And (tempAmt = 0.0) Then
                txt_est_cost.Text = CDbl(txt_est_cost.Text) + CDbl(txt_amt.Text)
                Call updateValues()
                txt_qty.Focus()
            ElseIf (Not txt_est_cost.Text = "") And (Not tempAmt = 0.0) Then
                txt_est_cost.Text = CDbl(txt_est_cost.Text) - tempAmt
                txt_est_cost.Text = CDbl(txt_est_cost.Text) + CDbl(txt_amt.Text)
                Call updateValues()
                txt_qty.Focus()
            End If
            '====================================================
            '==== Update amount values in Estimate_reservoirRate table
            '====================================================
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "UPDATE Estimate_reservoirRate SET ref" & tempRefNoIndex + 1 & _
                            "des='" & txt_desc.Text & "',ref" & tempRefNoIndex + 1 & "unit='" & txt_unit_rate.Text & _
                            "',ref" & tempRefNoIndex + 1 & "rate=" & txt_rate.Text & ",ref" & tempRefNoIndex + 1 & _
                            "amt=" & txt_amt.Text & " WHERE (refNoEst='" & frm_Estimate_home.refNo_reservoirEst & "')"
                con_cls.cmd.ExecuteNonQuery()
                cmd_confirm.Enabled = False
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Updating amount details error")
                Exit Sub
            End Try
            '====================================================================
            '==== Calculating all amount grand total from Estimate_reservoirRate table
            '====================================================================
            Try
                con_cls.connect()
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_reservoirRate WHERE (refNoEst='" & frm_Estimate_home.refNo_reservoirEst & "')"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    tempAmt = 0.0
                    For i = 1 To 5
                        tempAmt = tempAmt + dr.Item("ref" & i & "amt")
                    Next
                End If
                dr.Close()
                con_cls.disconnect()
                txt_est_cost.Text = tempAmt
                Call updateValues()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Updating extimate cost error")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        If MessageBox.Show("Current estimate data will be lost, continue?", "Sure to cancel?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoirRate WHERE refNoEst='" & frm_Estimate_home.refNo_reservoirEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
                Call resetFields()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Record delete information")
            End Try
        End If
    End Sub


    Private Sub cmd_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_continue.Click
        clickStatus = "OK"
        Call check_empty_fields()
        If empty_field_status = "OK" Then
            con_cls.connect()
            '======================================================================
            '   Checking whether all the reference quantities are updated or not
            '======================================================================
            con_cls.cmd.CommandText = "SELECT * FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
            dr = con_cls.cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                count = dr.Item("totRateRef")
                countAmtUpd = 0
                For i = 1 To count
                    If dr.IsDBNull(18 + i) Then
                        updateValueStatus = "NOT UPDATED"
                        Exit For
                    ElseIf dr.IsDBNull(23 + i) Then
                        updateValueStatus = "NOT UPDATED"
                        itemRef = dr.Item("refno" & i)
                        Exit For
                    Else
                        updateValueStatus = "UPDATED"
                    End If
                Next
                dr.Close()
                con_cls.disconnect()
            End If
            '===============================================================================================
            '   Updating estimate cost, contingency rate n cost, display board cost and total est cost
            '===============================================================================================
            If updateValueStatus = "UPDATED" Then
                Try
                    con_cls.connect()
                    con_cls.cmd.CommandText = "UPDATE Estimate_reservoir SET estCost=" & txt_est_cost.Text & ",dispCost=" & _
                    txt_dispBord_cost.Text & ",contRate=" & txt_contRate.Text & ",contCost=" & txt_cont_cost.Text & _
                    ",totEstCost=" & txt_tot_estCost.Text & " WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                    Try
                        Dim form As New frm_estimate_Uinfo
                        form.MdiParent = frm_Estimate_home
                        form.Show()
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, "Open Child")
                    End Try
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in updating pond estimate info.")
                End Try
            Else
                MsgBox("Quantity of reference no. " & itemRef & " is not updated.", MsgBoxStyle.OkOnly, "Error in updating pond estimate info.")
            End If
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================
    Public Sub resetFields()
        txt_contRate.Clear()
        txt_dispBord_cost.Clear()
        txt_cont_cost.Clear()
        txt_amt.Clear()
        txt_est_cost.Clear()
        txt_tot_estCost.Clear()
        cmb_rateItemNo.SelectedIndex = 0
        cmd_confirm.Enabled = True
        With txt_qty
            .Clear()
            .Focus()
        End With
    End Sub

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_est_cost.Text = "" Then
            MsgBox("Estimate cost cannot be null", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_est_cost.Focus()
            Exit Sub
        ElseIf txt_dispBord_cost.Text = "" Then
            txt_dispBord_cost.Text = "0.0"
            Call check_empty_fields()
        ElseIf txt_contRate.Text = "" Then
            txt_contRate.Text = "0.0"
            Call check_empty_fields()
        ElseIf txt_cont_cost.Text = "" Then
            txt_cont_cost.Text = "0.0"
            Call check_empty_fields()
        ElseIf txt_tot_estCost.Text = "" Then
            MsgBox("Total cost of Estimate cannot be null", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_tot_estCost.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub

    Public Sub updateValues()
        Call check_empty_fields()
        If empty_field_status = "OK" Then
            txt_cont_cost.Text = (CDbl(txt_est_cost.Text) * CDbl(txt_contRate.Text)) / 100
            txt_tot_estCost.Text = CDbl(txt_est_cost.Text) + CDbl(txt_dispBord_cost.Text) + CDbl(txt_cont_cost.Text)
        End If
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_qty_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_qty.Validating
        Try
            Call valid.qty_validate(txt_qty.Text, txt_qty)
            If (Not txt_qty.Text = "") And (Not valid.err_code = 1) Then
                txt_amt.Text = CDbl(txt_qty.Text) * CDbl(txt_rate.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
        cmd_confirm.Focus()
    End Sub

    Private Sub txt_dispBord_cost_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_dispBord_cost.Validating
        Try
            Call valid.qty_validate(txt_dispBord_cost.Text, txt_dispBord_cost)
            If (Not txt_dispBord_cost.Text = "") And (Not valid.err_code = 1) Then
                Call updateValues()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
        txt_contRate.Focus()
    End Sub

    Private Sub txt_contRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_contRate.Validating
        Try
            Call valid.rate_validate(txt_contRate.Text, txt_contRate)
            If (Not txt_contRate.Text = "") And (Not valid.err_code = 1) Then
                Call updateValues()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
        cmd_confirm.Focus()
    End Sub
End Class