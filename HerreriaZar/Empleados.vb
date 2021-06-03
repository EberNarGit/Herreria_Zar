Imports MySql.Data.MySqlClient

Public Class Empleados
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")


    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto

        'Declaracion de variables necesarias'
        If String.IsNullOrEmpty(TextBoxUsuario.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        Else
            Try
                Dim command As New MySqlCommand("INSERT INTO `usuarios`(`nombre`, `paterno`, `materno`, `usuario`, `password`) VALUES (@nombre,@paterno,@materno,@usuario,@password)", cnx)

                command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = TextBoxNombre.Text
                command.Parameters.Add("@paterno", MySqlDbType.VarChar).Value = TextBoxPaterno.Text
                command.Parameters.Add("@materno", MySqlDbType.VarChar).Value = TextBoxMaterno.Text
                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = TextBoxUsuario.Text
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxCon.Text

                cnx.Open()

                If command.ExecuteNonQuery() = 1 Then

                    MessageBox.Show("Empleado Guardado")

                Else

                    MessageBox.Show("No se puede gurdar el empleado, intenta con otro nombre de usuario")

                End If
            Catch ex As MySql.Data.MySqlClient.MySqlException
                Select Case ex.Number
                    Case 1406
                        MsgBox("Error, uno de los campos excede el límite de caracteres")
                    Case 1062
                        MsgBox("No se puede añadir, usuario duplicado")
                End Select

            End Try


            TextBoxNombre.Text = ""
            TextBoxPaterno.Text = ""
            TextBoxMaterno.Text = ""
            TextBoxUsuario.Text = ""
            TextBoxCon.Text = ""

            Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, usuario FROM `usuarios`", cnx)

            Dim dt As DataTable = New DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

            da.Fill(dt)
            DGVusuarios.DataSource = dt
            cnx.Close()

        End If


    End Sub

    Private Sub DGVusuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVusuarios.CellContentClick
        Dim renglon As Integer
        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVusuarios.CurrentCellAddress.Y
        TextBoxNombre.Text = DGVusuarios.Rows(renglon).Cells(1).Value
        TextBoxPaterno.Text = DGVusuarios.Rows(renglon).Cells(2).Value
        TextBoxMaterno.Text = DGVusuarios.Rows(renglon).Cells(3).Value
        TextBoxUsuario.Text = DGVusuarios.Rows(renglon).Cells(4).Value
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, usuario FROM `usuarios`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVusuarios.DataSource = dt
        cnx.Close()
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim command As New MySqlCommand("delete FROM `usuarios` WHERE usuario=@usuario ", cnx)

        command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = TextBoxNombre.Text
        command.Parameters.Add("@paterno", MySqlDbType.VarChar).Value = TextBoxPaterno.Text
        command.Parameters.Add("@materno", MySqlDbType.VarChar).Value = TextBoxMaterno.Text
        command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = TextBoxUsuario.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxCon.Text

        cnx.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Empleado Eliminado")

        Else

            MessageBox.Show("ERROR")

        End If

        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, usuario FROM `usuarios`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVusuarios.DataSource = dt
        cnx.Close()
        TextBoxNombre.Text = ""
        TextBoxPaterno.Text = ""
        TextBoxMaterno.Text = ""
        TextBoxUsuario.Text = ""
        TextBoxCon.Text = ""



    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        cnx.Open()
        Dim command As New MySqlCommand("UPDATE `usuarios` SET  paterno=@paterno, materno=@materno, usuario=@usuario, password=@password WHERE nombre=@nombre;", cnx)
        'Poder modificar todo
        command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = TextBoxNombre.Text
        command.Parameters.Add("@paterno", MySqlDbType.VarChar).Value = TextBoxPaterno.Text
        command.Parameters.Add("@materno", MySqlDbType.VarChar).Value = TextBoxMaterno.Text
        command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = TextBoxUsuario.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxCon.Text

        command.CommandType = CommandType.Text
        command.ExecuteNonQuery()


        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, usuario FROM `usuarios`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVusuarios.DataSource = dt
        cnx.Close()
        TextBoxNombre.Text = ""
        TextBoxPaterno.Text = ""
        TextBoxMaterno.Text = ""
        TextBoxUsuario.Text = ""
        TextBoxCon.Text = ""

    End Sub
End Class