Public Class Computador

    Private _idcomputador As Integer
    Private _equipo As String
    Private _usuario As String
    Private _precio As Decimal
    Private _Componentes As String
    Private _idcentrodecosto As Integer
    Private _idarea As Integer
    Private _fecha_ingreso As Date
    Private _fecha_traspaso As Date
    Private _Anydesk As String
    Private _oficce As String
    Private _microsof As String
    Private _VersionMicrosoft As String
    Private _ipEquipo As String
    Private _estado As Boolean

    Public Property Idcomputador As Integer
        Get
            Return _idcomputador
        End Get
        Set(value As Integer)
            _idcomputador = value
        End Set
    End Property

    Public Property Equipo As String
        Get
            Return _equipo
        End Get
        Set(value As String)
            _equipo = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
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

    Public Property Componentes As String
        Get
            Return _Componentes
        End Get
        Set(value As String)
            _Componentes = value
        End Set
    End Property

    Public Property Idcentrodecosto As Integer
        Get
            Return _idcentrodecosto
        End Get
        Set(value As Integer)
            _idcentrodecosto = value
        End Set
    End Property

    Public Property Idarea As Integer
        Get
            Return _idarea
        End Get
        Set(value As Integer)
            _idarea = value
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

    Public Property Fecha_traspaso As Date
        Get
            Return _fecha_traspaso
        End Get
        Set(value As Date)
            _fecha_traspaso = value
        End Set
    End Property

    Public Property Anydesk As String
        Get
            Return _Anydesk
        End Get
        Set(value As String)
            _Anydesk = value
        End Set
    End Property

    Public Property Oficce As String
        Get
            Return _oficce
        End Get
        Set(value As String)
            _oficce = value
        End Set
    End Property

    Public Property Microsof As String
        Get
            Return _microsof
        End Get
        Set(value As String)
            _microsof = value
        End Set
    End Property

    Public Property IpEquipo As String
        Get
            Return _ipEquipo
        End Get
        Set(value As String)
            _ipEquipo = value
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

    Public Property VersionMicrosoft As String
        Get
            Return _VersionMicrosoft
        End Get
        Set(value As String)
            _VersionMicrosoft = value
        End Set
    End Property
End Class
