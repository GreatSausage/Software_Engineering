Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module mdlOthers

    Public Function ConnectionOpen() As MySqlConnection
        Dim connection As New MySqlConnection(My.Settings.connString)
        connection.Open()
        Return connection
    End Function

    Public Sub DisplayFormPanel(frm As Form, displayPanel As Panel)
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        displayPanel.Controls.Clear()
        displayPanel.Controls.Add(frm)
        frm.Show()
    End Sub

#Region "Sign In"
    Public Sub Login(userName As String, password As String)
        Using connection As MySqlConnection = ConnectionOpen()
            Using userCommand As New MySqlCommand("SELECT COUNT(*) FROM tblusers WHERE userName = @userName", connection)
                userCommand.Parameters.AddWithValue("@@userName", userName)

                If Convert.ToInt32(userCommand.ExecuteScalar()) > 0 Then
                    Using passCommand As New MySqlCommand("SELECT Password FROM tblusers WHERE userName = @userName", connection)
                        passCommand.Parameters.AddWithValue("@userName", userName)
                        Dim dbPassword As String = Convert.ToString(passCommand.ExecuteScalar())

                        If dbPassword IsNot Nothing AndAlso dbPassword.Equals(password) Then
                            MessageBox.Show("Logged in successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            frmMain.Show()
                            Form1.Close()
                        Else
                            MessageBox.Show("Incorrect Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Else
                    MessageBox.Show("Email not exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
#End Region
End Module
