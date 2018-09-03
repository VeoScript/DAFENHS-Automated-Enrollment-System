Public Class Enrollment

    Private Sub btnJuniorHigh_Click(sender As Object, e As EventArgs) Handles btnJunior.Click
        line1.Visible = True
        line2.Visible = False
        EnrollmentJuniorHigh1.Visible = True
        EnrollmentSeniorHigh1.Visible = False
    End Sub

    Private Sub btnSenior_Click(sender As Object, e As EventArgs) Handles btnSenior.Click
        line1.Visible = False
        line2.Visible = True
        EnrollmentJuniorHigh1.Visible = False
        EnrollmentSeniorHigh1.Visible = True
    End Sub
End Class
