Public Class login
    Dim username As String = "admin"
    Dim pass As String = "admin"
    Private Sub loginBtnLoginForm_Click(sender As Object, e As EventArgs) Handles loginBtnLoginForm.Click
        loginBtnLoginForm.ForeColor = Color.FromArgb(0, 54, 99)
        If userNameTxtbox.Text.Equals(username) And pass.Equals(passTxtBox.Text) Then
            adminView.Show()
            Me.Close()
            Main.Close()
        End If
    End Sub

    Private Sub loginBtnLoginForm_mouseLeave(sender As Object, e As EventArgs) Handles loginBtnLoginForm.MouseLeave
        loginBtnLoginForm.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub



    Private Sub userNameTxtbox_TextChanged(sender As Object, e As EventArgs) Handles userNameTxtbox.MouseHover, userNameTxtbox.Click, userNameTxtbox.KeyPress
            If userNameTxtbox.Text.Equals("Username") Then
                userNameTxtbox.Text = ""
                userNameTxtbox.ForeColor = Color.FromArgb(0, 0, 0)
            End If
        End Sub

    Private Sub userNameTxtbox_mouseLeave(sender As Object, e As EventArgs) Handles userNameTxtbox.MouseLeave
        If userNameTxtbox.Text.Equals("") Then
            userNameTxtbox.Text = "Username"
            userNameTxtbox.ForeColor = Color.FromArgb(119, 117, 117)
        End If
    End Sub

    Private Sub passTxtBox_TextChanged(sender As Object, e As EventArgs) Handles passTxtBox.MouseHover, passTxtBox.Click, passTxtBox.KeyPress
            If passTxtBox.Text.Equals("Password") Then
                passTxtBox.Text = ""
                passTxtBox.ForeColor = Color.FromArgb(0, 0, 0)
            End If
        End Sub

    Private Sub passTxtBox_mouseLeave(sender As Object, e As EventArgs) Handles passTxtBox.MouseLeave
        If passTxtBox.Text.Equals("") Then
            passTxtBox.Text = "Password"
            passTxtBox.ForeColor = Color.FromArgb(119, 117, 117)
        End If
    End Sub

    Private Sub userNameTxtbox_TextChanged_1(sender As Object, e As EventArgs) Handles userNameTxtbox.TextChanged

        End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userNameTxtbox.Text = "Username"
        passTxtBox.Text = "Password"
    End Sub





End Class