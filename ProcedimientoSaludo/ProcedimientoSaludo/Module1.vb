Module Module1

    Sub Main()

        Console.Write("Nombre: ")
        Dim nombre = Console.ReadLine()

        saludar(nombre)

    End Sub

    Sub saludar(nombre As String)

        Console.WriteLine("Hola " & nombre & ", un placer conocerte (:")

    End Sub

End Module
