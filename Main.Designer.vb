<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.leftMainScreenPanel = New System.Windows.Forms.Panel()
        Me.scrollablePanel = New System.Windows.Forms.Panel()
        Me.pubPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.pyPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.authPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.newTitlePanel = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.publisherBtn = New System.Windows.Forms.Button()
        Me.pbBtn = New System.Windows.Forms.Button()
        Me.authBtn = New System.Windows.Forms.Button()
        Me.newTitleBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RadioButtonTitle = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAuthor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNewlyAdded = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPublicationDate = New System.Windows.Forms.RadioButton()
        Me.pictureBoxRectangle = New System.Windows.Forms.PictureBox()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.HtmlLabel1 = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.upperMainScreenPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.advanceSearchLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.leftMainScreenPanel.SuspendLayout()
        Me.scrollablePanel.SuspendLayout()
        Me.pubPanel.SuspendLayout()
        Me.pyPanel.SuspendLayout()
        Me.authPanel.SuspendLayout()
        Me.newTitlePanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.upperMainScreenPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftMainScreenPanel
        '
        Me.leftMainScreenPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leftMainScreenPanel.AutoScroll = True
        Me.leftMainScreenPanel.Controls.Add(Me.scrollablePanel)
        Me.leftMainScreenPanel.Location = New System.Drawing.Point(275, 316)
        Me.leftMainScreenPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.leftMainScreenPanel.Name = "leftMainScreenPanel"
        Me.leftMainScreenPanel.Size = New System.Drawing.Size(390, 442)
        Me.leftMainScreenPanel.TabIndex = 11
        '
        'scrollablePanel
        '
        Me.scrollablePanel.Controls.Add(Me.pubPanel)
        Me.scrollablePanel.Controls.Add(Me.pyPanel)
        Me.scrollablePanel.Controls.Add(Me.authPanel)
        Me.scrollablePanel.Controls.Add(Me.newTitlePanel)
        Me.scrollablePanel.Controls.Add(Me.publisherBtn)
        Me.scrollablePanel.Controls.Add(Me.pbBtn)
        Me.scrollablePanel.Controls.Add(Me.authBtn)
        Me.scrollablePanel.Controls.Add(Me.newTitleBtn)
        Me.scrollablePanel.Controls.Add(Me.PictureBox4)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonTitle)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonAuthor)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonNewlyAdded)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonPublicationDate)
        Me.scrollablePanel.Controls.Add(Me.pictureBoxRectangle)
        Me.scrollablePanel.Location = New System.Drawing.Point(4, 0)
        Me.scrollablePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.scrollablePanel.Name = "scrollablePanel"
        Me.scrollablePanel.Size = New System.Drawing.Size(331, 1094)
        Me.scrollablePanel.TabIndex = 0
        '
        'pubPanel
        '
        Me.pubPanel.Controls.Add(Me.LinkLabel10)
        Me.pubPanel.Controls.Add(Me.LinkLabel11)
        Me.pubPanel.Controls.Add(Me.LinkLabel12)
        Me.pubPanel.Location = New System.Drawing.Point(47, 469)
        Me.pubPanel.Name = "pubPanel"
        Me.pubPanel.Size = New System.Drawing.Size(254, 0)
        Me.pubPanel.TabIndex = 17
        '
        'LinkLabel10
        '
        Me.LinkLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.Location = New System.Drawing.Point(12, -44)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(85, 17)
        Me.LinkLabel10.TabIndex = 2
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "LinkLabel10"
        '
        'LinkLabel11
        '
        Me.LinkLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel11.AutoSize = True
        Me.LinkLabel11.Location = New System.Drawing.Point(12, -16)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(85, 17)
        Me.LinkLabel11.TabIndex = 1
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "LinkLabel11"
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.Location = New System.Drawing.Point(12, 11)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(85, 17)
        Me.LinkLabel12.TabIndex = 0
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "LinkLabel12"
        '
        'pyPanel
        '
        Me.pyPanel.Controls.Add(Me.LinkLabel7)
        Me.pyPanel.Controls.Add(Me.LinkLabel8)
        Me.pyPanel.Controls.Add(Me.LinkLabel9)
        Me.pyPanel.Location = New System.Drawing.Point(47, 417)
        Me.pyPanel.Name = "pyPanel"
        Me.pyPanel.Size = New System.Drawing.Size(254, 0)
        Me.pyPanel.TabIndex = 16
        '
        'LinkLabel7
        '
        Me.LinkLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Location = New System.Drawing.Point(12, -44)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel7.TabIndex = 2
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "LinkLabel7"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Location = New System.Drawing.Point(12, -16)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel8.TabIndex = 1
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "LinkLabel8"
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Location = New System.Drawing.Point(12, 11)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel9.TabIndex = 0
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "LinkLabel9"
        '
        'authPanel
        '
        Me.authPanel.Controls.Add(Me.LinkLabel4)
        Me.authPanel.Controls.Add(Me.LinkLabel5)
        Me.authPanel.Controls.Add(Me.LinkLabel6)
        Me.authPanel.Location = New System.Drawing.Point(47, 359)
        Me.authPanel.Name = "authPanel"
        Me.authPanel.Size = New System.Drawing.Size(254, 0)
        Me.authPanel.TabIndex = 15
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(12, -44)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel4.TabIndex = 2
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "LinkLabel4"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(12, -16)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel5.TabIndex = 1
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "LinkLabel5"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(12, 11)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel6.TabIndex = 0
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "LinkLabel6"
        '
        'newTitlePanel
        '
        Me.newTitlePanel.Controls.Add(Me.LinkLabel3)
        Me.newTitlePanel.Controls.Add(Me.LinkLabel2)
        Me.newTitlePanel.Controls.Add(Me.LinkLabel1)
        Me.newTitlePanel.Location = New System.Drawing.Point(47, 312)
        Me.newTitlePanel.Name = "newTitlePanel"
        Me.newTitlePanel.Size = New System.Drawing.Size(254, 0)
        Me.newTitlePanel.TabIndex = 14
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(12, -44)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel3.TabIndex = 2
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "LinkLabel3"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, -16)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel2.TabIndex = 1
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "LinkLabel2"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'publisherBtn
        '
        Me.publisherBtn.BackColor = System.Drawing.Color.White
        Me.publisherBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.publisherBtn.FlatAppearance.BorderSize = 0
        Me.publisherBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.publisherBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.publisherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.publisherBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisherBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.publisherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.publisherBtn.Location = New System.Drawing.Point(25, 417)
        Me.publisherBtn.Name = "publisherBtn"
        Me.publisherBtn.Size = New System.Drawing.Size(276, 52)
        Me.publisherBtn.TabIndex = 13
        Me.publisherBtn.Text = "Publisher"
        Me.publisherBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.publisherBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.publisherBtn.UseVisualStyleBackColor = False
        '
        'pbBtn
        '
        Me.pbBtn.BackColor = System.Drawing.Color.White
        Me.pbBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.pbBtn.FlatAppearance.BorderSize = 0
        Me.pbBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.pbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.pbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pbBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.pbBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pbBtn.Location = New System.Drawing.Point(25, 359)
        Me.pbBtn.Name = "pbBtn"
        Me.pbBtn.Size = New System.Drawing.Size(276, 52)
        Me.pbBtn.TabIndex = 13
        Me.pbBtn.Text = "Publication Year"
        Me.pbBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pbBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.pbBtn.UseVisualStyleBackColor = False
        '
        'authBtn
        '
        Me.authBtn.BackColor = System.Drawing.Color.White
        Me.authBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.authBtn.FlatAppearance.BorderSize = 0
        Me.authBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.authBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.authBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.authBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.authBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.authBtn.Location = New System.Drawing.Point(25, 304)
        Me.authBtn.Name = "authBtn"
        Me.authBtn.Size = New System.Drawing.Size(276, 52)
        Me.authBtn.TabIndex = 13
        Me.authBtn.Text = "Author"
        Me.authBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.authBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.authBtn.UseVisualStyleBackColor = False
        '
        'newTitleBtn
        '
        Me.newTitleBtn.BackColor = System.Drawing.Color.White
        Me.newTitleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.newTitleBtn.FlatAppearance.BorderSize = 0
        Me.newTitleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.newTitleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.newTitleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTitleBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTitleBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.newTitleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.newTitleBtn.Location = New System.Drawing.Point(25, 254)
        Me.newTitleBtn.Name = "newTitleBtn"
        Me.newTitleBtn.Size = New System.Drawing.Size(276, 52)
        Me.newTitleBtn.TabIndex = 13
        Me.newTitleBtn.Text = "New Titles"
        Me.newTitleBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.newTitleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.newTitleBtn.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(2, 234)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(322, 930)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'RadioButtonTitle
        '
        Me.RadioButtonTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonTitle.AutoSize = True
        Me.RadioButtonTitle.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTitle.Location = New System.Drawing.Point(25, 154)
        Me.RadioButtonTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonTitle.Name = "RadioButtonTitle"
        Me.RadioButtonTitle.Size = New System.Drawing.Size(170, 43)
        Me.RadioButtonTitle.TabIndex = 11
        Me.RadioButtonTitle.TabStop = True
        Me.RadioButtonTitle.Text = "Sort By Title"
        Me.RadioButtonTitle.UseVisualStyleBackColor = True
        '
        'RadioButtonAuthor
        '
        Me.RadioButtonAuthor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonAuthor.AutoSize = True
        Me.RadioButtonAuthor.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAuthor.Location = New System.Drawing.Point(25, 104)
        Me.RadioButtonAuthor.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonAuthor.Name = "RadioButtonAuthor"
        Me.RadioButtonAuthor.Size = New System.Drawing.Size(195, 43)
        Me.RadioButtonAuthor.TabIndex = 11
        Me.RadioButtonAuthor.TabStop = True
        Me.RadioButtonAuthor.Text = "Sort By Author"
        Me.RadioButtonAuthor.UseVisualStyleBackColor = True
        '
        'RadioButtonNewlyAdded
        '
        Me.RadioButtonNewlyAdded.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonNewlyAdded.AutoSize = True
        Me.RadioButtonNewlyAdded.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNewlyAdded.Location = New System.Drawing.Point(25, 4)
        Me.RadioButtonNewlyAdded.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonNewlyAdded.Name = "RadioButtonNewlyAdded"
        Me.RadioButtonNewlyAdded.Size = New System.Drawing.Size(261, 43)
        Me.RadioButtonNewlyAdded.TabIndex = 11
        Me.RadioButtonNewlyAdded.TabStop = True
        Me.RadioButtonNewlyAdded.Text = "Sort By Newly Added"
        Me.RadioButtonNewlyAdded.UseVisualStyleBackColor = True
        '
        'RadioButtonPublicationDate
        '
        Me.RadioButtonPublicationDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonPublicationDate.AutoSize = True
        Me.RadioButtonPublicationDate.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPublicationDate.Location = New System.Drawing.Point(25, 54)
        Me.RadioButtonPublicationDate.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonPublicationDate.Name = "RadioButtonPublicationDate"
        Me.RadioButtonPublicationDate.Size = New System.Drawing.Size(296, 43)
        Me.RadioButtonPublicationDate.TabIndex = 11
        Me.RadioButtonPublicationDate.TabStop = True
        Me.RadioButtonPublicationDate.Text = "Sort By Publication Date"
        Me.RadioButtonPublicationDate.UseVisualStyleBackColor = True
        '
        'pictureBoxRectangle
        '
        Me.pictureBoxRectangle.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxRectangle.Image = CType(resources.GetObject("pictureBoxRectangle.Image"), System.Drawing.Image)
        Me.pictureBoxRectangle.Location = New System.Drawing.Point(2, 2)
        Me.pictureBoxRectangle.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBoxRectangle.Name = "pictureBoxRectangle"
        Me.pictureBoxRectangle.Size = New System.Drawing.Size(322, 206)
        Me.pictureBoxRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxRectangle.TabIndex = 10
        Me.pictureBoxRectangle.TabStop = False
        '
        'mainPanel
        '
        Me.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainPanel.Controls.Add(Me.loginBtn)
        Me.mainPanel.Controls.Add(Me.FlowLayoutPanel1)
        Me.mainPanel.Controls.Add(Me.upperMainScreenPanel)
        Me.mainPanel.Controls.Add(Me.leftMainScreenPanel)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1441, 759)
        Me.mainPanel.TabIndex = 12
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtn.Location = New System.Drawing.Point(22, 330)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(215, 52)
        Me.loginBtn.TabIndex = 14
        Me.loginBtn.Text = "Log In"
        Me.loginBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.HtmlLabel1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(640, 1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(798, 757)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'HtmlLabel1
        '
        Me.HtmlLabel1.AutoScroll = True
        Me.HtmlLabel1.AutoScrollMinSize = New System.Drawing.Size(76, 25)
        Me.HtmlLabel1.AutoSize = False
        Me.HtmlLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlLabel1.Location = New System.Drawing.Point(3, 3)
        Me.HtmlLabel1.Name = "HtmlLabel1"
        Me.HtmlLabel1.Size = New System.Drawing.Size(75, 23)
        Me.HtmlLabel1.TabIndex = 0
        Me.HtmlLabel1.Text = "HtmlLabel1"
        '
        'upperMainScreenPanel
        '
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox3)
        Me.upperMainScreenPanel.Controls.Add(Me.advanceSearchLinkLbl)
        Me.upperMainScreenPanel.Controls.Add(Me.searchTextBox)
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox2)
        Me.upperMainScreenPanel.Controls.Add(Me.Label1)
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox1)
        Me.upperMainScreenPanel.Location = New System.Drawing.Point(3, 4)
        Me.upperMainScreenPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.upperMainScreenPanel.Name = "upperMainScreenPanel"
        Me.upperMainScreenPanel.Size = New System.Drawing.Size(630, 308)
        Me.upperMainScreenPanel.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(567, 188)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'advanceSearchLinkLbl
        '
        Me.advanceSearchLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.advanceSearchLinkLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.advanceSearchLinkLbl.BackColor = System.Drawing.Color.Transparent
        Me.advanceSearchLinkLbl.Font = New System.Drawing.Font("Sitka Subheading", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advanceSearchLinkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.advanceSearchLinkLbl.Location = New System.Drawing.Point(222, 254)
        Me.advanceSearchLinkLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.advanceSearchLinkLbl.Name = "advanceSearchLinkLbl"
        Me.advanceSearchLinkLbl.Size = New System.Drawing.Size(179, 35)
        Me.advanceSearchLinkLbl.TabIndex = 7
        Me.advanceSearchLinkLbl.TabStop = True
        Me.advanceSearchLinkLbl.Text = "Advance Search"
        '
        'searchTextBox
        '
        Me.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchTextBox.Font = New System.Drawing.Font("Maiandra GD", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchTextBox.Location = New System.Drawing.Point(35, 194)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(488, 40)
        Me.searchTextBox.TabIndex = 4
        Me.searchTextBox.Text = "Search..."
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 173)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(624, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 73)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "St. Therese School of Miarayon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-20, -5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Main
        '
        Me.AccessibleName = "Panel1_Paint"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1441, 759)
        Me.Controls.Add(Me.mainPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1457, 796)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.leftMainScreenPanel.ResumeLayout(False)
        Me.scrollablePanel.ResumeLayout(False)
        Me.scrollablePanel.PerformLayout()
        Me.pubPanel.ResumeLayout(False)
        Me.pubPanel.PerformLayout()
        Me.pyPanel.ResumeLayout(False)
        Me.pyPanel.PerformLayout()
        Me.authPanel.ResumeLayout(False)
        Me.authPanel.PerformLayout()
        Me.newTitlePanel.ResumeLayout(False)
        Me.newTitlePanel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.upperMainScreenPanel.ResumeLayout(False)
        Me.upperMainScreenPanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leftMainScreenPanel As Panel
    Friend WithEvents scrollablePanel As Panel
    Friend WithEvents RadioButtonTitle As RadioButton
    Friend WithEvents RadioButtonAuthor As RadioButton
    Friend WithEvents RadioButtonNewlyAdded As RadioButton
    Friend WithEvents RadioButtonPublicationDate As RadioButton
    Friend WithEvents pictureBoxRectangle As PictureBox
    Friend WithEvents mainPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents upperMainScreenPanel As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents advanceSearchLinkLbl As LinkLabel
    Friend WithEvents newTitleBtn As Button
    Friend WithEvents publisherBtn As Button
    Friend WithEvents pbBtn As Button
    Friend WithEvents authBtn As Button
    Friend WithEvents newTitlePanel As Panel
    Friend WithEvents HtmlLabel1 As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents loginBtn As Button
    Friend WithEvents authPanel As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents pyPanel As Panel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents pubPanel As Panel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
End Class
