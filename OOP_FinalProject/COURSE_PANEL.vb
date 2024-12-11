Public Class COURSE_PANEL


    Public Sub ShowCourses()
        ' SQL query to fetch data from the CLASSES table
        Dim query As String = "SELECT COURSE_ID, COURSE_NAME, CREDITS, DEPARTMENT_ID FROM COURSES"


        ' Fetch data using the GetDataTable method
        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        ' Check if data is retrieved
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Bind the DataTable to the DataGridView
            COURSESTABLE.DataSource = dt
            MessageBox.Show("Classes data loaded successfully.")
        Else
            MessageBox.Show("No classes data found.")
        End If
    End Sub

    Private Sub COURSE_PANEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowCourses()
    End Sub

    Private Sub COURSESTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles COURSESTABLE.SelectionChanged
        If COURSESTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = COURSESTABLE.SelectedRows(0)

            ' Retrieve cell values from the selected row
            Dim courseID As String = selectedRow.Cells("COURSE_ID").Value?.ToString()
            Dim courseName As String = selectedRow.Cells("COURSE_NAME").Value?.ToString()
            Dim credits As String = selectedRow.Cells("CREDITS").Value?.ToString()
            Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()

            ' Assign values to the corresponding TextBox or Label controls
            coursecourseid.Text = courseID
            coursecoursename.Text = courseName
            coursecredits.Text = credits
            coursedepartmentid.Text = departmentID
        End If
    End Sub



    Private Sub courseupdate_Click(sender As Object, e As EventArgs) Handles courseupdate.Click
        ' Ensure all required fields are filled
        If String.IsNullOrEmpty(coursecourseid.Text) OrElse String.IsNullOrEmpty(coursecoursename.Text) OrElse
       String.IsNullOrEmpty(coursecredits.Text) OrElse String.IsNullOrEmpty(coursedepartmentid.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to update the selected course
        Dim query As String = "UPDATE COURSES SET COURSE_NAME = @COURSE_NAME, CREDITS = @CREDITS, DEPARTMENT_ID = @DEPARTMENT_ID WHERE COURSE_ID = @COURSE_ID"

        ' Parameters for the query
        Dim params As New Dictionary(Of String, Object) From {
        {"@COURSE_ID", coursecourseid.Text},
        {"@COURSE_NAME", coursecoursename.Text},
        {"@CREDITS", coursecredits.Text},
        {"@DEPARTMENT_ID", coursedepartmentid.Text}
    }

        ' Execute the update
        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Course data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowCourses() ' Refresh the DataGridView to reflect the changes
        Else
            MessageBox.Show("Failed to update course data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub admin_addnewprof_Click(sender As Object, e As EventArgs) Handles courseaddnew.Click
        ADD_COURSES.Show()
    End Sub

    Private Sub admin_faculty_Paint(sender As Object, e As PaintEventArgs) Handles admin_faculty.Paint

    End Sub

    Private Sub coursedelete_Click(sender As Object, e As EventArgs) Handles coursedelete.Click
        ' Check if a row is selected
        If COURSESTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a course to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the COURSE_ID of the selected row
        Dim selectedRow As DataGridViewRow = COURSESTABLE.SelectedRows(0)
        Dim courseID As String = selectedRow.Cells("COURSE_ID").Value?.ToString()

        If String.IsNullOrEmpty(courseID) Then
            MessageBox.Show("The selected course does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the course with ID '{courseID}'?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' SQL query to delete the course
            Dim query As String = "DELETE FROM COURSES WHERE COURSE_ID = @COURSE_ID"

            ' Parameters for the query
            Dim params As New Dictionary(Of String, Object) From {
            {"@COURSE_ID", courseID}
        }

            ' Execute the delete query
            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowCourses() ' Refresh the DataGridView to reflect the changes
                Else
                    MessageBox.Show("Failed to delete the course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


End Class