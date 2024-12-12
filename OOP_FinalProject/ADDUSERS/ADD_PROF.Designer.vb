<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADD_PROFESSOR
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.admin_add = New Guna.UI2.WinForms.Guna2Button()
        Me.admin_txtprofid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_txtproffirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_txtproflastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_txtprofmiddlename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_txtcontactnum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Department = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_comboxstatus = New System.Windows.Forms.ComboBox()
        Me.admin_comboxdeptid = New System.Windows.Forms.ComboBox()
        Me.admin_txtaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_txtpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.admin_txtemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(842, -1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'admin_add
        '
        Me.admin_add.Animated = True
        Me.admin_add.AnimatedGIF = True
        Me.admin_add.BackColor = System.Drawing.Color.Transparent
        Me.admin_add.BorderRadius = 10
        Me.admin_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.admin_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.admin_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.admin_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.admin_add.FillColor = System.Drawing.Color.Green
        Me.admin_add.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_add.ForeColor = System.Drawing.Color.White
        Me.admin_add.Image = Global.OOP_FinalProject.My.Resources.Resources.Plus
        Me.admin_add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.admin_add.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.admin_add.ImageSize = New System.Drawing.Size(25, 25)
        Me.admin_add.Location = New System.Drawing.Point(684, 248)
        Me.admin_add.Name = "admin_add"
        Me.admin_add.Size = New System.Drawing.Size(112, 45)
        Me.admin_add.TabIndex = 91
        Me.admin_add.Text = "Add"
        Me.admin_add.TextOffset = New System.Drawing.Point(4, 0)
        '
        'admin_txtprofid
        '
        Me.admin_txtprofid.Animated = True
        Me.admin_txtprofid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtprofid.DefaultText = ""
        Me.admin_txtprofid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtprofid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtprofid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtprofid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtprofid.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtprofid.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtprofid.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtprofid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtprofid.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtprofid.Location = New System.Drawing.Point(265, 131)
        Me.admin_txtprofid.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtprofid.Name = "admin_txtprofid"
        Me.admin_txtprofid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtprofid.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtprofid.PlaceholderText = "dept-001"
        Me.admin_txtprofid.SelectedText = ""
        Me.admin_txtprofid.Size = New System.Drawing.Size(166, 34)
        Me.admin_txtprofid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtprofid.TabIndex = 93
        Me.admin_txtprofid.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel5.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel5.IsSelectionEnabled = False
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(137, 145)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(105, 23)
        Me.Guna2HtmlLabel5.TabIndex = 92
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Professor ID : "
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_txtproffirstname
        '
        Me.admin_txtproffirstname.Animated = True
        Me.admin_txtproffirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtproffirstname.DefaultText = ""
        Me.admin_txtproffirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtproffirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtproffirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtproffirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtproffirstname.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtproffirstname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtproffirstname.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtproffirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtproffirstname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtproffirstname.Location = New System.Drawing.Point(265, 178)
        Me.admin_txtproffirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtproffirstname.Name = "admin_txtproffirstname"
        Me.admin_txtproffirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtproffirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtproffirstname.PlaceholderText = "First name"
        Me.admin_txtproffirstname.SelectedText = ""
        Me.admin_txtproffirstname.Size = New System.Drawing.Size(166, 31)
        Me.admin_txtproffirstname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtproffirstname.TabIndex = 95
        Me.admin_txtproffirstname.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel1.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(73, 189)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(169, 23)
        Me.Guna2HtmlLabel1.TabIndex = 94
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Professor First Name :"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_txtproflastname
        '
        Me.admin_txtproflastname.Animated = True
        Me.admin_txtproflastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtproflastname.DefaultText = ""
        Me.admin_txtproflastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtproflastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtproflastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtproflastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtproflastname.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtproflastname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtproflastname.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtproflastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtproflastname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtproflastname.Location = New System.Drawing.Point(265, 217)
        Me.admin_txtproflastname.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtproflastname.Name = "admin_txtproflastname"
        Me.admin_txtproflastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtproflastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtproflastname.PlaceholderText = "Last name"
        Me.admin_txtproflastname.SelectedText = ""
        Me.admin_txtproflastname.Size = New System.Drawing.Size(166, 31)
        Me.admin_txtproflastname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtproflastname.TabIndex = 97
        Me.admin_txtproflastname.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel2.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(76, 228)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(166, 23)
        Me.Guna2HtmlLabel2.TabIndex = 96
        Me.Guna2HtmlLabel2.TabStop = False
        Me.Guna2HtmlLabel2.Text = "Professor Last Name :"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_txtprofmiddlename
        '
        Me.admin_txtprofmiddlename.Animated = True
        Me.admin_txtprofmiddlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtprofmiddlename.DefaultText = ""
        Me.admin_txtprofmiddlename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtprofmiddlename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtprofmiddlename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtprofmiddlename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtprofmiddlename.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtprofmiddlename.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtprofmiddlename.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtprofmiddlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtprofmiddlename.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtprofmiddlename.Location = New System.Drawing.Point(265, 261)
        Me.admin_txtprofmiddlename.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtprofmiddlename.Name = "admin_txtprofmiddlename"
        Me.admin_txtprofmiddlename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtprofmiddlename.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtprofmiddlename.PlaceholderText = "Middle name"
        Me.admin_txtprofmiddlename.SelectedText = ""
        Me.admin_txtprofmiddlename.Size = New System.Drawing.Size(166, 34)
        Me.admin_txtprofmiddlename.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtprofmiddlename.TabIndex = 99
        Me.admin_txtprofmiddlename.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel3.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel3.IsSelectionEnabled = False
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(54, 272)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(188, 23)
        Me.Guna2HtmlLabel3.TabIndex = 98
        Me.Guna2HtmlLabel3.TabStop = False
        Me.Guna2HtmlLabel3.Text = "Professor Middle Name :"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel8.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel8.IsSelectionEnabled = False
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(102, 394)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(140, 23)
        Me.Guna2HtmlLabel8.TabIndex = 103
        Me.Guna2HtmlLabel8.TabStop = False
        Me.Guna2HtmlLabel8.Text = "Contact Number :"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_txtcontactnum
        '
        Me.admin_txtcontactnum.Animated = True
        Me.admin_txtcontactnum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtcontactnum.DefaultText = ""
        Me.admin_txtcontactnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtcontactnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtcontactnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtcontactnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtcontactnum.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtcontactnum.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtcontactnum.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtcontactnum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtcontactnum.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtcontactnum.Location = New System.Drawing.Point(265, 383)
        Me.admin_txtcontactnum.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtcontactnum.Name = "admin_txtcontactnum"
        Me.admin_txtcontactnum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtcontactnum.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtcontactnum.PlaceholderText = "000-0000-000"
        Me.admin_txtcontactnum.SelectedText = ""
        Me.admin_txtcontactnum.Size = New System.Drawing.Size(166, 34)
        Me.admin_txtcontactnum.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtcontactnum.TabIndex = 106
        Me.admin_txtcontactnum.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel4.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel4.IsSelectionEnabled = False
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(182, 511)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(60, 23)
        Me.Guna2HtmlLabel4.TabIndex = 107
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Status : "
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Department
        '
        Me.Department.BackColor = System.Drawing.Color.Transparent
        Me.Department.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Department.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Department.IsContextMenuEnabled = False
        Me.Department.IsSelectionEnabled = False
        Me.Department.Location = New System.Drawing.Point(120, 334)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(122, 23)
        Me.Department.TabIndex = 101
        Me.Department.TabStop = False
        Me.Department.Text = "Department ID:"
        Me.Department.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_comboxstatus
        '
        Me.admin_comboxstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.admin_comboxstatus.FormattingEnabled = True
        Me.admin_comboxstatus.Items.AddRange(New Object() {"ACTIVE", "INACTIVE"})
        Me.admin_comboxstatus.Location = New System.Drawing.Point(265, 513)
        Me.admin_comboxstatus.Name = "admin_comboxstatus"
        Me.admin_comboxstatus.Size = New System.Drawing.Size(166, 21)
        Me.admin_comboxstatus.TabIndex = 118
        '
        'admin_comboxdeptid
        '
        Me.admin_comboxdeptid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.admin_comboxdeptid.FormattingEnabled = True
        Me.admin_comboxdeptid.Location = New System.Drawing.Point(265, 334)
        Me.admin_comboxdeptid.Name = "admin_comboxdeptid"
        Me.admin_comboxdeptid.Size = New System.Drawing.Size(166, 21)
        Me.admin_comboxdeptid.TabIndex = 119
        '
        'admin_txtaddress
        '
        Me.admin_txtaddress.Animated = True
        Me.admin_txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtaddress.DefaultText = ""
        Me.admin_txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtaddress.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtaddress.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtaddress.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtaddress.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtaddress.Location = New System.Drawing.Point(265, 442)
        Me.admin_txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtaddress.Name = "admin_txtaddress"
        Me.admin_txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtaddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtaddress.PlaceholderText = "Enter Addrress"
        Me.admin_txtaddress.SelectedText = ""
        Me.admin_txtaddress.Size = New System.Drawing.Size(166, 34)
        Me.admin_txtaddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtaddress.TabIndex = 121
        Me.admin_txtaddress.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel6.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel6.IsSelectionEnabled = False
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(166, 453)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(76, 23)
        Me.Guna2HtmlLabel6.TabIndex = 120
        Me.Guna2HtmlLabel6.TabStop = False
        Me.Guna2HtmlLabel6.Text = "Address: :"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_txtpass
        '
        Me.admin_txtpass.Animated = True
        Me.admin_txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtpass.DefaultText = ""
        Me.admin_txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtpass.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtpass.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtpass.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtpass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtpass.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtpass.Location = New System.Drawing.Point(630, 178)
        Me.admin_txtpass.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtpass.Name = "admin_txtpass"
        Me.admin_txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtpass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtpass.PlaceholderText = "Enter password"
        Me.admin_txtpass.SelectedText = ""
        Me.admin_txtpass.Size = New System.Drawing.Size(166, 31)
        Me.admin_txtpass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtpass.TabIndex = 125
        Me.admin_txtpass.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel7.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel7.IsSelectionEnabled = False
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(524, 186)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(83, 23)
        Me.Guna2HtmlLabel7.TabIndex = 124
        Me.Guna2HtmlLabel7.TabStop = False
        Me.Guna2HtmlLabel7.Text = "Password :"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'admin_txtemail
        '
        Me.admin_txtemail.Animated = True
        Me.admin_txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.admin_txtemail.DefaultText = ""
        Me.admin_txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.admin_txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.admin_txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.admin_txtemail.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.admin_txtemail.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtemail.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_txtemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.admin_txtemail.HoverState.BorderColor = System.Drawing.Color.Black
        Me.admin_txtemail.Location = New System.Drawing.Point(630, 131)
        Me.admin_txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.admin_txtemail.Name = "admin_txtemail"
        Me.admin_txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.admin_txtemail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.admin_txtemail.PlaceholderText = "@plpasig.edu"
        Me.admin_txtemail.SelectedText = ""
        Me.admin_txtemail.Size = New System.Drawing.Size(166, 34)
        Me.admin_txtemail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.admin_txtemail.TabIndex = 123
        Me.admin_txtemail.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel9.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel9.IsSelectionEnabled = False
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(557, 142)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(50, 23)
        Me.Guna2HtmlLabel9.TabIndex = 122
        Me.Guna2HtmlLabel9.TabStop = False
        Me.Guna2HtmlLabel9.Text = "Email : "
        Me.Guna2HtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Segoe UI Variable Display", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Turquoise
        Me.Guna2HtmlLabel10.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel10.IsSelectionEnabled = False
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(521, 70)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(275, 38)
        Me.Guna2HtmlLabel10.TabIndex = 126
        Me.Guna2HtmlLabel10.TabStop = False
        Me.Guna2HtmlLabel10.Text = "Account Credentials :"
        Me.Guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Segoe UI Variable Display", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.ForeColor = System.Drawing.Color.Turquoise
        Me.Guna2HtmlLabel11.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel11.IsSelectionEnabled = False
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(54, 70)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(292, 38)
        Me.Guna2HtmlLabel11.TabIndex = 127
        Me.Guna2HtmlLabel11.TabStop = False
        Me.Guna2HtmlLabel11.Text = "Professor Information :"
        Me.Guna2HtmlLabel11.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add_Professor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 644)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.admin_txtpass)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.admin_txtemail)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.admin_txtaddress)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.admin_comboxdeptid)
        Me.Controls.Add(Me.admin_comboxstatus)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.admin_txtcontactnum)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.Department)
        Me.Controls.Add(Me.admin_txtprofmiddlename)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.admin_txtproflastname)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.admin_txtproffirstname)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.admin_txtprofid)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.admin_add)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Professor"
        Me.Text = "Add_Professor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents admin_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents admin_txtproffirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_txtprofid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_txtproflastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_txtprofmiddlename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_txtcontactnum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Department As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_comboxstatus As ComboBox
    Friend WithEvents admin_comboxdeptid As ComboBox
    Friend WithEvents admin_txtaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_txtpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents admin_txtemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
