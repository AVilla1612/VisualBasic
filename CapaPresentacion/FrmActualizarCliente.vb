Public Class FrmActualizarCliente
    Private Sub txtNumIdA_LostFocus(sender As Object, e As EventArgs) Handles txtNumIdA.LostFocus

        Try

            Dim lc As New LClientes

            Dim dt As DataTable = lc.consultarCliente(txtNumIdA.Text)

            Dim dr As DataRow = dt.Rows(0)

            txtIdClienteA.Text = dr("ID_CLIENTE")
            txtNombreA.Text = dr("NOMBRE")
            txtTelefonoA.Text = dr("TELEFONO")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Dim lc As New LClientes

        Try

            lc.actulizarCliente(txtNombreA.Text, txtNumIdA.Text, txtTelefonoA.Text)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub



    Private Sub FrmActualizarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdClienteA.Enabled = False

    End Sub
End Class