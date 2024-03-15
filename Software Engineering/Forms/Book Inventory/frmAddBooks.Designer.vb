<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBooks))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.LinkLabel()
        Me.txtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAuthor = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtPublisher = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtYearPublished = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFindAuthor = New Guna.UI2.WinForms.Guna2Button()
        Me.btnFindPublisher = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAuthorID = New System.Windows.Forms.Label()
        Me.txtPublisherID = New System.Windows.Forms.Label()
        Me.txtGenre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGenreID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ADD BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.btnClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(307, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(48, 16)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TabStop = True
        Me.btnClose.Text = "[close]"
        Me.btnClose.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'txtISBN
        '
        Me.txtISBN.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtISBN.DefaultText = ""
        Me.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtISBN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Location = New System.Drawing.Point(5, 105)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtISBN.MaxLength = 13
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtISBN.PlaceholderText = ""
        Me.txtISBN.SelectedText = ""
        Me.txtISBN.Size = New System.Drawing.Size(350, 44)
        Me.txtISBN.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ISBN:"
        '
        'txtTitle
        '
        Me.txtTitle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitle.DefaultText = ""
        Me.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(5, 177)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitle.PlaceholderText = ""
        Me.txtTitle.SelectedText = ""
        Me.txtTitle.Size = New System.Drawing.Size(350, 44)
        Me.txtTitle.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Title:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Author:"
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.Transparent
        Me.txtAuthor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAuthor.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthor.ItemHeight = 30
        Me.txtAuthor.Location = New System.Drawing.Point(5, 248)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(290, 36)
        Me.txtAuthor.TabIndex = 14
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.Transparent
        Me.txtPublisher.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPublisher.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPublisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtPublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtPublisher.ItemHeight = 30
        Me.txtPublisher.Location = New System.Drawing.Point(5, 320)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.Size = New System.Drawing.Size(290, 36)
        Me.txtPublisher.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Publisher:"
        '
        'txtYearPublished
        '
        Me.txtYearPublished.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtYearPublished.DefaultText = ""
        Me.txtYearPublished.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtYearPublished.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtYearPublished.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearPublished.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtYearPublished.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtYearPublished.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtYearPublished.Location = New System.Drawing.Point(5, 393)
        Me.txtYearPublished.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtYearPublished.MaxLength = 4
        Me.txtYearPublished.Name = "txtYearPublished"
        Me.txtYearPublished.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYearPublished.PlaceholderText = ""
        Me.txtYearPublished.SelectedText = ""
        Me.txtYearPublished.Size = New System.Drawing.Size(350, 44)
        Me.txtYearPublished.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Year Published:"
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(5, 517)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(350, 44)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "SAVE"
        '
        'btnFindAuthor
        '
        Me.btnFindAuthor.BackgroundImage = CType(resources.GetObject("btnFindAuthor.BackgroundImage"), System.Drawing.Image)
        Me.btnFindAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindAuthor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFindAuthor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFindAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFindAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFindAuthor.FillColor = System.Drawing.Color.Transparent
        Me.btnFindAuthor.FocusedColor = System.Drawing.Color.Transparent
        Me.btnFindAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFindAuthor.ForeColor = System.Drawing.Color.White
        Me.btnFindAuthor.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnFindAuthor.Location = New System.Drawing.Point(301, 248)
        Me.btnFindAuthor.Name = "btnFindAuthor"
        Me.btnFindAuthor.Size = New System.Drawing.Size(54, 44)
        Me.btnFindAuthor.TabIndex = 24
        '
        'btnFindPublisher
        '
        Me.btnFindPublisher.BackgroundImage = CType(resources.GetObject("btnFindPublisher.BackgroundImage"), System.Drawing.Image)
        Me.btnFindPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindPublisher.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFindPublisher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFindPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFindPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFindPublisher.FillColor = System.Drawing.Color.Transparent
        Me.btnFindPublisher.FocusedColor = System.Drawing.Color.Transparent
        Me.btnFindPublisher.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFindPublisher.ForeColor = System.Drawing.Color.White
        Me.btnFindPublisher.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnFindPublisher.Location = New System.Drawing.Point(301, 320)
        Me.btnFindPublisher.Name = "btnFindPublisher"
        Me.btnFindPublisher.Size = New System.Drawing.Size(54, 44)
        Me.btnFindPublisher.TabIndex = 25
        '
        'txtAuthorID
        '
        Me.txtAuthorID.AutoSize = True
        Me.txtAuthorID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorID.Location = New System.Drawing.Point(1, 61)
        Me.txtAuthorID.Name = "txtAuthorID"
        Me.txtAuthorID.Size = New System.Drawing.Size(67, 20)
        Me.txtAuthorID.TabIndex = 26
        Me.txtAuthorID.Text = "authorID"
        '
        'txtPublisherID
        '
        Me.txtPublisherID.AutoSize = True
        Me.txtPublisherID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisherID.Location = New System.Drawing.Point(74, 61)
        Me.txtPublisherID.Name = "txtPublisherID"
        Me.txtPublisherID.Size = New System.Drawing.Size(85, 20)
        Me.txtPublisherID.TabIndex = 27
        Me.txtPublisherID.Text = "publisherID"
        '
        'txtGenre
        '
        Me.txtGenre.BackColor = System.Drawing.Color.Transparent
        Me.txtGenre.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtGenre.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtGenre.ItemHeight = 30
        Me.txtGenre.Location = New System.Drawing.Point(5, 464)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(348, 36)
        Me.txtGenre.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 441)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Genre:"
        '
        'txtGenreID
        '
        Me.txtGenreID.AutoSize = True
        Me.txtGenreID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenreID.Location = New System.Drawing.Point(165, 61)
        Me.txtGenreID.Name = "txtGenreID"
        Me.txtGenreID.Size = New System.Drawing.Size(62, 20)
        Me.txtGenreID.TabIndex = 31
        Me.txtGenreID.Text = "genreID"
        '
        'frmAddBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtGenreID)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPublisherID)
        Me.Controls.Add(Me.txtAuthorID)
        Me.Controls.Add(Me.btnFindPublisher)
        Me.Controls.Add(Me.btnFindAuthor)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtYearPublished)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPublisher)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtISBN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As LinkLabel
    Friend WithEvents txtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAuthor As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtPublisher As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtYearPublished As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFindAuthor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFindPublisher As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtAuthorID As Label
    Friend WithEvents txtPublisherID As Label
    Friend WithEvents txtGenre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtGenreID As Label
End Class
