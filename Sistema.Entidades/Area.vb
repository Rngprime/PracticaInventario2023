Public Class Area
    Private _idarea As Integer
    Private _nombre As String
    Private _codigodescripcion As String

    Public Property Idarea As Integer
        Get
            Return _idarea
        End Get
        Set(value As Integer)
            _idarea = value
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
