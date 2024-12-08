Imports MySql.Data.MySqlClient

Public Class LoginRegPanel

    Private Sub Login_loginbutton_Click(sender As Object, e As EventArgs) Handles Login_loginbutton.Click
        Dim query As String = "SELECT * FROM LOGIN WHERE (EMAIL = @input OR USER_ID = @input) AND Password = @password"
        Dim params As New Dictionary(Of String, Object) From {
        {"@input", Login_email.Text},
        {"@password", Login_password.Text}
    }

        Dim userRow As DataRow = databaseConnection.GetDataRow(query, params)

        If userRow IsNot Nothing Then
            Dim userID As String = userRow("USER_ID").ToString()

            ' Open the Student Dashboard if the logged-in user is a student
            If userRow("Role").ToString().ToUpper() = "STUDENT" Then
                Dim studentDashboard As New StudentMainMenu(userID)
                studentDashboard.Show()
            Else
                MessageBox.Show("Only students can access this dashboard.")
            End If

            Me.Hide()
        Else
            Login_invalidusername.Text = "Invalid username, email, or password."
        End If
    End Sub

End Class
