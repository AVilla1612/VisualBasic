Public Class Cuenta

    Protected numCuenta As Integer
    Protected saldo As Double
    Protected cliente As Cliente
    Protected Shared id As Integer = 1
    Protected Shared darNumeroCuenta As Integer = 1

    Public Sub New()

        numCuenta = id
        cliente = Nothing
        saldo = 0

        id += 1

    End Sub

    Public Sub New(cl As Cliente, sa As Double)

        numCuenta = darNumeroCuenta
        saldo = sa
        cliente = cl

        darNumeroCuenta += 1

    End Sub

    Public Property NumCuentaCliente() As String
        Get
            Return numCuenta
        End Get
        Set(value As String)
            numCuenta = value
        End Set
    End Property

    Public Property SaldoCliente() As String
        Get
            Return saldo
        End Get
        Set(value As String)
            saldo = value
        End Set
    End Property

    Public Property ClienteCuenta() As Cliente
        Get
            Return cliente
        End Get
        Set(value As Cliente)
            If cliente Is Nothing Then

                cliente = value

            Else

                Console.WriteLine("El cliente ya está asignado a la cuenta")

            End If

        End Set

    End Property

    Public Sub depositarDinero(valor As Double)

        saldo = saldo + valor

    End Sub

    Public Sub retirarDinero(valor As Double)

        If saldo >= valor Then

            saldo -= valor

        Else

            Console.WriteLine("El saldo disponible es menor que el valor a retirar")

        End If


    End Sub


End Class
