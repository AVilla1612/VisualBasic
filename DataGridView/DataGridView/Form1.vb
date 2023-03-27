Public Class Form1

    Dim listaProductos As New List(Of Producto)

    Private Sub VentaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listaProductos.Add(New Producto("ARROZ X 500GR", 20))
        listaProductos.Add(New Producto("ACEITE X 1000ML", 36))
        listaProductos.Add(New Producto("ATÚN CALVO X 6LATAS", 75))
        listaProductos.Add(New Producto("TOMATE FRITO SOLIS", 246))

        DesactivaTextBox()



        Dim codigo As New DataGridViewColumn

        'codigo.HeaderText = "Código"
        'codigo.CellTemplate = New DataGridViewTextBoxCell
        'dgvProductos.Columns.Add(codigo)

    End Sub

    Private Sub LimpiarTextBox()

        txtCodigo.Clear()
        txtDescrip.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtTotalProducto.Clear()

    End Sub

    Private Sub txtCantidad_LostFocus(sender As Object, e As EventArgs) Handles txtCantidad.LostFocus

        If txtCantidad.Text <> "" And Val(txtCantidad.Text) > 0 Then

            Dim total As Double = Val(txtPrecio.Text) * Val(txtCantidad.Text)

            txtTotalProducto.Text = total.ToString

        End If

    End Sub

    Private Sub DesactivaTextBox()

        txtDescrip.Enabled = False
        txtPrecio.Enabled = False
        txtTotalProducto.Enabled = False

    End Sub

    Private Sub txtCodigo_LostFocus(sender As Object, e As EventArgs) Handles txtCodigo.LostFocus

        Try

            Dim codigo As String = txtCodigo.Text.ToUpper

            For i = 0 To listaProductos.Count - 1 Step 1

                If codigo.Equals(listaProductos.Item(i).Codigo_Producto) Then

                    txtDescrip.Text = listaProductos.Item(i).Descripcion_Producto
                    txtPrecio.Text = listaProductos.Item(i).PrecioU_Producto

                    Exit For

                End If

            Next


        Catch ex As Exception

            MsgBox("El código ingresado no existe")

        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        dgvProductos.Rows.Add(txtCodigo.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text, txtTotalProducto.Text)

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        Dim total As Double = 0

        For i = 0 To dgvProductos.Rows.Count - 1 Step 1

            total += dgvProductos.Rows.Item(i).Cells.Item(4).Value

        Next

        Dim subTotal As Double = total - (total * 0.19)
        Dim iva As Double = total * 0.19

        txtSubTotal.Text = subTotal.ToString
        txtIva.Text = iva.ToString
        txtTotal.Text = total.ToString

    End Sub
End Class
