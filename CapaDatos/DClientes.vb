Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml

Public Class DClientes
    Inherits Conexion

    Private idCliente As Integer
    Private nombre As String
    Private numId As String
    Private telefono As String

    Private cmd As SqlCommand

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

    Public Function consultarCliente(numId As String) As DataTable

        Try

            conectar()

            cmd = New SqlCommand("SELECT ID_CLIENTE,NOMBRE,TELEFONO FROM CLIENTES WHERE NUM_ID='" & numId & "'")

            cmd.Connection = conexion

            If cmd.ExecuteNonQuery Then

                Dim dt As New DataTable
                Dim adp As New SqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function

    Public Function insertarCliente(dc As DClientes) As Boolean

        Try

            conectar()

            Dim sql As String = "INSERT INTO CLIENTES(NOMBRE,NUM_ID,TELEFONO)VALUES('" & dc.NombreCLiente & "','" & dc.NumIdCliente & "','" & dc.TelefonoCliente & "')"

            cmd = New SqlCommand(sql, conexion)

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

    Public Function actualizarCliente(cte As DClientes) As Boolean

        Try

            conectar()

            cmd = New SqlCommand("UPDATE CLIENTES SET NOMBRE='" & cte.NombreCLiente & "',NUM_ID='" & cte.NumIdCliente & "',TELEFONO='" & cte.TelefonoCliente & "'WHERE NUM_ID='" & cte.NumIdCliente & "'")

            cmd.Connection = conexion

            If cmd.ExecuteNonQuery Then

                MsgBox("Datos actualizados con éxito")
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

    Public Function eliminarCliente(numId As String) As Boolean

        Try

            conectar()

            cmd = New SqlCommand("DELETE FROM CLIENTES WHERE NUM_ID='" & numId & "'")

            cmd.Connection = conexion

            If cmd.ExecuteNonQuery Then

                MsgBox("El cliente ha sido eliminado con éxito")

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

    Public Function mostrarClientesTabla() As DataTable

        Try

            conectar()

            Dim Sql As String = "SELECT * FROM CLIENTES"

            cmd = New SqlCommand(Sql, conexion)

            If cmd.ExecuteNonQuery Then

                Dim dt As New DataTable

                Dim adp As New SqlDataAdapter(cmd)

                adp.Fill(dt)

                Return dt

            Else

                Return Nothing

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

            Return Nothing

        End Try

    End Function


End Class
