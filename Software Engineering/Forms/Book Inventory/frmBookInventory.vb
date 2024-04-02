﻿Public Class frmBookInventory
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        frmAddBooks.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmAddCopies.Show()
    End Sub

    Private Sub frmBookInventory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim booksDt As DataTable = DisplayBooks()
        dgBooks.DataSource = booksDt

        Dim copiesDt As DataTable = DisplayCopies()
        dgCopies.DataSource = copiesDt
    End Sub

    Private Sub dgBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBooks.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgBooks.Rows(e.RowIndex)
            Dim bookID As Integer = Convert.ToInt32(row.Cells("distinctBookID").Value)
            Dim isbn As String = row.Cells("distinctISBN").Value.ToString
            Dim bookTitle As String = row.Cells("distinctTitle").Value.ToString
            Dim author As String = row.Cells("distinctAuthor").Value.ToString
            Dim publisher = row.Cells("distinctPublisher").Value.ToString
            Dim yearPublished As String = row.Cells("yearPublished").Value.ToString
            Dim genre As String = row.Cells("genreName").Value.ToString
            Dim shelfNo As Integer = Convert.ToInt32(row.Cells("shelfNo").Value)
            Dim shelfID As Integer = Convert.ToInt32(row.Cells("shelfID").Value)
            Dim genreID As Integer = Convert.ToInt32(row.Cells("genreID").Value)

            Dim frmBookInfoInstance As New frmBookInfo()
            frmBookInfoInstance.SetSelectedBooks(bookID, isbn, bookTitle, author, publisher, yearPublished, genre, shelfNo, shelfID, genreID)
            frmBookInfoInstance.Show()
        End If
    End Sub
End Class