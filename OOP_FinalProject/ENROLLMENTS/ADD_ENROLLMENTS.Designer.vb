﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_ENROLLMENTS
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
        Me.SEMESTER = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cancelEnroll = New Guna.UI2.WinForms.Guna2Button()
        Me.enrollStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.CLASSID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.STUDENTID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'SEMESTER
        '
        Me.SEMESTER.BackColor = System.Drawing.Color.Transparent
        Me.SEMESTER.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SEMESTER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SEMESTER.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SEMESTER.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SEMESTER.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SEMESTER.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.SEMESTER.ItemHeight = 30
        Me.SEMESTER.Items.AddRange(New Object() {"FIRST", "SECOND"})
        Me.SEMESTER.Location = New System.Drawing.Point(234, 241)
        Me.SEMESTER.Name = "SEMESTER"
        Me.SEMESTER.Size = New System.Drawing.Size(140, 36)
        Me.SEMESTER.TabIndex = 70
        '
        'cancelEnroll
        '
        Me.cancelEnroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelEnroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelEnroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelEnroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelEnroll.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelEnroll.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancelEnroll.ForeColor = System.Drawing.Color.White
        Me.cancelEnroll.Location = New System.Drawing.Point(492, 288)
        Me.cancelEnroll.Name = "cancelEnroll"
        Me.cancelEnroll.Size = New System.Drawing.Size(125, 26)
        Me.cancelEnroll.TabIndex = 69
        Me.cancelEnroll.Text = "CANCEL"
        '
        'enrollStudent
        '
        Me.enrollStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.enrollStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.enrollStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.enrollStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.enrollStudent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.enrollStudent.ForeColor = System.Drawing.Color.White
        Me.enrollStudent.Location = New System.Drawing.Point(492, 251)
        Me.enrollStudent.Name = "enrollStudent"
        Me.enrollStudent.Size = New System.Drawing.Size(125, 26)
        Me.enrollStudent.TabIndex = 68
        Me.enrollStudent.Text = "ENROLL STUDENT"
        '
        'CLASSID
        '
        Me.CLASSID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CLASSID.DefaultText = ""
        Me.CLASSID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CLASSID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CLASSID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CLASSID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CLASSID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLASSID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CLASSID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLASSID.Location = New System.Drawing.Point(246, 193)
        Me.CLASSID.Name = "CLASSID"
        Me.CLASSID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CLASSID.PlaceholderText = ""
        Me.CLASSID.SelectedText = ""
        Me.CLASSID.Size = New System.Drawing.Size(192, 26)
        Me.CLASSID.TabIndex = 67
        '
        'STUDENTID
        '
        Me.STUDENTID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.STUDENTID.DefaultText = ""
        Me.STUDENTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.STUDENTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.STUDENTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.STUDENTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.STUDENTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.STUDENTID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.STUDENTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.STUDENTID.Location = New System.Drawing.Point(234, 156)
        Me.STUDENTID.Name = "STUDENTID"
        Me.STUDENTID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.STUDENTID.PlaceholderText = ""
        Me.STUDENTID.SelectedText = ""
        Me.STUDENTID.Size = New System.Drawing.Size(192, 26)
        Me.STUDENTID.TabIndex = 66
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(120, 252)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(62, 15)
        Me.Guna2HtmlLabel5.TabIndex = 65
        Me.Guna2HtmlLabel5.Text = "SEMESTER"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(124, 204)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(54, 15)
        Me.Guna2HtmlLabel3.TabIndex = 64
        Me.Guna2HtmlLabel3.Text = "CLASS_ID"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(124, 156)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(72, 15)
        Me.Guna2HtmlLabel2.TabIndex = 63
        Me.Guna2HtmlLabel2.Text = "STUDENT_ID"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(479, 136)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(201, 35)
        Me.Guna2HtmlLabel1.TabIndex = 62
        Me.Guna2HtmlLabel1.Text = "ENROLLMENT"
        '
        'ADD_ENROLLMENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SEMESTER)
        Me.Controls.Add(Me.cancelEnroll)
        Me.Controls.Add(Me.enrollStudent)
        Me.Controls.Add(Me.CLASSID)
        Me.Controls.Add(Me.STUDENTID)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "ADD_ENROLLMENTS"
        Me.Text = "ADD_ENROLLMENTS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEMESTER As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cancelEnroll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents enrollStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CLASSID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents STUDENTID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
