Module Module1

    Sub Main()

        Dim vector(2) As Integer
        vector(0) = 12
        vector(1) = 14
        vector(2) = 16


        Dim matriz(1, 1) As Integer
        matriz(0, 0) = 10
        matriz(0, 1) = 20
        matriz(1, 0) = 30
        matriz(1, 1) = 40

        For Each num As Integer In vector

            Console.WriteLine(num & " ")


        Next

        For Each num As Integer In matriz

            Console.Write(num & " ")

        Next



    End Sub

End Module
