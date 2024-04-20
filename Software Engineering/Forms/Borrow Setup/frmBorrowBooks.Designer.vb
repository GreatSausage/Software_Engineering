<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrowBooks))
        Me.lblAuthors = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCopyID = New System.Windows.Forms.Label()
        Me.txtAcn = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFindSuppliers = New Guna.UI2.WinForms.Guna2Button()
        Me.txtAuthors = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAuthors
        '
        Me.lblAuthors.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblAuthors.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAuthors.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.lblAuthors.Location = New System.Drawing.Point(0, 0)
        Me.lblAuthors.Name = "lblAuthors"
        Me.lblAuthors.Size = New System.Drawing.Size(728, 50)
        Me.lblAuthors.TabIndex = 3
        Me.lblAuthors.Text = "BOOK INFORMATION                               BORROWER INFORMATION "
        Me.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.btnClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(666, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(48, 16)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TabStop = True
        Me.btnClose.Text = "[close]"
        Me.btnClose.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtCopyID)
        Me.Panel1.Controls.Add(Me.txtAcn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnFindSuppliers)
        Me.Panel1.Controls.Add(Me.txtAuthors)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Controls.Add(Me.txtISBN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 322)
        Me.Panel1.TabIndex = 5
        '
        'txtCopyID
        '
        Me.txtCopyID.AutoSize = True
        Me.txtCopyID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopyID.Location = New System.Drawing.Point(3, 10)
        Me.txtCopyID.Name = "txtCopyID"
        Me.txtCopyID.Size = New System.Drawing.Size(56, 20)
        Me.txtCopyID.TabIndex = 40
        Me.txtCopyID.Text = "copyID"
        Me.txtCopyID.Visible = False
        '
        'txtAcn
        '
        Me.txtAcn.BackColor = System.Drawing.Color.Transparent
        Me.txtAcn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAcn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtAcn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAcn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAcn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAcn.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAcn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.txtAcn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAcn.ItemHeight = 30
        Me.txtAcn.Location = New System.Drawing.Point(5, 269)
        Me.txtAcn.Name = "txtAcn"
        Me.txtAcn.Size = New System.Drawing.Size(350, 36)
        Me.txtAcn.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Accession No.:"
        '
        'btnFindSuppliers
        '
        Me.btnFindSuppliers.BackgroundImage = CType(resources.GetObject("btnFindSuppliers.BackgroundImage"), System.Drawing.Image)
        Me.btnFindSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindSuppliers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFindSuppliers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFindSuppliers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFindSuppliers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFindSuppliers.FillColor = System.Drawing.Color.Transparent
        Me.btnFindSuppliers.FocusedColor = System.Drawing.Color.Transparent
        Me.btnFindSuppliers.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFindSuppliers.ForeColor = System.Drawing.Color.White
        Me.btnFindSuppliers.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.btnFindSuppliers.Location = New System.Drawing.Point(301, 126)
        Me.btnFindSuppliers.Name = "btnFindSuppliers"
        Me.btnFindSuppliers.Size = New System.Drawing.Size(54, 44)
        Me.btnFindSuppliers.TabIndex = 29
        '
        'txtAuthors
        '
        Me.txtAuthors.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthors.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAuthors.DefaultText = ""
        Me.txtAuthors.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAuthors.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAuthors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthors.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthors.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthors.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAuthors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthors.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtAuthors.Location = New System.Drawing.Point(5, 198)
        Me.txtAuthors.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAuthors.Name = "txtAuthors"
        Me.txtAuthors.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAuthors.PlaceholderText = ""
        Me.txtAuthors.SelectedText = ""
        Me.txtAuthors.Size = New System.Drawing.Size(350, 44)
        Me.txtAuthors.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Author:"
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
        Me.txtTitle.Location = New System.Drawing.Point(5, 126)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTitle.PlaceholderText = ""
        Me.txtTitle.SelectedText = ""
        Me.txtTitle.Size = New System.Drawing.Size(290, 44)
        Me.txtTitle.TabIndex = 10
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
        Me.txtISBN.Location = New System.Drawing.Point(5, 54)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtISBN.PlaceholderText = ""
        Me.txtISBN.SelectedText = ""
        Me.txtISBN.Size = New System.Drawing.Size(350, 44)
        Me.txtISBN.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ISBN:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2Button1)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.txtLastname)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtFirstname)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtStudentID)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(363, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 322)
        Me.Panel2.TabIndex = 6
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackgroundImage = CType(resources.GetObject("Guna2Button1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Location = New System.Drawing.Point(306, 55)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(54, 44)
        Me.Guna2Button1.TabIndex = 38
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
        Me.btnSave.Location = New System.Drawing.Point(10, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(350, 44)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "SAVE"
        '
        'txtLastname
        '
        Me.txtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.DefaultText = ""
        Me.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtLastname.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(10, 200)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.PlaceholderText = ""
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.Size = New System.Drawing.Size(350, 44)
        Me.txtLastname.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Lastname:"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.DefaultText = ""
        Me.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtFirstname.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(10, 128)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderText = ""
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.Size = New System.Drawing.Size(350, 44)
        Me.txtFirstname.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Firstname:"
        '
        'txtStudentID
        '
        Me.txtStudentID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentID.DefaultText = ""
        Me.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtStudentID.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtStudentID.Location = New System.Drawing.Point(10, 55)
        Me.txtStudentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentID.PlaceholderText = ""
        Me.txtStudentID.SelectedText = ""
        Me.txtStudentID.Size = New System.Drawing.Size(290, 44)
        Me.txtStudentID.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Student ID:"
        '
        'frmBorrowBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAuthors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBorrowBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAuthors As Label
    Friend WithEvents btnClose As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAuthors As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFindSuppliers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAcn As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCopyID As Label
End Class
