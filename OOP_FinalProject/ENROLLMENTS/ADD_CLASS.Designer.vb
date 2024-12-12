<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_CLASS
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
        Me.TERM = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ACADEMICYEAR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PROFESSORID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.COURSEID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SECTIONID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cancelNewClass = New Guna.UI2.WinForms.Guna2Button()
        Me.addNewClass = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'TERM
        '
        Me.TERM.BackColor = System.Drawing.Color.Transparent
        Me.TERM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.TERM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TERM.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TERM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TERM.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TERM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.TERM.ItemHeight = 30
        Me.TERM.Items.AddRange(New Object() {"MIDTERM", "FINAL", "" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.TERM.Location = New System.Drawing.Point(252, 293)
        Me.TERM.Name = "TERM"
        Me.TERM.Size = New System.Drawing.Size(140, 36)
        Me.TERM.TabIndex = 104
        '
        'ACADEMICYEAR
        '
        Me.ACADEMICYEAR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ACADEMICYEAR.DefaultText = ""
        Me.ACADEMICYEAR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ACADEMICYEAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ACADEMICYEAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ACADEMICYEAR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ACADEMICYEAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ACADEMICYEAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ACADEMICYEAR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ACADEMICYEAR.Location = New System.Drawing.Point(252, 335)
        Me.ACADEMICYEAR.Name = "ACADEMICYEAR"
        Me.ACADEMICYEAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ACADEMICYEAR.PlaceholderText = ""
        Me.ACADEMICYEAR.SelectedText = ""
        Me.ACADEMICYEAR.Size = New System.Drawing.Size(192, 26)
        Me.ACADEMICYEAR.TabIndex = 103
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(142, 335)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(93, 15)
        Me.Guna2HtmlLabel4.TabIndex = 102
        Me.Guna2HtmlLabel4.Text = "ACADEMIC_YEAR"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(138, 295)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(34, 15)
        Me.Guna2HtmlLabel7.TabIndex = 101
        Me.Guna2HtmlLabel7.Text = "TERM"
        '
        'PROFESSORID
        '
        Me.PROFESSORID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PROFESSORID.DefaultText = ""
        Me.PROFESSORID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PROFESSORID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PROFESSORID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PROFESSORID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PROFESSORID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PROFESSORID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PROFESSORID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PROFESSORID.Location = New System.Drawing.Point(252, 245)
        Me.PROFESSORID.Name = "PROFESSORID"
        Me.PROFESSORID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PROFESSORID.PlaceholderText = ""
        Me.PROFESSORID.SelectedText = ""
        Me.PROFESSORID.Size = New System.Drawing.Size(192, 26)
        Me.PROFESSORID.TabIndex = 100
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(142, 245)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(86, 15)
        Me.Guna2HtmlLabel6.TabIndex = 99
        Me.Guna2HtmlLabel6.Text = "PROFESSOR_ID"
        '
        'COURSEID
        '
        Me.COURSEID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.COURSEID.DefaultText = ""
        Me.COURSEID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.COURSEID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.COURSEID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.COURSEID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.COURSEID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSEID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.COURSEID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSEID.Location = New System.Drawing.Point(252, 204)
        Me.COURSEID.Name = "COURSEID"
        Me.COURSEID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.COURSEID.PlaceholderText = ""
        Me.COURSEID.SelectedText = ""
        Me.COURSEID.Size = New System.Drawing.Size(192, 26)
        Me.COURSEID.TabIndex = 98
        '
        'SECTIONID
        '
        Me.SECTIONID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SECTIONID.DefaultText = ""
        Me.SECTIONID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SECTIONID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SECTIONID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SECTIONID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SECTIONID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SECTIONID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SECTIONID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SECTIONID.Location = New System.Drawing.Point(252, 157)
        Me.SECTIONID.Name = "SECTIONID"
        Me.SECTIONID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SECTIONID.PlaceholderText = ""
        Me.SECTIONID.SelectedText = ""
        Me.SECTIONID.Size = New System.Drawing.Size(192, 26)
        Me.SECTIONID.TabIndex = 97
        '
        'cancelNewClass
        '
        Me.cancelNewClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelNewClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelNewClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelNewClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelNewClass.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelNewClass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancelNewClass.ForeColor = System.Drawing.Color.White
        Me.cancelNewClass.Location = New System.Drawing.Point(510, 241)
        Me.cancelNewClass.Name = "cancelNewClass"
        Me.cancelNewClass.Size = New System.Drawing.Size(125, 26)
        Me.cancelNewClass.TabIndex = 96
        Me.cancelNewClass.Text = "CANCEL"
        '
        'addNewClass
        '
        Me.addNewClass.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addNewClass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addNewClass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addNewClass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addNewClass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addNewClass.ForeColor = System.Drawing.Color.White
        Me.addNewClass.Location = New System.Drawing.Point(510, 204)
        Me.addNewClass.Name = "addNewClass"
        Me.addNewClass.Size = New System.Drawing.Size(125, 26)
        Me.addNewClass.TabIndex = 95
        Me.addNewClass.Text = "ADD CLASS"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(138, 205)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(65, 15)
        Me.Guna2HtmlLabel5.TabIndex = 94
        Me.Guna2HtmlLabel5.Text = "COURSE_ID"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(142, 157)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(67, 15)
        Me.Guna2HtmlLabel3.TabIndex = 93
        Me.Guna2HtmlLabel3.Text = "SECTION_ID"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(497, 89)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(166, 35)
        Me.Guna2HtmlLabel1.TabIndex = 92
        Me.Guna2HtmlLabel1.Text = "ADD CLASS"
        '
        'ADD_CLASS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TERM)
        Me.Controls.Add(Me.ACADEMICYEAR)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.PROFESSORID)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.COURSEID)
        Me.Controls.Add(Me.SECTIONID)
        Me.Controls.Add(Me.cancelNewClass)
        Me.Controls.Add(Me.addNewClass)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "ADD_CLASS"
        Me.Text = "ADD_CLASS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TERM As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ACADEMICYEAR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PROFESSORID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents COURSEID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SECTIONID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cancelNewClass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addNewClass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
