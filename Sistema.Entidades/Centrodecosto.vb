Public Class Centrodecosto
    Private _idcentrodecosto As Integer
    Private _nombre As String
    Private _codigodescripcion As String

    Public Property Idcentrodecosto As Integer
        Get
            Return _idcentrodecosto
        End Get
        Set(value As Integer)
            _idcentrodecosto = value
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

    Public Property Codigodescripcion As String
        Get
            Return _codigodescripcion
        End Get
        Set(value As String)
            _codigodescripcion = value
        End Set
    End Property
End Class
