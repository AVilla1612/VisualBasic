Public Class Coche

    Public marca As String
    Public modelo As String
    Public color As String
    Public velocidad As Integer

    Public Sub New(marca As String, modelo As String, color As String, velocidad As Integer)
        Me.marca = marca
        Me.modelo = modelo
        Me.color = color
        Me.velocidad = velocidad
    End Sub

    Public Sub New(marca As String, modelo As String, color As String)
        Me.marca = marca
        Me.modelo = modelo
        Me.color = color
    End Sub

    Public Sub subirVelocidad()

        velocidad += 10

    End Sub

    Public Sub bajarVelocidad()

        velocidad -= 10

    End Sub

    Function velocidadActual() As Integer

        Return velocidad

    End Function

End Class
