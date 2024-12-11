Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Net

Public Class ADD_ADMIN
    Public Sub InsertAdminFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(useridADMIN.Text) OrElse String.IsNullOrEmpty(firstnameADMIN.Text) OrElse
           String.IsNullOrEmpty(middlenameADMIN.Text) OrElse String.IsNullOrEmpty(lastnameADMIN.Text) OrElse
           String.IsNullOrEmpty(ageADMIN.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO ADMIN (USER_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, CONTACT_NUMBER, ADDRESS, AGE, REMARKS) " &
                              "VALUES (@USER_ID, @FIRST_NAME, @MIDDLE_NAME, @LAST_NAME, @CONTACT_NUMBER, @ADDRESS, @AGE, @REMARKS)"

        ' Gather data from TextBox controls
        Dim params As New Dictionary(Of String, Object) From {
            {"@USER_ID", Integer.Parse(useridADMIN.Text)}, ' Assuming txtUserId contains the user ID
            {"@FIRST_NAME", firstnameADMIN.Text},
            {"@MIDDLE_NAME", middlenameADMIN.Text},
            {"@LAST_NAME", lastnameADMIN.Text},
            {"@CONTACT_NUMBER", contactnumberADMIN.Text}, ' Optional, no null check required if it's allowed to be empty
{"@ADDRESS", addressADMIN.Text}, ' Optional, no null check required if it's allowed to be empty
            {"@AGE", Integer.Parse(ageADMIN.Text)}, ' Assuming txtAge is numeric
            {"@REMARKS", remarksADMIN.Text} ' Optional, no null check required if it's allowed to be empty
        }

        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Admin data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert admin data.")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertAdminFromTextBoxes()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
    End Sub
End Class