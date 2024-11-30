Public Class LoginRegPanel
    Private Sub Login_loginbutton_Click(sender As Object, e As EventArgs) Handles Login_loginbutton.Click
        StudentMainMenu.Show()
        Me.Hide()
    End Sub
End Class