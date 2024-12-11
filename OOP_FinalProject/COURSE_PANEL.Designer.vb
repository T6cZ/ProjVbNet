<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COURSE_PANEL
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.admin_faculty = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.coursedepartmentid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.coursecredits = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.coursecoursename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.coursecourseid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.COURSESTABLE = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.courseupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.coursedelete = New Guna.UI2.WinForms.Guna2Button()
        Me.courseaddnew = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_faculty.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.COURSESTABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_faculty
        '
        Me.admin_faculty.BackColor = System.Drawing.Color.Black
        Me.admin_faculty.BorderRadius = 10
        Me.admin_faculty.Controls.Add(Me.courseupdate)
        Me.admin_faculty.Controls.Add(Me.coursedelete)
        Me.admin_faculty.Controls.Add(Me.courseaddnew)
        Me.admin_faculty.Controls.Add(Me.Guna2ShadowPanel1)
        Me.admin_faculty.Controls.Add(Me.COURSESTABLE)
        Me.admin_faculty.CustomizableEdges.BottomLeft = False
        Me.admin_faculty.CustomizableEdges.TopLeft = False
        Me.admin_faculty.CustomizableEdges.TopRight = False
        Me.admin_faculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_faculty.Location = New System.Drawing.Point(20, 12)
        Me.admin_faculty.Name = "admin_faculty"
        Me.admin_faculty.Size = New System.Drawing.Size(938, 580)
        Me.admin_faculty.TabIndex = 85
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.coursedepartmentid)
        Me.Guna2ShadowPanel1.Controls.Add(Me.coursecredits)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.coursecoursename)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.coursecourseid)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(40, 266)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 7
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(723, 293)
        Me.Guna2ShadowPanel1.TabIndex = 89
        '
        'coursedepartmentid
        '
        Me.coursedepartmentid.Animated = True
        Me.coursedepartmentid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.coursedepartmentid.DefaultText = ""
        Me.coursedepartmentid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.coursedepartmentid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.coursedepartmentid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursedepartmentid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursedepartmentid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.coursedepartmentid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.coursedepartmentid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursedepartmentid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.coursedepartmentid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.coursedepartmentid.Location = New System.Drawing.Point(150, 192)
        Me.coursedepartmentid.Name = "coursedepartmentid"
        Me.coursedepartmentid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.coursedepartmentid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.coursedepartmentid.PlaceholderText = "Edit ID"
        Me.coursedepartmentid.SelectedText = ""
        Me.coursedepartmentid.Size = New System.Drawing.Size(129, 23)
        Me.coursedepartmentid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.coursedepartmentid.TabIndex = 94
        Me.coursedepartmentid.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'coursecredits
        '
        Me.coursecredits.Animated = True
        Me.coursecredits.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.coursecredits.DefaultText = ""
        Me.coursecredits.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.coursecredits.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.coursecredits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursecredits.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursecredits.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.coursecredits.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.coursecredits.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecredits.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.coursecredits.HoverState.BorderColor = System.Drawing.Color.Black
        Me.coursecredits.Location = New System.Drawing.Point(150, 148)
        Me.coursecredits.Name = "coursecredits"
        Me.coursecredits.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.coursecredits.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.coursecredits.PlaceholderText = "Edit Credits"
        Me.coursecredits.SelectedText = ""
        Me.coursecredits.Size = New System.Drawing.Size(129, 23)
        Me.coursecredits.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.coursecredits.TabIndex = 93
        Me.coursecredits.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2HtmlLabel1.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 9)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(131, 27)
        Me.Guna2HtmlLabel1.TabIndex = 74
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Course Details"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel7.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel7.IsSelectionEnabled = False
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(25, 190)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(98, 19)
        Me.Guna2HtmlLabel7.TabIndex = 87
        Me.Guna2HtmlLabel7.TabStop = False
        Me.Guna2HtmlLabel7.Text = "Department ID : "
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel4.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel4.IsSelectionEnabled = False
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(24, 147)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(47, 19)
        Me.Guna2HtmlLabel4.TabIndex = 83
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Credits"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'coursecoursename
        '
        Me.coursecoursename.Animated = True
        Me.coursecoursename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.coursecoursename.DefaultText = ""
        Me.coursecoursename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.coursecoursename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.coursecoursename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursecoursename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursecoursename.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.coursecoursename.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.coursecoursename.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecoursename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.coursecoursename.HoverState.BorderColor = System.Drawing.Color.Black
        Me.coursecoursename.Location = New System.Drawing.Point(150, 104)
        Me.coursecoursename.Name = "coursecoursename"
        Me.coursecoursename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.coursecoursename.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.coursecoursename.PlaceholderText = "Edit Name"
        Me.coursecoursename.SelectedText = ""
        Me.coursecoursename.Size = New System.Drawing.Size(129, 23)
        Me.coursecoursename.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.coursecoursename.TabIndex = 82
        Me.coursecoursename.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel3.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel3.IsSelectionEnabled = False
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(24, 107)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(91, 19)
        Me.Guna2HtmlLabel3.TabIndex = 81
        Me.Guna2HtmlLabel3.TabStop = False
        Me.Guna2HtmlLabel3.Text = "Course Name :"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'coursecourseid
        '
        Me.coursecourseid.Animated = True
        Me.coursecourseid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.coursecourseid.DefaultText = ""
        Me.coursecourseid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.coursecourseid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.coursecourseid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursecourseid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.coursecourseid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.coursecourseid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.coursecourseid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursecourseid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.coursecourseid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.coursecourseid.Location = New System.Drawing.Point(150, 65)
        Me.coursecourseid.Name = "coursecourseid"
        Me.coursecourseid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.coursecourseid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.coursecourseid.PlaceholderText = "Edit ID"
        Me.coursecourseid.SelectedText = ""
        Me.coursecourseid.Size = New System.Drawing.Size(129, 23)
        Me.coursecourseid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.coursecourseid.TabIndex = 80
        Me.coursecourseid.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel5.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel5.IsSelectionEnabled = False
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(24, 68)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(68, 19)
        Me.Guna2HtmlLabel5.TabIndex = 78
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Course ID :"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(24, 23)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(671, 36)
        Me.Guna2Separator1.TabIndex = 76
        '
        'COURSESTABLE
        '
        Me.COURSESTABLE.AllowUserToResizeColumns = False
        Me.COURSESTABLE.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COURSESTABLE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COURSESTABLE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.COURSESTABLE.ColumnHeadersHeight = 50
        Me.COURSESTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COURSESTABLE.DefaultCellStyle = DataGridViewCellStyle8
        Me.COURSESTABLE.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSESTABLE.Location = New System.Drawing.Point(40, 23)
        Me.COURSESTABLE.MultiSelect = False
        Me.COURSESTABLE.Name = "COURSESTABLE"
        Me.COURSESTABLE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COURSESTABLE.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.COURSESTABLE.RowHeadersVisible = False
        Me.COURSESTABLE.RowHeadersWidth = 51
        Me.COURSESTABLE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COURSESTABLE.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.COURSESTABLE.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.COURSESTABLE.RowTemplate.Height = 35
        Me.COURSESTABLE.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.COURSESTABLE.Size = New System.Drawing.Size(864, 224)
        Me.COURSESTABLE.TabIndex = 88
        Me.COURSESTABLE.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.COURSESTABLE.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.COURSESTABLE.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.COURSESTABLE.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.COURSESTABLE.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.COURSESTABLE.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.COURSESTABLE.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSESTABLE.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSESTABLE.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.COURSESTABLE.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COURSESTABLE.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.COURSESTABLE.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.COURSESTABLE.ThemeStyle.HeaderStyle.Height = 50
        Me.COURSESTABLE.ThemeStyle.ReadOnly = False
        Me.COURSESTABLE.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.COURSESTABLE.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.COURSESTABLE.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COURSESTABLE.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.COURSESTABLE.ThemeStyle.RowsStyle.Height = 35
        Me.COURSESTABLE.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSESTABLE.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'courseupdate
        '
        Me.courseupdate.Animated = True
        Me.courseupdate.AnimatedGIF = True
        Me.courseupdate.BackColor = System.Drawing.Color.Transparent
        Me.courseupdate.BorderRadius = 10
        Me.courseupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.courseupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.courseupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.courseupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.courseupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.courseupdate.FillColor = System.Drawing.Color.DarkGreen
        Me.courseupdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseupdate.ForeColor = System.Drawing.Color.White
        Me.courseupdate.Image = Global.OOP_FinalProject.My.Resources.Resources.update
        Me.courseupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.courseupdate.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.courseupdate.ImageSize = New System.Drawing.Size(23, 23)
        Me.courseupdate.Location = New System.Drawing.Point(792, 394)
        Me.courseupdate.Name = "courseupdate"
        Me.courseupdate.Size = New System.Drawing.Size(112, 45)
        Me.courseupdate.TabIndex = 91
        Me.courseupdate.Text = "Update"
        Me.courseupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.courseupdate.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'coursedelete
        '
        Me.coursedelete.Animated = True
        Me.coursedelete.AnimatedGIF = True
        Me.coursedelete.BackColor = System.Drawing.Color.Transparent
        Me.coursedelete.BorderRadius = 10
        Me.coursedelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.coursedelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.coursedelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.coursedelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.coursedelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.coursedelete.FillColor = System.Drawing.Color.DarkRed
        Me.coursedelete.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coursedelete.ForeColor = System.Drawing.Color.White
        Me.coursedelete.Image = Global.OOP_FinalProject.My.Resources.Resources.Delete
        Me.coursedelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.coursedelete.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.coursedelete.ImageSize = New System.Drawing.Size(23, 23)
        Me.coursedelete.Location = New System.Drawing.Point(792, 458)
        Me.coursedelete.Name = "coursedelete"
        Me.coursedelete.Size = New System.Drawing.Size(112, 45)
        Me.coursedelete.TabIndex = 92
        Me.coursedelete.Text = "Delete"
        Me.coursedelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.coursedelete.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'courseaddnew
        '
        Me.courseaddnew.Animated = True
        Me.courseaddnew.AnimatedGIF = True
        Me.courseaddnew.BackColor = System.Drawing.Color.Transparent
        Me.courseaddnew.BorderRadius = 10
        Me.courseaddnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.courseaddnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.courseaddnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.courseaddnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.courseaddnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.courseaddnew.FillColor = System.Drawing.Color.Green
        Me.courseaddnew.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseaddnew.ForeColor = System.Drawing.Color.White
        Me.courseaddnew.Image = Global.OOP_FinalProject.My.Resources.Resources.Plus
        Me.courseaddnew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.courseaddnew.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.courseaddnew.ImageSize = New System.Drawing.Size(25, 25)
        Me.courseaddnew.Location = New System.Drawing.Point(792, 331)
        Me.courseaddnew.Name = "courseaddnew"
        Me.courseaddnew.Size = New System.Drawing.Size(112, 45)
        Me.courseaddnew.TabIndex = 90
        Me.courseaddnew.Text = "Add New"
        Me.courseaddnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.courseaddnew.TextOffset = New System.Drawing.Point(0, -1)
        '
        'COURSE_PANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(970, 616)
        Me.Controls.Add(Me.admin_faculty)
        Me.Name = "COURSE_PANEL"
        Me.Text = "COURSE_PANEL"
        Me.admin_faculty.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.COURSESTABLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents admin_faculty As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents courseupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents coursedelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents courseaddnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents coursecoursename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents coursecourseid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents COURSESTABLE As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents coursedepartmentid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents coursecredits As Guna.UI2.WinForms.Guna2TextBox
End Class
