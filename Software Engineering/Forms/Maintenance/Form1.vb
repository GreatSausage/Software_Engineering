Imports MySql.Data.MySqlClient
Public Class Form1
    Dim constr As String

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrEmpty(txtUsernameSignIn.Text) OrElse
           String.IsNullOrEmpty(txtPasswordSignIn.Text) Then
            MessageBox.Show("Please fill in the necessary fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Login(txtUsernameSignIn.Text, txtPasswordSignIn.Text)
        End If
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim server As String = txtServer.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim database As String = txtDatabase.Text

        My.Settings.server = server
        My.Settings.database = database
        My.Settings.username = username
        My.Settings.password = password

        Dim constr As String = "server=" & server & ";username=" & username & ";password=" & password & ";database=" & database & ";port=3306"

        Try
            My.Settings.connString = constr
            My.Settings.Save()

            Using connection As New MySqlConnection(constr)
                connection.Open()
                MessageBox.Show("Server connected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error connecting to server: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        connection.Close()
        Dim connstring As String = My.Settings.connString
        connection.ConnectionString = connstring
    End Sub
End Class