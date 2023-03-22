Public Class Usuario
    Inherits Persona

    Public Property NombrePersona As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property DniPersona As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

End Class
