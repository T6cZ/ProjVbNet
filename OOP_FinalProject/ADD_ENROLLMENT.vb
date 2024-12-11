Public Class ADD_ENROLLMENT
    Public Sub InsertEnrollmentFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(STUDENTID.Text) OrElse String.IsNullOrEmpty(CLASSID.Text) OrElse
       String.IsNullOrEmpty(SEMESTER.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If

        ' Validate that the semester is valid (FIRST or SECOND)
        Dim validSemesters As List(Of String) = New List(Of String) From {"FIRST", "SECOND"}
        If Not validSemesters.Contains(SEMESTER.SelectedItem.ToString().ToUpper()) Then
            MessageBox.Show("Please select a valid semester (FIRST or SECOND).")
            Return
        End If

        ' Validate numeric input for class ID
        Dim classIdValue As Integer
        If Not Integer.TryParse(CLASSID.Text, classIdValue) Then
            MessageBox.Show("Class ID must be a valid number.")
            Return
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO ENROLLMENTS (STUDENT_ID, CLASS_ID, SEMESTER) " &
                          "VALUES (@STUDENT_ID, @CLASS_ID, @SEMESTER)"

        ' Gather data from TextBox controls
        Dim params As New Dictionary(Of String, Object) From {
        {"@STUDENT_ID", STUDENTID.Text}, ' Assuming txtStudentId is a TextBox for Student ID
        {"@CLASS_ID", classIdValue}, ' Parsed Class ID value
        {"@SEMESTER", SEMESTER.SelectedItem.ToString().ToUpper()} ' Retrieve selected semester from ComboBox
    }

        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Enrollment data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert enrollment data.")
        End If
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertEnrollmentFromTextBoxes()
    End Sub

    Private Sub ADD_ENROLLMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class