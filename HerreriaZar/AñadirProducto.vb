﻿Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AñadirProducto
    Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")

    Private Sub ButtonSelect_img_Click(sender As Object, e As EventArgs) Handles ButtonSelect_img.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If
    End Sub


    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

        Dim command As New MySqlCommand("INSERT INTO `catalogo_productos`(`imagen`, `descripcion`, `usuarios_fk`, `categorias_fk`) VALUES (@img,@ds,@us,@ct)", cnx)

        command.Parameters.Add("@img", MySqlDbType.Blob).Value = ms.ToArray()
        command.Parameters.Add("@ds", MySqlDbType.VarChar).Value = TextBoxDescripción.Text
        command.Parameters.Add("@us", MySqlDbType.VarChar).Value = ComboBoxUsuario.SelectedValue
        command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = ComboBoxCategoria.SelectedValue


        cnx.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Producto Añadido")

        Else
            MessageBox.Show("No se pudo agregar el producto, intenta de nuevo")
        End If

        cnx.Close()

    End Sub

    Private Sub ComboBoxUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUsuario.SelectedIndexChanged

    End Sub

    Private Sub AñadirProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim cnx As New MySqlConnection("Server = localhost; Database = herreriazar; Uid = root; Pwd =zP8HlxqCBwCFHcHz")
        Dim adapter As New MySqlDataAdapter("SELECT `id`, `usuario` FROM usuarios", cnx)
        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBoxUsuario.DataSource = table

        ComboBoxUsuario.ValueMember = "id"
        ComboBoxUsuario.DisplayMember = "usuario"

        Dim adapter1 As New MySqlDataAdapter("SELECT `id`, `descripcion` FROM categoria", cnx)
        Dim table1 As New DataTable()

        adapter1.Fill(table1)

        ComboBoxCategoria.DataSource = table1

        ComboBoxCategoria.ValueMember = "id"
        ComboBoxCategoria.DisplayMember = "descripcion"
    End Sub
End Class