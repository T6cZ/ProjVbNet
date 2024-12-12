Imports System.Net.Mail
Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class Add_Professor
    Dim professorID As String = admin_txtprofid.Text.Trim()
    Dim inputEmail As String = admin_txtemail.Text.Trim()
    Dim inputPassword As String = admin_txtpass.Text.Trim()
    Private Sub Add_Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddepartment()
    End Sub

    Public Sub InsertProfessorFromTextBoxes()
        If String.IsNullOrEmpty(admin_txtprofid.Text) OrElse
   String.IsNullOrEmpty(admin_txtproffirstname.Text) OrElse
   String.IsNullOrEmpty(admin_txtproflastname.Text) OrElse
   String.IsNullOrEmpty(admin_txtaddress.Text) OrElse
   String.IsNullOrEmpty(admin_txtcontactnum.Text) OrElse
   String.IsNullOrEmpty(admin_txtprofmiddlename.Text) OrElse
            admin_comboxdeptid.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        Dim insertLoginQuery As String = "INSERT INTO LOGIN (EMAIL, PASSWORD, ROLE) VALUES (@email, @password, 'PROFESSOR'); SELECT LAST_INSERT_ID() AS USER_ID;"
        Dim loginParams As New Dictionary(Of String, Object) From {
            {"@email", admin_txtemail.Text},
            {"@password", admin_txtpass.Text}
    }
        Dim userId As Integer = InsertDatas(insertLoginQuery, loginParams)

        Dim query As String = "INSERT INTO PROFESSOR (USER_ID, PROFESSOR_ID, FIRST_NAME, MIDDLE_NAME, LAST_NAME, DEPARTMENT_ID, CONTACT_NUMBER, ADDRESS, STATUS) " &
                              "VALUES (@USER_ID, @PROFESSOR_ID, @FIRST_NAME, @MIDDLE_NAME, @LAST_NAME, @DEPARTMENT_ID, @CONTACT_NUMBER, @ADDRESS, @STATUS)"

        Dim params As New Dictionary(Of String, Object) From {
    {"@USER_ID", userId},
    {"@PROFESSOR_ID", admin_txtprofid.Text},
    {"@FIRST_NAME", admin_txtproffirstname.Text},
    {"@MIDDLE_NAME", If(String.IsNullOrEmpty(admin_txtprofmiddlename.Text), DBNull.Value, admin_txtprofmiddlename.Text)},
    {"@LAST_NAME", admin_txtproflastname.Text},
    {"@DEPARTMENT_ID", If(admin_comboxdeptid.SelectedItem Is Nothing, DBNull.Value, admin_comboxdeptid.SelectedItem.ToString())},
    {"@CONTACT_NUMBER", If(String.IsNullOrEmpty(admin_txtcontactnum.Text), DBNull.Value, admin_txtcontactnum.Text)},
    {"@ADDRESS", If(String.IsNullOrEmpty(admin_txtaddress.Text), DBNull.Value, admin_txtaddress.Text)},
    {"@STATUS", If(admin_comboxstatus.SelectedItem Is Nothing, "ACTIVE", admin_comboxstatus.SelectedItem.ToString())}
}
        Dim isInserted As Boolean = InsertData(query, params)

        If isInserted Then
            MessageBox.Show("Professor data inserted successfully.")
        Else
            MessageBox.Show("Failed to insert professor data.")
        End If
    End Sub

    Private Function InsertDatas(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Dim connectionString As String = "Server=localhost;user=root;Database=university_grading_system"
        Dim userId As Integer = 0

        Using connection As MySqlConnection = New MySqlConnection(connectionString)
            connection.Open()

            Using command As New MySqlCommand(query, connection)
                For Each param In parameters
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        userId = reader.GetInt32(0)
                    End If
                End Using
            End Using
        End Using

        Return userId
    End Function

    Private Sub cleartxtbox()
        admin_txtprofid.Clear()
        admin_txtproffirstname.Clear()
        admin_txtprofmiddlename.Clear()
        admin_txtproflastname.Clear()
        admin_txtemail.Clear()
        admin_comboxdeptid.SelectedIndex = -1
        admin_comboxstatus.SelectedIndex = -1
        admin_txtcontactnum.Clear()
        admin_txtaddress.Clear()
        admin_txtemail.Clear()
        admin_txtpass.Clear()

    End Sub

    Private Sub admin_add_Click(sender As Object, e As EventArgs) Handles admin_add.Click
        InsertProfessorFromTextBoxes()
        cleartxtbox()
    End Sub

    Private Sub admin_comboxdeptid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles admin_comboxdeptid.SelectedIndexChanged

    End Sub

    Private Sub loaddepartment()
        Dim connectionString As String = "Server=localhost;user=root;Database=university_grading_system"
        Dim query As String = "SELECT DEPARTMENT_ID FROM department"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        admin_comboxdeptid.Items.Clear()
                        While reader.Read()
                            admin_comboxdeptid.Items.Add(reader("DEPARTMENT_ID").ToString())
                        End While
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error loading departments: " & ex.Message)
        End Try
    End Sub

End Class
