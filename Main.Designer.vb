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
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PageNumLabel = New System.Windows.Forms.Label()
        Me.Button_Back = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.leftMainScreenPanel = New System.Windows.Forms.Panel()
        Me.scrollablePanel = New System.Windows.Forms.Panel()
        Me.classPanel = New System.Windows.Forms.Panel()
        Me.searchClassification = New System.Windows.Forms.LinkLabel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.pbPanel = New System.Windows.Forms.Panel()
        Me.searchYear = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.afterYear = New System.Windows.Forms.ComboBox()
        Me.beforeYear = New System.Windows.Forms.ComboBox()
        Me.authPanel = New System.Windows.Forms.Panel()
        Me.searchAuth = New System.Windows.Forms.LinkLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.newTitlePanel = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.RadioButtonTitle = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAuthor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNewlyAdded = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPublicationDate = New System.Windows.Forms.RadioButton()
        Me.TitleLogoSearchPanel = New System.Windows.Forms.Panel()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.advanceSearchLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.publisherBtn = New System.Windows.Forms.Button()
        Me.pbBtn = New System.Windows.Forms.Button()
        Me.authBtn = New System.Windows.Forms.Button()
        Me.newTitleBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBoxRectangle = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.mainPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.leftMainScreenPanel.SuspendLayout()
        Me.scrollablePanel.SuspendLayout()
        Me.classPanel.SuspendLayout()
        Me.pbPanel.SuspendLayout()
        Me.authPanel.SuspendLayout()
        Me.newTitlePanel.SuspendLayout()
        Me.TitleLogoSearchPanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainPanel.Controls.Add(Me.Panel1)
        Me.mainPanel.Controls.Add(Me.TitleLogoSearchPanel)
        Me.mainPanel.Controls.Add(Me.loginBtn)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1448, 952)
        Me.mainPanel.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PageNumLabel)
        Me.Panel1.Controls.Add(Me.Button_Back)
        Me.Panel1.Controls.Add(Me.LinkLabel13)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.leftMainScreenPanel)
        Me.Panel1.Location = New System.Drawing.Point(-1, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1448, 719)
        Me.Panel1.TabIndex = 19
        '
        'PageNumLabel
        '
        Me.PageNumLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PageNumLabel.AutoSize = True
        Me.PageNumLabel.Location = New System.Drawing.Point(1094, 676)
        Me.PageNumLabel.Name = "PageNumLabel"
        Me.PageNumLabel.Size = New System.Drawing.Size(67, 25)
        Me.PageNumLabel.TabIndex = 17
        Me.PageNumLabel.Text = "Page 1"
        '
        'Button_Back
        '
        Me.Button_Back.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Button_Back.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Back.AutoSize = True
        Me.Button_Back.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Back.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Button_Back.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Button_Back.Location = New System.Drawing.Point(947, 676)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(87, 25)
        Me.Button_Back.TabIndex = 20
        Me.Button_Back.TabStop = True
        Me.Button_Back.Text = "Previous"
        '
        'LinkLabel13
        '
        Me.LinkLabel13.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.LinkLabel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel13.AutoSize = True
        Me.LinkLabel13.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel13.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel13.Location = New System.Drawing.Point(1225, 676)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(53, 25)
        Me.LinkLabel13.TabIndex = 21
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "Next"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(419, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1024, 670)
        Me.FlowLayoutPanel1.TabIndex = 18
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'leftMainScreenPanel
        '
        Me.leftMainScreenPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.leftMainScreenPanel.AutoScroll = True
        Me.leftMainScreenPanel.Controls.Add(Me.scrollablePanel)
        Me.leftMainScreenPanel.Location = New System.Drawing.Point(8, 4)
        Me.leftMainScreenPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.leftMainScreenPanel.Name = "leftMainScreenPanel"
        Me.leftMainScreenPanel.Size = New System.Drawing.Size(360, 721)
        Me.leftMainScreenPanel.TabIndex = 19
        '
        'scrollablePanel
        '
        Me.scrollablePanel.Controls.Add(Me.classPanel)
        Me.scrollablePanel.Controls.Add(Me.pbPanel)
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
        Me.scrollablePanel.Location = New System.Drawing.Point(4, 4)
        Me.scrollablePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.scrollablePanel.Name = "scrollablePanel"
        Me.scrollablePanel.Size = New System.Drawing.Size(331, 875)
        Me.scrollablePanel.TabIndex = 0
        '
        'classPanel
        '
        Me.classPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classPanel.Controls.Add(Me.searchClassification)
        Me.classPanel.Controls.Add(Me.ComboBox2)
        Me.classPanel.Location = New System.Drawing.Point(47, 469)
        Me.classPanel.Name = "classPanel"
        Me.classPanel.Size = New System.Drawing.Size(398, 0)
        Me.classPanel.TabIndex = 17
        '
        'searchClassification
        '
        Me.searchClassification.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.searchClassification.AutoSize = True
        Me.searchClassification.Font = New System.Drawing.Font("Sitka Small", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchClassification.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.searchClassification.LinkColor = System.Drawing.Color.Black
        Me.searchClassification.Location = New System.Drawing.Point(73, 76)
        Me.searchClassification.Name = "searchClassification"
        Me.searchClassification.Size = New System.Drawing.Size(97, 35)
        Me.searchClassification.TabIndex = 3
        Me.searchClassification.TabStop = True
        Me.searchClassification.Text = "Search"
        Me.searchClassification.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Generalities", "Science", "Math", "Bio"})
        Me.ComboBox2.Location = New System.Drawing.Point(3, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(246, 33)
        Me.ComboBox2.TabIndex = 0
        '
        'pbPanel
        '
        Me.pbPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPanel.Controls.Add(Me.searchYear)
        Me.pbPanel.Controls.Add(Me.Label2)
        Me.pbPanel.Controls.Add(Me.afterYear)
        Me.pbPanel.Controls.Add(Me.beforeYear)
        Me.pbPanel.Location = New System.Drawing.Point(22, 417)
        Me.pbPanel.Name = "pbPanel"
        Me.pbPanel.Size = New System.Drawing.Size(299, 0)
        Me.pbPanel.TabIndex = 16
        '
        'searchYear
        '
        Me.searchYear.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.searchYear.AutoSize = True
        Me.searchYear.Font = New System.Drawing.Font("Sitka Small", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchYear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.searchYear.LinkColor = System.Drawing.Color.Black
        Me.searchYear.Location = New System.Drawing.Point(101, 88)
        Me.searchYear.Name = "searchYear"
        Me.searchYear.Size = New System.Drawing.Size(97, 35)
        Me.searchYear.TabIndex = 2
        Me.searchYear.TabStop = True
        Me.searchYear.Text = "Search"
        Me.searchYear.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TO"
        '
        'afterYear
        '
        Me.afterYear.FormattingEnabled = True
        Me.afterYear.Location = New System.Drawing.Point(175, 42)
        Me.afterYear.Name = "afterYear"
        Me.afterYear.Size = New System.Drawing.Size(121, 33)
        Me.afterYear.TabIndex = 0
        '
        'beforeYear
        '
        Me.beforeYear.FormattingEnabled = True
        Me.beforeYear.Location = New System.Drawing.Point(0, 42)
        Me.beforeYear.Name = "beforeYear"
        Me.beforeYear.Size = New System.Drawing.Size(121, 33)
        Me.beforeYear.TabIndex = 0
        '
        'authPanel
        '
        Me.authPanel.Controls.Add(Me.searchAuth)
        Me.authPanel.Controls.Add(Me.ComboBox1)
        Me.authPanel.Location = New System.Drawing.Point(47, 359)
        Me.authPanel.Name = "authPanel"
        Me.authPanel.Size = New System.Drawing.Size(254, 0)
        Me.authPanel.TabIndex = 15
        '
        'searchAuth
        '
        Me.searchAuth.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.searchAuth.AutoSize = True
        Me.searchAuth.Font = New System.Drawing.Font("Sitka Small", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchAuth.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.searchAuth.LinkColor = System.Drawing.Color.Black
        Me.searchAuth.Location = New System.Drawing.Point(81, 82)
        Me.searchAuth.Name = "searchAuth"
        Me.searchAuth.Size = New System.Drawing.Size(97, 35)
        Me.searchAuth.TabIndex = 3
        Me.searchAuth.TabStop = True
        Me.searchAuth.Text = "Search"
        Me.searchAuth.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Lance Parantar", "Jamsed Cabili", "Danijel Carlos", "Monaxy Inson", "Philaxy Espiaers"})
        Me.ComboBox1.Location = New System.Drawing.Point(7, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(244, 37)
        Me.ComboBox1.TabIndex = 0
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
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LinkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(12, 22)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(102, 35)
        Me.LinkLabel3.TabIndex = 0
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Last Year"
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(12, -17)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(166, 35)
        Me.LinkLabel2.TabIndex = 0
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Last Six Months"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, -63)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(191, 35)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Last Three Months"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
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
        'TitleLogoSearchPanel
        '
        Me.TitleLogoSearchPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TitleLogoSearchPanel.BackColor = System.Drawing.Color.White
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox8)
        Me.TitleLogoSearchPanel.Controls.Add(Me.searchTextBox)
        Me.TitleLogoSearchPanel.Controls.Add(Me.advanceSearchLinkLbl)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox9)
        Me.TitleLogoSearchPanel.Controls.Add(Me.Label1)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox3)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox2)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox1)
        Me.TitleLogoSearchPanel.Location = New System.Drawing.Point(419, 33)
        Me.TitleLogoSearchPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleLogoSearchPanel.MaximumSize = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.MinimumSize = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.Name = "TitleLogoSearchPanel"
        Me.TitleLogoSearchPanel.Size = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.TabIndex = 18
        '
        'searchTextBox
        '
        Me.searchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchTextBox.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchTextBox.Location = New System.Drawing.Point(69, 96)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(349, 26)
        Me.searchTextBox.TabIndex = 8
        Me.searchTextBox.Text = "Search..."
        '
        'advanceSearchLinkLbl
        '
        Me.advanceSearchLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.advanceSearchLinkLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.advanceSearchLinkLbl.BackColor = System.Drawing.Color.Transparent
        Me.advanceSearchLinkLbl.Font = New System.Drawing.Font("Sitka Subheading", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advanceSearchLinkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.advanceSearchLinkLbl.Location = New System.Drawing.Point(215, 134)
        Me.advanceSearchLinkLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.advanceSearchLinkLbl.Name = "advanceSearchLinkLbl"
        Me.advanceSearchLinkLbl.Size = New System.Drawing.Size(179, 35)
        Me.advanceSearchLinkLbl.TabIndex = 7
        Me.advanceSearchLinkLbl.TabStop = True
        Me.advanceSearchLinkLbl.Text = "Advance Search"
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 74)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "St. Therese School of Miarayon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.publisherBtn.Text = "Classification"
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
        Me.authBtn.Location = New System.Drawing.Point(25, 307)
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
        Me.newTitleBtn.Location = New System.Drawing.Point(25, 260)
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
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.Image = Global.LibraryManagementSystem.My.Resources.Resources.magnifying_glass
        Me.PictureBox8.Location = New System.Drawing.Point(532, 95)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 12
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(48, 89)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(536, 48)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 6
        Me.PictureBox9.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(500, 100)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(48, 92)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(504, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.St__Therese_School_of_Miarayon_logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'loginBtn
        '
        Me.loginBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginBtn.BackColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.loginBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.log_in
        Me.loginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtn.Location = New System.Drawing.Point(1257, 11)

        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(178, 57)
        Me.loginBtn.TabIndex = 17
        Me.loginBtn.Text = "Log In"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AccessibleName = "Panel1_Paint"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1448, 952)
        Me.Controls.Add(Me.mainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1169, 645)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Management"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.leftMainScreenPanel.ResumeLayout(False)
        Me.scrollablePanel.ResumeLayout(False)
        Me.scrollablePanel.PerformLayout()
        Me.classPanel.ResumeLayout(False)
        Me.classPanel.PerformLayout()
        Me.pbPanel.ResumeLayout(False)
        Me.pbPanel.PerformLayout()
        Me.authPanel.ResumeLayout(False)
        Me.authPanel.PerformLayout()
        Me.newTitlePanel.ResumeLayout(False)
        Me.newTitlePanel.PerformLayout()
        Me.TitleLogoSearchPanel.ResumeLayout(False)
        Me.TitleLogoSearchPanel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mainPanel As Panel
    Friend WithEvents advanceSearchLinkLbl As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents loginBtn As Button
    Friend WithEvents TitleLogoSearchPanel As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PageNumLabel As Label
    Friend WithEvents Button_Back As LinkLabel
    Friend WithEvents LinkLabel13 As LinkLabel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents leftMainScreenPanel As Panel
    Friend WithEvents scrollablePanel As Panel
    Friend WithEvents classPanel As Panel
    Friend WithEvents searchClassification As LinkLabel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents pbPanel As Panel
    Friend WithEvents searchYear As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents afterYear As ComboBox
    Friend WithEvents beforeYear As ComboBox
    Friend WithEvents authPanel As Panel
    Friend WithEvents searchAuth As LinkLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents newTitlePanel As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents publisherBtn As Button
    Friend WithEvents pbBtn As Button
    Friend WithEvents authBtn As Button
    Friend WithEvents newTitleBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents RadioButtonTitle As RadioButton
    Friend WithEvents RadioButtonAuthor As RadioButton
    Friend WithEvents RadioButtonNewlyAdded As RadioButton
    Friend WithEvents RadioButtonPublicationDate As RadioButton
    Friend WithEvents pictureBoxRectangle As PictureBox
End Class
