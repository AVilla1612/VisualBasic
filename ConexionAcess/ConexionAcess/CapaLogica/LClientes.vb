Imports System.Data.OleDb
Imports System.Runtime.InteropServices.WindowsRuntime

Public Class LClientes

    Public Function insertarCliente(nom As String, nId As String, tel As String)

        Dim dc As New DClientes(nom, nId, tel)

        If dc.insertarCliente(dc) = True Then

            Return True

        Else

            Return False

        End If

    End Function

    Public Function consultarCliente(numId As String) As String()

        Try

            Dim dc As New DClientes

            Dim cte() As String = dc.consultarCliente(numId)

            Return cte

        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing

        End Try

    End Function

End Class
