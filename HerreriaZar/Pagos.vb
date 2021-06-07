Imports MySql.Data.MySqlClient

Public Class Pagos
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
    Private Sub LabelVentaEspe_Click(sender As Object, e As EventArgs) Handles LabelVentaEspe.Click

    End Sub

    Public Sub cargarcomboempleado()
        Dim dt As New DataTable
        Dim con As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
        Dim consulta As String = "SELECT id, nombre FROM usuarios"
        Dim comando As New MySqlDataAdapter(consulta, con)
        comando.Fill(dt)

        ComboBoxEmpleado.DataSource = dt
        ComboBoxEmpleado.DisplayMember = "nombre"
        ComboBoxEmpleado.ValueMember = "id"

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTPfecha.ValueChanged

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
        DGVpagos.ReadOnly = True

        Try

            cargarcomboempleado()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BuscarCliente()
        Dim datos As New MySqlDataAdapter("select vg.id, cc.nombre, cc.paterno, cc.materno , vg.anticipo, vg.total, vg.status, vg.fecha, vg.fecha_b from venta_general as vg
JOIN catalogo_clientes As cc
ON cc.id = vg.clientes_fk
where cc.nombre LIKE '" & TextBoxCliente.Text & "%'", cnx)

        Dim ds As New DataSet()
        datos.Fill(ds, "venta_especifica")

        Me.DGVpagos.DataSource = ds.Tables("venta_especifica")
    End Sub

    Private Sub CargarVentas()
        Dim datos As New MySqlDataAdapter("SELECT cp.descripcion,ve.alto,ve.largo,ve.ancho,ve.color, ve.cantidad, ve.precio 
FROM venta_especifica As ve
JOIN venta_general As vg
ON vg.id = ve.venta_general_fk
JOIN catalogo_productos As cp
ON cp.id = ve.productos_fk
WHERE vg.id = " & TextBoxid.Text & "", cnx)
        Dim ds As New DataSet()
        datos.Fill(ds, "venta_especifica")

        Me.DGVpagos.DataSource = ds.Tables("venta_especifica")
    End Sub

    Private Sub insertarnull()
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        Dim cmd As New MySqlCommand("INSERT INTO pagos(pago, fecha, venta_general_fk, usuarios_fk) VALUES(NULL,NULL,NULL,NULL)", cnx)
        cmd.ExecuteNonQuery()


        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub

    Private Sub updateVenta_General()


        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        Dim cmd As New MySqlCommand("UPDATE venta_general set status = 'pagado' where id = @id", cnx)
        cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = TextBoxid.Text
        cmd.ExecuteNonQuery()
        MsgBox("Pago exitoso", MsgBoxStyle.Information, "Confirmacion")

        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub

    Private Sub insertarPago()



        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        If TextBoxMonto.Text < 0 Then
            MsgBox("Por favor, ingresa un número valido")

        Else
            Dim command As New MySqlCommand("UPDATE pagos set pago = @pago, fecha = @fecha, venta_general_fk = @id , usuarios_fk = @usuarios_fk ORDER BY id DESC LIMIT 1 ", cnx)
            command.Parameters.Add("@pago", MySqlDbType.VarChar).Value = TextBoxMonto.Text
            command.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = DTPfecha.Value.Date.ToString("yyyy/MM/dd")
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = TextBoxid.Text
            command.Parameters.Add("@usuarios_fk", MySqlDbType.VarChar).Value = ComboBoxEmpleado.SelectedValue
            command.ExecuteNonQuery()
        End If

        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub

    Private Sub BotonPagar_Click(sender As Object, e As EventArgs) Handles BotonPagar.Click
        Call insertarPago()
        Call updateVenta_General()

        TextBoxMonto.Text = ""

        DGVpagos.DataSource = Nothing
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call BuscarCliente()
        DGVpagos.Columns("id").Visible = False

        TextBoxCliente.Text = ""



    End Sub

    Private Sub CargarDatosTotal()
        Dim lista As Byte
        Dim datos As New MySqlDataAdapter("select sum(total) - sum(anticipo) as monto
from venta_general
where id =  " & TextBoxid.Text & "", cnx)
        Dim ds As New DataSet()
        datos.Fill(ds, "venta_general")

        lista = ds.Tables("venta_general").Rows.Count
        TextBoxMonto.Text = ds.Tables("venta_general").Rows(0).Item("monto")
    End Sub

    Private Sub DGVpagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVpagos.CellContentClick
        Dim renglon As Integer
        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVpagos.CurrentCellAddress.Y
        TextBoxid.Text = DGVpagos.Rows(renglon).Cells(0).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call CargarVentas()
        Call CargarDatosTotal()



    End Sub
End Class