Public Class ADD_COURSES
    Public Sub InsertCourseFromTextBoxes()
        If String.IsNullOrEmpty(COURSEID.Text) OrElse String.IsNullOrEmpty(COURSENAME.Text) OrElse
           String.IsNullOrEmpty(CREDITS.Text) OrElse String.IsNullOrEmpty(DEPARTMENTID.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return '
        End If


        Dim creditValue As Integer
        If Not Integer.TryParse(CREDITS.Text, creditValue) Then
            MessageBox.Show("Credits must be a valid number.")
            Return
        End If

        Dim query As String = "INSERT INTO COURSES (COURSE_ID, COURSE_NAME, CREDITS, DEPARTMENT_ID) " &
                              "VALUES (@COURSE_ID, @COURSE_NAME, @CREDITS, @DEPARTMENT_ID)"
        Dim params As New Dictionary(Of String, Object) From {
            {"@COURSE_ID", COURSEID.Text},
            {"@COURSE_NAME", COURSENAME.Text},
            {"@CREDITS", creditValue},
            {"@DEPARTMENT_ID", DEPARTMENTID.Text}
        }

        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Course data inserted successfully.")
        Else

        End If

    End Sub

    Private Sub cancelAddnewCourse_Click(sender As Object, e As EventArgs) Handles cancelAddnewCourse.Click
        Me.Hide()
        InsertCourseFromTextBoxes()
    End Sub

    Private Sub addnewCourse_Click(sender As Object, e As EventArgs) Handles addnewCourse.Click
        InsertCourseFromTextBoxes()
    End Sub
End Class