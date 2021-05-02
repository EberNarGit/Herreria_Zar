Imports MySql.Data.MySqlClient

Public Class ReporteVentas

    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
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

        comando.CommandText = "SELECT vg.fecha As fecha_inicial, p.fecha As fecha_final, COUNT(vg.id) As Num_Ventas, (SUM(anticipo) + SUM(pago)) As Ganancias FROM pagos As p JOIN venta_general As vg ON (vg.id = p.venta_general_fk) WHERE vg.fecha >= '" + F + "'  AND p.fecha <='" + L + " ' "

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        DGVreporte.DataSource = dt
        cnx.Close()





        'Invocamos al metodo para poblar con los datos al DGV


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub DGVreporte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVreporte.CellContentClick

    End Sub
End Class



