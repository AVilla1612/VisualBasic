Public Class FrmInsertarCliente
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click

        Try

            If txtNombre.Text <> "" And txtNumId.Text <> "" And txtTelefono.Text <> "" Then

                Dim lc As New LClientes()
                lc.insertarCliente(txtNombre.Text, txtNumId.Text, txtTelefono.Text)

                limpiarCampos()

            Else

                MsgBox("No se puede insertar el cliente debido a que faltan datos")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub limpiarCampos()

        txtNombre.Clear()
        txtNumId.Clear()
        txtTelefono.Clear()

    End Sub
End Class