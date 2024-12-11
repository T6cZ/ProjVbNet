Imports System.Collections.Specialized.BitVector32

Public Class SECTION_PANEL

    ' Method to show all sections
    Public Sub ShowSections()
        ' SQL query to fetch data from the SECTIONS table
        Dim query As String = "SELECT SECTION_ID, SECTION_NAME, DEPARTMENT_ID, YEAR_LEVEL FROM SECTIONS"

        ' Fetch data using the GetDataTable method
        Dim dt As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

        ' Check if data is retrieved
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Bind the DataTable to the DataGridView
            SECTIONSTABLE.DataSource = dt
            MessageBox.Show("Section data loaded successfully.")
        Else
            MessageBox.Show("No section data found.")
        End If
    End Sub

    ' Load the section data when the form loads
    Private Sub SECTION_PANEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowSections()
    End Sub

    ' Handle selection change in the DataGridView
    Private Sub SECTIONSTABLE_SelectionChanged(sender As Object, e As EventArgs) Handles SECTIONSTABLE.SelectionChanged
        If SECTIONSTABLE.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = SECTIONSTABLE.SelectedRows(0)

            ' Retrieve cell values from the selected row
            Dim sectionID As String = selectedRow.Cells("SECTION_ID").Value?.ToString()
            Dim sectionName As String = selectedRow.Cells("SECTION_NAME").Value?.ToString()
            Dim departmentID As String = selectedRow.Cells("DEPARTMENT_ID").Value?.ToString()
            Dim yearLevel As String = selectedRow.Cells("YEAR_LEVEL").Value?.ToString()

            ' Assign values to the corresponding TextBox or Label controls
            s_sectionid.Text = sectionID
            s_sectionname.Text = sectionName
            s_departmentid.Text = departmentID
            s_yearlevel.Text = yearLevel
        End If
    End Sub

    ' Handle update button click
    Private Sub sectionupdate_Click(sender As Object, e As EventArgs) Handles sectionupdate.Click
        ' Ensure all required fields are filled
        If String.IsNullOrEmpty(s_sectionname.Text) OrElse String.IsNullOrEmpty(s_departmentid.Text) OrElse
       String.IsNullOrEmpty(s_yearlevel.Text) Then
            MessageBox.Show("Please fill in all fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate numeric input for year level
        Dim yearLevelValue As Integer
        If Not Integer.TryParse(s_yearlevel.Text, yearLevelValue) Then
            MessageBox.Show("Year Level must be a valid number.")
            Return
        End If

        ' SQL query to update the selected section
        Dim query As String = "UPDATE SECTIONS SET SECTION_NAME = @SECTION_NAME, DEPARTMENT_ID = @DEPARTMENT_ID, YEAR_LEVEL = @YEAR_LEVEL WHERE SECTION_ID = @SECTION_ID"

        ' Parameters for the query
        Dim params As New Dictionary(Of String, Object) From {
        {"@SECTION_ID", s_sectionid.Text},
        {"@SECTION_NAME", s_sectionname.Text},
        {"@DEPARTMENT_ID", s_departmentid.Text},
        {"@YEAR_LEVEL", yearLevelValue}
    }

        ' Execute the update
        Dim isUpdated As Boolean = databaseConnection.InsertData(query, params)

        If isUpdated Then
            MessageBox.Show("Section data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowSections() ' Refresh the DataGridView to reflect the changes
        Else
            MessageBox.Show("Failed to update section data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Handle delete button click
    Private Sub sectiondelete_Click(sender As Object, e As EventArgs) Handles sectiondelete.Click
        ' Check if a row is selected
        If SECTIONSTABLE.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a section to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Retrieve the SECTION_ID of the selected row
        Dim selectedRow As DataGridViewRow = SECTIONSTABLE.SelectedRows(0)
        Dim sectionID As String = selectedRow.Cells("SECTION_ID").Value?.ToString()

        If String.IsNullOrEmpty(sectionID) Then
            MessageBox.Show("The selected section does not have a valid ID.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the section with ID '{sectionID}'?",
                                                    "Confirm Deletion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)

        If confirmResult = DialogResult.Yes Then
            ' SQL query to delete the section
            Dim query As String = "DELETE FROM SECTIONS WHERE SECTION_ID = @SECTION_ID"

            ' Parameters for the query
            Dim params As New Dictionary(Of String, Object) From {
            {"@SECTION_ID", sectionID}
        }

            ' Execute the delete query
            Try
                Dim isDeleted As Boolean = databaseConnection.InsertData(query, params)

                If isDeleted Then
                    MessageBox.Show("Section deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowSections() ' Refresh the DataGridView to reflect the changes
                Else
                    MessageBox.Show("Failed to delete the section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting section: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Handle Add New Section button click
    Private Sub sectionaddnew_Click(sender As Object, e As EventArgs) Handles sectionaddnew.Click
        ADD_SECTION.Show()
    End Sub

End Class

