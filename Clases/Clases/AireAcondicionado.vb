Public Class AireAcondicionado

    Public marca As String
    Public modelo As String
    Public color As String
    Public voltaje As Integer
    Public temperatura As Integer

    Public Sub subirTemperatura()

        temperatura += 1

    End Sub

    Public Sub bajarTemperatura()

        temperatura -= 1

    End Sub

    Function temperaturaActual() As Integer

        Return temperatura

    End Function

End Class
