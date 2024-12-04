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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfessorPanel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.admin_container = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.prof_currentdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_currenttime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_profname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_profilepic = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.stp_sidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.prof_sbsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.adming_professor = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.prof_sbmanagegrade = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_sblogout = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_sbdashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_managegrade = New Guna.UI2.WinForms.Guna2Panel()
        Me.prof_datatable = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_sectiondrop = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.prof_departmentdrop = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.prof_deleteentry = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_updateinfo = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_addnewstudent = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_dashboard = New Guna.UI2.WinForms.Guna2Panel()
        Me.FormDrag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.FormBorderRad = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.DTBorderRad = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
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
        Me.prof_sbsettings.Image = CType(resources.GetObject("prof_sbsettings.Image"), System.Drawing.Image)
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
        Me.Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 50
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
        Me.Guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowHeadersWidth = 51
        Me.Guna2DataGridView1.RowTemplate.Height = 35
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
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35
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
        Me.prof_sbmanagegrade.Image = CType(resources.GetObject("prof_sbmanagegrade.Image"), System.Drawing.Image)
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
        Me.prof_sblogout.Image = CType(resources.GetObject("prof_sblogout.Image"), System.Drawing.Image)
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
        Me.prof_sbdashboard.Image = CType(resources.GetObject("prof_sbdashboard.Image"), System.Drawing.Image)
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
        Me.prof_managegrade.Controls.Add(Me.prof_datatable)
        Me.prof_managegrade.Controls.Add(Me.Guna2HtmlLabel1)
        Me.prof_managegrade.Controls.Add(Me.Guna2HtmlLabel5)
        Me.prof_managegrade.Controls.Add(Me.prof_sectiondrop)
        Me.prof_managegrade.Controls.Add(Me.prof_departmentdrop)
        Me.prof_managegrade.Controls.Add(Me.prof_deleteentry)
        Me.prof_managegrade.Controls.Add(Me.prof_updateinfo)
        Me.prof_managegrade.Controls.Add(Me.prof_addnewstudent)
        Me.prof_managegrade.CustomizableEdges.BottomLeft = False
        Me.prof_managegrade.CustomizableEdges.TopLeft = False
        Me.prof_managegrade.CustomizableEdges.TopRight = False
        Me.prof_managegrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_managegrade.Location = New System.Drawing.Point(58, 68)
        Me.prof_managegrade.Name = "prof_managegrade"
        Me.prof_managegrade.Size = New System.Drawing.Size(1025, 635)
        Me.prof_managegrade.TabIndex = 83
        '
        'prof_datatable
        '
        Me.prof_datatable.AllowUserToAddRows = False
        Me.prof_datatable.AllowUserToDeleteRows = False
        Me.prof_datatable.AllowUserToResizeColumns = False
        Me.prof_datatable.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.prof_datatable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.prof_datatable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.prof_datatable.ColumnHeadersHeight = 50
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prof_datatable.DefaultCellStyle = DataGridViewCellStyle7
        Me.prof_datatable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.prof_datatable.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prof_datatable.Location = New System.Drawing.Point(102, 87)
        Me.prof_datatable.Name = "prof_datatable"
        Me.prof_datatable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.prof_datatable.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.prof_datatable.RowHeadersVisible = False
        Me.prof_datatable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.prof_datatable.RowTemplate.Height = 35
        Me.prof_datatable.Size = New System.Drawing.Size(838, 288)
        Me.prof_datatable.TabIndex = 110
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
        Me.prof_datatable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.prof_datatable.ThemeStyle.HeaderStyle.Height = 50
        Me.prof_datatable.ThemeStyle.ReadOnly = False
        Me.prof_datatable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.prof_datatable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.prof_datatable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_datatable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.prof_datatable.ThemeStyle.RowsStyle.Height = 35
        Me.prof_datatable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.prof_datatable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel1.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(565, 46)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(70, 23)
        Me.Guna2HtmlLabel1.TabIndex = 109
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Section : "
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel5.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel5.IsSelectionEnabled = False
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(102, 46)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(105, 23)
        Me.Guna2HtmlLabel5.TabIndex = 108
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Department :"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prof_sectiondrop
        '
        Me.prof_sectiondrop.BackColor = System.Drawing.Color.Transparent
        Me.prof_sectiondrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.prof_sectiondrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prof_sectiondrop.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_sectiondrop.FocusedColor = System.Drawing.Color.Black
        Me.prof_sectiondrop.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_sectiondrop.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold)
        Me.prof_sectiondrop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_sectiondrop.ItemHeight = 25
        Me.prof_sectiondrop.Items.AddRange(New Object() {"CCS", "EDUC", "NURSING"})
        Me.prof_sectiondrop.Location = New System.Drawing.Point(641, 38)
        Me.prof_sectiondrop.Name = "prof_sectiondrop"
        Me.prof_sectiondrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.prof_sectiondrop.Size = New System.Drawing.Size(166, 31)
        Me.prof_sectiondrop.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_sectiondrop.TabIndex = 107
        Me.prof_sectiondrop.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'prof_departmentdrop
        '
        Me.prof_departmentdrop.BackColor = System.Drawing.Color.Transparent
        Me.prof_departmentdrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.prof_departmentdrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.prof_departmentdrop.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_departmentdrop.FocusedColor = System.Drawing.Color.Black
        Me.prof_departmentdrop.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_departmentdrop.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold)
        Me.prof_departmentdrop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_departmentdrop.ItemHeight = 25
        Me.prof_departmentdrop.Items.AddRange(New Object() {"CCS", "EDUC", "NURSING"})
        Me.prof_departmentdrop.Location = New System.Drawing.Point(213, 38)
        Me.prof_departmentdrop.Name = "prof_departmentdrop"
        Me.prof_departmentdrop.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.prof_departmentdrop.Size = New System.Drawing.Size(305, 31)
        Me.prof_departmentdrop.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_departmentdrop.TabIndex = 106
        Me.prof_departmentdrop.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'prof_deleteentry
        '
        Me.prof_deleteentry.Animated = True
        Me.prof_deleteentry.AnimatedGIF = True
        Me.prof_deleteentry.BackColor = System.Drawing.Color.Transparent
        Me.prof_deleteentry.BorderRadius = 10
        Me.prof_deleteentry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prof_deleteentry.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.prof_deleteentry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.prof_deleteentry.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.prof_deleteentry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.prof_deleteentry.FillColor = System.Drawing.Color.DarkRed
        Me.prof_deleteentry.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_deleteentry.ForeColor = System.Drawing.Color.White
        Me.prof_deleteentry.Image = CType(resources.GetObject("prof_deleteentry.Image"), System.Drawing.Image)
        Me.prof_deleteentry.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.prof_deleteentry.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.prof_deleteentry.ImageSize = New System.Drawing.Size(23, 23)
        Me.prof_deleteentry.Location = New System.Drawing.Point(378, 401)
        Me.prof_deleteentry.Name = "prof_deleteentry"
        Me.prof_deleteentry.Size = New System.Drawing.Size(112, 45)
        Me.prof_deleteentry.TabIndex = 92
        Me.prof_deleteentry.Text = "Delete"
        Me.prof_deleteentry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.prof_deleteentry.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'prof_updateinfo
        '
        Me.prof_updateinfo.Animated = True
        Me.prof_updateinfo.AnimatedGIF = True
        Me.prof_updateinfo.BackColor = System.Drawing.Color.Transparent
        Me.prof_updateinfo.BorderRadius = 10
        Me.prof_updateinfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prof_updateinfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.prof_updateinfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.prof_updateinfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.prof_updateinfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.prof_updateinfo.FillColor = System.Drawing.Color.DarkGreen
        Me.prof_updateinfo.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_updateinfo.ForeColor = System.Drawing.Color.White
        Me.prof_updateinfo.Image = CType(resources.GetObject("prof_updateinfo.Image"), System.Drawing.Image)
        Me.prof_updateinfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.prof_updateinfo.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.prof_updateinfo.ImageSize = New System.Drawing.Size(23, 23)
        Me.prof_updateinfo.Location = New System.Drawing.Point(238, 401)
        Me.prof_updateinfo.Name = "prof_updateinfo"
        Me.prof_updateinfo.Size = New System.Drawing.Size(112, 45)
        Me.prof_updateinfo.TabIndex = 91
        Me.prof_updateinfo.Text = "Update"
        Me.prof_updateinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.prof_updateinfo.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'prof_addnewstudent
        '
        Me.prof_addnewstudent.Animated = True
        Me.prof_addnewstudent.AnimatedGIF = True
        Me.prof_addnewstudent.BackColor = System.Drawing.Color.Transparent
        Me.prof_addnewstudent.BorderRadius = 10
        Me.prof_addnewstudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prof_addnewstudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.prof_addnewstudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.prof_addnewstudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.prof_addnewstudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.prof_addnewstudent.FillColor = System.Drawing.Color.Green
        Me.prof_addnewstudent.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_addnewstudent.ForeColor = System.Drawing.Color.White
        Me.prof_addnewstudent.Image = CType(resources.GetObject("prof_addnewstudent.Image"), System.Drawing.Image)
        Me.prof_addnewstudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.prof_addnewstudent.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.prof_addnewstudent.ImageSize = New System.Drawing.Size(25, 25)
        Me.prof_addnewstudent.Location = New System.Drawing.Point(102, 401)
        Me.prof_addnewstudent.Name = "prof_addnewstudent"
        Me.prof_addnewstudent.Size = New System.Drawing.Size(112, 45)
        Me.prof_addnewstudent.TabIndex = 90
        Me.prof_addnewstudent.Text = "Add New"
        Me.prof_addnewstudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.prof_addnewstudent.TextOffset = New System.Drawing.Point(0, -1)
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
        'FormDrag
        '
        Me.FormDrag.DockIndicatorTransparencyValue = 0.6R
        Me.FormDrag.TargetControl = Me
        Me.FormDrag.UseTransparentDrag = True
        '
        'FormBorderRad
        '
        Me.FormBorderRad.BorderRadius = 15
        Me.FormBorderRad.TargetControl = Me.prof_datatable
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
        '
        'ProfessorPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
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
        Me.prof_managegrade.PerformLayout()
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
    Friend WithEvents prof_deleteentry As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_updateinfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_addnewstudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FormDrag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents FormBorderRad As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents timer As Timer
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents DTBorderRad As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents prof_dashboard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents prof_sbsettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_sectiondrop As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents prof_departmentdrop As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_datatable As Guna.UI2.WinForms.Guna2DataGridView
End Class
