Public Class StudentMainMenu
    Private isSidebarExpanded As Boolean = True
    Private originalSidebarWidth As Integer = 55

    Private Sub stp_sidebartoggle_Click(sender As Object, e As EventArgs) Handles stp_sidebartoggle.Click
        If isSidebarExpanded Then
            stp_sidebar.Width = 180
        Else
            stp_sidebar.Width = originalSidebarWidth

        End If

        isSidebarExpanded = Not isSidebarExpanded
    End Sub


End Class