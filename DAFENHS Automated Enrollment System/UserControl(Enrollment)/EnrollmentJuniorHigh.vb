Imports System.Data.SqlClient
Imports System.IO

Public Class EnrollmentJuniorHigh

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable 
    Dim dataset As New DataSet

    'For Searching the Student LRN
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSearch.Text = "" Then
                MsgBox("Enter LRN first you search!", MsgBoxStyle.Information)
                txtSearch.Focus()
            Else
                con.Open()
                Dim query As String
                query = "SELECT LRN, StudentImage, LastName, FirstName, MiddleName, Gender, Age, Student_Address, Birthdate, BirthPlace FROM StudentRegistration_JuniorHighschool WHERE LRN='" & txtSearch.Text & "'"
                cmd = New SqlCommand(query, con)
                reader = cmd.ExecuteReader

                If Not reader Is Nothing Then
                    reader.Read()
                    txtLRN.Text = reader("LRN").ToString()
                    txtLastName.Text = reader("LastName").ToString()
                    txtFirstName.Text = reader("FirstName").ToString()
                    txtMiddleName.Text = reader("MiddleName").ToString()
                    txtGender.Text = reader("Gender").ToString()
                    txtAge.Text = reader("Age").ToString()
                    txtAddress.Text = reader("Student_Address").ToString()
                    txtBirthDate.Text = reader("Birthdate").ToString()
                    txtBirthPlace.Text = reader("BirthPlace").ToString()
                    Dim pic As Byte() = DirectCast(reader("StudentImage"), Byte())
                    Dim memosys As New MemoryStream(pic)
                    picboxProfile.Image = Image.FromStream(memosys)
                    lblIdentifier.Text = "R E G I S T E R E D"
                    reader.Close()  
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("This student are not yet registered!", MsgBoxStyle.Information)
            ClearEnrollmentRegistration()
        End Try
    End Sub
    'End For Searching the Student LRN

    Private Sub EnrollmentJuniorHigh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboLoadSection() 
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        EnrollJuniorHigh()
    End Sub

    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged
        ClassAdviserJunior()
        ScheduleHolderJunior()
    End Sub

    Private Sub ComboLoadSection()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            con.Open()
            Dim query As String
            query = "SELECT DISTINCT(MySection) FROM Register_Section WHERE Category='Junior Highschool'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader

            If Not reader Is Nothing Then
                Home.Enrollment1.EnrollmentJuniorHigh1.cmbSection.Items.Clear()
                While reader.Read
                    Dim load = reader("MySection").ToString()
                    Home.Enrollment1.EnrollmentJuniorHigh1.cmbSection.Items.Add(load)
                End While
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ScheduleHolderJunior()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            con.Open()
            Dim query As String
            query = "SELECT MySubject AS 'SUBJECT', MyTime AS 'TIME', Teacher AS 'TEACHERS' FROM Class_Schedule WHERE Category='Junior Highschool' AND GradeLevel='" & cmbGradeLevel.SelectedItem & "' AND Section='" & cmbSection.SelectedItem & "'"
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
            Return
        Finally
            con.Dispose()
        End Try
    End Sub

    'For the Enrollment of Students
    Private Sub EnrollJuniorHigh()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSearch.Text = "" Then
                MsgBox("Please Search Student LRN First!", MsgBoxStyle.Exclamation)
                txtSearch.Focus()
            ElseIf txtSchoolYear.Text = "" Then
                MsgBox("Please enter School Year first, before you enroll this student!", MsgBoxStyle.Exclamation)
                txtSchoolYear.Focus()
            ElseIf cmbGradeLevel.Text.Length = 0 Then
                MsgBox("Please select Gradelevel first, before you enroll this student!", MsgBoxStyle.Exclamation)
                cmbGradeLevel.Focus()
            ElseIf cmbSection.Text.Length = 0 Then
                MsgBox("Please select Section first, before you enroll this student!", MsgBoxStyle.Exclamation)
                cmbSection.Focus()
            Else
                con.Open()
                Dim query As String
                query = "INSERT INTO EnrollmentStatus_JuniorHighschool VALUES('" & txtLRN.Text & "', '" & txtGender.Text & "','" & cmbGradeLevel.SelectedItem & "', '" & cmbSection.SelectedItem & "', '" & txtSchoolYear.Text & "', '" & txtClassAdvisory.Text & "', '" & dgSubjectTeacher.Rows.GetFirstRow(DataGridViewElementStates.ReadOnly) & "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Enrolled Successfully", MsgBoxStyle.Information)
                ClearEnrollmentRegistration()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub
    'End For the Enrollment of Students

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
                While reader.Read
                    Dim load = reader("Fullname").ToString()
                    txtClassAdvisory.Text = reader(load)
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
                While reader.Read
                    Dim load = reader("Fullname").ToString()
                    txtClassAdvisory.Text = reader(load)
                End While
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeLevel.SelectedIndexChanged 
        ClassAdviserJunior()
        ScheduleHolderJunior()
    End Sub

    Public Sub ClassAdviserJunior()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        If cmbGradeLevel.Text.Length > 0 Then
            cmbSection.Enabled = True
        Else
            cmbSection.Enabled = False
        End If

        Try
            con.Open()
            Dim counting As Integer
            Dim count As String
            count = "SELECT COUNT(*) AS STUDENT FROM EnrollmentStatus_JuniorHighschool WHERE Section='" & cmbSection.SelectedItem & "' AND GradeLevel= '" & cmbGradeLevel.SelectedItem & "' AND SchoolYear='" & txtSchoolYear.Text & "'"
            cmd = New SqlCommand(count, con)
            reader = cmd.ExecuteReader

            reader.Read()
            counting = reader("STUDENT")

            If counting >= 30 Then
                MsgBox("This is Full Please proceed to another section!", MsgBoxStyle.Information)
                cmbGradeLevel.SelectedIndex = -1
                cmbSection.SelectedIndex = -1
                btnEnroll.Enabled = False
            Else
                con.Close()
                con.Open()
                Dim advisory As String
                advisory = "SELECT Adviser FROM Class_Advisory_Junior WHERE Section='" & cmbSection.SelectedItem & "' AND GradeLevel='" & cmbGradeLevel.SelectedItem & "' AND SchoolYear='" & txtSchoolYear.Text & "'"
                cmd = New SqlCommand(advisory, con)
                reader = cmd.ExecuteReader

                If reader.HasRows Then
                    reader.Read()
                    txtClassAdvisory.Text = reader("Adviser").ToString
                    reader.Close()
                Else
                    txtClassAdvisory.Text = ""
                End If

                btnEnroll.Enabled = True
                Return
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click 
        ScheduleHolderJunior()
    End Sub
End Class
