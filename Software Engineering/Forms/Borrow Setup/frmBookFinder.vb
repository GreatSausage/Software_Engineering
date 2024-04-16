Public Class frmBookFinder
    'Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
    '    Me.Close()
    'End Sub

    'Private Sub frmBookFinder_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Dim dtBooks As DataTable = DisplayBooksForFinder()
    '    dgBooks.DataSource = dtBooks
    'End Sub

    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    '    SearchBookForFinder(dgBooks, txtSearch.Text)
    'End Sub

    'Private Sub dgBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBooks.CellContentClick
    '    If e.RowIndex >= 0 Then
    '        Dim row As DataGridViewRow = dgBooks.Rows(e.RowIndex)
    '        Dim isbn As String = row.Cells("isbn").Value.ToString
    '        Dim title As String = row.Cells("title").Value.ToString
    '        Dim authorName As String = row.Cells("author").Value.ToString

    '        Dim frmBorrowBooksInstance As frmBorrowBooks = DirectCast(Application.OpenForms("frmBorrowBooks"), frmBorrowBooks)
    '        If frmBorrowBooksInstance IsNot Nothing Then
    '            frmBorrowBooksInstance.SetSelectedBooks(isbn, title, authorName)
    '        End If
    '        Me.Close()
    '    End If
    'End Sub
End Class