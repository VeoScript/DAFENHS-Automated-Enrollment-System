Imports System.Data.SqlClient
Public Class Login

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter 

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click, MyBase.Enter
        LoginConnection()
    End Sub

    'For Login Security Area

    Sub LoginConnection()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            If cmbLoginAs.Text.Length = 0 Then
                MsgBox("Hey! who are you?, Please select what Account Type are you!", MsgBoxStyle.Information)
                cmbLoginAs.Focus()
            ElseIf txtUsername.Text = "" Then
                MsgBox("Please enter Username first!", MsgBoxStyle.Information)
                txtUsername.Focus()
            ElseIf txtPassword.Text = "" Then
                MsgBox("Please enter Password first!", MsgBoxStyle.Information)
                txtPassword.Focus()
            Else
                con.Open()
                Dim query As String
                query = "SELECT Account_Username, Account_Password, Account_Type FROM RegisterSecurityAccount WHERE Account_Username='" & txtUsername.Text & "' AND Account_Password='" & txtPassword.Text & "' AND Account_Type='" & cmbLoginAs.SelectedItem & "'"
                cmd = New SqlCommand(query, con)
                reader = cmd.ExecuteReader()
                If reader.HasRows() Then
                    Main.Hide()
                    Me.Hide()
                    Home.Show()
                    LoginClearAll()
                Else
                    MsgBox("This account are not Registered!", MsgBoxStyle.Exclamation)
                    LoginClearAll()
                    cmbLoginAs.Focus()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            LoginClearAll()
        End Try
    End Sub

    'End For Login Security Area

    Private Sub btnSeePassword_MouseHover(sender As Object, e As EventArgs) Handles btnSeePassword.MouseHover
        txtPassword.isPassword = False
    End Sub

    Private Sub btnSeePassword_MouseLeave(sender As Object, e As EventArgs) Handles btnSeePassword.MouseLeave
        txtPassword.isPassword = True
    End Sub  
End Class