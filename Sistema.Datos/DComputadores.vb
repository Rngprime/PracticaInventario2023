Imports Sistema.Entidades
Imports System.Data.SqlClient

Public Class DComputadores

    Inherits Conexcion



    Public Function Listar() As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand(
                "computador_listar", MyBase.conn)
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

    Public Sub Insertar(obj As Computador)
        Try

            Dim comando As New SqlCommand("computador_insertar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcentrodecosto", SqlDbType.Int).Value = obj.Idcentrodecosto
            comando.Parameters.Add("@idarea", SqlDbType.Int).Value = obj.Idarea
            comando.Parameters.Add("@equipo", SqlDbType.VarChar).Value = obj.Equipo
            comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = obj.Usuario
            comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = obj.Precio
            comando.Parameters.Add("@componentes", SqlDbType.VarChar).Value = obj.Componentes
            comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = obj.Fecha_ingreso
            comando.Parameters.Add("@fecha_traspaso", SqlDbType.Date).Value = obj.Fecha_traspaso
            comando.Parameters.Add("@anydesk", SqlDbType.VarChar).Value = obj.Anydesk
            comando.Parameters.Add("@oficce", SqlDbType.VarChar).Value = obj.Oficce
            comando.Parameters.Add("@microsof", SqlDbType.VarChar).Value = obj.Microsof
            comando.Parameters.Add("@VersionMicrosoft", SqlDbType.VarChar).Value = obj.VersionMicrosoft

            comando.Parameters.Add("@ipEquipo", SqlDbType.VarChar).Value = obj.IpEquipo

            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Function Buscar(valor As String) As DataTable
        Try
            Dim resultado As SqlDataReader
            Dim tabla As New DataTable
            Dim comando As New SqlCommand("computador_buscar", MyBase.conn)
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

    Public Sub Actualizar(obj As Computador)

        Try

            Dim comando As New SqlCommand("computador_actualizar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcomputador", SqlDbType.Int).Value = obj.Idcomputador
            comando.Parameters.Add("@idcentrodecosto", SqlDbType.Int).Value = obj.Idcentrodecosto
            comando.Parameters.Add("@idarea", SqlDbType.Int).Value = obj.Idarea
            comando.Parameters.Add("@equipo", SqlDbType.VarChar).Value = obj.Equipo
            comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = obj.Usuario
            comando.Parameters.Add("@precio", SqlDbType.Decimal).Value = obj.Precio
            comando.Parameters.Add("@componentes", SqlDbType.VarChar).Value = obj.Componentes
            comando.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = obj.Fecha_ingreso
            comando.Parameters.Add("@fecha_traspaso", SqlDbType.Date).Value = obj.Fecha_traspaso
            comando.Parameters.Add("@anydesk", SqlDbType.VarChar).Value = obj.Anydesk
            comando.Parameters.Add("@oficce", SqlDbType.VarChar).Value = obj.Oficce
            comando.Parameters.Add("@microsof", SqlDbType.VarChar).Value = obj.Microsof
            comando.Parameters.Add("@VersionMicrosoft", SqlDbType.VarChar).Value = obj.VersionMicrosoft

            comando.Parameters.Add("@ipEquipo", SqlDbType.VarChar).Value = obj.IpEquipo



            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub Eliminar(id As Integer)
        Try

            Dim comando As New SqlCommand("computador_eliminar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcomputador", SqlDbType.Int).Value = id


            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Desactivar(id As Integer)
        Try


            Dim comando As New SqlCommand("computador_desactivar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcomputador", SqlDbType.Int).Value = id

            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub




    Public Sub Activar(id As Integer)

        Try


            Dim comando As New SqlCommand("computador_activar", MyBase.conn)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@idcomputador", SqlDbType.Int).Value = id

            MyBase.conn.Open()
            comando.ExecuteNonQuery()
            MyBase.conn.Close()


        Catch ex As Exception
            Throw ex
        End Try

    End Sub





End Class
