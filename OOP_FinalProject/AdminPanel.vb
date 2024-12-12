Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient




Public Class AdminPanel
    Private userID As String

    Private AdminID As String

    Public Sub New(adminID As String)
        InitializeComponent()
        Me.AdminID = adminID
    End Sub


    Public Function GetDepartmentIdByName(departmentName As String) As String
        Try
            Dim query As String = "SELECT DEPARTMENT_ID FROM DEPARTMENT WHERE DEPARTMENT_NAME = @DepartmentName"
            Dim params As New Dictionary(Of String, Object) From {
                {"@DepartmentName", departmentName}
            }
            Dim row As DataRow = databaseConnection.GetDataRow(query, params)

            If row IsNot Nothing Then
                Return row("DEPARTMENT_ID").ToString()
            Else
                Return String.Empty
            End If
        Catch ex As Exception
            MessageBox.Show($"Error fetching department ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfessorData()
        PopulateDepartments()

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
            Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

            admin_profdatatable.DataSource = dt
        Catch ex As Exception
            MessageBox.Show($"Failed to load professor data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateDepartments()
        Try
            Dim query As String = "SELECT DEPARTMENT_NAME FROM DEPARTMENT"
            Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

            admin_txtprofdepartment.Items.Clear()
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No departments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            For Each row As DataRow In dt.Rows
                admin_txtprofdepartment.Items.Add(If(row("DEPARTMENT_NAME") Is DBNull.Value, String.Empty, row("DEPARTMENT_NAME").ToString()))
            Next
        Catch ex As Exception
            MessageBox.Show($"Failed to load departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub admin_profdatatable_SelectionChanged(sender As Object, e As EventArgs) Handles admin_profdatatable.SelectionChanged
        If admin_profdatatable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = admin_profdatatable.SelectedRows(0)

            admin_txtprofid.Text = selectedRow.Cells("Professor ID").Value.ToString()
            admin_txtprofname.Text = $"{selectedRow.Cells("First Name").Value} {selectedRow.Cells("Middle Name").Value} {selectedRow.Cells("Last Name").Value}"
            admin_txtprofdepartment.Text = selectedRow.Cells("Department Name").Value.ToString()
            admin_txtprofacademicyear.Text = ""
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
            Dim params As New Dictionary(Of String, Object) From {
                {"@professor_id", admin_txtprofid.Text},
                {"@first_name", firstName},
                {"@last_name", lastName},
                {"@middle_name", middleName},
                {"@department_id", departmentId},
                {"@status", If(admin_statustgl.Checked, "ACTIVE", "INACTIVE")}
            }
            databaseConnection.GetDataTable(query, params)

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

        Add_Professor.Show()

    End Sub

    Private Sub admin_profdelete_Click(sender As Object, e As EventArgs) Handles admin_profdelete.Click
        If admin_profdatatable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = admin_profdatatable.SelectedRows(0)

            Dim profID As String = selectedRow.Cells("PROFESSOR_ID").Value.ToString()
            Dim profFirstName As String = selectedRow.Cells("FIRST_NAME").Value.ToString()
            Dim profMiddleName As String = If(IsDBNull(selectedRow.Cells("MIDDLE_NAME").Value), "", selectedRow.Cells("MIDDLE_NAME").Value.ToString())
            Dim profLastName As String = selectedRow.Cells("LAST_NAME").Value.ToString()
            Dim deptID As String = selectedRow.Cells("DEPARTMENT_ID").Value.ToString()
            Dim status As String = selectedRow.Cells("STATUS").Value.ToString()

            Dim result As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete this professor?{vbNewLine}" &
            $"ID: {profID}{vbNewLine}Name: {profFirstName} {profMiddleName} {profLastName} {vbNewLine}" &
            $"Department: {deptID}{vbNewLine}Status: {status}",
            "Confirm Deletion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                DeleteProf(profID, profFirstName, profMiddleName, profLastName, deptID, status, selectedRow.Index)
            End If
        Else
            MessageBox.Show("No row selected. Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub DeleteProf(profID As String, profFirstName As String, profMiddleName As String, profLastName As String, deptID As Integer, status As String, rowIndex As Integer)
        Dim connectionString As String = "Server=localhost;user=root;Database=university_grading_system"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim deleteQuery As String = "DELETE FROM PROFESSOR WHERE PROFESSOR_ID = @professor_id AND FIRST_NAME = @first_name AND MIDDLE_NAME = @middle_name AND LAST_NAME = @last_name AND DEPARTMENT_ID = @DEPARTMENT_ID"
                Using command As New MySqlCommand(deleteQuery, connection)
                    command.Parameters.AddWithValue("@professor_id", profID)
                    command.Parameters.AddWithValue("@first_name", profFirstName)
                    command.Parameters.AddWithValue("@middle_name", profMiddleName)
                    command.Parameters.AddWithValue("@last_name", profLastName)
                    command.Parameters.AddWithValue("@department_id", deptID)
                    command.Parameters.AddWithValue("@status", status)
                    command.ExecuteNonQuery()
                End Using

                admin_profdatatable.Rows.RemoveAt(rowIndex)
                MessageBox.Show("Professor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
