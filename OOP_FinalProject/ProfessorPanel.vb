Public Class ProfessorPanel
    Private Sub prof_datatable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prof_datatable.CellContentClick

    End Sub

    Private Sub ProfessorPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub prof_sblogout_Click(sender As Object, e As EventArgs) Handles prof_sblogout.Click
        Me.Hide()
        LoginRegPanel.Show()
    End Sub
End Class