Imports System.Data.SqlClient
Imports System.Web.Util
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Imports Mysqlx

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
                    Using borrowBook As New MySqlCommand("INSERT INTO tblBorrowedBooks (copyID, borrowerID, dateBorrowed, dueDate, borrowStatus) 
                                                          VALUES (@copyID, @borrowerID, @dateBorrowed, @dueDate, 'Not Returned')", connection)
                        borrowBook.Parameters.AddWithValue("@copyID", copyID)
                        borrowBook.Parameters.AddWithValue("@borrowerID", borrowerID)
                        borrowBook.Parameters.AddWithValue("@dateBorrowed", dateBorrowed)
                        borrowBook.Parameters.AddWithValue("@dueDate", dueDate)
                        borrowBook.ExecuteNonQuery()
                    End Using

                    Using updateCommand As New MySqlCommand("UPDATE tblBorrowers SET borrowLimit = borrowLimit - 1 WHERE borrowerID = @borrowerID", connection)
                        updateCommand.Parameters.AddWithValue("@borrowerID", borrowerID)
                        updateCommand.ExecuteNonQuery()
                    End Using

                    Using updateAvailability As New MySqlCommand("UPDATE tblCopies SET status = 'Borrowed' WHERE copyID = @copyID", connection)
                        updateAvailability.Parameters.AddWithValue("@copyID", copyID)
                        updateAvailability.ExecuteNonQuery()
                    End Using

                    'Using getPhoneNumber As New MySqlCommand("SELECT b.guardianContact, CONCAT(b.firstName, ' ', b.lastName) AS fullName
                    '                      FROM tblBorrowers b
                    '                      WHERE b.borrowerID = @borrowerID", connection)
                    '    getPhoneNumber.Parameters.AddWithValue("@borrowerID", borrowerID)
                    '    Dim reader As MySqlDataReader = getPhoneNumber.ExecuteReader()

                    '    If reader.Read() Then
                    '        Dim number As String = reader("guardianContact").ToString()
                    '        Dim fullName As String = reader("fullName").ToString()
                    '        SMSNotif(number, $"{fullName} has borrowed from St. Mark Academy of Primarosa, Inc.")
                    '    End If
                    'End Using

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
        Dim dueDate As DateTime = dateBorrowed.AddDays(9)
        While dueDate.DayOfWeek = DayOfWeek.Saturday OrElse dueDate.DayOfWeek = DayOfWeek.Sunday
            dueDate = dueDate.AddDays(1)
        End While
        Return dueDate
    End Function

    Public Function DisplayBorrowedBooks() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT bb.borrowID, bb.copyID, bb.borrowerID,
                                                      CONCAT(b.firstName, ' ', b.lastName) AS FullName,
                                                      b.borrowerType, b.studentID, b.firstName, b.lastName, 
                                                      bk.bookTitle, bk.ISBN, a.authorName, 
                                                      c.accessionNo, 
                                                      bb.dateBorrowed, bb.dueDate
                                               FROM tblBorrowedBooks bb
                                               INNER JOIN tblCopies c ON bb.copyID = c.copyID
                                               INNER JOIN tblBooks bk ON c.bookID = bk.bookID
                                               INNER JOIN tblAuthors a ON bk.authorID = a.authorID 
                                               INNER JOIN tblBorrowers b ON bb.borrowerID = b.borrowerID 
                                               WHERE bb.borrowStatus = 'Not Returned'", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Sub ReturnBookInGood(borrowID As Integer, copyID As Integer, studentID As String)
        Using connection As MySqlConnection = ConnectionOpen()

            Using updateCommand As New MySqlCommand("UPDATE tblBorrowers SET borrowLimit = borrowLimit + 1 WHERE studentID = @studentID", connection)
                updateCommand.Parameters.AddWithValue("@studentID", studentID)
                updateCommand.ExecuteNonQuery()
            End Using

            Using updateAvailability As New MySqlCommand("UPDATE tblCopies SET status = 'Borrowed' WHERE copyID = @copyID", connection)
                updateAvailability.Parameters.AddWithValue("@copyID", copyID)
                updateAvailability.ExecuteNonQuery()
            End Using

            Using updateBorrowStatus As New MySqlCommand("UPDATE tblBorrowedBooks SET borrowStatus = 'Returned' WHERE borrowID = @borrowID", connection)
                updateBorrowStatus.Parameters.AddWithValue("@borrowID", borrowID)
                updateBorrowStatus.ExecuteNonQuery()
            End Using

            MessageBox.Show("Book has been returned in good condition.")
            Dim dtBorrowed As DataTable = DisplayBorrowedBooks()
            frmIssueReturn.dgBorrowed.DataSource = dtBorrowed
        End Using
    End Sub


    Public Sub ReturnOverdue(borrowID As Integer, penalty As Decimal)
        MessageBox.Show("before connection open")
        Using connection As MySqlConnection = ConnectionOpen()
            MessageBox.Show("after connection open")
            Using insertCommand As New MySqlCommand("INSERT INTO tblpullout (borrowID, status, penalty) VALUES (@borrowID, @status, @penalty)", connection)
                insertCommand.Parameters.AddWithValue("@borrowID", borrowID)
                insertCommand.Parameters.AddWithValue("@status", "Not Paid/Replaced")
                insertCommand.Parameters.AddWithValue("@penalty", penalty)
                MessageBox.Show("before execute")
                insertCommand.ExecuteNonQuery()
                MessageBox.Show("after execute")
            End Using

            MessageBox.Show("Book has been added to pullout.")
        End Using
    End Sub
    Public Sub CalculateInOverdue(borrowID As Integer, textbox As Guna2TextBox)
        Dim currentDate As DateTime = DateTime.Now
        Dim dueDate As DateTime
        Dim dateBorrowed As DateTime

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using selectCommand As New MySqlCommand("SELECT dueDate, dateBorrowed FROM tblBorrowedBooks WHERE borrowID = @borrowID", connection)
                    selectCommand.Parameters.AddWithValue("@borrowID", borrowID)

                    Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                        If reader.Read() Then
                            dueDate = Convert.ToDateTime(reader("dueDate"))
                            dateBorrowed = Convert.ToDateTime(reader("dateBorrowed"))
                        End If
                    End Using
                End Using
            End Using

            Dim overDue As Integer = (currentDate - dueDate).Days

            ' Check if the book is overdue
            If overDue > 0 Then
                ' Calculate penalty based on the number of days overdue
                Dim totalPenalty As Integer = overDue * 20 ' Assuming penalty rate is $20 per day
                textbox.Text = totalPenalty.ToString()
                textbox.ReadOnly = True

                ' Optionally, handle the case where the book is considered lost
                If overDue > 7 Then
                    ' Implement logic for handling lost books
                    ' For example, mark the book as lost in the database
                End If
            Else
                textbox.Text = ""
                textbox.ReadOnly = False
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub

    Public Function IsBookOverdue(borrowID As Integer) As Boolean
        Dim currentDate As DateTime = DateTime.Now
        Dim dueDate As DateTime

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using selectCommand As New MySqlCommand("SELECT dueDate FROM tblBorrowedBooks WHERE borrowID = @borrowID", connection)
                    selectCommand.Parameters.AddWithValue("@borrowID", borrowID)

                    Dim reader As MySqlDataReader = selectCommand.ExecuteReader()

                    If reader.Read() Then
                        dueDate = Convert.ToDateTime(reader("dueDate"))
                        ' Check if the book is overdue
                        If currentDate > dueDate Then
                            Return True
                        Else
                            Return False ' The book is not overdue
                        End If
                    Else
                        MessageBox.Show("Error: No record found for the given borrowID.")
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
            Return False
        End Try
    End Function

#End Region
End Module
