Module Module1

    Sub Main()

        Dim numeros = New Integer() {233, 301, 192, 169, 215}

        For i = 0 To numeros.Length - 1 Step 1

            Dim menor As Integer = numeros(i)

            Dim posMenor As Integer = i

            For j = i + 1 To numeros.Length - 1 Step 1

                If numeros(j) < menor Then

                    menor = numeros(j)
                    posMenor = j

                End If

            Next

            Dim aux As Integer = numeros(i)
            numeros(i) = numeros(posMenor)
            numeros(posMenor) = aux

        Next

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next


    End Sub

End Module
