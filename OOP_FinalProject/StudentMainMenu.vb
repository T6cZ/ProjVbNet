Imports MySql.Data.MySqlClient

Public Class StudentMainMenu
    Private ReadOnly LoggedInStudentID As String

    Public Sub New(studentID As String)
        InitializeComponent()
        LoggedInStudentID = studentID
    End Sub

    Private Sub StudentMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentInfo()
        LoadStudentCourses()
    End Sub

    Private Sub LoadStudentInfo()
        Dim query As String = "SELECT DISTINCT " &
                          "CONCAT(Student.Last_Name, ' ', Student.Middle_Name, ' ', Student.First_Name) AS FullName, " &
                          "Student.Student_ID, " &
                          "Student.Department AS Department_Name, " &
                          "Sections.Section_Name, " &
                          "Login.EMAIL AS EmailAddress, " &
                          "Student.Address, " &
                          "Student.Birthdate, " &
                          "TIMESTAMPDIFF(YEAR, Student.Birthdate, CURDATE()) AS Age " &
                          "FROM STUDENT " &
                          "INNER JOIN LOGIN ON STUDENT.USER_ID = LOGIN.USER_ID " &
                          "LEFT JOIN Enrollments ON STUDENT.Student_ID = Enrollments.Student_ID " &
                          "LEFT JOIN Sections ON Enrollments.Section_ID = Sections.Section_ID " &
                          "WHERE STUDENT.USER_ID = @studentID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@studentID", LoggedInStudentID}
    }


        Dim studentRow As DataRow = databaseConnection.GetDataRow(query, params)

        If studentRow IsNot Nothing Then
            namelbl.Text = studentRow("FullName").ToString()
            studentidlbl.Text = studentRow("Student_ID").ToString()
            departmentlbl.Text = studentRow("Department_Name").ToString()
            sectionlbl.Text = studentRow("Section_Name").ToString()
            emailaddresslbl.Text = studentRow("EmailAddress").ToString()
            addresslbl.Text = studentRow("Address").ToString()
            birthdatelbl.Text = Convert.ToDateTime(studentRow("Birthdate")).ToShortDateString()
            agelbl.Text = studentRow("Age").ToString()
        Else
            MessageBox.Show("Student information not found.")
        End If
    End Sub



    Private Sub LoadStudentCourses()
        Dim query As String = "SELECT DISTINCT 
        Courses.COURSE_NAME AS Course, 
        Courses.COURSE_ID AS CourseCode,
        CONCAT(Professor.FIRST_NAME, ' ', Professor.LAST_NAME) AS ProfessorName, 
        Enrollments.TERM AS Term, 
        Final_Grades.MIDTERM_PERCENTAGE, 
        Final_Grades.FINAL_PERCENTAGE, 
        Final_Grades.SEMESTRAL_PERCENTAGE, 
        Final_Grades.REMARKS,
        Final_Grades.MIDTERM_GWA,
        Final_Grades.FINAL_GWA,
        Final_Grades.GWA
    FROM Enrollments 
    INNER JOIN Sections ON Enrollments.Section_ID = Sections.Section_ID 
    INNER JOIN Courses ON Sections.Course_ID = Courses.COURSE_ID 
    INNER JOIN Classes ON Sections.Section_ID = Classes.Section_ID 
    INNER JOIN Professor ON Classes.Professor_ID = Professor.Professor_ID 
    LEFT JOIN Final_Grades ON Enrollments.CLASS_ID = Final_Grades.CLASS_ID 
    WHERE Enrollments.Student_ID = (
        SELECT Student_ID FROM STUDENT WHERE USER_ID = @studentID
    );"

        Dim params As New Dictionary(Of String, Object) From {
        {"@studentID", LoggedInStudentID}
    }

        Try
            Dim coursesTable As DataTable = databaseConnection.GetDataTable(query, params)

            stp_datatable.DataSource = coursesTable

            If stp_datatable.Columns.Contains("MIDTERM_GWA") Then
                stp_datatable.Columns("MIDTERM_GWA").Visible = False
            End If

            If stp_datatable.Columns.Contains("FINAL_GWA") Then
                stp_datatable.Columns("FINAL_GWA").Visible = False
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

            Dim courseName As String = selectedRow.Cells("Course").Value?.ToString()
            Dim courseCode As String = selectedRow.Cells("CourseCode").Value?.ToString()
            Dim professorName As String = selectedRow.Cells("ProfessorName").Value?.ToString()
            Dim term As String = selectedRow.Cells("Term").Value?.ToString()
            Dim midtermGrade As String = selectedRow.Cells("MIDTERM_PERCENTAGE").Value?.ToString()
            Dim finalGrade As String = selectedRow.Cells("Final_PERCENTAGE").Value?.ToString()
            Dim semestralGrade As String = selectedRow.Cells("Semestral_PERCENTAGE").Value?.ToString()
            Dim remarks As String = selectedRow.Cells("Remarks").Value?.ToString()

            Dim midtermGWA As String = selectedRow.Cells("Midterm_GWA").Value?.ToString()
            Dim finalGWA As String = selectedRow.Cells("Final_GWA").Value?.ToString()
            Dim semestralGWA As String = selectedRow.Cells("GWA").Value?.ToString()

            stp_coursename.Text = courseName
            stp_coursecode.Text = courseCode
            stp_professorname.Text = professorName
            stp_semester.Text = term

            stp_midtermpercentage.Text = midtermGrade
            stp_finalspercentage.Text = finalGrade
            stp_semestralpercentage.Text = semestralGrade

            stp_midtermgwa.Text = midtermGWA
            stp_finalsgwa.Text = finalGWA
            stp_semestragwa.Text = semestralGWA

            remarkslbl.Text = remarks
        End If
    End Sub

End Class
