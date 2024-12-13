Public Class StudentMainMenu
    Private ReadOnly LoggedInStudentID As String

    Public Sub New(studentID As String)
        InitializeComponent()
        LoggedInStudentID = studentID
    End Sub

    Private Sub StudentMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadStudentInfo()
            LoadStudentCourses()
        Catch ex As Exception
            MessageBox.Show($"An error occurred during initialization: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadStudentInfo()
        Dim query As String =
        "SELECT DISTINCT " &
        "CONCAT(Student.Last_Name, ', ', Student.First_Name, ' ', Student.Middle_Name) AS FullName, " &
        "Student.Student_ID, " &
        "Department.Department_Name AS Department_Name, " &
        "Sections.Section_Name, " &
        "Login.EMAIL AS EmailAddress, " &
        "Student.Address, " &
        "Student.Birthdate, " &
        "TIMESTAMPDIFF(YEAR, Student.Birthdate, CURDATE()) AS Age " &
        "FROM STUDENT " &
        "INNER JOIN LOGIN ON STUDENT.USER_ID = LOGIN.USER_ID " &
        "LEFT JOIN Enrollments ON STUDENT.Student_ID = Enrollments.Student_ID " &
        "LEFT JOIN Classes ON Enrollments.Class_ID = Classes.Class_ID " &
        "LEFT JOIN Sections ON Classes.Section_ID = Sections.Section_ID " &
        "LEFT JOIN Department ON STUDENT.DEPARTMENT_ID = Department.DEPARTMENT_ID " &
        "WHERE LOGIN.USER_ID = @userID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@userID", LoggedInStudentID}
    }

        Try

            Dim studentRow As DataRow = databaseConnection.GetDataRow(query, params)

            If studentRow IsNot Nothing Then
                namelbl.Text = studentRow("FullName").ToString()
                studentidlbl.Text = studentRow("Student_ID").ToString()
                departmentlbl.Text = studentRow("Department_Name").ToString()
                sectionlbl.Text = If(IsDBNull(studentRow("Section_Name")), "N/A", studentRow("Section_Name").ToString())
                emailaddresslbl.Text = studentRow("EmailAddress").ToString()
                addresslbl.Text = studentRow("Address").ToString()
                birthdatelbl.Text = Convert.ToDateTime(studentRow("Birthdate")).ToShortDateString()
                agelbl.Text = studentRow("Age").ToString()
            Else
                MessageBox.Show("Student information not found.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load student information: {ex.Message}")
        End Try
    End Sub


    Private Sub LoadStudentCourses()
        Dim query As String =
    "SELECT DISTINCT " &
    "Courses.COURSE_NAME AS Course, " &
    "Courses.COURSE_ID AS CourseCode, " &
    "CONCAT(Professor.FIRST_NAME, ' ', Professor.LAST_NAME) AS ProfessorName, " &
    "Classes.TERM AS Semester, " &
    "Department.DEPARTMENT_NAME AS Department_Name, " &
    "Final_Grades.MIDTERM_PERCENTAGE AS Midterm_Percentage, " &
    "Final_Grades.FINALS_PERCENTAGE AS Finals_Percentage, " &
    "Final_Grades.SEMESTRAL_PERCENTAGE AS Semestral_Percentage, " &
    "Final_Grades.REMARKS AS Remarks, " &
    "Final_Grades.MIDTERM_GWA AS Midterm_GWA, " &
    "Final_Grades.FINALS_GWA AS Finals_GWA, " &
    "Final_Grades.SEMESTRAL_GWA AS Semestral_GWA " &
    "FROM Enrollments " &
    "INNER JOIN Classes ON Enrollments.CLASS_ID = Classes.CLASS_ID " &
    "INNER JOIN Courses ON Classes.COURSE_ID = Courses.COURSE_ID " &
    "INNER JOIN Professor ON Classes.Professor_ID = Professor.Professor_ID " &
    "INNER JOIN Department ON Courses.DEPARTMENT_ID = Department.DEPARTMENT_ID " &
    "LEFT JOIN Final_Grades ON Enrollments.CLASS_ID = Final_Grades.CLASS_ID " &
    "WHERE Enrollments.Student_ID = ( " &
    "    SELECT Student_ID FROM STUDENT WHERE USER_ID = @studentID " &
    ");"

        Dim params As New Dictionary(Of String, Object) From {
        {"@studentID", LoggedInStudentID}
    }

        Try
            Dim coursesTable As DataTable = databaseConnection.GetDataTable(query, params)
            stp_datatable.DataSource = coursesTable


            If stp_datatable.Columns.Contains("MIDTERM_GWA") Then
                stp_datatable.Columns("MIDTERM_GWA").Visible = False
            End If

            If stp_datatable.Columns.Contains("FINALS_GWA") Then
                stp_datatable.Columns("FINALS_GWA").Visible = False
            End If

            If stp_datatable.Columns.Contains("SEMESTRAL_GWA") Then
                stp_datatable.Columns("SEMESTRAL_GWA").Visible = False
            End If

            If stp_datatable.Columns.Contains("CourseCode") Then
                stp_datatable.Columns("CourseCode").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show($"Failed to load courses: {ex.Message}")
        End Try
    End Sub


    Private Sub stp_datatable_SelectionChanged(sender As Object, e As EventArgs) Handles stp_datatable.SelectionChanged
        If stp_datatable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = stp_datatable.SelectedRows(0)

            Try

                stp_coursename.Text = selectedRow.Cells("Course").Value?.ToString()
                stp_coursecode.Text = selectedRow.Cells("CourseCode").Value?.ToString()
                stp_professorname.Text = selectedRow.Cells("ProfessorName").Value?.ToString()
                stp_semester.Text = selectedRow.Cells("Semester").Value?.ToString()
                stp_department.Text = selectedRow.Cells("Department_Name").Value?.ToString()

                stp_midtermpercentage.Text = selectedRow.Cells("Midterm_Percentage").Value?.ToString()
                stp_finalspercentage.Text = selectedRow.Cells("Finals_Percentage").Value?.ToString()
                stp_semestralpercentage.Text = selectedRow.Cells("Semestral_Percentage").Value?.ToString()

                stp_midtermgwa.Text = selectedRow.Cells("Midterm_GWA").Value?.ToString()
                stp_finalsgwa.Text = selectedRow.Cells("Finals_GWA").Value?.ToString()
                stp_semestragwa.Text = selectedRow.Cells("Semestral_GWA").Value?.ToString()


                remarkslbl.Text = selectedRow.Cells("Remarks").Value?.ToString()

            Catch ex As Exception
                MessageBox.Show($"Failed to load selected course details: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub stp_datatable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles stp_datatable.CellContentClick

    End Sub
End Class
