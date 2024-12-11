<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CLASSPANEL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.admin_faculty = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txtprofessorid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtacademicyear = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbterm = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtcourseid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtclassid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.CLASSTABLE = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.classupdate = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_profdelete = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_addnewprof = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_faculty.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.CLASSTABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admin_faculty
        '
        Me.admin_faculty.BackColor = System.Drawing.Color.Black
        Me.admin_faculty.BorderRadius = 10
        Me.admin_faculty.Controls.Add(Me.classupdate)
        Me.admin_faculty.Controls.Add(Me.admin_profdelete)
        Me.admin_faculty.Controls.Add(Me.admin_addnewprof)
        Me.admin_faculty.Controls.Add(Me.Guna2ShadowPanel1)
        Me.admin_faculty.Controls.Add(Me.CLASSTABLE)
        Me.admin_faculty.CustomizableEdges.BottomLeft = False
        Me.admin_faculty.CustomizableEdges.TopLeft = False
        Me.admin_faculty.CustomizableEdges.TopRight = False
        Me.admin_faculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_faculty.Location = New System.Drawing.Point(74, 32)
        Me.admin_faculty.Name = "admin_faculty"
        Me.admin_faculty.Size = New System.Drawing.Size(938, 580)
        Me.admin_faculty.TabIndex = 84
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.AutoScroll = True
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtprofessorid)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtacademicyear)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2ShadowPanel1.Controls.Add(Me.cbterm)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtcourseid)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtclassid)
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
        'txtprofessorid
        '
        Me.txtprofessorid.Animated = True
        Me.txtprofessorid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtprofessorid.DefaultText = ""
        Me.txtprofessorid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtprofessorid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtprofessorid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtprofessorid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtprofessorid.Enabled = False
        Me.txtprofessorid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtprofessorid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtprofessorid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprofessorid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtprofessorid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtprofessorid.Location = New System.Drawing.Point(150, 148)
        Me.txtprofessorid.Name = "txtprofessorid"
        Me.txtprofessorid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtprofessorid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtprofessorid.PlaceholderText = "Edit Name"
        Me.txtprofessorid.SelectedText = ""
        Me.txtprofessorid.Size = New System.Drawing.Size(129, 23)
        Me.txtprofessorid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtprofessorid.TabIndex = 93
        Me.txtprofessorid.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'txtacademicyear
        '
        Me.txtacademicyear.Animated = True
        Me.txtacademicyear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtacademicyear.DefaultText = ""
        Me.txtacademicyear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtacademicyear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtacademicyear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtacademicyear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtacademicyear.Enabled = False
        Me.txtacademicyear.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtacademicyear.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtacademicyear.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacademicyear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtacademicyear.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtacademicyear.Location = New System.Drawing.Point(150, 229)
        Me.txtacademicyear.Name = "txtacademicyear"
        Me.txtacademicyear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtacademicyear.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtacademicyear.PlaceholderText = "Academic Year"
        Me.txtacademicyear.SelectedText = ""
        Me.txtacademicyear.Size = New System.Drawing.Size(129, 23)
        Me.txtacademicyear.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtacademicyear.TabIndex = 90
        Me.txtacademicyear.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(116, 27)
        Me.Guna2HtmlLabel1.TabIndex = 74
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Class Details"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomLeft
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel8.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel8.IsSelectionEnabled = False
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(25, 233)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(100, 19)
        Me.Guna2HtmlLabel8.TabIndex = 89
        Me.Guna2HtmlLabel8.TabStop = False
        Me.Guna2HtmlLabel8.Text = "Academic Year :"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbterm
        '
        Me.cbterm.BackColor = System.Drawing.Color.Transparent
        Me.cbterm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbterm.Enabled = False
        Me.cbterm.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cbterm.FocusedColor = System.Drawing.Color.Black
        Me.cbterm.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.cbterm.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cbterm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.cbterm.ItemHeight = 20
        Me.cbterm.Items.AddRange(New Object() {"MIDTERM", "FINAL"})
        Me.cbterm.Location = New System.Drawing.Point(151, 183)
        Me.cbterm.Name = "cbterm"
        Me.cbterm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbterm.Size = New System.Drawing.Size(129, 26)
        Me.cbterm.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cbterm.TabIndex = 88
        Me.cbterm.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(40, 19)
        Me.Guna2HtmlLabel7.TabIndex = 87
        Me.Guna2HtmlLabel7.TabStop = False
        Me.Guna2HtmlLabel7.Text = "Term : "
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
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(77, 19)
        Me.Guna2HtmlLabel4.TabIndex = 83
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Professor ID"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcourseid
        '
        Me.txtcourseid.Animated = True
        Me.txtcourseid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcourseid.DefaultText = ""
        Me.txtcourseid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcourseid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcourseid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourseid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcourseid.Enabled = False
        Me.txtcourseid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtcourseid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtcourseid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcourseid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtcourseid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtcourseid.Location = New System.Drawing.Point(150, 104)
        Me.txtcourseid.Name = "txtcourseid"
        Me.txtcourseid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcourseid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtcourseid.PlaceholderText = "Edit Name"
        Me.txtcourseid.SelectedText = ""
        Me.txtcourseid.Size = New System.Drawing.Size(129, 23)
        Me.txtcourseid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtcourseid.TabIndex = 82
        Me.txtcourseid.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(68, 19)
        Me.Guna2HtmlLabel3.TabIndex = 81
        Me.Guna2HtmlLabel3.TabStop = False
        Me.Guna2HtmlLabel3.Text = "Course ID :"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtclassid
        '
        Me.txtclassid.Animated = True
        Me.txtclassid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtclassid.DefaultText = ""
        Me.txtclassid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtclassid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtclassid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtclassid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtclassid.Enabled = False
        Me.txtclassid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtclassid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtclassid.Font = New System.Drawing.Font("Segoe UI Variable Text", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclassid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.txtclassid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtclassid.Location = New System.Drawing.Point(150, 65)
        Me.txtclassid.Name = "txtclassid"
        Me.txtclassid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtclassid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.txtclassid.PlaceholderText = "Edit ID"
        Me.txtclassid.SelectedText = ""
        Me.txtclassid.Size = New System.Drawing.Size(129, 23)
        Me.txtclassid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtclassid.TabIndex = 80
        Me.txtclassid.TextOffset = New System.Drawing.Point(-5, 1)
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
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(57, 19)
        Me.Guna2HtmlLabel5.TabIndex = 78
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Class ID :"
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
        'CLASSTABLE
        '
        Me.CLASSTABLE.AllowUserToResizeColumns = False
        Me.CLASSTABLE.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLASSTABLE.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLASSTABLE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CLASSTABLE.ColumnHeadersHeight = 50
        Me.CLASSTABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLASSTABLE.DefaultCellStyle = DataGridViewCellStyle3
        Me.CLASSTABLE.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLASSTABLE.Location = New System.Drawing.Point(40, 23)
        Me.CLASSTABLE.MultiSelect = False
        Me.CLASSTABLE.Name = "CLASSTABLE"
        Me.CLASSTABLE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLASSTABLE.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.CLASSTABLE.RowHeadersVisible = False
        Me.CLASSTABLE.RowHeadersWidth = 51
        Me.CLASSTABLE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CLASSTABLE.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.CLASSTABLE.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CLASSTABLE.RowTemplate.Height = 35
        Me.CLASSTABLE.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CLASSTABLE.Size = New System.Drawing.Size(864, 224)
        Me.CLASSTABLE.TabIndex = 88
        Me.CLASSTABLE.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.CLASSTABLE.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.CLASSTABLE.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.CLASSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.CLASSTABLE.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.CLASSTABLE.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.CLASSTABLE.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLASSTABLE.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLASSTABLE.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CLASSTABLE.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLASSTABLE.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.CLASSTABLE.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.CLASSTABLE.ThemeStyle.HeaderStyle.Height = 50
        Me.CLASSTABLE.ThemeStyle.ReadOnly = False
        Me.CLASSTABLE.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.CLASSTABLE.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.CLASSTABLE.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLASSTABLE.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.CLASSTABLE.ThemeStyle.RowsStyle.Height = 35
        Me.CLASSTABLE.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLASSTABLE.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'classupdate
        '
        Me.classupdate.Animated = True
        Me.classupdate.AnimatedGIF = True
        Me.classupdate.BackColor = System.Drawing.Color.Transparent
        Me.classupdate.BorderRadius = 10
        Me.classupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.classupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.classupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.classupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.classupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.classupdate.FillColor = System.Drawing.Color.DarkGreen
        Me.classupdate.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classupdate.ForeColor = System.Drawing.Color.White
        Me.classupdate.Image = Global.OOP_FinalProject.My.Resources.Resources.update
        Me.classupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.classupdate.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.classupdate.ImageSize = New System.Drawing.Size(23, 23)
        Me.classupdate.Location = New System.Drawing.Point(792, 394)
        Me.classupdate.Name = "classupdate"
        Me.classupdate.Size = New System.Drawing.Size(112, 45)
        Me.classupdate.TabIndex = 91
        Me.classupdate.Text = "Update"
        Me.classupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.classupdate.TextOffset = New System.Drawing.Point(-2, 0)
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
        Me.admin_profdelete.Location = New System.Drawing.Point(792, 458)
        Me.admin_profdelete.Name = "admin_profdelete"
        Me.admin_profdelete.Size = New System.Drawing.Size(112, 45)
        Me.admin_profdelete.TabIndex = 92
        Me.admin_profdelete.Text = "Delete"
        Me.admin_profdelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.admin_profdelete.TextOffset = New System.Drawing.Point(-5, 0)
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
        Me.admin_addnewprof.Location = New System.Drawing.Point(792, 331)
        Me.admin_addnewprof.Name = "admin_addnewprof"
        Me.admin_addnewprof.Size = New System.Drawing.Size(112, 45)
        Me.admin_addnewprof.TabIndex = 90
        Me.admin_addnewprof.Text = "Add New"
        Me.admin_addnewprof.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.admin_addnewprof.TextOffset = New System.Drawing.Point(0, -1)
        '
        'CLASSPANEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1096, 624)
        Me.Controls.Add(Me.admin_faculty)
        Me.Name = "CLASSPANEL"
        Me.Text = "CLASSPANEL"
        Me.admin_faculty.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.CLASSTABLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents admin_faculty As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents classupdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_profdelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_addnewprof As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents txtacademicyear As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtcourseid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtclassid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents CLASSTABLE As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtprofessorid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbterm As Guna.UI2.WinForms.Guna2ComboBox
End Class
