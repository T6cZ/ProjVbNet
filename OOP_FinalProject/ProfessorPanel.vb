Imports MySql.Data.MySqlClient

Public Class ProfessorPanel
    Dim prof_email As String
    Dim prof_id As String

    Private connectionString As String = "server=localhost; user=root; database=grading_system"


    Public Sub New(email As String)
        InitializeComponent()
        prof_email = email
    End Sub


End Class
