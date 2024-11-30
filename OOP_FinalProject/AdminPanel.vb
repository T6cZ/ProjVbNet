Public Class AdminPanel
    Private Sub admin_profdatatable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles admin_profdatatable.CellContentClick

    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer.Interval = 1000
        timer.Enabled = True
        timer.Start()



    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        admin_currenttime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        admin_currentdate.Text = DateTime.Now.ToString("MM/dd/yyyy dddd")
    End Sub
End Class