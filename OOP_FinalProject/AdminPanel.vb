Imports MySql.Data.MySqlClient

Public Class AdminPanel
    Private AdminID As String

    Public Sub New(adminID As String)
        InitializeComponent()
        Me.AdminID = adminID
    End Sub

    Private Sub sb_addstudent_Click(sender As Object, e As EventArgs) Handles sb_addstudent.Click
        studentpanel.BringToFront()
    End Sub

    Private Sub sb_addprof_Click(sender As Object, e As EventArgs) Handles sb_addprof.Click
        professorpanel.BringToFront()

    End Sub

    Private Sub sb_addadmin_Click(sender As Object, e As EventArgs) Handles sb_addadmin.Click
        addadminpanel.BringToFront()

    End Sub

    Private Sub sb_adddepartment_Click(sender As Object, e As EventArgs) Handles sb_adddepartment.Click
        departmentpanel.BringToFront()
    End Sub

    Private Sub sb_addcourse_Click(sender As Object, e As EventArgs) Handles sb_addcourse.Click
        coursepanel.BringToFront()
    End Sub

    Private Sub sb_addsection_Click(sender As Object, e As EventArgs) Handles sb_addsection.Click
        sectionpanel.BringToFront()
    End Sub

    Private Sub sb_addclass_Click(sender As Object, e As EventArgs) Handles sb_addclass.Click
        classpanel.BringToFront()
    End Sub

    Private Sub sb_enroll_Click(sender As Object, e As EventArgs) Handles sb_enroll.Click
        enrollmentpanel.BringToFront()
    End Sub



    '============================================================================================================


    Private Sub admin_addstudent_Click(sender As Object, e As EventArgs) Handles admin_addstudent.Click
        ADD_STUDENTS.Show()
    End Sub

    Private Sub admin_addnewprof_Click(sender As Object, e As EventArgs) Handles admin_addnewprof.Click
        Add_Professor.Show()

    End Sub
End Class
