Imports MySql.Data.MySqlClient

Public Class ProfessorPanel

    Private ReadOnly LoggedInProfessorID As String

    Public Sub New(professorID As String)
        InitializeComponent()
        LoggedInProfessorID = professorID
    End Sub

    Private Sub ProfessorMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadProfessorInfo()
            LoadStudentStatistics()
            LoadProfessorSection()
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading professor information: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadProfessorInfo()
        Dim query As String =
            "SELECT DISTINCT " &
            "CONCAT(p.FIRST_NAME, ' ', p.LAST_NAME) AS FullName, " &
            "p.PROFESSOR_ID, " &
            "l.EMAIL AS EmailAddress, " &
            "d.DEPARTMENT_NAME AS DepartmentName " &
            "FROM LOGIN l " &
            "INNER JOIN PROFESSOR p ON l.USER_ID = p.USER_ID " &
            "INNER JOIN DEPARTMENT d ON p.DEPARTMENT_ID = d.DEPARTMENT_ID " &
            "WHERE l.USER_ID = @userID"

        Dim params As New Dictionary(Of String, Object) From {
            {"@userID", LoggedInProfessorID}
        }

        Try
            Dim professorRow As DataRow = databaseConnection.GetDataRow(query, params)

            If professorRow IsNot Nothing Then
                lblFullName.Text = professorRow("FullName").ToString()
                lblprofid.Text = professorRow("PROFESSOR_ID").ToString()
                lblemail.Text = professorRow("EmailAddress").ToString()
                lbldepartment.Text = professorRow("DepartmentName").ToString()
            Else
                MessageBox.Show("Professor information not found.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load professor information: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadStudentStatistics()
        Try
            Dim query As String =
            "SELECT " &
            "    COUNT(DISTINCT e.CLASS_ID) AS TotalEnrolledStudents, " &
            "    COUNT(DISTINCT CASE WHEN fg.REMARKS = 'PASSED' THEN 1 ELSE NULL END) AS PassedStudents, " &
            "    COUNT(DISTINCT CASE WHEN fg.REMARKS = 'FAILED' THEN 1 ELSE NULL END) AS FailedStudents, " &
            "    COUNT(DISTINCT CASE WHEN fg.REMARKS = 'INCOMPLETE' THEN 1 ELSE NULL END) AS IncompleteStudents " &
            "FROM PROFESSOR p " &
            "INNER JOIN CLASSES c ON p.PROFESSOR_ID = c.PROFESSOR_ID " &
            "LEFT JOIN ENROLLMENTS e ON c.CLASS_ID = e.CLASS_ID " &
            "LEFT JOIN FINAL_GRADES fg ON e.CLASS_ID = fg.CLASS_ID AND e.STUDENT_ID = fg.STUDENT_ID " &
            "WHERE p.USER_ID = @userID"

            Dim params As New Dictionary(Of String, Object) From {
                {"@userID", LoggedInProfessorID}
            }

            Dim statsRow As DataRow = databaseConnection.GetDataRow(query, params)

            If statsRow IsNot Nothing Then
                lblTotalEnrolledStudents.Text = If(statsRow("TotalEnrolledStudents") IsNot DBNull.Value, statsRow("TotalEnrolledStudents").ToString(), "0")
                lblPassedStudents.Text = If(statsRow("PassedStudents") IsNot DBNull.Value, statsRow("PassedStudents").ToString(), "0")
                lblFailedStudents.Text = If(statsRow("FailedStudents") IsNot DBNull.Value, statsRow("FailedStudents").ToString(), "0")
                lblIncompleteStudents.Text = If(statsRow("IncompleteStudents") IsNot DBNull.Value, statsRow("IncompleteStudents").ToString(), "0")
            Else
                MessageBox.Show("No student statistics found.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Database Error: {ex.Message}")
        End Try
    End Sub

    Private Sub LoadProfessorSection()
        Dim query As String =
            "SELECT s.SECTION_NAME " &
            "FROM PROFESSOR p " &
            "INNER JOIN CLASSES c ON p.PROFESSOR_ID = c.PROFESSOR_ID " &
            "INNER JOIN SECTIONS s ON c.SECTION_ID = s.SECTION_ID " &
            "WHERE p.USER_ID = @userID"

        Dim params As New Dictionary(Of String, Object) From {
            {"@userID", LoggedInProfessorID}
        }

        Try
            Dim sectionTable As DataTable = databaseConnection.GetDataTable(query, params)

            If sectionTable IsNot Nothing AndAlso sectionTable.Rows.Count > 0 Then
                sectionlistsgrading.DataSource = sectionTable
                sectionlistsgrading.DisplayMember = "SECTION_NAME"
                sectionlistsgrading.ValueMember = "SECTION_NAME"
                sectionlistsgrading.SelectedIndex = -1
            End If

            If sectionTable IsNot Nothing AndAlso sectionTable.Rows.Count > 0 Then
                prof_sectiondrop.DataSource = sectionTable
                prof_sectiondrop.DisplayMember = "SECTION_NAME"
                prof_sectiondrop.ValueMember = "SECTION_NAME"
                prof_sectiondrop.SelectedIndex = -1
            Else
                MessageBox.Show("No sections found for the professor.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load sections: {ex.Message}")
        End Try
    End Sub

    Private Sub prof_sectiondrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prof_sectiondrop.SelectedIndexChanged
        If prof_sectiondrop.SelectedIndex <> -1 Then
            Dim selectedSection As String = prof_sectiondrop.SelectedValue.ToString()
            LoadStudentDetails(selectedSection)
        End If
    End Sub

    Private Sub LoadStudentDetails(sectionName As String)
        If String.IsNullOrEmpty(sectionName) Then Exit Sub

        Dim query As String =
        "SELECT " &
        "    CONCAT(s.LAST_NAME, ', ', s.FIRST_NAME, ' ', IFNULL(s.MIDDLE_NAME, '')) AS FullName, " &
        "    c.COURSE_ID, " &
        "    fg.MIDTERM_PERCENTAGE, fg.MIDTERM_GWA, " &
        "    fg.FINALS_PERCENTAGE, fg.FINALS_GWA, " &
        "    fg.SEMESTRAL_PERCENTAGE, fg.SEMESTRAL_GWA, " &
        "    fg.REMARKS " &
        "FROM ENROLLMENTS e " &
        "INNER JOIN STUDENT s ON e.STUDENT_ID = s.STUDENT_ID " &
        "INNER JOIN CLASSES c ON e.CLASS_ID = c.CLASS_ID " &
        "INNER JOIN FINAL_GRADES fg ON e.STUDENT_ID = fg.STUDENT_ID AND e.CLASS_ID = fg.CLASS_ID " &
        "WHERE c.SECTION_ID = (SELECT SECTION_ID FROM SECTIONS WHERE SECTION_NAME = @sectionName)"

        Dim params As New Dictionary(Of String, Object) From {
            {"@sectionName", sectionName}
        }

        Try
            Dim studentDetailsTable As DataTable = databaseConnection.GetDataTable(query, params)

            If studentDetailsTable IsNot Nothing AndAlso studentDetailsTable.Rows.Count > 0 Then
                listofstudentstable.DataSource = studentDetailsTable

                listofstudentstable.Columns("MIDTERM_PERCENTAGE").Visible = False
                listofstudentstable.Columns("MIDTERM_GWA").Visible = False
                listofstudentstable.Columns("FINALS_PERCENTAGE").Visible = False
                listofstudentstable.Columns("FINALS_GWA").Visible = False
                listofstudentstable.Columns("SEMESTRAL_PERCENTAGE").Visible = False
                listofstudentstable.Columns("SEMESTRAL_GWA").Visible = False
                listofstudentstable.Columns("REMARKS").Visible = False
            Else

            End If

            If studentDetailsTable IsNot Nothing AndAlso studentDetailsTable.Rows.Count > 0 Then
                listofstudentstable.DataSource = studentDetailsTable
            Else
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load student details: {ex.Message}")
        End Try
    End Sub

    Private Sub listofstudentstable_SelectionChanged(sender As Object, e As EventArgs) Handles listofstudentstable.SelectionChanged
        If listofstudentstable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = listofstudentstable.SelectedRows(0)
            midtermpercent.Text = If(selectedRow.Cells("MIDTERM_PERCENTAGE").Value IsNot DBNull.Value, selectedRow.Cells("MIDTERM_PERCENTAGE").Value.ToString(), "0")
            midtermgwa.Text = If(selectedRow.Cells("MIDTERM_GWA").Value IsNot DBNull.Value, selectedRow.Cells("MIDTERM_GWA").Value.ToString(), "0")
            finalspercentage.Text = If(selectedRow.Cells("FINALS_PERCENTAGE").Value IsNot DBNull.Value, selectedRow.Cells("FINALS_PERCENTAGE").Value.ToString(), "0")
            finalsgwa.Text = If(selectedRow.Cells("FINALS_GWA").Value IsNot DBNull.Value, selectedRow.Cells("FINALS_GWA").Value.ToString(), "0")
            semestralpercent.Text = If(selectedRow.Cells("SEMESTRAL_PERCENTAGE").Value IsNot DBNull.Value, selectedRow.Cells("SEMESTRAL_PERCENTAGE").Value.ToString(), "0")
            semestralgwa.Text = If(selectedRow.Cells("SEMESTRAL_GWA").Value IsNot DBNull.Value, selectedRow.Cells("SEMESTRAL_GWA").Value.ToString(), "0")
            remarkslbl.Text = If(selectedRow.Cells("REMARKS").Value IsNot DBNull.Value, selectedRow.Cells("REMARKS").Value.ToString(), "N/A")
        End If
    End Sub

    Private Sub loadstudentgrades(selectedSectiongrading As String)

        If String.IsNullOrEmpty(selectedSectiongrading) Then Exit Sub

        Dim query As String =
        "SELECT " &
        "    CONCAT(s.LAST_NAME, ', ', s.FIRST_NAME, ' ', IFNULL(s.MIDDLE_NAME, '')) AS FullName, " &
        "    c.COURSE_ID, " &
        "    at.ASSESSMENT_NAME AS AssessmentType, " &
        "    a.ITEM_NAME, " &
        "    sg.SCORE_OBTAINED, " &
        "    a.MAX_SCORE " &
        "FROM " &
        "    ENROLLMENTS e " &
        "INNER JOIN STUDENT s ON e.STUDENT_ID = s.STUDENT_ID " &
        "INNER JOIN CLASSES c ON e.CLASS_ID = c.CLASS_ID " &
        "INNER JOIN ASSESSMENTS a ON c.CLASS_ID = a.CLASS_ID " &
        "INNER JOIN ASSESSMENT_TYPES at ON a.ASSESSMENT_TYPE_ID = at.ASSESSMENT_TYPE_ID " &
        "INNER JOIN STUDENT_GRADES sg ON e.STUDENT_ID = sg.STUDENT_ID AND a.ASSESSMENT_ID = sg.ASSESSMENT_ID " &
        "WHERE " &
        "    c.SECTION_ID = (SELECT SECTION_ID FROM SECTIONS WHERE SECTION_NAME = @sectionName)"

        Dim params As New Dictionary(Of String, Object) From {
        {"@sectionName", selectedSectiongrading}
    }

        Try
            Dim assessmentsDataTable As DataTable = databaseConnection.GetDataTable(query, params)

            If assessmentsDataTable Is Nothing OrElse assessmentsDataTable.Rows.Count = 0 Then
                MessageBox.Show("No student grades found for this section.")
                ' Optionally, clear the data binding to the UI control
            Else
                ' Bind studentGradesTable to the UI control (e.g., assessmentsDataTable)
            End If

        Catch ex As Exception
            MessageBox.Show($"Failed to load student grades: {ex.Message}")
        End Try
    End Sub

    Private Sub sectionlistsgrading_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectionlistsgrading.SelectedIndexChanged
        If sectionlistsgrading.SelectedIndex <> -1 Then
            Dim selectedSectiongrading As String = sectionlistsgrading.SelectedValue.ToString()
            loadstudentgrades(selectedSectiongrading)
        End If
    End Sub

    Private Sub prof_sbdashboard_Click(sender As Object, e As EventArgs) Handles prof_sbdashboard.Click
        profdashboard.BringToFront()

    End Sub

    Private Sub prof_sbmanagegrade_Click(sender As Object, e As EventArgs) Handles prof_sbmanagegrade.Click
        profgrading.BringToFront()

    End Sub
End Class
