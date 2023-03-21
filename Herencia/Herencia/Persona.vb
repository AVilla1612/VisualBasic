Public Class Persona

    Protected nombre As String
    Protected celula As String
    Protected direccion As String
    Protected telefono As String

    Public Sub New(nombre As String, celula As String, direccion As String, telefono As String)
        Me.nombre = nombre
        Me.celula = celula
        Me.direccion = direccion
        Me.telefono = telefono
    End Sub

    Public Property NombrePersona() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property CelulaPersona() As String
        Get
            Return celula
        End Get
        Set(value As String)
            celula = value
        End Set
    End Property

    Public Property DireccionPersona() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoPersona() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

End Class
