Public Class ADD_CLASS
    Public Sub InsertClassFromTextBoxes()
        If String.IsNullOrEmpty(SECTIONID.Text) OrElse
       String.IsNullOrEmpty(COURSEID.Text) OrElse
       String.IsNullOrEmpty(PROFESSORID.Text) OrElse
       TERM.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.")
            Return '
        End If

        Dim sectionIdValue As Integer
        If Not Integer.TryParse(SECTIONID.Text, sectionIdValue) Then
            MessageBox.Show("Section ID must be a valid number.")
            Return
        End If

        Dim query As String = "INSERT INTO CLASSES (SECTION_ID, COURSE_ID, PROFESSOR_ID, TERM, ACADEMIC_YEAR) " &
                          "VALUES (@SECTION_ID, @COURSE_ID, @PROFESSOR_ID, @TERM, @ACADEMIC_YEAR)"


        Dim params As New Dictionary(Of String, Object) From {
        {"@SECTION_ID", sectionIdValue},
        {"@COURSE_ID", COURSEID.Text},
        {"@PROFESSOR_ID", PROFESSORID.Text},
        {"@TERM", TERM.SelectedItem.ToString()},
        {"@ACADEMIC_YEAR", ACADEMICYEAR.Text}
    }

        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Class data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert class data.")
        End If
    End Sub

    Private Sub addNewClass_Click(sender As Object, e As EventArgs) Handles addNewClass.Click
        InsertClassFromTextBoxes()
    End Sub

    Private Sub cancelNewClass_Click(sender As Object, e As EventArgs) Handles cancelNewClass.Click
        Me.Hide()

    End Sub

    '==============================================================================================================================

End Class