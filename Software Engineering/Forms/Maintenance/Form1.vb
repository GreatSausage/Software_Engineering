Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As New MySqlConnection
    Dim constr As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnClose.LinkClicked
        Me.Close()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
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

        con.Close()
        constr = "server=" & server & ";username=" & username & ";password=" & password & ";database=" & database & ";port=3306"
        con.ConnectionString = constr
        My.Settings.connString = constr

        Using connection As MySqlConnection = ConnectionOpen()
            ConnectionOpen()
            If connection.State = ConnectionState.Open Then
                MessageBox.Show("Server connected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub
End Class