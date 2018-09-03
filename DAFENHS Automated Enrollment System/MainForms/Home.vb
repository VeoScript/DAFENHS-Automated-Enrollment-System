Imports System.Data.SqlClient
Public Class Home

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim adapter As SqlDataAdapter
    Dim reader As SqlDataReader

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        DialogResult = MessageBox.Show("Are you sure you want to LOGOUT?", "Automated Enrollment System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            Main.Show()
        Else
            Return
        End If
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Login.Hide()
        RegisterAccount.Hide()
        AES_Settings.Hide()
        AES_About.Hide()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Minimized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        AES_Settings.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AES_About.Show()
    End Sub

    Private Sub timerNow_Tick(sender As Object, e As EventArgs) Handles timerNow.Tick
        lblTime.Text = TimeOfDay
        If TimeOfDay.Hour >= 5 And TimeOfDay.Hour <= 11 Then
            lblGreet.Text = "   GOOD MORNING!"
        ElseIf TimeOfDay.Hour = 12 Then
            lblGreet.Text = "       GOOD NOON!"
        ElseIf TimeOfDay.Hour >= 12 And TimeOfDay.Hour <= 17 Then
            lblGreet.Text = "GOOD AFTERNOON!"
        ElseIf TimeOfDay.Hour >= 18 Or TimeOfDay.Hour <= 4 Then
            lblGreet.Text = "   GOOD EVENING!"
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timerNow.Enabled = True
        btnHome.IsTab = True
        btnHome.selected = True 
        GuestInfoLoad() 
        If lblGuest.Text = "USER" Then
            btnRegistration.Enabled = False
            btnRegistration.Cursor = Cursors.Default
            lblMessageUser.Visible = True
        Else
            btnRegistration.Enabled = True
            lblMessageUser.Visible = False
        End If
    End Sub

    Sub GuestInfoLoad()
        con = New SqlConnection
        con.ConnectionString = MyConnection()

        Try
            con.Open()
            Dim query As String
            query = "SELECT Fullname, Position, Account_Type FROM RegisterSecurityAccount WHERE Account_Username='" & Login.txtUsername.Text & "' AND Account_Password='" & Login.txtPassword.Text & "'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader()

            If Not reader Is Nothing Then

            End If

            reader.Read()
            lblFullname.Text = reader("Fullname").ToString()
            lblPosition.Text = reader("Position").ToString()
            lblGuest.Text = reader("Account_Type").ToString()
            reader.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        HomeDesign1.Visible = True
        JuniorHighRegistration1.Visible = False
        SeniorHighRegistration1.Visible = False
        Registration1.Visible = False
        Enrollment1.Visible = False
        ClassSchedule1.Visible = False
        Search1.Visible = False
        ClassScheduleClear()
        ClearSearch()
    End Sub

    Private Sub btnJuniorHighschool_Click(sender As Object, e As EventArgs) Handles btnJuniorHighschool.Click
        HomeDesign1.Visible = False
        JuniorHighRegistration1.Visible = True
        SeniorHighRegistration1.Visible = False
        Registration1.Visible = False
        Enrollment1.Visible = False
        ClassSchedule1.Visible = False
        Search1.Visible = False
        ClassScheduleClear()
        ClearSearch()
    End Sub

    Private Sub btnSeniorHighschool_Click(sender As Object, e As EventArgs) Handles btnSeniorHighschool.Click
        HomeDesign1.Visible = False
        JuniorHighRegistration1.Visible = False
        SeniorHighRegistration1.Visible = True
        Registration1.Visible = False
        Enrollment1.Visible = False
        ClassSchedule1.Visible = False
        Search1.Visible = False
        ClassScheduleClear()
        ClearSearch()
    End Sub 

    Private Sub btnEnrollmentSection_Click(sender As Object, e As EventArgs) Handles btnEnrollmentSection.Click
        HomeDesign1.Visible = False
        JuniorHighRegistration1.Visible = False
        SeniorHighRegistration1.Visible = False
        Registration1.Visible = False
        Enrollment1.Visible = True
        ClassSchedule1.Visible = False
        Search1.Visible = False
        ClassScheduleClear()
        ClearSearch()
    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        HomeDesign1.Visible = False
        JuniorHighRegistration1.Visible = False
        SeniorHighRegistration1.Visible = False
        Registration1.Visible = True
        Enrollment1.Visible = False
        ClassSchedule1.Visible = False
        Search1.Visible = False
        ClassScheduleClear()
        ClearSearch()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        HomeDesign1.Visible = False
        JuniorHighRegistration1.Visible = False
        SeniorHighRegistration1.Visible = False
        Registration1.Visible = False
        Enrollment1.Visible = False
        ClassSchedule1.Visible = False
        Search1.Visible = True
        ClassScheduleClear()
        ClearSearch()
    End Sub

    Private Sub btnClassList_Click(sender As Object, e As EventArgs) Handles btnClassList.Click
        HomeDesign1.Visible = False
        JuniorHighRegistration1.Visible = False
        SeniorHighRegistration1.Visible = False
        Registration1.Visible = False
        Enrollment1.Visible = False
        ClassSchedule1.Visible = True
        Search1.Visible = False
        ClassScheduleClear()
        ClearSearch()
    End Sub
End Class