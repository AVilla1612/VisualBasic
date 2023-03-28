Public Class FrmGenerarReport
    Private Sub btnGenerarReporte_Click(sender As Object, e As EventArgs) Handles btnGenerarReporte.Click

        Try

            Dim frmRC As New FrmReportCliente

            frmRC.generarReporte(txtGenerarReporte.Text)

            frmRC.Show()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub
End Class