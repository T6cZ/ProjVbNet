Imports MySql.Data.MySqlClient

Public Class ProfessorPanel
    Private isAddingNewRow As Boolean = False ' Tracks if the user is adding a new row

    Private Sub ProfessorPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
    End Sub

    Private Sub LoadDepartments()
        Try
            Dim query As String = "SELECT DEPARTMENT_NAME FROM DEPARTMENT;"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        prof_departmentdrop.Items.Clear()
                        While reader.Read()
                            prof_departmentdrop.Items.Add(reader("DEPARTMENT_NAME").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to load departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub prof_departmentdrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prof_departmentdrop.SelectedIndexChanged
        If prof_departmentdrop.SelectedItem IsNot Nothing Then
            LoadSections(prof_departmentdrop.SelectedItem.ToString())
        End If
    End Sub

    Private Sub LoadSections(selectedDepartment As String)
        Try
            Dim query As String = "
                SELECT SECTION.YEAR_SECTION 
                FROM SECTION 
                INNER JOIN DEPARTMENT ON SECTION.DEPARTMENT_ID = DEPARTMENT.DEPARTMENT_ID
                WHERE DEPARTMENT.DEPARTMENT_NAME = @DepartmentName;"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DepartmentName", selectedDepartment)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        prof_sectiondrop.Items.Clear()
                        While reader.Read()
                            prof_sectiondrop.Items.Add(reader("YEAR_SECTION").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to load sections: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub prof_sectiondrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prof_sectiondrop.SelectedIndexChanged
        If prof_departmentdrop.SelectedItem IsNot Nothing AndAlso prof_sectiondrop.SelectedItem IsNot Nothing Then
            FilterStudentData()
        End If
    End Sub

    Private Sub FilterStudentData()
        Try
            Dim query As String = "
                SELECT 
                    STUDENTS.STUDENT_ID AS 'Student ID',
                    STUDENTS.LAST_NAME AS 'Last Name',
                    STUDENTS.MIDDLE_NAME AS 'Middle Name',
                    STUDENTS.FIRST_NAME AS 'First Name',
                    COURSES.SUBJECT_TITLE AS 'Subject Name',
                    SECTION.YEAR_SECTION AS 'Section',
                    STUDENT_GRADES.MIDTERM_GRADE AS 'Midterm Grade',
                    STUDENT_GRADES.FINALS_GRADE AS 'Finals Grade',
                    STUDENT_GRADES.SEMESTRAL_GRADE AS 'Semestral Grade',
                    STUDENT_GRADES.REMARKS AS 'Remarks'
                FROM 
                    STUDENTS
                INNER JOIN 
                    STUDENT_GRADES ON STUDENTS.STUDENT_ID = STUDENT_GRADES.STUDENT_ID
                INNER JOIN 
                    COURSES ON STUDENT_GRADES.SUBJECT_CODE = COURSES.SUBJECT_CODE
                INNER JOIN 
                    SECTION ON STUDENTS.YEAR_SECTION = SECTION.YEAR_SECTION
                INNER JOIN 
                    DEPARTMENT ON STUDENTS.DEPARTMENT_ID = DEPARTMENT.DEPARTMENT_ID
                WHERE 
                    DEPARTMENT.DEPARTMENT_NAME = @DepartmentName
                    AND SECTION.YEAR_SECTION = @Section;"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@DepartmentName", prof_departmentdrop.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Section", prof_sectiondrop.SelectedItem.ToString())
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    prof_datatable.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Failed to filter student data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Add new row
    Private Sub prof_addnewstudent_Click(sender As Object, e As EventArgs) Handles prof_addnewstudent.Click
        If Not isAddingNewRow Then
            Dim dt As DataTable = TryCast(prof_datatable.DataSource, DataTable)
            If dt IsNot Nothing Then
                Dim newRow As DataRow = dt.NewRow()
                dt.Rows.Add(newRow)
                prof_datatable.CurrentCell = prof_datatable.Rows(prof_datatable.Rows.Count - 1).Cells(0)
                isAddingNewRow = True
            End If
        End If
    End Sub

    ' Save new or updated data to the database
    Private Sub prof_updateinfo_Click(sender As Object, e As EventArgs) Handles prof_updateinfo.Click
        Try
            Dim dt As DataTable = TryCast(prof_datatable.DataSource, DataTable)
            If dt IsNot Nothing Then
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Using transaction = conn.BeginTransaction()
                        For Each row As DataRow In dt.Rows
                            If row.RowState = DataRowState.Added Then
                                ' Insert new record
                                Dim insertQuery As String = "INSERT INTO STUDENTS (STUDENT_ID, LAST_NAME, MIDDLE_NAME, FIRST_NAME) VALUES (@StudentID, @LastName, @MiddleName, @FirstName);"
                                Using cmd As New MySqlCommand(insertQuery, conn, transaction)
                                    cmd.Parameters.AddWithValue("@StudentID", row("Student ID"))
                                    cmd.Parameters.AddWithValue("@LastName", row("Last Name"))
                                    cmd.Parameters.AddWithValue("@MiddleName", row("Middle Name"))
                                    cmd.Parameters.AddWithValue("@FirstName", row("First Name"))
                                    cmd.ExecuteNonQuery()
                                End Using
                            ElseIf row.RowState = DataRowState.Modified Then
                                ' Update existing record
                                Dim updateQuery As String = "UPDATE STUDENTS SET LAST_NAME = @LastName, MIDDLE_NAME = @MiddleName, FIRST_NAME = @FirstName WHERE STUDENT_ID = @StudentID;"
                                Using cmd As New MySqlCommand(updateQuery, conn, transaction)
                                    cmd.Parameters.AddWithValue("@StudentID", row("Student ID"))
                                    cmd.Parameters.AddWithValue("@LastName", row("Last Name"))
                                    cmd.Parameters.AddWithValue("@MiddleName", row("Middle Name"))
                                    cmd.Parameters.AddWithValue("@FirstName", row("First Name"))
                                    cmd.ExecuteNonQuery()
                                End Using
                            End If
                        Next
                        transaction.Commit()
                    End Using
                End Using
                MessageBox.Show("Changes saved successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to save changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        isAddingNewRow = False
    End Sub

    ' Delete selected row
    Private Sub prof_deleteentry_Click(sender As Object, e As EventArgs) Handles prof_deleteentry.Click
        If prof_datatable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = prof_datatable.SelectedRows(0)
            Dim studentID As String = selectedRow.Cells("Student ID").Value.ToString()
            Dim confirmation = MessageBox.Show($"Are you sure you want to delete Student ID {studentID}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirmation = DialogResult.Yes Then
                Try
                    Dim deleteQuery As String = "DELETE FROM STUDENTS WHERE STUDENT_ID = @StudentID;"
                    Using conn As MySqlConnection = GetConnection()
                        conn.Open()
                        Using cmd As New MySqlCommand(deleteQuery, conn)
                            cmd.Parameters.AddWithValue("@StudentID", studentID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    prof_datatable.Rows.Remove(selectedRow)
                    MessageBox.Show("Record deleted successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Failed to delete record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
