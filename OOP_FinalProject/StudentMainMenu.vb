Imports MySql.Data.MySqlClient

Public Class StudentMainMenu
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str As String
    Dim con As New MySqlConnection("server=localhost;user=root;database=grading_system")
    Dim student_email As String
    Dim student_id As String

    ' Constructor to accept email from LoginRegPanel
    Public Sub New(email As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the email value in the variable
        student_email = email
    End Sub

    Private Sub StudentMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set timer to update clock every second
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer1.Start()

        ' Fetch and display student details based on the email
        SetStudentDetailsByEmail(student_email)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update current time and date on the panel
        stp_clocktimer.Text = DateTime.Now.ToString("hh:mm:ss tt")
        stp_currentdate.Text = DateTime.Now.ToString("MM/dd/yyyy dddd")
    End Sub

    ' Function to fetch student details and student_id by email
    Private Sub SetStudentDetailsByEmail(email As String)
        Try
            con.Open()

            ' SQL query to get student details (including student_id) by email
            str = "SELECT STUDENT_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, EMAIL, ADDRESS, BIRTHDAY, AGE 
                       FROM STUDENTS WHERE EMAIL = @Email"

            cmd = New MySqlCommand(str, con)
            cmd.Parameters.AddWithValue("@Email", email)

            da = New MySqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)

            ' Check if the student is found
            If dt.Rows.Count > 0 Then
                ' Extract student details from the database
                student_id = dt.Rows(0)("STUDENT_ID").ToString() ' Save student_id
                Dim firstName As String = dt.Rows(0)("FIRST_NAME").ToString()
                Dim middleName As String = If(IsDBNull(dt.Rows(0)("MIDDLE_NAME")), "", dt.Rows(0)("MIDDLE_NAME").ToString())
                Dim lastName As String = dt.Rows(0)("LAST_NAME").ToString()
                Dim address As String = If(IsDBNull(dt.Rows(0)("ADDRESS")), "No Address Provided", dt.Rows(0)("ADDRESS").ToString())
                Dim birthday As String = Date.Parse(dt.Rows(0)("BIRTHDAY").ToString()).ToString("MMMM dd, yyyy")
                Dim age As String = dt.Rows(0)("AGE").ToString()

                ' Concatenate full name and display in the panel
                STUDENT_NAME.Text = $"{firstName} {middleName} {lastName}".Trim()
                stp_studentid.Text = student_id
                stp_emailaddress.Text = email
                stp_studentaddress.Text = address
                stp_birthdate.Text = birthday
                stp_age.Text = age

                ' Optionally, you can call other methods to fetch enrollments or grades
                showenrollment()
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally
            ' Ensure connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    ' Function to show enrollments in DataGrid
    Sub showenrollment()
        Try
            dt.Clear()

            ' SQL query to get enrollments for the student using student_id
            str = "SELECT * FROM STUDENT_ENROLLMENTS WHERE STUDENT_ID = @StudentID"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = str
            cmd.Parameters.AddWithValue("@StudentID", student_id) ' Use student_id to filter enrollments
            da.SelectCommand = cmd
            da.Fill(dt)

            ' Bind data to DataGrid
            stp_datatable.DataSource = dt
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    ' Handle DataGrid click event to show enrollments
    Private Sub stp_datatable_Click(sender As Object, e As EventArgs) Handles stp_datatable.Click
        showenrollment()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        LoginRegPanel.Show()
    End Sub

    Private Sub STUDENT_NAME_Click(sender As Object, e As EventArgs) Handles STUDENT_NAME.Click

    End Sub
End Class
