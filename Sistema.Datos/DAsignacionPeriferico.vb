Imports Sistema.Entidades
Imports System.Data.SqlClient


Public Class DAsignacionPeriferico

    Inherits Conexcion


    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("AsignacionPeriferico_listar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("AsignacionPeriferico_buscar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarDetalle(Id As Integer) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("detalle_Asignacion_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idventa", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Anular(Id As Integer)
        Try
            Dim Comando As New SqlCommand("AsignacionPeriferico_anular", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idAsignacionPeriferico", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Public Sub Insertar(Obj As AsignacionPeriferico)   ', Det As DataTable)
        Try
            Dim Comando As New SqlCommand("detalle_Asignacion_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idAsignacionPeriferico", SqlDbType.Int).Value = Obj.IdAsignacionPeriferico
            Comando.Parameters("@idAsignacionPeriferico").Direction = ParameterDirection.Output
            Comando.Parameters.Add("@idcomputador", SqlDbType.Int).Value = Obj.Idcomputador
            Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = Obj.Fecha
            Comando.Parameters.Add("@iva", SqlDbType.Decimal).Value = Obj.Iva
            Comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.Total
            '  Comando.Parameters.Add("@Detalle", SqlDbType.Structured).Value = Det

            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub InsertarPrueba(obj As AsignacionPeriferico)
        Try

            Dim comando As New SqlCommand("insertar_prueba", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idAsignacionPeriferico", SqlDbType.Int).Value = obj.IdAsignacionPeriferico
            comando.Parameters.Add("@idcomputador", SqlDbType.Int).Value = obj.Idcomputador
            comando.Parameters.Add("@iva", SqlDbType.Decimal).Value = obj.Iva
            comando.Parameters.Add("@total", SqlDbType.Decimal).Value = obj.Total


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub






End Class
