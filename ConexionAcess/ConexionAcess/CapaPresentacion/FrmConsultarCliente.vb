Public Class FrmConsultarCliente
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try

            Dim lc As New LClientes

            Dim c() As String = lc.consultarCliente(txtNumId.Text)

            txtClienteId.Text = c(0)
            txtNombre.Text = c(1)
            txtTelefono.Text = c(2)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtClienteId.Clear()
        txtNombre.Clear()
        txtNumId.Clear()
        txtTelefono.Clear()

    End Sub
End Class