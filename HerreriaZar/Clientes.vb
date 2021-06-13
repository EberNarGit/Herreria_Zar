Imports MySql.Data.MySqlClient

Public Class Clientes
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick
        Dim renglon As Integer
        'Al darle clic al renglón mostramos los datos en las cajas de texto
        Try
            renglon = DGVClientes.CurrentCellAddress.Y
            TextBoxNombre.Text = DGVClientes.Rows(renglon).Cells(1).Value
            TextBoxPaterno.Text = DGVClientes.Rows(renglon).Cells(2).Value
            TextBoxMaterno.Text = DGVClientes.Rows(renglon).Cells(3).Value
            TextBoxRFC.Text = DGVClientes.Rows(renglon).Cells(4).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarDatos()
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")


        Dim lista As Byte
        Dim datos As New MySqlDataAdapter("select id 
from usuarios 
where usuario = '" & TextBoxid.Text & "'", cnx)
        Dim ds As New DataSet()
        datos.Fill(ds, "usuarios")

        lista = ds.Tables("usuarios").Rows.Count
        Try
            ejemplo.Text = ds.Tables("usuarios").Rows(0).Item("id")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxid.Text = Module1.usuario
        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, RFC FROM `catalogo_clientes`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVClientes.DataSource = dt
        cnx.Close()

        TextBoxNombre.Text = ""
        TextBoxPaterno.Text = ""
        TextBoxMaterno.Text = ""
        TextBoxTelefono.Text = ""
        TextBoxCorreo.Text = ""
        TextBoxRFC.Text = ""

    End Sub

    Private Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click
        CargarDatos()

        Dim lines() As String
        lines = TextBoxTelefono.Lines
        For Each line As String In TextBoxTelefono.Lines
            ' Protect against strings that do not have a first letter to check
            If line.Length >= 1 Then
                Dim firstLetter As Char = line.Substring(0, 1)

                If firstLetter = "-" Then
                    MessageBox.Show("No se acepta ese caracter al principio")
                End If
            End If
        Next

        If String.IsNullOrEmpty(TextBoxRFC.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")

        ElseIf String.IsNullOrEmpty(TextBoxNombre.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxPaterno.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxMaterno.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")

        ElseIf String.IsNullOrEmpty(TextBoxCorreo.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxTelefono.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        Else
            Try
                Dim command As New MySqlCommand("INSERT INTO `catalogo_clientes`(`nombre`, `paterno`, `materno`, `correo`, `telefono`, `RFC`, `usuarios_fk`) VALUES (@nombre,@paterno,@materno,@correo,@telefono,@RFC, @fkusuario)", cnx)



                command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = TextBoxNombre.Text
                command.Parameters.Add("@paterno", MySqlDbType.VarChar).Value = TextBoxPaterno.Text
                command.Parameters.Add("@materno", MySqlDbType.VarChar).Value = TextBoxMaterno.Text
                command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = TextBoxCorreo.Text
                command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = TextBoxTelefono.Text
                command.Parameters.Add("@RFC", MySqlDbType.VarChar).Value = TextBoxRFC.Text
                command.Parameters.Add("@fkusuario", MySqlDbType.VarChar).Value = ejemplo.Text

                cnx.Open()

                If command.ExecuteNonQuery() = 1 Then  ''Field 'usuarios_fk' doesn't have a default value'
                    '

                    MessageBox.Show("Cliente Añadido")

                Else

                    MessageBox.Show("ERROR")

                End If
            Catch ex As MySql.Data.MySqlClient.MySqlException
                Select Case ex.Number
                    Case 1406
                        MsgBox("Error, uno de los campos excede el límite de caracteres")
                    Case 1062
                        MsgBox("No se puede añadir, RFC duplicado")
                End Select

            End Try
            'Catch ex As Exception
            '   MsgBox("No se puede añadir, RFC duplicado")
            ' End Try


            Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, RFC FROM `catalogo_clientes`", cnx)

            Dim dt As DataTable = New DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

            da.Fill(dt)
            DGVClientes.DataSource = dt
            cnx.Close()
            TextBoxNombre.Text = ""
            TextBoxPaterno.Text = ""
            TextBoxMaterno.Text = ""
            TextBoxTelefono.Text = ""
            TextBoxCorreo.Text = ""
            TextBoxRFC.Text = ""


        End If
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        cnx.Open()

        If String.IsNullOrEmpty(TextBoxRFC.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")

        ElseIf String.IsNullOrEmpty(TextBoxPaterno.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxMaterno.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")

        ElseIf String.IsNullOrEmpty(TextBoxCorreo.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        ElseIf String.IsNullOrEmpty(TextBoxTelefono.Text) Then
            ' "Contains Empty value or Null Value" 
            MessageBox.Show("Los campos están vacios, verificar información")
        Else

            Try
                Dim command As New MySqlCommand("UPDATE  `catalogo_clientes` SET  paterno=@paterno, materno=@materno, correo=@correo, telefono=@telefono, RFC=@RFC WHERE nombre=@nombre;", cnx)
                'Poder modificar todo
                command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = TextBoxNombre.Text
                command.Parameters.Add("@paterno", MySqlDbType.VarChar).Value = TextBoxPaterno.Text
                command.Parameters.Add("@materno", MySqlDbType.VarChar).Value = TextBoxMaterno.Text
                command.Parameters.Add("@correo", MySqlDbType.VarChar).Value = TextBoxCorreo.Text
                command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = TextBoxTelefono.Text
                command.Parameters.Add("@RFC", MySqlDbType.VarChar).Value = TextBoxRFC.Text

                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                Select Case ex.Number
                    Case 1406
                        MsgBox("Error, uno de los campos excede el límite de caracteres")
                    Case 1062
                        MsgBox("No se puede modificar, RFC duplicado")
                End Select

            End Try
        End If



        Dim comman As New MySqlCommand("SELECT id,nombre, paterno, materno, RFC FROM `catalogo_clientes`", cnx)

        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comman)

        da.Fill(dt)
        DGVClientes.DataSource = dt
        cnx.Close()

        TextBoxNombre.Text = ""
        TextBoxPaterno.Text = ""
        TextBoxMaterno.Text = ""
        TextBoxTelefono.Text = ""
        TextBoxCorreo.Text = ""
        TextBoxRFC.Text = ""

    End Sub

    Private Sub ComboBoxCliente_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxid_TextChanged(sender As Object, e As EventArgs) Handles TextBoxid.TextChanged

    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub
End Class