<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEPARTMENT_PANEL
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
        Me.departmentudpate = New Guna.UI2.WinForms.Guna2Button()
        Me.departmentdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.departmentaddnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.d_departmentname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.d_departmentid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.DEPARTMENTSTABLE = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.admin_faculty.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.DEPARTMENTSTABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_faculty
        '
        Me.admin_faculty.BackColor = System.Drawing.Color.Black
        Me.admin_faculty.BorderRadius = 10
        Me.admin_faculty.Controls.Add(Me.departmentudpate)
        Me.admin_faculty.Controls.Add(Me.departmentdelete)
        Me.admin_faculty.Controls.Add(Me.departmentaddnew)
        Me.admin_faculty.Controls.Add(Me.Guna2ShadowPanel1)
        Me.admin_faculty.Controls.Add(Me.DEPARTMENTSTABLE)
        Me.admin_faculty.CustomizableEdges.BottomLeft = False
        Me.admin_faculty.CustomizableEdges.TopLeft = False
        Me.admin_faculty.CustomizableEdges.TopRight = False
        Me.admin_faculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_faculty.Location = New System.Drawing.Point(48, 6)
        Me.admin_faculty.Name = "admin_faculty"
        Me.admin_faculty.Size = New System.Drawing.Size(938, 580)
        Me.admin_faculty.TabIndex = 86
        '
        'departmentudpate
        '
        Me.departmentudpate.Animated = True
        Me.departmentudpate.AnimatedGIF = True
        Me.departmentudpate.BackColor = System.Drawing.Color.Transparent
        Me.departmentudpate.BorderRadius = 10
        Me.departmentudpate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.departmentudpate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.departmentudpate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.departmentudpate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.departmentudpate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.departmentudpate.FillColor = System.Drawing.Color.DarkGreen
        Me.departmentudpate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentudpate.ForeColor = System.Drawing.Color.White
        Me.departmentudpate.Image = Global.OOP_FinalProject.My.Resources.Resources.update
        Me.departmentudpate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.departmentudpate.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.departmentudpate.ImageSize = New System.Drawing.Size(23, 23)
        Me.departmentudpate.Location = New System.Drawing.Point(792, 394)
        Me.departmentudpate.Name = "departmentudpate"
        Me.departmentudpate.Size = New System.Drawing.Size(112, 45)
        Me.departmentudpate.TabIndex = 91
        Me.departmentudpate.Text = "Update"
        Me.departmentudpate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.departmentudpate.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'departmentdelete
        '
        Me.departmentdelete.Animated = True
        Me.departmentdelete.AnimatedGIF = True
        Me.departmentdelete.BackColor = System.Drawing.Color.Transparent
        Me.departmentdelete.BorderRadius = 10
        Me.departmentdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.departmentdelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.departmentdelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.departmentdelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.departmentdelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.departmentdelete.FillColor = System.Drawing.Color.DarkRed
        Me.departmentdelete.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentdelete.ForeColor = System.Drawing.Color.White
        Me.departmentdelete.Image = Global.OOP_FinalProject.My.Resources.Resources.Delete
        Me.departmentdelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.departmentdelete.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.departmentdelete.ImageSize = New System.Drawing.Size(23, 23)
        Me.departmentdelete.Location = New System.Drawing.Point(792, 458)
        Me.departmentdelete.Name = "departmentdelete"
        Me.departmentdelete.Size = New System.Drawing.Size(112, 45)
        Me.departmentdelete.TabIndex = 92
        Me.departmentdelete.Text = "Delete"
        Me.departmentdelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.departmentdelete.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'departmentaddnew
        '
        Me.departmentaddnew.Animated = True
        Me.departmentaddnew.AnimatedGIF = True
        Me.departmentaddnew.BackColor = System.Drawing.Color.Transparent
        Me.departmentaddnew.BorderRadius = 10
        Me.departmentaddnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.departmentaddnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.departmentaddnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.departmentaddnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.departmentaddnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.departmentaddnew.FillColor = System.Drawing.Color.Green
        Me.departmentaddnew.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentaddnew.ForeColor = System.Drawing.Color.White
        Me.departmentaddnew.Image = Global.OOP_FinalProject.My.Resources.Resources.Plus
        Me.departmentaddnew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.departmentaddnew.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.departmentaddnew.ImageSize = New System.Drawing.Size(25, 25)
        Me.departmentaddnew.Location = New System.Drawing.Point(792, 331)
        Me.departmentaddnew.Name = "departmentaddnew"
        Me.departmentaddnew.Size = New System.Drawing.Size(112, 45)
        Me.departmentaddnew.TabIndex = 90
        Me.departmentaddnew.Text = "Add New"
        Me.departmentaddnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.departmentaddnew.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.d_departmentname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.d_departmentid)
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
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.0!)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2HtmlLabel1.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(25, 9)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(174, 27)
        Me.Guna2HtmlLabel1.TabIndex = 74
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Department Details"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
        '
        'd_departmentname
        '
        Me.d_departmentname.Animated = True
        Me.d_departmentname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.d_departmentname.DefaultText = ""
        Me.d_departmentname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.d_departmentname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.d_departmentname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.d_departmentname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.d_departmentname.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.d_departmentname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.d_departmentname.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_departmentname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.d_departmentname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.d_departmentname.Location = New System.Drawing.Point(150, 104)
        Me.d_departmentname.Name = "d_departmentname"
        Me.d_departmentname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.d_departmentname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.d_departmentname.PlaceholderText = "Edit Name"
        Me.d_departmentname.SelectedText = ""
        Me.d_departmentname.Size = New System.Drawing.Size(129, 23)
        Me.d_departmentname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.d_departmentname.TabIndex = 82
        Me.d_departmentname.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(121, 19)
        Me.Guna2HtmlLabel3.TabIndex = 81
        Me.Guna2HtmlLabel3.TabStop = False
        Me.Guna2HtmlLabel3.Text = "Department Name : "
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'd_departmentid
        '
        Me.d_departmentid.Animated = True
        Me.d_departmentid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.d_departmentid.DefaultText = ""
        Me.d_departmentid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.d_departmentid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.d_departmentid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.d_departmentid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.d_departmentid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.d_departmentid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.d_departmentid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d_departmentid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.d_departmentid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.d_departmentid.Location = New System.Drawing.Point(150, 65)
        Me.d_departmentid.Name = "d_departmentid"
        Me.d_departmentid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.d_departmentid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.d_departmentid.PlaceholderText = "Edit ID"
        Me.d_departmentid.SelectedText = ""
        Me.d_departmentid.Size = New System.Drawing.Size(129, 23)
        Me.d_departmentid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.d_departmentid.TabIndex = 80
        Me.d_departmentid.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(98, 19)
        Me.Guna2HtmlLabel5.TabIndex = 78
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Department ID : "
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
        'DEPARTMENTSTABLE
        '
        Me.DEPARTMENTSTABLE.AllowUserToResizeColumns = False
        Me.DEPARTMENTSTABLE.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPARTMENTSTABLE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPARTMENTSTABLE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DEPARTMENTSTABLE.ColumnHeadersHeight = 50
        Me.DEPARTMENTSTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPARTMENTSTABLE.DefaultCellStyle = DataGridViewCellStyle8
        Me.DEPARTMENTSTABLE.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTSTABLE.Location = New System.Drawing.Point(40, 23)
        Me.DEPARTMENTSTABLE.MultiSelect = False
        Me.DEPARTMENTSTABLE.Name = "DEPARTMENTSTABLE"
        Me.DEPARTMENTSTABLE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPARTMENTSTABLE.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DEPARTMENTSTABLE.RowHeadersVisible = False
        Me.DEPARTMENTSTABLE.RowHeadersWidth = 51
        Me.DEPARTMENTSTABLE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DEPARTMENTSTABLE.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DEPARTMENTSTABLE.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DEPARTMENTSTABLE.RowTemplate.Height = 35
        Me.DEPARTMENTSTABLE.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DEPARTMENTSTABLE.Size = New System.Drawing.Size(864, 224)
        Me.DEPARTMENTSTABLE.TabIndex = 88
        Me.DEPARTMENTSTABLE.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DEPARTMENTSTABLE.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DEPARTMENTSTABLE.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DEPARTMENTSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DEPARTMENTSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DEPARTMENTSTABLE.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DEPARTMENTSTABLE.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTSTABLE.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTSTABLE.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DEPARTMENTSTABLE.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEPARTMENTSTABLE.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DEPARTMENTSTABLE.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DEPARTMENTSTABLE.ThemeStyle.HeaderStyle.Height = 50
        Me.DEPARTMENTSTABLE.ThemeStyle.ReadOnly = False
        Me.DEPARTMENTSTABLE.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DEPARTMENTSTABLE.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DEPARTMENTSTABLE.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEPARTMENTSTABLE.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DEPARTMENTSTABLE.ThemeStyle.RowsStyle.Height = 35
        Me.DEPARTMENTSTABLE.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTSTABLE.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DEPARTMENT_PANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1034, 593)
        Me.Controls.Add(Me.admin_faculty)
        Me.Name = "DEPARTMENT_PANEL"
        Me.Text = "DEPARTMENT_PANEL"
        Me.admin_faculty.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.DEPARTMENTSTABLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents admin_faculty As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents departmentudpate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents departmentdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents departmentaddnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents d_departmentname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents d_departmentid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents DEPARTMENTSTABLE As Guna.UI2.WinForms.Guna2DataGridView
End Class
