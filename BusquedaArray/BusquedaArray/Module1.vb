Module Module1

    Sub Main()

        Dim edades = New Integer() {25, 21, 43, 58, 34, 16, 51, 26}

        Dim contadora As Integer = 0

        For i = 0 To edades.Length - 1 Step 1

            If edades(i) < 50 Then

                contadora += 1

            End If

        Next

        Console.WriteLine("El número de personas cuya edad es menor de 50 es: " & contadora)

    End Sub

End Module
