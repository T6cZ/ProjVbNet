<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SECTION_PANEL
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.admin_faculty = New Guna.UI2.WinForms.Guna2Panel()
        Me.sectionupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.sectiondelete = New Guna.UI2.WinForms.Guna2Button()
        Me.sectionaddnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.s_yearlevel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.s_departmentid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.s_sectionname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.s_sectionid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.SECTIONSTABLE = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.admin_faculty.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.SECTIONSTABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_faculty
        '
        Me.admin_faculty.BackColor = System.Drawing.Color.Black
        Me.admin_faculty.BorderRadius = 10
        Me.admin_faculty.Controls.Add(Me.sectionupdate)
        Me.admin_faculty.Controls.Add(Me.sectiondelete)
        Me.admin_faculty.Controls.Add(Me.sectionaddnew)
        Me.admin_faculty.Controls.Add(Me.Guna2ShadowPanel1)
        Me.admin_faculty.Controls.Add(Me.SECTIONSTABLE)
        Me.admin_faculty.CustomizableEdges.BottomLeft = False
        Me.admin_faculty.CustomizableEdges.TopLeft = False
        Me.admin_faculty.CustomizableEdges.TopRight = False
        Me.admin_faculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_faculty.Location = New System.Drawing.Point(-15, -3)
        Me.admin_faculty.Name = "admin_faculty"
        Me.admin_faculty.Size = New System.Drawing.Size(938, 580)
        Me.admin_faculty.TabIndex = 87
        '
        'sectionupdate
        '
        Me.sectionupdate.Animated = True
        Me.sectionupdate.AnimatedGIF = True
        Me.sectionupdate.BackColor = System.Drawing.Color.Transparent
        Me.sectionupdate.BorderRadius = 10
        Me.sectionupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sectionupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.sectionupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.sectionupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.sectionupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.sectionupdate.FillColor = System.Drawing.Color.DarkGreen
        Me.sectionupdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionupdate.ForeColor = System.Drawing.Color.White
        Me.sectionupdate.Image = Global.OOP_FinalProject.My.Resources.Resources.update
        Me.sectionupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.sectionupdate.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.sectionupdate.ImageSize = New System.Drawing.Size(23, 23)
        Me.sectionupdate.Location = New System.Drawing.Point(792, 394)
        Me.sectionupdate.Name = "sectionupdate"
        Me.sectionupdate.Size = New System.Drawing.Size(112, 45)
        Me.sectionupdate.TabIndex = 91
        Me.sectionupdate.Text = "Update"
        Me.sectionupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.sectionupdate.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'sectiondelete
        '
        Me.sectiondelete.Animated = True
        Me.sectiondelete.AnimatedGIF = True
        Me.sectiondelete.BackColor = System.Drawing.Color.Transparent
        Me.sectiondelete.BorderRadius = 10
        Me.sectiondelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sectiondelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.sectiondelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.sectiondelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.sectiondelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.sectiondelete.FillColor = System.Drawing.Color.DarkRed
        Me.sectiondelete.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectiondelete.ForeColor = System.Drawing.Color.White
        Me.sectiondelete.Image = Global.OOP_FinalProject.My.Resources.Resources.Delete
        Me.sectiondelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.sectiondelete.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.sectiondelete.ImageSize = New System.Drawing.Size(23, 23)
        Me.sectiondelete.Location = New System.Drawing.Point(792, 458)
        Me.sectiondelete.Name = "sectiondelete"
        Me.sectiondelete.Size = New System.Drawing.Size(112, 45)
        Me.sectiondelete.TabIndex = 92
        Me.sectiondelete.Text = "Delete"
        Me.sectiondelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.sectiondelete.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'sectionaddnew
        '
        Me.sectionaddnew.Animated = True
        Me.sectionaddnew.AnimatedGIF = True
        Me.sectionaddnew.BackColor = System.Drawing.Color.Transparent
        Me.sectionaddnew.BorderRadius = 10
        Me.sectionaddnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sectionaddnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.sectionaddnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.sectionaddnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.sectionaddnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.sectionaddnew.FillColor = System.Drawing.Color.Green
        Me.sectionaddnew.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectionaddnew.ForeColor = System.Drawing.Color.White
        Me.sectionaddnew.Image = Global.OOP_FinalProject.My.Resources.Resources.Plus
        Me.sectionaddnew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.sectionaddnew.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.sectionaddnew.ImageSize = New System.Drawing.Size(25, 25)
        Me.sectionaddnew.Location = New System.Drawing.Point(792, 331)
        Me.sectionaddnew.Name = "sectionaddnew"
        Me.sectionaddnew.Size = New System.Drawing.Size(112, 45)
        Me.sectionaddnew.TabIndex = 90
        Me.sectionaddnew.Text = "Add New"
        Me.sectionaddnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.sectionaddnew.TextOffset = New System.Drawing.Point(0, -1)
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.s_yearlevel)
        Me.Guna2ShadowPanel1.Controls.Add(Me.s_departmentid)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.s_sectionname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.s_sectionid)
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
        's_yearlevel
        '
        Me.s_yearlevel.Animated = True
        Me.s_yearlevel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.s_yearlevel.DefaultText = ""
        Me.s_yearlevel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.s_yearlevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.s_yearlevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_yearlevel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_yearlevel.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.s_yearlevel.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.s_yearlevel.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_yearlevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.s_yearlevel.HoverState.BorderColor = System.Drawing.Color.Black
        Me.s_yearlevel.Location = New System.Drawing.Point(150, 192)
        Me.s_yearlevel.Name = "s_yearlevel"
        Me.s_yearlevel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.s_yearlevel.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.s_yearlevel.PlaceholderText = "Edit Year Level"
        Me.s_yearlevel.SelectedText = ""
        Me.s_yearlevel.Size = New System.Drawing.Size(129, 23)
        Me.s_yearlevel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.s_yearlevel.TabIndex = 94
        Me.s_yearlevel.TextOffset = New System.Drawing.Point(-5, 1)
        '
        's_departmentid
        '
        Me.s_departmentid.Animated = True
        Me.s_departmentid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.s_departmentid.DefaultText = ""
        Me.s_departmentid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.s_departmentid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.s_departmentid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_departmentid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_departmentid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.s_departmentid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.s_departmentid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_departmentid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.s_departmentid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.s_departmentid.Location = New System.Drawing.Point(150, 148)
        Me.s_departmentid.Name = "s_departmentid"
        Me.s_departmentid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.s_departmentid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.s_departmentid.PlaceholderText = "Edit ID"
        Me.s_departmentid.SelectedText = ""
        Me.s_departmentid.Size = New System.Drawing.Size(129, 23)
        Me.s_departmentid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.s_departmentid.TabIndex = 93
        Me.s_departmentid.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(145, 27)
        Me.Guna2HtmlLabel1.TabIndex = 74
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Sections Details"
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
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(71, 19)
        Me.Guna2HtmlLabel7.TabIndex = 87
        Me.Guna2HtmlLabel7.TabStop = False
        Me.Guna2HtmlLabel7.Text = "Year Level : "
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
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(98, 19)
        Me.Guna2HtmlLabel4.TabIndex = 83
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Department ID : "
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_sectionname
        '
        Me.s_sectionname.Animated = True
        Me.s_sectionname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.s_sectionname.DefaultText = ""
        Me.s_sectionname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.s_sectionname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.s_sectionname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_sectionname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_sectionname.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.s_sectionname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.s_sectionname.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_sectionname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.s_sectionname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.s_sectionname.Location = New System.Drawing.Point(150, 104)
        Me.s_sectionname.Name = "s_sectionname"
        Me.s_sectionname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.s_sectionname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.s_sectionname.PlaceholderText = "Edit Name"
        Me.s_sectionname.SelectedText = ""
        Me.s_sectionname.Size = New System.Drawing.Size(129, 23)
        Me.s_sectionname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.s_sectionname.TabIndex = 82
        Me.s_sectionname.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(95, 19)
        Me.Guna2HtmlLabel3.TabIndex = 81
        Me.Guna2HtmlLabel3.TabStop = False
        Me.Guna2HtmlLabel3.Text = "Section Name : "
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        's_sectionid
        '
        Me.s_sectionid.Animated = True
        Me.s_sectionid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.s_sectionid.DefaultText = ""
        Me.s_sectionid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.s_sectionid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.s_sectionid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_sectionid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.s_sectionid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.s_sectionid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.s_sectionid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s_sectionid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.s_sectionid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.s_sectionid.Location = New System.Drawing.Point(150, 65)
        Me.s_sectionid.Name = "s_sectionid"
        Me.s_sectionid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.s_sectionid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.s_sectionid.PlaceholderText = "Edit ID"
        Me.s_sectionid.SelectedText = ""
        Me.s_sectionid.Size = New System.Drawing.Size(129, 23)
        Me.s_sectionid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.s_sectionid.TabIndex = 80
        Me.s_sectionid.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(72, 19)
        Me.Guna2HtmlLabel5.TabIndex = 78
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Section ID :"
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
        'SECTIONSTABLE
        '
        Me.SECTIONSTABLE.AllowUserToResizeColumns = False
        Me.SECTIONSTABLE.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SECTIONSTABLE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SECTIONSTABLE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SECTIONSTABLE.ColumnHeadersHeight = 50
        Me.SECTIONSTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SECTIONSTABLE.DefaultCellStyle = DataGridViewCellStyle3
        Me.SECTIONSTABLE.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SECTIONSTABLE.Location = New System.Drawing.Point(40, 23)
        Me.SECTIONSTABLE.MultiSelect = False
        Me.SECTIONSTABLE.Name = "SECTIONSTABLE"
        Me.SECTIONSTABLE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SECTIONSTABLE.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.SECTIONSTABLE.RowHeadersVisible = False
        Me.SECTIONSTABLE.RowHeadersWidth = 51
        Me.SECTIONSTABLE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SECTIONSTABLE.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.SECTIONSTABLE.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SECTIONSTABLE.RowTemplate.Height = 35
        Me.SECTIONSTABLE.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SECTIONSTABLE.Size = New System.Drawing.Size(864, 224)
        Me.SECTIONSTABLE.TabIndex = 88
        Me.SECTIONSTABLE.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.SECTIONSTABLE.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.SECTIONSTABLE.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.SECTIONSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.SECTIONSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.SECTIONSTABLE.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.SECTIONSTABLE.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SECTIONSTABLE.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SECTIONSTABLE.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.SECTIONSTABLE.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SECTIONSTABLE.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SECTIONSTABLE.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.SECTIONSTABLE.ThemeStyle.HeaderStyle.Height = 50
        Me.SECTIONSTABLE.ThemeStyle.ReadOnly = False
        Me.SECTIONSTABLE.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.SECTIONSTABLE.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SECTIONSTABLE.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SECTIONSTABLE.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.SECTIONSTABLE.ThemeStyle.RowsStyle.Height = 35
        Me.SECTIONSTABLE.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SECTIONSTABLE.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SECTION_PANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 574)
        Me.Controls.Add(Me.admin_faculty)
        Me.Name = "SECTION_PANEL"
        Me.Text = "SECTION_PANEL"
        Me.admin_faculty.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.SECTIONSTABLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents admin_faculty As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents sectionupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents sectiondelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents sectionaddnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents s_yearlevel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents s_departmentid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents s_sectionname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents s_sectionid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents SECTIONSTABLE As Guna.UI2.WinForms.Guna2DataGridView
End Class
