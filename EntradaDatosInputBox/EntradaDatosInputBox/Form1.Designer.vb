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
        Me.btnIngresarDatos = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.gbIngresrDatos = New System.Windows.Forms.GroupBox()
        Me.gbResultado = New System.Windows.Forms.GroupBox()
        Me.gbIngresrDatos.SuspendLayout()
        Me.gbResultado.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIngresarDatos
        '
        Me.btnIngresarDatos.Location = New System.Drawing.Point(325, 59)
        Me.btnIngresarDatos.Name = "btnIngresarDatos"
        Me.btnIngresarDatos.Size = New System.Drawing.Size(163, 32)
        Me.btnIngresarDatos.TabIndex = 0
        Me.btnIngresarDatos.Text = "Ingresar datos"
        Me.btnIngresarDatos.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(325, 73)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(163, 32)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(325, 125)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(163, 22)
        Me.txtResultado.TabIndex = 2
        '
        'gbIngresrDatos
        '
        Me.gbIngresrDatos.Controls.Add(Me.btnIngresarDatos)
        Me.gbIngresrDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIngresrDatos.Location = New System.Drawing.Point(12, 27)
        Me.gbIngresrDatos.Name = "gbIngresrDatos"
        Me.gbIngresrDatos.Size = New System.Drawing.Size(776, 147)
        Me.gbIngresrDatos.TabIndex = 3
        Me.gbIngresrDatos.TabStop = False
        Me.gbIngresrDatos.Text = "Ingreso de datos"
        '
        'gbResultado
        '
        Me.gbResultado.Controls.Add(Me.btnCalcular)
        Me.gbResultado.Controls.Add(Me.txtResultado)
        Me.gbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbResultado.Location = New System.Drawing.Point(12, 202)
        Me.gbResultado.Name = "gbResultado"
        Me.gbResultado.Size = New System.Drawing.Size(776, 225)
        Me.gbResultado.TabIndex = 4
        Me.gbResultado.TabStop = False
        Me.gbResultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbResultado)
        Me.Controls.Add(Me.gbIngresrDatos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbIngresrDatos.ResumeLayout(False)
        Me.gbResultado.ResumeLayout(False)
        Me.gbResultado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIngresarDatos As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents gbIngresrDatos As GroupBox
    Friend WithEvents gbResultado As GroupBox
End Class
