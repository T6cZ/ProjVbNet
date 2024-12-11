Public Class ADD_CLASS

    Public Sub InsertClassFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(SECTIONID.Text) OrElse
       String.IsNullOrEmpty(COURSEID.Text) OrElse
       String.IsNullOrEmpty(PROFESSORID.Text) OrElse
       term.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If

        ' Validate numeric input for Section ID
        Dim sectionIdValue As Integer
        If Not Integer.TryParse(SECTIONID.Text, sectionIdValue) Then
            MessageBox.Show("Section ID must be a valid number.")
            Return
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO CLASSES (SECTION_ID, COURSE_ID, PROFESSOR_ID, TERM, ACADEMIC_YEAR) " &
                          "VALUES (@SECTION_ID, @COURSE_ID, @PROFESSOR_ID, @TERM, @ACADEMIC_YEAR)"

        ' Gather data from TextBox controls and ComboBox
        Dim params As New Dictionary(Of String, Object) From {
        {"@SECTION_ID", sectionIdValue}, ' Parsed Section ID value
        {"@COURSE_ID", courseid.Text}, ' Assuming courseid is a TextBox for Course ID
        {"@PROFESSOR_ID", professorid.Text}, ' Assuming professorid is a TextBox for Professor ID
        {"@TERM", term.SelectedItem.ToString()}, ' Selected term from ComboBox
        {"@ACADEMIC_YEAR", academicyear.Text} ' Assuming academicyear is a TextBox for Academic Year
    }

        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Class data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert class data.")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertClassFromTextBoxes()
    End Sub

    Private Sub ADD_CLASS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        CLASSPANEL.Show()
    End Sub
End Class