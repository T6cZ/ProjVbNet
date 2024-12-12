Imports MySql.Data.MySqlClient

Public Class AdminPanel
    Private AdminID As String

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDepartments()
        ShowSections()
        ShowCourses()
        ShowClasses()
        ShowEnrollments()

    End Sub

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

    Private Sub admin_addadmin_Click(sender As Object, e As EventArgs) Handles admin_addadmin.Click
        ADD_ADMIN.Show()

    End Sub

    '==============================================================================================================

    Public Sub ShowDepartments()
        Dim query As String = "SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENT"
        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            DEPARTMENTSTABLE.DataSource = dt
        Else
            MessageBox.Show("No department data found.")
        End If
    End Sub

    Private Sub departmentaddnew_Click(sender As Object, e As EventArgs) Handles departmentaddnew.Click
        ADD_DEPARTMENT.Show()

    End Sub

    Private Sub DEPARTMENTSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles DEPARTMENTSTABLE.SelectionChanged
        If DEPARTMENTSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DEPARTMENTSTABLE.SelectedRows(0)

            Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()
            Dim departmentName As String = selectedRow.Cells("DEPARTMENT_NAME").Value?.ToString()

            d_departmentid.Text = departmentID
            d_departmentname.Text = departmentName
        End If
    End Sub

    Private Sub departmentudpate_Click(sender As Object, e As EventArgs) Handles departmentudpate.Click
        If String.IsNullOrEmpty(d_departmentid.Text) OrElse String.IsNullOrEmpty(d_departmentname.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "UPDATE DEPARTMENT SET DEPARTMENT_NAME = @DEPARTMENT_NAME WHERE DEPARTMENT_ID = @DEPARTMENT_ID"

        Dim params As New Dictionary(Of String, Object) From {
            {"@DEPARTMENT_ID", d_departmentid.Text},
            {"@DEPARTMENT_NAME", d_departmentname.Text}
        }

        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Department data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowDepartments()
        Else
            MessageBox.Show("Failed to update department data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub departmentdelete_Click(sender As Object, e As EventArgs) Handles departmentdelete.Click
        If DEPARTMENTSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a department to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim selectedRow As DataGridViewRow = DEPARTMENTSTABLE.SelectedRows(0)
        Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()

        If String.IsNullOrEmpty(departmentID) Then
            MessageBox.Show("The selected department does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the department with ID '{departmentID}'?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then

            Dim query As String = "DELETE FROM DEPARTMENT WHERE DEPARTMENT_ID = @DEPARTMENT_ID"


            Dim params As New Dictionary(Of String, Object) From {
                {"@DEPARTMENT_ID", departmentID}
            }
            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Department deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowDepartments()
                Else
                    MessageBox.Show("Failed to delete the department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    '=======================================================================================================================
    Public Sub ShowSections()
        Dim query As String = "SELECT SECTION_ID, SECTION_NAME, DEPARTMENT_ID, YEAR_LEVEL FROM SECTIONS"

        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            SECTIONSTABLE.DataSource = dt
        Else
            MessageBox.Show("No section data found.")
        End If
    End Sub


    Private Sub SECTIONSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles SECTIONSTABLE.SelectionChanged
        If SECTIONSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = SECTIONSTABLE.SelectedRows(0)


            Dim sectionID As String = selectedRow.Cells("SECTION_ID").Value?.ToString()
            Dim sectionName As String = selectedRow.Cells("SECTION_NAME").Value?.ToString()
            Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()
            Dim yearLevel As String = selectedRow.Cells("YEAR_LEVEL").Value?.ToString()

            s_sectionid.Text = sectionID
            s_sectionname.Text = sectionName
            s_departmentid.Text = departmentID
            s_yearlevel.Text = yearLevel
        End If
    End Sub

    Private Sub sectionupdate_Click(sender As Object, e As EventArgs) Handles sectionupdate.Click
        If String.IsNullOrEmpty(s_sectionname.Text) OrElse String.IsNullOrEmpty(s_departmentid.Text) OrElse
       String.IsNullOrEmpty(s_yearlevel.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim yearLevelValue As Integer
        If Not Integer.TryParse(s_yearlevel.Text, yearLevelValue) Then
            MessageBox.Show("Year Level must be a valid number.")
            Return
        End If


        Dim query As String = "UPDATE SECTIONS SET SECTION_NAME = @SECTION_NAME, DEPARTMENT_ID = @DEPARTMENT_ID, YEAR_LEVEL = @YEAR_LEVEL WHERE SECTION_ID = @SECTION_ID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@SECTION_ID", s_sectionid.Text},
        {"@SECTION_NAME", s_sectionname.Text},
        {"@DEPARTMENT_ID", s_departmentid.Text},
        {"@YEAR_LEVEL", yearLevelValue}
    }

        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Section data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowSections()
        Else
            MessageBox.Show("Failed to update section data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub sectiondelete_Click(sender As Object, e As EventArgs) Handles sectiondelete.Click
        If SECTIONSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a section to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = SECTIONSTABLE.SelectedRows(0)
        Dim sectionID As String = selectedRow.Cells("SECTION_ID").Value?.ToString()

        If String.IsNullOrEmpty(sectionID) Then
            MessageBox.Show("The selected section does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the section with ID '{sectionID}'?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Dim query As String = "DELETE FROM SECTIONS WHERE SECTION_ID = @SECTION_ID"

            Dim params As New Dictionary(Of String, Object) From {
            {"@SECTION_ID", sectionID}
        }

            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Section deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowSections()
                Else
                    MessageBox.Show("Failed to delete the section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting section: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub sectionaddnew_Click(sender As Object, e As EventArgs) Handles sectionaddnew.Click
        ADD_SECTION.Show()
    End Sub


    '===============================================================================================================================

    Public Sub ShowCourses()

        Dim query As String = "SELECT COURSE_ID, COURSE_NAME, CREDITS, DEPARTMENT_ID FROM COURSES"

        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            COURSESTABLE.DataSource = dt
        Else
            MessageBox.Show("No classes data found.")
        End If
    End Sub

    Private Sub COURSESTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles COURSESTABLE.SelectionChanged
        If COURSESTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = COURSESTABLE.SelectedRows(0)
            Dim courseID As String = selectedRow.Cells("COURSE_ID").Value?.ToString()
            Dim courseName As String = selectedRow.Cells("COURSE_NAME").Value?.ToString()
            Dim credits As String = selectedRow.Cells("CREDITS").Value?.ToString()
            Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()
            coursecourseid.Text = courseID
            coursecoursename.Text = courseName
            coursecredits.Text = credits
            coursedepartmentid.Text = departmentID
        End If
    End Sub



    Private Sub courseupdate_Click(sender As Object, e As EventArgs) Handles courseupdate.Click
        If String.IsNullOrEmpty(coursecourseid.Text) OrElse String.IsNullOrEmpty(coursecoursename.Text) OrElse
       String.IsNullOrEmpty(coursecredits.Text) OrElse String.IsNullOrEmpty(coursedepartmentid.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE COURSES SET COURSE_NAME = @COURSE_NAME, CREDITS = @CREDITS, DEPARTMENT_ID = @DEPARTMENT_ID WHERE COURSE_ID = @COURSE_ID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@COURSE_ID", coursecourseid.Text},
        {"@COURSE_NAME", coursecoursename.Text},
        {"@CREDITS", coursecredits.Text},
        {"@DEPARTMENT_ID", coursedepartmentid.Text}
    }
        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Course data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowCourses()
        Else
            MessageBox.Show("Failed to update course data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub




    Private Sub coursedelete_Click(sender As Object, e As EventArgs) Handles coursedelete.Click
        If COURSESTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a course to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = COURSESTABLE.SelectedRows(0)
        Dim courseID As String = selectedRow.Cells("COURSE_ID").Value?.ToString()

        If String.IsNullOrEmpty(courseID) Then
            MessageBox.Show("The selected course does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the course with ID '{courseID}'?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Dim query As String = "DELETE FROM COURSES WHERE COURSE_ID = @COURSE_ID"
            Dim params As New Dictionary(Of String, Object) From {
            {"@COURSE_ID", courseID}
        }
            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowCourses()
                Else
                    MessageBox.Show("Failed to delete the course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub courseaddnew_Click(sender As Object, e As EventArgs) Handles courseaddnew.Click
        ADD_COURSES.Show()
    End Sub

    '=======================================================================================================================

    Public Sub ShowClasses()

        Dim query As String = "SELECT CLASS_ID, SECTION_ID, COURSE_ID, PROFESSOR_ID, TERM, ACADEMIC_YEAR FROM CLASSES"

        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            CLASSTABLE.DataSource = dt
        Else
            MessageBox.Show("No classes data found.")
        End If
    End Sub

    Private Sub CLASSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles CLASSTABLE.SelectionChanged
        If CLASSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = CLASSTABLE.SelectedRows(0)

            Dim classID As String = selectedRow.Cells("CLASS_ID").Value?.ToString()
            Dim sectionID As String = selectedRow.Cells("SECTION_ID").Value?.ToString()
            Dim courseID As String = selectedRow.Cells("COURSE_ID").Value?.ToString()
            Dim professorID As String = selectedRow.Cells("PROFESSOR_ID").Value?.ToString()
            Dim term As String = selectedRow.Cells("TERM").Value?.ToString()
            Dim academicYear As String = selectedRow.Cells("ACADEMIC_YEAR").Value?.ToString()

            txtclassid.Text = classID
            txtcourseid.Text = courseID
            txtprofessorid.Text = professorID
            cbterm.Text = term
            txtacademicyear.Text = academicYear
        End If
    End Sub



    Private Sub classupdate_Click(sender As Object, e As EventArgs) Handles classupdate.Click
        If String.IsNullOrEmpty(txtclassid.Text) OrElse String.IsNullOrEmpty(txtcourseid.Text) OrElse
           String.IsNullOrEmpty(txtprofessorid.Text) OrElse String.IsNullOrEmpty(cbterm.Text) OrElse
           String.IsNullOrEmpty(txtacademicyear.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE CLASSES SET COURSE_ID = @COURSE_ID, PROFESSOR_ID = @PROFESSOR_ID, TERM = @TERM, ACADEMIC_YEAR = @ACADEMIC_YEAR WHERE CLASS_ID = @CLASS_ID"

        Dim params As New Dictionary(Of String, Object) From {
            {"@CLASS_ID", txtclassid.Text},
            {"@COURSE_ID", txtcourseid.Text},
            {"@PROFESSOR_ID", txtprofessorid.Text},
            {"@TERM", cbterm.Text},
            {"@ACADEMIC_YEAR", txtacademicyear.Text}
        }
        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Class data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowClasses()
        Else
            MessageBox.Show("Failed to update class data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub addnewClass_Click(sender As Object, e As EventArgs) Handles addnewClass.Click
        ADD_CLASS.Show()
    End Sub

    Private Sub deleteClass_Click(sender As Object, e As EventArgs) Handles deleteClass.Click
        If CLASSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a section to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = CLASSTABLE.SelectedRows(0)
        Dim classID As String = selectedRow.Cells("CLASS_ID").Value?.ToString()

        If String.IsNullOrEmpty(classID) Then
            MessageBox.Show("The selected section does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the section with ID '{classID}'?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Dim query As String = "DELETE FROM CLASSES WHERE CLASS_ID = @CLASS_ID"

            Dim params As New Dictionary(Of String, Object) From {
            {"@CLASS_ID", classID}
        }

            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Section deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowSections()
                Else
                    MessageBox.Show("Failed to delete the section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting section: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    '========================================================================================================================

    Public Sub ShowEnrollments()
        Dim query As String = "SELECT ENROLLMENT_ID, STUDENT_ID, CLASS_ID, ENROLL_DATE, SEMESTER FROM ENROLLMENTS"

        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ENROLLMENTSTABLE.DataSource = dt
        Else
            MessageBox.Show("No enrollment data found.")
        End If
    End Sub


    Private Sub ENROLLMENTSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles ENROLLMENTSTABLE.SelectionChanged
        If ENROLLMENTSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ENROLLMENTSTABLE.SelectedRows(0)

            Dim enrollmentID As String = selectedRow.Cells("ENROLLMENT_ID").Value?.ToString()
            Dim studentID As String = selectedRow.Cells("STUDENT_ID").Value?.ToString()
            Dim classID As String = selectedRow.Cells("CLASS_ID").Value?.ToString()
            Dim enrollDate As String = selectedRow.Cells("ENROLL_DATE").Value?.ToString()
            Dim semester As String = selectedRow.Cells("SEMESTER").Value?.ToString()

            e_enrollmentid.Text = enrollmentID
            e_studentname.Text = studentID
            e_classid.Text = classID
            e_enrollmentdate.Text = enrollDate
            e_semester.Text = semester
        End If
    End Sub

    Private Sub enrollmentupdate_Click(sender As Object, e As EventArgs) Handles enrollmentupdate.Click
        If String.IsNullOrEmpty(e_enrollmentid.Text) OrElse String.IsNullOrEmpty(e_studentname.Text) OrElse
       String.IsNullOrEmpty(e_classid.Text) OrElse String.IsNullOrEmpty(e_semester.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim query As String = "UPDATE ENROLLMENTS SET STUDENT_ID = @STUDENT_ID, CLASS_ID = @CLASS_ID, SEMESTER = @SEMESTER WHERE ENROLLMENT_ID = @ENROLLMENT_ID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@ENROLLMENT_ID", e_enrollmentid.Text},
        {"@STUDENT_ID", e_studentname.Text},
        {"@CLASS_ID", e_classid.Text},
        {"@SEMESTER", e_semester.Text}
    }

        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Enrollment data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowEnrollments()
        Else
            MessageBox.Show("Failed to update enrollment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub enrollmentdelete_Click(sender As Object, e As EventArgs) Handles enrollmentdelete.Click
        If ENROLLMENTSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an enrollment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedRow As DataGridViewRow = ENROLLMENTSTABLE.SelectedRows(0)
        Dim enrollmentID As String = selectedRow.Cells("ENROLLMENT_ID").Value?.ToString()

        If String.IsNullOrEmpty(enrollmentID) Then
            MessageBox.Show("The selected enrollment does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the enrollment with ID '{enrollmentID}'?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Dim query As String = "DELETE FROM ENROLLMENTS WHERE ENROLLMENT_ID = @ENROLLMENT_ID"
            Dim params As New Dictionary(Of String, Object) From {
            {"@ENROLLMENT_ID", enrollmentID}
        }
            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Enrollment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowEnrollments()
                Else
                    MessageBox.Show("Failed to delete the enrollment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting enrollment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub addnewEnrollment_Click(sender As Object, e As EventArgs) Handles addnewEnrollment.Click
        ADD_ENROLLMENTS.Show()
    End Sub

    Private Sub admin_logout_Click(sender As Object, e As EventArgs) Handles admin_logout.Click
        Me.Hide()
        LoginRegPanel.Show()

    End Sub
End Class
