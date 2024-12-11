<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ENROLLMENT_PANEL
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
        Me.e_semester = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.e_enrollmentdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.e_classid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.e_studentname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.e_enrollmentid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.ENROLLMENTSTABLE = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.enrollmentupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.enrollmentdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.courseaddnew = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_faculty.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.ENROLLMENTSTABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_faculty
        '
        Me.admin_faculty.BackColor = System.Drawing.Color.Black
        Me.admin_faculty.BorderRadius = 10
        Me.admin_faculty.Controls.Add(Me.enrollmentupdate)
        Me.admin_faculty.Controls.Add(Me.enrollmentdelete)
        Me.admin_faculty.Controls.Add(Me.courseaddnew)
        Me.admin_faculty.Controls.Add(Me.Guna2ShadowPanel1)
        Me.admin_faculty.Controls.Add(Me.ENROLLMENTSTABLE)
        Me.admin_faculty.CustomizableEdges.BottomLeft = False
        Me.admin_faculty.CustomizableEdges.TopLeft = False
        Me.admin_faculty.CustomizableEdges.TopRight = False
        Me.admin_faculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_faculty.Location = New System.Drawing.Point(13, -2)
        Me.admin_faculty.Name = "admin_faculty"
        Me.admin_faculty.Size = New System.Drawing.Size(938, 580)
        Me.admin_faculty.TabIndex = 86
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.e_semester)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.e_enrollmentdate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.e_classid)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.e_studentname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.e_enrollmentid)
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
        'e_semester
        '
        Me.e_semester.BackColor = System.Drawing.Color.Transparent
        Me.e_semester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.e_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.e_semester.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.e_semester.FocusedColor = System.Drawing.Color.Black
        Me.e_semester.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.e_semester.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold)
        Me.e_semester.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.e_semester.ItemHeight = 20
        Me.e_semester.Items.AddRange(New Object() {"FIRST", "SECOND"})
        Me.e_semester.Location = New System.Drawing.Point(150, 234)
        Me.e_semester.Name = "e_semester"
        Me.e_semester.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.e_semester.Size = New System.Drawing.Size(129, 26)
        Me.e_semester.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.e_semester.TabIndex = 96
        Me.e_semester.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel2.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(25, 234)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(60, 19)
        Me.Guna2HtmlLabel2.TabIndex = 95
        Me.Guna2HtmlLabel2.TabStop = False
        Me.Guna2HtmlLabel2.Text = "Semester"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'e_enrollmentdate
        '
        Me.e_enrollmentdate.Animated = True
        Me.e_enrollmentdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.e_enrollmentdate.DefaultText = ""
        Me.e_enrollmentdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.e_enrollmentdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.e_enrollmentdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_enrollmentdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_enrollmentdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.e_enrollmentdate.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.e_enrollmentdate.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_enrollmentdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.e_enrollmentdate.HoverState.BorderColor = System.Drawing.Color.Black
        Me.e_enrollmentdate.Location = New System.Drawing.Point(150, 192)
        Me.e_enrollmentdate.Name = "e_enrollmentdate"
        Me.e_enrollmentdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.e_enrollmentdate.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.e_enrollmentdate.PlaceholderText = "Edit date"
        Me.e_enrollmentdate.SelectedText = ""
        Me.e_enrollmentdate.Size = New System.Drawing.Size(129, 23)
        Me.e_enrollmentdate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.e_enrollmentdate.TabIndex = 94
        Me.e_enrollmentdate.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'e_classid
        '
        Me.e_classid.Animated = True
        Me.e_classid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.e_classid.DefaultText = ""
        Me.e_classid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.e_classid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.e_classid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_classid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_classid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.e_classid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.e_classid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_classid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.e_classid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.e_classid.Location = New System.Drawing.Point(150, 148)
        Me.e_classid.Name = "e_classid"
        Me.e_classid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.e_classid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.e_classid.PlaceholderText = "Edit ID"
        Me.e_classid.SelectedText = ""
        Me.e_classid.Size = New System.Drawing.Size(129, 23)
        Me.e_classid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.e_classid.TabIndex = 93
        Me.e_classid.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(164, 27)
        Me.Guna2HtmlLabel1.TabIndex = 74
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Enrollment Details"
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
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(105, 19)
        Me.Guna2HtmlLabel7.TabIndex = 87
        Me.Guna2HtmlLabel7.TabStop = False
        Me.Guna2HtmlLabel7.Text = "Enrollment Date:"
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
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(57, 19)
        Me.Guna2HtmlLabel4.TabIndex = 83
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Class ID :"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'e_studentname
        '
        Me.e_studentname.Animated = True
        Me.e_studentname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.e_studentname.DefaultText = ""
        Me.e_studentname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.e_studentname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.e_studentname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_studentname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_studentname.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.e_studentname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.e_studentname.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_studentname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.e_studentname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.e_studentname.Location = New System.Drawing.Point(150, 104)
        Me.e_studentname.Name = "e_studentname"
        Me.e_studentname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.e_studentname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.e_studentname.PlaceholderText = "Edit ID"
        Me.e_studentname.SelectedText = ""
        Me.e_studentname.Size = New System.Drawing.Size(129, 23)
        Me.e_studentname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.e_studentname.TabIndex = 82
        Me.e_studentname.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(74, 19)
        Me.Guna2HtmlLabel3.TabIndex = 81
        Me.Guna2HtmlLabel3.TabStop = False
        Me.Guna2HtmlLabel3.Text = "Student ID :"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'e_enrollmentid
        '
        Me.e_enrollmentid.Animated = True
        Me.e_enrollmentid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.e_enrollmentid.DefaultText = ""
        Me.e_enrollmentid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.e_enrollmentid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.e_enrollmentid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_enrollmentid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.e_enrollmentid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.e_enrollmentid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.e_enrollmentid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.e_enrollmentid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.e_enrollmentid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.e_enrollmentid.Location = New System.Drawing.Point(150, 65)
        Me.e_enrollmentid.Name = "e_enrollmentid"
        Me.e_enrollmentid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.e_enrollmentid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.e_enrollmentid.PlaceholderText = "Edit ID"
        Me.e_enrollmentid.SelectedText = ""
        Me.e_enrollmentid.Size = New System.Drawing.Size(129, 23)
        Me.e_enrollmentid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.e_enrollmentid.TabIndex = 80
        Me.e_enrollmentid.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(93, 19)
        Me.Guna2HtmlLabel5.TabIndex = 78
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Enrollment ID :"
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
        'ENROLLMENTSTABLE
        '
        Me.ENROLLMENTSTABLE.AllowUserToResizeColumns = False
        Me.ENROLLMENTSTABLE.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENROLLMENTSTABLE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENROLLMENTSTABLE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.ENROLLMENTSTABLE.ColumnHeadersHeight = 50
        Me.ENROLLMENTSTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENROLLMENTSTABLE.DefaultCellStyle = DataGridViewCellStyle8
        Me.ENROLLMENTSTABLE.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ENROLLMENTSTABLE.Location = New System.Drawing.Point(40, 23)
        Me.ENROLLMENTSTABLE.MultiSelect = False
        Me.ENROLLMENTSTABLE.Name = "ENROLLMENTSTABLE"
        Me.ENROLLMENTSTABLE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENROLLMENTSTABLE.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.ENROLLMENTSTABLE.RowHeadersVisible = False
        Me.ENROLLMENTSTABLE.RowHeadersWidth = 51
        Me.ENROLLMENTSTABLE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ENROLLMENTSTABLE.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.ENROLLMENTSTABLE.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ENROLLMENTSTABLE.RowTemplate.Height = 35
        Me.ENROLLMENTSTABLE.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ENROLLMENTSTABLE.Size = New System.Drawing.Size(864, 224)
        Me.ENROLLMENTSTABLE.TabIndex = 88
        Me.ENROLLMENTSTABLE.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.ENROLLMENTSTABLE.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.ENROLLMENTSTABLE.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.ENROLLMENTSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.ENROLLMENTSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.ENROLLMENTSTABLE.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.ENROLLMENTSTABLE.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ENROLLMENTSTABLE.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ENROLLMENTSTABLE.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ENROLLMENTSTABLE.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENROLLMENTSTABLE.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ENROLLMENTSTABLE.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.ENROLLMENTSTABLE.ThemeStyle.HeaderStyle.Height = 50
        Me.ENROLLMENTSTABLE.ThemeStyle.ReadOnly = False
        Me.ENROLLMENTSTABLE.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ENROLLMENTSTABLE.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ENROLLMENTSTABLE.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENROLLMENTSTABLE.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ENROLLMENTSTABLE.ThemeStyle.RowsStyle.Height = 35
        Me.ENROLLMENTSTABLE.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ENROLLMENTSTABLE.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'enrollmentupdate
        '
        Me.enrollmentupdate.Animated = True
        Me.enrollmentupdate.AnimatedGIF = True
        Me.enrollmentupdate.BackColor = System.Drawing.Color.Transparent
        Me.enrollmentupdate.BorderRadius = 10
        Me.enrollmentupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enrollmentupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.enrollmentupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.enrollmentupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.enrollmentupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.enrollmentupdate.FillColor = System.Drawing.Color.DarkGreen
        Me.enrollmentupdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollmentupdate.ForeColor = System.Drawing.Color.White
        Me.enrollmentupdate.Image = Global.OOP_FinalProject.My.Resources.Resources.update
        Me.enrollmentupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.enrollmentupdate.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.enrollmentupdate.ImageSize = New System.Drawing.Size(23, 23)
        Me.enrollmentupdate.Location = New System.Drawing.Point(792, 394)
        Me.enrollmentupdate.Name = "enrollmentupdate"
        Me.enrollmentupdate.Size = New System.Drawing.Size(112, 45)
        Me.enrollmentupdate.TabIndex = 91
        Me.enrollmentupdate.Text = "Update"
        Me.enrollmentupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.enrollmentupdate.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'enrollmentdelete
        '
        Me.enrollmentdelete.Animated = True
        Me.enrollmentdelete.AnimatedGIF = True
        Me.enrollmentdelete.BackColor = System.Drawing.Color.Transparent
        Me.enrollmentdelete.BorderRadius = 10
        Me.enrollmentdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enrollmentdelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.enrollmentdelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.enrollmentdelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.enrollmentdelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.enrollmentdelete.FillColor = System.Drawing.Color.DarkRed
        Me.enrollmentdelete.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrollmentdelete.ForeColor = System.Drawing.Color.White
        Me.enrollmentdelete.Image = Global.OOP_FinalProject.My.Resources.Resources.Delete
        Me.enrollmentdelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.enrollmentdelete.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.enrollmentdelete.ImageSize = New System.Drawing.Size(23, 23)
        Me.enrollmentdelete.Location = New System.Drawing.Point(792, 458)
        Me.enrollmentdelete.Name = "enrollmentdelete"
        Me.enrollmentdelete.Size = New System.Drawing.Size(112, 45)
        Me.enrollmentdelete.TabIndex = 92
        Me.enrollmentdelete.Text = "Delete"
        Me.enrollmentdelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.enrollmentdelete.TextOffset = New System.Drawing.Point(-5, 0)
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
        'ENROLLMENT_PANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(964, 577)
        Me.Controls.Add(Me.admin_faculty)
        Me.Name = "ENROLLMENT_PANEL"
        Me.Text = "ENROLLMENT_PANEL"
        Me.admin_faculty.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.ENROLLMENTSTABLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents admin_faculty As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents enrollmentupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents enrollmentdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents courseaddnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents e_enrollmentdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents e_classid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents e_studentname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents e_enrollmentid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents ENROLLMENTSTABLE As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents e_semester As Guna.UI2.WinForms.Guna2ComboBox
End Class
