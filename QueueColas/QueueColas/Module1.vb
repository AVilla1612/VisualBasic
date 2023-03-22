Imports System.Reflection.Emit
Imports System.Security.Cryptography

Module Module1

    Sub Main()

        Dim cola As New Queue(Of Integer)

        cola.Enqueue(2)
        cola.Enqueue(6)
        cola.Enqueue(12)
        cola.Enqueue(16)
        cola.Enqueue(22)

        Console.WriteLine("Rrimer numero cola: " & cola.Peek)

        Console.WriteLine(" ")

        For Each num As Integer In cola

            Console.WriteLine(num)

        Next

        Console.WriteLine(" ")

        For i = 0 To cola.Count - 1 Step 1

            Console.WriteLine(cola.Dequeue)

        Next





    End Sub

End Module
