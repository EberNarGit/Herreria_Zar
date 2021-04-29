Imports MySql.Data.MySqlClient

Public Class ClasePedidos
    Public Function consultaPedidos() As Object
        Dim cnx As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = cnx

        Try
            cnx.ConnectionString = "Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz"
            cnx.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT cc.nombre as cliente, vg.id as ID_Venta, vg.fecha as fecha_pedido, vg.fecha_b as fecha_entrega, vg.total, vg.anticipo" & " 
                                                    FROM venta_general as vg JOIN catalogo_clientes as cc ON (cc.id = vg.clientes_fk);"

        consultaPedidos = comando.CommandText



    End Function

    Public Sub poblarDGVPedidos(ByVal DGVPedidos As DataGridView)
        'Método que lee todas las materias del origen de datos
        DGVPedidos.DataSource = consultaPedidos()
        DGVPedidos.Refresh()
        'Establecer ancho de cada columna del DataGridView




    End Sub

End Class
