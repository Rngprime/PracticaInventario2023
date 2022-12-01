Imports Sistema.Entidades
Imports System.Data.SqlClient
Public Class DArticulos

    Inherits Conexcion



    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand(
                "articulo_listar", MyBase.conn)
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
            Dim comando As New SqlCommand("articulo_buscar", MyBase.conn)
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




    Public Function Buscar1(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("articulo_buscar1", MyBase.conn)
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

    Public Function Buscar_codigo(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("articulo_buscar_codigo_venta", MyBase.conn)
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

    Public Sub Insertar(obj As Articulos)
        Try

            Dim comando As New SqlCommand("articulo_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.Idcategoria
            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = obj.Codigo
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = obj.Precio
            comando.Parameters.Add("@stock", SqlDbType.Int).Value = obj.Stock
            comando.Parameters.Add("@marca", SqlDbType.VarChar).Value = obj.Marca
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion
            comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = obj.Fecha_ingreso



            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Actualizar(obj As Articulos)

        Try

            Dim comando As New SqlCommand("articulo_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.Idcategoria
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = obj.Idarticulo
            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = obj.Codigo
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre
            comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = obj.Precio
            comando.Parameters.Add("@stock", SqlDbType.Int).Value = obj.Stock
            comando.Parameters.Add("@marca", SqlDbType.VarChar).Value = obj.Marca
            comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.Descripcion
            comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = obj.Fecha_ingreso


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub Eliminar(id As Integer)
        Try

            Dim comando As New SqlCommand("articulo_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Desactivar(id As Integer)
        Try


            Dim comando As New SqlCommand("articulo_desactivar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id

            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub




    Public Sub Activar(id As Integer)

        Try


            Dim comando As New SqlCommand("articulo_activar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = id

            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub






End Class
