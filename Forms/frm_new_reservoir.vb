Imports System.Data
Imports System.Data.SqlClient

Public Class frm_new_reservoir
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions
    Dim dr As SqlDataReader
    Public empty_field_status As String
    Public distanceUnit As String
    Public continueStatus As String

    Private Sub frm_new_reservoir_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If continueStatus = "" Then
            frm_Estimate_home.MS_Home.Items(0).Enabled = True
        End If
    End Sub

    Private Sub frm_new_reservoir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
        '==========================================================================
        '=== If this form is reopened from the next form by clicking back command
        '==========================================================================
        If Not frm_Estimate_home.refNo_reservoirEst = "" Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    txt_refNo.Text = dr.Item("refNo")
                    txt_dateEst.Text = dr.Item("dateEst")
                    cmb_unit.SelectedItem = dr.Item("unit")
                    txt_tb.Text = dr.Item("tb")
                    txt_bb.Text = dr.Item("bb")
                    txt_tl.Text = dr.Item("tl")
                    txt_bl.Text = dr.Item("bl")
                    txt_dp.Text = dr.Item("dp")
                    txt_slope.Text = dr.Item("slope")
                    txt_vol.Text = dr.Item("vol")
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("Previous data read error", MsgBoxStyle.OkOnly, "Database read error")
                dr.Close()
            End Try
            Try
                con_cls.cmd.CommandText = "DELETE FROM Estimate_reservoir WHERE refNo='" & frm_Estimate_home.refNo_reservoirEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                frm_Estimate_home.refNo_reservoirEst = ""
            Catch ex As Exception
                MsgBox("Record delete after previous data read error", MsgBoxStyle.OkOnly, "Database record delete error")
            End Try
            con_cls.disconnect()
        End If

    End Sub

    Private Sub DTP_dateEst_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_dateEst.ValueChanged
        txt_dateEst.Text = DTP_dateEst.Value
    End Sub

    Private Sub cmb_unit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_unit.SelectedIndexChanged
        distanceUnit = cmb_unit.SelectedItem
    End Sub

    Private Sub cmd_calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_calculate.Click
        Dim length As Double
        Dim breadth As Double
        Dim depth As Double
        Dim volume As Double
        Dim slope As Decimal
        Call check_empty_fields()
        If empty_field_status = "OK" Then
            length = CDec(txt_tl.Text) + CDec(txt_bl.Text)
            breadth = CDec(txt_tb.Text) + CDec(txt_bb.Text)
            depth = CDec(txt_dp.Text)
            volume = ((0.5 * length) * (0.5 * breadth)) * depth
            slope = (CDbl(txt_tl.Text) - CDbl(txt_bl.Text)) / 2
            txt_vol.Text = volume
            txt_slope.Text = Math.Truncate(slope) & " : " & depth
        End If
    End Sub

    Private Sub cmd_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_continue.Click
        Try
            Call check_empty_fields()
            If empty_field_status = "OK" And (Not txt_slope.Text = "") And (Not txt_vol.Text = "") Then
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "INSERT INTO Estimate_reservoir (refNo,dateEst,unit,tb,bb,tl,bl,dp,slope,vol) VALUES ('" & txt_refNo.Text & "','" & _
                    CDate(txt_dateEst.Text) & "','" & distanceUnit & "'," & txt_tb.Text & "," & txt_bb.Text & "," & txt_tl.Text & "," & txt_bl.Text & "," & _
                    txt_dp.Text & ",'" & txt_slope.Text & "'," & txt_vol.Text & ")"
                    con_cls.cmd.ExecuteNonQuery()
                    '====================================================
                    '============Setting global variable values
                    '====================================================
                    frm_Estimate_home.refNo_reservoirEst = txt_refNo.Text
                    frm_Estimate_home.parentEstimateForm = "RESERVOIR"
                    Call resetFields()
                    continueStatus = "OK"
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Sql querry error")
                End Try
                con_cls.disconnect()
                Me.Close()
                Try
                    Dim form As New frm_select_rates
                    form.MdiParent = frm_Estimate_home
                    form.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Open Child")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Database insert error", MsgBoxStyle.OkOnly, "Database connectivety error")
        End Try

    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        frm_Estimate_home.refNo_reservoirEst = ""
        Call resetFields()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        If MessageBox.Show("All entered data will be lost. Are you sure to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frm_Estimate_home.refNo_reservoirEst = ""
            continueStatus = ""
            frm_Estimate_home.MS_Home.Items(0).Enabled = True
            Me.Close()
        End If
    End Sub

    Public Sub resetFields()
        txt_refNo.Clear()
        distanceUnit = ""
        DTP_dateEst.Value = System.DateTime.Today
        txt_dateEst.Clear()
        cmb_unit.SelectedIndex = 0
        txt_tl.Clear()
        txt_bl.Clear()
        txt_bb.Clear()
        txt_tb.Clear()
        txt_dp.Clear()
        txt_vol.Clear()
        txt_slope.Clear()
        txt_refNo.Focus()
        continueStatus = ""
        frm_Estimate_home.MS_Home.Items(0).Enabled = False
    End Sub

    '=================================================================
    '                   EMPTY FIELD VALIDATION OF DATA FIELDS
    '=================================================================

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_refNo.Text = "" Then
            MsgBox("Please enter reference number", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_refNo.Focus()
            Exit Sub
        ElseIf txt_dateEst.Text = "" Then
            MsgBox("Please enter estimate date", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_dateEst.Focus()
            Exit Sub
        ElseIf distanceUnit = "" Then
            MsgBox("Please select unit", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmb_unit.Focus()
            Exit Sub
        ElseIf txt_tb.Text = "" Then
            MsgBox("Please enter top breadth", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_tb.Focus()
            Exit Sub
        ElseIf txt_bb.Text = "" Then
            MsgBox("Please enter bottom breadth", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_bb.Focus()
            Exit Sub
        ElseIf txt_tl.Text = "" Then
            MsgBox("Please enter top length", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_tl.Focus()
            Exit Sub
        ElseIf txt_bl.Text = "" Then
            MsgBox("Please enter bottom length", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_bl.Focus()
            Exit Sub
        ElseIf txt_dp.Text = "" Then
            MsgBox("Please enter depth of reservoir", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_dp.Focus()
            Exit Sub
        Else
            empty_field_status = "OK"
        End If
    End Sub


    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_refNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_refNo.Validating
        Try
            Call valid.txt_refNo_validate(txt_refNo.Text, txt_refNo)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub DTP_dateEst_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DTP_dateEst.Validating
        txt_dateEst.Focus()
    End Sub

    Private Sub txt_dateEst_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_dateEst.Validating
        Try
            Call valid.date_validate(txt_dateEst.Text, DTP_dateEst.Value, DTP_dateEst)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub cmb_unit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmb_unit.Validating
        Try
            Call valid.distUnit_validate(distanceUnit, cmb_unit)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_tl_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_tl.Validating
        Try
            Call valid.distance_validate(txt_tl.Text, txt_tl)
            If (Not txt_tl.Text = "") And (Not txt_bl.Text = "") Then
                If CDbl(txt_tl.Text) < CDbl(txt_bl.Text) Then
                    MsgBox("Top length cannot be smaller than bottom length", MsgBoxStyle.OkOnly, "Validation error")
                    txt_tl.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_bl_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_bl.Validating
        Try
            Call valid.distance_validate(txt_bl.Text, txt_bl)
            If (Not txt_tl.Text = "") And (Not txt_bl.Text = "") Then
                If CDbl(txt_tl.Text) < CDbl(txt_bl.Text) Then
                    MsgBox("Bottom length cannot be bigger than top length", MsgBoxStyle.OkOnly, "Validation error")
                    txt_bl.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_tb_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_tb.Validating
        Try
            Call valid.distance_validate(txt_tb.Text, txt_tb)
            If (Not txt_tb.Text = "") And (Not txt_bb.Text = "") Then
                If CDbl(txt_tb.Text) < CDbl(txt_bb.Text) Then
                    MsgBox("Top breadth cannot be smaller than bottom breadth", MsgBoxStyle.OkOnly, "Validation error")
                    txt_tb.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_bb_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_bb.Validating
        Try
            Call valid.distance_validate(txt_bb.Text, txt_bb)
            If (Not txt_tb.Text = "") And (Not txt_bb.Text = "") Then
                If CDbl(txt_tb.Text) < CDbl(txt_bb.Text) Then
                    MsgBox("Bottom breadth cannot be bigger than top breadth", MsgBoxStyle.OkOnly, "Validation error")
                    txt_bb.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_dp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_dp.Validating
        Try
            Call valid.distance_validate(txt_dp.Text, txt_dp)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class