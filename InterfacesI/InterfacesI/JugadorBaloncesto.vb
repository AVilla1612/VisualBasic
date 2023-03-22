Public Class JugadorBaloncesto
    Inherits Deportista
    Implements IJugadorBaloncesto

    Public Sub New(nom As String, pos As String, e As Integer, alt As Double)

        MyBase.New(nom, pos, e, alt)

    End Sub

    Public Function VerificarAltura() As Boolean Implements IJugadorBaloncesto.VerificarAltura

        If AlturaDeportista >= 190 Then

            Return True

        Else

            Return False

        End If

    End Function

End Class
