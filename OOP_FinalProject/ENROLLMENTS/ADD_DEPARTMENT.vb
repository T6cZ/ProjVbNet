Public Class ADD_DEPARTMENT
    Public Sub InsertDepartmentFromTextBoxes()
        If String.IsNullOrEmpty(DEPARTMENTID.Text) OrElse String.IsNullOrEmpty(DEPARTMENTNAME.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim query As String = "INSERT INTO DEPARTMENT (DEPARTMENT_ID, DEPARTMENT_NAME) VALUES (@DEPARTMENT_ID, @DEPARTMENT_NAME)"

        Dim params As New Dictionary(Of String, Object) From {
        {"@DEPARTMENT_ID", DEPARTMENTID.Text},
        {"@DEPARTMENT_NAME", DEPARTMENTNAME.Text}
    }

        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("New Department has been ADDED")
        Else
            MessageBox.Show("Failed to insert department data.")
        End If
    End Sub

    Private Sub addnewdepartment_Click(sender As Object, e As EventArgs) Handles addnewdepartment.Click
        InsertDepartmentFromTextBoxes()
    End Sub

    Private Sub canceldepartment_Click(sender As Object, e As EventArgs) Handles canceldepartment.Click
        Me.Hide()

    End Sub
End Class