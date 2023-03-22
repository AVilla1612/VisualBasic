Public Class Cliente

    Private nombre As String
    Private dni As String
    Private direccion As String
    Private telefono As String

    Public Sub New(nombre As String, dni As String, direccion As String, telefono As String)
        Me.nombre = nombre
        Me.dni = dni
        Me.direccion = direccion
        Me.telefono = telefono
    End Sub

    Public Sub New()

    End Sub

    Public Property NombreCliente() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property DniCliente() As String
        Get
            Return dni
        End Get
        Set(value As String)
            dni = value
        End Set
    End Property

    Public Property DireccionCliente() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

End Class
