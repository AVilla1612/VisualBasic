Module Module1

    Sub Main()

        Dim edades = New Integer() {25, 21, 43, 58, 34, 16, 51, 26}

        Dim edad, indice As Integer

        Dim encontrado As Boolean = False

        Dim contadora As Integer = 0

        Console.Write("Ingrese el número que desea buscar: ")
        edad = Console.ReadLine()

        For i = 0 To edades.Length - 1 And encontrado = False Step 1

            contadora += 1
            If edad = edades(i) Then

                indice = i
                encontrado = True

                Exit For

            End If

        Next

        If encontrado = True Then

            Console.WriteLine("El número buscado se encuentra en la posición: " & indice)
            Console.WriteLine(contadora & vbCr)

        Else

        End If

    End Sub

End Module
