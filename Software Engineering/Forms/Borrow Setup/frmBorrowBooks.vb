Public Class frmBorrowBooks

    Dim getBorrowerID As Integer = Nothing

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub txtISBN_TextChanged(sender As Object, e As EventArgs) Handles txtISBN.TextChanged
        BorrowBookInfo(txtISBN.Text, txtTitle, txtAuthors)

        Dim acnDt As DataTable = AvailableAcn(txtISBN.Text)
        txtAcn.DataSource = acnDt
        txtAcn.DisplayMember = "accessionNo"
        txtAcn.ValueMember = "accessionNo"
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        BorrowerInfo(txtStudentID.Text, txtFirstname, txtLastname)
    End Sub

    Private Sub btnFindSuppliers_Click(sender As Object, e As EventArgs) Handles btnFindSuppliers.Click
        frmBookFinder.Show()
    End Sub

    Public Sub SetSelectedBooks(isbn As String, title As String, authorName As String)
        txtISBN.Text = isbn
        txtTitle.Text = title
        txtAuthors.Text = authorName
    End Sub

    Public Sub SetSelectedBorrower(borrowerID As Integer, studentID As String, firstName As String, lastName As String)
        getBorrowerID = borrowerID
        txtStudentID.Text = studentID
        txtFirstname.Text = firstName
        txtLastname.Text = lastName
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmBorrowerFinder.Show()
    End Sub



    'Private Sub txtAcn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAcn.SelectedIndexChanged
    '    Dim copyID As Integer = Convert.ToInt32(GetCopyID(txtAcn.Text))
    '    txtCopyID.Text = copyID
    'End Sub
End Class