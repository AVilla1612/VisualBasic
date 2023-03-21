Module Module1

    Sub Main()


        Dim numeros(2, 3) As Integer

        numeros(0, 0) = 25
        numeros(0, 1) = 13
        numeros(0, 2) = 84
        numeros(1, 0) = 6
        numeros(1, 1) = 22
        numeros(1, 2) = 39

        For fila = 0 To 1 Step 1


            For columna = 0 To 2 Step 1

                Console.Write("Ingrese el número: " & fila & " , " & columna & " : ")
                numeros(fila, columna) = Console.ReadLine()


            Next


        Next

    End Sub

End Module
