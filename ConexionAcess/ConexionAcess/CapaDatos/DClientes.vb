Imports System.Data.OleDb
Public Class DClientes
    Inherits Conexion

    Private idCliente As Integer
    Private nombre As String
    Private numId As String
    Private telefono As String

    Private cmd As OleDbCommand

    Private dr As OleDbDataReader

    Public Sub New(nom As String, nId As String, tel As String)

        nombre = nom
        numId = nId
        telefono = tel

    End Sub

    Public Sub New()

    End Sub

    Public Property NombreCLiente As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property NumIdCliente As String
        Get
            Return numId
        End Get
        Set(value As String)
            numId = value
        End Set
    End Property

    Public Property TelefonoCliente As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Function consultarCliente(numId As String) As String()

        Try

            conectar()

            cmd = New OleDbCommand("SELECT ID_CLIENTE,NOMBRE,TELEFONO FROM CLIENTES WHERE NUM_ID='" & numId & "'")

            cmd.Connection = conexion

            dr = cmd.ExecuteReader

            If dr.Read Then

                Dim cte = New String() {dr.Item("ID_CLIENTE"), dr.Item("NOMBRE"), dr.Item("TELEFONO")}

                Return cte

                dr.Close()

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        Finally

            desconectar()

        End Try

    End Function

    Public Function insertarCliente(dc As DClientes) As Boolean

        Try

            conectar()

            Dim sql As String = "INSERT INTO CLIENTES(NOMBRE,NUM_ID,TELEFONO)VALUES('" & dc.NombreCLiente & "','" & dc.NumIdCliente & "','" & dc.TelefonoCliente & "')"

            cmd = New OleDbCommand(sql, conexion)

            If cmd.ExecuteNonQuery() Then

                MsgBox("El cliente se ha ingresado correctamente")
                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        Finally

            desconectar()

        End Try

    End Function
End Class
