Public Class viewBook
    Private Sub Location_Btn_Click(sender As Object, e As EventArgs) Handles Location_Btn.Click
        LocationPage.Location = New Point(364, 0)
        DetailsPage.Visible = False
        LocationPage.Visible = True
        MoreInfoPage.Visible = False
    End Sub

    Private Sub Btn_Details_Click(sender As Object, e As EventArgs) Handles Btn_Details.Click
        DetailsPage.Location = New Point(364, 0)
        DetailsPage.Visible = True
        LocationPage.Visible = False
        MoreInfoPage.Visible = False
    End Sub

    Private Sub MoreInformation_Btn_Click(sender As Object, e As EventArgs) Handles MoreInformation_Btn.Click
        MoreInfoPage.Location = New Point(364, 0)
        DetailsPage.Visible = False
        LocationPage.Visible = False
        MoreInfoPage.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Details_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Details.MouseLeave
        Me.Btn_Details.BackColor = Color.Transparent
    End Sub

    Private Sub Btn_Details_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Details.MouseEnter
        Me.Btn_Details.BackColor = Color.Gray
    End Sub


    Private Sub Location_Btn_MouseLeave(sender As Object, e As EventArgs) Handles Location_Btn.MouseLeave
        Me.Location_Btn.BackColor = Color.Transparent
    End Sub

    Private Sub Location_Btn_MouseEnter(sender As Object, e As EventArgs) Handles Location_Btn.MouseEnter
        Me.Location_Btn.BackColor = Color.Gray
    End Sub

    Private Sub MoreInformation_Btn_MouseLeave(sender As Object, e As EventArgs) Handles MoreInformation_Btn.MouseLeave
        Me.MoreInformation_Btn.BackColor = Color.Transparent
    End Sub

    Private Sub MoreInformation_Btn_MouseEnter(sender As Object, e As EventArgs) Handles MoreInformation_Btn.MouseEnter
        Me.MoreInformation_Btn.BackColor = Color.Gray
    End Sub

    Private Sub NumberOfBooksNO_Click(sender As Object, e As EventArgs) Handles NumberOfBooksNO.Click

    End Sub
End Class