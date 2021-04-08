<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminView
    Inherits System.Windows.Forms.Form

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
        Dim TopPanel As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminView))
        Me.TitleLogoSearchPanel = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.advanceSearchLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btn_blk = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_white = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.signOutBtn = New System.Windows.Forms.LinkLabel()
        Me.backgrounPanel = New System.Windows.Forms.Panel()
        Me.collectionsPanel = New System.Windows.Forms.Panel()
        Me.addBookPanel = New System.Windows.Forms.Panel()
        Me.recordsPanel = New System.Windows.Forms.Panel()
        Me.LeftSidePanel = New System.Windows.Forms.Panel()
        Me.recordsBtn = New System.Windows.Forms.Button()
        Me.collectionsBtn = New System.Windows.Forms.Button()
        Me.bokkAddBtn = New System.Windows.Forms.Button()
        Me.viewBookBtn = New System.Windows.Forms.Button()
        Me.viewBookPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        TopPanel = New System.Windows.Forms.Panel()
        TopPanel.SuspendLayout()
        Me.TitleLogoSearchPanel.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.backgrounPanel.SuspendLayout()
        Me.LeftSidePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        TopPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TopPanel.AutoSize = True
        TopPanel.BackColor = System.Drawing.Color.White
        TopPanel.Controls.Add(Me.TitleLogoSearchPanel)
        TopPanel.Controls.Add(Me.ShapeContainer2)
        TopPanel.Location = New System.Drawing.Point(301, 0)
        TopPanel.Margin = New System.Windows.Forms.Padding(4)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New System.Drawing.Size(1046, 197)
        TopPanel.TabIndex = 2
        '
        'TitleLogoSearchPanel
        '
        Me.TitleLogoSearchPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TitleLogoSearchPanel.BackColor = System.Drawing.Color.White
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox8)
        Me.TitleLogoSearchPanel.Controls.Add(Me.searchTextBox)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox9)
        Me.TitleLogoSearchPanel.Controls.Add(Me.Label1)
        Me.TitleLogoSearchPanel.Controls.Add(Me.advanceSearchLinkLbl)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox3)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox2)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox1)
        Me.TitleLogoSearchPanel.Location = New System.Drawing.Point(227, 24)
        Me.TitleLogoSearchPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleLogoSearchPanel.MaximumSize = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.MinimumSize = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.Name = "TitleLogoSearchPanel"
        Me.TitleLogoSearchPanel.Size = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.TabIndex = 1
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
        'advanceSearchLinkLbl
        '
        Me.advanceSearchLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.advanceSearchLinkLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.advanceSearchLinkLbl.BackColor = System.Drawing.Color.Transparent
        Me.advanceSearchLinkLbl.Font = New System.Drawing.Font("Sitka Subheading", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advanceSearchLinkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.advanceSearchLinkLbl.Location = New System.Drawing.Point(219, 128)
        Me.advanceSearchLinkLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.advanceSearchLinkLbl.Name = "advanceSearchLinkLbl"
        Me.advanceSearchLinkLbl.Size = New System.Drawing.Size(156, 32)
        Me.advanceSearchLinkLbl.TabIndex = 11
        Me.advanceSearchLinkLbl.TabStop = True
        Me.advanceSearchLinkLbl.Text = "Advance Search"
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
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.btn_blk, Me.btn_white})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1046, 197)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'btn_blk
        '
        Me.btn_blk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_blk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_blk.BorderColor = System.Drawing.Color.White
        Me.btn_blk.CornerRadius = 20
        Me.btn_blk.Location = New System.Drawing.Point(1256, 7)
        Me.btn_blk.Name = "btn_blk"
        Me.btn_blk.SelectionColor = System.Drawing.Color.White
        Me.btn_blk.Size = New System.Drawing.Size(70, 60)
        '
        'btn_white
        '
        Me.btn_white.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_white.BorderColor = System.Drawing.Color.White
        Me.btn_white.CornerRadius = 20
        Me.btn_white.Location = New System.Drawing.Point(1254, 11)
        Me.btn_white.Name = "btn_white"
        Me.btn_white.SelectionColor = System.Drawing.Color.White
        Me.btn_white.Size = New System.Drawing.Size(70, 55)
        '
        'signOutBtn
        '
        Me.signOutBtn.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.signOutBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signOutBtn.AutoSize = True
        Me.signOutBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signOutBtn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.signOutBtn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.signOutBtn.Location = New System.Drawing.Point(1715, 11)
        Me.signOutBtn.Name = "signOutBtn"
        Me.signOutBtn.Size = New System.Drawing.Size(120, 40)
        Me.signOutBtn.TabIndex = 20
        Me.signOutBtn.TabStop = True
        Me.signOutBtn.Text = "Sign Out"
        '
        'backgrounPanel
        '
        Me.backgrounPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backgrounPanel.BackColor = System.Drawing.Color.White
        Me.backgrounPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.backgrounPanel.Controls.Add(Me.collectionsPanel)
        Me.backgrounPanel.Controls.Add(Me.addBookPanel)
        Me.backgrounPanel.Controls.Add(Me.recordsPanel)
        Me.backgrounPanel.Controls.Add(Me.LeftSidePanel)
        Me.backgrounPanel.Controls.Add(Me.viewBookPanel)
        Me.backgrounPanel.Location = New System.Drawing.Point(0, 186)
        Me.backgrounPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.backgrounPanel.Name = "backgrounPanel"
        Me.backgrounPanel.Size = New System.Drawing.Size(1738, 1810)
        Me.backgrounPanel.TabIndex = 3
        '
        'collectionsPanel
        '
        Me.collectionsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.collectionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.collectionsPanel.Location = New System.Drawing.Point(318, 6)
        Me.collectionsPanel.Name = "collectionsPanel"
        Me.collectionsPanel.Size = New System.Drawing.Size(1482, 1740)
        Me.collectionsPanel.TabIndex = 3
        '
        'addBookPanel
        '
        Me.addBookPanel.BackColor = System.Drawing.Color.White
        Me.addBookPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addBookPanel.Location = New System.Drawing.Point(318, 6)
        Me.addBookPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.addBookPanel.Name = "addBookPanel"
        Me.addBookPanel.Size = New System.Drawing.Size(1473, 1740)
        Me.addBookPanel.TabIndex = 1
        '
        'recordsPanel
        '
        Me.recordsPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recordsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.recordsPanel.Location = New System.Drawing.Point(318, 6)
        Me.recordsPanel.Name = "recordsPanel"
        Me.recordsPanel.Size = New System.Drawing.Size(1669, 950)
        Me.recordsPanel.TabIndex = 0
        '
        'LeftSidePanel
        '
        Me.LeftSidePanel.BackColor = System.Drawing.Color.White
        Me.LeftSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LeftSidePanel.Controls.Add(Me.recordsBtn)
        Me.LeftSidePanel.Controls.Add(Me.collectionsBtn)
        Me.LeftSidePanel.Controls.Add(Me.bokkAddBtn)
        Me.LeftSidePanel.Controls.Add(Me.viewBookBtn)
        Me.LeftSidePanel.Location = New System.Drawing.Point(4, 6)
        Me.LeftSidePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LeftSidePanel.Name = "LeftSidePanel"
        Me.LeftSidePanel.Size = New System.Drawing.Size(306, 321)
        Me.LeftSidePanel.TabIndex = 0
        '
        'recordsBtn
        '
        Me.recordsBtn.BackColor = System.Drawing.Color.White
        Me.recordsBtn.FlatAppearance.BorderSize = 0
        Me.recordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recordsBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordsBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.recordsBtn
        Me.recordsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.recordsBtn.Location = New System.Drawing.Point(22, 147)
        Me.recordsBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.recordsBtn.Name = "recordsBtn"
        Me.recordsBtn.Size = New System.Drawing.Size(208, 58)
        Me.recordsBtn.TabIndex = 12
        Me.recordsBtn.Text = "    Records"
        Me.recordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.recordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.recordsBtn.UseVisualStyleBackColor = False
        '
        'collectionsBtn
        '
        Me.collectionsBtn.BackColor = System.Drawing.Color.White
        Me.collectionsBtn.FlatAppearance.BorderSize = 0
        Me.collectionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.collectionsBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collectionsBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.bookPng
        Me.collectionsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.collectionsBtn.Location = New System.Drawing.Point(22, 219)
        Me.collectionsBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.collectionsBtn.Name = "collectionsBtn"
        Me.collectionsBtn.Size = New System.Drawing.Size(208, 58)
        Me.collectionsBtn.TabIndex = 13
        Me.collectionsBtn.Text = "   Collections"
        Me.collectionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.collectionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.collectionsBtn.UseVisualStyleBackColor = False
        '
        'bokkAddBtn
        '
        Me.bokkAddBtn.BackColor = System.Drawing.Color.White
        Me.bokkAddBtn.FlatAppearance.BorderSize = 0
        Me.bokkAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bokkAddBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bokkAddBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.addIcon
        Me.bokkAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bokkAddBtn.Location = New System.Drawing.Point(21, 85)
        Me.bokkAddBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.bokkAddBtn.Name = "bokkAddBtn"
        Me.bokkAddBtn.Size = New System.Drawing.Size(208, 58)
        Me.bokkAddBtn.TabIndex = 9
        Me.bokkAddBtn.Text = "   Add"
        Me.bokkAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bokkAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bokkAddBtn.UseVisualStyleBackColor = False
        '
        'viewBookBtn
        '
        Me.viewBookBtn.BackColor = System.Drawing.Color.White
        Me.viewBookBtn.FlatAppearance.BorderSize = 0
        Me.viewBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewBookBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBookBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.bookPng
        Me.viewBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewBookBtn.Location = New System.Drawing.Point(22, 21)
        Me.viewBookBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.viewBookBtn.Name = "viewBookBtn"
        Me.viewBookBtn.Size = New System.Drawing.Size(208, 58)
        Me.viewBookBtn.TabIndex = 8
        Me.viewBookBtn.Text = "   View Book"
        Me.viewBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.viewBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.viewBookBtn.UseVisualStyleBackColor = False
        '
        'viewBookPanel
        '
        Me.viewBookPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewBookPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.viewBookPanel.Location = New System.Drawing.Point(318, 6)
        Me.viewBookPanel.Name = "viewBookPanel"
        Me.viewBookPanel.Size = New System.Drawing.Size(1419, 1803)
        Me.viewBookPanel.TabIndex = 2
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1910, 746)
        Me.Controls.Add(Me.signOutBtn)
        Me.Controls.Add(Me.backgrounPanel)
        Me.Controls.Add(TopPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1553, 781)
        Me.Name = "adminView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        TopPanel.ResumeLayout(False)
        Me.TitleLogoSearchPanel.ResumeLayout(False)
        Me.TitleLogoSearchPanel.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.backgrounPanel.ResumeLayout(False)
        Me.LeftSidePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backgrounPanel As Panel
    Friend WithEvents LeftSidePanel As Panel
    Friend WithEvents addBookPanel As Panel
    Friend WithEvents addPcBx As PictureBox
    Friend WithEvents cancelPcBx As PictureBox
    Friend WithEvents savePcBx As PictureBox
    Friend WithEvents viewBookBtn As Button
    Friend WithEvents bokkAddBtn As Button
    Friend WithEvents recordsBtn As Button
    Friend WithEvents collectionsBtn As Button
    Friend WithEvents viewBookPanel As Panel
    Friend WithEvents recordsPanel As Panel
    Friend WithEvents signOutBtn As LinkLabel
    Friend WithEvents TitleLogoSearchPanel As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents advanceSearchLinkLbl As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents btn_blk As PowerPacks.RectangleShape
    Friend WithEvents btn_white As PowerPacks.RectangleShape
    Friend WithEvents collectionsPanel As Panel
    Friend WithEvents Timer1 As Timer
End Class
