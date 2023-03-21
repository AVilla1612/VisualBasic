Public Class Coche

    Public marca As String
    Public modelo As String
    Public color As String
    Public velocidad As Integer

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
