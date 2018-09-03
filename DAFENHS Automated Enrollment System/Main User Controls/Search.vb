Imports System.Data.SqlClient
Public Class Search

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader
    Dim table As New DataTable
    Dim dataset As New DataSet

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cmbCategory.SelectedItem = "Junior Highschool" Then
            SearchJuniorHigh()
        Else
            SearchSeniorHigh()
        End If
    End Sub 

    Private Sub btnSearchPopulation_Click(sender As Object, e As EventArgs) Handles btnSearchPopulation.Click
        If cmbPopulationCategory.SelectedItem = "Junior Highschool" Then
            PopulationJuniorHigh()
        Else
            PopulationSeniorHigh()
        End If
    End Sub 

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedItem = "Junior Highschool" Then
            cmbTrack.Enabled = False
            cmbTrack.SelectedIndex = -1
        Else
            cmbTrack.Enabled = True 
        End If
    End Sub

    Private Sub cmbPopulationCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPopulationCategory.SelectedIndexChanged
        If cmbPopulationCategory.SelectedItem = "Junior Highschool" Then
            'cmbPopulationTrack.Enabled = False
        Else
            'cmbPopulationTrack.Enabled = True
        End If
    End Sub

    Private Sub SearchJuniorHigh()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSchoolYear.Text = "" Then
                MsgBox("Enter the School Year first!", MsgBoxStyle.Information)
                txtSchoolYear.Focus()
            ElseIf txtGradeLevel.Text = "" Then
                MsgBox("Enter the Grade Level first!", MsgBoxStyle.Information)
                txtGradeLevel.Focus()
            ElseIf txtSection.Text = "" Then
                MsgBox("Enter the Section first!", MsgBoxStyle.Information)
                txtSection.Focus()
            Else
                con.Open()
                Dim query As String
                query = "SELECT EnrollmentStatus_JuniorHighschool.LRN AS 'LRN', StudentRegistration_JuniorHighschool.LastName AS 'Last', StudentRegistration_JuniorHighschool.FirstName AS 'First', StudentRegistration_JuniorHighschool.MiddleName AS 'Middle', StudentRegistration_JuniorHighschool.Gender AS 'Gender', StudentRegistration_JuniorHighschool.Age AS 'Age', StudentRegistration_JuniorHighschool.Student_Address AS 'Address', StudentRegistration_JuniorHighschool.Birthdate AS 'Birth Date', StudentRegistration_JuniorHighschool.BirthPlace AS 'Birth Place', StudentRegistration_JuniorHighschool.Name_Father AS 'Father', StudentRegistration_JuniorHighschool.Name_Mother AS 'Mother', StudentRegistration_JuniorHighschool.Name_Guardian AS 'Guardian', StudentRegistration_JuniorHighschool.Guradian_Relationship AS 'Relationship' FROM StudentRegistration_JuniorHighschool INNER JOIN EnrollmentStatus_JuniorHighschool ON StudentRegistration_JuniorHighschool.LRN = EnrollmentStatus_JuniorHighschool.LRN WHERE Section='" & txtSection.Text & "' AND GradeLevel='" & txtGradeLevel.Text & "' AND SchoolYear='" & txtSchoolYear.Text & "' ORDER BY LastName ASC"
                cmd = New SqlCommand(query, con)

                adapter = New SqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                dgClassList.DataSource = table
                dgClassList.Refresh()
                con.Close()

                con.Open()
                Dim adviser As String
                adviser = "SELECT Adviser FROM Class_Advisory_Junior WHERE Section='" & txtSection.Text & "' AND GradeLevel='" & txtGradeLevel.Text & "' AND SchoolYear='" & txtSchoolYear.Text & "'"
                cmd = New SqlCommand(adviser, con)
                reader = cmd.ExecuteReader

                reader.Read()
                txtAdviser.Text = reader("Adviser").ToString
                reader.Close()

                con.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("No Information Found!, Please enter correctly!", MsgBoxStyle.Exclamation)
            txtAdviser.Text = ""
        End Try
    End Sub

    Private Sub SearchSeniorHigh()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSchoolYear.Text = "" Then
                MsgBox("Enter the School Year first!", MsgBoxStyle.Information)
                txtSchoolYear.Focus()
            ElseIf txtGradeLevel.Text = "" Then
                MsgBox("Enter the Grade Level first!", MsgBoxStyle.Information)
                txtGradeLevel.Focus()
            ElseIf txtSection.Text = "" Then
                MsgBox("Enter the Section first!", MsgBoxStyle.Information)
                txtSection.Focus()
            Else
                con.Open()
                Dim query As String
                query = "SELECT EnrollmentStatus_SeniorHighschool.LRN AS 'LRN', StudentRegistration_SeniorHighschool.LastName AS 'Last', StudentRegistration_SeniorHighschool.FirstName AS 'First', StudentRegistration_SeniorHighschool.MiddleName AS 'Middle', StudentRegistration_SeniorHighschool.Gender AS 'Gender', StudentRegistration_SeniorHighschool.Age AS 'Age', StudentRegistration_SeniorHighschool.Student_Address AS 'Address', StudentRegistration_SeniorHighschool.Birthdate AS 'Birth Date', StudentRegistration_SeniorHighschool.BirthPlace AS 'Birth Place', StudentRegistration_SeniorHighschool.Name_Father AS 'Father', StudentRegistration_SeniorHighschool.Name_Mother AS 'Mother', StudentRegistration_SeniorHighschool.Name_Guardian AS 'Guardian', StudentRegistration_SeniorHighschool.Guradian_Relationship AS 'Relationship' FROM StudentRegistration_SeniorHighschool INNER JOIN EnrollmentStatus_SeniorHighschool ON StudentRegistration_SeniorHighschool.LRN = EnrollmentStatus_SeniorHighschool.LRN WHERE Track='" & cmbTrack.SelectedItem & "' AND Section='" & txtSection.Text & "' AND GradeLevel='" & txtGradeLevel.Text & "' AND SchoolYear='" & txtSchoolYear.Text & "' ORDER BY LastName ASC"
                cmd = New SqlCommand(query, con)

                adapter = New SqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                dgClassList.DataSource = table
                dgClassList.Refresh()
                con.Close()

                con.Open()
                Dim adviser As String
                adviser = "SELECT Adviser FROM Class_Advisory_Senior WHERE Section='" & txtSection.Text & "' AND GradeLevel='" & txtGradeLevel.Text & "' AND SchoolYear='" & txtSchoolYear.Text & "' AND Track='" & cmbTrack.SelectedItem & "'"
                cmd = New SqlCommand(adviser, con)
                reader = cmd.ExecuteReader

                reader.Read()
                txtAdviser.Text = reader("Adviser").ToString
                reader.Close()

                con.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message) 
            MsgBox("No Information Found!, Please enter correctly!", MsgBoxStyle.Exclamation)
            txtAdviser.Text = ""
        End Try
    End Sub

    Private Sub PopulationJuniorHigh()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSchoolYearPopulation.Text = "" Then
                MsgBox("Enter the School Year first!", MsgBoxStyle.Information)
                txtSchoolYearPopulation.Focus()
            Else
                con.Open()
                Dim query2 As String
                query2 = "SELECT EnrollmentStatus_JuniorHighschool.GradeLevel, EnrollmentStatus_JuniorHighschool.Section, EnrollmentStatus_JuniorHighschool.LRN, StudentRegistration_JuniorHighschool.LastName, StudentRegistration_JuniorHighschool.FirstName, StudentRegistration_JuniorHighschool.MiddleName, StudentRegistration_JuniorHighschool.Gender  FROM StudentRegistration_JuniorHighschool INNER JOIN EnrollmentStatus_JuniorHighschool ON StudentRegistration_JuniorHighschool.LRN = EnrollmentStatus_JuniorHighschool.LRN WHERE SchoolYear = '" & txtSchoolYearPopulation.Text & "' ORDER BY GradeLevel ASC, Section ASC, LastName ASC, FirstName ASC, MiddleName ASC"
                cmd = New SqlCommand(query2, con)

                adapter = New SqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                dgPopulation.DataSource = table
                dgPopulation.Refresh()
                con.Close()

                con.Open()
                Dim query3 As String
                query3 = "SELECT SUM(CASE WHEN Gender = 'Male' THEN 1 ELSE 0 END) as MaleCount, SUM(CASE WHEN Gender = 'Female' THEN 1 ELSE 0 END) as FemaleCount, COUNT(*) as TotalCount FROM EnrollmentStatus_JuniorHighschool WHERE SchoolYear='" & txtSchoolYearPopulation.Text & "'"
                cmd = New SqlCommand(query3, con)
                reader = cmd.ExecuteReader

                If Not reader Is Nothing Then
                    reader.Read()
                    lblMale.Text = reader("MaleCount").ToString
                    lblFemale.Text = reader("FemaleCount").ToString
                    lblTotal.Text = reader("TotalCount").ToString
                    reader.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PopulationSeniorHigh()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSchoolYearPopulation.Text = "" Then
                MsgBox("Enter the School Year first!", MsgBoxStyle.Information)
                txtSchoolYearPopulation.Focus()
            Else
                con.Open()
                Dim query2 As String
                query2 = "SELECT EnrollmentStatus_SeniorHighschool.LRN, StudentRegistration_SeniorHighschool.LastName, StudentRegistration_SeniorHighschool.FirstName, StudentRegistration_SeniorHighschool.MiddleName, StudentRegistration_SeniorHighschool.Gender  FROM StudentRegistration_SeniorHighschool INNER JOIN EnrollmentStatus_SeniorHighschool ON StudentRegistration_SeniorHighschool.LRN = EnrollmentStatus_SeniorHighschool.LRN WHERE SchoolYear = '" & txtSchoolYearPopulation.Text & "'"
                cmd = New SqlCommand(query2, con)

                adapter = New SqlDataAdapter(cmd)
                table = New DataTable
                adapter.Fill(table)

                dgPopulation.DataSource = table
                dgPopulation.Refresh()
                con.Close()

                con.Open()
                Dim query3 As String
                query3 = "SELECT SUM(CASE WHEN Gender = 'Male' THEN 1 ELSE 0 END) as MaleCount, SUM(CASE WHEN Gender = 'Female' THEN 1 ELSE 0 END) as FemaleCount, COUNT(*) as TotalCount FROM EnrollmentStatus_SeniorHighschool WHERE SchoolYear='" & txtSchoolYearPopulation.Text & "'"
                cmd = New SqlCommand(query3, con)
                reader = cmd.ExecuteReader

                If Not reader Is Nothing Then
                    reader.Read()
                    lblMale.Text = reader("MaleCount").ToString
                    lblFemale.Text = reader("FemaleCount").ToString
                    lblTotal.Text = reader("TotalCount").ToString
                    reader.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
