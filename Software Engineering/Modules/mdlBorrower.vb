Imports System.Data.SqlClient
Imports System.Globalization

Module mdlBorrower

    Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clifford\source\repos\Software Engineering\Software Engineering\Databases\dbLMS.mdf;Integrated Security=True"

#Region "Borrower"

    Public Function DisplaySection(grade As Integer) As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT sectionID, section FROM tblSection WHERE gradeID = @grade", connection)
                command.Parameters.AddWithValue("@grade", grade)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Sub AddBorrowers(studentID As String, firstName As String, lastName As String, gradeID As Integer, sectionID As Integer, guardianContact As String)

        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedFirstName As String = textInfo.ToTitleCase(firstName.ToLower())
        Dim capitalizedLastName As String = textInfo.ToTitleCase(lastName.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("INSERT INTO tblBorrowers (studentID, firstName, lastName, gradeID, sectionID, guardianContact) 
                                             VALUES (@studentID, @firstName, @lastName, @gradeID, @sectionID, @guardianContact)", connection)
                With command.Parameters
                    .AddWithValue("@studentID", studentID)
                    .AddWithValue("@firstName", capitalizedFirstName)
                    .AddWithValue("@lastName", capitalizedLastName)
                    .AddWithValue("@gradeID", gradeID)
                    .AddWithValue("@sectionID", sectionID)
                    .AddWithValue("@guardianContact", guardianContact)
                End With
                command.ExecuteNonQuery()
                MessageBox.Show("Borrower added successfully.")

                Dim dtBorrowers As DataTable = DisplayBorrowers()
                frmMainte.dgBorrowers.DataSource = dtBorrowers
            End Using
        End Using
    End Sub

    Public Sub SearchBorrowers(datagridview As DataGridView, search As String)
        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim query As String = "SELECT borrowerID, studentID, firstName, lastName FROM tblBorrowers "

            If Not String.IsNullOrEmpty(search) Then
                query += " WHERE borrowerID LIKE @search OR studentID LIKE @search OR firstName LIKE @search OR lastName LIKE @search"
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

    Public Function DisplayBorrowers() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT b.borrowerID, b.studentID, b.firstName, b.lastName, g.grade, s.section, b.guardianContact
                                             FROM tblBorrowers b
                                             JOIN tblGrade g ON b.gradeID = g.gradeID
                                             JOIN tblSection s ON b.sectionID = s.sectionID", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    Return datatable
                End Using
            End Using
        End Using
    End Function

#End Region

#Region "Grade"
    Public Sub GradeDatatable()
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT * FROM tblGrade", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    frmMainte.dgGrade.DataSource = datatable
                End Using
            End Using
        End Using
    End Sub

    Public Sub AddGrade(grade As Integer)
        Using connection As SqlConnection = ConnectionOpen(connString)

            Dim gradeExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblGrade WHERE grade = @grade", connection)
                checkCommand.Parameters.AddWithValue("@grade", grade)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                gradeExists = count > 0
            End Using

            If gradeExists Then
                MessageBox.Show("Grade already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblGrade (grade) VALUES (@grade)", connection)
                command.Parameters.AddWithValue("@grade", grade)
                command.ExecuteNonQuery()
                MessageBox.Show("Grade added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GradeDatatable()
            End Using
        End Using
    End Sub
#End Region

#Region "Section"
    Public Sub SectionDatatable()
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT s.sectionID, s.section, g.grade 
                                             FROM tblSection s 
                                             JOIN tblGrade g ON s.gradeID = g.gradeID", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim datatable As New DataTable
                    adapter.Fill(datatable)
                    frmMainte.dgSection.DataSource = datatable
                End Using
            End Using
        End Using
    End Sub

    Public Function DisplayGrades() As DataTable
        Using connection As SqlConnection = ConnectionOpen(connString)
            Using command As New SqlCommand("SELECT gradeID, grade FROM tblGrade", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

    Public Sub AddSection(section As String, gradeID As Integer)

        Dim cultureInfo As New CultureInfo("en-US")
        Dim textInfo As TextInfo = cultureInfo.TextInfo
        Dim capitalizedSection As String = textInfo.ToTitleCase(section.ToLower())

        Using connection As SqlConnection = ConnectionOpen(connString)
            Dim sectionExists As Boolean = False
            Using checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblSection WHERE section = @section", connection)
                checkCommand.Parameters.AddWithValue("@section", capitalizedSection)
                Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                sectionExists = count > 0
            End Using

            If sectionExists Then
                MessageBox.Show("Section already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using command As New SqlCommand("INSERT INTO tblSection (section, gradeID) VALUES (@section, @gradeID)", connection)
                command.Parameters.AddWithValue("@section", capitalizedSection)
                command.Parameters.AddWithValue("@gradeID", gradeID)
                command.ExecuteNonQuery()
                MessageBox.Show("Section added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SectionDatatable()
            End Using
        End Using
    End Sub
#End Region
End Module
