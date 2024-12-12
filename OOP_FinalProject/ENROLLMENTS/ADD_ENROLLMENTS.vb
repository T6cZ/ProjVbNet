Public Class ADD_ENROLLMENTS
    Public Sub InsertEnrollmentFromTextBoxes()
        If String.IsNullOrEmpty(STUDENTID.Text) OrElse String.IsNullOrEmpty(CLASSID.Text) OrElse
       String.IsNullOrEmpty(SEMESTER.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If
        Dim validSemesters As List(Of String) = New List(Of String) From {"FIRST", "SECOND"}
        If Not validSemesters.Contains(SEMESTER.SelectedItem.ToString().ToUpper()) Then
            MessageBox.Show("Please select a valid semester (FIRST or SECOND).")
            Return
        End If

        Dim classIdValue As Integer
        If Not Integer.TryParse(CLASSID.Text, classIdValue) Then
            MessageBox.Show("Class ID must be a valid number.")
            Return
        End If

        Dim query As String = "INSERT INTO ENROLLMENTS (STUDENT_ID, CLASS_ID, SEMESTER) " &
                          "VALUES (@STUDENT_ID, @CLASS_ID, @SEMESTER)"

        Dim params As New Dictionary(Of String, Object) From {
        {"@STUDENT_ID", STUDENTID.Text},
        {"@CLASS_ID", classIdValue},
        {"@SEMESTER", SEMESTER.SelectedItem.ToString().ToUpper()}
    }

        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Enrollment data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert enrollment data.")
        End If
    End Sub

    Private Sub enrollStudent_Click(sender As Object, e As EventArgs) Handles enrollStudent.Click
        InsertEnrollmentFromTextBoxes()
    End Sub

    Private Sub cancelEnroll_Click(sender As Object, e As EventArgs) Handles cancelEnroll.Click
        Me.Hide()

    End Sub
End Class