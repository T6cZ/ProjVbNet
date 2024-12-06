Imports MySql.Data.MySqlClient

Public Class ProfessorPanel
    Private isAddingNewRow As Boolean = False

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
                    STUDENT_GRADES.REMARKS AS 'Remarks',
                    STUDENT_GRADES.GRADE_EQUIVALENT AS 'Grade Equivalent'
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

    ' Automatically calculate Semestral Grade and determine Remarks
    Private Sub prof_datatable_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles prof_datatable.CellValueChanged
        If e.ColumnIndex = prof_datatable.Columns("Midterm Grade").Index OrElse e.ColumnIndex = prof_datatable.Columns("Finals Grade").Index Then
            Dim midtermGrade As Decimal
            Dim finalsGrade As Decimal

            If Decimal.TryParse(prof_datatable.Rows(e.RowIndex).Cells("Midterm Grade").Value?.ToString(), midtermGrade) AndAlso
               Decimal.TryParse(prof_datatable.Rows(e.RowIndex).Cells("Finals Grade").Value?.ToString(), finalsGrade) Then

                Dim semestralGrade = Math.Round((midtermGrade + finalsGrade) / 2, 2)
                prof_datatable.Rows(e.RowIndex).Cells("Semestral Grade").Value = semestralGrade

                ' Determine Remarks
                Dim remarks As String = If(semestralGrade >= 3.0, "FAILED", "PASSED")
                prof_datatable.Rows(e.RowIndex).Cells("Remarks").Value = remarks

                ' Transmute Grade
                Dim gradeEquivalent = TransmuteGrade(semestralGrade)
                prof_datatable.Rows(e.RowIndex).Cells("Grade Equivalent").Value = gradeEquivalent
            End If
        End If
    End Sub

    Private Function TransmuteGrade(semestralGrade As Decimal) As Decimal
        ' Example transmutation logic (replace with your logic if needed)
        If semestralGrade >= 1.0 AndAlso semestralGrade <= 3.0 Then
            Return semestralGrade ' Adjust this as per your grading system
        End If
        Return 5.0 ' Default to failing grade
    End Function

    Private Sub prof_updateinfo_Click(sender As Object, e As EventArgs) Handles prof_updateinfo.Click
        Try
            Dim dt As DataTable = TryCast(prof_datatable.DataSource, DataTable)
            If dt IsNot Nothing Then
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    Using transaction = conn.BeginTransaction()
                        For Each row As DataRow In dt.Rows
                            If row.RowState = DataRowState.Modified Then
                                Dim updateQuery As String = "
                                    UPDATE STUDENT_GRADES 
                                    SET MIDTERM_GRADE = @MidtermGrade, FINALS_GRADE = @FinalsGrade, 
                                        SEMESTRAL_GRADE = @SemestralGrade, REMARKS = @Remarks, 
                                        GRADE_EQUIVALENT = @GradeEquivalent
                                    WHERE STUDENT_ID = @StudentID;"
                                Using cmd As New MySqlCommand(updateQuery, conn, transaction)
                                    cmd.Parameters.AddWithValue("@StudentID", row("Student ID"))
                                    cmd.Parameters.AddWithValue("@MidtermGrade", row("Midterm Grade"))
                                    cmd.Parameters.AddWithValue("@FinalsGrade", row("Finals Grade"))
                                    cmd.Parameters.AddWithValue("@SemestralGrade", row("Semestral Grade"))
                                    cmd.Parameters.AddWithValue("@Remarks", row("Remarks"))
                                    cmd.Parameters.AddWithValue("@GradeEquivalent", row("Grade Equivalent"))
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
    End Sub
End Class
