Module Module1

    Sub Main()

        Dim nom, id As String
        Dim edad As Integer

        Try

            Console.Write("Ingrese su nombre: ")
            nom = Console.ReadLine

            Console.Write("Ingrese su número de identificación: ")
            id = Console.ReadLine

            Console.Write("Ingrese su edad: ")
            edad = Console.ReadLine

            Dim p As New Persona(nom, id, edad)

        Catch ex As InvalidCastException

            Console.WriteLine("Campo EDAD inválido --> Sólo debe contener números")

        End Try



    End Sub

End Module
