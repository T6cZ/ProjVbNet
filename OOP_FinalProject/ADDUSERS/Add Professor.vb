Imports MySql.Data.MySqlClient

Public Class Add_Professor

    Sub LoadDepartments()
        Dim query As String = "SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENT;"
        Dim dt As DataTable = GetDataTable(query, New Dictionary(Of String, Object)())

        If dt.Rows.Count > 0 Then
            DEPARTMENTID.DataSource = dt
            DEPARTMENTID.DisplayMember = "DEPARTMENT_NAME"
            DEPARTMENTID.ValueMember = "DEPARTMENT_ID"
        Else
            MessageBox.Show("No departments available.")
        End If
    End Sub

    Private Sub AddProfessorButton_Click(sender As Object, e As EventArgs) Handles AddProfessorButton.Click
        Try
            ' Validate required fields
            If String.IsNullOrEmpty(prof_ID.Text) OrElse String.IsNullOrEmpty(prof_firstname.Text) OrElse String.IsNullOrEmpty(prof_lastname.Text) OrElse DEPARTMENTID.SelectedIndex = -1 OrElse String.IsNullOrEmpty(prof_email.Text) OrElse String.IsNullOrEmpty(prof_password.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Query to insert a new professor
            Dim query As String = "
                INSERT INTO PROFESSOR (
                    PROFESSOR_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, DEPARTMENT_ID
                ) VALUES (
                    @ProfessorID, @FirstName, @MiddleName, @LastName, @DepartmentID
                );"

            ' Parameters for the query
            Dim params As New Dictionary(Of String, Object) From {
                {"@ProfessorID", prof_ID.Text.Trim()},
                {"@FirstName", prof_firstname.Text.Trim()},
                {"@MiddleName", If(String.IsNullOrEmpty(prof_middlename.Text.Trim()), DBNull.Value, prof_middlename.Text.Trim())},
                {"@LastName", prof_lastname.Text.Trim()},
                {"@DepartmentID", DEPARTMENTID.SelectedValue}
            }

            ' Execute the query
            Dim rowsAffected = ExecuteQuery(query, params)

            If rowsAffected > 0 Then
                ' Add login credentials
                AddLoginCredentials(prof_email.Text.Trim(), prof_password.Text.Trim(), "PROFESSOR")
                MessageBox.Show("Professor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
            Else
                MessageBox.Show("Failed to add professor. Please check the data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show($"Failed to add professor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddLoginCredentials(email As String, password As String, role As String)
        Try
            Dim query As String = "
                INSERT INTO LOGIN (EMAIL, PASSWORD, ROLE)
                VALUES (@Email, @Password, @Role);"

            Dim params As New Dictionary(Of String, Object) From {
                {"@Email", email},
                {"@Password", password},
                {"@Role", role}
            }

            ExecuteQuery(query, params)
        Catch ex As Exception
            MessageBox.Show($"Failed to add login credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        ' Clear all input fields
        prof_ID.Clear()
        prof_firstname.Clear()
        prof_middlename.Clear()
        prof_lastname.Clear()
        prof_email.Clear()
        prof_password.Clear()
        DEPARTMENTID.SelectedIndex = -1
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

    Private Sub Add_Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
    End Sub

End Class
