Imports System.Math

Public Class frm_slopeCal
    Dim valid As New class_validation_functions

    Private Sub frm_utilities_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
    End Sub

    Private Sub cmd_calSlope_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_calSlope.Click
        Call validateFields()
        If valid.err_code = 1 Then
            txt_slope_percent.Focus()
            Exit Sub
        End If
        If (Not txt_slope_perp.Text = "") And (Not txt_slope_base.Text = "") Then
            txt_slope_percent.Text = Round(((Atan(CDbl(txt_slope_perp.Text) / CDbl(txt_slope_base.Text))) * (180 / PI)), 2)
        Else
            MsgBox("Please enter both the slope parameters to calculate.", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
        End If
    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        Call resetFields()
    End Sub

    Public Sub resetFields()
        txt_slope_perp.Clear()
        txt_slope_base.Clear()
        txt_slope_percent.Clear()
        txt_slope_perp.Text = "Vertical or Perpendicular"
        txt_slope_base.Text = "Horizontal or Base"
    End Sub

    Public Sub validateFields()
        Try
            Call valid.perpbase_validate(txt_slope_perp.Text, txt_slope_perp)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
        If valid.err_code = 1 Then
            Exit Sub
        End If
        Try
            Call valid.perpbase_validate(txt_slope_base.Text, txt_slope_base)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub
    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    Private Sub txt_slope_perp_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_slope_perp.Enter
        If txt_slope_perp.Text = "" Or txt_slope_perp.Text = "Vertical or Perpendicular" Then
            txt_slope_perp.Text = ""
        End If
    End Sub

    Private Sub txt_slope_perp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_slope_perp.Validating
        If txt_slope_perp.Text = "" Then
            txt_slope_perp.Text = "Vertical or Perpendicular"
        Else
            Try
                Call valid.perpbase_validate(txt_slope_perp.Text, txt_slope_perp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_slope_base_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_slope_base.Enter
        If txt_slope_base.Text = "" Or txt_slope_base.Text = "Horizontal or Base" Then
            txt_slope_base.Text = ""
        End If
    End Sub

    Private Sub txt_slope_base_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_slope_base.Validating
        If txt_slope_base.Text = "" Then
            txt_slope_base.Text = "Horizontal or Base"
        Else
            Try
                Call valid.perpbase_validate(txt_slope_base.Text, txt_slope_base)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

End Class