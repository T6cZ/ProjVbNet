Public Class CLASSPANEL

    Public Sub ShowClasses()
        ' SQL query to fetch data from the CLASSES table
        Dim query As String = "SELECT CLASS_ID, SECTION_ID, COURSE_ID, PROFESSOR_ID, TERM, ACADEMIC_YEAR FROM CLASSES"

        ' Fetch data using the GetDataTable method
        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        ' Check if data is retrieved
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Bind the DataTable to the DataGridView
            CLASSTABLE.DataSource = dt
            MessageBox.Show("Classes data loaded successfully.")
        Else
            MessageBox.Show("No classes data found.")
        End If
    End Sub

    Private Sub CLASSPANEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowClasses()
    End Sub

    Private Sub CLASSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles CLASSTABLE.SelectionChanged
        If CLASSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = CLASSTABLE.SelectedRows(0)

            ' Retrieve cell values from the selected row
            Dim classID As String = selectedRow.Cells("CLASS_ID").Value?.ToString()
            Dim sectionID As String = selectedRow.Cells("SECTION_ID").Value?.ToString()
            Dim courseID As String = selectedRow.Cells("COURSE_ID").Value?.ToString()
            Dim professorID As String = selectedRow.Cells("PROFESSOR_ID").Value?.ToString()
            Dim term As String = selectedRow.Cells("TERM").Value?.ToString()
            Dim academicYear As String = selectedRow.Cells("ACADEMIC_YEAR").Value?.ToString()

            ' Assign values to the corresponding TextBox or Label controls
            txtclassid.Text = classID
            txtcourseid.Text = courseID
            txtprofessorid.Text = professorID
            cbterm.Text = term
            txtacademicyear.Text = academicYear
        End If
    End Sub

    Private Sub admin_addnewprof_Click(sender As Object, e As EventArgs) Handles admin_addnewprof.Click
        ADD_CLASS.Show()
    End Sub

    Private Sub admin_profUpdate_Click(sender As Object, e As EventArgs) Handles classupdate.Click
        txtclassid.Enabled = True
        txtcourseid.Enabled = True
        txtprofessorid.Enabled = True
        cbterm.Enabled = True
        txtacademicyear.Enabled = True
    End Sub

    Private Sub classupdate_Click(sender As Object, e As EventArgs) Handles classupdate.Click
        ' Ensure all required fields are filled
        If String.IsNullOrEmpty(txtclassid.Text) OrElse String.IsNullOrEmpty(txtcourseid.Text) OrElse
           String.IsNullOrEmpty(txtprofessorid.Text) OrElse String.IsNullOrEmpty(cbterm.Text) OrElse
           String.IsNullOrEmpty(txtacademicyear.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to update the selected class
        Dim query As String = "UPDATE CLASSES SET COURSE_ID = @COURSE_ID, PROFESSOR_ID = @PROFESSOR_ID, TERM = @TERM, ACADEMIC_YEAR = @ACADEMIC_YEAR WHERE CLASS_ID = @CLASS_ID"

        ' Parameters for the query
        Dim params As New Dictionary(Of String, Object) From {
            {"@CLASS_ID", txtclassid.Text},
            {"@COURSE_ID", txtcourseid.Text},
            {"@PROFESSOR_ID", txtprofessorid.Text},
            {"@TERM", cbterm.Text},
            {"@ACADEMIC_YEAR", txtacademicyear.Text}
        }

        ' Execute the update
        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Class data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowClasses() ' Refresh the DataGridView to reflect the changes
        Else
            MessageBox.Show("Failed to update class data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub admin_profdelete_Click(sender As Object, e As EventArgs) Handles admin_profdelete.Click

    End Sub
End Class
