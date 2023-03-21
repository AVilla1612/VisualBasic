Module Module1

    Sub Main()

        Console.Write("Inserte el valor total de la compra: ")

        Dim valorCompra = Console.ReadLine()

        Dim descuento As Double = 0

        If valorCompra >= 500 And valorCompra <= 100 Then

            descuento = valorCompra * 0.05

        ElseIf valorCompra > 100 And valorCompra <= 150 Then

            descuento = valorCompra * 0.1

        ElseIf valorCompra > 150 Then

            descuento = valorCompra * 0.15

        End If

        Console.WriteLine("El valor total de la compra SIN descuento es: " & valorCompra)

        Console.WriteLine("El valor total de la compra CON descuento es: " & valorCompra - descuento)

        Console.WriteLine("El descuento total es: " & descuento)


    End Sub

End Module
