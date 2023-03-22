Module Module1

    Sub Main()

        Dim numeros = New Integer() {10, 8, 23, 6, 12, 16}

        Array.Sort(numeros)

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next

    End Sub

End Module
