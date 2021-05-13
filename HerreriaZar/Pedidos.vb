

Imports MySql.Data.MySqlClient

Public Class Pedidos


    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
        Pagos.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Show()
    End Sub

    Private Sub ButtonCatálogo_Click(sender As Object, e As EventArgs) Handles ButtonCatálogo.Click
        CatalogoDeProductos.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReporteVentas.Show()
        Me.Hide()
    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPedidos.CellContentClick

    End Sub

    Private Sub BotonActualizar_Click(sender As Object, e As EventArgs) Handles BtmActualizar.Click
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto
        Dim F As String = DTPpre.Value.Date.ToString("yyyy/MM/dd")
        Dim L As String = DTPdes.Value.Date.ToString("yyyy/MM/dd")

        'Declaracion de variables necesarias'
        Dim cnx As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = cnx

        'Probar conexion'
        Try
            cnx.ConnectionString = "Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@"
            cnx.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT cc.nombre as cliente, cp.descripcion as producto, vg.fecha as fecha_pedido, vg.fecha_b as fecha_entrega 
FROM venta_general as vg 
JOIN catalogo_clientes as cc ON (cc.id = vg.clientes_fk)
JOIN venta_especifica as ve ON(vg.id = ve.venta_general_fk)
JOIN catalogo_productos as cp ON(cp.id = ve.productos_fk) WHERE vg.fecha >= '" + F + "'  AND vg.fecha_b <='" + L + " ' "

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        DGVPedidos.DataSource = dt
        cnx.Close()

    End Sub
End Class