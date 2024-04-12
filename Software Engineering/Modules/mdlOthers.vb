Imports MySql.Data.MySqlClient

Module mdlOthers

    Public Function ConnectionOpen(connectionString As String)
        Dim connection As New MySqlConnection(connectionString)
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

End Module
