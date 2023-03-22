Public Class Universitario
    Inherits Estudiante

    Private programa As String

    Public Sub New(nombre As String, tipoId As String, numId As String, edad As Integer, direccion As String, telefono As String, carnet As Boolean, programa As String)
        MyBase.New(nombre, tipoId, numId, edad, direccion, telefono, carnet)
        Me.programa = programa

    End Sub

    Public Property ProgramaEstudiante() As String
        Get
            Return programa
        End Get
        Set(value As String)
            programa = value
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
        Console.WriteLine("Programa Universitario: " & ProgramaEstudiante)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Telefono: " & TelefonoPersona)
        Console.WriteLine("---------------------------------------------------")

    End Sub
End Class
