Imports System.Data.SqlClient
Public Class RegisterSection

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader
    Dim table As New DataTable

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If cmbCategory.SelectedItem = "Senior Highschool" Then
            cmbTrack.Enabled = True
        Else
            cmbTrack.Enabled = False
        End If
    End Sub

    'For Registration Section 
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSection.Text = "" Then
                MsgBox("Enter theSection!")
            ElseIf cmbCategory.Text.Length = 0 Then
                MsgBox("Select Teacher gender!")
            Else
                If cmbCategory.SelectedItem = "Junior Highschool" Then
                    con.Open()
                    Dim query As String
                    query = "INSERT INTO Register_Section VALUES('" & txtSection.Text & "', '" & cmbCategory.SelectedItem & "', '" & cmbTrack.SelectedItem & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registered Successfully!", MsgBoxStyle.Information)
                    RegistrationClear()
                    ComboLoadSectionJunior()
                    Home.Enrollment1.EnrollmentJuniorHigh1.Refresh()
                    con.Close()
                Else
                    con.Open()
                    Dim query As String
                    query = "INSERT INTO Register_Section VALUES('" & txtSection.Text & "', '" & cmbCategory.SelectedItem & "', '" & cmbTrack.SelectedItem & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Registered Successfully!", MsgBoxStyle.Information)
                    RegistrationClear()
                    ComboLoadSectionSenior()
                    Home.Enrollment1.EnrollmentSeniorHigh1.Refresh()
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub 
    'End For Registration Section

    'For Searching the name of Section 
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSearch.Text = "" Then
                MsgBox("Enter Name of Teacher, before you search!", MsgBoxStyle.Information)
            Else
                con.Open()
                Dim query As String
                query = "SELECT * FROM Register_Section WHERE MySection='" & txtSearch.Text & "'"
                cmd = New SqlCommand(query, con)
                reader = cmd.ExecuteReader

                If Not reader Is Nothing Then
                    reader.Read()
                    txtSection.Text = reader("MySection").ToString()
                    cmbCategory.SelectedItem = reader("Category").ToString()
                    cmbTrack.SelectedItem = reader("Track").ToString()
                    reader.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("This Section are not yet Registered!", MsgBoxStyle.Information)
            txtSearch.Text = ""
        End Try
    End Sub
    'End For Searching the name of Section 
     
    'For Deleting the Section
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSection.Text = "" Then
                MsgBox("Enter Name of Section!")
            ElseIf cmbCategory.Text.Length = 0 Then
                MsgBox("Select category!")
            Else
                con.Open()
                Dim query As String
                query = "DELETE FROM Register_Section WHERE MySection='" & txtSection.Text & "'"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Delete Successfully!", MsgBoxStyle.Information)
                ComboLoadSectionJunior()
                ComboLoadSectionSenior()
                txtSearch.Text = ""
                txtSection.Text = ""
                cmbCategory.SelectedIndex = -1
                cmbTrack.SelectedIndex = -1
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub 
    'End For Deleting the Section 

    Private Sub ComboLoadSectionJunior()
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

    Private Sub ComboLoadSectionSenior()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            con.Open()
            Dim query As String
            query = "SELECT DISTINCT(MySection) FROM Register_Section WHERE Category='Senior Highschool'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader

            If Not reader Is Nothing Then
                Home.Enrollment1.EnrollmentSeniorHigh1.cmbSection.Items.Clear()
                While reader.Read
                    Dim load = reader("MySection").ToString()
                    Home.Enrollment1.EnrollmentSeniorHigh1.cmbSection.Items.Add(load)
                End While
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
