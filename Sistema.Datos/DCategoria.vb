Imports Sistema.Entidades
Imports System.Data.SqlClient

Public Class DCategoria

    Inherits Conexcion

    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand(
                "categoria_listar", MyBase.conn)
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
            Dim comando As New SqlCommand("categoria_buscar", MyBase.conn)
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

    Public Sub Insertar(obj As Categoria)
        Try

            Dim comando As New SqlCommand("categoria_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre1
            comando.Parameters.Add("@codigo", SqlDbType.Text).Value = obj.Codigo1


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(obj As Categoria)

        Try

            Dim comando As New SqlCommand("categoria_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.Idcategoria1
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre1
            comando.Parameters.Add("@codigo", SqlDbType.Text).Value = obj.Codigo1


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub Eliminar(id As Integer)
        Try

            Dim comando As New SqlCommand("categoria_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Desactivar(id As Integer)
        Try


            Dim comando As New SqlCommand("categoria_desactivar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id

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
            Dim Comando As New SqlCommand("categoria_seleccionar", MyBase.conn)
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

    Public Sub Activar(id As Integer)

        Try


            Dim comando As New SqlCommand("categoria_activar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = id

            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub




End Class
