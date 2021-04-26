Public Class Usuario
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub ButtonEmpleados_Click(sender As Object, e As EventArgs) Handles ButtonEmpleados.Click
        Empleados.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clientes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonVentas_Click(sender As Object, e As EventArgs) Handles ButtonVentas.Click
        VentaG.Show()
    End Sub

    Private Sub ButtonUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonUsuarios.Click
        Me.Show()
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
        CatalogoDeProductos.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ReporteVentas.Show()
        Me.Hide()
    End Sub
End Class