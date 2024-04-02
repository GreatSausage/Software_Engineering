Imports System.Data.SqlClient
Imports Guna.UI2.WinForms.Suite
Imports System.Globalization
Imports System.Collections.ObjectModel
Imports System.Web.WebSockets

Module mdlBookInventory

    Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\Software Engineering\Software Engineering\Databases\dbLMS.mdf;Integrated Security=True"

#Region "Book Inventory"
    Public Function DisplayAlphabeticalData(tblName As String, columnName As String) As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand($"SELECT * FROM {tblName} ORDER BY {columnName}", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function DisplayShelves() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT shelfID, shelfNo FROM tblBookshelves", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function DisplayBooks() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT b.bookID, b.bookTitle, b.isbn, b.yearPublished, 
                                                a.authorName,
                                                p.publisherName, 
                                                g.genreName, g.genreID,  
                                                s.shelfNo, s.shelfID 
                                             FROM tblBooks b 
                                             INNER JOIN tblAuthors a ON b.authorID = a.authorID
                                             INNER JOIN tblPublishers p ON b.publisherID = p.publisherID
                                             INNER JOIN tblGenres g ON b.genreID = g.genreID 
                                             INNER JOIN tblBookshelves s ON b.shelfID = s.shelfID
                                             GROUP BY b.bookID, b.bookTitle, b.isbn, b.yearPublished,
                                                      a.authorName,
                                                      p.publisherName, 
                                                      g.genreName, g.genreID,  
                                                      s.shelfNo, s.shelfID", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


    Public Function AddBooks(isbn As String, title As String, authorID As Integer, publisherID As Integer, yearPublished As String, genreID As Integer, shelfID As Integer) As Integer
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedTitle As String = textInfo.ToTitleCase(title.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)

            Dim titleExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE bookTitle = @title", connection)
                checkCommand.Parameters.AddWithValue("@title", capitalizedTitle)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                titleExists = count > 0
            End Using

            If titleExists Then
                MessageBox.Show("Book title already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Dim isbnExists As Boolean = False
            Using checkCommandTwo As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE isbn = @isbn", connection)
                checkCommandTwo.Parameters.AddWithValue("@isbn", isbn)
                Dim count As Integer = Convert.ToInt32(checkCommandTwo.ExecuteScalar())
                isbnExists = count > 0
            End Using

            If isbnExists Then
                MessageBox.Show("Book ISBN already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Using command As New SqlCommand("INSERT INTO tblBooks (bookTitle, isbn, authorID, publisherID, genreID, yearPublished, shelfID) 
                                             OUTPUT INSERTED.bookID 
                                             VALUES (@title, @isbn, @authorID, @publisherID, @genreID, @yearPublished, @shelfID)", connection)
                With command.Parameters
                    .AddWithValue("@title", capitalizedTitle)
                    .AddWithValue("@isbn", isbn)
                    .AddWithValue("@authorID", authorID)
                    .AddWithValue("@publisherID", publisherID)
                    .AddWithValue("@genreID", genreID)
                    .AddWithValue("@yearPublished", yearPublished)
                    .AddWithValue("@shelfID", shelfID)
                End With
                Return Convert.ToInt32(command.ExecuteScalar())
                MessageBox.Show("Book has added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim dtBooks As DataTable = DisplayBooks()
                frmBookInventory.dgBooks.DataSource = dtBooks
            End Using
        End Using
    End Function

    Public Sub SearchAuthors(datagridview As DataGridView, search As String)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim query As String = "SELECT authorName, authorID FROM tblAuthors "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE authorName LIKE @search"
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

    Public Sub SearchPublishers(datagridview As DataGridView, search As String)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim query As String = "SELECT publisherName, publisherID FROM tblPublishers "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE publisherName LIKE @search OR publisherID LIKE @search"
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

#End Region

#Region "Copies Inventory"
    Public Function GetBookTitle(isbn As String) As String

        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT bookTitle FROM tblBooks WHERE isbn = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return reader.GetString(0)
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    Public Function GetBookID(isbn As String) As Integer
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT bookID FROM tblBooks WHERE isbn = @isbn", connection)
                command.Parameters.AddWithValue("@isbn", isbn)
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Return reader.GetInt32(0)
                    End If
                End Using
            End Using
        End Using
        Return Nothing
    End Function

    Public Function DisplaySuppliers() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT supplierName, supplierID FROM tblSuppliers WHERE type = 'Supplier'", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function DisplayDonator() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT supplierName, supplierID FROM tblSuppliers WHERE type = 'Donator'", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Function DisplayCopies() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT b.bookID, b.bookTitle, b.isbn,
                                            a.authorName,
                                            COUNT(c.copyID) AS totalCopies,
                                            SUM(CASE WHEN c.status = 'Available' THEN 1 ELSE 0 END) AS availableCopies,
                                            SUM(CASE WHEN c.status = 'Borrowed' THEN 1 ELSE 0 END) AS borrowedCopies
                                         FROM tblBooks b 
                                         INNER JOIN tblAuthors a ON b.authorID = a.authorID
                                         INNER JOIN tblPublishers p ON b.publisherID = p.publisherID
                                         LEFT JOIN tblCopies c ON b.bookID = c.bookID
                                         GROUP BY b.bookID, b.bookTitle, b.isbn, b.yearPublished,
                                                  a.authorName,
                                                  p.publisherName
                                         HAVING COUNT(c.copyID) > 0", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


    Public Function AccessionGenerator() As String
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("UPDATE tblAccessionGenerator SET AccessionSequence = AccessionSequence + 1; 
                                             SELECT AccessionSequence FROM tblAccessionGenerator", connection)
                Dim acs As Integer = CInt(command.ExecuteScalar())
                Dim formatted As String = String.Format("ACN-{0:D5}", acs)
                Return formatted
            End Using
        End Using
    End Function

    Public Sub AddCopies(accessionNo As String, bookID As Integer, supplierID As Integer, price As Decimal, acquisitionType As String)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("INSERT INTO tblCopies (accessionNo, bookID, supplierID, price, acquisitionType) 
                                             VALUES (@accessionNo, @bookID, @supplierID, @price, @acquisitionType)", connection)
                With command.Parameters
                    .AddWithValue("@accessionNo", accessionNo)
                    .AddWithValue("@bookID", bookID)
                    .AddWithValue("@supplierID", supplierID)
                    .AddWithValue("@price", price)
                    .AddWithValue("@acquisitionType", acquisitionType)
                End With
                command.ExecuteNonQuery()

                Dim dtCopies As DataTable = DisplayCopies()
                frmBookInventory.dgCopies.DataSource = dtCopies

                Dim dtBooks As DataTable = DisplayBooks()
                frmBookInventory.dgBooks.DataSource = dtBooks
            End Using
        End Using
    End Sub

    Public Sub AddInitialCopies(accessionNo As String, bookID As Integer)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("INSERT INTO tblCopies (accessionNo, bookID) 
                                             VALUES (@accessionNo, @bookID)", connection)
                With command.Parameters
                    .AddWithValue("@accessionNo", accessionNo)
                    .AddWithValue("@bookID", bookID)
                End With
                command.ExecuteNonQuery()

                Dim dtCopies As DataTable = DisplayCopies()
                frmBookInventory.dgCopies.DataSource = dtCopies

                Dim dtBooks As DataTable = DisplayBooks()
                frmBookInventory.dgBooks.DataSource = dtBooks
            End Using
        End Using
    End Sub

    Public Sub SearchSuppliers(datagridview As DataGridView, search As String)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim query As String = "SELECT supplierName, supplierID FROM tblSuppliers "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE supplierName LIKE @search"
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
#End Region
End Module

