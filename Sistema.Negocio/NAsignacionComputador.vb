Imports Sistema.Datos
Imports Sistema.Entidades


Public Class NAsignacionComputador

    Public Function Listar() As DataTable
        Try
            Dim Datos As New DAsignacionPeriferico
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New DAsignacionPeriferico
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ListarDetalle(Id As Integer) As DataTable
        Try
            Dim Datos As New DAsignacionPeriferico
            Dim Tabla As New DataTable
            Tabla = Datos.ListarDetalle(Id)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Anular(Id As Integer) As Boolean
        Try
            Dim Datos As New DAsignacionPeriferico
            Datos.Anular(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Insertar(Obj As AsignacionPeriferico) As Boolean ', Det As DataTable) As Boolean
        Try
            Dim Datos As New DAsignacionPeriferico
            Datos.Insertar(Obj) ', Det)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function InsertarPrueba(Obj As AsignacionPeriferico) As Boolean
        Try
            Dim Datos As New DAsignacionPeriferico

            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



End Class
