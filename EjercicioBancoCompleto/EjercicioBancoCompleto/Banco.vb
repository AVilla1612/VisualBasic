Public Class Banco

    Private nomBanco As String
    Private cuentas() As CuentaAhorros

    Public Sub New(nomB As String)

        nomBanco = nomB
        cuentas = New CuentaAhorros(20) {}

    End Sub

    Public Sub CrearCuentaCliente(cl As Cliente, saldo As Double)

        For i = 0 To cuentas.Length - 1 Step 1

            If cuentas(i) Is Nothing Then

                cuentas(i) = New CuentaAhorros(cl, saldo)

                Exit For
            End If

        Next

    End Sub

    Public Sub DepositarDineroCuenta(numCuenta As Integer, valor As Double)

        cuentas(numCuenta - 1).depositarDinero(valor)

    End Sub

    Public Sub RetirarDineroCuenta(numCuenta As Integer, valor As Double)

        cuentas(numCuenta - 1).retirarDinero(valor)

    End Sub

    Public Function getSaldoCuenta(numCuenta As Integer)

        Return cuentas(numCuenta - 1).SaldoCliente

    End Function

    Public Function buscarCuentaCliente(dni As String) As CuentaAhorros

        Dim cuentaCliente As CuentaAhorros = Nothing

        For i = 0 To cuentas.Length - 1 Step 1

            If dni.Equals(cuentas(i).ClienteCuenta.DniCliente) Then

                cuentaCliente = cuentas(i)

                Exit For

            End If

        Next

        Return cuentaCliente

    End Function

End Class
