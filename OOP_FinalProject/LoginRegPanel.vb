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
            Debug.WriteLine($"Logged-in USER_ID: {userID}")

            If userRow("ROLE").ToString().ToUpper() = "PROFESSOR" Then
                Dim profDashboard As New ProfessorPanel(userID)
                profDashboard.Show()  ' Corrected this line
                Me.Hide()

            ElseIf userRow("ROLE").ToString().ToUpper() = "STUDENT" Then
                Dim studentDashboard As New StudentMainMenu(userID)
                studentDashboard.Show()
                Me.Hide()

            ElseIf userRow("ROLE").ToString().ToUpper() = "ADMIN" Then
                Dim adminQuery As String = "SELECT ADMIN_ID FROM ADMIN WHERE USER_ID = @userID"
                Dim adminParams As New Dictionary(Of String, Object) From {
                    {"@userID", userID}
                }

                Dim adminRow As DataRow = databaseConnection.GetDataRow(adminQuery, adminParams)

                If adminRow IsNot Nothing Then
                    Dim adminID As String = adminRow("ADMIN_ID").ToString()
                    Dim adminDashboard As New AdminPanel(adminID)
                    adminDashboard.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Admin details not found.")
                End If
            End If

        Else
            Login_invalidusername.Text = "Invalid username, email, or password."
        End If
    End Sub

End Class
