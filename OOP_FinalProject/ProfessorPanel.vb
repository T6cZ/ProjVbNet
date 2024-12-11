Imports MySql.Data.MySqlClient

Public Class ProfessorPanel
    Private ReadOnly LoggedInProfessorID As String

    Public Sub New(professorID As String)
        InitializeComponent()
        LoggedInProfessorID = professorID
    End Sub

    Private Sub ProfessorMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfessorInfo()
        LoadSectionsForProfessor()
        LoadStatisticsForProfessor()

        If prof_sectiondrop.Items.Count > 0 Then
            Dim selectedSection As String = prof_sectiondrop.SelectedValue?.ToString()
            If selectedSection IsNot Nothing Then
                LoadAssessmentsDataTable(selectedSection)
            End If
        End If

        AddHandler listofstudentstable.SelectionChanged, AddressOf listofstudentstable_SelectionChanged
    End Sub

    Private Sub LoadProfessorInfo()
        Dim query As String = "SELECT DISTINCT 
                               CONCAT(Professor.LAST_NAME, ' ', Professor.FIRST_NAME) AS FullName, 
                               Professor.PROFESSOR_ID, 
                               Professor.DEPARTMENT_ID, 
                               Login.EMAIL AS EmailAddress
                               FROM PROFESSOR 
                               INNER JOIN LOGIN ON PROFESSOR.USER_ID = LOGIN.USER_ID 
                               WHERE PROFESSOR.PROFESSOR_ID = @professorID"

        Dim params As New Dictionary(Of String, Object) From {
            {"@professorID", LoggedInProfessorID}
        }

        Dim professorRow As DataRow = databaseConnection.GetDataRow(query, params)

        If professorRow IsNot Nothing Then
            prof_profname.Text = professorRow("FullName").ToString()
            lblprofid.Text = professorRow("PROFESSOR_ID").ToString()
            lblemail.Text = professorRow("EmailAddress").ToString()

            Dim deptQuery As String = "SELECT DEPARTMENT_NAME FROM DEPARTMENT WHERE DEPARTMENT_ID = @deptID"
            Dim deptParams As New Dictionary(Of String, Object) From {
                {"@deptID", professorRow("DEPARTMENT_ID").ToString()}
            }
            Dim deptRow As DataRow = databaseConnection.GetDataRow(deptQuery, deptParams)
            If deptRow IsNot Nothing Then
                lbldepartment.Text = deptRow("DEPARTMENT_NAME").ToString()
            End If
        Else
            MessageBox.Show("Professor information not found.")
        End If
    End Sub

    Private Sub LoadSectionsForProfessor()
        Dim query As String = "SELECT DISTINCT Sections.Section_Name 
                           FROM Sections    
                           INNER JOIN Classes ON Sections.Section_ID = Classes.Section_ID 
                           WHERE Classes.Professor_ID = @professorID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@professorID", LoggedInProfessorID}
    }

        Try
            ' Fetch sections only once
            Dim sectionsTable As DataTable = databaseConnection.GetDataTable(query, params)

            If sectionsTable.Rows.Count > 0 Then
                ' Bind sections to comboboxsectionlistgrading
                comboboxsectionlistgrading.DataSource = sectionsTable
                comboboxsectionlistgrading.DisplayMember = "Section_Name"
                comboboxsectionlistgrading.ValueMember = "Section_Name"

                ' Bind sections to prof_sectiondrop
                prof_sectiondrop.DataSource = sectionsTable
                prof_sectiondrop.DisplayMember = "Section_Name"
                prof_sectiondrop.ValueMember = "Section_Name"
            Else
                MessageBox.Show("No sections found for this professor.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load sections: {ex.Message}")
        End Try
    End Sub


    Private Sub prof_sectiondrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prof_sectiondrop.SelectedIndexChanged
        If prof_sectiondrop.SelectedIndex >= 0 Then
            LoadStudentsForSelectedSection(prof_sectiondrop.SelectedValue.ToString())
        End If
    End Sub

    Private Sub LoadStudentsForSelectedSection(sectionName As String)
        Dim query As String = "SELECT 
                              CONCAT(Student.LAST_NAME, ', ', Student.FIRST_NAME) AS Student_Name,
                              Courses.COURSE_ID,
                              Final_Grades.MIDTERM_PERCENTAGE,
                              Final_Grades.FINAL_PERCENTAGE,
                              Final_Grades.SEMESTRAL_PERCENTAGE,
                              Final_Grades.MIDTERM_GWA,
                              Final_Grades.FINAL_GWA,
                              Final_Grades.SEMESTRAL_GWA,
                              Final_Grades.REMARKS
                          FROM Enrollments 
                          INNER JOIN Student ON Enrollments.Student_ID = Student.Student_ID
                          INNER JOIN Classes ON Enrollments.CLASS_ID = Classes.CLASS_ID
                          INNER JOIN Sections ON Classes.Section_ID = Sections.Section_ID
                          INNER JOIN Courses ON Sections.COURSE_ID = Courses.COURSE_ID
                          LEFT JOIN Final_Grades ON Enrollments.CLASS_ID = Final_Grades.CLASS_ID
                          WHERE Sections.Section_Name = @sectionName
                          AND Classes.Professor_ID = @professorID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@sectionName", sectionName},
        {"@professorID", LoggedInProfessorID}
    }

        Try
            Dim studentsTable As DataTable = databaseConnection.GetDataTable(query, params)
            listofstudentstable.DataSource = studentsTable

            For Each column As DataGridViewColumn In listofstudentstable.Columns
                If column.Name <> "Student_Name" AndAlso column.Name <> "COURSE_ID" Then
                    column.Visible = False
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"Failed to load student data: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadStatisticsForProfessor()
        Dim query As String = "SELECT 
                               COUNT(Enrollments.Student_ID) AS Total_Students_Enrolled,
                               SUM(CASE WHEN Final_Grades.Remarks = 'Passed' THEN 1 ELSE 0 END) AS Total_Passed,
                               SUM(CASE WHEN Final_Grades.Remarks = 'Failed' THEN 1 ELSE 0 END) AS Total_Failed,
                               SUM(CASE WHEN Final_Grades.Remarks = 'Incomplete' THEN 1 ELSE 0 END) AS Total_Incomplete
                           FROM Enrollments
                           INNER JOIN Classes ON Enrollments.CLASS_ID = Classes.CLASS_ID
                           INNER JOIN Sections ON Classes.Section_ID = Sections.Section_ID
                           LEFT JOIN Final_Grades ON Enrollments.CLASS_ID = Final_Grades.CLASS_ID
                           WHERE Classes.Professor_ID = @professorID"

        Dim params As New Dictionary(Of String, Object) From {
        {"@professorID", LoggedInProfessorID}
    }

        Try
            Dim statsTable As DataTable = databaseConnection.GetDataTable(query, params)

            If statsTable.Rows.Count > 0 Then
                Dim row As DataRow = statsTable.Rows(0)
                totalstudentenrolled.Text = row("Total_Students_Enrolled").ToString()
                totalpassed.Text = row("Total_Passed").ToString()
                totalfailed.Text = row("Total_Failed").ToString()
                totalincomplete.Text = row("Total_Incomplete").ToString()
            Else

                totalstudentenrolled.Text = "0"
                totalpassed.Text = "0"
                totalfailed.Text = "0"
                totalincomplete.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load statistics: {ex.Message}")
        End Try
    End Sub

    Private Sub listofstudentstable_SelectionChanged(sender As Object, e As EventArgs) Handles listofstudentstable.SelectionChanged
        If listofstudentstable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = listofstudentstable.SelectedRows(0)

            midtermpercent.Text = selectedRow.Cells("MIDTERM_PERCENTAGE")?.Value?.ToString()
            midtermgwa.Text = selectedRow.Cells("MIDTERM_GWA")?.Value?.ToString()
            finalspercentage.Text = selectedRow.Cells("FINAL_PERCENTAGE")?.Value?.ToString()
            finalsgwa.Text = selectedRow.Cells("FINAL_GWA")?.Value?.ToString()
            semestralpercent.Text = selectedRow.Cells("SEMESTRAL_PERCENTAGE")?.Value?.ToString()
            semestralgwa.Text = selectedRow.Cells("SEMESTRAL_GWA")?.Value?.ToString()
            remarkslbl.Text = selectedRow.Cells("Remarks")?.Value?.ToString()
        End If
    End Sub

    Private Sub prof_sbdashboard_Click(sender As Object, e As EventArgs) Handles prof_sbdashboard.Click
        profdashboard.Show()
        profgrading.Hide()
    End Sub

    Private Sub prof_sbmanagegrade_Click(sender As Object, e As EventArgs) Handles prof_sbmanagegrade.Click
        profdashboard.Hide()
        profgrading.Show()
    End Sub

    '============================================================================================================

    Private Sub LoadAssessmentsDataTable(sectionName As String)
        Dim query As String = "SELECT 
                            Assessments.ASSESSMENT_ID,
                            Classes.CLASS_ID,
                            Assessments.ASSESSMENT_NAME,
                            Assessments.MAX_SCORE,
                            Assessments.WEIGHT,
                            Assessments.ASSESSMENT_DATE
                        FROM Assessments
                        INNER JOIN Classes ON Assessments.CLASS_ID = Classes.CLASS_ID
                        WHERE Classes.SECTION_ID IN (
                            SELECT SECTION_ID FROM Sections WHERE Section_Name = @sectionName
                        )"

        Dim params As New Dictionary(Of String, Object) From {
        {"@sectionName", sectionName}
    }

        Try
            Dim assessmentsTable As DataTable = databaseConnection.GetDataTable(query, params)
            assessmentsDataTable.DataSource = assessmentsTable
        Catch ex As Exception
            MessageBox.Show($"Failed to load assessments for {sectionName}: {ex.Message}")
        End Try
    End Sub

    Private Sub comboboxsectionlistgrading_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxsectionlistgrading.SelectedIndexChanged
        If comboboxsectionlistgrading.SelectedIndex >= 0 Then
            Dim selectedSection As String = comboboxsectionlistgrading.SelectedValue?.ToString()
            If selectedSection IsNot Nothing Then
                LoadAssessmentsDataTable(selectedSection)
            End If
        End If
    End Sub

    Private Sub listofstudentstable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listofstudentstable.CellContentClick

    End Sub
End Class
