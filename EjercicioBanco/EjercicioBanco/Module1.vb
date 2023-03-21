Module Module1

    Sub Main()

        Dim cuenta1 As New CuentaAhorros(New Cliente("Maria", "123", "Calle Alegria", "666666666"), 500)

        Console.WriteLine("Saldo actual: " & cuenta1.SaldoCliente() & " Cliente: " & cuenta1.ClienteCuenta.NombreCliente)

        cuenta1.depositarDinero(500)

        Console.WriteLine("Saldo actual: " & cuenta1.SaldoCliente() & " Cliente: " & cuenta1.ClienteCuenta.NombreCliente)

        cuenta1.retirarDinero(250)

        Console.WriteLine("Saldo actual: " & cuenta1.SaldoCliente() & " Cliente: " & cuenta1.ClienteCuenta.NombreCliente)

    End Sub

End Module
