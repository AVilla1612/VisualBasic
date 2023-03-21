Module Module1

    Sub Main()

        'Dim nombres = New String() {"maria", "pedro", "juan", "daniela", "luis", "lucia"}'

        Dim nombres(6) As String

        nombres(0) = "Pedro"
        nombres(1) = "Luis"
        nombres(2) = "Juan"
        nombres(3) = "Lucia"
        nombres(4) = "Carmen"
        nombres(5) = "Daniela"

        For Each nom As String In nombres

            Console.WriteLine(nom)



        Next




    End Sub

End Module
