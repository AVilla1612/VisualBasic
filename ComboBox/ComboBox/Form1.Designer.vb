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
        Me.cmbPersonas = New System.Windows.Forms.ComboBox()
        Me.gbPersona = New System.Windows.Forms.GroupBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNumId = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.gbPersona.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbPersonas
        '
        Me.cmbPersonas.FormattingEnabled = True
        Me.cmbPersonas.Location = New System.Drawing.Point(101, 51)
        Me.cmbPersonas.Name = "cmbPersonas"
        Me.cmbPersonas.Size = New System.Drawing.Size(261, 24)
        Me.cmbPersonas.TabIndex = 0
        '
        'gbPersona
        '
        Me.gbPersona.Controls.Add(Me.btnAgregar)
        Me.gbPersona.Controls.Add(Me.txtTelefono)
        Me.gbPersona.Controls.Add(Me.txtNombre)
        Me.gbPersona.Controls.Add(Me.txtNumId)
        Me.gbPersona.Controls.Add(Me.txtCorreo)
        Me.gbPersona.Controls.Add(Me.lblCorreo)
        Me.gbPersona.Controls.Add(Me.lblNumId)
        Me.gbPersona.Controls.Add(Me.lblTelefono)
        Me.gbPersona.Controls.Add(Me.lblNombre)
        Me.gbPersona.Location = New System.Drawing.Point(12, 12)
        Me.gbPersona.Name = "gbPersona"
        Me.gbPersona.Size = New System.Drawing.Size(486, 252)
        Me.gbPersona.TabIndex = 1
        Me.gbPersona.TabStop = False
        Me.gbPersona.Text = "Ingresar Persona"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(33, 50)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'gbDatos
        '
        Me.gbDatos.Controls.Add(Me.cmbPersonas)
        Me.gbDatos.Location = New System.Drawing.Point(12, 287)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(486, 151)
        Me.gbDatos.TabIndex = 2
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Seleccionar y Mostrar Datos"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(33, 119)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefono.TabIndex = 1
        Me.lblTelefono.Text = "Teléfono"
        '
        'lblNumId
        '
        Me.lblNumId.AutoSize = True
        Me.lblNumId.Location = New System.Drawing.Point(279, 50)
        Me.lblNumId.Name = "lblNumId"
        Me.lblNumId.Size = New System.Drawing.Size(103, 16)
        Me.lblNumId.TabIndex = 2
        Me.lblNumId.Text = "Nº Identificación"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(279, 119)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(118, 16)
        Me.lblCorreo.TabIndex = 3
        Me.lblCorreo.Text = "Correo Electronico"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(282, 138)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(152, 22)
        Me.txtCorreo.TabIndex = 4
        '
        'txtNumId
        '
        Me.txtNumId.Location = New System.Drawing.Point(282, 69)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(152, 22)
        Me.txtNumId.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(36, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 22)
        Me.txtNombre.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(36, 138)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(152, 22)
        Me.txtTelefono.TabIndex = 7
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(139, 190)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(197, 34)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 454)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.gbPersona)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbPersona.ResumeLayout(False)
        Me.gbPersona.PerformLayout()
        Me.gbDatos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbPersonas As Windows.Forms.ComboBox
    Friend WithEvents gbPersona As GroupBox
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblNumId As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnAgregar As Button
End Class
