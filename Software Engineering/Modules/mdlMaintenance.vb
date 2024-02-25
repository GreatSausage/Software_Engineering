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
#End Region

#Region "Authors"
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

                Dim dtAuthors As DataTable = DisplayData("tblAuthors")
                frmMaintenance.dgAuthors.DataSource = dtAuthors
            End Using
        End Using
    End Sub
#End Region

#Region "Publishers"
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

                Dim dtPublishers As DataTable = DisplayData("tblPublishers")
                frmMaintenance.dgPublishers.DataSource = dtPublishers
            End Using
        End Using
    End Sub
#End Region

#Region "Genres"
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

                Dim dtGenres As DataTable = DisplayData("tblGenres")
                frmMaintenance.dgGenres.DataSource = dtGenres
            End Using
        End Using
    End Sub
#End Region

#Region "Bookshelves"

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

                Dim shelfDt As DataTable = DisplayData("tblBookshelves")
                frmMaintenance.dgBookshelves.DataSource = shelfDt
            End Using
        End Using
    End Sub
#End Region
End Module
