Imports MySql.Data.MySqlClient
Public Class LogIn

    Private Sub BotonDeIngreso_Click(sender As Object, e As EventArgs) Handles BotonDeIngreso.Click
        'Declaracion de variables necesarias'

        Dim comando As MySqlCommand = New MySqlCommand


        Module1.usuario = user.Text



        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
        comando.Connection = cnx

        'Probar conexion'
        Try

            'zP8HlxqCBwCFHcHz password JP'
            cnx.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT * FROM usuarios WHERE usuario=@usuario AND password=@password" '"
        comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.Text
        comando.Parameters.Add("@password", MySqlDbType.VarChar).Value = Contraseña.Text

        Dim r As MySqlDataReader

        r = comando.ExecuteReader

        If r.HasRows <> False Then
            r.Read()
            MsgBox("Bienvenido de Vuelta: " + r.GetString("nombre"))
            MenuPrincipal.Show()
            Me.Hide()
        Else
            MsgBox("Error, Usuario o contaseña no validos")
        End If
        'cerrar conexion'
        user.Text = ""
        Contraseña.Text = ""
        user.Focus()
        cnx.Close()
    End Sub



    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged

    End Sub

    Private Sub Contraseña_TextChanged(sender As Object, e As EventArgs) Handles Contraseña.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
