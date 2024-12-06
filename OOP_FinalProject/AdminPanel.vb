Imports MySql.Data.MySqlClient

Public Module DatabaseConnection

    Dim cmd As New MySql.Data.MySqlClient.MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter
    Dim X As Integer = 0

    Public Function GetConnection() As MySql.Data.MySqlClient.MySqlConnection
        Dim connectionString As String = "server=localhost;user=root;database=GRADING_SYSTEM"
        Return New MySql.Data.MySqlClient.MySqlConnection(connectionString)
    End Function

    Public Function GetDepartmentIdByName(departmentName As String) As String
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Query to fetch department_id based on department_name
                Dim query As String = "SELECT DEPARTMENT_ID FROM DEPARTMENT WHERE DEPARTMENT_NAME = @DepartmentName"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DepartmentName", departmentName)

                    ' Execute the query to fetch the department ID
                    Dim departmentId As Object = cmd.ExecuteScalar()
                    If departmentId IsNot Nothing Then
                        Return departmentId.ToString()
                    Else
                        Return String.Empty ' Return empty if no matching department is found
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching department ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function
End Module

Public Class AdminPanel

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfessorData()
        PopulateCourses()
        PopulateDepartments()
        PopulateSemesters()

        timer.Interval = 1000
        timer.Enabled = True
        timer.Start()

        admin_profdatatable.ReadOnly = True
        admin_profdatatable.SelectionMode = DataGridViewSelectionMode.FullRowSelect
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

    Private Sub admin_profdatatable_SelectionChanged(sender As Object, e As EventArgs) Handles admin_profdatatable.SelectionChanged
        If admin_profdatatable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = admin_profdatatable.SelectedRows(0)

            ' Display the data in the textboxes
            admin_txtprofid.Text = selectedRow.Cells("Professor ID").Value.ToString()
            admin_txtprofname.Text = selectedRow.Cells("First Name").Value.ToString() & " " & selectedRow.Cells("Middle Name").Value.ToString() & " " & selectedRow.Cells("Last Name").Value.ToString()
            admin_txtprofdepartment.Text = selectedRow.Cells("Department Name").Value.ToString()
            admin_txtprofsemester.Text = "" ' Update based on your requirement
            admin_txtprofacademicyear.Text = "" ' Update based on your requirement
            admin_statustgl.Checked = selectedRow.Cells("Status").Value.ToString() = "ACTIVE"
        End If
    End Sub

    Dim x As Integer = 0
    Private Sub admin_addnewprof_Click(sender As Object, e As EventArgs) Handles admin_addnewprof.Click
        x = 1  ' This sets the operation to "Add"
        BtnforAddEdit()

        ' Clear the form for a new entry
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

    Public Sub admin_profUpdate_Click(sender As Object, e As EventArgs) Handles admin_profUpdate.Click
        Try
            Dim query As String
            Dim fullName As String = admin_txtprofname.Text.Trim()

            ' Split the full name into parts based on spaces
            Dim nameParts As String() = fullName.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

            ' Default values for first name, middle name, and last name
            Dim firstName As String = ""
            Dim middleName As String = ""
            Dim lastName As String = ""

            ' If there is at least one part, assign the first name
            If nameParts.Length > 0 Then
                firstName = nameParts(0)
            End If

            ' If there are more than two parts, treat the middle parts as middle name
            If nameParts.Length > 2 Then
                middleName = String.Join(" ", nameParts.Skip(1).Take(nameParts.Length - 2))
            End If

            ' The last part is considered the last name
            If nameParts.Length > 1 Then
                lastName = nameParts(nameParts.Length - 1)
            End If

            ' Get the department_id based on the selected department name from UI
            Dim departmentId As String = GetDepartmentIdByName(admin_txtprofdepartment.SelectedItem.ToString())

            If x = 1 Then
                ' Insert query for adding a new professor
                query = "INSERT INTO professor (professor_id, first_name, last_name, middle_name, department_id, status) 
                 VALUES (@professor_id, @first_name, @last_name, @middle_name, @department_id, @status)"
            ElseIf x = 2 Then
                ' Update query for updating an existing professor
                query = "UPDATE professor 
                 SET first_name = @first_name, 
                     last_name = @last_name, 
                     middle_name = @middle_name, 
                     department_id = @department_id, 
                     status = @status 
                 WHERE professor_id = @professor_id"
            Else
                Throw New Exception("Invalid operation. x must be 1 (Add) or 2 (Update).")
            End If

            ' Execute the query using the department_id
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@professor_id", admin_txtprofid.Text)
                    cmd.Parameters.AddWithValue("@first_name", firstName)
                    cmd.Parameters.AddWithValue("@last_name", lastName)
                    cmd.Parameters.AddWithValue("@middle_name", middleName)
                    cmd.Parameters.AddWithValue("@department_id", departmentId) ' Use department_id here
                    cmd.Parameters.AddWithValue("@status", If(admin_statustgl.Checked, "ACTIVE", "INACTIVE")) ' Handle active/inactive status
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Changes saved successfully.")

            ' Refresh the DataGridView after the update
            LoadProfessorData()

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PopulateCourses()
        Try
            Dim query As String = "SELECT SUBJECT_CODE, SUBJECT_TITLE FROM courses"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        admin_courseCB.Items.Clear()
                        While reader.Read()
                            admin_courseCB.Items.Add($"{reader("SUBJECT_TITLE")} ({reader("SUBJECT_CODE")})")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to load courses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateDepartments()
        Try
            Dim query As String = "SELECT DEPARTMENT_NAME FROM DEPARTMENT"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        admin_txtprofdepartment.Items.Clear()
                        While reader.Read()
                            admin_txtprofdepartment.Items.Add(reader("DEPARTMENT_NAME").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to load departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateSemesters()
        admin_txtprofsemester.Items.Clear()
        admin_txtprofsemester.Items.Add("First Semester")
        admin_txtprofsemester.Items.Add("Second Semester")
    End Sub

End Class