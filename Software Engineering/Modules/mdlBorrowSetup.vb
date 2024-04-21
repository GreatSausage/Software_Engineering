Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Module mdlBorrowSetup

#Region "Borrow Setup"

    Public Sub BorrowerInfo(studentID As String, firstname As Guna2TextBox, lastname As Guna2TextBox)
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT firstName, lastName FROM tblBorrowers WHERE studentID = @studentID", connection)
                command.Parameters.AddWithValue("@studentID", studentID)
                Using reader As MySqlDataReader = command.ExecuteReader()
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

    Public Sub SearchBorrowerForFinder(datagridview As DataGridView, search As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Dim query As String = "SELECT b.borrowerID, b.studentID, b.firstName, b.lastName, g.grade, s.section, b.guardianContact, b.borrowerType 
                                             FROM tblBorrowers b 
                                             LEFT JOIN tblGrade g ON b.gradeID = g.gradeID 
                                             LEFT JOIN tblSection s ON b.sectionID = s.sectionID "

            If Not String.IsNullOrEmpty(search) Then
                query += "WHERE b.studentID LIKE @search OR b.firstName LIKE @search OR b.lastName LIKE @search OR g.grade LIKE @search OR s.section LIKE @search OR b.borrowerType LIKE @search"
            End If

            Using command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    command.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Using adapter As New MySqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    datagridview.DataSource = ds.Tables(0)
                End Using

            End Using
        End Using
    End Sub

    Public Sub BorrowBookInfo(isbn As String, title As Guna2TextBox, authors As Guna2TextBox)
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT B.bookTitle, A.AuthorName 
                                             FROM tblBooks B 
                                             JOIN tblAuthors A ON A.AuthorID = B.AuthorID
                                             JOIN tblCopies C ON B.BookID = C.BookID
                                             WHERE B.ISBN = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Using reader As MySqlDataReader = command.ExecuteReader()
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

    Public Function AvailableAcn(isbn As String) As DataTable
        Dim bookID As Integer = Convert.ToInt32(GetBookIDForBorrow(isbn))
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT accessionNo FROM tblCopies WHERE status = 'Available' AND bookID = @bookID", connection)
                command.Parameters.AddWithValue("@bookID", bookID)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function GetBookIDForBorrow(isbn As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT bookID FROM tblBooks WHERE isbn = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Sub SearchBookForFinder(datagridview As DataGridView, search As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Dim query As String = "SELECT b.ISBN, b.bookTitle, a.authorName 
                                       FROM tblBooks b 
                                       JOIN tblAuthors a ON a.authorID = b.authorID "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE b.ISBN LIKE @search OR b.bookTitle LIKE @search OR a.authorName LIKE @search"
            End If

            Using command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(search) Then
                    command.Parameters.AddWithValue("@search", "%" & search & "%")
                End If

                Using adapter As New MySqlDataAdapter(command)
                    Dim ds As New DataSet
                    adapter.Fill(ds)
                    datagridview.DataSource = ds.Tables(0)
                End Using
            End Using
        End Using
    End Sub

    Public Function GetCopyIDFunction(acn As String) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT copyID FROM tblCopies WHERE accessionNo = @acn", connection)
                command.Parameters.AddWithValue("@acn", acn)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function GetBorrowLimit(borrowerID) As Integer
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT borrowLimit FROM tblBorrowers WHERE borrowerID = @borrowerID", connection)
                command.Parameters.AddWithValue("@borrowerID", borrowerID)
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Sub BorrowBooks(copyID As Integer, borrowerID As Integer)
        Dim dateBorrowed As DateTime = DateTime.Now
        Dim dueDate As DateTime = CalculateDueDate(dateBorrowed)

        Using connection As MySqlConnection = ConnectionOpen()
            Using checkLimit As New MySqlCommand("SELECT borrowLimit FROM tblBorrowers WHERE borrowerID = @borrowerID", connection)
                checkLimit.Parameters.AddWithValue("@borrowerID", borrowerID)
                Dim limit As Integer = Convert.ToInt32(checkLimit.ExecuteScalar())

                If limit > 0 Then
                    Using transact As New MySqlCommand("INSERT INTO tblTransactions (borrowerID, dateBorrowed, dueDate) 
                                                        VALUES (@borrowerID, @dateBorrowed, @dueDate); 
                                                        SELECT LAST_INSERT_ID();", connection)
                        transact.Parameters.AddWithValue("@borrowerID", borrowerID)
                        transact.Parameters.AddWithValue("@dateBorrowed", dateBorrowed)
                        transact.Parameters.AddWithValue("@dueDate", dueDate)
                        Dim transactionID As Integer = Convert.ToInt32(transact.ExecuteScalar())

                        Using borrowBook As New MySqlCommand("INSERT INTO tblBorrowedBooks (copyID, transactionID) VALUES (@copyID, @transactionID)", connection)
                            borrowBook.Parameters.AddWithValue("@copyID", copyID)
                            borrowBook.Parameters.AddWithValue("@transactionID", transactionID)
                            borrowBook.ExecuteNonQuery()
                        End Using
                    End Using

                    Using updateCommand As New MySqlCommand("UPDATE tblBorrowers SET borrowLimit = borrowLimit - 1 WHERE borrowerID = @borrowerID", connection)
                        updateCommand.Parameters.AddWithValue("@borrowerID", borrowerID)
                        updateCommand.ExecuteNonQuery()
                    End Using
                    Using updateAvailability As New MySqlCommand("UPDATE tblCopies SET status = 'Borrowed' WHERE copyID = @copyID", connection)
                        updateAvailability.Parameters.AddWithValue("@copyID", copyID)
                        updateAvailability.ExecuteNonQuery()
                    End Using

                    Using getPhoneNumber As New MySqlCommand("SELECT b.guardianContact, CONCAT(b.firstName, ' ', b.lastName) AS fullName, 
                                                                     bk.bookTitle 
                                                              FROM tblBorrowers b 
                                                              JOIN tblTransactions t ON b.borrowerID = t.borrowerID
                                                              JOIN tblBorrowedBooks bb ON t.transactionID = bb.transactionID 
                                                              JOIN tblCopies c ON bb.copyID = c.copyID
                                                              JOIN tblBooks bk ON c.bookID = bk.bookID
                                                              WHERE b.borrowerID = @borrowerID", connection)
                        getPhoneNumber.Parameters.AddWithValue("@borrowerID", borrowerID)
                        Dim reader As MySqlDataReader = getPhoneNumber.ExecuteReader()

                        If reader.Read() Then
                            Dim number As String = reader("guardianContact").ToString()
                            Dim fullName As String = reader("fullName").ToString()
                            Dim title As String = reader("bookTitle").ToString()
                            SMSNotif(number, $"{fullName} has borrowed {title} from St. Mark Academy of Primarosa, Inc.")
                        End If
                    End Using


                    MessageBox.Show("The book has been borrowed successfully.")
                    Dim dtBorrowed As DataTable = DisplayBorrowedBooks()
                    frmIssueReturn.dgBorrowed.DataSource = dtBorrowed

                    Dim dtBooks As DataTable = DisplayBooks()
                    frmBookInventory.dgCopies.DataSource = dtBooks
                Else
                    MessageBox.Show("You have reached the maximum borrowing limit. Please return borrowed books before borrowing again.")
                End If
            End Using
        End Using
    End Sub


    Private Function CalculateDueDate(dateBorrowed As DateTime) As DateTime
        Dim dueDate As DateTime = dateBorrowed.AddDays(7)
        While dueDate.DayOfWeek = DayOfWeek.Saturday OrElse dueDate.DayOfWeek = DayOfWeek.Sunday
            dueDate = dueDate.AddDays(1)
        End While
        Return dueDate
    End Function

    Public Function DisplayBorrowedBooks() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT t.transactionID, bb.borrowID, bb.copyID, t.borrowerID,
                                                      CONCAT(b.firstName, ' ', b.lastName) AS Fullname, b.borrowerType, 
                                                      bk.bookTitle,
                                                      a.authorName,
                                                      t.dateBorrowed, t.dueDate 
                                               FROM tblBorrowedBooks bb
                                               JOIN tblCopies cp ON bb.copyID = cp.copyID
                                               JOIN tblBooks bk ON cp.bookID = bk.bookID
                                               JOIN tblAuthors a ON bk.authorID = a.authorID
                                               JOIN tblTransactions t ON bb.transactionID = t.transactionID
                                               JOIN tblBorrowers b ON t.borrowerID = b.borrowerID", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
#End Region
End Module
