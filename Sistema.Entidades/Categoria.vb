Public Class Categoria
    Private idcategoria As Integer
    Private nombre As String
    Private codigo As String
    Private estado As Boolean

    Public Property Idcategoria1 As Integer
        Get
            Return idcategoria
        End Get
        Set(value As Integer)
            idcategoria = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Codigo1 As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Public Property Estado1 As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property
End Class
