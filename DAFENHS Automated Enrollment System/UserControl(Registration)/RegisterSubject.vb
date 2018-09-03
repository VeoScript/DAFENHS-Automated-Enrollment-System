Imports System.Data.SqlClient
Public Class RegisterSubject

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
            If txtGradeLevel.Text = "" Then
                MsgBox("Please Enter Grade Level first!", MsgBoxStyle.Exclamation)
            ElseIf txtSubject.Text = "" Then
                MsgBox("Please Enter Subject first!", MsgBoxStyle.Exclamation)
            ElseIf cmbCategory.Text.Length = 0 Then
                MsgBox("Please Select Category first!", MsgBoxStyle.Exclamation)
            Else
                con.Open()
                Dim query As String
                query = "INSERT INTO Register_Subject VALUES('" & txtGradeLevel.Text & "', '" & txtSubject.Text & "', '" & cmbCategory.SelectedItem & "')"
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Registered Successfully!", MsgBoxStyle.Information)
                RegistrationClear()
                'loadSubjectJunior()
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'End For Registration of Teachers


    'For Deleting the Specific Subjects
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try 
            con.Open()
            Dim query As String
            query = "DELETE FROM Register_Subject WHERE MySubject='" & txtSubject.Text & "'"
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Delete Successfully!", MsgBoxStyle.Information)
            Home.ClassSchedule1.ClassSchedJuniorHigh1.dgSubjects.Columns.Clear()
            'loadSubjectJunior()
            txtSearch.Text = ""
            txtSubject.Text = ""
            txtGradeLevel.Text = ""
            cmbCategory.SelectedIndex = -1 
            con.Close() 
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Sub For Deleting the Specific Subjects


    'For Searching the name of Subjects
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If txtSearch.Text = "" Then
                MsgBox("Enter Name of Subject, before you search!", MsgBoxStyle.Information)
            Else
                con.Open()
                Dim query As String
                query = "SELECT * FROM Register_Subject WHERE MySubject='" & txtSearch.Text & "'"
                cmd = New SqlCommand(query, con)
                reader = cmd.ExecuteReader

                If Not reader Is Nothing Then
                    reader.Read()
                    txtGradeLevel.Text = reader("GradeLevel").ToString()
                    txtSubject.Text = reader("MySubject").ToString()
                    cmbCategory.SelectedItem = reader("Category").ToString()
                    reader.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("This Subject are not yet Registered!", MsgBoxStyle.Information)
            txtSearch.Text = ""
        End Try
    End Sub
    'End For Searching the name of Subjects
End Class
