Public Class ADD_SECTION
    Public Sub InsertSectionFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(SECTIONNAME.Text) OrElse
           String.IsNullOrEmpty(DEPARTMENTID.Text) OrElse
           String.IsNullOrEmpty(YEARLEVEL.Text) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If

        ' Validate numeric input for year level
        Dim yearLevelValue As Integer
        If Not Integer.TryParse(YEARLEVEL.Text, yearLevelValue) Then
            MessageBox.Show("Year Level must be a valid number.")
            Return
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO SECTIONS (SECTION_NAME, DEPARTMENT_ID, YEAR_LEVEL) " &
                              "VALUES (@SECTION_NAME, @DEPARTMENT_ID, @YEAR_LEVEL)"

        ' Gather data from TextBox controls
        Dim params As New Dictionary(Of String, Object) From {
            {"@SECTION_NAME", SECTIONNAME.Text}, ' Assuming sectionname is a TextBox for Section Name
            {"@DEPARTMENT_ID", DEPARTMENTID.Text}, ' Assuming departmentid is a TextBox or ComboBox for Department ID
            {"@YEAR_LEVEL", yearLevelValue} ' Parsed Year Level value
        }

        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Section data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert section data.")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertSectionFromTextBoxes()
    End Sub

    Private Sub ADD_SECTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class