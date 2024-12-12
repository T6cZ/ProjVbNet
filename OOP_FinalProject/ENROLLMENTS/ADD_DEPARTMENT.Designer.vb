<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_DEPARTMENT
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
        Me.canceldepartment = New Guna.UI2.WinForms.Guna2Button()
        Me.addnewdepartment = New Guna.UI2.WinForms.Guna2Button()
        Me.DEPARTMENTNAME = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DEPARTMENTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'canceldepartment
        '
        Me.canceldepartment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.canceldepartment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.canceldepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.canceldepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.canceldepartment.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.canceldepartment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.canceldepartment.ForeColor = System.Drawing.Color.White
        Me.canceldepartment.Location = New System.Drawing.Point(235, 325)
        Me.canceldepartment.Name = "canceldepartment"
        Me.canceldepartment.Size = New System.Drawing.Size(125, 26)
        Me.canceldepartment.TabIndex = 49
        Me.canceldepartment.Text = "CANCEL"
        '
        'addnewdepartment
        '
        Me.addnewdepartment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addnewdepartment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addnewdepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addnewdepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addnewdepartment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addnewdepartment.ForeColor = System.Drawing.Color.White
        Me.addnewdepartment.Location = New System.Drawing.Point(235, 288)
        Me.addnewdepartment.Name = "addnewdepartment"
        Me.addnewdepartment.Size = New System.Drawing.Size(125, 26)
        Me.addnewdepartment.TabIndex = 48
        Me.addnewdepartment.Text = "ADD NEW DEPARTMENT"
        '
        'DEPARTMENTNAME
        '
        Me.DEPARTMENTNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DEPARTMENTNAME.DefaultText = ""
        Me.DEPARTMENTNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DEPARTMENTNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DEPARTMENTNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DEPARTMENTNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DEPARTMENTNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTNAME.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DEPARTMENTNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DEPARTMENTNAME.Location = New System.Drawing.Point(374, 218)
        Me.DEPARTMENTNAME.Name = "DEPARTMENTNAME"
        Me.DEPARTMENTNAME.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DEPARTMENTNAME.PlaceholderText = ""
        Me.DEPARTMENTNAME.SelectedText = ""
        Me.DEPARTMENTNAME.Size = New System.Drawing.Size(192, 26)
        Me.DEPARTMENTNAME.TabIndex = 47
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(235, 218)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(115, 15)
        Me.Guna2HtmlLabel2.TabIndex = 46
        Me.Guna2HtmlLabel2.Text = "DEPARTMENT_NAME"
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
        Me.DEPARTMENTID.Location = New System.Drawing.Point(374, 155)
        Me.DEPARTMENTID.Name = "DEPARTMENTID"
        Me.DEPARTMENTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DEPARTMENTID.PlaceholderText = ""
        Me.DEPARTMENTID.SelectedText = ""
        Me.DEPARTMENTID.Size = New System.Drawing.Size(192, 26)
        Me.DEPARTMENTID.TabIndex = 45
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(235, 155)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(95, 15)
        Me.Guna2HtmlLabel6.TabIndex = 44
        Me.Guna2HtmlLabel6.Text = "DEPARTMENT_ID"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(235, 99)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(271, 35)
        Me.Guna2HtmlLabel1.TabIndex = 43
        Me.Guna2HtmlLabel1.Text = "ADD DEPARTMENT"
        '
        'ADD_DEPARTMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.canceldepartment)
        Me.Controls.Add(Me.addnewdepartment)
        Me.Controls.Add(Me.DEPARTMENTNAME)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.DEPARTMENTID)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "ADD_DEPARTMENT"
        Me.Text = "ADD_DEPARTMENT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents canceldepartment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addnewdepartment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DEPARTMENTNAME As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DEPARTMENTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
