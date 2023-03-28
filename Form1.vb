Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1

    Private conexion As New SqlConnection("Data Source=DESKTOP-DT3S3H6;Initial Catalog=Prueba;Integrated Security=True")
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click

        Try

            conexion.Open()

            MsgBox("Conexion realizada con éxito")

        Catch ex As Exception

            MsgBox(ex.Message)

        Finally

            conexion.Close()

        End Try

    End Sub
End Class
