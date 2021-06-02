Imports MySql.Data.MySqlClient

Public Class Pagos
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
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

    Private Sub BotonPagar_Click(sender As Object, e As EventArgs) Handles BotonPagar.Click



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call BuscarCliente()
        DGVpagos.Columns("id").Visible = False


    End Sub

    Private Sub DGVpagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVpagos.CellContentClick
        Dim renglon As Integer
        'Al darle clic al renglón mostramos los datos en las cajas de texto
        renglon = DGVpagos.CurrentCellAddress.Y
        TextBoxid.Text = DGVpagos.Rows(renglon).Cells(0).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call CargarVentas()

    End Sub
End Class