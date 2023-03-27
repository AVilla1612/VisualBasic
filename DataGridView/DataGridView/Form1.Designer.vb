<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbProductos = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtTotalProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblTotalProducto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblPrecioUnidad = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.gbProductosAgregados = New System.Windows.Forms.GroupBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.gbTotales = New System.Windows.Forms.GroupBox()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.codigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbProductos.SuspendLayout()
        Me.gbProductosAgregados.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProductos
        '
        Me.gbProductos.Controls.Add(Me.btnAgregar)
        Me.gbProductos.Controls.Add(Me.txtTotalProducto)
        Me.gbProductos.Controls.Add(Me.txtCantidad)
        Me.gbProductos.Controls.Add(Me.txtPrecio)
        Me.gbProductos.Controls.Add(Me.txtDescrip)
        Me.gbProductos.Controls.Add(Me.txtCodigo)
        Me.gbProductos.Controls.Add(Me.lblTotalProducto)
        Me.gbProductos.Controls.Add(Me.lblCantidad)
        Me.gbProductos.Controls.Add(Me.lblPrecioUnidad)
        Me.gbProductos.Controls.Add(Me.lblDescripcion)
        Me.gbProductos.Controls.Add(Me.lblCodigo)
        Me.gbProductos.Location = New System.Drawing.Point(12, 12)
        Me.gbProductos.Name = "gbProductos"
        Me.gbProductos.Size = New System.Drawing.Size(777, 160)
        Me.gbProductos.TabIndex = 0
        Me.gbProductos.TabStop = False
        Me.gbProductos.Text = "Agregar Productos"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(20, 112)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(86, 29)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtTotalProducto
        '
        Me.txtTotalProducto.Location = New System.Drawing.Point(620, 66)
        Me.txtTotalProducto.Name = "txtTotalProducto"
        Me.txtTotalProducto.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalProducto.TabIndex = 9
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(472, 66)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 8
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(307, 66)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 22)
        Me.txtPrecio.TabIndex = 7
        '
        'txtDescrip
        '
        Me.txtDescrip.Location = New System.Drawing.Point(161, 66)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(100, 22)
        Me.txtDescrip.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(20, 66)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.txtCodigo.TabIndex = 5
        '
        'lblTotalProducto
        '
        Me.lblTotalProducto.AutoSize = True
        Me.lblTotalProducto.Location = New System.Drawing.Point(617, 35)
        Me.lblTotalProducto.Name = "lblTotalProducto"
        Me.lblTotalProducto.Size = New System.Drawing.Size(38, 16)
        Me.lblTotalProducto.TabIndex = 4
        Me.lblTotalProducto.Text = "Total"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(469, 35)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(61, 16)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblPrecioUnidad
        '
        Me.lblPrecioUnidad.AutoSize = True
        Me.lblPrecioUnidad.Location = New System.Drawing.Point(304, 35)
        Me.lblPrecioUnidad.Name = "lblPrecioUnidad"
        Me.lblPrecioUnidad.Size = New System.Drawing.Size(60, 16)
        Me.lblPrecioUnidad.TabIndex = 2
        Me.lblPrecioUnidad.Text = "Precio/U"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(158, 35)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(79, 16)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(17, 35)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
        '
        'gbProductosAgregados
        '
        Me.gbProductosAgregados.Controls.Add(Me.dgvProductos)
        Me.gbProductosAgregados.Location = New System.Drawing.Point(12, 178)
        Me.gbProductosAgregados.Name = "gbProductosAgregados"
        Me.gbProductosAgregados.Size = New System.Drawing.Size(777, 219)
        Me.gbProductosAgregados.TabIndex = 1
        Me.gbProductosAgregados.TabStop = False
        Me.gbProductosAgregados.Text = "Productos Agregados"
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoProducto, Me.desProducto, Me.precioUnidad, Me.cantidadProducto, Me.totalProducto})
        Me.dgvProductos.Location = New System.Drawing.Point(20, 36)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.Size = New System.Drawing.Size(733, 153)
        Me.dgvProductos.TabIndex = 0
        '
        'gbTotales
        '
        Me.gbTotales.Controls.Add(Me.btnTotal)
        Me.gbTotales.Controls.Add(Me.txtTotal)
        Me.gbTotales.Controls.Add(Me.txtIva)
        Me.gbTotales.Controls.Add(Me.txtSubTotal)
        Me.gbTotales.Controls.Add(Me.lblTotal)
        Me.gbTotales.Controls.Add(Me.lblIva)
        Me.gbTotales.Controls.Add(Me.lblSubTotal)
        Me.gbTotales.Location = New System.Drawing.Point(12, 403)
        Me.gbTotales.Name = "gbTotales"
        Me.gbTotales.Size = New System.Drawing.Size(777, 173)
        Me.gbTotales.TabIndex = 1
        Me.gbTotales.TabStop = False
        Me.gbTotales.Text = "Totales"
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(20, 115)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(100, 37)
        Me.btnTotal.TabIndex = 11
        Me.btnTotal.Text = "Ver Totales"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(555, 66)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTotal.TabIndex = 12
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(339, 66)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(100, 22)
        Me.txtIva.TabIndex = 11
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Location = New System.Drawing.Point(137, 66)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtSubTotal.TabIndex = 10
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(582, 36)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(365, 36)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(57, 16)
        Me.lblIva.TabIndex = 6
        Me.lblIva.Text = "IVA 19%"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(158, 36)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(62, 16)
        Me.lblSubTotal.TabIndex = 5
        Me.lblSubTotal.Text = "SubTotal"
        '
        'codigoProducto
        '
        Me.codigoProducto.HeaderText = "Código"
        Me.codigoProducto.MinimumWidth = 6
        Me.codigoProducto.Name = "codigoProducto"
        Me.codigoProducto.ReadOnly = True
        Me.codigoProducto.Width = 125
        '
        'desProducto
        '
        Me.desProducto.HeaderText = "Descripción"
        Me.desProducto.MinimumWidth = 6
        Me.desProducto.Name = "desProducto"
        Me.desProducto.ReadOnly = True
        Me.desProducto.Width = 180
        '
        'precioUnidad
        '
        Me.precioUnidad.HeaderText = "Precio/U"
        Me.precioUnidad.MinimumWidth = 6
        Me.precioUnidad.Name = "precioUnidad"
        Me.precioUnidad.ReadOnly = True
        Me.precioUnidad.Width = 125
        '
        'cantidadProducto
        '
        Me.cantidadProducto.HeaderText = "Cantidad"
        Me.cantidadProducto.MinimumWidth = 6
        Me.cantidadProducto.Name = "cantidadProducto"
        Me.cantidadProducto.ReadOnly = True
        Me.cantidadProducto.Width = 125
        '
        'totalProducto
        '
        Me.totalProducto.HeaderText = "Total"
        Me.totalProducto.MinimumWidth = 6
        Me.totalProducto.Name = "totalProducto"
        Me.totalProducto.ReadOnly = True
        Me.totalProducto.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 573)
        Me.Controls.Add(Me.gbTotales)
        Me.Controls.Add(Me.gbProductosAgregados)
        Me.Controls.Add(Me.gbProductos)
        Me.Name = "Form1"
        Me.Text = "Venta Productos"
        Me.gbProductos.ResumeLayout(False)
        Me.gbProductos.PerformLayout()
        Me.gbProductosAgregados.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTotales.ResumeLayout(False)
        Me.gbTotales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbProductos As GroupBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents gbProductosAgregados As GroupBox
    Friend WithEvents gbTotales As GroupBox
    Friend WithEvents lblTotalProducto As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblPrecioUnidad As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtTotalProducto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents dgvProductos As Windows.Forms.DataGridView
    Friend WithEvents btnTotal As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents codigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents desProducto As DataGridViewTextBoxColumn
    Friend WithEvents precioUnidad As DataGridViewTextBoxColumn
    Friend WithEvents cantidadProducto As DataGridViewTextBoxColumn
    Friend WithEvents totalProducto As DataGridViewTextBoxColumn
End Class
