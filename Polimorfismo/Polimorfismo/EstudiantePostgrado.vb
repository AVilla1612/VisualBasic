Public Class EstudiantePostgrado
    Inherits Universitario

    Public Sub New(nombre As String, tipoId As String, numId As String, edad As Integer, direccion As String, telefono As String, carnet As Boolean, programa As String)
        MyBase.New(nombre, tipoId, numId, edad, direccion, telefono, carnet, programa)

    End Sub

    Public Overrides Sub DarDescripcion()

        Console.WriteLine("---------------------------------------------------")
        Console.WriteLine("Datos del ESTUDIANTE:")
        Console.WriteLine("Nombre: " & NombrePersona)
        Console.WriteLine("Tipo de Identificación: " & TipoIdPersona)
        Console.WriteLine("Número de Identificación: " & NumIdPersona)
        Console.WriteLine("Código de ESTUDIANTE: " & CodigoEstudiante)
        Console.WriteLine("Carnet Estudiantil: " & Carnet_Estudiante)
        Console.WriteLine("Programa PostGrado: " & ProgramaEstudiante)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Dirección: " & DireccionPersona)
        Console.WriteLine("Telefono: " & TelefonoPersona)
        Console.WriteLine("---------------------------------------------------")

    End Sub

End Class
