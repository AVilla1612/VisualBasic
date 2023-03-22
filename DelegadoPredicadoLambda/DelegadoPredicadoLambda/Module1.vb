Module Module1

    Sub Main()

        'Dim persona1 As New Persona("Luis", 22)

        'Dim encargado1 As New Encargado(AddressOf persona1.ToString)

        'Console.WriteLine(encargado1())

        Dim listaPersona As New List(Of Persona)

        listaPersona.Add(New Persona("Luis", 22))
        listaPersona.Add(New Persona("Carmen", 21))
        listaPersona.Add(New Persona("Hugo", 19))
        listaPersona.Add(New Persona("Lucia", 18))

        'Dim objetoPredicado As New Predicate(Of Persona)(AddressOf MenoresVeinte)

        Dim listaMenor20 As List(Of Persona) = listaPersona.FindAll(Function(p) p.EdadPersona < 20)

    End Sub

    'Delegate Function Encargado()

    'Function MenoresVeinte(p As Persona) As Boolean

    '    If p.EdadPersona < 20 Then

    '        Return True

    '    Else

    '        Return False

    '    End If

    'End Function


End Module
