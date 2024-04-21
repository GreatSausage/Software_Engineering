Public Class frmReturnBooks

    Dim getBorrowID As Integer = Nothing

    Public Sub SetSelectedBorrowedBooks(borrowID As Integer, studentID As Integer, firstname As String, lastname As String, isbn As String, author As String, accessionNo As String, title As String)
        getBorrowID = borrowID
        txtStudentID.Text = studentID
        txtFirstname.Text = firstname
        txtLastname.Text = lastname
        txtISBN.Text = isbn
        txtAuthors.Text = author
        txtAcn.Text = accessionNo
        txtTitle.Text = title
    End Sub

    Private Sub frmReturnBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsBookOverdue(getBorrowID) Then
            rbOverdue.Checked = True
            MessageBox.Show("This book is overdue.")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim copyID As Integer = GetCopyIDFunction(txtAcn.Text)

        Try
            If rbGood.Checked Then
                ReturnBookInGood(getBorrowID, copyID, txtStudentID.Text)
            ElseIf rbOverdue.Checked Then
                MessageBox.Show("Before returning overdue.")
                ReturnOverdue(getBorrowID, txtPenalty.Text)
                MessageBox.Show("After returning overdue.")
            End If

            ' Close the form after processing
            getBorrowID = Nothing
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

End Class