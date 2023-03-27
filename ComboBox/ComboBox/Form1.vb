Public Class Form1

    Dim listaPersona As New List(Of Persona)

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If txtNombre.Text <> "" And txtNumId.Text <> "" And txtTelefono.Text <> "" And txtCorreo.Text <> "" Then

            Dim p As New Persona(txtNombre.Text, txtNumId.Text, txtTelefono.Text, txtCorreo.Text)

            listaPersona.Add(p)

            cmbPersonas.Items.Add(txtNumId.Text)

            txtNombre.Clear()
            txtNumId.Clear()
            txtTelefono.Clear()
            txtCorreo.Clear()

        Else

            MsgBox("Faltan datos por ingresar, revise todos los campos")

        End If

    End Sub

    Private Sub cmbPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPersonas.SelectedIndexChanged

        Dim numIdPersona As String = cmbPersonas.SelectedItem.ToString

        For i = 0 To listaPersona.Count - 1 Step 1

            If numIdPersona.Equals(listaPersona.Item(i).NumIdPersona) Then

                MsgBox(listaPersona.Item(i).ToString)

                Exit For

            End If

        Next

    End Sub
End Class
