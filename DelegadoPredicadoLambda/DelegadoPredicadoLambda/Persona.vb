Public Class Persona

    Private nombre As String
    Private edad As Integer

    Public Sub New(nombre As String, edad As Integer)
        Me.nombre = nombre
        Me.edad = edad
    End Sub

    Public Property NombrePersona() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property EdadPersona() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Overrides Function ToString() As String

        Return nombre & " " & edad

    End Function

End Class
