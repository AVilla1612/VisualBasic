Public Class AireAcondicionado

    Private marca As String
    Private modelo As String
    Private color As String
    Private voltaje As Integer
    Private temperatura As Integer
    Private tipo As Integer

    Public Sub New(marca As String, modelo As String, color As String, voltaje As Integer, temperatura As Integer, tipo As TAireAcondicionado)
        Me.marca = marca
        Me.modelo = modelo
        Me.color = color
        Me.voltaje = voltaje
        Me.temperatura = temperatura
        Me.tipo = CType(tipo, Integer)
    End Sub


    Public Enum TAireAcondicionado

        Ventana = 101
        Split = 102

    End Enum

    'Public Property marcaAire As String
    '    Get
    '        Return marca
    '    End Get
    '    Set(value As String)
    '        marca = value
    '    End Set
    'End Property

    'Public Property modeloAire As String
    '    Get
    '        Return modelo
    '    End Get
    '    Set(value As String)
    '        modelo = value
    '    End Set
    'End Property

    Public Sub setMarca(ma As String)

        marca = ma

    End Sub
    Public Sub setModelo(ma As String)

        marca = ma

    End Sub
    Public Sub setColor(co As String)

        color = co

    End Sub
    Public Sub setVoltaje(vo As String)

        voltaje = vo

    End Sub
    Public Sub setTempetatura(te As String)

        temperatura = te

    End Sub

    Public Sub setTipo(ti As Integer)

        tipo = ti

    End Sub

    Public Function getTipo() As Integer

        Return tipo

    End Function

    Public Function getMarca() As String

        Return marca

    End Function
    Public Function getModelo() As String

        Return modelo

    End Function
    Public Function getColor() As String

        Return color

    End Function
    Public Function getVoltaje() As String

        Return voltaje

    End Function
    Public Function getTemperatura() As String

        Return temperatura

    End Function

    Public Overloads Sub subirTemperatura()

        If temperaturaActual() < 30 Then

            temperatura += 1

        End If

    End Sub

    Public Overloads Sub subirTemperatura(grados As Integer)

        Dim temp As Integer = temperatura + grados

        If temp > 30 Then

            temperatura = 30

        Else

            temperatura = temp

        End If

    End Sub

    Public Overloads Sub bajarTemperatura()

        If temperatura > 17 Then

            temperatura -= 1

        End If

    End Sub

    Public Overloads Sub bajarTemperatura(grados)

        Dim temp As Integer = temperatura - grados

        If temp < 17 Then

            temperatura = 17

        Else

            temperatura = temp

        End If

    End Sub


    Function temperaturaActual() As Integer

        Return temperatura

    End Function

End Class
