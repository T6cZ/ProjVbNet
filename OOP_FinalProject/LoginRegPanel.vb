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

            If userRow("ROLE").ToString().ToUpper() = "PROFESSOR" Then
                Dim professorQuery As String = "SELECT PROFESSOR_ID FROM PROFESSOR WHERE USER_ID = @userID"
                Dim professorParams As New Dictionary(Of String, Object) From {
                    {"@userID", userID}
                }

                Dim professorRow As DataRow = databaseConnection.GetDataRow(professorQuery, professorParams)

                If professorRow IsNot Nothing Then
                    Dim professorID As String = professorRow("PROFESSOR_ID").ToString()
                    Dim professorDashboard As New ProfessorPanel(professorID)
                    professorDashboard.Show()
                Else
                    MessageBox.Show("Professor details not found.")
                End If

            ElseIf userRow("ROLE").ToString().ToUpper() = "STUDENT" Then
                Dim studentDashboard As New StudentMainMenu(userID)
                studentDashboard.Show()

            ElseIf userRow("ROLE").ToString().ToUpper() = "ADMIN" Then
                AdminPanel.Show()

            Else
                MessageBox.Show("Invalid role detected.")
            End If

            Me.Hide()

        Else
            Login_invalidusername.Text = "Invalid username, email, or password."
        End If
    End Sub
End Class
