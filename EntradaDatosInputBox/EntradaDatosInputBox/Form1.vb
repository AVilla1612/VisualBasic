Public Class Form1

    Private numero1 As Integer
    Private numero2 As Integer

    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnIngresarDatos.Click

        numero1 = Integer.Parse(InputBox("Ingrese el primer número", "Suma de dos números", "0", 700, 300))
        numero2 = Integer.Parse(InputBox("Ingrese el segundo número", "Suma de dos números", "0", 700, 300))

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim resultado As Integer = numero1 + numero2
        txtResultado.Text = resultado.ToString

    End Sub
End Class
