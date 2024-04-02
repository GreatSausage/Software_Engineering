Public Class frmBookInfo
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub frmBookInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim genresDt As DataTable = DisplayAlphabeticalData("tblGenres", "genreName")
        txtGenre.DataSource = genresDt
        txtGenre.ValueMember = "genreID"
        txtGenre.DisplayMember = "genreName"

    End Sub

    Public Sub SetSelectedBooks(bookID As Integer, isbn As String, title As String, author As String, publisher As String, yearPublished As String, genre As String, shelfNo As Integer, shelfID As Integer, genreID As Integer)
        Dim selectedValue As Integer = Convert.ToInt32(txtGenreID.Text)

        txtBookID.Text = bookID
        txtISBN.Text = isbn
        txtTitle.Text = title
        txtAuthor.Text = author
        txtPublisher.Text = publisher
        txtYearPublished.Text = yearPublished
        txtGenre.SelectedValue = selectedValue
        txtShelfNo.Text = shelfNo
        txtGenreID.Text = genreID
        txtShelfID.Text = shelfID
    End Sub

    Private Sub btnFindAuthor_Click(sender As Object, e As EventArgs) Handles btnFindAuthor.Click
        frmFindAuthor.Show()
    End Sub

    Public Sub SetSelectedBookAuthor(authorID As Integer, authorName As String)
        txtAuthor.Text = authorName
        txtAuthorID.Text = authorID
    End Sub

    Private Sub btnFindPublisher_Click(sender As Object, e As EventArgs) Handles btnFindPublisher.Click
        frmFindPublisher.Show()
    End Sub

    Public Sub SetSelectedBookPublisher(publisherID As Integer, publisherName As String)
        txtPublisherID.Text = publisherID
        txtPublisher.Text = publisherName
    End Sub

    Private Sub txtGenre_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtGenre.SelectedValueChanged
        txtGenreID.Text = txtGenre.SelectedValue.ToString
    End Sub

    Private Sub btnFindGenres_Click(sender As Object, e As EventArgs) Handles btnFindGenres.Click
        frmFindGenres.Show()
    End Sub
End Class