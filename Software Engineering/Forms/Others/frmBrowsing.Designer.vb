﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowsing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowsing))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.dgBorrowers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.borrowerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.firstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.dgBorrowers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1598, 160)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(15, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(167, 145)
        Me.Panel4.TabIndex = 2
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(167, 145)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 1
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(15, 145)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1598, 15)
        Me.Panel2.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 160)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1598, 15)
        Me.Panel5.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 175)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1598, 5)
        Me.Panel6.TabIndex = 2
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 893)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1598, 5)
        Me.Panel7.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 180)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 713)
        Me.Panel8.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(1593, 180)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 713)
        Me.Panel9.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btnSave)
        Me.Panel10.Controls.Add(Me.Panel12)
        Me.Panel10.Controls.Add(Me.Guna2TextBox2)
        Me.Panel10.Controls.Add(Me.Label4)
        Me.Panel10.Controls.Add(Me.Guna2TextBox1)
        Me.Panel10.Controls.Add(Me.Label3)
        Me.Panel10.Controls.Add(Me.txtISBN)
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Controls.Add(Me.Label1)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(5, 180)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(310, 713)
        Me.Panel10.TabIndex = 6
        '
        'dgBorrowers
        '
        Me.dgBorrowers.AllowUserToAddRows = False
        Me.dgBorrowers.AllowUserToDeleteRows = False
        Me.dgBorrowers.AllowUserToResizeColumns = False
        Me.dgBorrowers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgBorrowers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgBorrowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBorrowers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgBorrowers.ColumnHeadersHeight = 40
        Me.dgBorrowers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.borrowerID, Me.studentID, Me.firstName, Me.lastName, Me.timeIn, Me.timeOut})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBorrowers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgBorrowers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBorrowers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowers.Location = New System.Drawing.Point(315, 180)
        Me.dgBorrowers.MultiSelect = False
        Me.dgBorrowers.Name = "dgBorrowers"
        Me.dgBorrowers.ReadOnly = True
        Me.dgBorrowers.RowHeadersVisible = False
        Me.dgBorrowers.RowHeadersWidth = 51
        Me.dgBorrowers.RowTemplate.Height = 24
        Me.dgBorrowers.Size = New System.Drawing.Size(1278, 713)
        Me.dgBorrowers.TabIndex = 7
        Me.dgBorrowers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBorrowers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgBorrowers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgBorrowers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgBorrowers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgBorrowers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgBorrowers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgBorrowers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBorrowers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgBorrowers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgBorrowers.ThemeStyle.HeaderStyle.Height = 40
        Me.dgBorrowers.ThemeStyle.ReadOnly = True
        Me.dgBorrowers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBorrowers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgBorrowers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBorrowers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgBorrowers.ThemeStyle.RowsStyle.Height = 24
        Me.dgBorrowers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBorrowers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'borrowerID
        '
        Me.borrowerID.HeaderText = "Borrower ID"
        Me.borrowerID.MinimumWidth = 6
        Me.borrowerID.Name = "borrowerID"
        Me.borrowerID.ReadOnly = True
        '
        'studentID
        '
        Me.studentID.HeaderText = "Student ID"
        Me.studentID.MinimumWidth = 6
        Me.studentID.Name = "studentID"
        Me.studentID.ReadOnly = True
        '
        'firstName
        '
        Me.firstName.HeaderText = "Firstname"
        Me.firstName.MinimumWidth = 6
        Me.firstName.Name = "firstName"
        Me.firstName.ReadOnly = True
        '
        'lastName
        '
        Me.lastName.HeaderText = "Lastname"
        Me.lastName.MinimumWidth = 6
        Me.lastName.Name = "lastName"
        Me.lastName.ReadOnly = True
        '
        'timeIn
        '
        Me.timeIn.HeaderText = "Time In"
        Me.timeIn.MinimumWidth = 6
        Me.timeIn.Name = "timeIn"
        Me.timeIn.ReadOnly = True
        '
        'timeOut
        '
        Me.timeOut.HeaderText = "Time Out"
        Me.timeOut.MinimumWidth = 6
        Me.timeOut.Name = "timeOut"
        Me.timeOut.ReadOnly = True
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(305, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(5, 713)
        Me.Panel11.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 44)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Login/Logout"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 44)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Student ID:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        Me.txtISBN.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtISBN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.txtISBN.Location = New System.Drawing.Point(0, 88)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtISBN.MaxLength = 13
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtISBN.PlaceholderText = ""
        Me.txtISBN.SelectedText = ""
        Me.txtISBN.Size = New System.Drawing.Size(305, 44)
        Me.txtISBN.TabIndex = 11
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(0, 176)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.MaxLength = 13
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(305, 44)
        Me.Guna2TextBox1.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 44)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Firstname:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(0, 264)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.MaxLength = 13
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(305, 44)
        Me.Guna2TextBox2.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 44)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Lastname:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 308)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(305, 11)
        Me.Panel12.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(0, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(305, 44)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "LOGIN"
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(182, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1416, 68)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "  St. Mark Academy of Primarosa Inc."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(182, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1416, 68)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "  Library Management System"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmBrowsing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1598, 898)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgBorrowers)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBrowsing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.dgBorrowers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents dgBorrowers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents borrowerID As DataGridViewTextBoxColumn
    Friend WithEvents studentID As DataGridViewTextBoxColumn
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents timeIn As DataGridViewTextBoxColumn
    Friend WithEvents timeOut As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
