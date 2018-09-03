Imports System.Data.SqlClient
Public Class SecurityAdmin

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub

    Private Sub btnSeePassword_MouseHover(sender As Object, e As EventArgs) Handles btnSeePassword.MouseHover
        txtPassword.isPassword = False
    End Sub

    Private Sub btnSeePassword_MouseLeave(sender As Object, e As EventArgs) Handles btnSeePassword.MouseLeave
        txtPassword.isPassword = True
    End Sub

    'For the ADMIN Security Password

    Private Sub btnAccess_Click(sender As Object, e As EventArgs) Handles btnAccess.Click
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            con.Open()
            Dim query As String
            query = "SELECT Account_Password, Account_Type FROM RegisterSecurityAccount WHERE Account_Password='" & txtPassword.Text & "' AND Account_Type='ADMIN'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader

            If reader.HasRows Then
                txtPassword.Text = ""
                Me.Hide()
                RegisterAccount.Show()
            Else
                MsgBox("Incorrect Password!")
                txtPassword.Text = ""
                Return
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    'End For the ADMIN Security Password
End Class