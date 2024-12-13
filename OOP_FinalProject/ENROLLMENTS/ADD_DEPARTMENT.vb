Public Class ADD_DEPARTMENT


    Public Sub InsertDepartmentFromTextBoxes()
        If String.IsNullOrEmpty(DEPARTMENTID.Text) OrElse String.IsNullOrEmpty(DEPARTMENTNAME.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim query As String = "INSERT INTO DEPARTMENT (DEPARTMENT_ID, DEPARTMENT_NAME) VALUES (@DEPARTMENT_ID, @DEPARTMENT_NAME)"

        Dim params As New Dictionary(Of String, Object) From {
            {"@DEPARTMENT_ID", DEPARTMENTID.Text.Trim()},
            {"@DEPARTMENT_NAME", DEPARTMENTNAME.Text.Trim()}
        }

        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Department Added Successfully.")

            Me.Hide()

            DEPARTMENTID.Clear()
            DEPARTMENTNAME.Clear()
        Else
            MessageBox.Show("Failed to insert dep   artment data.")
        End If
    End Sub

    Private Sub addnewdepartment_Click(sender As Object, e As EventArgs) Handles addnewdepartment.Click
        Dim parentForm As AdminPanel = TryCast(Me.Owner, AdminPanel)

        InsertDepartmentFromTextBoxes()
    End Sub

    Private Sub ADD_DEPARTMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class