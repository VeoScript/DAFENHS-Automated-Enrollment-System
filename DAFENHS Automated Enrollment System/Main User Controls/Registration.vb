Public Class Registration

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        RegisterTeacher1.Visible = True 
        RegisterSubject1.Visible = False
        RegisterSection1.Visible = False
    End Sub

    Private Sub btnSubject_Click(sender As Object, e As EventArgs) Handles btnSubject.Click
        RegisterTeacher1.Visible = False 
        RegisterSubject1.Visible = True
        RegisterSection1.Visible = False
    End Sub

    Private Sub btnSection_Click(sender As Object, e As EventArgs) Handles btnSection.Click
        RegisterTeacher1.Visible = False
        RegisterSubject1.Visible = False
        RegisterSection1.Visible = True
    End Sub
End Class
