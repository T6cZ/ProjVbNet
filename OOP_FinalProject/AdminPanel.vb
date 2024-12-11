Imports MySql.Data.MySqlClient

Public Class AdminPanel
    Private AdminID As String

    Public Sub New(adminID As String)
        InitializeComponent()
        Me.AdminID = adminID
    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
