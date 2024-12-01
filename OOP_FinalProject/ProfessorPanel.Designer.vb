<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfessorPanel
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.admin_container = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.prof_currentdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_currenttime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_profname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_profilepic = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.stp_sidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.adming_professor = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.prof_sbmanagegrade = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_sblogout = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_sbdashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_managegrade = New Guna.UI2.WinForms.Guna2Panel()
        Me.admin_profdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_profUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_addnewprof = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_datatable = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.FormDrag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.FormBorderRad = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.DTBorderRad = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.prof_dashboard = New Guna.UI2.WinForms.Guna2Panel()
        Me.prof_sbsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_container.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.prof_profilepic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stp_sidebar.SuspendLayout()
        Me.adming_professor.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.prof_managegrade.SuspendLayout()
        CType(Me.prof_datatable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_container
        '
        Me.admin_container.AutoScroll = True
        Me.admin_container.BackColor = System.Drawing.Color.Transparent
        Me.admin_container.Controls.Add(Me.Guna2Panel2)
        Me.admin_container.Controls.Add(Me.stp_sidebar)
        Me.admin_container.Controls.Add(Me.prof_managegrade)
        Me.admin_container.Controls.Add(Me.prof_dashboard)
        Me.admin_container.FillColor = System.Drawing.Color.Black
        Me.admin_container.Location = New System.Drawing.Point(74, 52)
        Me.admin_container.Name = "admin_container"
        Me.admin_container.Radius = 10
        Me.admin_container.ShadowColor = System.Drawing.Color.Black
        Me.admin_container.ShadowDepth = 0
        Me.admin_container.ShadowShift = 0
        Me.admin_container.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.admin_container.Size = New System.Drawing.Size(1086, 706)
        Me.admin_container.TabIndex = 19
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.Controls.Add(Me.prof_currentdate)
        Me.Guna2Panel2.Controls.Add(Me.prof_currenttime)
        Me.Guna2Panel2.Controls.Add(Me.prof_profname)
        Me.Guna2Panel2.Controls.Add(Me.prof_profilepic)
        Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.CustomizableEdges.BottomRight = False
        Me.Guna2Panel2.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(55, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1031, 67)
        Me.Guna2Panel2.TabIndex = 1
        '
        'prof_currentdate
        '
        Me.prof_currentdate.BackColor = System.Drawing.Color.Transparent
        Me.prof_currentdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_currentdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.prof_currentdate.IsContextMenuEnabled = False
        Me.prof_currentdate.IsSelectionEnabled = False
        Me.prof_currentdate.Location = New System.Drawing.Point(757, 23)
        Me.prof_currentdate.Name = "prof_currentdate"
        Me.prof_currentdate.Size = New System.Drawing.Size(130, 21)
        Me.prof_currentdate.TabIndex = 75
        Me.prof_currentdate.TabStop = False
        Me.prof_currentdate.Text = "mm/dd/yyyy dddd"
        Me.prof_currentdate.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'prof_currenttime
        '
        Me.prof_currenttime.BackColor = System.Drawing.Color.Transparent
        Me.prof_currenttime.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_currenttime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.prof_currenttime.IsContextMenuEnabled = False
        Me.prof_currenttime.IsSelectionEnabled = False
        Me.prof_currenttime.Location = New System.Drawing.Point(907, 23)
        Me.prof_currenttime.Name = "prof_currenttime"
        Me.prof_currenttime.Size = New System.Drawing.Size(83, 21)
        Me.prof_currenttime.TabIndex = 74
        Me.prof_currenttime.TabStop = False
        Me.prof_currenttime.Text = "00:00:00 PM"
        Me.prof_currenttime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prof_profname
        '
        Me.prof_profname.AutoSize = False
        Me.prof_profname.BackColor = System.Drawing.Color.Transparent
        Me.prof_profname.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_profname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.prof_profname.IsContextMenuEnabled = False
        Me.prof_profname.IsSelectionEnabled = False
        Me.prof_profname.Location = New System.Drawing.Point(68, 23)
        Me.prof_profname.Name = "prof_profname"
        Me.prof_profname.Size = New System.Drawing.Size(196, 18)
        Me.prof_profname.TabIndex = 73
        Me.prof_profname.TabStop = False
        Me.prof_profname.Text = "Sample Name S. Name"
        Me.prof_profname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'prof_profilepic
        '
        Me.prof_profilepic.ImageRotate = 0!
        Me.prof_profilepic.Location = New System.Drawing.Point(22, 12)
        Me.prof_profilepic.Name = "prof_profilepic"
        Me.prof_profilepic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.prof_profilepic.Size = New System.Drawing.Size(40, 40)
        Me.prof_profilepic.TabIndex = 0
        Me.prof_profilepic.TabStop = False
        '
        'stp_sidebar
        '
        Me.stp_sidebar.BorderRadius = 15
        Me.stp_sidebar.Controls.Add(Me.prof_sbsettings)
        Me.stp_sidebar.Controls.Add(Me.adming_professor)
        Me.stp_sidebar.Controls.Add(Me.prof_sbmanagegrade)
        Me.stp_sidebar.Controls.Add(Me.prof_sblogout)
        Me.stp_sidebar.Controls.Add(Me.prof_sbdashboard)
        Me.stp_sidebar.CustomizableEdges.BottomRight = False
        Me.stp_sidebar.CustomizableEdges.TopRight = False
        Me.stp_sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.stp_sidebar.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.stp_sidebar.Location = New System.Drawing.Point(0, 0)
        Me.stp_sidebar.Name = "stp_sidebar"
        Me.stp_sidebar.Size = New System.Drawing.Size(55, 706)
        Me.stp_sidebar.TabIndex = 0
        '
        'adming_professor
        '
        Me.adming_professor.BackColor = System.Drawing.Color.Black
        Me.adming_professor.BorderRadius = 10
        Me.adming_professor.Controls.Add(Me.Guna2DataGridView1)
        Me.adming_professor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adming_professor.Location = New System.Drawing.Point(55, 67)
        Me.adming_professor.Name = "adming_professor"
        Me.adming_professor.Size = New System.Drawing.Size(931, 571)
        Me.adming_professor.TabIndex = 89
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(22, 24)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(885, 154)
        Me.Guna2DataGridView1.TabIndex = 88
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'prof_sbmanagegrade
        '
        Me.prof_sbmanagegrade.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.prof_sbmanagegrade.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.prof_sbmanagegrade.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.prof_sbmanagegrade.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.prof_sbmanagegrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.prof_sbmanagegrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.prof_sbmanagegrade.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_sbmanagegrade.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sbmanagegrade.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.prof_sbmanagegrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.prof_sbmanagegrade.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sbmanagegrade.Image = Global.OOP_FinalProject.My.Resources.Resources.GradeSubjectIconm
        Me.prof_sbmanagegrade.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.prof_sbmanagegrade.ImageOffset = New System.Drawing.Point(5, 0)
        Me.prof_sbmanagegrade.ImageSize = New System.Drawing.Size(27, 27)
        Me.prof_sbmanagegrade.Location = New System.Drawing.Point(0, 177)
        Me.prof_sbmanagegrade.Name = "prof_sbmanagegrade"
        Me.prof_sbmanagegrade.Size = New System.Drawing.Size(55, 45)
        Me.prof_sbmanagegrade.TabIndex = 7
        Me.prof_sbmanagegrade.TextOffset = New System.Drawing.Point(14, 0)
        Me.prof_sbmanagegrade.UseTransparentBackground = True
        '
        'prof_sblogout
        '
        Me.prof_sblogout.Animated = True
        Me.prof_sblogout.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.prof_sblogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.prof_sblogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.prof_sblogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.prof_sblogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.prof_sblogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_sblogout.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sblogout.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.prof_sblogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.prof_sblogout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sblogout.Image = Global.OOP_FinalProject.My.Resources.Resources.LoginOutIcon1
        Me.prof_sblogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.prof_sblogout.ImageOffset = New System.Drawing.Point(5, 0)
        Me.prof_sblogout.ImageSize = New System.Drawing.Size(27, 27)
        Me.prof_sblogout.Location = New System.Drawing.Point(0, 593)
        Me.prof_sblogout.Name = "prof_sblogout"
        Me.prof_sblogout.Size = New System.Drawing.Size(55, 45)
        Me.prof_sblogout.TabIndex = 6
        Me.prof_sblogout.TextOffset = New System.Drawing.Point(14, 0)
        Me.prof_sblogout.UseTransparentBackground = True
        '
        'prof_sbdashboard
        '
        Me.prof_sbdashboard.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.prof_sbdashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.prof_sbdashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.prof_sbdashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.prof_sbdashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.prof_sbdashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.prof_sbdashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_sbdashboard.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sbdashboard.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.prof_sbdashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.prof_sbdashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sbdashboard.Image = Global.OOP_FinalProject.My.Resources.Resources.Dashboard_LayoutIcon
        Me.prof_sbdashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.prof_sbdashboard.ImageOffset = New System.Drawing.Point(5, 0)
        Me.prof_sbdashboard.ImageSize = New System.Drawing.Size(27, 27)
        Me.prof_sbdashboard.Location = New System.Drawing.Point(0, 106)
        Me.prof_sbdashboard.Name = "prof_sbdashboard"
        Me.prof_sbdashboard.Size = New System.Drawing.Size(55, 45)
        Me.prof_sbdashboard.TabIndex = 4
        Me.prof_sbdashboard.UseTransparentBackground = True
        '
        'prof_managegrade
        '
        Me.prof_managegrade.BackColor = System.Drawing.Color.Black
        Me.prof_managegrade.BorderRadius = 10
        Me.prof_managegrade.Controls.Add(Me.admin_profdelete)
        Me.prof_managegrade.Controls.Add(Me.admin_profUpdate)
        Me.prof_managegrade.Controls.Add(Me.admin_addnewprof)
        Me.prof_managegrade.Controls.Add(Me.prof_datatable)
        Me.prof_managegrade.CustomizableEdges.BottomLeft = False
        Me.prof_managegrade.CustomizableEdges.TopLeft = False
        Me.prof_managegrade.CustomizableEdges.TopRight = False
        Me.prof_managegrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_managegrade.Location = New System.Drawing.Point(58, 68)
        Me.prof_managegrade.Name = "prof_managegrade"
        Me.prof_managegrade.Size = New System.Drawing.Size(1025, 635)
        Me.prof_managegrade.TabIndex = 83
        '
        'admin_profdelete
        '
        Me.admin_profdelete.Animated = True
        Me.admin_profdelete.AnimatedGIF = True
        Me.admin_profdelete.BackColor = System.Drawing.Color.Transparent
        Me.admin_profdelete.BorderRadius = 10
        Me.admin_profdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_profdelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_profdelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_profdelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_profdelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_profdelete.FillColor = System.Drawing.Color.DarkRed
        Me.admin_profdelete.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_profdelete.ForeColor = System.Drawing.Color.White
        Me.admin_profdelete.Image = Global.OOP_FinalProject.My.Resources.Resources.Delete
        Me.admin_profdelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_profdelete.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.admin_profdelete.ImageSize = New System.Drawing.Size(23, 23)
        Me.admin_profdelete.Location = New System.Drawing.Point(658, 150)
        Me.admin_profdelete.Name = "admin_profdelete"
        Me.admin_profdelete.Size = New System.Drawing.Size(112, 45)
        Me.admin_profdelete.TabIndex = 92
        Me.admin_profdelete.Text = "Delete"
        Me.admin_profdelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.admin_profdelete.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'admin_profUpdate
        '
        Me.admin_profUpdate.Animated = True
        Me.admin_profUpdate.AnimatedGIF = True
        Me.admin_profUpdate.BackColor = System.Drawing.Color.Transparent
        Me.admin_profUpdate.BorderRadius = 10
        Me.admin_profUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_profUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_profUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_profUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_profUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_profUpdate.FillColor = System.Drawing.Color.DarkGreen
        Me.admin_profUpdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_profUpdate.ForeColor = System.Drawing.Color.White
        Me.admin_profUpdate.Image = Global.OOP_FinalProject.My.Resources.Resources.update
        Me.admin_profUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_profUpdate.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.admin_profUpdate.ImageSize = New System.Drawing.Size(23, 23)
        Me.admin_profUpdate.Location = New System.Drawing.Point(658, 86)
        Me.admin_profUpdate.Name = "admin_profUpdate"
        Me.admin_profUpdate.Size = New System.Drawing.Size(112, 45)
        Me.admin_profUpdate.TabIndex = 91
        Me.admin_profUpdate.Text = "Update"
        Me.admin_profUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.admin_profUpdate.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'admin_addnewprof
        '
        Me.admin_addnewprof.Animated = True
        Me.admin_addnewprof.AnimatedGIF = True
        Me.admin_addnewprof.BackColor = System.Drawing.Color.Transparent
        Me.admin_addnewprof.BorderRadius = 10
        Me.admin_addnewprof.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_addnewprof.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_addnewprof.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_addnewprof.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_addnewprof.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_addnewprof.FillColor = System.Drawing.Color.Green
        Me.admin_addnewprof.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_addnewprof.ForeColor = System.Drawing.Color.White
        Me.admin_addnewprof.Image = Global.OOP_FinalProject.My.Resources.Resources.Plus
        Me.admin_addnewprof.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_addnewprof.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.admin_addnewprof.ImageSize = New System.Drawing.Size(25, 25)
        Me.admin_addnewprof.Location = New System.Drawing.Point(658, 23)
        Me.admin_addnewprof.Name = "admin_addnewprof"
        Me.admin_addnewprof.Size = New System.Drawing.Size(112, 45)
        Me.admin_addnewprof.TabIndex = 90
        Me.admin_addnewprof.Text = "Add New"
        Me.admin_addnewprof.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.admin_addnewprof.TextOffset = New System.Drawing.Point(0, -1)
        '
        'prof_datatable
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.prof_datatable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.prof_datatable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.prof_datatable.ColumnHeadersHeight = 4
        Me.prof_datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prof_datatable.DefaultCellStyle = DataGridViewCellStyle6
        Me.prof_datatable.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prof_datatable.Location = New System.Drawing.Point(19, 23)
        Me.prof_datatable.Name = "prof_datatable"
        Me.prof_datatable.RowHeadersVisible = False
        Me.prof_datatable.RowHeadersWidth = 51
        Me.prof_datatable.Size = New System.Drawing.Size(633, 589)
        Me.prof_datatable.TabIndex = 88
        Me.prof_datatable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.prof_datatable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.prof_datatable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.prof_datatable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.prof_datatable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.prof_datatable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.prof_datatable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prof_datatable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prof_datatable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.prof_datatable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_datatable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.prof_datatable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.prof_datatable.ThemeStyle.HeaderStyle.Height = 4
        Me.prof_datatable.ThemeStyle.ReadOnly = False
        Me.prof_datatable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.prof_datatable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.prof_datatable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_datatable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.prof_datatable.ThemeStyle.RowsStyle.Height = 22
        Me.prof_datatable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prof_datatable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'FormDrag
        '
        Me.FormDrag.DockIndicatorTransparencyValue = 0.6R
        Me.FormDrag.TargetControl = Me
        Me.FormDrag.UseTransparentDrag = True
        '
        'FormBorderRad
        '
        Me.FormBorderRad.BorderRadius = 15
        Me.FormBorderRad.TargetControl = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderRadius = 7
        Me.Guna2ControlBox1.CustomizableEdges.BottomLeft = False
        Me.Guna2ControlBox1.CustomizableEdges.BottomRight = False
        Me.Guna2ControlBox1.CustomizableEdges.TopLeft = False
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1188, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 20
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.BorderRadius = 7
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.CustomizableEdges.BottomLeft = False
        Me.Guna2ControlBox2.CustomizableEdges.BottomRight = False
        Me.Guna2ControlBox2.CustomizableEdges.TopLeft = False
        Me.Guna2ControlBox2.CustomizableEdges.TopRight = False
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1144, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 21
        Me.Guna2ControlBox2.UseTransparentBackground = True
        '
        'DTBorderRad
        '
        Me.DTBorderRad.BorderRadius = 20
        Me.DTBorderRad.TargetControl = Me.prof_datatable
        '
        'prof_dashboard
        '
        Me.prof_dashboard.BackColor = System.Drawing.Color.Black
        Me.prof_dashboard.BorderRadius = 10
        Me.prof_dashboard.CustomizableEdges.BottomLeft = False
        Me.prof_dashboard.CustomizableEdges.TopLeft = False
        Me.prof_dashboard.CustomizableEdges.TopRight = False
        Me.prof_dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_dashboard.Location = New System.Drawing.Point(57, 68)
        Me.prof_dashboard.Name = "prof_dashboard"
        Me.prof_dashboard.Size = New System.Drawing.Size(1025, 635)
        Me.prof_dashboard.TabIndex = 93
        '
        'prof_sbsettings
        '
        Me.prof_sbsettings.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.prof_sbsettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.prof_sbsettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.prof_sbsettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.prof_sbsettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.prof_sbsettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.prof_sbsettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_sbsettings.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sbsettings.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.prof_sbsettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.prof_sbsettings.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.prof_sbsettings.Image = Global.OOP_FinalProject.My.Resources.Resources.SeettingsIcon
        Me.prof_sbsettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.prof_sbsettings.ImageOffset = New System.Drawing.Point(5, 0)
        Me.prof_sbsettings.ImageSize = New System.Drawing.Size(27, 27)
        Me.prof_sbsettings.Location = New System.Drawing.Point(0, 532)
        Me.prof_sbsettings.Name = "prof_sbsettings"
        Me.prof_sbsettings.Size = New System.Drawing.Size(55, 45)
        Me.prof_sbsettings.TabIndex = 90
        Me.prof_sbsettings.TextOffset = New System.Drawing.Point(14, 0)
        Me.prof_sbsettings.UseTransparentBackground = True
        '
        'ProfessorPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OOP_FinalProject.My.Resources.Resources.Paman
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1234, 811)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.admin_container)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProfessorPanel"
        Me.Text = "ProfessorPanel"
        Me.admin_container.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.prof_profilepic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stp_sidebar.ResumeLayout(False)
        Me.adming_professor.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.prof_managegrade.ResumeLayout(False)
        CType(Me.prof_datatable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents admin_container As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents prof_currentdate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_currenttime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_profname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_profilepic As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents stp_sidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents adming_professor As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents prof_sbmanagegrade As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_sblogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_sbdashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_managegrade As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents admin_profdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_profUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_addnewprof As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_datatable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents FormDrag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents FormBorderRad As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents timer As Timer
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DTBorderRad As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents prof_dashboard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents prof_sbsettings As Guna.UI2.WinForms.Guna2Button
End Class
