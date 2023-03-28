Imports Microsoft.Reporting.WinForms

Public Class FrmReportCliente
    Private Sub FrmReportCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Public Sub generarReporte(numId As String)

        Try

            Dim dt As New DataTable
            Dim dc As New DClientes

            dt = dc.consultarCliente(numId)

            ReportViewer1.LocalReport.DataSources.Clear()

            Dim rpt As New ReportDataSource("dsCliente", dt)

            ReportViewer1.LocalReport.DataSources.Add(rpt)

            ReportViewer1.RefreshReport()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

End Class