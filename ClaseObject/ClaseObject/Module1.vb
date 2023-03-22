Module Module1

    Sub Main()

        Dim miObjeto As Object = New Persona("Juan", 26)

        Dim auxPersona As Persona = TryCast(miObjeto, Persona)

        Console.WriteLine("Nombre: " & auxPersona.NombrePersona & "     " & "Edad: " & auxPersona.EdadPersona)

    End Sub

End Module
