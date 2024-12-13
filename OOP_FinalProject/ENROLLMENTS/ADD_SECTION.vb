Public Class ADD_SECTION

    ' Load departments into the ComboBox
    Sub LoadDepartments(comboBox As ComboBox)
        Dim query As String = "SELECT DEPARTMENT_ID, DEPARTMENT_NAME FROM DEPARTMENT;"
        Dim dt As DataTable = GetDataTable(query, New Dictionary(Of String, Object)())
        comboBox.DataSource = dt
        comboBox.DisplayMember = "DEPARTMENT_NAME"
        comboBox.ValueMember = "DEPARTMENT_ID"
    End Sub

    ' Insert section data from textboxes into the database
    Public Sub InsertSectionFromTextBoxes()
        If String.IsNullOrEmpty(SECTIONNAME.Text) OrElse String.IsNullOrEmpty(YEARLEVEL.Text) OrElse DEPARTMENTID.SelectedValue Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim yearLevelValue As Integer
        If Not Integer.TryParse(YEARLEVEL.Text, yearLevelValue) Then
            MessageBox.Show("Year Level must be a valid number.")
            Return
        End If

        ' Insert section with the selected department ID
        Dim query As String = "INSERT INTO SECTIONS (SECTION_NAME, DEPARTMENT_ID, YEAR_LEVEL) VALUES (@SECTION_NAME, @DEPARTMENT_ID, @YEAR_LEVEL)"
        Dim params As New Dictionary(Of String, Object) From {
            {"@SECTION_NAME", SECTIONNAME.Text},
            {"@DEPARTMENT_ID", DEPARTMENTID.SelectedValue},
            {"@YEAR_LEVEL", YEARLEVEL.SelectedValue}
        }

        If InsertData(query, params) Then
            MessageBox.Show("Section data inserted successfully.")
            Me.Hide()
        Else
            MessageBox.Show("Failed to insert section data.")
        End If
    End Sub

    Private Sub addnewSection_Click(sender As Object, e As EventArgs) Handles addnewSection.Click
        InsertSectionFromTextBoxes()
    End Sub

End Class