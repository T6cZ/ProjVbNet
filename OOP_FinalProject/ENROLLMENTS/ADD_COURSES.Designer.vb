<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_COURSES
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
        Me.cancelAddnewCourse = New Guna.UI2.WinForms.Guna2Button()
        Me.addnewCourse = New Guna.UI2.WinForms.Guna2Button()
        Me.DEPARTMENTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CREDITS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.COURSENAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.COURSEID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'cancelAddnewCourse
        '
        Me.cancelAddnewCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelAddnewCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelAddnewCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelAddnewCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelAddnewCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelAddnewCourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancelAddnewCourse.ForeColor = System.Drawing.Color.White
        Me.cancelAddnewCourse.Location = New System.Drawing.Point(514, 329)
        Me.cancelAddnewCourse.Name = "cancelAddnewCourse"
        Me.cancelAddnewCourse.Size = New System.Drawing.Size(125, 26)
        Me.cancelAddnewCourse.TabIndex = 53
        Me.cancelAddnewCourse.Text = "CANCEL"
        '
        'addnewCourse
        '
        Me.addnewCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addnewCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addnewCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addnewCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addnewCourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addnewCourse.ForeColor = System.Drawing.Color.White
        Me.addnewCourse.Location = New System.Drawing.Point(514, 292)
        Me.addnewCourse.Name = "addnewCourse"
        Me.addnewCourse.Size = New System.Drawing.Size(125, 27)
        Me.addnewCourse.TabIndex = 52
        Me.addnewCourse.Text = "ADD NEW COURSE"
        '
        'DEPARTMENTID
        '
        Me.DEPARTMENTID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DEPARTMENTID.DefaultText = ""
        Me.DEPARTMENTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DEPARTMENTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DEPARTMENTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DEPARTMENTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DEPARTMENTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DEPARTMENTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTID.Location = New System.Drawing.Point(276, 330)
        Me.DEPARTMENTID.Name = "DEPARTMENTID"
        Me.DEPARTMENTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DEPARTMENTID.PlaceholderText = ""
        Me.DEPARTMENTID.SelectedText = ""
        Me.DEPARTMENTID.Size = New System.Drawing.Size(192, 25)
        Me.DEPARTMENTID.TabIndex = 51
        '
        'CREDITS
        '
        Me.CREDITS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CREDITS.DefaultText = ""
        Me.CREDITS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CREDITS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CREDITS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CREDITS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CREDITS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CREDITS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CREDITS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CREDITS.Location = New System.Drawing.Point(272, 279)
        Me.CREDITS.Name = "CREDITS"
        Me.CREDITS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CREDITS.PlaceholderText = ""
        Me.CREDITS.SelectedText = ""
        Me.CREDITS.Size = New System.Drawing.Size(192, 25)
        Me.CREDITS.TabIndex = 50
        '
        'COURSENAME
        '
        Me.COURSENAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.COURSENAME.DefaultText = ""
        Me.COURSENAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.COURSENAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.COURSENAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.COURSENAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.COURSENAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSENAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.COURSENAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.COURSENAME.Location = New System.Drawing.Point(272, 242)
        Me.COURSENAME.Name = "COURSENAME"
        Me.COURSENAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.COURSENAME.PlaceholderText = ""
        Me.COURSENAME.SelectedText = ""
        Me.COURSENAME.Size = New System.Drawing.Size(192, 25)
        Me.COURSENAME.TabIndex = 49
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(162, 330)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(95, 15)
        Me.Guna2HtmlLabel4.TabIndex = 48
        Me.Guna2HtmlLabel4.Text = "DEPARTMENT_ID"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(162, 279)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(50, 15)
        Me.Guna2HtmlLabel3.TabIndex = 47
        Me.Guna2HtmlLabel3.Text = "CREDITS"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(162, 231)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(85, 15)
        Me.Guna2HtmlLabel2.TabIndex = 46
        Me.Guna2HtmlLabel2.Text = "COURSE_NAME"
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
        Me.COURSEID.Location = New System.Drawing.Point(272, 179)
        Me.COURSEID.Name = "COURSEID"
        Me.COURSEID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.COURSEID.PlaceholderText = ""
        Me.COURSEID.SelectedText = ""
        Me.COURSEID.Size = New System.Drawing.Size(192, 25)
        Me.COURSEID.TabIndex = 45
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(162, 168)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(65, 15)
        Me.Guna2HtmlLabel6.TabIndex = 44
        Me.Guna2HtmlLabel6.Text = "COURSE_ID"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(201, 96)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(215, 35)
        Me.Guna2HtmlLabel1.TabIndex = 43
        Me.Guna2HtmlLabel1.Text = "ADD COURSES"
        '
        'ADD_COURSES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cancelAddnewCourse)
        Me.Controls.Add(Me.addnewCourse)
        Me.Controls.Add(Me.DEPARTMENTID)
        Me.Controls.Add(Me.CREDITS)
        Me.Controls.Add(Me.COURSENAME)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.COURSEID)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "ADD_COURSES"
        Me.Text = "ADD_COURSES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelAddnewCourse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addnewCourse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DEPARTMENTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CREDITS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents COURSENAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents COURSEID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
