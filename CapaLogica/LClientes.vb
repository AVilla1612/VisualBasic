Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class LClientes
    Inherits Conexion

    Public Function insertarCliente(nom As String, nId As String, tel As String)

        Dim dc As New DClientes(nom, nId, tel)

        If dc.insertarCliente(dc) = True Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function consultarCliente(numId As String) As DataTable

        Try

            Dim dc As New DClientes

            Dim dt As DataTable = dc.consultarCliente(numId)

            Return dt

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function

    Public Function actulizarCliente(nom As String, nId As String, tel As String) As Boolean

        Try

            Dim dc As New DClientes(nom, nId, tel)

            dc.actualizarCliente(dc)

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)

            Return False

        End Try

    End Function

    Public Function eliminarCliente(numId As String) As Boolean

        Try

            Dim dc As New DClientes

            dc.eliminarCliente(numId)

            Return True

        Catch ex As Exception

            MsgBox(ex.Message)

            Return False

        End Try

    End Function

    Public Function mostrarClientesTabla(numId) As DataTable

        Dim dc As New DClientes

        Try

            Dim dt As DataTable = dc.consultarCliente(numId)


            If dt IsNot Nothing Then

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
