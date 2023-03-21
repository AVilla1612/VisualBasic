Module Module1

    Sub Main()

        Console.WriteLine("Ingrese 1 si desea sumar")
        Console.WriteLine("Ingrese 2 si desea restar")
        Console.WriteLine("Ingrese 3 si desea multiplicar")
        Console.WriteLine("Ingrese 4 si desea dividir")
        Console.WriteLine("Ingrese 5 si desea obtener el resto")

        Dim opcion As Integer = Console.ReadLine()

        Dim num1, num2 As Double

        Select Case opcion

            Case 1 : Console.Write("Primer nº que desea sumar: ")
                num1 = Console.ReadLine()
                Console.Write("Segundo nº que desea sumar: ")
                num2 = Console.ReadLine()
                Console.WriteLine("La suma de ambos numeros es: " & (num1 + num2))

            Case 2 : Console.Write("Primer nº que desea restar: ")
                num1 = Console.ReadLine()
                Console.Write("Segundo nº que desea restar: ")
                num2 = Console.ReadLine()
                Console.WriteLine("La resta de ambos numeros es: " & (num1 - num2))

            Case 3 : Console.Write("Primer nº que desea multiplicar: ")
                num1 = Console.ReadLine()
                Console.Write("Segundo nº que desea multiplicar: ")
                num2 = Console.ReadLine()
                Console.WriteLine("La multiplicación de ambos numeros es: " & (num1 * num2))

            Case 4 : Console.Write("Primer nº que desea dividir: ")
                num1 = Console.ReadLine()
                Console.Write("Segundo nº que desea dividir: ")
                num2 = Console.ReadLine()
                Console.WriteLine("La división de ambos numeros es: " & (num1 / num2))

            Case 5 : Console.Write("Primer nº que desea dividir: ")
                num1 = Console.ReadLine()
                Console.Write("Segundo nº que desea dividir: ")
                num2 = Console.ReadLine()
                Console.WriteLine("El resto de la división es: " & (num1 Mod num2))

            Case Else

                Console.WriteLine("la opción introducida NO es válida")

        End Select




    End Sub

End Module
