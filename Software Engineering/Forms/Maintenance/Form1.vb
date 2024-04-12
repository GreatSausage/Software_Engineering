Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As New MySqlConnection
    Dim constr As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim server As String = TextBox1.Text
        Dim username As String = TextBox2.Text
        Dim password As String = TextBox3.Text
        Dim database As String = TextBox4.Text
        My.Settings.server = server
        My.Settings.database = database
        My.Settings.username = username
        My.Settings.password = password

        con.Close()
        constr = "server=" & server & ";username=" & username & ";password=" & password & ";database=" & database & ";port=3306"
        con.ConnectionString = constr
        My.Settings.connString = constr

        If con.State = ConnectionState.Closed Then
            con.Open()
            If con.State = ConnectionState.Open Then
                MsgBox("Connected")
            End If
        End If

    End Sub
End Class