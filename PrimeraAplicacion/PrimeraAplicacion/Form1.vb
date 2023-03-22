Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("Primera Interfaz Gráfica de Usuario")

    End Sub

    Private Sub btnMostrarMensaje_Click(sender As Object, e As EventArgs) Handles btnMostrarMensaje.Click

        Dim nombre As String = txtNombre.Text

        lblMostrarMensaje.Text = " Hola , " & nombre

    End Sub


End Class
