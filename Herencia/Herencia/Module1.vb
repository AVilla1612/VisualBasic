Module Module1

    Sub Main()

        'Dim cuenta1 As New CuentaAhorros(New Cliente("Maria", "123", "Calle Alegria", "666666666"), 500)

        'Console.WriteLine(cuenta1.SaldoCliente())

        'cuenta1.retirarDinero(501)

        'Console.WriteLine(cuenta1.SaldoCliente())

        Dim cuentas(2) As CuentaAhorros

        For i = 0 To 2 Step 1

            Dim nom, ce, dir, tel As String
            Dim saldo As Double
            Console.Write("Ingrese los valores para la cuenta nº " & (i + 1))
            Console.WriteLine(" ")
            Console.Write("Ingrese nombre de cliente: ")
            nom = Console.ReadLine()

            Console.Write("Ingrese la celula de cliente: ")
            ce = Console.ReadLine()

            Console.Write("Ingrese la direccion de cliente: ")
            dir = Console.ReadLine()

            Console.Write("Ingrese el numero de telefono de cliente: ")
            tel = Console.ReadLine()

            Console.Write("Ingrese el saldo inicial del cliente: ")
            saldo = Console.ReadLine()

            Console.WriteLine("-------------------------")

            Dim cuenta As New CuentaAhorros(New Cliente(nom, ce, dir, tel), saldo)

            cuentas(i) = cuenta

        Next

        For Each c As CuentaAhorros In cuentas

            Console.WriteLine("-------------------------")
            Console.WriteLine("Nº Cuenta: " & c.NumCuentaCliente)
            Console.WriteLine("Nombre Cliente: " & c.ClienteCuenta.NombrePersona)
            Console.WriteLine("saldo Actual: " & c.SaldoCliente)
        Next

    End Sub

End Module
