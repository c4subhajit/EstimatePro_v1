<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Estimate_home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Estimate_home))
        Me.MS_Main_New = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main_New_Pond = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main_View = New System.Windows.Forms.ToolStripMenuItem
        Me.RateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main_System = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main_System_Utilities = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main_System_Utilities_Calculator = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main_System_Utilities_Notepad = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main_System_About = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Home = New System.Windows.Forms.MenuStrip
        Me.TSMI_New = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_Reservoir = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_Pond = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_View = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_Rate = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMI_About = New System.Windows.Forms.ToolStripMenuItem
        Me.OFD_db = New System.Windows.Forms.OpenFileDialog
        Me.SS_Home = New System.Windows.Forms.StatusStrip
        Me.TSSL_Clock = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer_Home = New System.Windows.Forms.Timer(Me.components)
        Me.CMS_Home = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMS_TSMI_Calculator = New System.Windows.Forms.ToolStripMenuItem
        Me.CMS_TSMI_NotePad = New System.Windows.Forms.ToolStripMenuItem
        Me.CMS_TSMI_SlopeCal = New System.Windows.Forms.ToolStripMenuItem
        Me.CMS_TSMI_CumCal = New System.Windows.Forms.ToolStripMenuItem
        Me.CMS_TSMI_Exit = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Home.SuspendLayout()
        Me.SS_Home.SuspendLayout()
        Me.CMS_Home.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS_Main_New
        '
        Me.MS_Main_New.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_Main_New_Pond})
        Me.MS_Main_New.Name = "MS_Main_New"
        Me.MS_Main_New.Size = New System.Drawing.Size(43, 20)
        Me.MS_Main_New.Text = "&New"
        '
        'MS_Main_New_Pond
        '
        Me.MS_Main_New_Pond.Name = "MS_Main_New_Pond"
        Me.MS_Main_New_Pond.Size = New System.Drawing.Size(102, 22)
        Me.MS_Main_New_Pond.Text = "&Pond"
        '
        'MS_Main_View
        '
        Me.MS_Main_View.Name = "MS_Main_View"
        Me.MS_Main_View.Size = New System.Drawing.Size(44, 20)
        Me.MS_Main_View.Text = "&View"
        '
        'RateToolStripMenuItem
        '
        Me.RateToolStripMenuItem.Name = "RateToolStripMenuItem"
        Me.RateToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.RateToolStripMenuItem.Text = "&Rate"
        '
        'MS_Main_System
        '
        Me.MS_Main_System.Name = "MS_Main_System"
        Me.MS_Main_System.Size = New System.Drawing.Size(57, 20)
        Me.MS_Main_System.Text = "&System"
        '
        'MS_Main_System_Utilities
        '
        Me.MS_Main_System_Utilities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MS_Main_System_Utilities_Calculator, Me.MS_Main_System_Utilities_Notepad})
        Me.MS_Main_System_Utilities.Name = "MS_Main_System_Utilities"
        Me.MS_Main_System_Utilities.Size = New System.Drawing.Size(152, 22)
        Me.MS_Main_System_Utilities.Text = "&Utilities"
        '
        'MS_Main_System_Utilities_Calculator
        '
        Me.MS_Main_System_Utilities_Calculator.Name = "MS_Main_System_Utilities_Calculator"
        Me.MS_Main_System_Utilities_Calculator.Size = New System.Drawing.Size(128, 22)
        Me.MS_Main_System_Utilities_Calculator.Text = "&Calculator"
        '
        'MS_Main_System_Utilities_Notepad
        '
        Me.MS_Main_System_Utilities_Notepad.Name = "MS_Main_System_Utilities_Notepad"
        Me.MS_Main_System_Utilities_Notepad.Size = New System.Drawing.Size(128, 22)
        Me.MS_Main_System_Utilities_Notepad.Text = "&Notepad"
        '
        'MS_Main_System_About
        '
        Me.MS_Main_System_About.Name = "MS_Main_System_About"
        Me.MS_Main_System_About.Size = New System.Drawing.Size(152, 22)
        Me.MS_Main_System_About.Text = "&About"
        '
        'MS_Home
        '
        Me.MS_Home.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_New, Me.TSMI_View, Me.TSMI_Rate, Me.TSMI_About})
        Me.MS_Home.Location = New System.Drawing.Point(0, 0)
        Me.MS_Home.Name = "MS_Home"
        Me.MS_Home.Size = New System.Drawing.Size(984, 24)
        Me.MS_Home.TabIndex = 4
        Me.MS_Home.Text = "MenuStrip1"
        '
        'TSMI_New
        '
        Me.TSMI_New.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Reservoir, Me.TSMI_Pond})
        Me.TSMI_New.Name = "TSMI_New"
        Me.TSMI_New.Size = New System.Drawing.Size(43, 20)
        Me.TSMI_New.Text = "&New"
        '
        'TSMI_Reservoir
        '
        Me.TSMI_Reservoir.Name = "TSMI_Reservoir"
        Me.TSMI_Reservoir.Size = New System.Drawing.Size(122, 22)
        Me.TSMI_Reservoir.Text = "&Reservoir"
        '
        'TSMI_Pond
        '
        Me.TSMI_Pond.Name = "TSMI_Pond"
        Me.TSMI_Pond.Size = New System.Drawing.Size(122, 22)
        Me.TSMI_Pond.Text = "&Pond"
        '
        'TSMI_View
        '
        Me.TSMI_View.Name = "TSMI_View"
        Me.TSMI_View.Size = New System.Drawing.Size(44, 20)
        Me.TSMI_View.Text = "&View"
        '
        'TSMI_Rate
        '
        Me.TSMI_Rate.Name = "TSMI_Rate"
        Me.TSMI_Rate.Size = New System.Drawing.Size(42, 20)
        Me.TSMI_Rate.Text = "&Rate"
        '
        'TSMI_About
        '
        Me.TSMI_About.Name = "TSMI_About"
        Me.TSMI_About.Size = New System.Drawing.Size(52, 20)
        Me.TSMI_About.Text = "&About"
        '
        'OFD_db
        '
        Me.OFD_db.FileName = "KVKDhalai_Estimate.mdf"
        '
        'SS_Home
        '
        Me.SS_Home.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_Clock, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.SS_Home.Location = New System.Drawing.Point(0, 640)
        Me.SS_Home.Name = "SS_Home"
        Me.SS_Home.Size = New System.Drawing.Size(984, 22)
        Me.SS_Home.TabIndex = 6
        Me.SS_Home.Text = "StatusStrip1"
        '
        'TSSL_Clock
        '
        Me.TSSL_Clock.AutoSize = False
        Me.TSSL_Clock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_Clock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TSSL_Clock.Name = "TSSL_Clock"
        Me.TSSL_Clock.Size = New System.Drawing.Size(150, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(166, 17)
        Me.ToolStripStatusLabel1.Text = "Alt+V=View previous estimate"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(68, 17)
        Me.ToolStripStatusLabel2.Text = "Alt+R=Rate"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(79, 17)
        Me.ToolStripStatusLabel3.Text = "Alt+A=About"
        '
        'Timer_Home
        '
        Me.Timer_Home.Enabled = True
        '
        'CMS_Home
        '
        Me.CMS_Home.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_TSMI_Calculator, Me.CMS_TSMI_NotePad, Me.CMS_TSMI_SlopeCal, Me.CMS_TSMI_CumCal, Me.CMS_TSMI_Exit})
        Me.CMS_Home.Name = "CMS_Home"
        Me.CMS_Home.Size = New System.Drawing.Size(186, 114)
        '
        'CMS_TSMI_Calculator
        '
        Me.CMS_TSMI_Calculator.Name = "CMS_TSMI_Calculator"
        Me.CMS_TSMI_Calculator.Size = New System.Drawing.Size(185, 22)
        Me.CMS_TSMI_Calculator.Text = "&Calcutator"
        '
        'CMS_TSMI_NotePad
        '
        Me.CMS_TSMI_NotePad.Name = "CMS_TSMI_NotePad"
        Me.CMS_TSMI_NotePad.Size = New System.Drawing.Size(185, 22)
        Me.CMS_TSMI_NotePad.Text = "&Notepad"
        '
        'CMS_TSMI_SlopeCal
        '
        Me.CMS_TSMI_SlopeCal.Name = "CMS_TSMI_SlopeCal"
        Me.CMS_TSMI_SlopeCal.Size = New System.Drawing.Size(185, 22)
        Me.CMS_TSMI_SlopeCal.Text = "&Slope calculator"
        '
        'CMS_TSMI_CumCal
        '
        Me.CMS_TSMI_CumCal.Name = "CMS_TSMI_CumCal"
        Me.CMS_TSMI_CumCal.Size = New System.Drawing.Size(185, 22)
        Me.CMS_TSMI_CumCal.Text = "&Earth work calculator"
        '
        'CMS_TSMI_Exit
        '
        Me.CMS_TSMI_Exit.Name = "CMS_TSMI_Exit"
        Me.CMS_TSMI_Exit.Size = New System.Drawing.Size(185, 22)
        Me.CMS_TSMI_Exit.Text = "&Exit"
        '
        'frm_Estimate_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EstimatePro_v2.My.Resources.Resources.Logo_KVK
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.ContextMenuStrip = Me.CMS_Home
        Me.Controls.Add(Me.SS_Home)
        Me.Controls.Add(Me.MS_Home)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MS_Home
        Me.MinimumSize = New System.Drawing.Size(1000, 700)
        Me.Name = "frm_Estimate_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estimate Pro v2.0"
        Me.MS_Home.ResumeLayout(False)
        Me.MS_Home.PerformLayout()
        Me.SS_Home.ResumeLayout(False)
        Me.SS_Home.PerformLayout()
        Me.CMS_Home.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MS_Main_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Main_New_Pond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Main_View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Main_System As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Main_System_Utilities As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Main_System_Utilities_Calculator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Main_System_Utilities_Notepad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Main_System_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_Home As System.Windows.Forms.MenuStrip
    Friend WithEvents TSMI_New As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_Pond As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_View As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_Rate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OFD_db As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SS_Home As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer_Home As System.Windows.Forms.Timer
    Public WithEvents TSSL_Clock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSMI_Reservoir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMS_Home As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CMS_TSMI_Calculator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMS_TSMI_NotePad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMS_TSMI_SlopeCal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMS_TSMI_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMS_TSMI_CumCal As System.Windows.Forms.ToolStripMenuItem
End Class
