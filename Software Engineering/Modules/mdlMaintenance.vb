Imports System.Data.SqlClient
Imports System.Globalization

Module mdlMaintenance

    Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\Software Engineering\Software Engineering\Databases\dbLMS.mdf;Integrated Security=True"

    Public Function DisplayData(tableName As String) As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand($"SELECT * FROM {tableName}", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function


#Region "User Maintenance"
    Public Function DisplayUsers() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT u.userID, u.firstName, u.lastName, u.phoneNumber, 
                                                    r.roleName 
                                             FROM tblUsers u 
                                             JOIN tblRoles r 
                                             ON r.roleID = u.roleID", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using

            End Using
        End Using
    End Function

    Public Function DisplayRoles() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT roleID, roleName FROM tblRoles WHERE roleID IN(2,3)", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

    Public Sub AddUser(firstName As String, lastName As String, phoneNumber As String, userName As String, password As String, answer As String, question As String, roleID As Integer, roleName As String)

        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedFirstName As String = textInfo.ToTitleCase(firstName.ToLower())
        Dim capitalizedLastName As String = textInfo.ToTitleCase(lastName.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim userExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblUsers WHERE userName = @userName", connection)
                checkCommand.Parameters.AddWithValue("@userName", userName)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                userExists = count > 0
            End Using

            If userExists Then
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim nameExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblUsers WHERE (firstName = @firstName AND lastName = @lastName)", connection)
                checkCommand.Parameters.AddWithValue("@firstName", firstName)
                checkCommand.Parameters.AddWithValue("@lastName", lastName)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                nameExists = count > 0
            End Using

            If nameExists Then
                MessageBox.Show("User with the same first name or last name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblUsers(firstName, lastName, phoneNumber, userName, password, securityAnswer, securityQuestion, roleID) 
                                         VALUES (@firstName, @lastName, @phoneNumber, @userName, @password, @answer, @question, @roleID)", connection)

                With command.Parameters
                    .AddWithValue("@firstName", capitalizedFirstName)
                    .AddWithValue("@lastName", capitalizedLastName)
                    .AddWithValue("@phoneNumber", phoneNumber)
                    .AddWithValue("@userName", userName)
                    .AddWithValue("@password", password)
                    .AddWithValue("@answer", answer)
                    .AddWithValue("@question", question)
                    .AddWithValue("@roleID", roleID)
                End With
                command.ExecuteNonQuery()
                MessageBox.Show($"{capitalizedFirstName} {capitalizedLastName} added as {roleName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmAddUsers.Close()
            End Using
        End Using
    End Sub
#End Region

#Region "Suppliers"

    Public Sub SupplierDatatable()
        Dim dtSupplier As DataTable = DisplayData("tblSuppliers")
        frmMaintenance.dgSuppliers.DataSource = dtSupplier
    End Sub

    'ADD SUPPLIERS
    Public Sub AddSuppliers(supplierName As String, contactNumber As String, address As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedsupplierName As String = textInfo.ToTitleCase(supplierName.ToLower())
        Dim capitalizedAddress As String = textInfo.ToTitleCase(address.ToLower)

        Using connection As SqlConnection = ConnectionOpen(connString)

            Dim supplierExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblSuppliers WHERE supplierName = @supplierName", connection)
                checkCommand.Parameters.AddWithValue("@supplierName", capitalizedsupplierName)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                supplierExists = count > 0
            End Using

            If supplierExists Then
                MessageBox.Show("Supplier already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblSuppliers (supplierName, contactNumber, address) 
                                             VALUES (@supplierName, @contactNumber, @address)", connection)
                With command.Parameters
                    .AddWithValue("@supplierName", capitalizedsupplierName)
                    .AddWithValue("@contactNumber", contactNumber)
                    .AddWithValue("@address", capitalizedAddress)
                End With
                command.ExecuteNonQuery()
                MessageBox.Show("Supplier added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim dtSupplier As DataTable = DisplayData("tblSuppliers")
                frmMaintenance.dgSuppliers.DataSource = dtSupplier
            End Using
        End Using
    End Sub

    'UPDATE SUPPLIERS
    Public Sub UpdateSuppliers(supplierID As Integer, supplierName As String, contact As String, address As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedSupplier As String = textInfo.ToTitleCase(supplierName.ToLower)

        Using connection As SqlConnection = ConnectionOpen(connString)

            Using command As New SqlCommand("UPDATE tblSuppliers SET supplierName = @supplierName,
                                                                     contactNumber = @contactNo, 
                                                                     address = @address 
                                             WHERE supplierID = @supplierID", connection)
                command.Parameters.AddWithValue("@supplierID", supplierID)
                command.Parameters.AddWithValue("@supplierName", capitalizedSupplier)
                command.Parameters.AddWithValue("@contactNo", contact)
                command.Parameters.AddWithValue("@address", address)

                command.ExecuteNonQuery()
                MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                SupplierDatatable()
            End Using

        End Using

    End Sub

    Public Sub DeleteSuppliers(supplierID As Integer)
        Using connection As SqlConnection = ConnectionOpen(connString)

            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblCopies WHERE supplierID = @supplierID", connection)
                checkCommand.Parameters.AddWithValue("@supplierID", supplierID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Supplier cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New SqlCommand("DELETE FROM tblSuppliers WHERE supplierID = @supplierID", connection)
                        command.Parameters.AddWithValue("@supplierID", supplierID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Supplier has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        SupplierDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub

#End Region

#Region "Authors"

    Public Sub AuthorDatatable()
        Dim dtAuthors As DataTable = DisplayData("tblAuthors")
        frmMaintenance.dgAuthors.DataSource = dtAuthors
    End Sub

    'ADD AUTHORS
    Public Sub AddAuthors(authorName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedAuthors As String = textInfo.ToTitleCase(authorName.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)

            Dim authorExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblAuthors WHERE authorName = @authorName", connection)
                checkCommand.Parameters.AddWithValue("@authorName", capitalizedAuthors)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                authorExists = count > 0
            End Using

            If authorExists Then
                MessageBox.Show("Author already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblAuthors(authorName) VALUES (@authorName)", connection)
                command.Parameters.AddWithValue("@authorName", capitalizedAuthors)
                command.ExecuteNonQuery()
                MessageBox.Show("Author/s added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                AuthorDatatable()
            End Using
        End Using
    End Sub

    'UPDATE AUTHORS
    Public Sub UpdateAuthors(authorID As Integer, authorName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedAuthors As String = textInfo.ToTitleCase(authorName.ToLower)

        Using connection As SqlConnection = ConnectionOpen(connString)

            Using command As New SqlCommand("UPDATE tblAuthors SET authorName = @authorName WHERE authorID = @authorID", connection)
                command.Parameters.AddWithValue("@authorID", authorID)
                command.Parameters.AddWithValue("@authorName", capitalizedAuthors)
                command.ExecuteNonQuery()
                MessageBox.Show("Author updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                AuthorDatatable()
            End Using

        End Using

    End Sub

    'DELETE AUTHORS
    Public Sub DeleteAuthors(authorID As Integer)
        Using connection As SqlConnection = ConnectionOpen(connString)

            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE authorID = @authorID", connection)
                checkCommand.Parameters.AddWithValue("@authorID", authorID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Author cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New SqlCommand("DELETE FROM tblAuthors WHERE authorID = @authorID", connection)
                        command.Parameters.AddWithValue("@authorID", authorID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Author has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        AuthorDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub

#End Region

#Region "Publishers"
    Public Sub PublisherDatatable()
        Dim dtPublisher As DataTable = DisplayData("tblPublishers")
        frmMaintenance.dgPublishers.DataSource = dtPublisher
    End Sub

    Public Sub AddPublishers(publisherName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedPublisher As String = textInfo.ToTitleCase(publisherName.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)

            Dim publisherExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblPublishers WHERE publisherName = @publisherName", connection)
                checkCommand.Parameters.AddWithValue("@publisherName", capitalizedPublisher)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                publisherExists = count > 0
            End Using

            If publisherExists Then
                MessageBox.Show("Publisher already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblPublishers(publisherName) VALUES(@publisherName)", connection)
                command.Parameters.AddWithValue("@publisherName", capitalizedPublisher)
                command.ExecuteNonQuery()
                MessageBox.Show("Publisher/s added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                PublisherDatatable()
            End Using
        End Using
    End Sub

    Public Sub UpdatePublisher(publisherID As Integer, PublisherName As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedPublisher As String = textInfo.ToTitleCase(PublisherName.ToLower)

        Using connection As SqlConnection = ConnectionOpen(connString)

            Using command As New SqlCommand("UPDATE tblPublishers SET publisherName = @publisherName WHERE publisherID = @publisherID", connection)
                command.Parameters.AddWithValue("@publisherID", publisherID)
                command.Parameters.AddWithValue("@publisherName", capitalizedPublisher)
                command.ExecuteNonQuery()
                MessageBox.Show("Publisher updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                PublisherDatatable()
            End Using

        End Using

    End Sub

    Public Sub DeletePublisher(publisherID As Integer)
        Using connection As SqlConnection = ConnectionOpen(connString)

            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE publisherID = @publisherID", connection)
                checkCommand.Parameters.AddWithValue("@publisherID", publisherID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Publisher cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New SqlCommand("DELETE FROM tblPublishers WHERE publisherID = @publisherID", connection)
                        command.Parameters.AddWithValue("@publisherID", publisherID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Publisher has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        PublisherDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub

#End Region

#Region "Genres"
    Public Sub GenreDatatable()
        Dim dtGenre As DataTable = DisplayData("tblGenres")
        frmMaintenance.dgGenres.DataSource = dtGenre
    End Sub
    Public Sub AddGenre(genreName As String, description As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedGenreName As String = textInfo.ToTitleCase(genreName.ToLower())
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)

            Dim genreExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblGenres WHERE genreName = @genreName", connection)
                checkCommand.Parameters.AddWithValue("@genreName", capitalizedGenreName)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                genreExists = count > 0
            End Using

            If genreExists Then
                MessageBox.Show("Genre already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblGenres(genreName, description) VALUES (@genreName, @description)", connection)
                command.Parameters.AddWithValue("@genreName", capitalizedGenreName)
                command.Parameters.AddWithValue("@description", capitalizedDescription)
                command.ExecuteNonQuery()
                MessageBox.Show("Genre added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                GenreDatatable()
            End Using
        End Using
    End Sub

    Public Sub UpdateGenre(genreID As Integer, genreName As String, description As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedGenre As String = textInfo.ToTitleCase(genreName.ToLower)
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower)

        Using connection As SqlConnection = ConnectionOpen(connString)

            Using command As New SqlCommand("UPDATE tblGenres SET genreName = @genreName,
                                                                 description = @description    
                                             WHERE genreID = @genreID", connection)
                command.Parameters.AddWithValue("@genreID", genreID)
                command.Parameters.AddWithValue("@genreName", capitalizedGenre)
                command.Parameters.AddWithValue("@description", capitalizedDescription)
                command.ExecuteNonQuery()
                MessageBox.Show("Genre updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                PublisherDatatable()
            End Using

        End Using

    End Sub

    Public Sub DeleteGenre(genreID As Integer)
        Using connection As SqlConnection = ConnectionOpen(connString)

            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE genreID = @genreID", connection)
                checkCommand.Parameters.AddWithValue("@genreID", genreID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Genre cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New SqlCommand("DELETE FROM tblGenres WHERE genreID = @genreID", connection)
                        command.Parameters.AddWithValue("@genreID", genreID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Genre has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        GenreDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub
#End Region

#Region "Bookshelves"
    Public Sub ShelfDatatable()
        Dim dtShelf As DataTable = DisplayData("tblBookshelves")
        frmMaintenance.dgBookshelves.DataSource = dtShelf
    End Sub

    Public Sub AddBookshelves(shelfNo As String, description As String, location As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower())
        Dim capitalizedLocation As String = textInfo.ToTitleCase(location.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)

            Dim shelfExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBookshelves WHERE shelfNo = @shelfNo", connection)
                checkCommand.Parameters.AddWithValue("@shelfNo", shelfNo)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                shelfExists = count > 0
            End Using

            If shelfExists Then
                MessageBox.Show("Shelf number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblBookshelves(shelfNo, description, location) 
                                             VALUES(@shelfNo, @description, @location)", connection)
                With command.Parameters
                    .AddWithValue("@shelfNo", shelfNo)
                    .AddWithValue("@description", capitalizedDescription)
                    .AddWithValue("@location", capitalizedLocation)
                End With
                command.ExecuteNonQuery()
                MessageBox.Show("Bookshelf added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ShelfDatatable()
            End Using
        End Using
    End Sub

    Public Sub UpdateBookshelf(shelfID As Integer, description As String, location As String)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedlocation As String = textInfo.ToTitleCase(location.ToLower)
        Dim capitalizedDescription As String = textInfo.ToTitleCase(description.ToLower)

        Using connection As SqlConnection = ConnectionOpen(connString)

            Using command As New SqlCommand("UPDATE tblBookshelves SET description = @description,
                                                                       location = @location     
                                             WHERE shelfID = @shelfID", connection)
                command.Parameters.AddWithValue("@shelfID", shelfID)
                command.Parameters.AddWithValue("@description", capitalizedDescription)
                command.Parameters.AddWithValue("@location", capitalizedlocation)
                command.ExecuteNonQuery()
                MessageBox.Show("Shelf updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ShelfDatatable()
            End Using

        End Using

    End Sub

    Public Sub DeleteShelf(shelfID As Integer)
        Using connection As SqlConnection = ConnectionOpen(connString)

            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBooks WHERE shelfID = @shelfID", connection)
                checkCommand.Parameters.AddWithValue("@shelfID", shelfID)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Shelf cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Using command As New SqlCommand("DELETE FROM tblBookshelves WHERE shelfID = @shelfID", connection)
                        command.Parameters.AddWithValue("@shelfID", shelfID)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Shelf has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ShelfDatatable()
                    End Using
                End If
            End Using
        End Using
    End Sub
#End Region
End Module
