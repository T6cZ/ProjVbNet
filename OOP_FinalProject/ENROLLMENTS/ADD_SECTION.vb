Public Class ADD_SECTION
    Public Sub InsertSectionFromTextBoxes()
        If String.IsNullOrEmpty(SECTIONNAME.Text) OrElse
           String.IsNullOrEmpty(DEPARTMENTID.Text) OrElse
           String.IsNullOrEmpty(YEARLEVEL.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim yearLevelValue As Integer
        If Not Integer.TryParse(YEARLEVEL.Text, yearLevelValue) Then
            MessageBox.Show("Year Level must be a valid number.")
            Return
        End If

        Dim query As String = "INSERT INTO SECTIONS (SECTION_NAME, DEPARTMENT_ID, YEAR_LEVEL) " &
                              "VALUES (@SECTION_NAME, @DEPARTMENT_ID, @YEAR_LEVEL)"

        Dim params As New Dictionary(Of String, Object) From {
            {"@SECTION_NAME", SECTIONNAME.Text},
            {"@DEPARTMENT_ID", DEPARTMENTID.Text},
            {"@YEAR_LEVEL", yearLevelValue}
        }

        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Section data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert section data.")
        End If
    End Sub

    Private Sub addnewSection_Click(sender As Object, e As EventArgs) Handles addnewSection.Click
        InsertSectionFromTextBoxes()

    End Sub

    Private Sub canceladdSection_Click(sender As Object, e As EventArgs) Handles canceladdSection.Click
        Me.Hide()

    End Sub
End Class