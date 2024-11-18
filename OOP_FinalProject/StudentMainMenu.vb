Public Class StudentMainMenu
    Private Sub StudentMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stp_clocktimer.Text = DateTime.Now.ToString("hh:mm:ss tt")
        stp_currentdate.Text = DateTime.Now.ToString("MM/dd/yyyy dddd")

    End Sub
End Class