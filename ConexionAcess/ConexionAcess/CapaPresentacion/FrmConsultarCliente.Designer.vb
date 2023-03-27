<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultarCliente
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
        Me.gbDatosConsulta = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblClienteId = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblNumId = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtClienteId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.gbDatosConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatosConsulta
        '
        Me.gbDatosConsulta.Controls.Add(Me.txtTelefono)
        Me.gbDatosConsulta.Controls.Add(Me.txtNumId)
        Me.gbDatosConsulta.Controls.Add(Me.txtNombre)
        Me.gbDatosConsulta.Controls.Add(Me.txtClienteId)
        Me.gbDatosConsulta.Controls.Add(Me.lblTelefono)
        Me.gbDatosConsulta.Controls.Add(Me.lblNumId)
        Me.gbDatosConsulta.Controls.Add(Me.lblNombre)
        Me.gbDatosConsulta.Controls.Add(Me.lblClienteId)
        Me.gbDatosConsulta.Controls.Add(Me.btnNuevo)
        Me.gbDatosConsulta.Controls.Add(Me.btnConsultar)
        Me.gbDatosConsulta.Location = New System.Drawing.Point(12, 12)
        Me.gbDatosConsulta.Name = "gbDatosConsulta"
        Me.gbDatosConsulta.Size = New System.Drawing.Size(786, 224)
        Me.gbDatosConsulta.TabIndex = 0
        Me.gbDatosConsulta.TabStop = False
        Me.gbDatosConsulta.Text = "Datos de la Consulta"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(120, 135)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(176, 46)
        Me.btnConsultar.TabIndex = 0
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(460, 135)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(176, 46)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'lblClienteId
        '
        Me.lblClienteId.AutoSize = True
        Me.lblClienteId.Location = New System.Drawing.Point(38, 42)
        Me.lblClienteId.Name = "lblClienteId"
        Me.lblClienteId.Size = New System.Drawing.Size(62, 16)
        Me.lblClienteId.TabIndex = 2
        Me.lblClienteId.Text = "Id Cliente"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(227, 42)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 16)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'lblNumId
        '
        Me.lblNumId.AutoSize = True
        Me.lblNumId.Location = New System.Drawing.Point(402, 42)
        Me.lblNumId.Name = "lblNumId"
        Me.lblNumId.Size = New System.Drawing.Size(155, 16)
        Me.lblNumId.TabIndex = 4
        Me.lblNumId.Text = "Número de Identificación"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(587, 42)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Teléfono"
        '
        'txtClienteId
        '
        Me.txtClienteId.Location = New System.Drawing.Point(41, 72)
        Me.txtClienteId.Name = "txtClienteId"
        Me.txtClienteId.Size = New System.Drawing.Size(141, 22)
        Me.txtClienteId.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(230, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(141, 22)
        Me.txtNombre.TabIndex = 7
        '
        'txtNumId
        '
        Me.txtNumId.Location = New System.Drawing.Point(405, 72)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(141, 22)
        Me.txtNumId.TabIndex = 8
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(590, 72)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(141, 22)
        Me.txtTelefono.TabIndex = 9
        '
        'FrmConsultarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 249)
        Me.Controls.Add(Me.gbDatosConsulta)
        Me.Name = "FrmConsultarCliente"
        Me.Text = "FrmConsultarCliente"
        Me.gbDatosConsulta.ResumeLayout(False)
        Me.gbDatosConsulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDatosConsulta As GroupBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtClienteId As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNumId As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblClienteId As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnConsultar As Button
End Class
