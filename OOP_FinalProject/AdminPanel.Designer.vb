<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FormDrag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.FormBorderRad = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.admin_container = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.stp_currentdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.stp_clocktimer = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.stp_sidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.admin_sbdepartment = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_sbfaculty = New Guna.UI2.WinForms.Guna2Button()
        Me.adming_professor = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.admin_sbprofessor = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_sbstudent = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_faculty = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_ = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.stp_datatable = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DTBorderRad = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.admin_container.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stp_sidebar.SuspendLayout()
        Me.adming_professor.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.admin_faculty.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.stp_datatable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1038, -1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 10
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(994, -1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 11
        Me.Guna2ControlBox2.UseTransparentBackground = True
        '
        'admin_container
        '
        Me.admin_container.AutoScroll = True
        Me.admin_container.BackColor = System.Drawing.Color.Transparent
        Me.admin_container.Controls.Add(Me.Guna2Panel2)
        Me.admin_container.Controls.Add(Me.stp_sidebar)
        Me.admin_container.Controls.Add(Me.admin_faculty)
        Me.admin_container.FillColor = System.Drawing.Color.Black
        Me.admin_container.Location = New System.Drawing.Point(43, 45)
        Me.admin_container.Name = "admin_container"
        Me.admin_container.Radius = 10
        Me.admin_container.ShadowColor = System.Drawing.Color.Black
        Me.admin_container.ShadowDepth = 0
        Me.admin_container.ShadowShift = 0
        Me.admin_container.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.admin_container.Size = New System.Drawing.Size(999, 651)
        Me.admin_container.TabIndex = 18
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.Controls.Add(Me.stp_currentdate)
        Me.Guna2Panel2.Controls.Add(Me.stp_clocktimer)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel2.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.CustomizableEdges.BottomRight = False
        Me.Guna2Panel2.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(55, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(944, 67)
        Me.Guna2Panel2.TabIndex = 1
        '
        'stp_currentdate
        '
        Me.stp_currentdate.AutoSize = False
        Me.stp_currentdate.BackColor = System.Drawing.Color.Transparent
        Me.stp_currentdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stp_currentdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.stp_currentdate.IsContextMenuEnabled = False
        Me.stp_currentdate.IsSelectionEnabled = False
        Me.stp_currentdate.Location = New System.Drawing.Point(610, 23)
        Me.stp_currentdate.Name = "stp_currentdate"
        Me.stp_currentdate.Size = New System.Drawing.Size(194, 18)
        Me.stp_currentdate.TabIndex = 75
        Me.stp_currentdate.TabStop = False
        Me.stp_currentdate.Text = "mm/dd/yyyy dddd"
        Me.stp_currentdate.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'stp_clocktimer
        '
        Me.stp_clocktimer.AutoSize = False
        Me.stp_clocktimer.BackColor = System.Drawing.Color.Transparent
        Me.stp_clocktimer.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stp_clocktimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.stp_clocktimer.IsContextMenuEnabled = False
        Me.stp_clocktimer.IsSelectionEnabled = False
        Me.stp_clocktimer.Location = New System.Drawing.Point(806, 23)
        Me.stp_clocktimer.Name = "stp_clocktimer"
        Me.stp_clocktimer.Size = New System.Drawing.Size(101, 18)
        Me.stp_clocktimer.TabIndex = 74
        Me.stp_clocktimer.TabStop = False
        Me.stp_clocktimer.Text = "00:00:00 PM"
        Me.stp_clocktimer.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2HtmlLabel2.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(68, 23)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(196, 18)
        Me.Guna2HtmlLabel2.TabIndex = 73
        Me.Guna2HtmlLabel2.TabStop = False
        Me.Guna2HtmlLabel2.Text = "Sample Name S. Name"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'stp_sidebar
        '
        Me.stp_sidebar.BorderRadius = 15
        Me.stp_sidebar.Controls.Add(Me.admin_sbdepartment)
        Me.stp_sidebar.Controls.Add(Me.admin_sbfaculty)
        Me.stp_sidebar.Controls.Add(Me.adming_professor)
        Me.stp_sidebar.Controls.Add(Me.admin_sbprofessor)
        Me.stp_sidebar.Controls.Add(Me.Guna2Button2)
        Me.stp_sidebar.Controls.Add(Me.admin_sbstudent)
        Me.stp_sidebar.Controls.Add(Me.Guna2Button3)
        Me.stp_sidebar.CustomizableEdges.BottomRight = False
        Me.stp_sidebar.CustomizableEdges.TopRight = False
        Me.stp_sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.stp_sidebar.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.stp_sidebar.Location = New System.Drawing.Point(0, 0)
        Me.stp_sidebar.Name = "stp_sidebar"
        Me.stp_sidebar.Size = New System.Drawing.Size(55, 651)
        Me.stp_sidebar.TabIndex = 0
        '
        'admin_sbdepartment
        '
        Me.admin_sbdepartment.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.admin_sbdepartment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.admin_sbdepartment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbdepartment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbdepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_sbdepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_sbdepartment.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_sbdepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbdepartment.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.admin_sbdepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.admin_sbdepartment.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbdepartment.Image = Global.OOP_FinalProject.My.Resources.Resources.faculty
        Me.admin_sbdepartment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_sbdepartment.ImageOffset = New System.Drawing.Point(5, 0)
        Me.admin_sbdepartment.ImageSize = New System.Drawing.Size(27, 27)
        Me.admin_sbdepartment.Location = New System.Drawing.Point(0, 354)
        Me.admin_sbdepartment.Name = "admin_sbdepartment"
        Me.admin_sbdepartment.Size = New System.Drawing.Size(55, 45)
        Me.admin_sbdepartment.TabIndex = 91
        Me.admin_sbdepartment.TextOffset = New System.Drawing.Point(14, 0)
        Me.admin_sbdepartment.UseTransparentBackground = True
        '
        'admin_sbfaculty
        '
        Me.admin_sbfaculty.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.admin_sbfaculty.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.admin_sbfaculty.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbfaculty.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbfaculty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_sbfaculty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_sbfaculty.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_sbfaculty.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbfaculty.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.admin_sbfaculty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.admin_sbfaculty.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbfaculty.Image = Global.OOP_FinalProject.My.Resources.Resources.Department
        Me.admin_sbfaculty.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_sbfaculty.ImageOffset = New System.Drawing.Point(5, 0)
        Me.admin_sbfaculty.ImageSize = New System.Drawing.Size(27, 27)
        Me.admin_sbfaculty.Location = New System.Drawing.Point(0, 305)
        Me.admin_sbfaculty.Name = "admin_sbfaculty"
        Me.admin_sbfaculty.Size = New System.Drawing.Size(55, 45)
        Me.admin_sbfaculty.TabIndex = 90
        Me.admin_sbfaculty.TextOffset = New System.Drawing.Point(14, 0)
        Me.admin_sbfaculty.UseTransparentBackground = True
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
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle28
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.Guna2DataGridView1.ColumnHeadersHeight = 4
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle30
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(22, 24)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
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
        'admin_sbprofessor
        '
        Me.admin_sbprofessor.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.admin_sbprofessor.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.admin_sbprofessor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbprofessor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbprofessor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_sbprofessor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_sbprofessor.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_sbprofessor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbprofessor.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.admin_sbprofessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.admin_sbprofessor.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbprofessor.Image = Global.OOP_FinalProject.My.Resources.Resources.Teacher
        Me.admin_sbprofessor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_sbprofessor.ImageOffset = New System.Drawing.Point(5, 0)
        Me.admin_sbprofessor.ImageSize = New System.Drawing.Size(27, 27)
        Me.admin_sbprofessor.Location = New System.Drawing.Point(0, 225)
        Me.admin_sbprofessor.Name = "admin_sbprofessor"
        Me.admin_sbprofessor.Size = New System.Drawing.Size(55, 45)
        Me.admin_sbprofessor.TabIndex = 7
        Me.admin_sbprofessor.TextOffset = New System.Drawing.Point(14, 0)
        Me.admin_sbprofessor.UseTransparentBackground = True
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Button2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2Button2.Image = Global.OOP_FinalProject.My.Resources.Resources.LoginOutIcon1
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.ImageOffset = New System.Drawing.Point(5, 0)
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(27, 27)
        Me.Guna2Button2.Location = New System.Drawing.Point(0, 593)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(55, 45)
        Me.Guna2Button2.TabIndex = 6
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(14, 0)
        Me.Guna2Button2.UseTransparentBackground = True
        '
        'admin_sbstudent
        '
        Me.admin_sbstudent.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.admin_sbstudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.admin_sbstudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbstudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_sbstudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_sbstudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_sbstudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_sbstudent.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbstudent.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.admin_sbstudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.admin_sbstudent.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.admin_sbstudent.Image = Global.OOP_FinalProject.My.Resources.Resources.Edu
        Me.admin_sbstudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_sbstudent.ImageOffset = New System.Drawing.Point(5, 0)
        Me.admin_sbstudent.ImageSize = New System.Drawing.Size(27, 27)
        Me.admin_sbstudent.Location = New System.Drawing.Point(0, 176)
        Me.admin_sbstudent.Name = "admin_sbstudent"
        Me.admin_sbstudent.Size = New System.Drawing.Size(55, 45)
        Me.admin_sbstudent.TabIndex = 5
        Me.admin_sbstudent.TextOffset = New System.Drawing.Point(14, 0)
        Me.admin_sbstudent.UseTransparentBackground = True
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2Button3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.5!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Guna2Button3.Image = Global.OOP_FinalProject.My.Resources.Resources.Dashboard_LayoutIcon
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.ImageOffset = New System.Drawing.Point(5, 0)
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(27, 27)
        Me.Guna2Button3.Location = New System.Drawing.Point(0, 106)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(55, 45)
        Me.Guna2Button3.TabIndex = 4
        Me.Guna2Button3.UseTransparentBackground = True
        '
        'admin_faculty
        '
        Me.admin_faculty.BackColor = System.Drawing.Color.Black
        Me.admin_faculty.BorderRadius = 10
        Me.admin_faculty.Controls.Add(Me.Guna2Button4)
        Me.admin_faculty.Controls.Add(Me.Guna2Button1)
        Me.admin_faculty.Controls.Add(Me.admin_)
        Me.admin_faculty.Controls.Add(Me.Guna2ShadowPanel1)
        Me.admin_faculty.Controls.Add(Me.stp_datatable)
        Me.admin_faculty.CustomizableEdges.BottomLeft = False
        Me.admin_faculty.CustomizableEdges.TopLeft = False
        Me.admin_faculty.CustomizableEdges.TopRight = False
        Me.admin_faculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_faculty.Location = New System.Drawing.Point(58, 68)
        Me.admin_faculty.Name = "admin_faculty"
        Me.admin_faculty.Size = New System.Drawing.Size(938, 580)
        Me.admin_faculty.TabIndex = 83
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AnimatedGIF = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = Global.OOP_FinalProject.My.Resources.Resources.Delete
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.Guna2Button4.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Button4.Location = New System.Drawing.Point(779, 509)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(112, 45)
        Me.Guna2Button4.TabIndex = 92
        Me.Guna2Button4.Text = "Delete"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkGreen
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.OOP_FinalProject.My.Resources.Resources.update
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(23, 23)
        Me.Guna2Button1.Location = New System.Drawing.Point(651, 509)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(112, 45)
        Me.Guna2Button1.TabIndex = 91
        Me.Guna2Button1.Text = "Update"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'admin_
        '
        Me.admin_.Animated = True
        Me.admin_.AnimatedGIF = True
        Me.admin_.BackColor = System.Drawing.Color.Transparent
        Me.admin_.BorderRadius = 10
        Me.admin_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_.FillColor = System.Drawing.Color.Green
        Me.admin_.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_.ForeColor = System.Drawing.Color.White
        Me.admin_.Image = Global.OOP_FinalProject.My.Resources.Resources.Plus
        Me.admin_.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.admin_.ImageSize = New System.Drawing.Size(25, 25)
        Me.admin_.Location = New System.Drawing.Point(792, 21)
        Me.admin_.Name = "admin_"
        Me.admin_.Size = New System.Drawing.Size(112, 45)
        Me.admin_.TabIndex = 90
        Me.admin_.Text = "Add New"
        Me.admin_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.admin_.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(41, 338)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 7
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(318, 216)
        Me.Guna2ShadowPanel1.TabIndex = 89
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel6.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel6.IsSelectionEnabled = False
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(8, 69)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(34, 19)
        Me.Guna2HtmlLabel6.TabIndex = 79
        Me.Guna2HtmlLabel6.TabStop = False
        Me.Guna2HtmlLabel6.Text = "GWA"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel5.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel5.IsSelectionEnabled = False
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(8, 46)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(72, 19)
        Me.Guna2HtmlLabel5.TabIndex = 78
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Percentage"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(8, 36)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(197, 10)
        Me.Guna2Separator1.TabIndex = 76
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2HtmlLabel1.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(8, 8)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(135, 27)
        Me.Guna2HtmlLabel1.TabIndex = 74
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Midterm Grade"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'stp_datatable
        '
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        Me.stp_datatable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.stp_datatable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.stp_datatable.ColumnHeadersHeight = 4
        Me.stp_datatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.stp_datatable.DefaultCellStyle = DataGridViewCellStyle27
        Me.stp_datatable.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stp_datatable.Location = New System.Drawing.Point(40, 72)
        Me.stp_datatable.Name = "stp_datatable"
        Me.stp_datatable.RowHeadersVisible = False
        Me.stp_datatable.Size = New System.Drawing.Size(864, 240)
        Me.stp_datatable.TabIndex = 88
        Me.stp_datatable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.stp_datatable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.stp_datatable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.stp_datatable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.stp_datatable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.stp_datatable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.stp_datatable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stp_datatable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stp_datatable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.stp_datatable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stp_datatable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.stp_datatable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.stp_datatable.ThemeStyle.HeaderStyle.Height = 4
        Me.stp_datatable.ThemeStyle.ReadOnly = False
        Me.stp_datatable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.stp_datatable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.stp_datatable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stp_datatable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.stp_datatable.ThemeStyle.RowsStyle.Height = 22
        Me.stp_datatable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stp_datatable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DTBorderRad
        '
        Me.DTBorderRad.BorderRadius = 20
        Me.DTBorderRad.TargetControl = Me.stp_datatable
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Animated = True
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.Green
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI Variable Text", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(115, 140)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "asdadad"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(158, 33)
        Me.Guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.Guna2TextBox1.TabIndex = 80
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OOP_FinalProject.My.Resources.Resources.Paman
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 711)
        Me.Controls.Add(Me.admin_container)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPanel"
        Me.Text = "AdminPanel"
        Me.admin_container.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stp_sidebar.ResumeLayout(False)
        Me.adming_professor.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.admin_faculty.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.stp_datatable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormDrag As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents FormBorderRad As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents admin_container As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents stp_sidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_sbstudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_sbprofessor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DTBorderRad As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents adming_professor As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stp_currentdate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents stp_clocktimer As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents admin_faculty As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stp_datatable As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents admin_sbdepartment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_sbfaculty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_ As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
