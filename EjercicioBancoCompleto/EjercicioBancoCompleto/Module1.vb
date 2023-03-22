Module Module1

    Sub Main()

        Dim banco As New Banco("CajaMurcia")

        banco.CrearCuentaCliente(New Cliente("Juan", "49224538Z", "Calle Alegria", "696334422"), 1000)
        banco.CrearCuentaCliente(New Cliente("Ana", "49594538L", "Calle Siempre Viva", "696666422"), 1600)
        banco.CrearCuentaCliente(New Cliente("Luis", "49744538Y", "Calle Miguel Hernandez", "696366622"), 1862)
        banco.CrearCuentaCliente(New Cliente("Carmen", "49594577S", "Calle Pintor Flores", "697776422"), 2400)

        banco.DepositarDineroCuenta(1, 600)
        banco.DepositarDineroCuenta(2, 400)
        banco.DepositarDineroCuenta(3, 200)
        banco.DepositarDineroCuenta(4, 100)

        Console.WriteLine("Saldo Cuenta 1: " & banco.getSaldoCuenta(1))
        Console.WriteLine("Saldo Cuenta 2: " & banco.getSaldoCuenta(2))
        Console.WriteLine("Saldo Cuenta 3: " & banco.getSaldoCuenta(3))
        Console.WriteLine("Saldo Cuenta 4: " & banco.getSaldoCuenta(4))

        Console.WriteLine(" ")

        banco.RetirarDineroCuenta(1, 200)
        banco.RetirarDineroCuenta(2, 200)
        banco.RetirarDineroCuenta(3, 200)
        banco.RetirarDineroCuenta(4, 200)

        Console.WriteLine("Saldo Cuenta 1: " & banco.getSaldoCuenta(1))
        Console.WriteLine("Saldo Cuenta 2: " & banco.getSaldoCuenta(2))
        Console.WriteLine("Saldo Cuenta 3: " & banco.getSaldoCuenta(3))
        Console.WriteLine("Saldo Cuenta 4: " & banco.getSaldoCuenta(4))

        Console.WriteLine(" ")

        Dim ca As CuentaAhorros = banco.buscarCuentaCliente("49224538Z")

        Console.WriteLine("Nº cuenta: " & ca.NumCuentaCliente)
        Console.WriteLine("Nombre cliente : " & ca.ClienteCuenta.NombreCliente)

        Console.WriteLine(" ")


    End Sub

End Module
