<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Professor
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
        Me.AddProfessorButton = New Guna.UI2.WinForms.Guna2Button()
        Me.prof_ID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_middlename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_AY = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.prof_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.prof_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DEPARTMENTID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(460, -1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'AddProfessorButton
        '
        Me.AddProfessorButton.Animated = True
        Me.AddProfessorButton.AnimatedGIF = True
        Me.AddProfessorButton.BackColor = System.Drawing.Color.Transparent
        Me.AddProfessorButton.BorderRadius = 10
        Me.AddProfessorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddProfessorButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddProfessorButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddProfessorButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddProfessorButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddProfessorButton.FillColor = System.Drawing.Color.Green
        Me.AddProfessorButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProfessorButton.ForeColor = System.Drawing.Color.White
        Me.AddProfessorButton.Image = Global.OOP_FinalProject.My.Resources.Resources.Plus
        Me.AddProfessorButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AddProfessorButton.ImageOffset = New System.Drawing.Point(-3, 0)
        Me.AddProfessorButton.ImageSize = New System.Drawing.Size(25, 25)
        Me.AddProfessorButton.Location = New System.Drawing.Point(46, 611)
        Me.AddProfessorButton.Name = "AddProfessorButton"
        Me.AddProfessorButton.Size = New System.Drawing.Size(412, 45)
        Me.AddProfessorButton.TabIndex = 91
        Me.AddProfessorButton.Text = "Add New Professor"
        Me.AddProfessorButton.TextOffset = New System.Drawing.Point(4, 0)
        '
        'prof_ID
        '
        Me.prof_ID.Animated = True
        Me.prof_ID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prof_ID.DefaultText = ""
        Me.prof_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prof_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prof_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_ID.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_ID.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_ID.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_ID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_ID.HoverState.BorderColor = System.Drawing.Color.Black
        Me.prof_ID.Location = New System.Drawing.Point(268, 113)
        Me.prof_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.prof_ID.Name = "prof_ID"
        Me.prof_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prof_ID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.prof_ID.PlaceholderText = "Prof-001"
        Me.prof_ID.SelectedText = ""
        Me.prof_ID.Size = New System.Drawing.Size(166, 34)
        Me.prof_ID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_ID.TabIndex = 93
        Me.prof_ID.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel5.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel5.IsSelectionEnabled = False
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(66, 126)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(105, 23)
        Me.Guna2HtmlLabel5.TabIndex = 92
        Me.Guna2HtmlLabel5.TabStop = False
        Me.Guna2HtmlLabel5.Text = "Professor ID : "
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prof_firstname
        '
        Me.prof_firstname.Animated = True
        Me.prof_firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prof_firstname.DefaultText = ""
        Me.prof_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prof_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prof_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_firstname.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_firstname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_firstname.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_firstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_firstname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.prof_firstname.Location = New System.Drawing.Point(268, 170)
        Me.prof_firstname.Margin = New System.Windows.Forms.Padding(4)
        Me.prof_firstname.Name = "prof_firstname"
        Me.prof_firstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prof_firstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.prof_firstname.PlaceholderText = "First name"
        Me.prof_firstname.SelectedText = ""
        Me.prof_firstname.Size = New System.Drawing.Size(166, 31)
        Me.prof_firstname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_firstname.TabIndex = 95
        Me.prof_firstname.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel1.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(66, 180)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(169, 23)
        Me.Guna2HtmlLabel1.TabIndex = 94
        Me.Guna2HtmlLabel1.TabStop = False
        Me.Guna2HtmlLabel1.Text = "Professor First Name :"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prof_lastname
        '
        Me.prof_lastname.Animated = True
        Me.prof_lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prof_lastname.DefaultText = ""
        Me.prof_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prof_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prof_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_lastname.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_lastname.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_lastname.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_lastname.HoverState.BorderColor = System.Drawing.Color.Black
        Me.prof_lastname.Location = New System.Drawing.Point(268, 224)
        Me.prof_lastname.Margin = New System.Windows.Forms.Padding(4)
        Me.prof_lastname.Name = "prof_lastname"
        Me.prof_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prof_lastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.prof_lastname.PlaceholderText = "Last name"
        Me.prof_lastname.SelectedText = ""
        Me.prof_lastname.Size = New System.Drawing.Size(166, 31)
        Me.prof_lastname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_lastname.TabIndex = 97
        Me.prof_lastname.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel2.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(66, 234)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(166, 23)
        Me.Guna2HtmlLabel2.TabIndex = 96
        Me.Guna2HtmlLabel2.TabStop = False
        Me.Guna2HtmlLabel2.Text = "Professor Last Name :"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prof_middlename
        '
        Me.prof_middlename.Animated = True
        Me.prof_middlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prof_middlename.DefaultText = ""
        Me.prof_middlename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prof_middlename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prof_middlename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_middlename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_middlename.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_middlename.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_middlename.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_middlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_middlename.HoverState.BorderColor = System.Drawing.Color.Black
        Me.prof_middlename.Location = New System.Drawing.Point(268, 278)
        Me.prof_middlename.Margin = New System.Windows.Forms.Padding(4)
        Me.prof_middlename.Name = "prof_middlename"
        Me.prof_middlename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prof_middlename.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.prof_middlename.PlaceholderText = "Middle name"
        Me.prof_middlename.SelectedText = ""
        Me.prof_middlename.Size = New System.Drawing.Size(166, 34)
        Me.prof_middlename.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_middlename.TabIndex = 99
        Me.prof_middlename.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel3.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel3.IsSelectionEnabled = False
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(66, 291)
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
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(66, 402)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(124, 23)
        Me.Guna2HtmlLabel8.TabIndex = 103
        Me.Guna2HtmlLabel8.TabStop = False
        Me.Guna2HtmlLabel8.Text = "Academic Year :"
        Me.Guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prof_AY
        '
        Me.prof_AY.Animated = True
        Me.prof_AY.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prof_AY.DefaultText = ""
        Me.prof_AY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prof_AY.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prof_AY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_AY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_AY.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_AY.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_AY.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_AY.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_AY.HoverState.BorderColor = System.Drawing.Color.Black
        Me.prof_AY.Location = New System.Drawing.Point(268, 389)
        Me.prof_AY.Margin = New System.Windows.Forms.Padding(4)
        Me.prof_AY.Name = "prof_AY"
        Me.prof_AY.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prof_AY.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.prof_AY.PlaceholderText = "yyyy-yyyy"
        Me.prof_AY.SelectedText = ""
        Me.prof_AY.Size = New System.Drawing.Size(166, 34)
        Me.prof_AY.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_AY.TabIndex = 106
        Me.prof_AY.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel4.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel4.IsSelectionEnabled = False
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(66, 459)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(115, 23)
        Me.Guna2HtmlLabel4.TabIndex = 107
        Me.Guna2HtmlLabel4.TabStop = False
        Me.Guna2HtmlLabel4.Text = "Email Address : "
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prof_email
        '
        Me.prof_email.Animated = True
        Me.prof_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prof_email.DefaultText = ""
        Me.prof_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prof_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prof_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_email.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_email.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_email.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_email.HoverState.BorderColor = System.Drawing.Color.Black
        Me.prof_email.Location = New System.Drawing.Point(268, 446)
        Me.prof_email.Margin = New System.Windows.Forms.Padding(4)
        Me.prof_email.Name = "prof_email"
        Me.prof_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prof_email.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.prof_email.PlaceholderText = "Email address"
        Me.prof_email.SelectedText = ""
        Me.prof_email.Size = New System.Drawing.Size(166, 34)
        Me.prof_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_email.TabIndex = 108
        Me.prof_email.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'prof_password
        '
        Me.prof_password.Animated = True
        Me.prof_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.prof_password.DefaultText = ""
        Me.prof_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.prof_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.prof_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.prof_password.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.prof_password.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.prof_password.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prof_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.prof_password.HoverState.BorderColor = System.Drawing.Color.Black
        Me.prof_password.Location = New System.Drawing.Point(268, 503)
        Me.prof_password.Margin = New System.Windows.Forms.Padding(4)
        Me.prof_password.Name = "prof_password"
        Me.prof_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.prof_password.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.prof_password.PlaceholderText = "Enter password"
        Me.prof_password.SelectedText = ""
        Me.prof_password.Size = New System.Drawing.Size(166, 34)
        Me.prof_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.prof_password.TabIndex = 110
        Me.prof_password.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel6.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel6.IsSelectionEnabled = False
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(66, 516)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(83, 23)
        Me.Guna2HtmlLabel6.TabIndex = 109
        Me.Guna2HtmlLabel6.TabStop = False
        Me.Guna2HtmlLabel6.Text = "Password :"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DEPARTMENTID
        '
        Me.DEPARTMENTID.BackColor = System.Drawing.Color.Transparent
        Me.DEPARTMENTID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DEPARTMENTID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DEPARTMENTID.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.DEPARTMENTID.FocusedColor = System.Drawing.Color.Black
        Me.DEPARTMENTID.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.DEPARTMENTID.Font = New System.Drawing.Font("Segoe UI Variable Text", 10.0!, System.Drawing.FontStyle.Bold)
        Me.DEPARTMENTID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.DEPARTMENTID.ItemHeight = 25
        Me.DEPARTMENTID.Items.AddRange(New Object() {"CCS", "EDUC", "NURSING"})
        Me.DEPARTMENTID.Location = New System.Drawing.Point(268, 335)
        Me.DEPARTMENTID.Name = "DEPARTMENTID"
        Me.DEPARTMENTID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DEPARTMENTID.Size = New System.Drawing.Size(166, 31)
        Me.DEPARTMENTID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.DEPARTMENTID.TabIndex = 112
        Me.DEPARTMENTID.TextOffset = New System.Drawing.Point(-5, 1)
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Guna2HtmlLabel9.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel9.IsSelectionEnabled = False
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(66, 345)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(105, 23)
        Me.Guna2HtmlLabel9.TabIndex = 111
        Me.Guna2HtmlLabel9.TabStop = False
        Me.Guna2HtmlLabel9.Text = "Department : "
        Me.Guna2HtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Segoe UI Variable Display", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(164, 53)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(157, 38)
        Me.Guna2HtmlLabel10.TabIndex = 114
        Me.Guna2HtmlLabel10.Text = "PROFESSOR"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Firebrick
        Me.Guna2HtmlLabel7.IsContextMenuEnabled = False
        Me.Guna2HtmlLabel7.IsSelectionEnabled = False
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(152, 571)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(169, 20)
        Me.Guna2HtmlLabel7.TabIndex = 113
        Me.Guna2HtmlLabel7.TabStop = False
        Me.Guna2HtmlLabel7.Text = "Please fill in all fields."
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Guna2HtmlLabel7.Visible = False
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Add_Professor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 700)
        Me.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.DEPARTMENTID)
        Me.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Controls.Add(Me.prof_password)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.prof_email)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.prof_AY)
        Me.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Controls.Add(Me.prof_middlename)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.prof_lastname)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.prof_firstname)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.prof_ID)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.AddProfessorButton)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Professor"
        Me.Text = "Add_Professor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents AddProfessorButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents prof_firstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_ID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_middlename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_AY As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents prof_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DEPARTMENTID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
