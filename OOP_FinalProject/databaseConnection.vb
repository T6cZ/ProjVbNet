Imports System.Data.SqlClient

Module databaseConnection
    Private ReadOnly connectionString As String = "YourConnectionStringHere"

    Public Function GetDataTable(query As String, params As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                For Each param In params
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetDataRow(query As String, params As Dictionary(Of String, Object)) As DataRow
        Dim dt As DataTable = GetDataTable(query, params)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        End If
        Return Nothing
    End Function
End Module
