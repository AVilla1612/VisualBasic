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
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.cbClase = New System.Windows.Forms.CheckBox()
        Me.cbObjeto = New System.Windows.Forms.CheckBox()
        Me.cbHerencia = New System.Windows.Forms.CheckBox()
        Me.cbBucle = New System.Windows.Forms.CheckBox()
        Me.cbPolimorfismo = New System.Windows.Forms.CheckBox()
        Me.btnRespuesta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Comic Sans MS", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(136, 79)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(477, 25)
        Me.lblPregunta.TabIndex = 0
        Me.lblPregunta.Text = "¿Qué conceptos pertenecen al paradigma de la POO?"
        '
        'cbClase
        '
        Me.cbClase.AutoSize = True
        Me.cbClase.Location = New System.Drawing.Point(251, 155)
        Me.cbClase.Name = "cbClase"
        Me.cbClase.Size = New System.Drawing.Size(64, 20)
        Me.cbClase.TabIndex = 1
        Me.cbClase.Text = "Clase"
        Me.cbClase.UseVisualStyleBackColor = True
        '
        'cbObjeto
        '
        Me.cbObjeto.AutoSize = True
        Me.cbObjeto.Location = New System.Drawing.Point(251, 192)
        Me.cbObjeto.Name = "cbObjeto"
        Me.cbObjeto.Size = New System.Drawing.Size(69, 20)
        Me.cbObjeto.TabIndex = 2
        Me.cbObjeto.Text = "Objeto"
        Me.cbObjeto.UseVisualStyleBackColor = True
        '
        'cbHerencia
        '
        Me.cbHerencia.AutoSize = True
        Me.cbHerencia.Location = New System.Drawing.Point(251, 230)
        Me.cbHerencia.Name = "cbHerencia"
        Me.cbHerencia.Size = New System.Drawing.Size(84, 20)
        Me.cbHerencia.TabIndex = 3
        Me.cbHerencia.Text = "Herencia"
        Me.cbHerencia.UseVisualStyleBackColor = True
        '
        'cbBucle
        '
        Me.cbBucle.AutoSize = True
        Me.cbBucle.Location = New System.Drawing.Point(251, 267)
        Me.cbBucle.Name = "cbBucle"
        Me.cbBucle.Size = New System.Drawing.Size(63, 20)
        Me.cbBucle.TabIndex = 4
        Me.cbBucle.Text = "Bucle"
        Me.cbBucle.UseVisualStyleBackColor = True
        '
        'cbPolimorfismo
        '
        Me.cbPolimorfismo.AutoSize = True
        Me.cbPolimorfismo.Location = New System.Drawing.Point(251, 305)
        Me.cbPolimorfismo.Name = "cbPolimorfismo"
        Me.cbPolimorfismo.Size = New System.Drawing.Size(107, 20)
        Me.cbPolimorfismo.TabIndex = 5
        Me.cbPolimorfismo.Text = "Polimorfismo"
        Me.cbPolimorfismo.UseVisualStyleBackColor = True
        '
        'btnRespuesta
        '
        Me.btnRespuesta.Location = New System.Drawing.Point(369, 192)
        Me.btnRespuesta.Name = "btnRespuesta"
        Me.btnRespuesta.Size = New System.Drawing.Size(219, 87)
        Me.btnRespuesta.TabIndex = 6
        Me.btnRespuesta.Text = "Procesar Respuesta"
        Me.btnRespuesta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRespuesta)
        Me.Controls.Add(Me.cbPolimorfismo)
        Me.Controls.Add(Me.cbBucle)
        Me.Controls.Add(Me.cbHerencia)
        Me.Controls.Add(Me.cbObjeto)
        Me.Controls.Add(Me.cbClase)
        Me.Controls.Add(Me.lblPregunta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPregunta As Label
    Friend WithEvents cbClase As Windows.Forms.CheckBox
    Friend WithEvents cbObjeto As Windows.Forms.CheckBox
    Friend WithEvents cbHerencia As Windows.Forms.CheckBox
    Friend WithEvents cbBucle As Windows.Forms.CheckBox
    Friend WithEvents cbPolimorfismo As Windows.Forms.CheckBox
    Friend WithEvents btnRespuesta As Button
End Class
