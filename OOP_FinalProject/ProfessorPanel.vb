Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class ProfessorPanel

    Private connectionString As String = "server=localhost; user=root; database=grading_system"

    Public Property ProfessorID As String
    Public Property LastName As String
    Public Property FirstName As String
    Public Property MiddleName As String
    Public Property DepartmentID As String
    Public Property DepartmentName As String
    Public Property Status As String

    Private Sub ProfessorPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the labels
        lblProfessorID.Text = ProfessorID
        lblLastName.Text = LastName
        lblFirstName.Text = FirstName
        lblMiddleName.Text = MiddleName
        lbldepartment.Text = DepartmentName
        lblStatus.Text = Status
        prof_profname.Text = ProfFullName  ' Set the concatenated full name

        ' Populate the section dropdown
        PopulateSections()
    End Sub

    Private Sub PopulateSections()
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()

            Dim query As String = "
                SELECT YEAR_SECTION
                FROM SECTION
                WHERE DEPARTMENT_ID = @DepartmentID
                  AND YEAR_SECTION IN (
                      SELECT YEAR_SECTION
                      FROM CLASSES
                      WHERE PROFESSOR_ID = @ProfessorID
                  );
            "

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@DepartmentID", DepartmentID)
                cmd.Parameters.AddWithValue("@ProfessorID", ProfessorID)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        prof_sectiondrop.Items.Add(reader("YEAR_SECTION").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub



    Private Sub prof_profname_Click(sender As Object, e As EventArgs) Handles prof_profname.Click

    End Sub

    Private Sub lblprofid_Click(sender As Object, e As EventArgs) Handles lblprofid.Click

    End Sub

    Private Sub lblemail_Click(sender As Object, e As EventArgs) Handles lblemail.Click

    End Sub

    Private Sub lbldepartment_Click(sender As Object, e As EventArgs) Handles lbldepartment.Click

    End Sub

    Private Sub totalstudentenrolled_Click(sender As Object, e As EventArgs) Handles totalstudentenrolled.Click

    End Sub

    Private Sub totalpassed_Click(sender As Object, e As EventArgs) Handles totalpassed.Click

    End Sub

    Private Sub totalfailed_Click(sender As Object, e As EventArgs) Handles totalfailed.Click

    End Sub

    Private Sub totalincomplete_Click(sender As Object, e As EventArgs) Handles totalincomplete.Click

    End Sub

    Private Sub prof_sectiondrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prof_sectiondrop.SelectedIndexChanged

    End Sub

    Private Sub midtermpercent_Click(sender As Object, e As EventArgs) Handles midtermpercent.Click

    End Sub

    Private Sub midtermgwa_Click(sender As Object, e As EventArgs) Handles midtermgwa.Click

    End Sub

    Private Sub finalspercentage_Click(sender As Object, e As EventArgs) Handles finalspercentage.Click

    End Sub

    Private Sub finalsgwa_Click(sender As Object, e As EventArgs) Handles finalsgwa.Click

    End Sub

    Private Sub semestralpercent_Click(sender As Object, e As EventArgs) Handles semestralpercent.Click

    End Sub

    Private Sub semestralgwa_Click(sender As Object, e As EventArgs) Handles semestralgwa.Click

    End Sub

    Private Sub remarks_Click(sender As Object, e As EventArgs) Handles remarks.Click

    End Sub

    Private Sub prof_sblogout_Click(sender As Object, e As EventArgs) Handles prof_sblogout.Click

    End Sub

    Private Sub prof_sbsettings_Click(sender As Object, e As EventArgs) Handles prof_sbsettings.Click

    End Sub

    Private Sub prof_sbmanagegrade_Click(sender As Object, e As EventArgs) Handles prof_sbmanagegrade.Click
        profdashboard.Hide()
        profgrading.Show()
    End Sub

    Private Sub prof_sbdashboard_Click(sender As Object, e As EventArgs) Handles prof_sbdashboard.Click
        profdashboard.Show()
        profgrading.Hide()

    End Sub
End Class
