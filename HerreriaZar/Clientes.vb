Imports MySql.Data.MySqlClient

Public Class Clientes
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, telefono FROM `catalogo_clientes`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVClientes.DataSource = dt
        cnx.Close()
    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        Dim command As New MySqlCommand("INSERT INTO `catalogo_clientes`(`nombre`, `paterno`, `materno`, `correo`, `telefono`) VALUES (@nombre,@paterno,@materno,@correo,@telefono)", cnx)

        command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = TextBoxNombre.Text
        command.Parameters.Add("@paterno", MySqlDbType.VarChar).Value = TextBoxPaterno.Text
        command.Parameters.Add("@materno", MySqlDbType.VarChar).Value = TextBoxMaterno.Text
        command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = TextBoxCorreo.Text
        command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = TextBoxTelefono.Text

        cnx.Open()

        If command.ExecuteNonQuery() = 1 Then  ''Field 'usuarios_fk' doesn't have a default value'
            '

            MessageBox.Show("Cliente Añadido")

        Else

            MessageBox.Show("ERROR")

        End If

        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, telefono FROM `catalogo_clientes`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVClientes.DataSource = dt
        cnx.Close()


    End Sub

End Class