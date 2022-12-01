﻿Public Class frmCategoria
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.listar()
        Me.Formato()
    End Sub

    Public Sub listar()
        Try
            Dim Neg As New Negocio.NCategorias
            DgvListado.DataSource = Neg.Listar()
            lblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            'LblPrecios.Text = "TOTAL SUMA PRODUCTOS" & Format(DgvListado.DataSource.Compute("SUM(Precio)"), "$ #,##0.000")

            Me.Formato()
            Me.limpiar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BUSCAR()
        Try
            Dim Neg As New Negocio.NCategorias

            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            lblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.BUSCAR()
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" Then
            Dim obj As New Entidades.Categoria
            Dim neg As New Negocio.NCategorias

            obj.Nombre1 = TxtNombre.Text
            obj.Codigo1 = TxtDescripcion.Text



            'obj.NombreEquipo = TxtEquipo.Text
            If (neg.Insertar(obj)) Then
                MsgBox("Se ha regristado Correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                Me.limpiar()
                Me.listar()
            Else
                MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro Incompleto")


            End If



        Else
            MsgBox("Rellene todos los datos Obligatorios (*)")

        End If
    End Sub

    Private Sub DgvListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentDoubleClick
        TxtId.Text = DgvListado.SelectedCells.Item(1).Value
        TxtNombre.Text = DgvListado.SelectedCells.Item(2).Value
        TxtDescripcion.Text = DgvListado.SelectedCells.Item(3).Value



        TabGneral.SelectedIndex = 1
        BtnActualizar.Visible = True
        BtnInsertar.Visible = False



    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtId.Text <> "" Then
            Dim obj As New Entidades.Categoria
            Dim neg As New Negocio.NCategorias
            obj.Idcategoria1 = TxtId.Text
            obj.Nombre1 = TxtNombre.Text
            obj.Codigo1 = TxtDescripcion.Text


            If (neg.Actualizar(obj)) Then
                MsgBox("Se ha Actualizado Correctamente", vbOKOnly + vbInformation, "Actualizacion  Correcto")
                Me.limpiar()
                Me.listar()
                TabGneral.SelectedIndex = 0
            Else
                MsgBox("No se ha podido Actualizar", vbOKOnly + vbCritical, "Actualizacion Incompleto")


            End If



        Else
            MsgBox("Rellene todos los datos Obligatorios (*)")

        End If
    End Sub

    Private Sub limpiar()
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False

        TxtId.Text = ""
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""

    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TabGneral.SelectedIndex = 0
        Me.limpiar()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Estas seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NCategorias
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Eliminar(OneKey)
                    End If
                Next
                Me.listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Estas seguro de activar los registros seleccionados?", vbYesNo + vbQuestion, "Activar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NCategorias
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Activar(OneKey)
                    End If
                Next
                Me.listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Estas seguro de desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NCategorias
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Desactivar(OneKey)
                    End If
                Next
                Me.listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub
    ' comportamiento del check 
    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub


    Private Sub ChbSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChbSeleccionar.CheckedChanged
        If ChbSeleccionar.CheckState = CheckState.Checked Then
            DgvListado.Columns.Item("Seleccionar").Visible = True
            BtnEliminar.Visible = True
            BtnActivar.Visible = True
            BtnDesactivar.Visible = True

        Else
            DgvListado.Columns.Item("Seleccionar").Visible = False
            BtnEliminar.Visible = False
            BtnActivar.Visible = False
            BtnDesactivar.Visible = False

        End If
    End Sub

    ' comportamiento de data 

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Width = 50
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(2).Width = 200


        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChbSeleccionar.CheckState = False

    End Sub
End Class