

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

    Private Sub BotonActualizar_Click(sender As Object, e As EventArgs) Handles BotonActualizar.Click
        'Botón de guardar, cuando se quiere registrar la información, validamos que se haya
        'capturado texto en las cajas de texto

        'Declaracion de variables necesarias'
        Dim cnx As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = cnx

        'Probar conexion'
        Try
            cnx.ConnectionString = "Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz"
            cnx.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT cc.nombre as cliente, vg.id as ID_Venta, vg.fecha as fecha_pedido, vg.fecha_b as fecha_entrega, vg.total, vg.anticipo" & " 
                                                    FROM venta_general as vg JOIN catalogo_clientes as cc ON (cc.id = vg.clientes_fk);"

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        DGVPedidos.DataSource = dt
        cnx.Close()





        'Invocamos al metodo para poblar con los datos al DGV

    End Sub
End Class