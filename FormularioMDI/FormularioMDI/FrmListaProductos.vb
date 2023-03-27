Public Class FrmListaProductos
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim frmV As FrmVentas = FrmVentas.getInstancia

        Dim producto As String = ListBox1.SelectedItem.ToString

        frmV.insertarDatos(producto)

        Me.Close()

    End Sub
End Class