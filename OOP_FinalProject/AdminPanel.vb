Imports MySql.Data.MySqlClient
'aaksdhahsdbsabhabdasjbhasdsbh
Public Module DatabaseConnection

    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim X As Integer = 0

    Public Function GetConnection() As MySql.Data.MySqlClient.MySqlConnection
        Dim connectionString As String = "server=localhost;user=root;database=GRADING_SYSTEM"
        Return New MySql.Data.MySqlClient.MySqlConnection(connectionString)
    End Function
End Module

Public Class AdminPanel

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfessorData() ' Load professors into DataGridView
        LoadCourses() ' Load courses into the ListBox

        timer.Interval = 1000
        timer.Enabled = True
        timer.Start()

        LoadProfessorData()
    End Sub


    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        admin_currenttime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        admin_currentdate.Text = DateTime.Now.ToString("MM/dd/yyyy dddd")
    End Sub


    Private Sub LoadProfessorData()
        Try
            Dim query As String = "
                SELECT 
                    PROFESSOR.PROFESSOR_ID AS 'Professor ID',
                    PROFESSOR.FIRST_NAME AS 'First Name',
                    PROFESSOR.LAST_NAME AS 'Last Name',
                    PROFESSOR.MIDDLE_NAME AS 'Middle Name',
                    DEPARTMENT.DEPARTMENT_NAME AS 'Department Name',
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


                    admin_profdatatable.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to load professor data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim x As Integer = 0
    Private Sub admin_addnewprof_Click(sender As Object, e As EventArgs) Handles admin_addnewprof.Click
        x = 1
        BtnforAddEdit()
        admin_txtprofid.Text = ""
        admin_txtprofname.Text = ""
        admin_txtprofdepartment.Text = ""
        admin_txtprofsemester.Text = ""
        admin_txtprofacademicyear.Text = ""

        admin_profUpdate.Enabled = True
        admin_profdelete.Enabled = True
    End Sub

    Sub BtnforAddEdit()
        admin_txtprofid.Enabled = True
        admin_txtprofname.Enabled = True
        admin_txtprofdepartment.Enabled = True
        admin_txtprofsemester.Enabled = True
        admin_txtprofacademicyear.Enabled = True
    End Sub



    Private Sub LoadCourses()
        Try
            ' SQL Query to fetch courses
            Dim query As String = "
            SELECT SUBJECT_CODE, SUBJECT_TITLE 
            FROM subjects" ' Replace "subjects" with your actual table name

            ' Open connection and execute query
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    ' Clear the list before populating
                    admin_courseCB.Items.Clear()

                    ' Populate the ListBox
                    While reader.Read()
                        Dim course As String = $"{reader("SUBJECT_CODE")} - {reader("SUBJECT_TITLE")}"
                        admin_courseCB.Items.Add(course) ' Add to ListBox
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to load courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
