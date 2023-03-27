Public Class FrmVentas

    Public Shared existeInstancia As FrmVentas

    Public Function getInstancia() As FrmVentas

        If existeInstancia Is Nothing Then

            existeInstancia = New FrmVentas

            Return existeInstancia

        Else

            Return existeInstancia

        End If

    End Function

    Public Sub insertarDatos(productos As String)

        TextBox1.Text = productos

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frmListaP As New FrmListaProductos

        frmListaP.ShowDialog()

    End Sub

    Private Sub FrmVentas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        existeInstancia = Nothing

    End Sub
End Class