Public Class Respaldo
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        LogIn.Show()
        Me.Hide()
    End Sub
End Class