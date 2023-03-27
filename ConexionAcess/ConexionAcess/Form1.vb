Imports System.Data.OleDb
Public Class Form1

    Private conexion As New OleDbConnection()
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        Try

            conexion.Open()

            MsgBox("Conexión realizada con éxito")

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            conexion.Close()

        End Try

    End Sub
End Class
