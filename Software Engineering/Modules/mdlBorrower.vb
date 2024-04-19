Imports System.Collections.Specialized.BitVector32
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Globalization

Module mdlBorrower


#Region "Borrower"

    'Public Function DisplaySection(grade As Integer) As DataTable
    '    Using connection As MySqlConnection = ConnectionOpen()
    '        Using command As New MySqlCommand("SELECT sectionID, section FROM tblSection WHERE gradeID = @grade", connection)
    '            command.Parameters.AddWithValue("@grade", grade)
    '            Using adapter As New MySqlDataAdapter(command)
    '                Dim dt As New DataTable
    '                adapter.Fill(dt)
    '                Return dt
    '            End Using
    '        End Using
    '    End Using
    'End Function

    '    Public Sub AddBorrowers(studentID As String, firstName As String, lastName As String, gradeID As Integer, sectionID As Integer, guardianContact As String)

    '        Dim cultureInfo As New CultureInfo("en-US")
    '        Dim textInfo As TextInfo = cultureInfo.TextInfo
    '        Dim capitalizedFirstName As String = textInfo.ToTitleCase(firstName.ToLower())
    '        Dim capitalizedLastName As String = textInfo.ToTitleCase(lastName.ToLower())

    '        Using connection As SqlConnection = ConnectionOpen(connString)

    '            Dim nameExists As Boolean = False
    '            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBorrowers WHERE (firstName = @firstName AND lastName = @lastName)", connection)
    '                checkCommand.Parameters.AddWithValue("@firstName", firstName)
    '                checkCommand.Parameters.AddWithValue("@lastName", lastName)
    '                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
    '                nameExists = count > 0
    '            End Using

    '            If nameExists Then
    '                MessageBox.Show("User with the same first name or last name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Return
    '            End If

    '            Dim contactExists As Boolean = False
    '            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBorrowers WHERE guardianContact = @contact", connection)
    '                checkCommand.Parameters.AddWithValue("@contact", guardianContact)
    '                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
    '                contactExists = count > 0
    '            End Using

    '            If contactExists Then
    '                MessageBox.Show("Contact number already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Return
    '            End If

    '            Using command As New SqlCommand("INSERT INTO tblBorrowers (studentID, firstName, lastName, gradeID, sectionID, guardianContact, borrowerType) 
    '                                             VALUES (@studentID, @firstName, @lastName, @gradeID, @sectionID, @guardianContact, 'Student')", connection)
    '                With command.Parameters
    '                    .AddWithValue("@studentID", studentID)
    '                    .AddWithValue("@firstName", capitalizedFirstName)
    '                    .AddWithValue("@lastName", capitalizedLastName)
    '                    .AddWithValue("@gradeID", gradeID)
    '                    .AddWithValue("@sectionID", sectionID)
    '                    .AddWithValue("@guardianContact", guardianContact)
    '                End With
    '                command.ExecuteNonQuery()
    '                MessageBox.Show("Borrower added successfully.")

    '                Dim dtBorrowers As DataTable = DisplayBorrowers()
    '                frmMainte.dgBorrowers.DataSource = dtBorrowers
    '            End Using
    '        End Using
    '    End Sub

    '    Public Sub SearchBorrowers(datagridview As DataGridView, search As String)
    '        Using connection As SqlConnection = ConnectionOpen(connString)
    '            Dim query As String = "SELECT borrowerID, studentID, firstName, lastName FROM tblBorrowers "

    '            If Not String.IsNullOrEmpty(search) Then
    '                query += " WHERE borrowerID LIKE @search OR studentID LIKE @search OR firstName LIKE @search OR lastName LIKE @search"
    '            End If

    '            Using command As New SqlCommand(query, connection)
    '                If Not String.IsNullOrEmpty(search) Then
    '                    command.Parameters.AddWithValue("@search", "%" & search & "%")
    '                End If

    '                Using adapter As New SqlDataAdapter(command)
    '                    Dim ds As New DataSet
    '                    adapter.Fill(ds)
    '                    datagridview.DataSource = ds.Tables(0)
    '                End Using
    '            End Using
    '        End Using
    '    End Sub

    '    Public Function DisplayBorrowers() As DataTable
    '        Using connection As SqlConnection = ConnectionOpen(connString)
    '            Using command As New SqlCommand("SELECT b.borrowerID, b.studentID, b.firstName, b.lastName, g.grade, s.section, b.guardianContact
    '                                             FROM tblBorrowers b
    '                                             JOIN tblGrade g ON b.gradeID = g.gradeID
    '                                             JOIN tblSection s ON b.sectionID = s.sectionID", connection)
    '                Using adapter As New SqlDataAdapter(command)
    '                    Dim datatable As New DataTable
    '                    adapter.Fill(datatable)
    '                    Return datatable
    '                End Using
    '            End Using
    '        End Using
    '    End Function

