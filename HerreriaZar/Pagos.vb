Imports MySql.Data.MySqlClient

Public Class Pagos
    Private Sub LabelVentaEspe_Click(sender As Object, e As EventArgs) Handles LabelVentaEspe.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTP.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonVentas_Click(sender As Object, e As EventArgs) Handles ButtonVentas.Click
        VentaG.Show()
    End Sub

    Private Sub ButtonUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonUsuarios.Click
        Usuario.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonPagos_Click(sender As Object, e As EventArgs) Handles ButtonPagos.Click
        Me.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonCatálogo_Click(sender As Object, e As EventArgs) Handles ButtonCatálogo.Click
        CatalogoDeProductos.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReporteVentas.Show()
        Me.Hide()
    End Sub

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        Dim adapter As New MySqlDataAdapter("SELECT cc.nombre FROM pagos As p JOIN venta_general As vg ON vg.id = p.venta_general_fk JOIN catalogo_clientes As cc ON cc.id = vg.clientes_fk", cnx)
        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBoxCliente.DataSource = table

        ComboBoxCliente.ValueMember = "nombre"
        ComboBoxCliente.DisplayMember = "nombre"

        Dim adapter1 As New MySqlDataAdapter("SELECT `id`, `usuario` FROM usuarios", cnx)
        Dim table1 As New DataTable()

        adapter1.Fill(table1)

        ComboBoxEmpleado.DataSource = table1

        ComboBoxEmpleado.ValueMember = "id"
        ComboBoxEmpleado.DisplayMember = "usuario"

    End Sub

    Private Sub BotonPagar_Click(sender As Object, e As EventArgs) Handles BotonPagar.Click
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        Dim command As New MySqlCommand("INSERT INTO `catalogo_clientes`(`nombre`, `paterno`, `materno`, `correo`, `telefono`) VALUES (@nombre,@paterno,@materno,@correo,@telefono)", cnx)

        command.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = ComboBoxCliente.SelectedValue
        command.Parameters.Add("@monto", MySqlDbType.VarChar).Value = TextBoxMonto.Text
        command.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = DTP.Value.Date.ToString("yyyy/MM/dd")
        command.Parameters.Add("@concepto", MySqlDbType.VarChar).Value = ComboBoxEmpleado.SelectedValue


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
        DGVPagos.DataSource = dt
        cnx.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        Dim command As New MySqlCommand("SELECT  pago, fecha, usuarios_fk FROM `pagos` WHERE venta_general_fk=@cliente)", cnx)

        command.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = ComboBoxCliente.SelectedValue

        cnx.Open()

        If command.ExecuteNonQuery() = 1 Then  ''Field 'usuarios_fk' doesn't have a default value'
            '

            MessageBox.Show("Cliente Añadido")

        Else

            MessageBox.Show("ERROR")

        End If

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(command)

        da.Fill(dt)
        DGVPagos.DataSource = dt
        cnx.Close()

    End Sub
End Class