Imports MySql.Data.MySqlClient

Module databaseConnection
    ' Connection string to your MySQL database
    Private ReadOnly connectionString As String = "Server=localhost;user=root;Database=university_grading_system"

    ' Function to retrieve a DataTable (for SELECT queries)
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

    ' Function to retrieve a single DataRow (for SELECT queries)
    Public Function GetDataRow(query As String, params As Dictionary(Of String, Object)) As DataRow
        Dim dt As DataTable = GetDataTable(query, params)
        Return If(dt.Rows.Count > 0, dt.Rows(0), Nothing)
    End Function

    ' Function to execute queries that modify data (INSERT, UPDATE, DELETE)
    Public Function ExecuteQuery(query As String, params As Dictionary(Of String, Object)) As Integer
        Dim rowsAffected As Integer = 0

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    For Each param In params
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    ' Execute the query and return the number of rows affected
                    rowsAffected = command.ExecuteNonQuery()
                    Console.WriteLine($"Rows affected: {rowsAffected}") ' Debugging line
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}")
        End Try

        Return rowsAffected
    End Function
End Module