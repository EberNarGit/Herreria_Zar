Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AñadirProducto
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd = Eber844@")

    Private Sub ButtonSelect_img_Click(sender As Object, e As EventArgs) Handles ButtonSelect_img.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub CargarDatos()
        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd = Eber844@")


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

    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        CargarDatos()

        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        TextBoxid.Text = Module1.usuario

        Dim command As New MySqlCommand("INSERT INTO `catalogo_productos`(`imagen`, `descripcion`, `usuarios_fk`, `categorias_fk`) VALUES (@img,@ds,@us,@ct)", cnx)

        command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()
        command.Parameters.Add("@ds", MySqlDbType.VarChar).Value = TextBoxDescripción.Text
        command.Parameters.Add("@us", MySqlDbType.VarChar).Value = ejemplo.Text
        command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = ComboBoxCategoria.SelectedValue


        cnx.Open()

        Try
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Producto Añadido")

            Else
                MessageBox.Show("No se pudo agregar el producto, intenta de nuevo")
            End If
        Catch ex As MySQL.Data.MySqlClient.MySqlException
            MsgBox("Error, uno de los campos excede el límite de caracteres")
            TextBoxDescripción.Text = ""
        End Try
        cnx.Close()

    End Sub

    Private Sub ComboBoxUsuario_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AñadirProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxid.Text = Module1.usuario



        Dim adapter1 As New MySqlDataAdapter("SELECT `id`, `descripcion` FROM categoria", cnx)
        Dim table1 As New DataTable()

        adapter1.Fill(table1)

        ComboBoxCategoria.DataSource = table1

        ComboBoxCategoria.ValueMember = "id"
        ComboBoxCategoria.DisplayMember = "descripcion"
    End Sub

    Private Sub TextBoxid_TextChanged(sender As Object, e As EventArgs) Handles TextBoxid.TextChanged

    End Sub

    Private Sub ejemplo_TextChanged(sender As Object, e As EventArgs) Handles ejemplo.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class