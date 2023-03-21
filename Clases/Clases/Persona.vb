Public Class Persona

    Public nombre As String
    Public apellidos As String
    Public direccion As String
    Public dni As Integer

    Public Sub New(nombre As String, apellidos As String, direccion As String, dni As Integer)
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.direccion = direccion
        Me.dni = dni
    End Sub

End Class
