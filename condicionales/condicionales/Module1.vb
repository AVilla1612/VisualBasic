Module Module1

    Sub Main()

        Dim estudia As Boolean = False

        Console.Write("Ingrese la cantidad de dinero ahorrado: ")

        Dim dineroAhorrado As Double = Console.ReadLine()

        If dineroAhorrado >= 600 Then

            estudia = True

        End If

        If estudia = True Then

            Console.WriteLine("El dinero ahorrado permite estudiar en la universidad")

        Else

            Console.WriteLine("El dinero ahorrado NO permite estudiar en la universidad")

        End If

    End Sub

End Module
