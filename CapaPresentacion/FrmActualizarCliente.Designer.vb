<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarCliente
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
        Me.txtIdClienteA = New System.Windows.Forms.TextBox()
        Me.txtNombreA = New System.Windows.Forms.TextBox()
        Me.txtNumIdA = New System.Windows.Forms.TextBox()
        Me.txtTelefonoA = New System.Windows.Forms.TextBox()
        Me.lblClienteIdA = New System.Windows.Forms.Label()
        Me.lblNombreA = New System.Windows.Forms.Label()
        Me.lblNumIdA = New System.Windows.Forms.Label()
        Me.lblTelefonoA = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnNuevoA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIdClienteA
        '
        Me.txtIdClienteA.Location = New System.Drawing.Point(252, 54)
        Me.txtIdClienteA.Name = "txtIdClienteA"
        Me.txtIdClienteA.Size = New System.Drawing.Size(138, 22)
        Me.txtIdClienteA.TabIndex = 0
        '
        'txtNombreA
        '
        Me.txtNombreA.Location = New System.Drawing.Point(252, 117)
        Me.txtNombreA.Name = "txtNombreA"
        Me.txtNombreA.Size = New System.Drawing.Size(138, 22)
        Me.txtNombreA.TabIndex = 1
        '
        'txtNumIdA
        '
        Me.txtNumIdA.Location = New System.Drawing.Point(252, 184)
        Me.txtNumIdA.Name = "txtNumIdA"
        Me.txtNumIdA.Size = New System.Drawing.Size(138, 22)
        Me.txtNumIdA.TabIndex = 2
        '
        'txtTelefonoA
        '
        Me.txtTelefonoA.Location = New System.Drawing.Point(252, 254)
        Me.txtTelefonoA.Name = "txtTelefonoA"
        Me.txtTelefonoA.Size = New System.Drawing.Size(138, 22)
        Me.txtTelefonoA.TabIndex = 3
        '
        'lblClienteIdA
        '
        Me.lblClienteIdA.AutoSize = True
        Me.lblClienteIdA.Location = New System.Drawing.Point(105, 60)
        Me.lblClienteIdA.Name = "lblClienteIdA"
        Me.lblClienteIdA.Size = New System.Drawing.Size(62, 16)
        Me.lblClienteIdA.TabIndex = 4
        Me.lblClienteIdA.Text = "Id Cliente"
        '
        'lblNombreA
        '
        Me.lblNombreA.AutoSize = True
        Me.lblNombreA.Location = New System.Drawing.Point(105, 120)
        Me.lblNombreA.Name = "lblNombreA"
        Me.lblNombreA.Size = New System.Drawing.Size(56, 16)
        Me.lblNombreA.TabIndex = 5
        Me.lblNombreA.Text = "Nombre"
        '
        'lblNumIdA
        '
        Me.lblNumIdA.AutoSize = True
        Me.lblNumIdA.Location = New System.Drawing.Point(105, 187)
        Me.lblNumIdA.Name = "lblNumIdA"
        Me.lblNumIdA.Size = New System.Drawing.Size(49, 16)
        Me.lblNumIdA.TabIndex = 6
        Me.lblNumIdA.Text = "Num Id"
        '
        'lblTelefonoA
        '
        Me.lblTelefonoA.AutoSize = True
        Me.lblTelefonoA.Location = New System.Drawing.Point(105, 260)
        Me.lblTelefonoA.Name = "lblTelefonoA"
        Me.lblTelefonoA.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefonoA.TabIndex = 7
        Me.lblTelefonoA.Text = "Telefono"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(108, 324)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(91, 41)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnNuevoA
        '
        Me.btnNuevoA.Location = New System.Drawing.Point(299, 324)
        Me.btnNuevoA.Name = "btnNuevoA"
        Me.btnNuevoA.Size = New System.Drawing.Size(91, 41)
        Me.btnNuevoA.TabIndex = 9
        Me.btnNuevoA.Text = "Nuevo"
        Me.btnNuevoA.UseVisualStyleBackColor = True
        '
        'FrmActualizarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 442)
        Me.Controls.Add(Me.btnNuevoA)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblTelefonoA)
        Me.Controls.Add(Me.lblNumIdA)
        Me.Controls.Add(Me.lblNombreA)
        Me.Controls.Add(Me.lblClienteIdA)
        Me.Controls.Add(Me.txtTelefonoA)
        Me.Controls.Add(Me.txtNumIdA)
        Me.Controls.Add(Me.txtNombreA)
        Me.Controls.Add(Me.txtIdClienteA)
        Me.Name = "FrmActualizarCliente"
        Me.Text = "FrmActualizarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdClienteA As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents txtNumIdA As TextBox
    Friend WithEvents txtTelefonoA As TextBox
    Friend WithEvents lblClienteIdA As Label
    Friend WithEvents lblNombreA As Label
    Friend WithEvents lblNumIdA As Label
    Friend WithEvents lblTelefonoA As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnNuevoA As Button
End Class
