Public Class DEPARTMENT_PANEL

    ' Method to show all departments
    Public Sub ShowDepartments()
        ' SQL query to fetch data from the DEPARTMENT table
        Dim query As String = "SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENT"

        ' Fetch data using the GetDataTable method
        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        ' Check if data is retrieved
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Bind the DataTable to the DataGridView
            DEPARTMENTSTABLE.DataSource = dt
            MessageBox.Show("Department data loaded successfully.")
        Else
            MessageBox.Show("No department data found.")
        End If
    End Sub

    ' Load department data when the form loads
    Private Sub DEPARTMENT_PANEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDepartments()
    End Sub

    ' Handle selection change in the DataGridView
    Private Sub DEPARTMENTSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles DEPARTMENTSTABLE.SelectionChanged
        If DEPARTMENTSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DEPARTMENTSTABLE.SelectedRows(0)

            ' Retrieve cell values from the selected row
            Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()
            Dim departmentName As String = selectedRow.Cells("DEPARTMENT_NAME").Value?.ToString()

            ' Assign values to the corresponding TextBox or Label controls
            d_departmentid.Text = departmentID
            d_departmentname.Text = departmentName
        End If
    End Sub

    ' Handle update button click
    Private Sub departmentudpate_Click(sender As Object, e As EventArgs) Handles departmentudpate.Click
        ' Ensure all required fields are filled
        If String.IsNullOrEmpty(d_departmentid.Text) OrElse String.IsNullOrEmpty(d_departmentname.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to update the selected department
        Dim query As String = "UPDATE DEPARTMENT SET DEPARTMENT_NAME = @DEPARTMENT_NAME WHERE DEPARTMENT_ID = @DEPARTMENT_ID"

        ' Parameters for the query
        Dim params As New Dictionary(Of String, Object) From {
            {"@DEPARTMENT_ID", d_departmentid.Text},
            {"@DEPARTMENT_NAME", d_departmentname.Text}
        }

        ' Execute the update
        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Department data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowDepartments() ' Refresh the DataGridView to reflect the changes
        Else
            MessageBox.Show("Failed to update department data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Handle delete button click
    Private Sub departmentdelete_Click(sender As Object, e As EventArgs) Handles departmentdelete.Click
        ' Check if a row is selected
        If DEPARTMENTSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a department to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the DEPARTMENT_ID of the selected row
        Dim selectedRow As DataGridViewRow = DEPARTMENTSTABLE.SelectedRows(0)
        Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()

        If String.IsNullOrEmpty(departmentID) Then
            MessageBox.Show("The selected department does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the department with ID '{departmentID}'?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' SQL query to delete the department
            Dim query As String = "DELETE FROM DEPARTMENT WHERE DEPARTMENT_ID = @DEPARTMENT_ID"

            ' Parameters for the query
            Dim params As New Dictionary(Of String, Object) From {
                {"@DEPARTMENT_ID", departmentID}
            }

            ' Execute the delete query
            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Department deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowDepartments() ' Refresh the DataGridView to reflect the changes
                Else
                    MessageBox.Show("Failed to delete the department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Handle Add New Department button click
    Private Sub departmentaddnew_Click(sender As Object, e As EventArgs) Handles departmentaddnew.Click
        ADD_DEPARTMENT.Show()
    End Sub

End Class
