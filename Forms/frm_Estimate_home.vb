Imports System
Imports System.Text
Imports System.Windows.Forms

Public Class frm_Estimate_home
    Dim con_cls As New class_connect_string
    Public refNo_pondEst, refNo_reservoirEst As String
    Public parentEstimateForm As String
    Dim filename As String
    Dim backUpPath As String
    Dim i, limit As Integer

    Private Sub frm_Estimate_home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call dbExistCheck()
        Call con_cls.softwareValidity(Me)
    End Sub

    '=================================================================
    '                   MAIN MENU ITEMS
    '=================================================================

    Private Sub TSMI_Reservoir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_Reservoir.Click
        Try
            Dim form As New frm_new_reservoir
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_Pond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_Pond.Click
        Try
            Dim form As New frm_new_pond
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_View.Click
        Try
            Dim form As New frm_view
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_Rate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_Rate.Click
        Try
            Dim form As New frm_rate
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub TSMI_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_About.Click
        Try
            Dim form As New frm_about
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    '=================================================================
    '                   CONTEXT MENU ITEMS
    '=================================================================

    Private Sub CMS_TSMI_Calculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMS_TSMI_Calculator.Click
        Try
            System.Diagnostics.Process.Start("calc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
    End Sub

    Private Sub CMS_TSMI_NotePad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMS_TSMI_NotePad.Click
        Try
            System.Diagnostics.Process.Start("notepad")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Information")
        End Try
    End Sub

    Private Sub CMS_TSMI_SlopeCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMS_TSMI_SlopeCal.Click
        Try
            Dim form As New frm_slopeCal
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub CMS_TSMI_CumCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMS_TSMI_CumCal.Click
        Try
            Dim form As New frm_cumCal
            form.MdiParent = Me
            form.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Open Child")
        End Try
    End Sub

    Private Sub CMS_TSMI_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMS_TSMI_Exit.Click
        If MessageBox.Show("Do u want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    '=================================================================
    '                   USER DEFINED FUNCTIONS
    '=================================================================

    Public Sub dbExistCheck()
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\DataItems\KVKDhalai_Estimate.mdf") Then
            MsgBox("Software database not found. Please browse database file.", MsgBoxStyle.OkOnly, "Database information")
            OFD_db.ShowDialog()
            filename = My.Computer.FileSystem.GetName(OFD_db.FileName)
            If filename = "KVKDhalai_Estimate.mdf" Then
                Try
                    My.Computer.FileSystem.CopyFile(OFD_db.FileName, Application.StartupPath & "\DataItems\" & filename, True)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Database information")
                End Try
            Else
                Call dbExistCheck()
            End If
        End If
        Call failsafe()
    End Sub

    Public Sub failsafe()
        Try
            con_cls.disconnect()
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Estimate.mdf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Estimate_log.ldf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
        Catch ex As Exception
            MsgBox("Failsafe process (delete) unsuccessful", MsgBoxStyle.OkOnly, "Failsafe information")
        End Try
        Try
            con_cls.disconnect()
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\DataItems\KVKDhalai_Estimate.mdf", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Estimate.mdf", True)
            My.Computer.FileSystem.CopyFile(Application.StartupPath & "\DataItems\KVKDhalai_Estimate_log.ldf", My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Failsafe\KVKDhalai_Estimate_log.ldf", True)
        Catch ex As Exception
            MsgBox("Failsafe process unsuccessful", MsgBoxStyle.OkOnly, "Failsafe information")
        End Try
    End Sub

    Private Sub Timer_Home_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Home.Tick
        TSSL_Clock.Text = My.Computer.Clock.LocalTime.ToString
    End Sub

End Class