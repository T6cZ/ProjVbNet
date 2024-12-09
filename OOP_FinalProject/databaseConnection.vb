﻿Imports MySql.Data.MySqlClient

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

    Public Function GetDataRow(query As String, params As Dictionary(Of String, Object)) As DataRow
        Dim dt As DataTable = GetDataTable(query, params)
        Return If(dt.Rows.Count > 0, dt.Rows(0), Nothing)
    End Function
End Module
