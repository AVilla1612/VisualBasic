Module Module1

    Sub Main()

        Dim numeros = New Integer() {2, 4, 6, 8}

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next

        ReDim Preserve numeros(5)


        numeros(4) = 10
        numeros(5) = 12

        Console.WriteLine(" ")

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next

        Console.WriteLine(" ")

        ReDim Preserve numeros(7)


        numeros(4) = 10
        numeros(5) = 12
        numeros(6) = 14
        numeros(7) = 16

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next

        Console.WriteLine(" ")
        Console.WriteLine(" ")

        Dim numbers = New Integer(,) {{1, 2}, {3, 4}}

        For i = 0 To 1 Step 1

            For j = 0 To 1 Step 1

                Console.Write(numbers(i, j) & " ")
            Next
        Next

        Console.WriteLine(" ")


        ReDim numbers(3, 3)

        numbers(0, 0) = 2
        numbers(0, 1) = 4
        numbers(0, 2) = 6
        numbers(1, 0) = 8
        numbers(1, 1) = 10
        numbers(1, 2) = 12
        numbers(2, 0) = 14
        numbers(2, 1) = 16
        numbers(2, 2) = 18
        numbers(0, 3) = 20

        For i = 0 To 2 Step 1

            For j = 0 To 2 Step 1

                Console.Write(numbers(i, j) & " ")
            Next
        Next

    End Sub

End Module
