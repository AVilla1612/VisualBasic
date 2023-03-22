Public Class Estudiante
    Inherits Persona
    Implements IComparable


    Private codEstudiante As String
    Private carnetEstudiante As Boolean

    Public Sub New(nombre As String, tipoId As String, numId As String, edad As Integer, direccion As String, telefono As String, carnet As Boolean)
        MyBase.New(nombre, tipoId, numId, edad, direccion, telefono)
        Me.codEstudiante = nombre.Substring(0, 2) & numId.Substring(0, 2)
        carnetEstudiante = carnet
    End Sub

    Public Property CodigoEstudiante() As String
        Get
            Return codEstudiante
        End Get
        Set(value As String)
            codEstudiante = value
        End Set
    End Property

    Public Property Carnet_Estudiante() As Boolean
        Get
            Return carnetEstudiante
        End Get
        Set(value As Boolean)
            carnetEstudiante = value
        End Set
    End Property

    Public Overrides Sub DarDescripcion()

        Console.WriteLine("---------------------------------------------------")
        Console.WriteLine("Datos del ESTUDIANTE:")
        Console.WriteLine("Nombre: " & NombrePersona)
        Console.WriteLine("Tipo de Identificación: " & TipoIdPersona)
        Console.WriteLine("Número de Identificación: " & NumIdPersona)
        Console.WriteLine("Código de ESTUDIANTE: " & CodigoEstudiante)
        Console.WriteLine("Carnet Estudiantil: " & Carnet_Estudiante)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Telefono: " & TelefonoPersona)
        Console.WriteLine("---------------------------------------------------")

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo

        Dim auxEstudiante As Estudiante = TryCast(obj, Estudiante)

        If Me.EdadPersona < auxEstudiante.EdadPersona Then

            Return -1

        ElseIf Me.EdadPersona = auxEstudiante.EdadPersona Then

            Return 0

        Else

            Return 1

        End If

    End Function

End Class
