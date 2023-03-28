<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerarReport
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
        Me.btnGenerarReporte = New System.Windows.Forms.Button()
        Me.txtGenerarReporte = New System.Windows.Forms.TextBox()
        Me.lblGenerarReporte = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerarReporte
        '
        Me.btnGenerarReporte.Location = New System.Drawing.Point(93, 110)
        Me.btnGenerarReporte.Name = "btnGenerarReporte"
        Me.btnGenerarReporte.Size = New System.Drawing.Size(233, 58)
        Me.btnGenerarReporte.TabIndex = 0
        Me.btnGenerarReporte.Text = "Generar Reporte"
        Me.btnGenerarReporte.UseVisualStyleBackColor = True
        '
        'txtGenerarReporte
        '
        Me.txtGenerarReporte.Location = New System.Drawing.Point(154, 68)
        Me.txtGenerarReporte.Name = "txtGenerarReporte"
        Me.txtGenerarReporte.Size = New System.Drawing.Size(100, 22)
        Me.txtGenerarReporte.TabIndex = 1
        '
        'lblGenerarReporte
        '
        Me.lblGenerarReporte.AutoSize = True
        Me.lblGenerarReporte.Location = New System.Drawing.Point(90, 29)
        Me.lblGenerarReporte.Name = "lblGenerarReporte"
        Me.lblGenerarReporte.Size = New System.Drawing.Size(236, 16)
        Me.lblGenerarReporte.TabIndex = 2
        Me.lblGenerarReporte.Text = "Introduzca su Número de Identificación"
        '
        'FrmGenerarReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 221)
        Me.Controls.Add(Me.lblGenerarReporte)
        Me.Controls.Add(Me.txtGenerarReporte)
        Me.Controls.Add(Me.btnGenerarReporte)
        Me.Name = "FrmGenerarReport"
        Me.Text = "FrmGenerarReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerarReporte As Button
    Friend WithEvents txtGenerarReporte As TextBox
    Friend WithEvents lblGenerarReporte As Label
End Class
