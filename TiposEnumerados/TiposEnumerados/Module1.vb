Module Module1

    Sub Main()

        Dim aire As New AireAcondicionado("Ramsung", "Blanco", 110, 12000, 0, AireAcondicionado.TAireAcondicionado.Split)
        Dim aire1 As New AireAcondicionado("RamsungG", "Negro", 111, 12000, 0, AireAcondicionado.TAireAcondicionado.Ventana)

        Console.WriteLine("Tipo de aire: " & aire.getTipo)
        Console.WriteLine("Tipo de aire: " & aire1.getTipo)

    End Sub

End Module
