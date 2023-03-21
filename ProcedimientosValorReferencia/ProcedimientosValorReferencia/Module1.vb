Module Module1

    Sub Main()

        Dim numero As Integer = 16
        Console.WriteLine(numero & vbCr)
        cambiarValor(numero, 12)
        Console.WriteLine(numero)

    End Sub

    Sub cambiarValor(ByRef num As Integer, numNuevo As Integer)

        num = numNuevo

    End Sub

End Module
