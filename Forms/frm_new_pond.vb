Imports System.Data
Imports System.Math
Imports System.Data.SqlClient

Public Class frm_new_pond
    Dim con_cls As New class_connect_string
    Dim valid As New class_validation_functions
    Dim dr As SqlDataReader
    Public empty_field_status_pond, empty_field_status_bund, empty_field_status_drain, empty_field_status_turf, empty_field_status_cutting As String
    Public distanceUnit, continueStatus As String
    Public errCode As Integer
    Public bottomLength_pp, bottomBreadth_pp As Double
    Public bottomWidth_bp, areaCS_bp As Double
    Public bottomBreadth_dp, areaCS_dp As Double
    Public length_cp, breadth_cp, totAreaCut_cp As Double
    Public perimeterBundGlobal, totWidth_bp, surfaceArea_bp As Double
    Public plotLength, plotBreadth, plotArea As Double
    Public totVolEEW As Double

    Private Sub frm_new_pond_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call resetFields()
        '==========================================================================
        '=== If this form is reopened from the next form by clicking back command
        '==========================================================================
        If Not frm_Estimate_home.refNo_pondEst = "" Then
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "SELECT * FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                dr = con_cls.cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    txt_refNo.Text = dr.Item("refNo")
                    txt_dateEst.Text = dr.Item("dateEst")
                    cmb_unit.SelectedItem = dr.Item("unit")
                    txt_length_pp.Text = dr.Item("length_pp")
                    txt_breadth_pp.Text = dr.Item("breadth_pp")
                    txt_depth_pp.Text = dr.Item("depth_pp")
                    txt_slope_pp.Text = dr.Item("slope_pp")
                    txt_vol_pp.Text = dr.Item("volume_pp")

                    If dr.Item("bund") = "TRUE" Then
                        Call enableBP()
                        txt_berm_bp.Text = dr.Item("berm_bp")
                        txt_topWidth_bp.Text = dr.Item("topWidth_bp")
                        txt_height_bp.Text = dr.Item("height_bp")
                        txt_slope_bp.Text = dr.Item("slope_bp")
                        txt_vol_bp.Text = dr.Item("volume_bp")
                    Else
                        Call disableBP()
                    End If

                    If dr.Item("sideDrain") = "TRUE" Then
                        Call enableDP()
                        txt_length_dp.Text = dr.Item("length_dp")
                        txt_breadth_dp.Text = dr.Item("breadth_dp")
                        txt_depth_dp.Text = dr.Item("depth_dp")
                        txt_slope_dp.Text = dr.Item("slope_dp")
                        txt_vol_dp.Text = dr.Item("volume_dp")
                    Else
                        Call disableDP()
                    End If

                    If dr.Item("turf") = "TRUE" Then
                        Call enableTP()
                        txt_length_tp.Text = dr.Item("length_tp")
                        txt_totWidth_tp.Text = dr.Item("totWidth_tp")
                        txt_totArea_tp.Text = dr.Item("totArea_tp")
                    Else
                        Call disableTP()
                    End If

                    If dr.Item("cutting") = "TRUE" Then
                        Call enableCP()
                        txt_length_cp.Text = dr.Item("length_cp")
                        txt_breadth_cp.Text = dr.Item("breadth_cp")
                        txt_totAreaCut_cp.Text = dr.Item("totAreaCut_cp")
                    Else
                        Call disableCP()
                    End If
                    dr.Close()
                End If
            Catch ex As Exception
                MsgBox("Previous data read error", MsgBoxStyle.OkOnly, "Database read error")
                dr.Close()
            End Try

            Try
                con_cls.cmd.CommandText = "DELETE FROM Estimate_pond WHERE refNo='" & frm_Estimate_home.refNo_pondEst & "'"
                con_cls.cmd.ExecuteNonQuery()
                frm_Estimate_home.refNo_pondEst = ""
            Catch ex As Exception
                MsgBox("Record delete after previous data read error", MsgBoxStyle.OkOnly, "Database record delete error")
            End Try
            con_cls.disconnect()
        End If
        '==========================================================================

    End Sub

    Private Sub frm_new_pond_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not continueStatus = "OK" Then
            frm_Estimate_home.MS_Home.Items(0).Enabled = True
        End If
    End Sub

    Private Sub DTP_dateEst_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_dateEst.ValueChanged
        txt_dateEst.Text = DTP_dateEst.Value.Date
    End Sub

    Private Sub cmb_unit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_unit.SelectedIndexChanged
        distanceUnit = cmb_unit.SelectedItem
    End Sub

    Private Sub chk_bund_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bund.CheckedChanged
        If chk_bund.CheckState = CheckState.Checked Then
            Call enableBP()
        Else
            Call disableBP()
        End If
    End Sub

    Private Sub chk_cutting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cutting.CheckedChanged
        If chk_cutting.CheckState = CheckState.Checked Then
            Call enableCP()
            '   AUTO LOAD CUTTING PARAMETERS (DEFAULT)
            Call check_empty_fields_pondParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If chk_bund.CheckState = CheckState.Checked Then
                Call check_empty_fields_bundParameters()
                If errCode = 1 Then
                    Exit Sub
                End If
            Else
                empty_field_status_bund = ""
            End If
            If empty_field_status_pond = "OK" And empty_field_status_bund = "OK" Then
                txt_length_cp.Text = CDbl(txt_length_pp.Text) + (2 * CDbl(txt_berm_bp.Text)) + (2 * bottomWidth_bp)
                txt_breadth_cp.Text = CDbl(txt_breadth_pp.Text) + (2 * CDbl(txt_berm_bp.Text)) + (2 * bottomWidth_bp)
            ElseIf empty_field_status_pond = "OK" And empty_field_status_bund = "" Then
                txt_length_cp.Text = CDbl(txt_length_pp.Text)
                txt_breadth_cp.Text = CDbl(txt_breadth_pp.Text)
            End If
            '-----------------------------------------
        Else
            Call disableCP()
        End If
    End Sub

    Private Sub chk_sideDrain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_sideDrain.CheckedChanged
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Call enableDP()
        Else
            Call disableDP()
        End If
    End Sub

    Private Sub chk_turfing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_turfing.CheckedChanged
        If chk_turfing.CheckState = CheckState.Checked Then
            Call enableTP()

            '   AUTO LOAD TURFING PARAMETERS (DEFAULT)
            If chk_bund.CheckState = CheckState.Checked Then
                Call check_empty_fields_bundParameters()
                If errCode = 1 Or txt_vol_bp.Text = "" Then
                    Exit Sub
                End If
                txt_length_tp.Text = perimeterBundGlobal
                txt_totWidth_tp.Text = Round((CDbl(txt_topWidth_bp.Text) + (2 * (CDbl(txt_height_bp.Text) / Sin((CDbl(txt_slope_bp.Text) * (PI / 180)))))), 2)
            End If
            '-----------------------------------------
        Else
            Call disableTP()
        End If
    End Sub

    Private Sub cmd_calculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_calculate.Click
        Dim length_pp, breadth_pp, depth_pp, volume_pp As Double
        Dim slope As Decimal
        Dim perimeterBund, berm_bp As Double

        '           CALCULATION OF POND PARAMETERS
        Call check_empty_fields_pondParameters()
        If errCode = 1 Then
            Exit Sub
        End If
        If empty_field_status_pond = "OK" Then
            length_pp = CDbl(txt_length_pp.Text)
            breadth_pp = CDbl(txt_breadth_pp.Text)
            depth_pp = CDbl(txt_depth_pp.Text)
            slope = (CDbl(txt_slope_pp.Text) * (PI / 180))
            bottomLength_pp = Round(length_pp - (2 * (depth_pp / Tan(slope))), 2)
            bottomBreadth_pp = Round(breadth_pp - (2 * (depth_pp / Tan(slope))), 2)
            If bottomLength_pp > 1 And bottomBreadth_pp > 1 Then
                volume_pp = ((length_pp + bottomLength_pp) / 2) * ((breadth_pp + bottomBreadth_pp) / 2) * depth_pp
                txt_vol_pp.Text = Round(volume_pp, 2)
            Else
                MsgBox("Please check pond parameters before proceeding further.", MsgBoxStyle.OkOnly, "Parameter error.")
                Exit Sub
            End If
        End If

        '           CALCULATION OF BUND PARAMETERS
        If chk_bund.CheckState = CheckState.Checked Then
            Call check_empty_fields_bundParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_bund = "OK" Then
                Dim topWidth_bp, height_bp, volume_bp As Double
                topWidth_bp = CDbl(txt_topWidth_bp.Text)
                height_bp = CDbl(txt_height_bp.Text)
                berm_bp = CDbl(txt_berm_bp.Text)
                slope = (CDbl(txt_slope_bp.Text) * (PI / 180))
                bottomWidth_bp = Round(topWidth_bp + (2 * (height_bp / Tan(slope))), 2)
                areaCS_bp = Round((height_bp * (topWidth_bp + bottomWidth_bp) / 2), 2)
                perimeterBund = Round((2 * (length_pp + (2 * berm_bp) + bottomWidth_bp)) + (2 * (breadth_pp + (2 * berm_bp) + bottomWidth_bp)), 2)
                totWidth_bp = Round((CDbl(txt_topWidth_bp.Text) + (2 * (CDbl(txt_height_bp.Text) / Sin((CDbl(txt_slope_bp.Text) * (PI / 180)))))), 2)
                perimeterBundGlobal = perimeterBund
                surfaceArea_bp = Round(perimeterBund * totWidth_bp, 2)
                volume_bp = areaCS_bp * perimeterBund
                txt_vol_bp.Text = Round(volume_bp, 2)
            End If
        End If

        '           CALCULATION OF SIDE DRAIN PARAMETERS
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Call check_empty_fields_drainParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_drain = "OK" Then
                Dim length_dp, breadth_dp, depth_dp, volume_dp As Double
                length_dp = CDbl(txt_length_dp.Text)
                breadth_dp = CDbl(txt_breadth_dp.Text)
                depth_dp = CDbl(txt_depth_dp.Text)
                slope = (CDbl(txt_slope_dp.Text) * (PI / 180))
                bottomBreadth_dp = Round(breadth_dp - (2 * (depth_dp / Tan(slope))), 2)
                If bottomBreadth_dp > 0 Then
                    areaCS_dp = Round((depth_dp * ((breadth_dp + bottomBreadth_dp) / 2)), 2)
                    volume_dp = areaCS_dp * length_dp
                    txt_vol_dp.Text = Round(volume_dp, 2)
                Else
                    MsgBox("Please check side drain parameters before proceeding further.", MsgBoxStyle.OkOnly, "Parameter error.")
                    Exit Sub
                End If
            End If
        End If

        '           CALCULATION OF TURFING PARAMETERS
        If chk_turfing.CheckState = CheckState.Checked Then
            Call check_empty_fields_turfParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_turf = "OK" Then
                Dim length_tp, totWidth_tp, totArea_tp As Double
                length_tp = CDbl(txt_length_tp.Text)
                totWidth_tp = CDbl(txt_totWidth_tp.Text)
                totArea_tp = length_tp * totWidth_tp
                txt_totArea_tp.Text = Round(totArea_tp, 2)
            End If
        End If

        '           CALCULATION OF JUNGLE CUTTING PARAMETERS
        If chk_cutting.CheckState = CheckState.Checked Then
            Call check_empty_fields_cuttingParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_cutting = "OK" Then
                length_cp = CDbl(txt_length_cp.Text)
                breadth_cp = CDbl(txt_breadth_cp.Text)
                totAreaCut_cp = length_cp * breadth_cp
                txt_totAreaCut_cp.Text = Round(totAreaCut_cp, 2)
            End If
        End If

        '           CALCULATION OF PLOT PARAMETERS
        If chk_bund.CheckState = CheckState.Checked Then
            Call check_empty_fields_bundParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            Call check_empty_fields_pondParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_pond = "OK" And empty_field_status_bund = "OK" Then
                plotLength = Round((length_pp + (2 * berm_bp) + (2 * bottomWidth_bp)), 2)
                plotBreadth = Round((breadth_pp + (2 * berm_bp) + (2 * bottomWidth_bp)), 2)
                plotArea = Round(plotLength * plotBreadth, 2)
            End If
        Else
            Call check_empty_fields_pondParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_pond = "OK" Then
                plotLength = Round(length_pp, 2)
                plotBreadth = Round(breadth_pp, 2)
                plotArea = Round(plotLength * plotBreadth, 2)
            End If
        End If

        '           CALCULATION OF EARTH EXCAVATION WORK (EEW) PARAMETERS
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Call check_empty_fields_drainParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            Call check_empty_fields_pondParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_pond = "OK" And empty_field_status_drain = "OK" Then
                totVolEEW = Round((CDbl(txt_vol_pp.Text) + CDbl(txt_vol_dp.Text)), 2)
            End If
        Else
            Call check_empty_fields_pondParameters()
            If errCode = 1 Then
                Exit Sub
            End If
            If empty_field_status_pond = "OK" Then
                totVolEEW = Round(CDbl(txt_vol_pp.Text), 2)
            End If
        End If

    End Sub

    Private Sub cmd_continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_continue.Click
        '=====================================================================
        '                   UPDATE POND PARAMETERS IN TABLE
        '=====================================================================
        Call check_empty_fields_pondParameters()
        If errCode = 1 Or txt_vol_pp.Text = "" Then
            MsgBox("Please calculate volume of pond excavation", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmd_calculate.Focus()
            Exit Sub
        Else
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "INSERT INTO Estimate_pond (refNo,dateEst,unit,length_pp,breadth_pp,depth_pp,slope_pp,volume_pp,bottomLength_pp,bottomBreadth_pp) VALUES ('" & _
                txt_refNo.Text & "'," & CDate(txt_dateEst.Text) & ",'" & distanceUnit & "','" & txt_length_pp.Text & "','" & txt_breadth_pp.Text & "','" & txt_depth_pp.Text & "','" & txt_slope_pp.Text & _
                "','" & txt_vol_pp.Text & "','" & bottomLength_pp & "','" & bottomBreadth_pp & "')"
                con_cls.cmd.ExecuteNonQuery()
                '====================================================
                '============Setting global variable values
                '====================================================
                frm_Estimate_home.refNo_pondEst = txt_refNo.Text
                frm_Estimate_home.parentEstimateForm = "POND"
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "POND Sql querry error")
            End Try
        End If

        '=====================================================================
        '                   UPDATE BUND PARAMETERS IN TABLE
        '=====================================================================
        If chk_bund.CheckState = CheckState.Checked Then
            Call check_empty_fields_bundParameters()
            If errCode = 1 Or txt_vol_bp.Text = "" Then
                MsgBox("Please calculate earth volume for bund", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
                cmd_calculate.Focus()
                Exit Sub
            Else
                '      IF BUND PARAMETERS ARE CHECKED AND CALCULATED
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "UPDATE Estimate_pond SET bund='TRUE',berm_bp='" & txt_berm_bp.Text & "',topWidth_bp='" & txt_topWidth_bp.Text & "',height_bp='" & txt_height_bp.Text & "',slope_bp='" & _
                    txt_slope_bp.Text & "',volume_bp='" & txt_vol_bp.Text & "',bottomWidth_bp='" & bottomWidth_bp & "',areaCS_bp='" & areaCS_bp & "',perimeter_bp='" & perimeterBundGlobal & "',totWidth_bp='" & _
                    totWidth_bp & "',surfaceArea_bp='" & surfaceArea_bp & "' WHERE refNo='" & txt_refNo.Text & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "BUND Sql querry error")
                End Try
            End If
        Else
            '      IF BUND PARAMETERS ARE NOT CHECKED AND NOT CALCULATED
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "UPDATE Estimate_pond SET bund='FALSE',berm_bp='" & txt_berm_bp.Text & "',topWidth_bp='" & txt_topWidth_bp.Text & "',height_bp='" & _
                txt_height_bp.Text & "',slope_bp='" & txt_slope_bp.Text & "',volume_bp='" & txt_vol_bp.Text & "',bottomWidth_bp='-- N.A. --',areaCS_bp='-- N.A. --',perimeter_bp=" & _
                "'-- N.A. --',totWidth_bp='-- N.A. --',surfaceArea_bp='-- N.A. --' WHERE refNo='" & txt_refNo.Text & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "BUND Sql querry error")
            End Try
        End If

        '=====================================================================
        '               UPDATE SIDE DRAIN PARAMETERS IN TABLE
        '=====================================================================
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Call check_empty_fields_drainParameters()
            If errCode = 1 Or txt_vol_dp.Text = "" Then
                MsgBox("Please calculate volume of drain excavation", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
                cmd_calculate.Focus()
                Exit Sub
            Else
                '      IF SIDE DRAIN PARAMETERS ARE CHECKED AND CALCULATED
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "UPDATE Estimate_pond SET sideDrain='TRUE',length_dp='" & txt_length_dp.Text & "',breadth_dp='" & txt_breadth_dp.Text & "',depth_dp='" & txt_depth_dp.Text & "',slope_dp='" & _
                    txt_slope_dp.Text & "',volume_dp='" & txt_vol_dp.Text & "',bottomBreadth_dp='" & bottomBreadth_dp & "',areaCS_dp='" & areaCS_dp & "' WHERE refNo='" & txt_refNo.Text & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SIDE DRAIN Sql querry error")
                End Try
            End If
        Else
            '      IF SIDE DRAIN PARAMETERS ARE NOT CHECKED AND NOT CALCULATED
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "UPDATE Estimate_pond SET sideDrain='FALSE',length_dp='" & txt_length_dp.Text & "',breadth_dp='" & txt_breadth_dp.Text & "',depth_dp='" & txt_depth_dp.Text & "',slope_dp='" & _
                txt_slope_dp.Text & "',volume_dp='" & txt_vol_dp.Text & "',bottomBreadth_dp='-- N.A. --',areaCS_dp='-- N.A. --' WHERE refNo='" & txt_refNo.Text & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "SIDE DRAIN Sql querry error")
            End Try
        End If

        '=====================================================================
        '               UPDATE TURFING PARAMETERS IN TABLE
        '=====================================================================
        If chk_turfing.CheckState = CheckState.Checked Then
            Call check_empty_fields_turfParameters()
            If errCode = 1 Or txt_totArea_tp.Text = "" Then
                MsgBox("Please calculate surface area for turfing", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
                cmd_calculate.Focus()
                Exit Sub
            Else
                '      IF TURFING PARAMETERS ARE CHECKED AND CALCULATED
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "UPDATE Estimate_pond SET turf='TRUE',length_tp='" & txt_length_tp.Text & "',totWidth_tp='" & txt_totWidth_tp.Text & "',totArea_tp='" & txt_totArea_tp.Text & _
                    "' WHERE refNo='" & txt_refNo.Text & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "TURFING Sql querry error")
                End Try
            End If
        Else
            '      IF TURFING PARAMETERS ARE NOT CHECKED AND NOT CALCULATED
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "UPDATE Estimate_pond SET turf='FALSE',length_tp='" & txt_length_tp.Text & "',totWidth_tp='" & txt_totWidth_tp.Text & "',totArea_tp='" & txt_totArea_tp.Text & _
                "' WHERE refNo='" & txt_refNo.Text & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "TURFING Sql querry error")
            End Try
        End If

        '=====================================================================
        '               UPDATE JUNGLE CUTTING PARAMETERS IN TABLE
        '=====================================================================
        If chk_cutting.CheckState = CheckState.Checked Then
            If txt_totAreaCut_cp.Text = "" Then
                MsgBox("Please calculate area for cleaning jungles", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
                cmd_calculate.Focus()
                Exit Sub
            Else
                '      IF JUNGLE CUTTING PARAMETERS ARE CHECKED AND CALCULATED
                con_cls.connect()
                Try
                    con_cls.cmd.CommandText = "UPDATE Estimate_pond SET cutting='TRUE',length_cp='" & length_cp & "',breadth_cp='" & breadth_cp & "',totAreaCut_cp='" & txt_totAreaCut_cp.Text & _
                    "' WHERE refNo='" & txt_refNo.Text & "'"
                    con_cls.cmd.ExecuteNonQuery()
                    con_cls.disconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "JUNGLE CUTTING Sql querry error")
                End Try
            End If
        Else
            '      IF JUNGLE CUTTING PARAMETERS ARE NOT CHECKED AND NOT CALCULATED
            con_cls.connect()
            Try
                con_cls.cmd.CommandText = "UPDATE Estimate_pond SET cutting='FALSE',length_cp='-- N.A. --',breadth_cp='-- N.A. --',totAreaCut_cp='-- N.A. --' WHERE refNo='" & txt_refNo.Text & "'"
                con_cls.cmd.ExecuteNonQuery()
                con_cls.disconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "JUNGLE CUTTING Sql querry error")
            End Try
        End If

        '=====================================================================
        '               UPDATE PLOT PARAMETERS IN TABLE
        '=====================================================================
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "UPDATE Estimate_pond SET plotLength='" & plotLength & "',plotBreadth='" & plotBreadth & "',plotArea='" & plotArea & "' WHERE refNo='" & txt_refNo.Text & "'"
            con_cls.cmd.ExecuteNonQuery()
            con_cls.disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Plot parameter Sql querry error")
        End Try

        '=====================================================================
        '        UPDATE TOTAL EARTH EXCAVATION WORK PARAMETER IN TABLE
        '=====================================================================
        con_cls.connect()
        Try
            con_cls.cmd.CommandText = "UPDATE Estimate_pond SET totVolEEW='" & totVolEEW & "' WHERE refNo='" & txt_refNo.Text & "'"
            con_cls.cmd.ExecuteNonQuery()
            con_cls.disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Total earth excavation work parameter Sql querry error")
        End Try

        '=====================================================================
        '                    POST UPDATE GLOBAL TASKS
        '=====================================================================
        Call resetFields()
        continueStatus = "OK"
        Me.Close()
        Try
            Dim form As New frm_select_rates
            form.MdiParent = frm_Estimate_home
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try

    End Sub

    Private Sub cmd_reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reset.Click
        frm_Estimate_home.refNo_pondEst = ""
        frm_Estimate_home.parentEstimateForm = ""
        Call resetFields()
    End Sub

    Private Sub cmd_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_cancel.Click
        If MessageBox.Show("All entered data will be lost. Are you sure to continue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frm_Estimate_home.refNo_pondEst = ""
            Me.Close()
        End If
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================

    Public Sub resetFields()
        txt_refNo.Clear()
        distanceUnit = ""
        DTP_dateEst.Value = System.DateTime.Today
        txt_dateEst.Clear()
        cmb_unit.SelectedIndex = 0
        txt_length_pp.Clear()
        txt_length_pp.Clear()
        txt_breadth_pp.Clear()
        txt_slope_pp.Clear()
        txt_depth_pp.Clear()
        txt_vol_pp.Clear()
        txt_refNo.Focus()
        empty_field_status_pond = ""
        continueStatus = ""
        frm_Estimate_home.MS_Home.Items(0).Enabled = False
        Call disableDP()
        Call disableBP()
        Call disableTP()
        Call disableCP()
    End Sub

    Public Sub disableDP()
        txt_length_dp.Text = "-- N.A. --"
        txt_breadth_dp.Text = "-- N.A. --"
        txt_depth_dp.Text = "-- N.A. --"
        txt_slope_dp.Text = "-- N.A. --"
        txt_vol_dp.Text = "-- N.A. --"
        GPB_DP.Enabled = False
        chk_sideDrain.Checked = False
    End Sub

    Public Sub enableDP()
        txt_length_dp.Clear()
        txt_breadth_dp.Clear()
        txt_depth_dp.Clear()
        txt_slope_dp.Clear()
        txt_vol_dp.Clear()
        GPB_DP.Enabled = True
        chk_sideDrain.Checked = True
        empty_field_status_drain = ""
    End Sub

    Public Sub disableBP()
        txt_berm_bp.Text = "-- N.A. --"
        txt_topWidth_bp.Text = "-- N.A. --"
        txt_height_bp.Text = "-- N.A. --"
        txt_slope_bp.Text = "-- N.A. --"
        txt_vol_bp.Text = "-- N.A. --"
        GPB_BP.Enabled = False
        chk_bund.Checked = False
    End Sub

    Public Sub enableBP()
        txt_berm_bp.Clear()
        txt_topWidth_bp.Clear()
        txt_height_bp.Clear()
        txt_slope_bp.Clear()
        txt_vol_bp.Clear()
        GPB_BP.Enabled = True
        chk_bund.Checked = True
        empty_field_status_bund = ""
    End Sub

    Public Sub disableTP()
        txt_length_tp.Text = "-- N.A. --"
        txt_totWidth_tp.Text = "-- N.A. --"
        txt_totArea_tp.Text = "-- N.A. --"
        GPB_TP.Enabled = False
        chk_turfing.Checked = False
    End Sub

    Public Sub enableTP()
        txt_length_tp.Clear()
        txt_totWidth_tp.Clear()
        txt_totArea_tp.Clear()
        GPB_TP.Enabled = True
        chk_turfing.Checked = True
        empty_field_status_turf = ""
    End Sub

    Public Sub disableCP()
        txt_length_cp.Text = "-- N.A. --"
        txt_breadth_cp.Text = "-- N.A. --"
        txt_totAreaCut_cp.Text = "-- N.A. --"
        GPB_CP.Enabled = False
        chk_cutting.Checked = False
    End Sub

    Public Sub enableCP()
        txt_length_cp.Clear()
        txt_breadth_cp.Clear()
        txt_totAreaCut_cp.Clear()
        GPB_CP.Enabled = True
        chk_cutting.Checked = True
        empty_field_status_cutting = ""
    End Sub

    '=================================================================
    '                   EMPTY FIELD VALIDATION OF DATA FIELDS
    '=================================================================

    Public Sub check_empty_fields_pondParameters()
        empty_field_status_pond = ""
        If txt_refNo.Text = "" Then
            MsgBox("Please enter reference number of pond", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_refNo.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_dateEst.Text = "" Then
            MsgBox("Please enter estimate date of pond", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_dateEst.Focus()
            errCode = 1
            Exit Sub
        ElseIf distanceUnit = "" Then
            MsgBox("Please select unit of pond", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            cmb_unit.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_breadth_pp.Text = "" Then
            MsgBox("Please enter breadth of pond", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_breadth_pp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_length_pp.Text = "" Then
            MsgBox("Please enter length of pond", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_length_pp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_depth_pp.Text = "" Then
            MsgBox("Please enter depth of pond", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_depth_pp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_slope_pp.Text = "" Then
            MsgBox("Please enter slope percent of pond", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_slope_pp.Focus()
            errCode = 1
            Exit Sub
        Else
            empty_field_status_pond = "OK"
            errCode = 0
        End If
    End Sub

    Public Sub check_empty_fields_bundParameters()
        empty_field_status_bund = ""
        If txt_berm_bp.Text = "" Then
            MsgBox("Please enter berm of bund", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_berm_bp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_topWidth_bp.Text = "" Then
            MsgBox("Please enter top width of bund", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_topWidth_bp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_height_bp.Text = "" Then
            MsgBox("Please enter height of bund", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_height_bp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_slope_bp.Text = "" Then
            MsgBox("Please enter slope percent of bund", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_slope_bp.Focus()
            errCode = 1
            Exit Sub
        Else
            empty_field_status_bund = "OK"
            errCode = 0
        End If
    End Sub

    Public Sub check_empty_fields_drainParameters()
        empty_field_status_drain = ""
        If txt_length_dp.Text = "" Then
            MsgBox("Please enter length of drain", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_length_dp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_breadth_dp.Text = "" Then
            MsgBox("Please enter breadth of drain", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_breadth_dp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_depth_dp.Text = "" Then
            MsgBox("Please enter depth of drain", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_depth_dp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_slope_dp.Text = "" Then
            MsgBox("Please enter slope percent of drain", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_slope_dp.Focus()
            errCode = 1
            Exit Sub
        Else
            empty_field_status_drain = "OK"
            errCode = 0
        End If
    End Sub

    Public Sub check_empty_fields_turfParameters()
        empty_field_status_turf = ""
        If txt_length_tp.Text = "" Then
            MsgBox("Please enter length of turf", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_length_tp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_totWidth_tp.Text = "" Then
            MsgBox("Please enter total width of turf", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_totWidth_tp.Focus()
            errCode = 1
            Exit Sub
        Else
            empty_field_status_turf = "OK"
            errCode = 0
        End If
    End Sub

    Public Sub check_empty_fields_cuttingParameters()
        empty_field_status_cutting = ""
        If txt_length_cp.Text = "" Then
            MsgBox("Please enter length of cutting parameter", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_length_cp.Focus()
            errCode = 1
            Exit Sub
        ElseIf txt_breadth_cp.Text = "" Then
            MsgBox("Please enter total breadth of cutting parameter", MsgBoxStyle.OkOnly, "Validation error (Empty field)")
            txt_breadth_cp.Focus()
            errCode = 1
            Exit Sub
        Else
            empty_field_status_cutting = "OK"
            errCode = 0
        End If
    End Sub

    '=================================================================
    '                   TEXT VALIDATION OF DATA FIELDS
    '=================================================================

    '                   ESTIMATE DETAILS VALIDATION

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

    Private Sub cmb_unit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            Call valid.distUnit_validate(distanceUnit, cmb_unit)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    '                   POND PARAMETERS VALIDATION

    Private Sub txt_length_pp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_length_pp.Validating
        Try
            Call valid.distance_validate(txt_length_pp.Text, txt_length_pp)
            If Not (Not txt_length_pp.Text = "") And (Not txt_breadth_pp.Text = "") Then
                If CDbl(txt_length_pp.Text) < CDbl(txt_breadth_pp.Text) Then
                    MsgBox("Length cannot be smaller than breadth.", MsgBoxStyle.OkOnly, "Validation error")
                    txt_length_pp.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_breadth_pp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_breadth_pp.Validating
        Try
            Call valid.distance_validate(txt_breadth_pp.Text, txt_breadth_pp)
            If (Not txt_length_pp.Text = "") And (Not txt_breadth_pp.Text = "") Then
                If CDbl(txt_length_pp.Text) < CDbl(txt_breadth_pp.Text) Then
                    MsgBox("Breadth cannot be bigger than length.", MsgBoxStyle.OkOnly, "Validation error")
                    txt_breadth_pp.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_depth_pp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_depth_pp.Validating
        Try
            Call valid.distance_validate(txt_depth_pp.Text, txt_depth_pp)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    Private Sub txt_slope_pp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_slope_pp.Validating
        Try
            Call valid.slope_validate(txt_slope_pp.Text, txt_slope_pp)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
        End Try
    End Sub

    '                   BUND PARAMETERS VALIDATION

    Private Sub txt_berm_bp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_berm_bp.Validating
        If chk_bund.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_berm_bp.Text, txt_berm_bp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_topWidth_bp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_topWidth_bp.Validating
        If chk_bund.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_topWidth_bp.Text, txt_topWidth_bp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_height_bp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_height_bp.Validating
        If chk_bund.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_height_bp.Text, txt_height_bp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_slope_bp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_slope_bp.Validating
        If chk_bund.CheckState = CheckState.Checked Then
            Try
                Call valid.slope_validate(txt_slope_bp.Text, txt_slope_bp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub
    

    '                   SIDEDRAIN PARAMETERS VALIDATION

    Private Sub txt_length_dp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_length_dp.Validating
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_length_dp.Text, txt_length_dp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_breadth_dp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_breadth_dp.Validating
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_breadth_dp.Text, txt_breadth_dp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_depth_dp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_depth_dp.Validating
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_depth_dp.Text, txt_depth_dp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_slope_dp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_slope_dp.Validating
        If chk_sideDrain.CheckState = CheckState.Checked Then
            Try
                Call valid.slope_validate(txt_slope_dp.Text, txt_slope_dp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    '                   TURFING PARAMETERS VALIDATION

    Private Sub txt_length_tp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_length_tp.Validating
        If chk_turfing.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_length_tp.Text, txt_length_tp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

    Private Sub txt_totWidth_tp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_totWidth_tp.Validating
        If chk_turfing.CheckState = CheckState.Checked Then
            Try
                Call valid.distance_validate(txt_totWidth_tp.Text, txt_totWidth_tp)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Connecting with class_validaton_function error")
            End Try
        End If
    End Sub

End Class