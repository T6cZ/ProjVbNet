Public Class ENROLLMENT_PANEL

    ' Method to show all enrollments
    Public Sub ShowEnrollments()
        ' SQL query to fetch data from the ENROLLMENTS table
        Dim query As String = "SELECT ENROLLMENT_ID, STUDENT_ID, CLASS_ID, ENROLL_DATE, SEMESTER FROM ENROLLMENTS"

        ' Fetch data using the GetDataTable method
        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        ' Check if data is retrieved
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Bind the DataTable to the DataGridView
            ENROLLMENTSTABLE.DataSource = dt
            MessageBox.Show("Enrollment data loaded successfully.")
        Else
            MessageBox.Show("No enrollment data found.")
        End If
    End Sub

    ' Load the enrollment data when the form loads
    Private Sub ENROLLMENT_PANEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowEnrollments()
    End Sub

    ' Handle selection change in the DataGridView
    Private Sub ENROLLMENTSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles ENROLLMENTSTABLE.SelectionChanged
        If ENROLLMENTSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ENROLLMENTSTABLE.SelectedRows(0)

            ' Retrieve cell values from the selected row
            Dim enrollmentID As String = selectedRow.Cells("ENROLLMENT_ID").Value?.ToString()
            Dim studentID As String = selectedRow.Cells("STUDENT_ID").Value?.ToString()
            Dim classID As String = selectedRow.Cells("CLASS_ID").Value?.ToString()
            Dim enrollDate As String = selectedRow.Cells("ENROLL_DATE").Value?.ToString()
            Dim semester As String = selectedRow.Cells("SEMESTER").Value?.ToString()

            ' Assign values to the corresponding TextBox or Label controls
            e_enrollmentid.Text = enrollmentID
            e_studentname.Text = studentID
            e_enrollmentdate.Text = enrollDate
            e_semester.Text = semester
        End If
    End Sub

    ' Handle update button click
    Private Sub enrollmentupdate_Click(sender As Object, e As EventArgs) Handles enrollmentupdate.Click
        ' Ensure all required fields are filled
        If String.IsNullOrEmpty(e_enrollmentid.Text) OrElse String.IsNullOrEmpty(e_studentname.Text) OrElse
       String.IsNullOrEmpty(e_classid.Text) OrElse String.IsNullOrEmpty(e_semester.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to update the selected enrollment
        Dim query As String = "UPDATE ENROLLMENTS SET STUDENT_ID = @STUDENT_ID, CLASS_ID = @CLASS_ID, SEMESTER = @SEMESTER WHERE ENROLLMENT_ID = @ENROLLMENT_ID"

        ' Parameters for the query
        Dim params As New Dictionary(Of String, Object) From {
        {"@ENROLLMENT_ID", e_enrollmentid.Text},
        {"@STUDENT_ID", e_studentname.Text},
        {"@CLASS_ID", e_classid.Text},
        {"@SEMESTER", e_semester.Text}
    }

        ' Execute the update
        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Enrollment data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowEnrollments() ' Refresh the DataGridView to reflect the changes
        Else
            MessageBox.Show("Failed to update enrollment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Handle delete button click
    Private Sub enrollmentdelete_Click(sender As Object, e As EventArgs) Handles enrollmentdelete.Click
        ' Check if a row is selected
        If ENROLLMENTSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an enrollment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the ENROLLMENT_ID of the selected row
        Dim selectedRow As DataGridViewRow = ENROLLMENTSTABLE.SelectedRows(0)
        Dim enrollmentID As String = selectedRow.Cells("ENROLLMENT_ID").Value?.ToString()

        If String.IsNullOrEmpty(enrollmentID) Then
            MessageBox.Show("The selected enrollment does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the enrollment with ID '{enrollmentID}'?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' SQL query to delete the enrollment
            Dim query As String = "DELETE FROM ENROLLMENTS WHERE ENROLLMENT_ID = @ENROLLMENT_ID"

            ' Parameters for the query
            Dim params As New Dictionary(Of String, Object) From {
            {"@ENROLLMENT_ID", enrollmentID}
        }

            ' Execute the delete query
            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Enrollment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowEnrollments() ' Refresh the DataGridView to reflect the changes
                Else
                    MessageBox.Show("Failed to delete the enrollment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting enrollment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub courseaddnew_Click(sender As Object, e As EventArgs) Handles courseaddnew.Click
        ADD_ENROLLMENT.Show()
    End Sub
End Class

