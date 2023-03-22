Public Class Deportista

    Private nombre As String
    Private posicion As String
    Private edad As Integer
    Private altura As Double

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, posicion As String, edad As Integer, altura As Double)
        Me.nombre = nombre
        Me.posicion = posicion
        Me.edad = edad
        Me.altura = altura
    End Sub

    Public Property NombreDeportista() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property PosicionDeportista() As String
        Get
            Return posicion
        End Get
        Set(value As String)
            posicion = value
        End Set
    End Property

    Public Property EdadDeportista() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Property AlturaDeportista() As Double
        Get
            Return altura
        End Get
        Set(value As Double)
            altura = value
        End Set
    End Property
End Class
