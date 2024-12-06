Imports MySql.Data.MySqlClient

Public Class LoginRegPanel
    Private connectionString As String = "server=localhost; user=root; database=grading_system"

    Private Sub LoginRegPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login_invalidusername.Visible = False
        Login_invalidpassword.Visible = False
    End Sub

    Private Sub Login_loginbutton_Click(sender As Object, e As EventArgs) Handles Login_loginbutton.Click
        Dim email As String = Login_email.Text
        Dim password As String = Login_password.Text

        Dim userType As String = GetUserType(email, password)

        Select Case userType
            Case "STUDENT"
                MessageBox.Show("Welcome, Student!")

                Dim studentMenu As New StudentMainMenu(email)
                studentMenu.Show()
                Me.Hide()

            Case "PROFESSOR"
                MessageBox.Show("Welcome, Professor!")
                ProfessorPanel.Show()
                Me.Hide()

            Case "ADMIN"
                MessageBox.Show("Welcome, Admin!")
                AdminPanel.Show()
                Me.Hide()

            Case Else
                Login_invalidusername.Visible = True
                Login_invalidpassword.Visible = True
                login_errortimer.Enabled = True
        End Select
    End Sub

    Private Function GetUserType(email As String, password As String) As String
        Dim userType As String = String.Empty

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                    SELECT 
                        CASE 
                            WHEN STUDENT_ID IS NOT NULL THEN 'STUDENT'
                            WHEN PROFESSOR_ID IS NOT NULL THEN 'PROFESSOR'
                            WHEN USERNAME_ADMIN IS NOT NULL THEN 'ADMIN'
                            ELSE NULL
                        END AS UserType
                    FROM LOGIN_CREDENTIALS
                    WHERE EMAIL = @Email AND PASSWORD = @Password"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Dim result As Object = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        userType = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return userType
    End Function

    Private Sub Login_errortimer_Tick(sender As Object, e As EventArgs) Handles login_errortimer.Tick
        Login_invalidusername.Visible = False
        Login_invalidpassword.Visible = False
        login_errortimer.Enabled = False
    End Sub

    Private Sub login_showpass_CheckedChanged(sender As Object, e As EventArgs) Handles login_showpass.CheckedChanged
        If login_showpass.Checked Then
            Login_password.PasswordChar = ""
        Else
            Login_password.PasswordChar = "•"
        End If
    End Sub

    Private Sub Login_password_TextChanged(sender As Object, e As EventArgs) Handles Login_password.TextChanged
        If login_showpass.Checked Then
            Login_password.PasswordChar = ""
        Else
            Login_password.PasswordChar = "•"
        End If
    End Sub

End Class
