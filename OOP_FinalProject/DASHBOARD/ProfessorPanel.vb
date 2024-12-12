Imports MySql.Data.MySqlClient

Public Class ProfessorPanel
    Private WithEvents timer1 As New Timer
    Private ReadOnly LoggedInProfessorID As String

    Public Sub New(professorID As String)
        InitializeComponent()
        LoggedInProfessorID = professorID
    End Sub



    Private Sub ProfessorMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.KeyPreview = True
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading professor information: {ex.Message}")
        End Try
    End Sub

    Private Sub ProfessorMainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.R Then
            Try
                LoadProfessorInfo()
                LoadStudentStatistics()
                LoadProfessorSection()
            Catch ex As Exception
                MessageBox.Show($"An error occurred while loading professor information: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub LoadProfessorInfo()
        Dim query As String =
        "SELECT DISTINCT " &
        "    CONCAT(p.FIRST_NAME, ' ', p.LAST_NAME) AS FullName, " &
        "    p.PROFESSOR_ID, " &
        "    p.STATUS, " &
        "    l.EMAIL AS EmailAddress, " &
        "    d.DEPARTMENT_NAME AS DepartmentName " &
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
                lblStatus.Text = professorRow("STATUS").ToString()
                lblemail.Text = professorRow("EmailAddress").ToString()
                lbldepartment.Text = professorRow("DepartmentName").ToString()

                If professorRow("STATUS").ToString().ToUpper() = "ACTIVE" Then
                    lblStatus.ForeColor = Color.Green
                Else
                    lblStatus.ForeColor = Color.DarkRed
                End If
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
                "    COUNT(e.CLASS_ID) AS TotalEnrolledStudents, " &
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
        "SELECT DISTINCT s.SECTION_NAME " &
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

                prof_sectiondrop.DataSource = sectionTable.Copy.Copy()
                prof_sectiondrop.DisplayMember = "SECTION_NAME"
                prof_sectiondrop.ValueMember = "SECTION_NAME"
                prof_sectiondrop.SelectedIndex = -1

                sectionlistsgrading.DataSource = sectionTable
                sectionlistsgrading.DisplayMember = "SECTION_NAME"
                sectionlistsgrading.ValueMember = "SECTION_NAME"
                sectionlistsgrading.SelectedIndex = -1


                addgradesection.DataSource = sectionTable.Copy()
                addgradesection.DisplayMember = "SECTION_NAME"
                addgradesection.ValueMember = "SECTION_NAME"
                addgradesection.SelectedIndex = -1

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
                listofstudentstable.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load student details: {ex.Message}")
        End Try
    End Sub


    Private Sub sectionlistsgrading_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectionlistsgrading.SelectedIndexChanged
        If sectionlistsgrading.SelectedIndex <> -1 Then
            Dim selectedSection As String = sectionlistsgrading.SelectedValue.ToString()
            LoadStudentGrades(selectedSection)
        End If
    End Sub


    Private Sub LoadStudentGrades(sectionName As String)
        If String.IsNullOrEmpty(sectionName) Then Exit Sub

        Dim query As String =
        "SELECT " &
        "    CONCAT(s.LAST_NAME, ', ', s.FIRST_NAME, ' ', IFNULL(s.MIDDLE_NAME, '')) AS Student_Name, " &
        "    at.ASSESSMENT_NAME AS AssessmentType, " &
        "    a.ITEM_NAME AS Item, " &
        "    sg.SCORE_OBTAINED AS Score, " &
        "    a.MAX_SCORE AS Total_Score, " &
        "    a.ASSESSMENT_ID, " &
        "    sg.GRADE_ID " &
        "FROM ENROLLMENTS e " &
        "INNER JOIN STUDENT s ON e.STUDENT_ID = s.STUDENT_ID " &
        "INNER JOIN CLASSES c ON e.CLASS_ID = c.CLASS_ID " &
        "INNER JOIN ASSESSMENTS a ON c.CLASS_ID = a.CLASS_ID " &
        "INNER JOIN ASSESSMENT_TYPES at ON a.ASSESSMENT_TYPE_ID = at.ASSESSMENT_TYPE_ID " &
        "INNER JOIN STUDENT_GRADES sg ON e.STUDENT_ID = sg.STUDENT_ID AND a.ASSESSMENT_ID = sg.ASSESSMENT_ID " &
        "WHERE c.SECTION_ID = (SELECT SECTION_ID FROM SECTIONS WHERE SECTION_NAME = @sectionName)"


        Dim params As New Dictionary(Of String, Object) From {
        {"@sectionName", sectionName}
    }

        Try
            Dim gradesTable As DataTable = databaseConnection.GetDataTable(query, params)

            If gradesTable IsNot Nothing AndAlso gradesTable.Rows.Count > 0 Then
                assessmentsDataTable.DataSource = gradesTable
                assessmentsDataTable.Columns("ASSESSMENT_ID").Visible = False
                assessmentsDataTable.Columns("GRADE_ID").Visible = False
                assessmentsDataTable.Columns("AssessmentType").Visible = False
                assessmentsDataTable.Columns("Student_Name").ReadOnly = True

            Else
                assessmentsDataTable.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load grades: {ex.Message}")
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

    Private Sub prof_sbdashboard_Click(sender As Object, e As EventArgs) Handles prof_sbdashboard.Click
        profdashboard.BringToFront()
    End Sub

    Private Sub prof_sbmanagegrade_Click(sender As Object, e As EventArgs) Handles prof_sbmanagegrade.Click
        profgrading.BringToFront()
    End Sub

    Private Sub sb_addgradings_Click(sender As Object, e As EventArgs) Handles sb_addgradings.Click
        addgradepanel.BringToFront()
    End Sub
    '==============================================================================================================================================================================


    Private Sub UpdateGrade_Click(sender As Object, e As EventArgs) Handles update_grade.Click
        Try
            For Each row As DataGridViewRow In assessmentsDataTable.Rows
                If Not row.IsNewRow Then
                    Dim assessmentID As Integer = Convert.ToInt32(row.Cells("ASSESSMENT_ID").Value)
                    Dim itemName As String = row.Cells("Item").Value.ToString()
                    Dim maxScore As Integer = Convert.ToInt32(row.Cells("Total_Score").Value)
                    Dim gradeID As Integer = Convert.ToInt32(row.Cells("GRADE_ID").Value)
                    Dim scoreObtained As Integer = Convert.ToInt32(row.Cells("Score").Value)

                    Dim query As String =
                    "UPDATE ASSESSMENTS SET ITEM_NAME = @itemName, MAX_SCORE = @maxScore WHERE ASSESSMENT_ID = @assessmentID; " &
                    "UPDATE STUDENT_GRADES SET SCORE_OBTAINED = @scoreObtained WHERE GRADE_ID = @gradeID;"

                    Dim params As New Dictionary(Of String, Object) From {
                    {"@itemName", itemName},
                    {"@maxScore", maxScore},
                    {"@scoreObtained", scoreObtained},
                    {"@assessmentID", assessmentID},
                    {"@gradeID", gradeID}
                }

                    databaseConnection.ExecuteNonQuery(query, params)
                End If
            Next

            RecalculateGrades()
            MessageBox.Show("Grades updated and recalculated successfully.")
        Catch ex As Exception
            MessageBox.Show($"Error updating grades: {ex.Message}")
        End Try
    End Sub

    Private Sub RecalculateGrades()
        Try
            Dim query As String =
            "SELECT sg.STUDENT_ID, a.TERM, a.CLASS_ID, at.WEIGHTED_GRADE, sg.SCORE_OBTAINED, a.MAX_SCORE " &
            "FROM STUDENT_GRADES sg " &
            "INNER JOIN ASSESSMENTS a ON sg.ASSESSMENT_ID = a.ASSESSMENT_ID " &
            "INNER JOIN ASSESSMENT_TYPES at ON a.ASSESSMENT_TYPE_ID = at.ASSESSMENT_TYPE_ID"

            Dim gradesData As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())
            Dim termScores As New Dictionary(Of String, Decimal)()
            Dim termMaxScores As New Dictionary(Of String, Decimal)()

            For Each row As DataRow In gradesData.Rows
                Dim studentID As String = row("STUDENT_ID").ToString()
                Dim term As String = row("TERM").ToString()
                Dim classID As Integer = Convert.ToInt32(row("CLASS_ID"))
                Dim scoreObtained As Decimal = Convert.ToDecimal(row("SCORE_OBTAINED"))
                Dim maxScore As Decimal = Convert.ToDecimal(row("MAX_SCORE"))

                Dim key As String = $"{studentID}_{classID}_{term}"

                If Not termScores.ContainsKey(key) Then
                    termScores(key) = 0
                    termMaxScores(key) = 0
                End If

                termScores(key) += scoreObtained
                termMaxScores(key) += maxScore
            Next


            For Each key In termScores.Keys
                Dim parts = key.Split("_")
                Dim studentID = parts(0)
                Dim classID = Convert.ToInt32(parts(1))
                Dim term = parts(2)

                Dim totalScore = termScores(key)
                Dim totalMaxScore = termMaxScores(key)

                Dim percentage = (totalScore / totalMaxScore) * 50 + 50
                Dim gwa = CalculateGWA(percentage)

                Dim updateQuery As String
                If term.ToUpper() = "MIDTERM" Then
                    updateQuery = "UPDATE FINAL_GRADES SET MIDTERM_PERCENTAGE = @percentage, MIDTERM_GWA = @gwa WHERE STUDENT_ID = @studentID AND CLASS_ID = @classID;"
                Else
                    updateQuery = "UPDATE FINAL_GRADES SET FINALS_PERCENTAGE = @percentage, FINALS_GWA = @gwa WHERE STUDENT_ID = @studentID AND CLASS_ID = @classID;"
                End If

                Dim params As New Dictionary(Of String, Object) From {
                {"@percentage", percentage},
                {"@gwa", gwa},
                {"@studentID", studentID},
                {"@classID", classID}
            }

                databaseConnection.ExecuteNonQuery(updateQuery, params)
            Next


            UpdateSemestralGrades()
        Catch ex As Exception
            MessageBox.Show($"Error recalculating grades: {ex.Message}")
        End Try
    End Sub

    Private Sub UpdateSemestralGrades()
        Try
            Dim query As String = "SELECT STUDENT_ID, CLASS_ID, MIDTERM_PERCENTAGE, FINALS_PERCENTAGE FROM FINAL_GRADES"
            Dim finalGrades As DataTable = databaseConnection.GetDataTable(query, New Dictionary(Of String, Object)())

            For Each row As DataRow In finalGrades.Rows
                Dim studentID As String = row("STUDENT_ID").ToString()
                Dim classID As Integer = Convert.ToInt32(row("CLASS_ID"))
                Dim midtermPercentage As Decimal = Convert.ToDecimal(row("MIDTERM_PERCENTAGE"))
                Dim finalsPercentage As Decimal = Convert.ToDecimal(row("FINALS_PERCENTAGE"))

                Dim semestralPercentage = (midtermPercentage + finalsPercentage) / 2
                Dim semestralGWA = CalculateGWA(semestralPercentage)
                Dim remarks = If(semestralPercentage >= 75, "PASSED", "FAILED")

                Dim updateQuery As String =
                "UPDATE FINAL_GRADES SET SEMESTRAL_PERCENTAGE = @semestralPercentage, SEMESTRAL_GWA = @semestralGWA, REMARKS = @remarks " &
                "WHERE STUDENT_ID = @studentID AND CLASS_ID = @classID;"

                Dim params As New Dictionary(Of String, Object) From {
                {"@semestralPercentage", semestralPercentage},
                {"@semestralGWA", semestralGWA},
                {"@remarks", remarks},
                {"@studentID", studentID},
                {"@classID", classID}
            }

                databaseConnection.ExecuteNonQuery(updateQuery, params)
            Next
        Catch ex As Exception
            MessageBox.Show($"Error updating semestral grades: {ex.Message}")
        End Try
    End Sub

    Private Function CalculateGWA(percentage As Decimal) As Decimal
        Select Case percentage
            Case >= 97.5 : Return 1.0
            Case >= 94.5 : Return 1.25
            Case >= 91.5 : Return 1.5
            Case >= 88.5 : Return 1.75
            Case >= 85.5 : Return 2.0
            Case >= 82.5 : Return 2.25
            Case >= 79.5 : Return 2.5
            Case >= 76.5 : Return 2.75
            Case >= 75 : Return 3.0
            Case Else : Return 5.0
        End Select
    End Function

    Private Sub addnew_grade_Click(sender As Object, e As EventArgs) Handles addnew_grade.Click
        addgradepanel.BringToFront()
    End Sub




    Private Sub addgradesection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles addgradesection.SelectedIndexChanged
        If addgradesection.SelectedIndex <> -1 Then
            Dim selectedSection As String = TryCast(addgradesection.SelectedValue, String)
            If Not String.IsNullOrEmpty(selectedSection) Then
                LoadAddStudentLists(selectedSection)
            End If
        End If
    End Sub

    Private Sub LoadAddStudentLists(sectionName As String)
        If String.IsNullOrEmpty(sectionName) Then Exit Sub

        Dim query As String = "SELECT " &
                    "    CONCAT(s.LAST_NAME, ', ', s.FIRST_NAME, ' ', IFNULL(s.MIDDLE_NAME, '')) AS Student_Name " &
                    "FROM ENROLLMENTS e " &
                    "INNER JOIN STUDENT s ON e.STUDENT_ID = s.STUDENT_ID " &
                    "INNER JOIN CLASSES c ON e.CLASS_ID = c.CLASS_ID " &
                    "WHERE c.SECTION_ID = (SELECT SECTION_ID FROM SECTIONS WHERE SECTION_NAME = @sectionName)"

        Dim params As New Dictionary(Of String, Object) From {
        {"@sectionName", sectionName}
    }

        Try
            Dim studentListsAddGrade As DataTable = databaseConnection.GetDataTable(query, params)

            If studentListsAddGrade IsNot Nothing AndAlso studentListsAddGrade.Rows.Count > 0 Then
                studentaddgrade.DataSource = studentListsAddGrade.Copy()
                studentaddgrade.DisplayMember = "Student_Name"
                studentaddgrade.ValueMember = "Student_Name"
                studentaddgrade.SelectedIndex = -1
            Else
                studentaddgrade.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load student list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub studentaddgrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentaddgrade.SelectedIndexChanged
        If studentaddgrade.SelectedIndex <> -1 Then
            Dim selectedStudentName As String = TryCast(studentaddgrade.SelectedValue, String)
            If Not String.IsNullOrEmpty(selectedStudentName) Then
                LoadStudentGradeData(selectedStudentName)
            End If
        End If
    End Sub

    Private Sub LoadStudentGradeData(studentName As String)
        If String.IsNullOrEmpty(studentName) Then Exit Sub

        Dim query As String = "SELECT " &
                    "    CONCAT(s.LAST_NAME, ', ', s.FIRST_NAME, ' ', IFNULL(s.MIDDLE_NAME, '')) AS Student_Name, " &
                    "    at.ASSESSMENT_NAME AS AssessmentType, " &
                    "    a.ITEM_NAME AS Item, " &
                    "    sg.SCORE_OBTAINED AS Score, " &
                    "    a.MAX_SCORE AS Total_Score, " &
                    "    a.ASSESSMENT_ID, " &
                    "    sg.GRADE_ID " &
                    "FROM ENROLLMENTS e " &
                    "INNER JOIN STUDENT s ON e.STUDENT_ID = s.STUDENT_ID " &
                    "INNER JOIN CLASSES c ON e.CLASS_ID = c.CLASS_ID " &
                    "INNER JOIN ASSESSMENTS a ON c.CLASS_ID = a.CLASS_ID " &
                    "INNER JOIN ASSESSMENT_TYPES at ON a.ASSESSMENT_TYPE_ID = at.ASSESSMENT_TYPE_ID " &
                    "INNER JOIN STUDENT_GRADES sg ON e.STUDENT_ID = sg.STUDENT_ID AND a.ASSESSMENT_ID = sg.ASSESSMENT_ID " &
                    "WHERE CONCAT(s.LAST_NAME, ', ', s.FIRST_NAME, ' ', IFNULL(s.MIDDLE_NAME, '')) = @studentName"

        Dim params As New Dictionary(Of String, Object) From {
        {"@studentName", studentName}
    }

        Try
            Dim studentGradeData As DataTable = databaseConnection.GetDataTable(query, params)

            If studentGradeData IsNot Nothing AndAlso studentGradeData.Rows.Count > 0 Then
                addgradedatatable.DataSource = studentGradeData
            Else
                addgradedatatable.DataSource = Nothing
                MessageBox.Show("No grade data found for the selected student.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Failed to load student grade data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addnewgradestudents_Click(sender As Object, e As EventArgs) Handles addnewgradestudents.Click
        Try
            Dim professorDepartmentQuery As String =
            "SELECT DISTINCT " &
            "    p.DEPARTMENT_ID, " &
            "    d.DEPARTMENT_NAME " &
            "FROM LOGIN l " &
            "INNER JOIN PROFESSOR p ON l.USER_ID = p.USER_ID " &
            "INNER JOIN DEPARTMENT d ON p.DEPARTMENT_ID = d.DEPARTMENT_ID " &
            "WHERE l.USER_ID = @userID"

            Dim departmentParams As New Dictionary(Of String, Object) From {
            {"@userID", LoggedInProfessorID}
}
            Dim departmentTable As DataTable = databaseConnection.GetDataTable(professorDepartmentQuery, departmentParams)

            If departmentTable Is Nothing OrElse departmentTable.Rows.Count = 0 Then
                MessageBox.Show("Unable to retrieve the professor's department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim departmentId As Integer = Convert.ToInt32(departmentTable.Rows(0)("DEPARTMENT_ID"))


            Dim assessmentTypeQuery As String =
            "SELECT ASSESSMENT_TYPE_ID, ASSESSMENT_NAME " &
            "FROM ASSESSMENT_TYPES " &
            "WHERE DEPARTMENT_NAME = @departmentName"


            Dim assessmentTypeParams As New Dictionary(Of String, Object) From {
            {"@departmentName", departmentTable.Rows(0)("DEPARTMENT_NAME").ToString()}
        }
            Dim assessmentTypeTable As DataTable = databaseConnection.GetDataTable(assessmentTypeQuery, assessmentTypeParams)

            If assessmentTypeTable Is Nothing OrElse assessmentTypeTable.Rows.Count = 0 Then
                MessageBox.Show("No assessment types found for this department.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim editableTable As DataTable = CType(addgradedatatable.DataSource, DataTable)
            Dim newRow As DataRow = editableTable.NewRow()

            newRow("AssessmentType") = ""
            newRow("Item") = ""
            newRow("Score") = DBNull.Value
            newRow("Total_Score") = DBNull.Value
            newRow("Term") = ""

            editableTable.Rows.Add(newRow)

            For Each column As DataColumn In editableTable.Columns
                column.ReadOnly = True
            Next
            editableTable.Columns("AssessmentType").ReadOnly = False
            editableTable.Columns("Item").ReadOnly = False
            editableTable.Columns("Score").ReadOnly = False
            editableTable.Columns("Total_Score").ReadOnly = False
            editableTable.Columns("Term").ReadOnly = False

            MessageBox.Show("New row added. You can now edit the fields.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addgradeUpdate_Click(sender As Object, e As EventArgs) Handles addgradeUpdate.Click
        Try
            For Each row As DataGridViewRow In addgradedatatable.Rows
                If Not row.IsNewRow Then
                    Dim assessmentID As Integer = Convert.ToInt32(row.Cells("ASSESSMENT_ID").Value)
                    Dim itemName As String = row.Cells("Item").Value.ToString()
                    Dim maxScore As Integer = Convert.ToInt32(row.Cells("Total_Score").Value)
                    Dim gradeID As Integer = Convert.ToInt32(row.Cells("GRADE_ID").Value)
                    Dim scoreObtained As Integer = Convert.ToInt32(row.Cells("Score").Value)

                    Dim query As String =
                    "UPDATE ASSESSMENTS SET ITEM_NAME = @itemName, MAX_SCORE = @maxScore WHERE ASSESSMENT_ID = @assessmentID; " &
                    "UPDATE STUDENT_GRADES SET SCORE_OBTAINED = @scoreObtained WHERE GRADE_ID = @gradeID;"

                    Dim params As New Dictionary(Of String, Object) From {
                    {"@itemName", itemName},
                    {"@maxScore", maxScore},
                    {"@scoreObtained", scoreObtained},
                    {"@assessmentID", assessmentID},
                    {"@gradeID", gradeID}
                }

                    databaseConnection.ExecuteNonQuery(query, params)
                End If
            Next

            RecalculateGrades()
            MessageBox.Show("Grades updated and recalculated successfully.")
        Catch ex As Exception
            MessageBox.Show($"Error updating grades: {ex.Message}")
        End Try
    End Sub
End Class