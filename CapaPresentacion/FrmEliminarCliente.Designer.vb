<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarCliente
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
        Me.lblClienteIdE = New System.Windows.Forms.Label()
        Me.lblNombreE = New System.Windows.Forms.Label()
        Me.lblNumIdE = New System.Windows.Forms.Label()
        Me.lblTelefonoE = New System.Windows.Forms.Label()
        Me.txtIdClienteE = New System.Windows.Forms.TextBox()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.txtNumIdE = New System.Windows.Forms.TextBox()
        Me.txtTelefonoE = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblClienteIdE
        '
        Me.lblClienteIdE.AutoSize = True
        Me.lblClienteIdE.Location = New System.Drawing.Point(97, 55)
        Me.lblClienteIdE.Name = "lblClienteIdE"
        Me.lblClienteIdE.Size = New System.Drawing.Size(62, 16)
        Me.lblClienteIdE.TabIndex = 5
        Me.lblClienteIdE.Text = "Id Cliente"
        '
        'lblNombreE
        '
        Me.lblNombreE.AutoSize = True
        Me.lblNombreE.Location = New System.Drawing.Point(97, 133)
        Me.lblNombreE.Name = "lblNombreE"
        Me.lblNombreE.Size = New System.Drawing.Size(56, 16)
        Me.lblNombreE.TabIndex = 6
        Me.lblNombreE.Text = "Nombre"
        '
        'lblNumIdE
        '
        Me.lblNumIdE.AutoSize = True
        Me.lblNumIdE.Location = New System.Drawing.Point(97, 200)
        Me.lblNumIdE.Name = "lblNumIdE"
        Me.lblNumIdE.Size = New System.Drawing.Size(49, 16)
        Me.lblNumIdE.TabIndex = 7
        Me.lblNumIdE.Text = "Num Id"
        '
        'lblTelefonoE
        '
        Me.lblTelefonoE.AutoSize = True
        Me.lblTelefonoE.Location = New System.Drawing.Point(97, 264)
        Me.lblTelefonoE.Name = "lblTelefonoE"
        Me.lblTelefonoE.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefonoE.TabIndex = 8
        Me.lblTelefonoE.Text = "Telefono"
        '
        'txtIdClienteE
        '
        Me.txtIdClienteE.Location = New System.Drawing.Point(204, 52)
        Me.txtIdClienteE.Name = "txtIdClienteE"
        Me.txtIdClienteE.Size = New System.Drawing.Size(154, 22)
        Me.txtIdClienteE.TabIndex = 9
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(204, 130)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(154, 22)
        Me.txtNombreE.TabIndex = 10
        '
        'txtNumIdE
        '
        Me.txtNumIdE.Location = New System.Drawing.Point(204, 197)
        Me.txtNumIdE.Name = "txtNumIdE"
        Me.txtNumIdE.Size = New System.Drawing.Size(154, 22)
        Me.txtNumIdE.TabIndex = 11
        '
        'txtTelefonoE
        '
        Me.txtTelefonoE.Location = New System.Drawing.Point(204, 261)
        Me.txtTelefonoE.Name = "txtTelefonoE"
        Me.txtTelefonoE.Size = New System.Drawing.Size(154, 22)
        Me.txtTelefonoE.TabIndex = 12
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(100, 319)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(258, 43)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar Cliente"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'FrmEliminarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 397)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtTelefonoE)
        Me.Controls.Add(Me.txtNumIdE)
        Me.Controls.Add(Me.txtNombreE)
        Me.Controls.Add(Me.txtIdClienteE)
        Me.Controls.Add(Me.lblTelefonoE)
        Me.Controls.Add(Me.lblNumIdE)
        Me.Controls.Add(Me.lblNombreE)
        Me.Controls.Add(Me.lblClienteIdE)
        Me.Name = "FrmEliminarCliente"
        Me.Text = "FrmEliminarCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblClienteIdE As Label
    Friend WithEvents lblNombreE As Label
    Friend WithEvents lblNumIdE As Label
    Friend WithEvents lblTelefonoE As Label
    Friend WithEvents txtIdClienteE As TextBox
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents txtNumIdE As TextBox
    Friend WithEvents txtTelefonoE As TextBox
    Friend WithEvents btnEliminar As Button
End Class
