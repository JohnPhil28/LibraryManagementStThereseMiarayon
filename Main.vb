﻿Public Class Main
    Public bookDP As List(Of bookDisplay)
    Private newTitle_click As Integer = 0
    Private auth_click As Integer = 0
    Private pb_click As Integer = 0
    Private pub_click As Integer = 0

    Private PageIndex As Integer = 0
    Private BooksPerPage As Integer = 6 'number of books shown on each page

    Public Sub New()
        InitializeComponent()
        bookDP = New List(Of bookDisplay)
        searchTextBox.SelectionStart = 0
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.WrapContents = False

        ' loop here
        ' bookDP.Add(New bookDisplay)
        displayBookvb.loadBooks(bookDP)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x As Integer = 1 To 12
            Dim book As New bookDisplay
            bookDP.Add(book)
            If x <= BooksPerPage Then FlowLayoutPanel1.Controls.Add(book) 'add the first page of books when adding them to the List
        Next
    End Sub

    Private Sub Button_Back_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Button_Back.LinkClicked
        LoadPage(False) 'false indicates to go back a page
    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        LoadPage(True) 'true indicates to go forward a page
    End Sub


    Private Sub LoadPage(ByVal pgNext As Boolean)

        'make sure there is another page before adding 1 to the PageIndex
        If pgNext And (PageIndex + 1) * BooksPerPage < bookDP.Count - 1 Then
            PageIndex += 1
        ElseIf Not pgNext And PageIndex - 1 >= 0 Then 'make sure it is not on PageIndex 0 before going back a Page
            PageIndex -= 1
        Else
            Exit Sub 'exit the sub if already on Page1 or on the Last Page
        End If

        ' remove all the books from the this page
        For i As Integer = FlowLayoutPanel1.Controls.Count - 1 To 0 Step -1
            FlowLayoutPanel1.Controls.RemoveAt(i)
        Next

        'when going forward, make sure there Is 6 more books in the list. If Not then get the number of books left in the list.
        Dim endpage As Integer = Math.Min(((PageIndex * BooksPerPage) + BooksPerPage) - 1, bookDP.Count - 1)

        'add the books for the Page to the FlowLayoutPanel
        For i As Integer = (PageIndex * BooksPerPage) To endpage
            FlowLayoutPanel1.Controls.Add(bookDP(i))
        Next

        PageNumLabel.Text = "Page " & (PageIndex + 1).ToString 'set the text to the Page Number
    End Sub




    Private Sub searchTextBox_mouseEnter(sender As Object, e As EventArgs) Handles searchTextBox.MouseHover, searchTextBox.Click, searchTextBox.KeyPress
        If searchTextBox.Text.Equals("Search...") Then
            searchTextBox.Text = ""
            searchTextBox.ForeColor = Color.FromArgb(0, 0, 0)
        End If

        ' sample search
        ' For Each book In bookDP
        ' book.Anchor = Anchor.Left
        ' book.Anchor = Anchor.Right
        'FlowLayoutPanel1.Controls.Add(book)
        '  Next

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
        utils.dropDownAnimationpy(pbPanel, publisherBtn)
    End Sub

    Private Sub publisherBtn_Click(sender As Object, e As EventArgs) Handles publisherBtn.Click
        pub_click += 1
        utils.clickAnimation(publisherBtn, pub_click)
        utils.dropDownAnimationpub(pubPanel)
    End Sub



    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        loginBtn.ForeColor = Color.FromArgb(0, 54, 99)
        login.ShowDialog()
    End Sub

    Private Sub advanceSearchLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles advanceSearchLinkLbl.LinkClicked
        advanceSearch.ShowDialog()
    End Sub




    Private Sub loginBtn_mouseLeave(sender As Object, e As EventArgs) Handles loginBtn.MouseLeave
        loginBtn.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        newTitlePanel.Height = 127

        authBtn.Location = New Point(authBtn.Location.X, authBtn.Location.Y + 127)
        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)

        authPanel.Location = New Point(authBtn.Location.X, authBtn.Location.Y + 45)
        pbPanel.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 45)
        pubPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        authPanel.Height = 127

        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        pbPanel.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 45)
        pubPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pbPanel.Height = 127

        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        pubPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pubPanel.Height = 127
        Timer4.Stop()
    End Sub

  
End Class























