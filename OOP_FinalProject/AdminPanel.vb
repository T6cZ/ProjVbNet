Imports MySql.Data.MySqlClient

Public Module DatabaseConnection
    Public Function GetConnection() As MySqlConnection
        Dim connectionString As String = "server=localhost;user id=root;database=GRADING_SYSTEM"
        Return New MySqlConnection(connectionString)
    End Function
End Module



Public Class AdminPanel

    Public Function GetDepartmentIdByName(departmentName As String) As String
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String = "SELECT DEPARTMENT_ID FROM DEPARTMENT WHERE DEPARTMENT_NAME = @DepartmentName"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DepartmentName", departmentName)
                    Dim departmentId As Object = cmd.ExecuteScalar()
                    If departmentId IsNot Nothing Then
                        Return departmentId.ToString()
                    Else
                        Return String.Empty
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching department ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfessorData()
        PopulateDepartments()
        PopulateSemesters()


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

    ' Populate department combobox
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


    Private Sub admin_profdatatable_SelectionChanged(sender As Object, e As EventArgs) Handles admin_profdatatable.SelectionChanged
        If admin_profdatatable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = admin_profdatatable.SelectedRows(0)


            admin_txtprofid.Text = selectedRow.Cells("Professor ID").Value.ToString()
            admin_txtprofname.Text = $"{selectedRow.Cells("First Name").Value} {selectedRow.Cells("Middle Name").Value} {selectedRow.Cells("Last Name").Value}"
            admin_txtprofdepartment.Text = selectedRow.Cells("Department Name").Value.ToString()
            admin_txtprofsemester.Text = "" ' Leave empty unless tied to your logic
            admin_txtprofacademicyear.Text = "" ' Leave empty unless tied to your logic
            admin_statustgl.Checked = selectedRow.Cells("Status").Value.ToString() = "ACTIVE"
        End If
    End Sub

    Private Sub admin_profUpdate_Click(sender As Object, e As EventArgs) Handles admin_profUpdate.Click
        Try

            Dim fullName As String = admin_txtprofname.Text.Trim()
            Dim nameParts As String() = fullName.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            Dim firstName As String = If(nameParts.Length > 0, nameParts(0), "")
            Dim middleName As String = If(nameParts.Length > 2, String.Join(" ", nameParts.Skip(1).Take(nameParts.Length - 2)), "")
            Dim lastName As String = If(nameParts.Length > 1, nameParts.Last(), "")


            Dim departmentId As String = GetDepartmentIdByName(admin_txtprofdepartment.Text)
            If String.IsNullOrEmpty(departmentId) Then
                MessageBox.Show("Please select a valid department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim query As String = "
                UPDATE PROFESSOR 
                SET FIRST_NAME = @first_name, 
                    LAST_NAME = @last_name, 
                    MIDDLE_NAME = @middle_name, 
                    DEPARTMENT_ID = @department_id, 
                    STATUS = @status 
                WHERE PROFESSOR_ID = @professor_id;"


            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@professor_id", admin_txtprofid.Text)
                    cmd.Parameters.AddWithValue("@first_name", firstName)
                    cmd.Parameters.AddWithValue("@last_name", lastName)
                    cmd.Parameters.AddWithValue("@middle_name", middleName)
                    cmd.Parameters.AddWithValue("@department_id", departmentId)
                    cmd.Parameters.AddWithValue("@status", If(admin_statustgl.Checked, "ACTIVE", "INACTIVE"))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Professor details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadProfessorData()
        Catch ex As Exception
            MessageBox.Show($"Failed to update professor details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub admin_addnewprof_Click(sender As Object, e As EventArgs) Handles admin_addnewprof.Click
        Dim addProfessorForm As New Add_Professor()
        addProfessorForm.ShowDialog()

        LoadProfessorData()
    End Sub
End Class
