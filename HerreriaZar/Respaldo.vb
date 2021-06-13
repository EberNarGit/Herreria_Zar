Imports MySql.Data.MySqlClient

Public Class Respaldo
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        LogIn.Show()
        MsgBox("Nos vemos pronto :)")
        Me.Hide()

    End Sub



    Private Sub Respaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Text = Module1.usuario
    End Sub
End Class