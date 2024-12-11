Imports MySql.Data.MySqlClient

Public Class ADD_STUDENT



    Public Sub InsertStudentFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(userid.Text) OrElse String.IsNullOrEmpty(studentid.Text) OrElse String.IsNullOrEmpty(firstname.Text) OrElse
       String.IsNullOrEmpty(middlename.Text) OrElse String.IsNullOrEmpty(lastname.Text) OrElse String.IsNullOrEmpty(birthdate.Text) OrElse
       String.IsNullOrEmpty(gender.SelectedItem?.ToString()) OrElse String.IsNullOrEmpty(yearlevel.Text) OrElse String.IsNullOrEmpty(contactnumber.Text) OrElse
       String.IsNullOrEmpty(address.Text) OrElse String.IsNullOrEmpty(age.Text) OrElse String.IsNullOrEmpty(department.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO STUDENT (USER_ID, STUDENT_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, BIRTHDATE, GENDER, YEAR_LEVEL, CONTACT_NUMBER, ADDRESS, AGE, DEPARTMENT) " &
                          "VALUES (@USER_ID, @STUDENT_ID, @FIRST_NAME, @MIDDLE_NAME, @LAST_NAME, @BIRTHDATE, @GENDER, @YEAR_LEVEL, @CONTACT_NUMBER, @ADDRESS, @AGE, @DEPARTMENT)"

        ' Gather data from TextBox controls and ComboBox
        Dim params As New Dictionary(Of String, Object) From {
        {"@USER_ID", Integer.Parse(userid.Text)}, ' Assuming txtUserId contains the user ID
        {"@STUDENT_ID", studentid.Text}, ' Assuming txtStudentId is a TextBox for Student ID
        {"@FIRST_NAME", firstname.Text},
        {"@MIDDLE_NAME", middlename.Text},
        {"@LAST_NAME", lastname.Text},
        {"@BIRTHDATE", DateTime.Parse(birthdate.Text)}, ' Assuming txtBirthDate is a valid Date
        {"@GENDER", gender.SelectedItem.ToString()}, ' Retrieve the selected gender from ComboBox
        {"@YEAR_LEVEL", Integer.Parse(yearlevel.Text)}, ' Assuming txtYearLevel is numeric
        {"@CONTACT_NUMBER", contactnumber.Text},
        {"@ADDRESS", address.Text},
        {"@AGE", Integer.Parse(age.Text)}, ' Assuming txtAge is numeric
        {"@DEPARTMENT", department.Text}
    }

        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Student data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert student data.")
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertStudentFromTextBoxes()
    End Sub

    Private Sub Guna2HtmlLabel14_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel14.Click

    End Sub

    Private Sub ADD_STUDENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class