#End Region

#Region "Grade"
    Public Function DisplayGrade() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT * FROM tblGrade 
                                               ORDER BY grade", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

    Public Sub GradeDatatable()
        Dim dtGrade As DataTable = DisplayGrade()
        frmMainte.dgGrade.DataSource = dtGrade
    End Sub

    Public Sub AddGrade(grade As Integer)
        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblGrade (grade) VALUES (@grade)", connection)
                    command.Parameters.AddWithValue("@grade", grade)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Grade added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GradeDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Grade level already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

    End Sub
#End Region

#Region "Section"
    Public Function DisplaySection() As DataTable
        Using connection As MySqlConnection = ConnectionOpen()
            Using command As New MySqlCommand("SELECT s.sectionID, s.section, g.grade 
                                               FROM tblSection s 
                                               JOIN tblGrade g ON s.gradeID = g.gradeID
                                               ORDER BY g.grade", connection)
                Using adapter As New MySqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

    Public Sub SectionDatatable()
        Dim sectionDt As DataTable = DisplaySection()
        frmMainte.dgSection.DataSource = sectionDt
    End Sub

    Public Sub AddSection(section As String, gradeID As Integer)
        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedSection As String = textInfo.ToTitleCase(section.ToLower())

        Try
            Using connection As MySqlConnection = ConnectionOpen()
                Using command As New MySqlCommand("INSERT INTO tblSection (section, gradeID) VALUES (@section, @gradeID)", connection)
                    command.Parameters.AddWithValue("@section", capitalizedSection)
                    command.Parameters.AddWithValue("@gradeID", gradeID)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Section added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SectionDatatable()
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MessageBox.Show("Section already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub
#End Region

    '#Region "Faculty"

    '    Public Sub FacultyDatatable()
    '        Using connection As SqlConnection = ConnectionOpen(connString)
    '            Using command As New SqlCommand("SELECT borrowerID, firstName, lastName, guardianContact, borrowerType FROM tblBorrowers WHERE borrowerType = 'Faculty'", connection)
    '                Using adapter As New SqlDataAdapter(command)
    '                    Dim dt As New DataTable
    '                    adapter.Fill(dt)
    '                    frmMainte.dgFaculty.DataSource = dt
    '                End Using
    '            End Using
    '        End Using
    '    End Sub
    '    Public Sub AddFaculty(firstname As String, lastname As String, phoneNumber As String)

    '        Dim cultureInfo As New CultureInfo("en-US")
    '        Dim textInfo As TextInfo = cultureInfo.TextInfo
    '        Dim capitalizedFirstname As String = textInfo.ToTitleCase(firstname.ToLower())
    '        Dim capitalizedLastname As String = textInfo.ToTitleCase(lastname.ToLower())

    '        Using connection As SqlConnection = ConnectionOpen(connString)

    '            Dim contactExists As Boolean = False
    '            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblBorrowers WHERE guardianContact = @contact", connection)
    '                checkCommand.Parameters.AddWithValue("@contact", phoneNumber)
    '                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
    '                contactExists = count > 0
    '            End Using

    '            If contactExists Then
    '                MessageBox.Show("Contact already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Return
    '            End If
    '            Using command As New SqlCommand("INSERT INTO tblBorrowers (firstName, lastName, guardianContact, borrowerType) 
    '                                             VALUES (@firstName, @lastName, @phoneNumber, 'Faculty')", connection)
    '                With command.Parameters
    '                    .AddWithValue("@firstName", capitalizedFirstname)
    '                    .AddWithValue("@lastName", capitalizedLastname)
    '                    .AddWithValue("@phoneNumber", phoneNumber)
    '                End With
    '                command.ExecuteNonQuery()
    '                MessageBox.Show("Faculty added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                FacultyDatatable()
    '            End Using
    '        End Using
    '    End Sub
    '#End Region
End Module
