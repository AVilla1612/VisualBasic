Module Module1

    Sub Main()

        Dim lista As New LinkedList(Of Integer)

        lista.AddFirst(12)
        lista.AddFirst(New LinkedListNode(Of Integer)(20))

        lista.AddLast(6)
        lista.AddLast(New LinkedListNode(Of Integer)(30))

        lista.Remove(20)
        lista.RemoveLast()

        Dim nodo As LinkedListNode(Of Integer) = lista.First

        While nodo IsNot Nothing

            Console.WriteLine(nodo.Value)

            nodo = nodo.Next

        End While

    End Sub

End Module
