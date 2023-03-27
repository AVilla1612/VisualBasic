Imports System.Data.OleDb
Imports System.Runtime.Remoting.Messaging

Public Class Conexion

    Protected conexion As New OleDbConnection()

    Public Function conectar() As Boolean

        Try

            conexion.Open()
            Return True


        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try

    End Function

    Public Sub desconectar()

        Try

            If conexion.State = ConnectionState.Open Then

                conexion.Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

End Class
