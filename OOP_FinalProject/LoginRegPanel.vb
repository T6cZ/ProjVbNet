﻿Public Class LoginRegPanel
    Private Sub Login_loginbutton_Click(sender As Object, e As EventArgs) Handles Login_loginbutton.Click
        StudentMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub LoginRegPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Login_email_TextChanged(sender As Object, e As EventArgs) Handles Login_email.TextChanged

    End Sub
End Class