Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NComputador

    Public Function Listar() As DataTable
        Try
            Dim Datos As New DComputadores

            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing


        End Try

    End Function

    Public Function Actualizar(Obj As Computador) As Boolean
        Try
            Dim Datos As New DComputadores
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Insertar(Obj As Computador) As Boolean
        Try
            Dim Datos As New DComputadores

            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function Buscar(valor As String) As DataTable
        Try
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DComputadores
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Try
            Dim Datos As New DComputadores
            Datos.Desactivar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Try
            Dim Datos As New DComputadores
            Datos.Activar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function





    Dim Datos As New DComputadores
    Dim Tabla As New DataTable


End Class
