Public Class AsignacionPeriferico

    Private _idAsignacionPeriferico As Integer
    Private _idcomputador As Integer
    Private _fecha As Date
    Private _iva As Decimal
    Private _total As Decimal
    Private _estado As String


    Public Property IdAsignacionPeriferico As Integer
        Get
            Return _idAsignacionPeriferico
        End Get
        Set(value As Integer)
            _idAsignacionPeriferico = value
        End Set
    End Property

    Public Property Idcomputador As Integer
        Get
            Return _idcomputador
        End Get
        Set(value As Integer)
            _idcomputador = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Iva As Decimal
        Get
            Return _iva
        End Get
        Set(value As Decimal)
            _iva = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
End Class
