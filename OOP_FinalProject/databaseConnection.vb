Imports MySql.Data.MySqlClient

Module databaseConnection
    Private ReadOnly connectionString As String = "Server=localhost;user=root;Database=university_grading_system"

    Public Function GetDataTable(query As String, params As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    For Each param In params
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}")
        End Try

        Return dt
    End Function

    Public Function InsertData(query As String, params As Dictionary(Of String, Object)) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    For Each param In params
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Dim result As Integer = command.ExecuteNonQuery()
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function GetDataRow(query As String, params As Dictionary(Of String, Object)) As DataRow
        Dim dt As DataTable = GetDataTable(query, params)
        Return If(dt.Rows.Count > 0, dt.Rows(0), Nothing)
    End Function

    Public Sub ExecuteNonQuery(query As String, params As Dictionary(Of String, Object))
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    For Each param In params
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}")
        End Try
    End Sub

    Public Function ExecuteQuery(query As String, params As Dictionary(Of String, Object)) As Integer
        Dim rowsAffected As Integer = 0

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    For Each param In params
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    rowsAffected = command.ExecuteNonQuery()
                    Console.WriteLine($"Rows affected: {rowsAffected}")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}")
        End Try

        Return rowsAffected
    End Function
End Module


