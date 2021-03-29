Public Class login
    Private Sub loginBtnLoginForm_Click(sender As Object, e As EventArgs) Handles loginBtnLoginForm.Click
        loginBtnLoginForm.ForeColor = Color.FromArgb(0, 54, 99)
    End Sub

    Private Sub loginBtnLoginForm_mouseLeave(sender As Object, e As EventArgs) Handles loginBtnLoginForm.MouseLeave
        loginBtnLoginForm.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub
End Class