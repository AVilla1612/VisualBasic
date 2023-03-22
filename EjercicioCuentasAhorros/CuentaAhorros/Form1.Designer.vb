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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCrearCuenta = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnVerTransacciones = New System.Windows.Forms.Button()
        Me.btnVerSaldo = New System.Windows.Forms.Button()
        Me.btnRetirarDinero = New System.Windows.Forms.Button()
        Me.btnIngresarDinero = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.liRetiros = New System.Windows.Forms.ListBox()
        Me.liIngresos = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSaldoInicial)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnCrearCuenta)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNumId)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Cuenta"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(618, 36)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(126, 20)
        Me.txtSaldoInicial.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(641, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Saldo Inicial"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(159, 94)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(126, 30)
        Me.btnNuevo.TabIndex = 9
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnCrearCuenta
        '
        Me.btnCrearCuenta.Location = New System.Drawing.Point(7, 94)
        Me.btnCrearCuenta.Name = "btnCrearCuenta"
        Me.btnCrearCuenta.Size = New System.Drawing.Size(126, 30)
        Me.btnCrearCuenta.TabIndex = 8
        Me.btnCrearCuenta.Text = "Crear Cuenta"
        Me.btnCrearCuenta.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(501, 36)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(95, 20)
        Me.txtTelefono.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(316, 36)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(163, 20)
        Me.txtDireccion.TabIndex = 6
        '
        'txtNumId
        '
        Me.txtNumId.Location = New System.Drawing.Point(159, 36)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(126, 20)
        Me.txtNumId.TabIndex = 5
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(6, 36)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(127, 20)
        Me.txtNombres.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(525, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número de identificación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnVerTransacciones)
        Me.GroupBox2.Controls.Add(Me.btnVerSaldo)
        Me.GroupBox2.Controls.Add(Me.btnRetirarDinero)
        Me.GroupBox2.Controls.Add(Me.btnIngresarDinero)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(750, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacciones"
        '
        'btnVerTransacciones
        '
        Me.btnVerTransacciones.Location = New System.Drawing.Point(557, 45)
        Me.btnVerTransacciones.Name = "btnVerTransacciones"
        Me.btnVerTransacciones.Size = New System.Drawing.Size(110, 42)
        Me.btnVerTransacciones.TabIndex = 3
        Me.btnVerTransacciones.Text = "Ver Detalle Transacciones"
        Me.btnVerTransacciones.UseVisualStyleBackColor = True
        '
        'btnVerSaldo
        '
        Me.btnVerSaldo.Location = New System.Drawing.Point(369, 45)
        Me.btnVerSaldo.Name = "btnVerSaldo"
        Me.btnVerSaldo.Size = New System.Drawing.Size(110, 42)
        Me.btnVerSaldo.TabIndex = 2
        Me.btnVerSaldo.Text = "Ver Saldo Disponible"
        Me.btnVerSaldo.UseVisualStyleBackColor = True
        '
        'btnRetirarDinero
        '
        Me.btnRetirarDinero.Location = New System.Drawing.Point(198, 45)
        Me.btnRetirarDinero.Name = "btnRetirarDinero"
        Me.btnRetirarDinero.Size = New System.Drawing.Size(110, 42)
        Me.btnRetirarDinero.TabIndex = 1
        Me.btnRetirarDinero.Text = "Retirar Dinero"
        Me.btnRetirarDinero.UseVisualStyleBackColor = True
        '
        'btnIngresarDinero
        '
        Me.btnIngresarDinero.Location = New System.Drawing.Point(23, 45)
        Me.btnIngresarDinero.Name = "btnIngresarDinero"
        Me.btnIngresarDinero.Size = New System.Drawing.Size(110, 42)
        Me.btnIngresarDinero.TabIndex = 0
        Me.btnIngresarDinero.Text = "Ingresar Dinero"
        Me.btnIngresarDinero.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.liRetiros)
        Me.GroupBox3.Controls.Add(Me.liIngresos)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 326)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(750, 302)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial de Transacciones Cuenta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(529, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Retiros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(155, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Ingresos"
        '
        'liRetiros
        '
        Me.liRetiros.FormattingEnabled = True
        Me.liRetiros.Location = New System.Drawing.Point(387, 55)
        Me.liRetiros.Name = "liRetiros"
        Me.liRetiros.Size = New System.Drawing.Size(357, 212)
        Me.liRetiros.TabIndex = 1
        '
        'liIngresos
        '
        Me.liIngresos.FormattingEnabled = True
        Me.liIngresos.Location = New System.Drawing.Point(7, 55)
        Me.liIngresos.Name = "liIngresos"
        Me.liIngresos.Size = New System.Drawing.Size(374, 212)
        Me.liIngresos.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 640)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCrearCuenta As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnIngresarDinero As Button
    Friend WithEvents btnVerTransacciones As Button
    Friend WithEvents btnVerSaldo As Button
    Friend WithEvents btnRetirarDinero As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents liRetiros As ListBox
    Friend WithEvents liIngresos As ListBox
End Class
