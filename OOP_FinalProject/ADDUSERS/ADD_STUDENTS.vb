Imports MySql.Data.MySqlClient

Public Class ADD_STUDENTS

    Public Sub InsertStudentFromTextBoxes()
        If String.IsNullOrEmpty(studentid.Text) OrElse String.IsNullOrEmpty(firstname.Text) OrElse
            String.IsNullOrEmpty(middlename.Text) OrElse String.IsNullOrEmpty(lastname.Text) OrElse String.IsNullOrEmpty(birthdate.Text) OrElse
            String.IsNullOrEmpty(gender.SelectedItem?.ToString()) OrElse String.IsNullOrEmpty(yearlevel.Text) OrElse String.IsNullOrEmpty(contactnumber.Text) OrElse
            String.IsNullOrEmpty(address.Text) OrElse String.IsNullOrEmpty(department.Text) OrElse
            String.IsNullOrEmpty(emailaddress.Text) OrElse String.IsNullOrEmpty(password.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim insertLoginQuery As String = "INSERT INTO LOGIN (EMAIL, PASSWORD, ROLE) VALUES (@email, @password, 'STUDENT'); SELECT LAST_INSERT_ID() AS USER_ID;"
        Dim loginParams As New Dictionary(Of String, Object) From {
            {"@email", emailaddress.Text},
            {"@password", password.Text}
        }
        Dim userId As Integer = InsertDatas(insertLoginQuery, loginParams)


        Dim insertStudentQuery As String = "INSERT INTO STUDENT (USER_ID, STUDENT_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, BIRTHDATE, GENDER, YEAR_LEVEL, CONTACT_NUMBER, ADDRESS, DEPARTMENT_ID) " &
                                          "VALUES (@USER_ID, @STUDENT_ID, @FIRST_NAME, @MIDDLE_NAME, @LAST_NAME, @BIRTHDATE, @GENDER, @YEAR_LEVEL, @CONTACT_NUMBER, @ADDRESS, @DEPARTMENT)"
        Dim studentParams As New Dictionary(Of String, Object) From {
            {"@USER_ID", userId},
            {"@STUDENT_ID", studentid.Text},
            {"@FIRST_NAME", firstname.Text},
            {"@MIDDLE_NAME", middlename.Text},
            {"@LAST_NAME", lastname.Text},
            {"@BIRTHDATE", DateTime.Parse(birthdate.Text)},
            {"@GENDER", gender.SelectedItem.ToString()},
            {"@YEAR_LEVEL", yearlevel.Text},
            {"@CONTACT_NUMBER", contactnumber.Text},
            {"@ADDRESS", address.Text},
            {"@DEPARTMENT", department.Text}
        }
        Dim isInserted As Boolean = InsertData(insertStudentQuery, studentParams)

        If isInserted Then
            MessageBox.Show("Student data inserted successfully.")
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

    Private Sub add_student_Click(sender As Object, e As EventArgs) Handles add_student.Click
        InsertStudentFromTextBoxes()
    End Sub

    Private Sub gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()

    End Sub
End Class