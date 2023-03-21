Module Module1

    Sub Main()

        Dim suma As Integer = 1

        For i = 2 To 20 Step 1

            If i <> 20 Then

                Console.Write(suma & " , ")

            Else

                Console.Write(suma & " . ")

            End If



            suma = suma + i

        Next

    End Sub

End Module
