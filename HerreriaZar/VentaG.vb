Imports MySql.Data.MySqlClient
Public Class VentaG
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub VentaG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Hoy es " & Today
        Call insertarnull()


        DGVventa.ReadOnly = True

        Try
            cargarcomboproducto()
            cargarcombocliente()
            cargarcomboempleado()
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

    Public Sub cargarcomboempleado()
        Dim dt As New DataTable
        Dim con As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =Eber844@")
        Dim consulta As String = "SELECT id, nombre FROM usuarios"
        Dim comando As New MySqlDataAdapter(consulta, con)
        comando.Fill(dt)

        CBEmpleado.DataSource = dt
        CBEmpleado.DisplayMember = "nombre"
        CBEmpleado.ValueMember = "id"

    End Sub

    Private Sub CargarDatos()
        Dim datos As New MySqlDataAdapter("SELECT cp.descripcion,ve.alto,ve.largo,ve.ancho,ve.color, ve.cantidad, ve.precio 
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

    Private Sub insertar()
        If cnx.state = ConnectionState.Closed Then
            cnx.Open
        End If

        Dim cmd As New MySqlCommand("INSERT INTO venta_especifica(alto, ancho, largo, color, cantidad, precio, productos_fk,venta_general_fk) VALUES(" & Me.TextBoxAlto.Text & "," & Me.TextBoxAncho.Text & "," & Me.TextBoxLargo.Text & ",'" & TextBoxColor.Text & "'," & TextBoxCantidad.Text & "," & TextBoxPrecio.Text & "," & CBProducto.SelectedValue & ",(SELECT MAX(id) FROM venta_general))", cnx)
        cmd.ExecuteNonQuery()
        MsgBox("Prudocto Añadido", MsgBoxStyle.Information, "Confirmacion")

        If cnx.State = ConnectionState.Open Then
            cnx.Close
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

    Private Sub CBEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpleado.SelectedIndexChanged
        Dim G As String = CBEmpleado.SelectedValue.ToString
    End Sub

    Private Sub updateVG()
        Dim F As String = DTPFechaVenta.Value.Date.ToString("yyyy/MM/dd")
        Dim L As String = DTPFecha_Entrega.Value.Date.ToString("yyyy/MM/dd")

        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        Dim cmd As New MySqlCommand("UPDATE venta_general set fecha ='" & DTPFechaVenta.Value.Date.ToString("yyyy/MM/dd") & "',fecha_b = '" & DTPFecha_Entrega.Value.Date.ToString("yyyy/MM/dd") & "', total = '" & Me.TextBoxTotal.Text & "', anticipo ='" & TextBoxAnticipo.Text & "', clientes_fk ='" & CBCliente.SelectedValue & "', usuarios_fk ='" & CBEmpleado.SelectedValue & "'ORDER BY id DESC LIMIT 1;", cnx)
        cmd.ExecuteNonQuery()
        MsgBox("Venta Realizada", MsgBoxStyle.Information, "Confirmacion")

        If cnx.State = ConnectionState.Open Then
            cnx.Close()
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Call insertar()
        Call CargarDatos()
    End Sub

    Private Sub BotonSiguiente_Click(sender As Object, e As EventArgs) Handles BotonSiguiente.Click
        Call updateVG()
        Me.Hide()

    End Sub
End Class


