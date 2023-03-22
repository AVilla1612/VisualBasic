Public Class CuentaAhorros

    Private numCuenta As Integer
    Private saldo As Double
    Private cte As Cliente

    Private Shared darNumeroCuenta As Integer = 1

    Public Sub New(numCuenta As Integer, saldo As Double, cte As Cliente)
        Me.numCuenta = numCuenta
        Me.saldo = saldo
        Me.cte = cte
    End Sub

    Public Sub New()

        numCuenta = darNumeroCuenta
        saldo = 0
        cte = Nothing

        darNumeroCuenta += 1

    End Sub

    Public Sub New(cl As Cliente, sa As Double)

        numCuenta = darNumeroCuenta
        saldo = sa
        cte = cl

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
            Return cte
        End Get
        Set(value As Cliente)
            If cte Is Nothing Then

                cte = value

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
