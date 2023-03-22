Imports System.Net.Http.Headers

Module Module1

    Sub Main()

        'Creación de un Stack/Pila'
        Dim pila As New Stack(Of Integer)

        pila.Push(2)
        pila.Push(4)
        pila.Push(6)
        pila.Push(8)
        pila.Push(10)

        pila.Pop()
        pila.Pop()

        While pila.Count <> 0

            Console.WriteLine(pila.Pop)

        End While

        For Each num As Integer In pila

            Console.WriteLine(num)

        Next

    End Sub

End Module
