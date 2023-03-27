Public Class Persona

    Private nombre As String
    Private numId As String
    Private telefono As String
    Private correo As String

    Public Sub New(nombre As String, numId As String, telefono As String, correo As String)
        Me.nombre = nombre
        Me.numId = numId
        Me.telefono = telefono
        Me.correo = correo
    End Sub

    Public Property NombrePersona As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property NumIdPersona As String
        Get
            Return numId
        End Get
        Set(value As String)
            numId = value
        End Set
    End Property

    Public Property TelefonoPersona As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property CorreoPersona As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Overrides Function ToString() As String

        Return "Nombre: " & nombre & vbCrLf & "Nº Identificación: " & numId & vbCrLf & "Teléfono: " & telefono & vbCrLf & "Correo Electrónico: " & correo

    End Function

End Class
