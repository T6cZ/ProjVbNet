Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail

Public Class ADD_ADMIN

    Public Sub insertNewAdmin()
        If String.IsNullOrEmpty(adminid.Text) OrElse String.IsNullOrEmpty(firstnameADMIN.Text) OrElse
            String.IsNullOrEmpty(middlenameADMIN.Text) OrElse String.IsNullOrEmpty(lastnameADMIN.Text) OrElse
            String.IsNullOrEmpty(contactnumberADMIN.Text) OrElse
            String.IsNullOrEmpty(addressADMIN.Text) OrElse
            String.IsNullOrEmpty(emailADMIN.Text) OrElse String.IsNullOrEmpty(passwordADMIN.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim insertLoginQuery As String = "INSERT INTO LOGIN (EMAIL, PASSWORD, ROLE) VALUES (@email, @password, 'ADMIN'); SELECT LAST_INSERT_ID() AS USER_ID;"
        Dim loginParams As New Dictionary(Of String, Object) From {
            {"@email", emailADMIN.Text},
            {"@password", passwordADMIN.Text}
        }
        Dim userId As Integer = InsertDatas(insertLoginQuery, loginParams)


        Dim insertStudentQuery As String = "INSERT INTO ADMIN (USER_ID, ADMIN_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, CONTACT_NUMBER, ADDRESS) " &
                                          "VALUES (@USER_ID, @ADMIN_ID, @FIRST_NAME, @MIDDLE_NAME, @LAST_NAME, @CONTACT_NUMBER, @ADDRESS )"
        Dim studentParams As New Dictionary(Of String, Object) From {
            {"@USER_ID", userId},
            {"@ADMIN_ID", adminid.Text},
            {"@FIRST_NAME", firstnameADMIN.Text},
            {"@MIDDLE_NAME", middlenameADMIN.Text},
            {"@LAST_NAME", lastnameADMIN.Text},
            {"@CONTACT_NUMBER", contactnumberADMIN.Text},
            {"@ADDRESS", addressADMIN.Text}
            }
        Dim isInserted As Boolean = InsertData(insertStudentQuery, studentParams)

        If isInserted Then
            MessageBox.Show("New Admin Has Been ADDED")
        Else
            MessageBox.Show("Failed to insert student data.")
        End If
    End Sub


    Private Function InsertDatas(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Dim connectionString As String = "Server=localhost;user=root;Database=university_grading_system"
        Dim userId As Integer = 0

        Using connection As MySqlConnection = New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                For Each param In parameters
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        userId = reader.GetInt32(0)
                    End If
                End Using
            End Using
        End Using

        Return userId
    End Function

    Private Sub addnewAdmin_Click(sender As Object, e As EventArgs) Handles addnewAdmin.Click
        insertNewAdmin()

    End Sub
End Class