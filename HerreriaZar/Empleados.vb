Imports MySql.Data.MySqlClient

Public Class Empleados
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto

        'Declaracion de variables necesarias'
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
        Dim command As New MySqlCommand("INSERT INTO `usuarios`(`nombre`, `paterno`, `materno`, `usuario`, `password`) VALUES (@nombre,@paterno,@materno,@usuario,@password)", cnx)

        command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = TextBoxNombre.Text
        command.Parameters.Add("@paterno", MySqlDbType.VarChar).Value = TextBoxPaterno.Text
        command.Parameters.Add("@materno", MySqlDbType.VarChar).Value = TextBoxMaterno.Text
        command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = TextBoxUsuario.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBoxCon.Text

        cnx.Open()

        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Usuario Guardado")

        Else

            MessageBox.Show("ERROR")

        End If

        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, usuario FROM `usuarios`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVusuarios.DataSource = dt
        cnx.Close()


    End Sub

    Private Sub DGVusuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVusuarios.CellContentClick

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, usuario FROM `usuarios`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVusuarios.DataSource = dt
        cnx.Close()
    End Sub
End Class