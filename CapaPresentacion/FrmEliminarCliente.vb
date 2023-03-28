Public Class FrmEliminarCliente
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try

            Dim lc As New LClientes

            lc.eliminarCliente(txtNumIdE.Text)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txtNumIdE_LostFocus(sender As Object, e As EventArgs) Handles txtNumIdE.LostFocus

        Try

            Dim lc As New LClientes

            Dim dt As DataTable = lc.consultarCliente(txtNumIdE.Text)

            Dim dr As DataRow = dt.Rows(0)

            txtIdClienteE.Text = dr("ID_CLIENTE")
            txtNombreE.Text = dr("NOMBRE")
            txtTelefonoE.Text = dr("TELEFONO")

        Catch ex As Exception

            MsgBox("Cliente NO registado")

        End Try

    End Sub

    Private Sub FrmEliminarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtIdClienteE.Enabled = False
        txtNombreE.Enabled = False
        txtTelefonoE.Enabled = False

    End Sub
End Class