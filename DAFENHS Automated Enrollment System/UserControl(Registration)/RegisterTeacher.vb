Imports System.Data.SqlClient
Public Class RegisterTeacher

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader
    Dim table As New DataTable

    'For Registration of Teachers
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtIDNumber.Text = "" Then
                MsgBox("Enter Teacher Id Number!")
            ElseIf txtFullname.Text = "" Then
                MsgBox("Enter Teacher Fullname!")
            ElseIf cmbGender.Text.Length = 0 Then
                MsgBox("Select Teacher gender!")
            ElseIf cmbPosition.Text.Length = 0 Then
                MsgBox("Select Teacher Postion!")
            ElseIf cmbRank.Text.Length = 0 Then
                MsgBox("Select Teacher Rank!")
            Else
                If cmbPosition.SelectedItem = "Teacher in  Junior High" Then
                    con.Open()
                    Dim query As String
                    query = "INSERT INTO Register_Teachers VALUES('" & txtIDNumber.Text & "', '" & txtFullname.Text & "', '" & cmbGender.SelectedItem & "', '" & cmbPosition.SelectedItem & "', '" & cmbRank.SelectedItem & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registered Successfully!", MsgBoxStyle.Information)
                    RegistrationClear()
                    ComboLoadTeacherJunior()
                    Home.Enrollment1.EnrollmentJuniorHigh1.Refresh() 
                    con.Close()
                Else
                    con.Open()
                    Dim query As String
                    query = "INSERT INTO Register_Teachers VALUES('" & txtIDNumber.Text & "', '" & txtFullname.Text & "', '" & cmbGender.SelectedItem & "', '" & cmbPosition.SelectedItem & "', '" & cmbRank.SelectedItem & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registered Successfully!", MsgBoxStyle.Information)
                    RegistrationClear() 
                    ComboLoadTeacherSenior() 
                    Home.Enrollment1.EnrollmentSeniorHigh1.Refresh()
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'For Registration of Teachers

    'For Deleting of Specific Teachers
    Private Sub btnDelete_Click(sener As Object, e As EventArgs) Handles btnDelete.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtIDNumber.Text = "" Then
                MsgBox("Enter Teacher Id Number!")
            ElseIf txtFullname.Text = "" Then
                MsgBox("Enter Teacher Fullname!")
            ElseIf cmbGender.Text.Length = 0 Then
                MsgBox("Select Teacher gender!")
            ElseIf cmbPosition.Text.Length = 0 Then
                MsgBox("Select Teacher Postion!")
            ElseIf cmbRank.Text.Length = 0 Then
                MsgBox("Select Teacher Rank!")
            Else
                con.Open()
                Dim query As String
                query = "DELETE FROM Register_Teachers WHERE ID_Number='" & txtIDNumber.Text & "' OR Fullname='" & txtFullname.Text & "'"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Delete Successfully!", MsgBoxStyle.Information)
                ComboLoadTeacherJunior()
                ComboLoadTeacherSenior()
                txtFullname.Text = ""
                txtIDNumber.Text = ""
                txtSearch.Text = ""
                cmbGender.SelectedIndex = -1
                cmbPosition.SelectedIndex = -1
                cmbRank.SelectedIndex = -1
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'End For Deleting of Specific Teachers

    'For Searching the name of the Teachers
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSearch.Text = "" Then
                MsgBox("Enter Name of Teacher, before you search!", MsgBoxStyle.Information)
            Else
                con.Open()
                Dim query As String
                query = "SELECT * FROM Register_Teachers WHERE FullName='" & txtSearch.Text & "'"
                cmd = New SqlCommand(query, con)
                reader = cmd.ExecuteReader

                If Not reader Is Nothing Then
                    reader.Read() 
                    txtIDNumber.Text = reader("ID_Number").ToString()
                    txtFullname.Text = reader("FullName").ToString()
                    cmbGender.SelectedItem = reader("Gender").ToString()
                    cmbPosition.SelectedItem = reader("Position").ToString()
                    cmbRank.SelectedItem = reader("Teacher_Rank").ToString() 
                    reader.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("This Teacher are not yet Registered!", MsgBoxStyle.Information) 
            txtSearch.Text = ""
        End Try
    End Sub
    'End For Searching the name of the Teachers


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
                Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbAdvisory.Items.Clear()
                Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbTeacher.Items.Clear()
                While reader.Read
                    Dim load = reader("Fullname").ToString()
                    Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbAdvisory.Items.Add(load)
                    Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbTeacher.Items.Add(load)
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
                Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbAdvisory.Items.Clear()
                Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbTeacher.Items.Clear()
                While reader.Read
                    Dim load = reader("Fullname").ToString()
                    Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbAdvisory.Items.Add(load)
                    Home.ClassSchedule1.ClassSchedJuniorHigh1.cmbTeacher.Items.Add(load)
                End While
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
