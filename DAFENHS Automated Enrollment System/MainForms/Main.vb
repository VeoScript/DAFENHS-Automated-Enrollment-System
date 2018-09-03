Public Class Main

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        DialogResult = MessageBox.Show("Are you sure you want to shutdown this system?", "Automated Enrollment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerNow.Enabled = True
    End Sub

    Private Sub timerNow_Tick(sender As Object, e As EventArgs) Handles timerNow.Tick
        lblTime.Text = TimeOfDay
    End Sub

    Private Sub Main_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Login.Hide()
        RegisterAccount.Hide()
        AES_Settings.Hide()
        AES_About.Hide()
        SecurityAdmin.Hide()
        LoginClearAll()
        RegistrationClearAll()
        SecurityAdmin.txtPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        SecurityAdmin.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        AES_Settings.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AES_About.Show()
    End Sub
End Class
