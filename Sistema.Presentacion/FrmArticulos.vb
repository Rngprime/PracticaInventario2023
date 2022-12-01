Public Class FrmArticulos
    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargaCategorias()
        Me.Listar()
        Me.Formato()

    End Sub





    Private Sub CargaCategorias()

        Try
            Dim Neg As New Negocio.NCategorias
            CboComputador.DataSource = Neg.Seleccionar
            CboComputador.ValueMember = "idcategoria"
            CboComputador.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False

        DgvListado.Columns(0).Width = 50
        DgvListado.Columns(1).Width = 60
        DgvListado.Columns(4).Width = 60
        DgvListado.Columns(5).Width = 250
        DgvListado.Columns(6).Width = 80
        DgvListado.Columns(6).DefaultCellStyle.Format = "N2"
        DgvListado.Columns(7).Width = 50
        DgvListado.Columns(8).Width = 300

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False

        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChbSeleccionar.CheckState = False

    End Sub


    Private Sub limpiar()
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False


        CboComputador.Text = ""
        TxtCodigo.Text = ""
        txtNombre.Text = ""
        TxtStock.Text = ""
        Txtprecio.Text = ""
        TxtDescripcion.Text = ""
        TxtMarca.Text = ""
        DtpIngreso.Text = ""
        TxtId.Text = ""

    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NArticulos
            DgvListado.DataSource = Neg.Listar()
            lblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count

            Me.Formato()
            Me.limpiar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If Me.ValidateChildren = True And Txtprecio.Text <> "" And TxtStock.Text <> "" And txtNombre.Text <> "" Then
            Dim obj As New Entidades.Articulos
            Dim neg As New Negocio.NArticulos

            obj.Idcategoria = CboComputador.SelectedValue
            obj.Descripcion = TxtDescripcion.Text
            obj.Marca = TxtMarca.Text
            obj.Codigo = TxtCodigo.Text
            obj.Precio = Txtprecio.Text
            obj.Fecha_ingreso = DtpIngreso.Text
            obj.Nombre = txtNombre.Text
            obj.Stock = TxtStock.Text



            If (neg.Insertar(obj)) Then
                MsgBox("Se ha regristado Correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                Me.limpiar()
                Me.Listar()
            Else
                MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro Incompleto")


            End If

        Else
            MsgBox("Rellene todos los datos Obligatorios (*)")

        End If
    End Sub

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


    Private Sub DgvListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentDoubleClick
        CboComputador.Text = DgvListado.SelectedCells.Item(3).Value
        TxtCodigo.Text = DgvListado.SelectedCells.Item(4).Value
        txtNombre.Text = DgvListado.SelectedCells.Item(5).Value
        TxtStock.Text = DgvListado.SelectedCells.Item(7).Value
        Txtprecio.Text = DgvListado.SelectedCells.Item(6).Value
        TxtDescripcion.Text = DgvListado.SelectedCells.Item(8).Value
        TxtMarca.Text = DgvListado.SelectedCells.Item(9).Value
        DtpIngreso.Text = DgvListado.SelectedCells.Item(10).Value

        TxtId.Text = DgvListado.SelectedCells.Item(1).Value

        TabGneral.SelectedIndex = 1
        BtnActualizar.Visible = True
        BtnInsertar.Visible = False



    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And Txtprecio.Text <> "" And TxtStock.Text <> "" And txtNombre.Text <> "" Then
            Dim obj As New Entidades.Articulos
            Dim neg As New Negocio.NArticulos

            obj.Idcategoria = CboComputador.SelectedValue
            obj.Descripcion = TxtDescripcion.Text
            obj.Marca = TxtMarca.Text
            obj.Codigo = TxtCodigo.Text
            obj.Precio = Txtprecio.Text
            obj.Fecha_ingreso = DtpIngreso.Text
            obj.Nombre = txtNombre.Text
            obj.Stock = TxtStock.Text
            obj.Idarticulo = TxtId.Text



            If (neg.Actualizar(obj)) Then
                MsgBox("Se ha Actualizado Correctamente", vbOKOnly + vbInformation, "Actualizacion  Correcto")
                'Me.limpiar()
                Me.Listar()
                TabGneral.SelectedIndex = 0
            Else
                MsgBox("No se ha podido Actualizar", vbOKOnly + vbCritical, "Actualizacion Incompleto")


            End If



        Else
            MsgBox("Rellene todos los datos Obligatorios (*)")

        End If


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.limpiar()
        TabGneral.SelectedIndex = 0
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.BUSCAR()
    End Sub
    Private Sub BUSCAR()
        Try
            Dim Neg As New Negocio.NArticulos
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            lblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Estas seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulos
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Eliminar(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Estas seguro de activar los registros seleccionados?", vbYesNo + vbQuestion, "Activar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulos
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Activar(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Estas seguro de desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NArticulos
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim OneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Desactivar(OneKey)
                    End If
                Next
                Me.Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class