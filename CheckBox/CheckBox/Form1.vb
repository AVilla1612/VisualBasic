Public Class Form1
    Private Sub btnRespuesta_Click(sender As Object, e As EventArgs) Handles btnRespuesta.Click

        Dim puntos As Double = 0

        If cbClase.Checked = True Then

            puntos += 2.5

        End If

        If cbObjeto.Checked = True Then

            puntos += 2.5

        End If

        If cbHerencia.Checked = True Then

            puntos += 2.5

        End If

        If cbPolimorfismo.Checked = True Then

            puntos += 2.5

        End If

        If cbBucle.Checked = True Then

            puntos -= 2.5

        End If

        MsgBox("El total de puntos obtenidos es: " & puntos)

    End Sub
End Class
