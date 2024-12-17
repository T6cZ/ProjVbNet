Imports MySql.Data.MySqlClient

Public Class AdminPanel
    Private AdminID As String

    Private Departments As DataTable

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDepartments()
        ShowSections()
        ShowCourses()
        ShowClasses()
        ShowEnrollments()
        ShowStudents()
        ShowAdmins()




        LoadProfessorData()

        LoadDepartments()

        timer.Interval = 1000
        timer.Enabled = True
        timer.Start()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        admin_currenttime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        admin_currentdate.Text = DateTime.Now.ToString("MM/dd/yyyy dddd")
    End Sub

    Public Sub ShowAdmins()
        Dim query As String = "SELECT ADMIN_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, CONTACT_NUMBER, ADDRESS, REMARKS FROM ADMIN"

        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ADMINSTABLE.DataSource = dt
        Else
            MessageBox.Show("No admin data found.")
        End If
    End Sub

    Private Sub LoadDepartments()
        Try
            Dim query As String = "SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENT;"
            Dim dt As DataTable = GetDataTable(query, New Dictionary(Of String, Object)())

            If dt.Rows.Count > 0 Then
                prof_dept.DataSource = dt
                prof_dept.DisplayMember = "DEPARTMENT_NAME"
                prof_dept.ValueMember = "DEPARTMENT_ID"
                prof_dept.SelectedIndex = -1
            Else
                MessageBox.Show("No departments available.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PROFESSORDATA_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PROFESSORDATA.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = PROFESSORDATA.Rows(e.RowIndex)

            prof_id.Text = row.Cells("Professor ID").Value.ToString()
            prof_givenname.Text = row.Cells("First Name").Value.ToString()
            prof_midname.Text = row.Cells("Middle Name").Value.ToString()
            prof_lastname.Text = row.Cells("Last Name").Value.ToString()
            prof_status.Checked = (row.Cells("Status").Value.ToString() = "ACTIVE")

            Dim deptName As String = row.Cells("Department Name").Value.ToString()
            Dim index As Integer = prof_dept.FindStringExact(deptName)
            prof_dept.SelectedIndex = If(index <> -1, index, -1)
        End If
    End Sub

    Private Sub admin_profUpdate_Click(sender As Object, e As EventArgs) Handles admin_profUpdate.Click
        Try
            If String.IsNullOrEmpty(prof_id.Text) Then
                MessageBox.Show("Please select a professor to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim query As String = "
            UPDATE PROFESSOR 
            SET 
                FIRST_NAME = @FirstName,
                MIDDLE_NAME = @MiddleName,
                LAST_NAME = @LastName,
                DEPARTMENT_ID = @DepartmentID,
                STATUS = @Status
            WHERE PROFESSOR_ID = @ProfessorID;"

            Dim params As New Dictionary(Of String, Object) From {
            {"@FirstName", prof_givenname.Text.Trim()},
            {"@MiddleName", If(String.IsNullOrEmpty(prof_midname.Text.Trim()), DBNull.Value, prof_midname.Text.Trim())},
            {"@LastName", prof_lastname.Text.Trim()},
            {"@DepartmentID", prof_dept.SelectedValue},
            {"@Status", If(prof_status.Checked, "ACTIVE", "INACTIVE")},
            {"@ProfessorID", prof_id.Text.Trim()}
        }

            Dim rowsAffected = ExecuteQuery(query, params)

            If rowsAffected > 0 Then
                MessageBox.Show("Professor information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadProfessorData()
            Else
                MessageBox.Show("No rows were updated. Please check the data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ExecuteQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function
    Private Sub LoadProfessorData()
        Try
            Dim query As String = "
                SELECT 
                    PROFESSOR.PROFESSOR_ID AS 'Professor ID',
                    PROFESSOR.FIRST_NAME AS 'First Name',
                    PROFESSOR.MIDDLE_NAME AS 'Middle Name',
                    PROFESSOR.LAST_NAME AS 'Last Name',
                    DEPARTMENT.DEPARTMENT_NAME AS 'Department Name',
                    PROFESSOR.CONTACT_NUMBER AS 'Contact Number',
                    PROFESSOR.ADDRESS AS 'Address',
                    PROFESSOR.STATUS AS 'Status'
                FROM 
                    PROFESSOR
                LEFT JOIN 
                    DEPARTMENT ON PROFESSOR.DEPARTMENT_ID = DEPARTMENT.DEPARTMENT_ID;"


            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    PROFESSORDATA.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Failed to load professor data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetDataTable(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to fetch data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Function GetConnection() As MySqlConnection

        Dim connectionString As String = "server=localhost;user id=root;database=university_grading_system;"
        Return New MySqlConnection(connectionString)
    End Function


    Private Sub admin_profdelete_Click(sender As Object, e As EventArgs) Handles admin_profdelete.Click
        Try
            If String.IsNullOrEmpty(prof_id.Text) Then
                MessageBox.Show("Please select a professor to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the professor with ID {prof_id.Text}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim query As String = "DELETE FROM PROFESSOR WHERE PROFESSOR_ID = @ProfessorID;"

                Dim params As New Dictionary(Of String, Object) From {
                {"@ProfessorID", prof_id.Text.Trim()}
            }
                Dim rowsAffected = ExecuteQuery(query, params)

                If rowsAffected > 0 Then
                    MessageBox.Show("Professor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadProfessorData()
                    ClearFields()
                Else
                    MessageBox.Show("No rows were deleted. Please check the data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show($"Failed to delete professor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        prof_id.Clear()
        prof_givenname.Clear()
        prof_midname.Clear()
        prof_lastname.Clear()
        prof_status.Checked = False
        prof_dept.SelectedIndex = -1
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

    '=================================== D E P A R T M E N T S ===========================================================================

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

    Private Sub DEPARTMENTSTABLE_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DEPARTMENTSTABLE.RowValidated
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DEPARTMENTSTABLE.Rows(e.RowIndex)

            Dim departmentID As String = row.Cells("DEPARTMENT_ID").Value?.ToString()
            Dim departmentName As String = row.Cells("DEPARTMENT_NAME").Value?.ToString()

            If String.IsNullOrWhiteSpace(departmentID) OrElse String.IsNullOrWhiteSpace(departmentName) Then
                MessageBox.Show("Department ID and Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim query As String = "UPDATE DEPARTMENT SET DEPARTMENT_NAME = @DEPARTMENT_NAME WHERE DEPARTMENT_ID = @DEPARTMENT_ID"
            Dim params As New Dictionary(Of String, Object) From {
            {"@DEPARTMENT_ID", departmentID},
            {"@DEPARTMENT_NAME", departmentName}
        }

            Dim rowsAffected As Integer = databaseConnection.ExecuteQuery(query, params)

            If rowsAffected > 0 Then
                Console.WriteLine($"Department '{departmentID}' updated successfully.")
            End If
        End If
    End Sub

    Private Sub departmentudpate_Click(sender As Object, e As EventArgs) Handles departmentudpate.Click

        If String.IsNullOrWhiteSpace(d_departmentid.Text) OrElse String.IsNullOrWhiteSpace(d_departmentname.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DEPARTMENTSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a department to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = DEPARTMENTSTABLE.SelectedRows(0)
        Dim oldDepartmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()

        Dim query As String = "UPDATE DEPARTMENT SET DEPARTMENT_ID = @NEW_DEPARTMENT_ID, DEPARTMENT_NAME = @DEPARTMENT_NAME WHERE DEPARTMENT_ID = @OLD_DEPARTMENT_ID"
        Dim params As New Dictionary(Of String, Object) From {
        {"@NEW_DEPARTMENT_ID", d_departmentid.Text.Trim()},
        {"@DEPARTMENT_NAME", d_departmentname.Text.Trim()},
        {"@OLD_DEPARTMENT_ID", oldDepartmentID}
    }

        Dim rowsAffected As Integer = databaseConnection.ExecuteQuery(query, params)

        If rowsAffected > 0 Then
            MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowDepartments()
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
        LoginPanel.Show()

    End Sub


    Public Sub ShowStudents()
        Dim query As String = "SELECT STUDENT_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, BIRTHDATE, GENDER, YEAR_LEVEL, CONTACT_NUMBER, ADDRESS, DEPARTMENT_ID, REMARKS FROM STUDENT"

        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            StudentDataTable.DataSource = dt
        Else
            MessageBox.Show("No student data found.")
        End If
    End Sub

    Private Sub STUDENTSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles StudentDataTable.SelectionChanged
        If StudentDataTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = StudentDataTable.SelectedRows(0)

            Dim studentID As String = selectedRow.Cells("STUDENT_ID").Value?.ToString()
            Dim firstName As String = selectedRow.Cells("FIRST_NAME").Value?.ToString()
            Dim middleName As String = selectedRow.Cells("MIDDLE_NAME").Value?.ToString()
            Dim lastName As String = selectedRow.Cells("LAST_NAME").Value?.ToString()
            Dim birthDate As String = selectedRow.Cells("BIRTHDATE").Value?.ToString()
            Dim gender As String = selectedRow.Cells("GENDER").Value?.ToString()
            Dim yearLevel As String = selectedRow.Cells("YEAR_LEVEL").Value?.ToString()
            Dim contactNumber As String = selectedRow.Cells("CONTACT_NUMBER").Value?.ToString()
            Dim address As String = selectedRow.Cells("ADDRESS").Value?.ToString()
            Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()
            Dim remarks As String = selectedRow.Cells("REMARKS").Value?.ToString()

            s_studentid.Text = studentID
            s_firstname.Text = firstName
            s_middlename.Text = middleName
            s_lastname.Text = lastName
            s_birthdate.Text = birthDate
            s_gender.Text = gender
            s_yearlevel.Text = yearLevel
            s_contactnumber.Text = contactNumber
            s_address.Text = address
            s_departmentid.Text = departmentID
            s_remarks.Text = remarks
        End If
    End Sub

    Private Sub studentupdate_Click(sender As Object, e As EventArgs) Handles studentupdate.Click
        If String.IsNullOrEmpty(s_studentid.Text) OrElse String.IsNullOrEmpty(s_firstname.Text) OrElse String.IsNullOrEmpty(s_lastname.Text) Then
            MessageBox.Show("Please fill in all required fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE STUDENT SET FIRST_NAME = @FIRST_NAME, MIDDLE_NAME = @MIDDLE_NAME, LAST_NAME = @LAST_NAME, BIRTHDATE = @BIRTHDATE, GENDER = @GENDER, YEAR_LEVEL = @YEAR_LEVEL, CONTACT_NUMBER = @CONTACT_NUMBER, ADDRESS = @ADDRESS, DEPARTMENT_ID = @DEPARTMENT_ID, REMARKS = @REMARKS WHERE STUDENT_ID = @STUDENT_ID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@STUDENT_ID", s_studentid.Text},
        {"@FIRST_NAME", s_firstname.Text},
        {"@MIDDLE_NAME", s_middlename.Text},
        {"@LAST_NAME", s_lastname.Text},
        {"@BIRTHDATE", s_birthdate.Text},
        {"@GENDER", s_gender.Text},
        {"@YEAR_LEVEL", s_yearlevel.Text},
        {"@CONTACT_NUMBER", s_contactnumber.Text},
        {"@ADDRESS", s_address.Text},
        {"@DEPARTMENT_ID", s_departmentid.Text},
        {"@REMARKS", s_remarks.Text}
    }

        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Student data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowStudents()
        Else
            MessageBox.Show("Failed to update student data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub studentdelete_Click(sender As Object, e As EventArgs) Handles admin_deletestudent.Click
        If StudentDataTable.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow As DataGridViewRow = StudentDataTable.SelectedRows(0)
        Dim studentID As String = selectedRow.Cells("STUDENT_ID").Value?.ToString()

        If String.IsNullOrEmpty(studentID) Then
            MessageBox.Show("The selected student does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the student with ID '{studentID}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            Dim query As String = "DELETE FROM STUDENT WHERE STUDENT_ID = @STUDENT_ID"
            Dim params As New Dictionary(Of String, Object) From {
            {"@STUDENT_ID", studentID}
        }

            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowStudents()
                Else
                    MessageBox.Show("Failed to delete the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub addnewStudent_Click(sender As Object, e As EventArgs) Handles admin_addstudent.Click
        ADD_STUDENTS.Show()
    End Sub



End Class
