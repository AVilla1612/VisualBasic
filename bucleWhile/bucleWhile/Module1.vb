Module Module1

    Sub Main()

        Console.Write("Ingrese un número: ")
        Dim num As Integer = Console.ReadLine()

        Dim sumaNum As Integer = 0

        While num > 0

            sumaNum = sumaNum + num Mod 10

            num = Math.Truncate(num / 10)

        End While

        Console.WriteLine("La suma de los números es: " & sumaNum)

    End Sub

End Module
