<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class advanceSearch
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.titleSearch = New System.Windows.Forms.TextBox()
        Me.authorSearch = New System.Windows.Forms.TextBox()
        Me.classificationSearch = New System.Windows.Forms.TextBox()
        Me.publisherSearch = New System.Windows.Forms.TextBox()
        Me.ISBNsearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.loginBtnLoginForm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Subheading", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Advance Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Subheading", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(567, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter search terms in at least one of the fields below"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Title"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 536)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Language"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 40)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Author"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 40)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Classification"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 40)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Publisher"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 40)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "ISBN"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(295, 528)
        Me.ComboBox2.MaxDropDownItems = 4
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(493, 41)
        Me.ComboBox2.TabIndex = 4
        '
        'titleSearch
        '
        Me.titleSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.titleSearch.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleSearch.Location = New System.Drawing.Point(295, 152)
        Me.titleSearch.Name = "titleSearch"
        Me.titleSearch.Size = New System.Drawing.Size(493, 34)
        Me.titleSearch.TabIndex = 6
        '
        'authorSearch
        '
        Me.authorSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.authorSearch.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorSearch.Location = New System.Drawing.Point(295, 225)
        Me.authorSearch.Name = "authorSearch"
        Me.authorSearch.Size = New System.Drawing.Size(493, 34)
        Me.authorSearch.TabIndex = 6
        '
        'classificationSearch
        '
        Me.classificationSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.classificationSearch.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classificationSearch.Location = New System.Drawing.Point(295, 309)
        Me.classificationSearch.Name = "classificationSearch"
        Me.classificationSearch.Size = New System.Drawing.Size(493, 34)
        Me.classificationSearch.TabIndex = 6
        '
        'publisherSearch
        '
        Me.publisherSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.publisherSearch.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisherSearch.Location = New System.Drawing.Point(295, 384)
        Me.publisherSearch.Name = "publisherSearch"
        Me.publisherSearch.Size = New System.Drawing.Size(493, 34)
        Me.publisherSearch.TabIndex = 6
        '
        'ISBNsearch
        '
        Me.ISBNsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ISBNsearch.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNsearch.Location = New System.Drawing.Point(295, 463)
        Me.ISBNsearch.Name = "ISBNsearch"
        Me.ISBNsearch.Size = New System.Drawing.Size(493, 34)
        Me.ISBNsearch.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(65, 607)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 40)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Year"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_18
        Me.PictureBox7.Location = New System.Drawing.Point(228, 593)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(235, 54)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 5
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_861
        Me.PictureBox6.Location = New System.Drawing.Point(237, 522)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(608, 54)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_861
        Me.PictureBox5.Location = New System.Drawing.Point(237, 453)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(608, 54)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_861
        Me.PictureBox4.Location = New System.Drawing.Point(237, 374)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(608, 54)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_861
        Me.PictureBox3.Location = New System.Drawing.Point(237, 298)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(608, 54)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_861
        Me.PictureBox2.Location = New System.Drawing.Point(237, 216)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(608, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_861
        Me.PictureBox1.Location = New System.Drawing.Point(237, 142)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(608, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Subheading", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(483, 602)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 40)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "To"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_18
        Me.PictureBox8.Location = New System.Drawing.Point(553, 593)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(235, 54)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 5
        Me.PictureBox8.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(257, 602)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(172, 34)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(589, 602)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 34)
        Me.TextBox2.TabIndex = 7
        '
        'loginBtnLoginForm
        '
        Me.loginBtnLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginBtnLoginForm.BackColor = System.Drawing.Color.White
        Me.loginBtnLoginForm.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.loginBtnLoginForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.loginBtnLoginForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.loginBtnLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtnLoginForm.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtnLoginForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.loginBtnLoginForm.Location = New System.Drawing.Point(295, 682)
        Me.loginBtnLoginForm.Name = "loginBtnLoginForm"
        Me.loginBtnLoginForm.Size = New System.Drawing.Size(215, 52)
        Me.loginBtnLoginForm.TabIndex = 16
        Me.loginBtnLoginForm.Text = "Search"
        Me.loginBtnLoginForm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginBtnLoginForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.loginBtnLoginForm.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(524, 682)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 52)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Clear"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'advanceSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(964, 748)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.loginBtnLoginForm)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ISBNsearch)
        Me.Controls.Add(Me.publisherSearch)
        Me.Controls.Add(Me.classificationSearch)
        Me.Controls.Add(Me.authorSearch)
        Me.Controls.Add(Me.titleSearch)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "advanceSearch"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "loginForm"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents titleSearch As TextBox
    Friend WithEvents authorSearch As TextBox
    Friend WithEvents classificationSearch As TextBox
    Friend WithEvents publisherSearch As TextBox
    Friend WithEvents ISBNsearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents loginBtnLoginForm As Button
    Friend WithEvents Button1 As Button
End Class
