Public Class Main
    Public bookDP As List(Of bookDisplay)
    Private newTitle_click As Integer = 0
    Private auth_click As Integer = 0
    Private pb_click As Integer = 0
    Private pub_click As Integer = 0

    Public Sub New()
        InitializeComponent()
        bookDP = New List(Of bookDisplay)


        searchTextBox.SelectionStart = 0

        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.WrapContents = False

        ' loop here
        'bookDP.Add(New bookDisplay()) 
        displayBookvb.loadBooks(bookDP)


        bookDP.Add(New bookDisplay) 'sample only
        bookDP.Add(New bookDisplay) 'sample only
        bookDP.Add(New bookDisplay) 'sample only
        bookDP.Add(New bookDisplay) 'sample only
        bookDP.Add(New bookDisplay) 'sample only


    End Sub

    Private Sub searchTextBox_mouseEnter(sender As Object, e As EventArgs) Handles searchTextBox.MouseHover, searchTextBox.Click, searchTextBox.KeyPress

        If searchTextBox.Text.Equals("Search...") Then
            searchTextBox.Text = ""
            searchTextBox.ForeColor = Color.FromArgb(0, 0, 0)
        End If


        ' sample search
        For Each book In bookDP
            book.Anchor = Anchor.Left
            book.Anchor = Anchor.Right
            FlowLayoutPanel1.Controls.Add(book)
        Next






    End Sub

    Private Sub searchTextBox_mouseLeave(sender As Object, e As EventArgs) Handles searchTextBox.MouseLeave
        If searchTextBox.Text.Equals("") Then
            searchTextBox.Text = "Search..."
            searchTextBox.ForeColor = Color.FromArgb(119, 117, 117)
        End If

    End Sub


    Private Sub newTitleBtn_Click(sender As Object, e As EventArgs) Handles newTitleBtn.Click
        newTitle_click += 1
        utils.clickAnimation(newTitleBtn, newTitle_click)
        utils.dropDownAnimationNewTitle(newTitlePanel, authBtn, pbBtn, publisherBtn)


    End Sub

    Private Sub authBtn_Click(sender As Object, e As EventArgs) Handles authBtn.Click
        auth_click += 1
        utils.clickAnimation(authBtn, auth_click)
        utils.dropDownAnimationauthBtn(authPanel, pbBtn, publisherBtn)

    End Sub

    Private Sub pbBtn_Click(sender As Object, e As EventArgs) Handles pbBtn.Click
        pb_click += 1
        utils.clickAnimation(pbBtn, pb_click)
        utils.dropDownAnimationpy(pyPanel, publisherBtn)
    End Sub

    Private Sub publisherBtn_Click(sender As Object, e As EventArgs) Handles publisherBtn.Click
        pub_click += 1
        utils.clickAnimation(publisherBtn, pub_click)
        utils.dropDownAnimationpub(pubPanel)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        newTitlePanel.Height = 127
        authBtn.Location = New Point(authBtn.Location.X, authBtn.Location.Y + 127)
        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        Timer1.Stop()
    End Sub


    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        loginBtn.ForeColor = Color.FromArgb(0, 54, 99)
        login.Show()
    End Sub
    Private Sub loginBtn_mouseLeave(sender As Object, e As EventArgs) Handles loginBtn.MouseLeave
        loginBtn.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        authPanel.Height = 127
        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pyPanel.Height = 127
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pubPanel.Height = 127
        Timer3.Stop()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
























