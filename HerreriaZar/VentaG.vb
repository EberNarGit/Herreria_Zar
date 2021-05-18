Imports MySql.Data.MySqlClient
Public Class VentaG
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub VentaG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Hoy es " & Today

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

    Private Sub CBProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProducto.SelectedIndexChanged
        Dim L As String = CBProducto.SelectedValue.ToString
    End Sub

    Private Sub CBCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCliente.SelectedIndexChanged
        Dim H As String = CBCliente.SelectedValue.ToString
    End Sub

    Private Sub CBEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEmpleado.SelectedIndexChanged
        Dim G As String = CBEmpleado.SelectedValue.ToString
    End Sub


End Class


