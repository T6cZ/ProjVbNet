Public Class ADD_DEPARTMENT
    Private Sub ENROLLMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub InsertDepartmentFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(DEPARTMENTID.Text) OrElse String.IsNullOrEmpty(DEPARTMENTNAME.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO DEPARTMENT (DEPARTMENT_ID, DEPARTMENT_NAME) VALUES (@DEPARTMENT_ID, @DEPARTMENT_NAME)"

        ' Gather data from TextBox controls
        Dim params As New Dictionary(Of String, Object) From {
        {"@DEPARTMENT_ID", DEPARTMENTID.Text}, ' Assuming txtDepartmentId is a TextBox for Department ID
        {"@DEPARTMENT_NAME", DEPARTMENTNAME.Text} ' Assuming txtDepartmentName is a TextBox for Department Name
    }

        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Department data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert department data.")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertDepartmentFromTextBoxes()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
    End Sub
End Class