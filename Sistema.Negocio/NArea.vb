Imports Sistema.Datos
Imports Sistema.Entidades
Public Class NArea

    Public Function Listar() As DataTable
        Try
            Dim Datos As New DArea

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
            Tabla = Datos.Buscar(valor)
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function Seleccionar() As DataTable
        Try
            Dim Datos As New DArea

            Dim Tabla As New DataTable
            Tabla = Datos.Seleccionar()
            Return Tabla
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function Insertar(Obj As Area) As Boolean
        Try
            Dim Datos As New DArea

            Datos.Insertar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function Actualizar(Obj As Area) As Boolean
        Try
            Dim Datos As New DArea
            Datos.Actualizar(Obj)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Try
            Dim Datos As New DArea
            Datos.Eliminar(Id)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function




    Dim Datos As New DArea
    Dim Tabla As New DataTable


End Class
