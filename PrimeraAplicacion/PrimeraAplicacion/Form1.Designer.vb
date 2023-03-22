<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnMostrarMensaje = New System.Windows.Forms.Button()
        Me.lblMostrarMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(271, 88)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 19)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(358, 85)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(133, 22)
        Me.txtNombre.TabIndex = 2
        '
        'btnMostrarMensaje
        '
        Me.btnMostrarMensaje.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarMensaje.Location = New System.Drawing.Point(305, 125)
        Me.btnMostrarMensaje.Name = "btnMostrarMensaje"
        Me.btnMostrarMensaje.Size = New System.Drawing.Size(150, 35)
        Me.btnMostrarMensaje.TabIndex = 3
        Me.btnMostrarMensaje.Text = "Mostrar Mensaje"
        Me.btnMostrarMensaje.UseVisualStyleBackColor = True
        '
        'lblMostrarMensaje
        '
        Me.lblMostrarMensaje.AutoSize = True
        Me.lblMostrarMensaje.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostrarMensaje.Location = New System.Drawing.Point(325, 178)
        Me.lblMostrarMensaje.Name = "lblMostrarMensaje"
        Me.lblMostrarMensaje.Size = New System.Drawing.Size(108, 19)
        Me.lblMostrarMensaje.TabIndex = 4
        Me.lblMostrarMensaje.Text = "___________"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMostrarMensaje)
        Me.Controls.Add(Me.btnMostrarMensaje)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnMostrarMensaje As Button
    Friend WithEvents lblMostrarMensaje As Label
End Class
