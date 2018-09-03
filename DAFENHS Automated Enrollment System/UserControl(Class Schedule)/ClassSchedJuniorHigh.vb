Imports System.Data.SqlClient
Public Class ClassSchedJuniorHigh

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedItem = "Junior Highschool" Then 
            ComboLoadTeacherJunior()
            cmbTrack.Enabled = False
            cmbTrack.SelectedIndex = -1

            txtSchoolYear.Enabled = True
            txtSection.Enabled = True
            txtGradeLevel.Enabled = True
        Else
            ComboLoadTeacherSenior()

            cmbTrack.Enabled = True 
            txtSchoolYear.Enabled = True
            txtSection.Enabled = True
            txtGradeLevel.Enabled = True
        End If
    End Sub

    Private Sub ComboLoadTeacherJunior()
        con = New SqlConnection
        con.ConnectionString = MyConnection()
        Try
            con.Open()
            Dim query As String
            query = "SELECT DISTINCT(Fullname) FROM Register_Teachers WHERE Position='Teacher in  Junior High'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader

            If Not reader Is Nothing Then
                cmbTeacher.Items.Clear()
                cmbAdvisory.Items.Clear()
                While reader.Read
                    Dim load = reader("Fullname").ToString()
                    cmbTeacher.Items.Add(load)
                    cmbAdvisory.Items.Add(load)
                End While
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboLoadTeacherSenior()
        con = New SqlConnection
        con.ConnectionString = MyConnection()
        Try
            con.Open()
            Dim query As String
            query = "SELECT DISTINCT(Fullname) FROM Register_Teachers WHERE Position='Teacher in Senior High'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader

            If Not reader Is Nothing Then
                cmbTeacher.Items.Clear()
                cmbAdvisory.Items.Clear()
                While reader.Read
                    Dim load = reader("Fullname").ToString()
                    cmbTeacher.Items.Add(load)
                    cmbAdvisory.Items.Add(load)
                End While
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If cmbCategory.SelectedItem = "Junior Highschool" Then
                
                If cmbCategory.Text.Length = 0 Then
                    MsgBox("Please select category first!", MsgBoxStyle.Exclamation)
                ElseIf txtSchoolYear.Text = "" Then
                    MsgBox("Please enter School Year first!", MsgBoxStyle.Exclamation)
                ElseIf txtGradeLevel.Text = "" Then
                    MsgBox("Please enter Grade Level first!", MsgBoxStyle.Exclamation)
                ElseIf txtSection.Text = "" Then
                    MsgBox("Please enter Section first!", MsgBoxStyle.Exclamation)
                Else
                    con.Open()
                    Dim search As String
                    search = "SELECT Adviser FROM Class_Advisory_Junior WHERE SchoolYear='" & txtSchoolYear.Text & "' AND Section='" & txtSection.Text & "' AND GradeLevel='" & txtGradeLevel.Text & "'"
                    cmd = New SqlCommand(search, con)
                    reader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()
                        cmbAdvisory.SelectedItem = reader("Adviser").ToString
                        cmbAdvisory.Enabled = False
                        reader.Close()
                    Else 
                        cmbAdvisory.Enabled = True
                    End If

                    con.Close()
                    con.Open()
                    Dim query As String
                    query = "SELECT MySubject FROM Register_Subject WHERE GradeLevel='" & txtGradeLevel.Text & "' AND Category='" & cmbCategory.SelectedItem & "'"
                    cmd = New SqlCommand(query, con)

                    adapter = New SqlDataAdapter(cmd)
                    table = New DataTable
                    adapter.Fill(table)

                    dgSubjects.DataSource = table
                    dgSubjects.Refresh()

                    cmbTrack.Enabled = False
                    txtSchoolYear.Enabled = False
                    txtSection.Enabled = False
                    txtGradeLevel.Enabled = False

                    con.Close()
                End If

            Else
                If cmbCategory.Text.Length = 0 Then
                    MsgBox("Please select category first!", MsgBoxStyle.Exclamation)
                ElseIf txtSchoolYear.Text = "" Then
                    MsgBox("Please enter School Year first!", MsgBoxStyle.Exclamation)
                ElseIf txtGradeLevel.Text = "" Then
                    MsgBox("Please enter Grade Level first!", MsgBoxStyle.Exclamation)
                ElseIf txtSection.Text = "" Then
                    MsgBox("Please enter Section first!", MsgBoxStyle.Exclamation)
                Else
                    con.Open()
                    Dim search As String
                    search = "SELECT Adviser FROM Class_Advisory_Senior WHERE SchoolYear='" & txtSchoolYear.Text & "' AND Section='" & txtSection.Text & "' AND GradeLevel='" & txtGradeLevel.Text & "' AND Track='" & cmbTrack.SelectedItem & "'"
                    cmd = New SqlCommand(search, con)
                    reader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()
                        cmbAdvisory.SelectedItem = reader("Adviser").ToString 
                        cmbAdvisory.Enabled = False
                        reader.Close()
                    Else 
                        cmbAdvisory.Enabled = True
                    End If

                    con.Close()
                    con.Open()
                    Dim query As String
                    query = "SELECT MySubject FROM Register_Subject WHERE GradeLevel='" & txtGradeLevel.Text & "' AND Category='" & cmbCategory.SelectedItem & "'"
                    cmd = New SqlCommand(query, con)

                    adapter = New SqlDataAdapter(cmd)
                    table = New DataTable
                    adapter.Fill(table)

                    dgSubjects.DataSource = table
                    dgSubjects.Refresh()

                    con.Close()
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgSubjects_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSubjects.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.dgSubjects.Rows(e.RowIndex)

            txtIdentIdentifier.Text = row.Cells("MySubject").Value.ToString
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If cmbCategory.SelectedItem = "Junior Highschool" Then
                If txtTime.Text = "" Then
                    MsgBox("Please enter Time before you add", MsgBoxStyle.Exclamation)
                ElseIf cmbCategory.Text.Length = 0 Then
                    MsgBox("Please select Teacher before you add", MsgBoxStyle.Exclamation)
                ElseIf cmbAdvisory.Text.Length = 0 Then
                    MsgBox("Please select Adviser for this Section before you add", MsgBoxStyle.Exclamation)
                Else
                    con.Open()
                    Dim query As String
                    query = "INSERT INTO Class_Schedule(MySubject, MyTime, Teacher, Category, GradeLevel, SchoolYear, Section) VALUES('" & txtIdentIdentifier.Text & "', '" & txtTime.Text & "', '" & cmbTeacher.SelectedItem & "', '" & cmbCategory.SelectedItem & "', '" & txtGradeLevel.Text & "', '" & txtSchoolYear.Text & "', '" & txtSection.Text & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Added Successfully", MsgBoxStyle.Information)
                    Me.dgScheduleLoader.Rows.Add(txtIdentIdentifier.Text, txtTime.Text, cmbTeacher.SelectedItem)
                    'ScheduleHolderJunior()
                    'ScheduleHolderSenior()
                    txtIdentIdentifier.Text = ""
                    txtTime.Text = ""
                    con.Close()
                End If
            Else
                If txtTime.Text = "" Then
                    MsgBox("Please enter Time before you add", MsgBoxStyle.Exclamation)
                ElseIf cmbCategory.Text.Length = 0 Then
                    MsgBox("Please select Teacher before you add", MsgBoxStyle.Exclamation)
                ElseIf cmbAdvisory.Text.Length = 0 Then
                    MsgBox("Please select Adviser for this Section before you add", MsgBoxStyle.Exclamation)
                Else
                    con.Open()
                    Dim query As String
                    query = "INSERT INTO Class_Schedule(MySubject, MyTime, Teacher, Category, GradeLevel, SchoolYear, Section, Track) VALUES('" & txtIdentIdentifier.Text & "', '" & txtTime.Text & "', '" & cmbTeacher.SelectedItem & "', '" & cmbCategory.SelectedItem & "', '" & txtGradeLevel.Text & "', '" & txtSchoolYear.Text & "', '" & txtSection.Text & "', '" & cmbTrack.SelectedItem & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Added Successfully", MsgBoxStyle.Information)
                    Me.dgScheduleLoader.Rows.Add(txtIdentIdentifier.Text, txtTime.Text, cmbTeacher.SelectedItem)
                    'ScheduleHolderSenior()
                    'ScheduleHolderSenior()
                    txtIdentIdentifier.Text = ""
                    txtTime.Text = ""
                    con.Close()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Duplication of TIME, SUBJECT and TEACHER, Please input correctly!", MsgBoxStyle.Exclamation)
            txtTime.Text = ""
            Return
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub ScheduleHolderJunior()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            con.Open()
            Dim query As String
            query = "SELECT MySubject AS 'SUBJECT', MyTime AS 'TIME', Teacher AS 'TEACHERS' FROM Class_Schedule WHERE Category='Junior Highschool'"
            cmd = New SqlCommand(query, con)

            adapter = New SqlDataAdapter(cmd)
            table = New DataTable
            adapter.Fill(table)

            Home.Enrollment1.EnrollmentJuniorHigh1.dgSubjectTeacher.DataSource = table
            Home.Enrollment1.EnrollmentJuniorHigh1.dgSubjectTeacher.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("There are no Subject Registered in this system, Please register a subject first", MsgBoxStyle.Information)
            'ClassScheduleClear()
            txtTime.Text = ""
            Return
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub ScheduleHolderSenior()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            con.Open()
            Dim query As String
            query = "SELECT MySubject AS 'SUBJECT', MyTime AS 'TIME', Teacher AS 'TEACHERS' FROM Class_Schedule WHERE Category='Senior Highschool'"
            cmd = New SqlCommand(query, con)

            adapter = New SqlDataAdapter(cmd)
            table = New DataTable
            adapter.Fill(table)

            Home.Enrollment1.EnrollmentSeniorHigh1.dgSubjectTeacher.DataSource = table
            Home.Enrollment1.EnrollmentSeniorHigh1.dgSubjectTeacher.Refresh()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            'MsgBox("There are no Subject Registered in this system, Please register a subject first", MsgBoxStyle.Information)
            'ClassScheduleClear()
            txtTime.Text = ""
            Return
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnAddAdviser_Click(sender As Object, e As EventArgs) Handles btnAddAdviser.Click 
        If cmbCategory.SelectedItem = "Junior Highschool" Then
            AdviserJuniorHigh()
        Else
            AdviserSeniorHigh()
        End If
    End Sub

    Public Sub AdviserJuniorHigh()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If cmbAdvisory.Text.Length = 0 Then
                MsgBox("Please enter Class Adviser First!", MsgBoxStyle.Exclamation)
                cmbAdvisory.Focus()
            Else
                If txtTime.Text = "" Then
                    MsgBox("Please enter a Time first", MsgBoxStyle.Exclamation)
                ElseIf cmbTeacher.Text.Length = 0 Then
                    MsgBox("Please enter a Teacher first", MsgBoxStyle.Exclamation)
                Else
                    con.Open()
                    Dim adviser As String
                    adviser = "INSERT INTO Class_Advisory_Junior VALUES('" & txtGradeLevel.Text & "', '" & txtSection.Text & "', '" & cmbAdvisory.SelectedItem & "', '" & txtSchoolYear.Text & "')"
                    cmd = New SqlCommand(adviser, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Adviser Added Successfully!", MsgBoxStyle.Information)
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AdviserSeniorHigh()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If cmbAdvisory.Text.Length = 0 Then
                MsgBox("Please enter Class Adviser First!", MsgBoxStyle.Exclamation)
                cmbAdvisory.Focus()
            Else
                If txtTime.Text = "" Then
                    MsgBox("Please enter a Time first", MsgBoxStyle.Exclamation)
                ElseIf cmbTeacher.Text.Length = 0 Then
                    MsgBox("Please enter a Teacher first", MsgBoxStyle.Exclamation)
                Else
                    con.Open()
                    Dim adviser As String
                    adviser = "INSERT INTO Class_Advisory_Senior VALUES('" & txtGradeLevel.Text & "', '" & txtSection.Text & "', '" & cmbAdvisory.SelectedItem & "', '" & txtSchoolYear.Text & "', '" & cmbTrack.SelectedItem & "')"
                    cmd = New SqlCommand(adviser, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Adviser Added Successfully!", MsgBoxStyle.Information)
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
