Public Class Producto

    Private codigo As String
    Private descripcion As String
    Private precioU As Double
    Private Shared indiceCodigo As Integer = 1

    Public Sub New(des As String, pu As Double)

        codigo = "AR00" + CStr(indiceCodigo)
        indiceCodigo += 1
        descripcion = des
        precioU = pu

    End Sub

    Public Property Codigo_Producto As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Public Property Descripcion_Producto As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

    Public Property PrecioU_Producto As String
        Get
            Return precioU
        End Get
        Set(value As String)
            precioU = value
        End Set
    End Property

End Class
