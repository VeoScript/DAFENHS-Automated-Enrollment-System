Imports System.Data.SqlClient
Public Class RegisterAccount

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader 

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        RegistrationClearAll()
    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    'For Registration of Login Security Account

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con = New SqlConnection()
        con.ConnectionString = MyConnection()

        Try
            If txtIdNumber.Text = "" Then
                MsgBox("Please enter your Id Number first!", MsgBoxStyle.Information)
                txtIdNumber.Focus()
            ElseIf txtFullname.Text = "" Then
                MsgBox("Please enter your Fullname first!", MsgBoxStyle.Information)
                txtFullname.Focus()
            ElseIf cmbPosition.Text.Length = 0 Then
                MsgBox("Please select your Position first!", MsgBoxStyle.Information)
                cmbPosition.Focus()
            ElseIf cmbAccountType.Text.Length = 0 Then
                MsgBox("Please select your Account Type first!", MsgBoxStyle.Information)
                cmbAccountType.Focus()
            ElseIf txtUsername.Text = "" Then
                MsgBox("Please enter your Username first!", MsgBoxStyle.Information)
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("Please enter your Password first!", MsgBoxStyle.Information)
                txtPassword.Focus()
            Else
                con.Open()
                Dim query As String
                query = "INSERT INTO RegisterSecurityAccount VALUES('" & txtIdNumber.Text & "', '" & txtFullname.Text & "', '" & cmbPosition.SelectedItem & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & cmbAccountType.SelectedItem & "')"
                cmd = New SqlCommand(query, con)
                reader = cmd.ExecuteReader() 
                MsgBox("Successfully Registered!", MsgBoxStyle.Information)
                RegistrationClearAll()
            End If
        Catch ex As Exception
            MsgBox("This Account is Already Registered!", MsgBoxStyle.Exclamation)
            'MsgBox(ex.Message)
            RegistrationClearAll()
        End Try
    End Sub

    'End For Registration of Login Security Account

    Private Sub btnSeePassword_MouseHover(sender As Object, e As EventArgs) Handles btnSeePassword.MouseHover
        txtPassword.isPassword = False
    End Sub

    Private Sub btnSeePassword_MouseLeave(sender As Object, e As EventArgs) Handles btnSeePassword.MouseLeave
        txtPassword.isPassword = True
    End Sub
End Class