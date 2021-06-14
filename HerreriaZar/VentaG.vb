Imports MySql.Data.MySqlClient
Public Class VentaG
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
    'zP8HlxqCBwCFHcHz
    'Eber844@
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CargarDatosc()
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")


        Dim lista As Byte
        Dim datos As New MySqlDataAdapter("select id 
from usuarios 
where usuario = '" & TextBox1.Text & "'", cnx)
        Dim ds As New DataSet()
        datos.Fill(ds, "usuarios")

        lista = ds.Tables("usuarios").Rows.Count
        Try
            ejemplo.Text = ds.Tables("usuarios").Rows(0).Item("id")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub VentaG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Hoy es " & Today
        Call insertarnull()
        TextBox1.Text = Module1.usuario

        DGVventa.ReadOnly = True

        Try
            cargarcomboproducto()
            cargarcombocliente()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub cargarcomboproducto()
        Dim dt As New DataTable
        Dim con As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
        Dim consulta As String = "SELECT id, descripcion FROM catalogo_productos"
        Dim comando As New MySqlDataAdapter(consulta, con)
        comando.Fill(dt)

        CBProducto.DataSource = dt
        CBProducto.DisplayMember = "descripcion"
        CBProducto.ValueMember = "id"

    End Sub

    Public Sub cargarcombocliente()
        Dim dt As New DataTable
        Dim con As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
        Dim consulta As String = "SELECT id, nombre FROM catalogo_clientes"
        Dim comando As New MySqlDataAdapter(consulta, con)
        comando.Fill(dt)

        CBCliente.DataSource = dt
        CBCliente.DisplayMember = "nombre"
        CBCliente.ValueMember = "id"

    End Sub



    Private Sub CargarDatos()
        Dim datos As New MySqlDataAdapter("SELECT ve.id, cp.descripcion,ve.alto,ve.largo,ve.ancho,ve.color, ve.cantidad, ve.precio 
        From venta_especifica As ve
        Join venta_general As vg
        On vg.id = ve.venta_general_fk
        Join catalogo_productos As cp
        On cp.id = ve.productos_fk
        Where vg.id In(Select MAX(id) from venta_general)", cnx)
        Dim ds As New DataSet()
        datos.Fill(ds, "venta_especifica")

        Me.DGVventa.DataSource = ds.Tables("venta_especifica")
    End Sub

    Private Sub CargarDatosTotal()
        Dim lista As Byte
        Dim datos As New MySqlDataAdapter("select sum(precio) as total
                                           from venta_especifica
                                            where venta_general_fk = (SELECT MAX(id) AS id FROM venta_general)", cnx)
        Dim ds As New DataSet()
        datos.Fill(ds, "venta_especifica")

        lista = ds.Tables("venta_especifica").Rows.Count
        Try
            TextBoxTotal.Text = ds.Tables("venta_especifica").Rows(0).Item("total")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub insertar()
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        'probar con ese if, en caso de que falle, borrarlo y solo dejar lo del else
        If TextBoxAlto.Text < 0 Or TextBoxAncho.Text < 0 Or TextBoxLargo.Text < 0 Or TextBoxCantidad.Text < 0 Or TextBoxPrecio.Text < 0 Then
            MsgBox("Por favor, ingresa un número valido")
        ElseIf String.IsNullOrEmpty(TextBoxAlto.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxAncho.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")

        ElseIf String.IsNullOrEmpty(TextBoxLargo.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxColor.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxCantidad.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxPrecio.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        Else
            Dim command As New MySqlCommand("INSERT INTO venta_especifica(alto, ancho, largo, color, cantidad, precio, productos_fk,venta_general_fk) VALUES(@alto,@ancho,@largo,@color,@cantidad,@precio, @productos_fk,(SELECT MAX(id) FROM venta_general))", cnx)

            command.Parameters.Add("@alto", MySqlDbType.VarChar).Value = TextBoxAlto.Text
            command.Parameters.Add("@ancho", MySqlDbType.VarChar).Value = TextBoxAncho.Text
            command.Parameters.Add("@largo", MySqlDbType.VarChar).Value = TextBoxLargo.Text
            command.Parameters.Add("@color", MySqlDbType.VarChar).Value = TextBoxColor.Text
            command.Parameters.Add("@cantidad", MySqlDbType.VarChar).Value = TextBoxCantidad.Text
            command.Parameters.Add("@precio", MySqlDbType.VarChar).Value = TextBoxPrecio.Text
            command.Parameters.Add("@productos_fk", MySqlDbType.VarChar).Value = CBProducto.SelectedValue
            command.ExecuteNonQuery()
            MsgBox("Pruducto Añadido", MsgBoxStyle.Information, "Confirmacion")
        End If

        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub

    Private Sub insertarnull()
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        Dim cmd As New MySqlCommand("INSERT INTO venta_general(fecha, fecha_b, total, anticipo, clientes_fk, usuarios_fk) VALUES(NULL,NULL,NULL,NULL,NULL,NULL)", cnx)
        cmd.ExecuteNonQuery()


        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub


    Private Sub CBProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProducto.SelectedIndexChanged
        Dim L As String = CBProducto.SelectedValue.ToString
    End Sub

    Private Sub CBCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCliente.SelectedIndexChanged
        Dim H As String = CBCliente.SelectedValue.ToString
    End Sub



    Private Sub updateVG()


        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        If TextBoxTotal.Text < 0 Or TextBoxAnticipo.Text < 0 Then
            MsgBox("Por favor, ingresa un número valido")
        ElseIf String.IsNullOrEmpty(TextBoxTotal.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxAnticipo.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")

        Else
            Dim command As New MySqlCommand("UPDATE venta_general set fecha = @fecha, fecha_b = @fecha_b, total = @total, anticipo = @anticipo, clientes_fk = @clientes_fk, usuarios_fk = @usuarios_fk ORDER BY id DESC LIMIT 1 ", cnx)

            command.Parameters.Add("@fecha", MySqlDbType.VarChar).Value = DTPFechaVenta.Value.Date.ToString("yyyy/MM/dd")
            command.Parameters.Add("@fecha_b", MySqlDbType.VarChar).Value = DTPFecha_Entrega.Value.Date.ToString("yyyy/MM/dd")
            command.Parameters.Add("@total", MySqlDbType.VarChar).Value = TextBoxTotal.Text
            command.Parameters.Add("@anticipo", MySqlDbType.VarChar).Value = TextBoxAnticipo.Text
            command.Parameters.Add("@clientes_fk", MySqlDbType.VarChar).Value = CBCliente.SelectedValue
            command.Parameters.Add("@usuarios_fk", MySqlDbType.VarChar).Value = ejemplo.Text
            command.ExecuteNonQuery()
            MsgBox("Venta Realizada", MsgBoxStyle.Information, "Confirmacion")
            TextBoxTotal.Text = ""
            TextBoxAnticipo.Text = ""

            DGVventa.DataSource = Nothing
            Me.Hide()
        End If


        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Call CargarDatosc()
        Call insertar()
        Call CargarDatos()
        Call CargarDatosTotal()
        DGVventa.Columns("id").Visible = False

        TextBoxAlto.Text = ""
        TextBoxAncho.Text = ""
        TextBoxColor.Text = ""
        TextBoxPrecio.Text = ""
        TextBoxLargo.Text = ""
        TextBoxCantidad.Text = ""

    End Sub

    Private Sub BotonSiguiente_Click(sender As Object, e As EventArgs) Handles BotonSiguiente.Click
        Call updateVG()




    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click


        Call CargarDatos()

        Try
            Dim command As New MySqlCommand(" delete FROM `venta_especifica` WHERE id=@id", cnx)

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = TextBoxid.Text

            cnx.Open()

            If command.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Producto Eliminado")

            Else


                MessageBox.Show("ERROR")

            End If
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Select Case ex.Number
                Case 1451
                    MsgBox("Error, selecciona un empleado a eliminar")

            End Select

        End Try

        Dim datos As New MySqlDataAdapter("SELECT ve.id, cp.descripcion,ve.alto,ve.largo,ve.ancho,ve.color, ve.cantidad, ve.precio 
        From venta_especifica As ve
        Join venta_general As vg
        On vg.id = ve.venta_general_fk
        Join catalogo_productos As cp
        On cp.id = ve.productos_fk
        Where vg.id In(Select MAX(id) from venta_general)", cnx)
        Dim ds As New DataSet()
        datos.Fill(ds, "venta_especifica")

        Me.DGVventa.DataSource = ds.Tables("venta_especifica")
        cnx.Close()
        TextBoxAlto.Text = ""
        TextBoxAncho.Text = ""
        TextBoxColor.Text = ""
        TextBoxPrecio.Text = ""
        TextBoxLargo.Text = ""
        TextBoxCantidad.Text = ""


    End Sub




    Private Sub DGVventa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVventa.CellContentClick
        Dim renglon As Integer
        renglon = DGVventa.CurrentCellAddress.Y
        TextBoxid.Text = DGVventa.Rows(renglon).Cells(0).Value
    End Sub
End Class


