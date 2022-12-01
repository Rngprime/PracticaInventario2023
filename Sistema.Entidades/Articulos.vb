Public Class Articulos
    Private _idarticulo As Integer
    Private _idcategoria As Integer
    Private _codigo As String
    Private _nombre As String
    Private _precio As Decimal
    Private _stock As Integer
    Private _marca As String
    Private _descripcion As String
    Private _fecha_ingreso As Date
    Private _estado As Boolean

    Public Property Idarticulo As Integer
        Get
            Return _idarticulo
        End Get
        Set(value As Integer)
            _idarticulo = value
        End Set
    End Property

    Public Property Idcategoria As Integer
        Get
            Return _idcategoria
        End Get
        Set(value As Integer)
            _idcategoria = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property

    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property Fecha_ingreso As Date
        Get
            Return _fecha_ingreso
        End Get
        Set(value As Date)
            _fecha_ingreso = value
        End Set
    End Property
End Class
