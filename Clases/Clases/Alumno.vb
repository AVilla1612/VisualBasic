Public Class Alumno

    Private idAlumno As Integer
    Private nombre As String

    Private Shared id As String = 1

    Public Sub New(nom As String)

        nombre = nom
        idAlumno = id
        id += 1

    End Sub

    Public Function getIdAlumno()

        Return idAlumno

    End Function

    Public Function getNombre()

        Return nombre

    End Function


End Class
