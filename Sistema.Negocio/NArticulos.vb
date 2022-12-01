Imports Sistema.Datos
Imports Sistema.Entidades

Public Class NArticulos

    Public Function Listar() As DataTable
        Try
            Dim Datos As New DArticulos

            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing


        End Try

    End Function




    Public Function Buscar(valor As String) As DataTable
        Try
            Dim Datos As New DArticulos
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function Buscar1(valor As String) As DataTable

        Try
            Dim Datos As New DArticulos
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar1(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function Buscar_codigo(valor As String) As DataTable

        Try
            Dim Datos As New DArticulos
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar1(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function Insertar(Obj As Articulos) As Boolean
        Try
            Dim Datos As New DArticulos

            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Public Function Actualizar(Obj As Articulos) As Boolean
        Try
            Dim Datos As New DArticulos
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulos
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulos
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArticulos
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



End Class
