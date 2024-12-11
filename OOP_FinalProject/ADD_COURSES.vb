Public Class ADD_COURSES
    Public Sub InsertCourseFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(courseid.Text) OrElse String.IsNullOrEmpty(coursename.Text) OrElse
           String.IsNullOrEmpty(credits.Text) OrElse String.IsNullOrEmpty(departmentid.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If

        ' Additional validation for numeric fields
        Dim creditValue As Integer
        If Not Integer.TryParse(credits.Text, creditValue) Then
            MessageBox.Show("Credits must be a valid number.")
            Return
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO COURSES (COURSE_ID, COURSE_NAME, CREDITS, DEPARTMENT_ID) " &
                              "VALUES (@COURSE_ID, @COURSE_NAME, @CREDITS, @DEPARTMENT_ID)"

        ' Gather data from TextBox controls
        Dim params As New Dictionary(Of String, Object) From {
            {"@COURSE_ID", courseid.Text}, ' Assuming txtCourseId is a TextBox for Course ID
            {"@COURSE_NAME", coursename.Text}, ' Assuming txtCourseName is a TextBox for Course Name
            {"@CREDITS", creditValue}, ' Parsed credits value
            {"@DEPARTMENT_ID", departmentid.Text} ' Assuming txtDepartmentId is a TextBox for Department ID
        }

        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Course data inserted successfully.")
        Else

        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertCourseFromTextBoxes()
    End Sub
End Class