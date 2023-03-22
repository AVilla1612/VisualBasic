Public Class Persona

    Private nombre As String
    Private id As Integer

    Public Sub New(nombre As String, id As Integer)
        Me.nombre = nombre
        Me.id = id
    End Sub

    Public Property NombrePersona() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property IdPersona() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

End Class
