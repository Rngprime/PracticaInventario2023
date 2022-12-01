Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class DArea

    Inherits Conexcion

    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand(
                "area_listar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla

        Catch ex As Exception
            Throw ex
        End Try


    End Function


    Public Function Buscar(valor As String) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("area_buscar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor
            MyBase.conn.Open()
            resultado = comando.ExecuteReader()
            tabla.Load(resultado)
            MyBase.conn.Close()
            Return tabla

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Insertar(obj As Area)
        Try

            Dim comando As New SqlCommand("area_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@codigo_descripcion", SqlDbType.Text).Value = obj.Codigodescripcion


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(obj As Area)

        Try

            Dim comando As New SqlCommand("area_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarea", SqlDbType.Int).Value = obj.Idarea
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@codigo_descripcion", SqlDbType.Text).Value = obj.Codigodescripcion


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub Eliminar(id As Integer)
        Try

            Dim comando As New SqlCommand("area_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarea", SqlDbType.Int).Value = id


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub




    Public Function Seleccionar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("area_seleccionar", MyBase.conn)
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


End Class
