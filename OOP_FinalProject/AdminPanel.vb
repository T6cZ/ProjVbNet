Imports MySql.Data.MySqlClient

Public Module DatabaseConnection
    Public Function GetConnection() As MySqlConnection

        Dim connectionString As String = "server=localhost; user=root; database=gms"
        Return New MySqlConnection(connectionString)
    End Function
End Module

Public Class AdminPanel

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub admin_addnewprof_Click(sender As Object, e As EventArgs) Handles admin_addnewprof.Click

    End Sub

    Private Sub admin_profUpdate_Click(sender As Object, e As EventArgs) Handles admin_profUpdate.Click

    End Sub

    Private Sub admin_profdelete_Click(sender As Object, e As EventArgs) Handles admin_profdelete.Click
    End Sub
End Class
