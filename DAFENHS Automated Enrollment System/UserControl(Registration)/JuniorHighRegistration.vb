Imports System.Data.SqlClient
Imports System.IO

Public Class JuniorHighRegistration

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader
    Dim browse As New OpenFileDialog

    Private Sub cmbEnrollAs_SelectedIndexChanged(sender As Object, e As EventArgs)
        pnlPersonalInformation.Enabled = True
        pnlParents.Enabled = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            Dim pic As String
            browse.Filter = Nothing
            pic = browse.FileName
            browse.ShowDialog()
            picboxProfile.Image = Image.FromFile(browse.FileName)

        Catch ex As Exception
            Return
        End Try
    End Sub

    'For the Registration of Junior High Student 
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()


        Try 
            If txtLRN.Text = "" Then
                MsgBox("Enter Student Learner Reference Number (LRN) first!", MsgBoxStyle.Critical)
                txtLRN.Focus()
            ElseIf txtLastName.Text = "" Then
                MsgBox("Enter Student Last Name first!", MsgBoxStyle.Critical)
                txtLastName.Focus()
            ElseIf txtFirstName.Text = "" Then
                MsgBox("Enter Student First Name first!", MsgBoxStyle.Critical)
                txtFirstName.Focus()
            ElseIf txtMiddleName.Text = "" Then
                MsgBox("Enter Student Middle Name first!", MsgBoxStyle.Critical)
                txtMiddleName.Focus()
            ElseIf txtAddress.Text = "" Then
                MsgBox("Enter Student Address first!", MsgBoxStyle.Critical)
                txtAddress.Focus()
            ElseIf cmbGender.Text.Length = 0 Then
                MsgBox("Select Student Gender first!", MsgBoxStyle.Critical)
                cmbGender.Focus()
            ElseIf txtAge.Text = "" Then
                MsgBox("Enter Student Age first!", MsgBoxStyle.Critical)
                txtAge.Focus()
            ElseIf dtpBirthDate.Text = Now Then
                MsgBox("Enter correct date of the Student!", MsgBoxStyle.Critical)
                dtpBirthDate.Focus()
            ElseIf txtBirthPlace.Text = "" Then
                MsgBox("Enter Student Birthplace first!", MsgBoxStyle.Critical)
                txtBirthPlace.Focus()
            Else
                con.Open()
                Dim search As String
                search = "SELECT LRN FROM StudentRegistration_JuniorHighschool WHERE LRN='" & txtLRN.Text & "'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader

                If reader.HasRows Then
                    MsgBox("This Student has already registered!", MsgBoxStyle.Exclamation)
                    ClearEnrollmentRegistration()
                Else
                    con.Close()
                    con.Open()
                    Dim query As String
                    query = "INSERT INTO StudentRegistration_JuniorHighschool VALUES('" & txtLRN.Text & "', @StudentImage, '" & txtLastName.Text & "', '" & txtFirstName.Text & "', '" & txtMiddleName.Text & "', '" & cmbGender.SelectedItem & "', '" & txtAge.Text & "', '" & txtAddress.Text & "', '" & dtpBirthDate.Text & "', '" & txtBirthPlace.Text & "', '" & txtFather.Text & "', '" & txtMother.Text & "', '" & txtGuardian.Text & "', '" & cmbRelationship.SelectedItem & "')"
                    cmd = New SqlCommand(query, con)
                    cmd.Parameters.Add(New SqlClient.SqlParameter("@StudentImage", SqlDbType.Image)).Value = IO.File.ReadAllBytes(browse.FileName)
                    'reader = cmd.ExecuteReader()
                    cmd.ExecuteNonQuery()
                    MsgBox("Registered Successfully!", MsgBoxStyle.Information)
                    ClearEnrollmentRegistration()
                    con.Close()
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("No Duplication allowed, maybe the Student Fullname are the same!", MsgBoxStyle.Exclamation)
            ClearEnrollmentRegistration()
        Finally
            con.Dispose()
        End Try
    End Sub 
    'End For the Registration of Junior High Student

    Private Sub txtLRN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLRN.KeyPress
        If txtLRN.Text.Length > 12 Then
            e.Handled = True
            MsgBox("You have reached the maximum LRN digits", MsgBoxStyle.Exclamation)
            txtLRN.Text = ""
            txtLRN.Focus()
        End If
    End Sub
End Class
