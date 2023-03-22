Module Module1

    Sub Main()

        'Dim persona1 As New Persona()'

        Dim estudiantes(2) As Estudiante

        estudiantes(0) = New Estudiante("Juan", "CC", "123", 22, "Calle Alegria", "696887744", True)
        estudiantes(1) = New Universitario("Luis", "CC", "446", 29, "Calle Vivienda", "696889944", True, "Medicina")
        estudiantes(2) = New EstudiantePostgrado("Ana", "CC", "665", 26, "Calle Entusiasmo", "696887722", False, "Desarrollador Software")

        Array.Sort(estudiantes)

        For Each est As Estudiante In estudiantes

            est.DarDescripcion()

        Next

    End Sub

End Module
