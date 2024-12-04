Imports System.Data.SqlClient
Imports System.Security
Imports System.Xml
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class StudentMainMenu
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost;user=root;database=gms")
    Dim student_id As String = "23-00242 " 'papalitan based sa log in na 

    Private Sub StudentMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer1.Start()
        Dim studentId As String = student_id ' Replace with the desired STUDENT_ID

        SetStudentDetails(studentId)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stp_clocktimer.Text = DateTime.Now.ToString("hh:mm:ss tt")
        stp_currentdate.Text = DateTime.Now.ToString("MM/dd/yyyy dddd")


    End Sub

    Private Sub Guna2HtmlLabel14_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel14.Click

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub SetStudentNameLabel(studentId As String)
        Try

            con.Open()


            str = "SELECT FIRST_NAME, MIDDLE_NAME, LAST_NAME FROM STUDENTS WHERE STUDENT_ID = @StudentID"


            cmd = New MySqlCommand(str, con)
            cmd.Parameters.AddWithValue("@StudentID", studentId)


            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Check if any record is returned
            If dt.Rows.Count > 0 Then
                ' Extract the name values from the first row
                Dim firstName As String = dt.Rows(0)("FIRST_NAME").ToString()
                Dim middleName As String = If(IsDBNull(dt.Rows(0)("MIDDLE_NAME")), "", dt.Rows(0)("MIDDLE_NAME").ToString())
                Dim lastName As String = dt.Rows(0)("LAST_NAME").ToString()

                ' Concatenate the full name
                Dim fullName As String = $"{firstName} {middleName} {lastName}".Trim()

                ' Set the label text to the full name
                STUDENT_NAME.Text = fullName
            End If

        Finally
            ' Close the database connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub SetStudentDetails(studentId As String)
        Try
            ' Open the database connection
            con.Open()

            ' SQL query to fetch the student's details
            str = "SELECT STUDENT_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, EMAIL, ADDRESS, BIRTHDAY, AGE 
                   FROM STUDENTS WHERE STUDENT_ID = @StudentID"

            ' Set up the command with the query and connection
            cmd = New MySqlCommand(str, con)
            cmd.Parameters.AddWithValue("@StudentID", studentId)

            ' Set up the data adapter and fill the data table
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Check if any record is returned
            If dt.Rows.Count > 0 Then
                ' Extract the details from the first row
                Dim fetchedStudentId As String = dt.Rows(0)("STUDENT_ID").ToString()
                Dim firstName As String = dt.Rows(0)("FIRST_NAME").ToString()
                Dim middleName As String = If(IsDBNull(dt.Rows(0)("MIDDLE_NAME")), "", dt.Rows(0)("MIDDLE_NAME").ToString())
                Dim lastName As String = dt.Rows(0)("LAST_NAME").ToString()
                Dim email As String = dt.Rows(0)("EMAIL").ToString()
                Dim address As String = dt.Rows(0)("ADDRESS").ToString()
                Dim birthday As String = Date.Parse(dt.Rows(0)("BIRTHDAY").ToString()).ToString("MMMM dd, yyyy")
                Dim age As String = dt.Rows(0)("AGE").ToString()

                ' Concatenate the full name
                Dim fullName As String = $"{firstName} {middleName} {lastName}".Trim()

                ' Set the labels for Student ID, Name, Email, Address, Birthday, and Age
                STUDENT_NAME.Text = fullName
                stp_studentid.Text = fetchedStudentId
                stp_emailaddress.Text = email
                stp_studentaddress.Text = address
                stp_birthdate.Text = birthday
                stp_age.Text = age
            End If
        Finally
            ' Close the database connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub SetStudentGrades(studentId As String)
        Try
            ' Open the database connection
            con.Open()

            ' SQL query to fetch the student's grades and course details
            str = "SELECT sg.MIDTERM_GRADE, sg.FINALS_GRADE, sg.SEMESTRAL_GRADE, 
                          c.SUBJECT_TITLE, c.SUBJECT_CODE, c.DEPARTMENT_ID, c.CURRICULUM_YEAR
                   FROM STUDENT_GRADES sg
                   INNER JOIN COURSES c ON sg.SUBJECT_CODE = c.SUBJECT_CODE
                   WHERE sg.STUDENT_ID = @StudentID"

            ' Set up the command with the query and connection
            cmd = New MySqlCommand(str, con)
            cmd.Parameters.AddWithValue("@StudentID", studentId)

            ' Set up the data adapter and fill the data table
            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Check if any record is returned
            If dt.Rows.Count > 0 Then
                ' Extract the details from the first row
                Dim midtermGrade As String = If(IsDBNull(dt.Rows(0)("MIDTERM_GRADE")), "N/A", dt.Rows(0)("MIDTERM_GRADE").ToString())
                Dim finalsGrade As String = If(IsDBNull(dt.Rows(0)("FINALS_GRADE")), "N/A", dt.Rows(0)("FINALS_GRADE").ToString())
                Dim semestralGrade As String = If(IsDBNull(dt.Rows(0)("SEMESTRAL_GRADE")), "N/A", dt.Rows(0)("SEMESTRAL_GRADE").ToString())
                Dim subjectTitle As String = dt.Rows(0)("SUBJECT_TITLE").ToString()
                Dim subjectCode As String = dt.Rows(0)("SUBJECT_CODE").ToString()
                Dim departmentId As String = dt.Rows(0)("DEPARTMENT_ID").ToString()
                Dim curriculumYear As String = dt.Rows(0)("CURRICULUM_YEAR").ToString()

                ' Set the labels for grades and course details
                stp_midtermpercentage.Text = midtermGrade
                stp_finalspercentage.Text = finalsGrade
                stp_semestralpercentage.Text = semestralGrade
                stp_coursename.Text = subjectTitle
                stp_coursecode.Text = subjectCode
                stp_department.Text = departmentId

            End If
        Finally
            ' Close the database connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Guna2ShadowPanel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel5.Paint

    End Sub

    Sub showenrollment()
        dt.Clear()
        str = "SELECT * FROM STUDENT_ENROLLMENTS WHERE STUDENT_ID = @StudentID"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = str
        da.SelectCommand = cmd
        da.Fill(dt)
        stp_datatable.DataSource = dt
        con.Close()
    End Sub
    Private Sub stp_datatable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles stp_datatable.CellContentClick

    End Sub

    Private Sub stp_datatable_Click(sender As Object, e As EventArgs) Handles stp_datatable.Click
        showenrollment()
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles STUDENT_NAME.Click

    End Sub
End Class