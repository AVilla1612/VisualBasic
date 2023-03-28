Public Class FrmConsultarCliente
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        Try

            Dim lc As New LClientes

            Dim dt As DataTable = lc.consultarCliente(txtNumId.Text)

            Dim dr As DataRow = dt.Rows.Item(0)

            txtClienteId.Text = dr.Item("ID_CLIENTE")
            txtNombre.Text = dr.Item("NOMBRE")
            txtTelefono.Text = dr.Item("TELEFONO")

        Catch ex As Exception

            MsgBox("El cliente ingresado no existe")

        End Try

    End Sub

    Private Sub FrmConsultarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtClienteId.Enabled = False
        txtNombre.Enabled = False
        txtTelefono.Enabled = False


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtClienteId.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()

    End Sub


End Class