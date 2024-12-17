Public Class LoginPanel

    Private Sub Login_loginbutton_Click(sender As Object, e As EventArgs) Handles Login_loginbutton.Click
        Dim inputEmail As String = Login_email.Text.Trim()
        Dim inputPassword As String = Login_password.Text.Trim()

        Dim query As String = "SELECT * FROM login WHERE BINARY EMAIL = @Email AND BINARY PASSWORD = @Password"
        Dim params As New Dictionary(Of String, Object) From {
      {"@Email", inputEmail},
      {"@Password", inputPassword}
  }

        Dim userRow As DataRow = databaseConnection.GetDataRow(query, params)

        If userRow IsNot Nothing Then
            Dim userID As String = userRow("USER_ID").ToString()
            Debug.WriteLine($"Logged-in USER_ID: {userID}")

            If userRow("ROLE").ToString().ToUpper() = "PROFESSOR" Then
                Dim profDashboard As New ProfessorPanel(userID)
                profDashboard.Show()
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
            Login_invalidcredentials.Visible = True
            errortimer.Enabled = True
        End If
    End Sub

    Private Sub login_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles login_showpass.CheckedChanged
        If login_showpass.Checked Then
            Login_password.PasswordChar = ""
            login_showhide.Text = "Show"
        Else
            Login_password.PasswordChar = "•"
            login_showhide.Text = "Hide"
        End If
    End Sub

    Private Sub Login_errortimer_Tick(sender As Object, e As EventArgs) Handles errortimer.Tick
        Login_invalidcredentials.Visible = False
        errortimer.Enabled = False
        rec_invalidcredentials.Visible = False
        rec_invalidpassword.Visible = False

    End Sub

    Private Sub Login_forgotpassword_Click(sender As Object, e As EventArgs) Handles Login_forgotpassword.Click
        PasswordRecovery.BringToFront()
        clear()
    End Sub

    Private Sub clear()
        Login_password.Text = ""
        Login_email.Text = ""

        rec_confirmpass.Text = ""
        rec_newpass.Text = ""
        rec_Email.Text = ""
        rec_AccountID.Text = ""
        login_showpass.Checked = False
        rec_showpassword.Checked = False
        rec_showconfirmpassword.Checked = False

    End Sub

    Private Sub rec_showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles rec_showpassword.CheckedChanged
        If rec_showpassword.Checked Then
            rec_newpass.PasswordChar = ""
            newpass_showhide.Text = "Show"
        Else
            rec_newpass.PasswordChar = "•"
            newpass_showhide.Text = "Hide"
        End If
    End Sub

    Private Sub rec_showconfirmpassword_CheckedChanged(sender As Object, e As EventArgs) Handles rec_showconfirmpassword.CheckedChanged
        If rec_showconfirmpassword.Checked Then
            rec_confirmpass.PasswordChar = ""
            confirmpass_showhide.Text = "Show"
        Else
            rec_confirmpass.PasswordChar = "•"
            confirmpass_showhide.Text = "Hide"
        End If
    End Sub

    Private Function ValidateCredentials(accountID As String, email As String) As Boolean
        Try
            Dim roleQuery As String = "SELECT ROLE, USER_ID FROM login WHERE BINARY EMAIL = @Email"
            Dim roleParams As New Dictionary(Of String, Object) From {
           {"@Email", email}
       }
            Dim roleRow As DataRow = databaseConnection.GetDataRow(roleQuery, roleParams)

            If roleRow Is Nothing Then Return False

            Dim role As String = roleRow("ROLE").ToString().ToUpper()
            Dim userID As String = roleRow("USER_ID").ToString()

            If role = "STUDENT" Then
                Dim studentQuery As String = "SELECT * FROM student WHERE STUDENT_ID = @AccountID AND USER_ID = @UserID"
                Dim studentParams As New Dictionary(Of String, Object) From {
                   {"@AccountID", accountID},
                   {"@UserID", userID}
               }
                Return databaseConnection.GetDataRow(studentQuery, studentParams) IsNot Nothing

            ElseIf role = "PROFESSOR" Then
                Dim professorQuery As String = "SELECT * FROM professor WHERE BINARY PROFESSOR_ID = @AccountID AND BINARY USER_ID = @UserID"
                Dim professorParams As New Dictionary(Of String, Object) From {
               {"@AccountID", accountID},
               {"@UserID", userID}
           }
                Return databaseConnection.GetDataRow(professorQuery, professorParams) IsNot Nothing

            End If

        Catch ex As Exception
            MessageBox.Show($"Error validating credentials: {ex.Message}")
        End Try

        Return False
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As New System.Security.Cryptography.SHA256Managed()
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Private Sub resetpassword_button(sender As Object, e As EventArgs) Handles rec_resetbutton.Click

        If Not rec_newpass.Text.Equals(rec_confirmpass.Text) Then
            rec_invalidpassword.Visible = True
            errortimer.Enabled = True
            Return
        End If

        Dim accountID As String = rec_AccountID.Text.Trim()
        Dim email As String = rec_Email.Text.Trim()
        Dim newPassword As String = rec_newpass.Text.Trim()

        If Not ValidateCredentials(accountID, email) Then
            MessageBox.Show("Invalid account ID or email.")
            Return
        End If

        Dim updatePasswordQuery As String = "UPDATE login SET PASSWORD = @newPassword WHERE EMAIL = @Email"
        Dim updatePasswordParams As New Dictionary(Of String, Object) From {
            {"@newPassword", newPassword},
            {"@Email", email}
        }

        Dim rowsAffected As Integer = databaseConnection.ExecuteQuery(updatePasswordQuery, updatePasswordParams)

        If rowsAffected > 0 Then
            MessageBox.Show("Password successfully updated!")
            LogIn.BringToFront()
            clear()
            HideDesign()
        Else
            MessageBox.Show("Failed to update password. Please check the account details.")
        End If
    End Sub

    Private Sub Account_Checker(sender As Object, e As EventArgs) Handles rec_AccountChecker.Click
        Dim accountID As String = rec_AccountID.Text.Trim()
        Dim email As String = rec_Email.Text.Trim()

        Try
            If ValidateCredentials(accountID, email) Then
                'SHOW PASSWORD FIELDS
                Guna2HtmlLabel15.Visible = True
                rec_newpass.Visible = True
                rec_showpassword.Visible = True
                newpass_showhide.Visible = True

                Guna2HtmlLabel34.Visible = True
                rec_confirmpass.Visible = True
                rec_showconfirmpassword.Visible = True
                confirmpass_showhide.Visible = True

                rec_resetbutton.Visible = True
            Else
                errortimer.Enabled = True
                rec_invalidcredentials.Visible = True
                HideDesign()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error checking account: {ex.Message}")
        End Try
    End Sub

    Private Sub HideDesign()
        'HIDE PASSWORD FIELDS
        Guna2HtmlLabel15.Visible = False
        rec_newpass.Visible = False
        rec_showpassword.Visible = False
        newpass_showhide.Visible = False

        Guna2HtmlLabel34.Visible = False
        rec_confirmpass.Visible = False
        rec_showconfirmpassword.Visible = False
        confirmpass_showhide.Visible = False

        rec_resetbutton.Visible = False

    End Sub

    Private Sub backtologin(sender As Object, e As EventArgs) Handles rec_backtologin.Click
        LogIn.BringToFront()
        HideDesign()
        clear()
    End Sub

    Private Sub LoginPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogIn.BringToFront()
    End Sub
End Class
