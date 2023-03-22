Module Module1

    Sub Main()

        Dim general As Object = "Probando los genéricos"
        Dim general1 As Object = New Persona("Juan", 1)
        Dim miPersona As Persona = TryCast(general1, Persona)

        Console.WriteLine("------------------------------------")
        Console.WriteLine(general)
        Console.WriteLine(general1)
        Console.WriteLine(miPersona.NombrePersona)
        Console.WriteLine("------------------------------------")

        Console.WriteLine("------------------------------------")
        Dim objetoGeneral As New Objetos(Of Persona)
        objetoGeneral.ElObjeto = New Persona("Alicia", 2)
        Console.WriteLine("Nombre: " & objetoGeneral.ElObjeto.NombrePersona)
        Console.WriteLine("Id: " & objetoGeneral.ElObjeto.IdPersona)
        Console.WriteLine("------------------------------------")

    End Sub

End Module
