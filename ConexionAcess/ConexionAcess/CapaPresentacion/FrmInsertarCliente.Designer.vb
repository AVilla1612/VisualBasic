<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsertarCliente
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
        Me.gbDatosCliente = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNumId = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.gbDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosCliente
        '
        Me.gbDatosCliente.Controls.Add(Me.btnInsertar)
        Me.gbDatosCliente.Controls.Add(Me.txtTelefono)
        Me.gbDatosCliente.Controls.Add(Me.txtNumId)
        Me.gbDatosCliente.Controls.Add(Me.txtNombre)
        Me.gbDatosCliente.Controls.Add(Me.lblTelefono)
        Me.gbDatosCliente.Controls.Add(Me.lblNumId)
        Me.gbDatosCliente.Controls.Add(Me.lblNombre)
        Me.gbDatosCliente.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosCliente.Name = "gbDatosCliente"
        Me.gbDatosCliente.Size = New System.Drawing.Size(448, 253)
        Me.gbDatosCliente.TabIndex = 0
        Me.gbDatosCliente.TabStop = False
        Me.gbDatosCliente.Text = "Datos del Cliente"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(115, 42)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblNumId
        '
        Me.lblNumId.AutoSize = True
        Me.lblNumId.Location = New System.Drawing.Point(115, 85)
        Me.lblNumId.Name = "lblNumId"
        Me.lblNumId.Size = New System.Drawing.Size(122, 16)
        Me.lblNumId.TabIndex = 1
        Me.lblNumId.Text = "Nº de Identificación"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(115, 126)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefono.TabIndex = 2
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(273, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 22)
        Me.txtNombre.TabIndex = 3
        '
        'txtNumId
        '
        Me.txtNumId.Location = New System.Drawing.Point(273, 79)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(143, 22)
        Me.txtNumId.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(273, 120)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(143, 22)
        Me.txtTelefono.TabIndex = 5
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(233, 179)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(183, 41)
        Me.btnInsertar.TabIndex = 6
        Me.btnInsertar.Text = "Insertar Cliente"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'FrmInsertarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 277)
        Me.Controls.Add(Me.gbDatosCliente)
        Me.Name = "FrmInsertarCliente"
        Me.Text = "FrmInsertarCliente"
        Me.gbDatosCliente.ResumeLayout(False)
        Me.gbDatosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosCliente As GroupBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNumId As Label
    Friend WithEvents lblNombre As Label
End Class
