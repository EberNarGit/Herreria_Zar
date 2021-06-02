Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

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

    End Sub

    Private Sub ButtonPedidos_Click(sender As Object, e As EventArgs) Handles ButtonPedidos.Click
        Pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonCatálogo_Click(sender As Object, e As EventArgs) Handles ButtonCatálogo.Click
        CatalogoDeProductos.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonReporte_Click(sender As Object, e As EventArgs) Handles ButtonReporte.Click
        ReporteVentas.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonProfile_Click(sender As Object, e As EventArgs) Handles ButtonProfile.Click
        Respaldo.Show()
    End Sub
End Class