Imports MySql.Data.MySqlClient
Public Class LogIn
    Private Sub BotonDeIngreso_Click(sender As Object, e As EventArgs) Handles BotonDeIngreso.Click
        'Declaracion de variables necesarias'
        Dim cnx As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = cnx

        'Probar conexion'
        Try
            cnx.ConnectionString = "Server = localhost; Database = herreriazar; Uid = root; Pwd = Eber844@;"
            cnx.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT * FROM usuarios WHERE usuario='" + user.Text + "' AND password='" + Contraseña.Text + "'"

        Dim r As MySqlDataReader

        r = comando.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            MsgBox(r.GetString("nombre"))
            MenuPrincipal.Show()
        Else
            MsgBox("Error, Usuario o contaseña no validos")
        End If

        'cerrar conexion'
        cnx.Close()
    End Sub

    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub

    Private Sub Contraseña_TextChanged(sender As Object, e As EventArgs) Handles Contraseña.TextChanged

    End Sub
End Class
