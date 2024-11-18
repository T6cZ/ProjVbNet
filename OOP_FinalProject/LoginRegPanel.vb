Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail

Public Class LoginRegPanel
    Private Sub Login_loginbutton_Click(sender As Object, e As EventArgs) Handles Login_loginbutton.Click
        StudentMainMenu.Show()
        Me.Hide()
    End Sub

End Class