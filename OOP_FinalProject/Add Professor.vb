Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Add_Professor

    Public Sub InsertProfessorFromTextBoxes()
        ' Validate required fields
        If String.IsNullOrEmpty(admin_txtuserid.Text) OrElse
   String.IsNullOrEmpty(admin_txtprofid.Text) OrElse
   String.IsNullOrEmpty(admin_txtproffirstname.Text) OrElse
   String.IsNullOrEmpty(admin_txtproflastname.Text) OrElse
   String.IsNullOrEmpty(admin_txtaddress.Text) OrElse
   admin_comboxdeptid.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.")
            Return ' Exit the method if validation fails
        End If


        ' Validate USER_ID as numeric
        Dim userIdValue As Integer
        If Not Integer.TryParse(admin_txtuserid.Text, userIdValue) Then
            MessageBox.Show("User ID must be a valid number.")
            Return
        End If

        ' Define the SQL INSERT query with parameter placeholders
        Dim query As String = "INSERT INTO PROFESSOR (USER_ID, PROFESSOR_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, DEPARTMENT_ID, CONTACT_NUMBER, ADDRESS, STATUS) " &
                              "VALUES (@USER_ID, @PROFESSOR_ID, @FIRST_NAME, @MIDDLE_NAME, @LAST_NAME, @DEPARTMENT_ID, @CONTACT_NUMBER, @ADDRESS, @STATUS)"

        ' Gather data from TextBox and ComboBox controls
        Dim params As New Dictionary(Of String, Object) From {
    {"@USER_ID", userIdValue},
    {"@PROFESSOR_ID", admin_txtprofid.Text},
    {"@FIRST_NAME", admin_txtproffirstname.Text},
    {"@MIDDLE_NAME", If(String.IsNullOrEmpty(admin_txtprofmiddlename.Text), DBNull.Value, admin_txtprofmiddlename.Text)},
    {"@LAST_NAME", admin_txtproflastname.Text},
    {"@DEPARTMENT_ID", If(admin_comboxdeptid.SelectedItem Is Nothing, DBNull.Value, admin_comboxdeptid.SelectedItem.ToString())},
    {"@CONTACT_NUMBER", If(String.IsNullOrEmpty(admin_txtcontactnum.Text), DBNull.Value, admin_txtcontactnum.Text)},
    {"@ADDRESS", If(String.IsNullOrEmpty(admin_txtaddress.Text), DBNull.Value, admin_txtaddress.Text)},
    {"@STATUS", If(admin_comboxstatus.SelectedItem Is Nothing, "ACTIVE", admin_comboxstatus.SelectedItem.ToString())}
}


        ' Call InsertData function and check the result
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Professor data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert professor data.")
        End If
    End Sub

    ' Function to handle database insertion
    Private Function InsertData(query As String, params As Dictionary(Of String, Object)) As Boolean
        Try
            Using connection As New MySqlConnection("Server=localhost;user=root;Database=university_grading_system")
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    For Each param In params
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    command.ExecuteNonQuery()
                End Using
            End Using

            Return True
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}")
            Return False
        End Try
    End Function

    ' Event handler for the "Add" button click
    Private Sub admin_add_Click(sender As Object, e As EventArgs) Handles admin_add.Click
        InsertProfessorFromTextBoxes()
    End Sub

    ' Form load event to populate comboboxes
    Private Sub Add_Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDepartmentComboBox()
        PopulateStatusComboBox()
    End Sub

    ' Method to populate department combobox
    Private Sub PopulateDepartmentComboBox()
        Dim query As String = "SELECT DEPARTMENT_ID FROM DEPARTMENT"
        Dim departments As DataTable = GetDataTable(query, New Dictionary(Of String, Object))

        If departments IsNot Nothing Then
            admin_comboxdeptid.Items.Clear()
            For Each row As DataRow In departments.Rows
                admin_comboxdeptid.Items.Add(row("DEPARTMENT_ID").ToString())
            Next
        End If
    End Sub

    ' Method to populate status combobox
    Private Sub PopulateStatusComboBox()
        admin_comboxstatus.Items.Clear()
        admin_comboxstatus.Items.Add("ACTIVE")
        admin_comboxstatus.Items.Add("INACTIVE")
        admin_comboxstatus.SelectedIndex = 0 ' Default to ACTIVE
    End Sub

    ' Function to retrieve data from the database
    Private Function GetDataTable(query As String, params As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()

        Try
            Using connection As New MySqlConnection("Server=localhost;user=root;Database=university_grading_system")
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    For Each param In params
                        command.Parameters.AddWithValue(param.Key, param.Value)
                    Next

                    Using adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Database error: {ex.Message}")
        End Try

        Return dt
    End Function

End Class
