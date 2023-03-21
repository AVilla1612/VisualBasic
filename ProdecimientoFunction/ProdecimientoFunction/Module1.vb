Imports System.Globalization

Module Module1

    Sub Main()

        Console.Write("Primer número a sumar: ")
        Dim num = Console.ReadLine()
        Console.WriteLine("------------")

        Console.Write("Segundo número a sumar: ")
        Dim num1 = Console.ReadLine()
        Console.WriteLine("------------")

        Console.WriteLine("El resultado es: " & Sumar(num, num1))
        Console.WriteLine("------------")

        Dim numeros = New Integer() {1, 2, 3, 4, 5, 6}
        Console.WriteLine("Posición del número en el Array: " & buscarNumero(3, numeros))

    End Sub

    Function Sumar(num As Integer, num1 As Integer) As Integer

        Dim resultado As Integer = num + num1

        Return resultado

    End Function

    Function buscarNumero(numBuscar As Integer, vector() As Integer) As Integer

        Dim pos As Integer = -1

        Dim encontrado As Boolean = False

        For i = 0 To vector.Length - 1 And encontrado = False

            If vector(i) = numBuscar Then

                pos = i
                encontrado = True

            End If

        Next

        Return pos

    End Function

End Module
