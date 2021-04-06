Imports System.Math

Public Class frm_cumCal
    Dim valid As New class_validation_functions
    Public empty_field_status As String

    Private Sub frm_cumCal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
    End Sub

    Private Sub cmd_calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_calculate.Click
        Call check_empty_fields()
        If empty_field_status = "OK" Then
            Dim length, breadth, bottomLength, bottomBreadth, depth, rate, volume, amount, slope As Double
            length = CDbl(txt_length.Text)
            breadth = CDbl(txt_breadth.Text)
            depth = CDbl(txt_depth.Text)
            slope = (CDbl(txt_slope.Text) * (PI / 180))
            bottomLength = length - (2 * (depth / Tan(slope)))
            bottomBreadth = breadth - (2 * (depth / Tan(slope)))
            If bottomLength > 1 And bottomBreadth > 1 Then
                rate = CDbl(txt_cumRate.Text)
                volume = ((length + bottomLength) / 2) * ((breadth + bottomBreadth) / 2) * depth
                amount = volume * rate
                txt_amount.Text = Round(amount, 2)
                txt_volume.Text = Round(volume, 2)
                txt_bottomLength.Text = Round(bottomLength, 2)
                txt_bottomBreadth.Text = Round(bottomBreadth, 2)
            Else
                MsgBox("Please check parameters before proceeding further.", MsgBoxStyle.OkOnly, "Parameter error.")
                Exit Sub
            End If
            
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
    End Sub

    Public Sub resetFields()
        txt_amount.Clear()
        txt_bottomBreadth.Clear()
        txt_bottomLength.Clear()
        txt_breadth.Clear()
        txt_cumRate.Clear()
        txt_depth.Clear()
        txt_length.Clear()
        txt_slope.Clear()
        txt_volume.Clear()
        txt_length.Focus()
    End Sub

    '=================================================================
    '                   EMPTY FIELD VALIDATION OF DATA FIELDS
    '=================================================================

    Public Sub check_empty_fields()
        empty_field_status = ""
        If txt_length.Text = "" Then
            MsgBox("Please enter length", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_length.Focus()
            Exit Sub
        ElseIf txt_breadth.Text = "" Then
            MsgBox("Please enter breadth", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_breadth.Focus()
            Exit Sub
        ElseIf txt_depth.Text = "" Then
            MsgBox("Please enter depth", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_depth.Focus()
            Exit Sub
        ElseIf txt_slope.Text = "" Then
            MsgBox("Please enter slope", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_slope.Focus()
            Exit Sub
        ElseIf txt_cumRate.Text = "" Then
            txt_cumRate.Text = "0.0"
            Call check_empty_fields()
        Else
            empty_field_status = "OK"
        End If
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_length_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_length.Validating
        Try
            Call valid.distance_validate(txt_length.Text, txt_length)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_breadth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_breadth.Validating
        Try
            Call valid.distance_validate(txt_breadth.Text, txt_breadth)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_depth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_depth.Validating
        Try
            Call valid.distance_validate(txt_depth.Text, txt_depth)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_slope_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_slope.Validating
        Try
            Call valid.distance_validate(txt_slope.Text, txt_slope)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_cumRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_cumRate.Validating
        Try
            Call valid.distance_validate(txt_cumRate.Text, txt_cumRate)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

End Class