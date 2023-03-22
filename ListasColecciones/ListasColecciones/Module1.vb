Module Module1

    Sub Main()

        Dim miLista As New List(Of Integer) From {1, 2, 3, 4, 5, 6}

        Dim copiaLista() As Integer = miLista.ToArray

        For i = 0 To miLista.Count - 1 Step 1

            Console.Write(miLista(i) & " ")

        Next

        Console.WriteLine(" ")

        For Each elemento As Integer In copiaLista

            Console.Write(elemento & " ")

        Next

    End Sub

End Module
