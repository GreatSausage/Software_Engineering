Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Module mdlBorrowSetup

    Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\Software Engineering\Software Engineering\Databases\dbLMS.mdf;Integrated Security=True"

#Region "Borrow Setup"

    Public Sub BorrowerInfo(studentID As String, firstname As Guna2TextBox, lastname As Guna2TextBox)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT firstName, lastName FROM tblBorrowers WHERE studentID = @studentID", connection)
                command.Parameters.AddWithValue("@studentID", studentID)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        firstname.Text = reader("firstName").ToString()
                        lastname.Text = reader("lastName").ToString()
                    Else
                        firstname.Text = ""
                        lastname.Text = ""
                    End If
                End Using
            End Using
        End Using
    End Sub
    Public Sub BorrowBookInfo(isbn As String, title As Guna2TextBox, authors As Guna2TextBox)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT B.bookTitle, A.AuthorName 
                                         FROM tblBooks B 
                                         JOIN tblAuthors A ON A.AuthorID = B.AuthorID
                                         JOIN tblCopies C ON B.BookID = C.BookID
                                         WHERE B.ISBN = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        title.Text = reader("bookTitle").ToString()
                        authors.Text = reader("AuthorName").ToString()
                    Else
                        title.Text = ""
                        authors.Text = ""
                    End If
                End Using
            End Using
        End Using
    End Sub

    Public Function GetBookIDForBorrow(isbn As String) As Integer
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT bookID FROM tblBooks WHERE isbn = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function AvailableAcn(isbn As String) As DataTable
        Dim bookID As Integer = Convert.ToInt32(GetBookIDForBorrow(isbn))
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT accessionNo FROM tblCopies WHERE status = 'Available' AND bookID = @bookID", connection)
                command.Parameters.AddWithValue("@bookID", bookID)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function GetCopyID(acn As String) As Integer
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT copyID FROM tblCopies WHERE accessionNo = @acn", connection)
                command.Parameters.AddWithValue("@acn", acn)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function DisplayBooksForFinder() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT b.isbn, b.bookTitle, a.authorName 
                                             FROM tblBooks b 
                                             JOIN tblAuthors a ON a.authorID = b.authorID", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Sub SearchBookForFinder(datagridview As DataGridView, search As String)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim query As String = "SELECT b.ISBN, b.bookTitle, a.authorName 
                                   FROM tblBooks b 
                                   JOIN tblAuthors a ON a.authorID = b.authorID "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE b.ISBN LIKE @search OR b.bookTitle LIKE @search OR a.authorName LIKE @search"
            End If

            Using command As New SqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    command.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Using adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    datagridview.DataSource = ds.Tables(0)
                End Using
            End Using
        End Using
    End Sub

    Public Sub SearchBorrowerForFinder(datagridview As DataGridView, search As String)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim query As String = "SELECT borrowerID, studentID, firstName, lastName 
                                   FROM tblBorrowers "

            Using command As New SqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    query += "WHERE studentID LIKE @search OR firstName LIKE @search OR lastName LIKE @search"
                End If

                Using adapter As New SqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    datagridview.DataSource = ds.Tables(0)
                End Using
            End Using
        End Using
    End Sub

    Public Function DisplayBorrowedBooks() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT bb.borrowID,
                                                    bb.copyID,
                                                    bb.borrowerID,
                                                    CONCAT(b.firstName, ' ', b.lastName) AS FullName,
                                                    bb.dateBorrowed,
                                                    bb.dueDate,
                                                    bk.bookTitle,
                                                    a.authorName 
                                             FROM tblBorrowedBooks bb 
                                             JOIN tblCopies c ON bb.copyID = c.copyID 
                                             JOIN tblBorrowers b ON bb.borrowerID = b.borrowerID 
                                             JOIN tblBooks bk ON c.bookID = bk.bookID 
                                             JOIN tblAuthors a ON bk.authorID = a.authorID", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
#End Region
End Module
