Imports System.Globalization

Public Class AddBook
    Private selectedBook As BookDetailsDTO
    Private classifications As List(Of ClassificationDTO)
    Private classificationNames As New List(Of String)
    Private provider As CultureInfo = CultureInfo.InvariantCulture

    Private numAuthor As Integer
    Private authors As New List(Of AuthorDTO)
    Private authorsTxt As String
    Private selectedAuthorNum As Integer
    Private imgFlName As String = ""

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'classifications = CategoryController.getCategories()
        'classifications.Sort(Function(x, y) x.id.CompareTo(y.id))
        'For Each classificationDto As ClassificationDTO In classifications
        '    classificationNames.Add(classificationDto.name)
        'Next
        'classificationCmbBx.DataSource = classificationNames
        'populate(4)
        'empty()
    End Sub

    '  EVENT HANDLERS

    ' books
    Private Sub addBookBtn_Click(sender As Object, e As EventArgs) Handles addHoverPcBx.Click

        Dim newBook As New BookDetailsDTO

        newBook.title = titleTxtBx.Text
        newBook.isbn = isbnTxtBx.Text
        ' TODO: check if isbn already exist first or check it after user typed it
        newBook.quantity = quantityTxtBx.Text
        newBook.language = languageTxtBx.Text
        newBook.summary = summaryRichTxtBx.Text
        newBook.edition = editionTxtBx.Text

        If publishedDatePicker.Checked Then
            newBook.publishedDate = publishedDatePicker.Value.ToString("yyyy-MM-dd")
        End If

        If String.Compare(publisherNameTxtBx.Text.Trim, "") <> 0 Then
            newBook.publisherName = publisherNameTxtBx.Text.Trim
        End If
        If String.Compare(publisherAddrTxtBx.Text.Trim, "") <> 0 Then
            newBook.publisherAddress = publisherAddrTxtBx.Text
        End If


        If String.Compare(copyrightNameTxtBx.Text.Trim, "") <> 0 Then
            newBook.copyrightName = copyrightNameTxtBx.Text
        End If

        If copyrightYearDTPckr.Checked Then
            newBook.copyrightYear = copyrightYearDTPckr.Value.ToString("yyyy")
        End If

        newBook.categoryId = classificationCmbBx.SelectedIndex + 1
        newBook.shelfName = shelfTxtBx.Text

        Dim hasImg As Boolean = False
        Dim ext = ""
        ' image
        If String.Compare(imgFlName, "") <> 0 Then
            hasImg = True
            Dim strt = imgFlName.LastIndexOf(".")
            ext = imgFlName.Substring(strt, imgFlName.Length - strt)
            newBook.image = "new" + ext ' TODO: set the server to set its image attrs to its id
        Else
            newBook.image = "empty"
        End If

        newBook.authors = authors
        Dim response = BookController.addNewBook(newBook)
        selectedBook = newBook

        If hasImg Then
            uploadImage(response + ext)  ' upload the image
        End If

        MessageBox.Show("Successfully added book!")
        empty()
        populate(response)
    End Sub


    Private Sub savePcBx_Click(sender As Object, e As EventArgs) Handles saveHoverPcBx.Click

        Dim attrs As New Dictionary(Of String, String)
        If String.Compare(selectedBook.title.Trim, selectedBook.title) <> 0 Then
            attrs.Add("title", selectedBook.title.Trim)
        End If
        If String.Compare(isbnTxtBx.Text.Trim, selectedBook.isbn) <> 0 Then
            attrs.Add("isbn", isbnTxtBx.Text.Trim)
        End If
        If String.Compare(quantityTxtBx.Text.Trim, selectedBook.quantity.ToString) <> 0 Then
            attrs.Add("quantity", quantityTxtBx.Text.Trim)
        End If
        If String.Compare(languageTxtBx.Text.Trim, selectedBook.language) <> 0 Then
            attrs.Add("language", languageTxtBx.Text.Trim)
        End If
        If String.Compare(summaryRichTxtBx.Text.Trim, selectedBook.summary) <> 0 Then
            attrs.Add("summary", summaryRichTxtBx.Text.Trim)
        End If
        If String.Compare(editionTxtBx.Text.Trim, selectedBook.edition.ToString) <> 0 Then
            attrs.Add("edition", editionTxtBx.Text.Trim)
        End If

        If publishedDatePicker.Checked Then
            If String.Compare(publishedDatePicker.Value.ToString("yyyy-MM-dd"), selectedBook.publishedDate) <> 0 Then
                attrs.Add("publishedDate", publishedDatePicker.Value.ToString("yyyy-MM-dd"))
            End If
        Else
            attrs.Add("publishedDate", Nothing)
        End If

        If String.Compare(publisherNameTxtBx.Text.Trim, selectedBook.publisherName) <> 0 Then
            If String.Compare(publisherNameTxtBx.Text.Trim, "") <> 0 Then
                attrs.Add("publisherName", publisherNameTxtBx.Text.Trim)
            Else
                attrs.Add("publisherName", Nothing)
            End If
        End If
        If String.Compare(publisherAddrTxtBx.Text.Trim, selectedBook.publisherAddress) <> 0 Then
            If String.Compare(publisherAddrTxtBx.Text.Trim, "") <> 0 Then
                attrs.Add("publisherAddress", publisherAddrTxtBx.Text.Trim)
            Else
                attrs.Add("publisherAddress", Nothing)
            End If
        End If
        If String.Compare(copyrightNameTxtBx.Text.Trim, selectedBook.copyrightName) <> 0 Then
            If String.Compare(copyrightNameTxtBx.Text.Trim, "") <> 0 Then
                attrs.Add("copyrightName", copyrightNameTxtBx.Text.Trim)
            Else
                attrs.Add("copyrightName", Nothing)
            End If
        End If
        If copyrightYearDTPckr.Checked Then
            If String.Compare(copyrightYearDTPckr.Value.ToString("yyyy"), selectedBook.copyrightYear) <> 0 Then
                attrs.Add("copyrightYear", copyrightYearDTPckr.Value.ToString("yyyy"))
            End If
        Else
            attrs.Add("copyrightYear", Nothing)
        End If

        If (classificationCmbBx.SelectedIndex + 1) <> selectedBook.categoryId Then
            ' TODO: check if the selected name exist
            attrs.Add("categoryId", classificationCmbBx.SelectedIndex + 1)
        End If

        If String.Compare(shelfTxtBx.Text.Trim, selectedBook.shelfName) <> 0 Then
            If String.Compare(shelfTxtBx.Text.Trim, "") <> 0 Then
                attrs.Add("shelfName", shelfTxtBx.Text.Trim)
            Else
                attrs.Add("shelfName", Nothing)
            End If
        End If

        ' check if there is changes on the authors
        Dim updateAuthor As Boolean = False
        If authors.Count <> selectedBook.authors.Count Then
            updateAuthor = True
        Else
            For Each author As AuthorDTO In authors
                If Not selectedBook.authors.Contains(author) Then
                    updateAuthor = True
                    Exit For
                End If
            Next
        End If

        ' image
        Dim uploadImg As Boolean = False
        Dim removeImg As Boolean = False
        Dim ext = ""

        If String.Compare(imgFlName, "") <> 0 Then
            uploadImg = True
            Dim strt = imgFlName.LastIndexOf(".")
            ext = imgFlName.Substring(strt, imgFlName.Length - strt)
            selectedBook.image = selectedBook.bookId.ToString + ext
            attrs.Add("image", selectedBook.image)
        Else
            If String.Compare(selectedBook.image, "empty") <> 0 Then
                removeImg = True
                attrs.Add("image", "empty")
            End If
        End If

        If attrs.Count <> 0 Then
            ' call request for update author
            BookController.updateBook(selectedBook.bookId, attrs)
        End If

        If updateAuthor Then
            ' request for update author possible on another thread
            BookController.updateAuthorOfBook(selectedBook.bookId, authors)
        End If

        If uploadImg Then
            uploadImage(selectedBook.image)  ' upload the image
        ElseIf removeImg Then
            ImageController.removeImage(selectedBook.image)
        End If
        MessageBox.Show("Successfully updated!")
        populate(selectedBook.bookId)
    End Sub

    Private Sub cancelHoverBtn_Click(sender As Object, e As EventArgs) Handles cancelHoverPcBx.Click
        Me.Close()
    End Sub


    ' authors
    Private Sub addAuthorBtn_Click(sender As Object, e As EventArgs) Handles addAuthorBtn.Click
        Dim newAuthor As New AuthorDTO
        Dim f_name = authorFNameTxtBx.Text.Trim
        Dim m_name = authorMNameTxtBx.Text.Trim
        Dim l_name = authorLNameTxtBx.Text.Trim
        Dim attrs As New Dictionary(Of String, String)

        If String.Compare(f_name, "") <> 0 Then
            attrs.Add("fName", f_name)
        End If

        If String.Compare(m_name, "") <> 0 Then
            attrs.Add("mName", m_name)
        End If

        If String.Compare(f_name, "") <> 0 Then
            attrs.Add("lName", l_name)
        End If

        Dim prevAuthor = AuthorController.findAuthorByName(attrs)

        If prevAuthor.id <> -1 Then
            newAuthor = prevAuthor
        Else
            newAuthor.id = -1
            newAuthor.f_name = f_name
            newAuthor.m_name = m_name
            newAuthor.l_name = l_name
        End If

        authors.Add(newAuthor)
        populateAuthors()
    End Sub

    Private Sub getAuthorBtn_Click(sender As Object, e As EventArgs) Handles getAuthorBtn.Click
        selectedAuthorNum = Integer.Parse(authorNumTxtBx.Text)
        If selectedAuthorNum < numAuthor And selectedAuthorNum > 0 Then
            Dim selectedAuthor As AuthorDTO = selectedBook.authors.Item(selectedAuthorNum - 1)
            authorFNameTxtBx.Text = selectedAuthor.f_name
            authorMNameTxtBx.Text = selectedAuthor.m_name
            authorLNameTxtBx.Text = selectedAuthor.l_name
            selectedAuthorLbl.Text = authorNumTxtBx.Text
        Else
            MessageBox.Show("Author Number does not exist", "Warning", MessageBoxButtons.OK)
            authorFNameTxtBx.Text = ""
            authorMNameTxtBx.Text = ""
            authorLNameTxtBx.Text = ""
            selectedAuthorLbl.Text = "None"
        End If
    End Sub

    Private Sub removeAuthorBtn_Click(sender As Object, e As EventArgs) Handles removeAuthorBtn.Click
        If selectedAuthorNum < numAuthor And selectedAuthorNum > 0 Then
            authors.RemoveAt(selectedAuthorNum - 1)
            authorFNameTxtBx.Text = ""
            authorMNameTxtBx.Text = ""
            authorLNameTxtBx.Text = ""
            numAuthor -= 1
            populateAuthors()
        End If
    End Sub

    Private Sub updateAuthorBtn_Click(sender As Object, e As EventArgs) Handles updateAuthorBtn.Click

        If selectedAuthorNum < numAuthor And selectedAuthorNum > 0 Then
            Dim selectedAuthor As AuthorDTO = selectedBook.authors.Item(selectedAuthorNum - 1)
            selectedAuthor.f_name = authorFNameTxtBx.Text
            selectedAuthor.m_name = authorMNameTxtBx.Text
            selectedAuthor.l_name = authorLNameTxtBx.Text
            populateAuthors()
        End If
    End Sub

    ' image
    Private Sub addImgBtn_click(sender As Object, e As EventArgs) Handles bkPicBx.Click
        Dim fileDialog = New OpenFileDialog()
        fileDialog.Filter = "Picture Files (*)|*.bmp;*.jpg;*.png"

        If fileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgFlName = fileDialog.FileName
            bkPicBx.Image = Image.FromFile(imgFlName)
            removeImgBtn.Visible = True
        End If
    End Sub

    Private Sub removeImgBtn_Click(sender As Object, e As EventArgs) Handles removeImgBtn.Click
        bkPicBx.Image = My.Resources.default_book
        imgFlName = ""
        removeImgBtn.Visible = False
    End Sub

    ' elements
    Private Sub panel_mouseLeave(sender As Object, e As EventArgs) Handles SidePanel1.MouseLeave, SidePanel2.MouseLeave,
        SidePanel3.MouseLeave, SidePanel4.MouseLeave, SidePanel5.MouseLeave, SidePanel6.MouseLeave
        If sender.Equals(SidePanel1) Then
            SidePanel1.BackColor = Color.White
            SidePanel1.BorderStyle = BorderStyle.None
        ElseIf sender.Equals(SidePanel2) Then
            SidePanel2.BackColor = Color.White
            SidePanel2.BorderStyle = BorderStyle.FixedSingle
        ElseIf sender.Equals(SidePanel3) Then
            SidePanel3.BackColor = Color.White
            SidePanel3.BorderStyle = BorderStyle.None
        ElseIf sender.Equals(SidePanel4) Then
            SidePanel4.BackColor = Color.White
            SidePanel4.BorderStyle = BorderStyle.None
        ElseIf sender.Equals(SidePanel5) Then
            SidePanel5.BackColor = Color.White
            SidePanel5.BorderStyle = BorderStyle.None
        ElseIf sender.Equals(SidePanel6) Then
            SidePanel6.BackColor = Color.White
            SidePanel6.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub panel_mouseHover(sender As Object,
            e As EventArgs) Handles SidePanel1.MouseHover, SideLabel1.MouseHover, SidePcBx1.MouseHover,
            SidePanel2.MouseHover, SideLabel2.MouseHover, SidePcBx2.MouseHover,
            SidePanel3.MouseHover, SideLabel3.MouseHover, SidePcBx3.MouseHover,
            SidePanel4.MouseHover, SideLabel4.MouseHover, SidePcBx4.MouseHover,
            SidePanel5.MouseHover, SideLabel5.MouseHover, SidePcBx5.MouseHover,
            SidePanel6.MouseHover, SideLabel6.MouseHover, SidePcBx6.MouseHover
        If sender.Equals(SidePanel1) Or sender.Equals(SideLabel1) Or sender.Equals(SidePcBx1) Then
            SidePanel1.BackColor = Color.LightGray
            SidePanel1.BorderStyle = BorderStyle.FixedSingle
        ElseIf sender.Equals(SidePanel2) Or sender.Equals(SideLabel2) Or sender.Equals(SidePcBx2) Then
            SidePanel2.BackColor = Color.LightGray
            SidePanel2.BorderStyle = BorderStyle.FixedSingle
        ElseIf sender.Equals(SidePanel3) Or sender.Equals(SideLabel3) Or sender.Equals(SidePcBx3) Then
            SidePanel3.BackColor = Color.LightGray
            SidePanel3.BorderStyle = BorderStyle.FixedSingle
        ElseIf sender.Equals(SidePanel4) Or sender.Equals(SideLabel4) Or sender.Equals(SidePcBx4) Then
            SidePanel4.BackColor = Color.LightGray
            SidePanel4.BorderStyle = BorderStyle.FixedSingle
        ElseIf sender.Equals(SidePanel5) Or sender.Equals(SideLabel5) Or sender.Equals(SidePcBx5) Then
            SidePanel5.BackColor = Color.LightGray
            SidePanel5.BorderStyle = BorderStyle.FixedSingle
        ElseIf sender.Equals(SidePanel6) Or sender.Equals(SideLabel6) Or sender.Equals(SidePcBx6) Then
            SidePanel6.BackColor = Color.LightGray
            SidePanel6.BorderStyle = BorderStyle.FixedSingle
        End If
    End Sub

    Private Sub cancelPcBx_Hover(sender As Object, e As EventArgs) Handles cancelPcBx.MouseHover
        cancelHoverPcBx.Visible = True
        cancelPcBx.Visible = False
    End Sub
    Private Sub cancelHoverPcBx_Hover(sender As Object, e As EventArgs) Handles cancelHoverPcBx.MouseLeave
        cancelHoverPcBx.Visible = False
        cancelPcBx.Visible = True
    End Sub

    Private Sub savePcBx_Hover(sender As Object, e As EventArgs) Handles savePcBx.MouseHover
        saveHoverPcBx.Visible = True
        savePcBx.Visible = False
    End Sub

    Private Sub saveHoverPcBx_Hover(sender As Object, e As EventArgs) Handles saveHoverPcBx.MouseLeave
        saveHoverPcBx.Visible = False
        savePcBx.Visible = True
    End Sub
    Private Sub addPcBx_Hover(sender As Object, e As EventArgs) Handles addPcBx.MouseHover
        addHoverPcBx.Visible = True
        addPcBx.Visible = False
    End Sub

    Private Sub addHoverPcBx_Hover(sender As Object, e As EventArgs) Handles addHoverPcBx.MouseLeave
        addHoverPcBx.Visible = False
        addPcBx.Visible = True
    End Sub

    ' HELPER FUNCTIONS/SUBS
    Private Sub populate(bookId As String)

        selectedBook = BookController.getBook(bookId)
        titleTxtBx.Text = selectedBook.title
        isbnTxtBx.Text = selectedBook.isbn
        quantityTxtBx.Text = selectedBook.quantity
        languageTxtBx.Text = selectedBook.language
        editionTxtBx.Text = selectedBook.edition
        'numAvailableLbl.Text = selectedBook.numAvailable

        publisherNameTxtBx.Text = selectedBook.publisherName
        publisherAddrTxtBx.Text = selectedBook.publisherAddress
        If selectedBook.publishedDate <> Nothing Then
            publishedDatePicker.Value = Date.ParseExact(selectedBook.publishedDate, "yyyy-MM-dd", provider)
        Else
            publishedDatePicker.Value = publishedDatePicker.MinDate
            publishedDatePicker.Checked = False
        End If

        classificationCmbBx.SelectedIndex = selectedBook.categoryId - 1
        copyrightNameTxtBx.Text = selectedBook.copyrightName
        If selectedBook.copyrightYear <> 0 Then
            copyrightYearDTPckr.Value = Date.ParseExact(selectedBook.copyrightYear, "yyyy", provider)

        Else
            copyrightYearDTPckr.Value = copyrightYearDTPckr.MinDate
            copyrightYearDTPckr.Checked = False
        End If

        shelfTxtBx.Text = selectedBook.shelfName
        summaryRichTxtBx.Text = selectedBook.summary

        authors = New List(Of AuthorDTO)
        For Each author As AuthorDTO In selectedBook.authors
            authors.Add(New AuthorDTO(author.id, author.f_name, author.m_name, author.l_name))
            removeAuthorBtn.Visible = True
        Next
        populateAuthors()

        If String.Compare(selectedBook.image, "empty") <> 0 Then
            ' TODO: separate thread or process
            bkPicBx.Image = getImage(selectedBook.image)
            removeImgBtn.Visible = True
            System.Diagnostics.Debug.WriteLine("tae")
        Else
            bkPicBx.Image = My.Resources.default_book
            removeImgBtn.Visible = False
            System.Diagnostics.Debug.WriteLine("tae" + " " + selectedBook.image)
        End If
        addPcBx.Visible = False
        savePcBx.Visible = True
    End Sub

    Private Sub empty()

        selectedBook = Nothing
        titleTxtBx.Text = String.Empty
        isbnTxtBx.Text = String.Empty
        quantityTxtBx.Text = String.Empty
        languageTxtBx.Text = String.Empty
        editionTxtBx.Text = String.Empty
        'numAvailableLbl.Text = selectedBook.numAvailable

        publisherNameTxtBx.Text = String.Empty
        publisherAddrTxtBx.Text = String.Empty

        publishedDatePicker.Value = Date.Now()
        publishedDatePicker.Checked = True

        classificationCmbBx.SelectedIndex = 0
        copyrightNameTxtBx.Text = String.Empty
        copyrightYearDTPckr.Value = Date.Now()
        copyrightYearDTPckr.Checked = True

        shelfTxtBx.Text = String.Empty
        summaryRichTxtBx.Text = String.Empty

        authors = New List(Of AuthorDTO)

        bkPicBx.Image = My.Resources.default_book
        removeImgBtn.Visible = False


        savePcBx.Visible = False
        addPcBx.Visible = True


        selectedBook = Nothing

        numAuthor = 0
        authorsTxt = String.Empty
        selectedAuthorNum = 0
        imgFlName = String.Empty

        populateAuthors()
    End Sub


    Private Sub populateAuthors()
        numAuthor = 1
        Dim outputNum As String = "No." + vbCrLf
        Dim outputFN As String = "FN" + vbCrLf
        Dim outputMN As String = "MN" + vbCrLf
        Dim outputLN As String = "LN" + vbCrLf

        For Each author In authors
            outputNum += numAuthor.ToString() + vbCrLf
            outputFN += author.f_name.Trim + vbCrLf
            outputMN += author.m_name.Trim + vbCrLf
            outputLN += author.l_name.Trim + vbCrLf
            numAuthor += 1
        Next
        authorsNumLbl.Text = outputNum
        authorsFNameLbl.Text = outputFN
        authorsMNameLbl.Text = outputMN
        authorsLNameLbl.Text = outputLN
        resetAuthorSelection()
    End Sub

    Private Sub resetAuthorSelection()
        authorNumTxtBx.Text = String.Empty
        authorFNameTxtBx.Text = String.Empty
        authorMNameTxtBx.Text = String.Empty
        authorLNameTxtBx.Text = String.Empty
        selectedAuthorLbl.Text = "None"
    End Sub

    Private Sub uploadImage(flNm As String)
        bkPicBx.Image.Dispose()
        Dim res As String = ImageController.uploadImage(imgFlName, flNm)
        bkPicBx.Image = Image.FromFile(imgFlName)
    End Sub

    Private Sub loadImage(flNm As String)
        Dim imgRetuned = ImageController.getImage(flNm)
        bkPicBx.Image = imgRetuned
    End Sub

End Class
