Imports MySql.Data.MySqlClient

Public Class CatalogoDeProductos
    Private Sub ButtonAddProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddProduct.Click
        AñadirProducto.Show()
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
        Pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonCatálogo_Click(sender As Object, e As EventArgs) Handles ButtonCatálogo.Click
        Me.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReporteVentas.Show()
        Me.Hide()
    End Sub


    Private Sub CatalogoDeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        Dim comman As New MySqlCommand("SELECT id,imagen, descripcion, categorias_fk FROM `catalogo_productos`", cnx)
        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)
        Dim pic1 As New DataGridViewImageColumn

        da.Fill(dt)
        DGVCatalogo.DataSource = dt
        DGVCatalogo.RowTemplate.Height = 90
        pic1 = DGVCatalogo.Columns(1)
        pic1.ImageLayout = DataGridViewImageCellLayout.Stretch
        cnx.Close()
    End Sub
End Class