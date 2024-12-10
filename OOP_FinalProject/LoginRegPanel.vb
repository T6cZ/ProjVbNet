Imports System.Web.UI.WebControls
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
            Login_invalidcredentials.Visible = True
            login_errortimer.Enabled = True
        End If
    End Sub

    Private Sub login_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles login_showpass.CheckedChanged
        If login_showpass.Checked Then
            Login_password.PasswordChar = ""
        Else
            Login_password.PasswordChar = "•"
        End If
    End Sub

    Private Sub Login_errortimer_Tick(sender As Object, e As EventArgs) Handles login_errortimer.Tick
        Login_invalidcredentials.Visible = False
        login_errortimer.Enabled = False
    End Sub

    Private Sub Login_forgotpassword_Click(sender As Object, e As EventArgs) Handles Login_forgotpassword.Click
        PasswordRecovery.BringToFront()
        clear()
    End Sub

    Private Sub loginback_Click(sender As Object, e As EventArgs) Handles loginback.Click
        LogIn.BringToFront()
        clear()
    End Sub

    Private Sub clear()
        Login_password.Text = ""
        Login_email.Text = ""

        rec_confirmpass.Text = ""
        rec_newpass.Text = ""
        rec_Email.Text = ""
        rec_ID.Text = ""

    End Sub



    Private Sub rec_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles rec_showpassword.CheckedChanged
        If rec_showpassword.Checked Then
            rec_newpass.PasswordChar = ""
        Else
            rec_newpass.PasswordChar = "•"
        End If
    End Sub

    Private Sub rec_showconfirmpassword_CheckedChanged(sender As Object, e As EventArgs) Handles rec_showconfirmpassword.CheckedChanged
        If rec_showconfirmpassword.Checked Then
            rec_confirmpass.PasswordChar = ""
        Else
            rec_confirmpass.PasswordChar = "•"
        End If
    End Sub

    Private Sub PasswordRecovery_Paint(sender As Object, e As PaintEventArgs) Handles PasswordRecovery.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub invalid_IDaccount_Click(sender As Object, e As EventArgs) Handles invalid_IDaccount.Click

    End Sub
End Class
