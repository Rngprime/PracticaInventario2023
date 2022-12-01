Public Class FrmAsignacion


    Private DtDetalle As New DataTable

    Private Sub FrmAsignacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Listar()
        Me.CrearTablaDetalle()

    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NAsignacionComputador
            DgvListado.DataSource = Neg.Listar()
            'pLbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            ' Me.Formato()
            'Me.Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        FrmComputadorAsinadorPuersto.ShowDialog()
        TxtIdCliente.Text = variables.idcomputador
        TxtNombreCliente.Text = variables.equipo
        TxtPrecio.Text = variables.precio
        TxtArea.Text = variables.area

    End Sub

    Private Sub BtnBuscarArticulos_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulos.Click
        PanelArticulos.Visible = True
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        PanelArticulos.Visible = False
    End Sub

    Private Sub BtnBuscarArticulosDetalle_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulosDetalle.Click
        Try
            Dim Neg As New Negocio.NArticulos
            Dim Valor As String
            Valor = TxtBuscarArticulos.Text
            DgvArticulos.DataSource = Neg.Buscar1(Valor)
            LblTotalArticulos.Text = "Total Artículos: " & DgvArticulos.DataSource.Rows.Count
            ' Me.FormatoArticulos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArticulos.CellDoubleClick
        Try
            Dim Obj As New Entidades.Articulos
            Obj.Idarticulo = DgvArticulos.SelectedCells.Item(0).Value
            Obj.Codigo = DgvArticulos.SelectedCells.Item(3).Value
            Obj.Nombre = DgvArticulos.SelectedCells.Item(4).Value
            Obj.Precio = DgvArticulos.SelectedCells.Item(5).Value
            Obj.Stock = DgvArticulos.SelectedCells.Item(6).Value
            Me.AgregarDetalle(Obj)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub CrearTablaDetalle()
        Me.DtDetalle = New DataTable("Detalle")
        Me.DtDetalle.Columns.Add("idarticulo", System.Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("stock", System.Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"))
        Me.DtDetalle.Columns.Add("total", System.Type.GetType("System.Decimal"))

        DgvDetalle.DataSource = Me.DtDetalle
        DgvDetalle.Columns(0).Visible = False
        DgvDetalle.Columns(1).HeaderText = "CODIGO"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "ARTICULO"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "STOCK"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "CANTIDAD"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "PRECIO"
        DgvDetalle.Columns(5).Width = 100
        DgvDetalle.Columns(6).HeaderText = "TOTAL"
        DgvDetalle.Columns(6).Width = 100

        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(3).ReadOnly = True
        DgvDetalle.Columns(6).ReadOnly = True
    End Sub

    Private Sub AgregarDetalle(Fila As Entidades.Articulos)
        Dim Agregar As Boolean = True

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            If (Convert.ToInt32(FilaTemp.Cells("idarticulo").Value) = Convert.ToInt32(Fila.Idarticulo)) Then
                Agregar = False
                MsgBox("El artículo ya ha sido agregado", vbOKOnly + vbCritical, "Error agregando detalles")
            End If
        Next
        If (Agregar) Then
            Dim Row As DataRow
            Row = Me.DtDetalle.NewRow()
            Row("idarticulo") = Convert.ToInt32(Fila.Idarticulo)
            Row("codigo") = Convert.ToString(Fila.Codigo)
            Row("articulo") = Convert.ToString(Fila.Nombre)
            Row("stock") = Convert.ToInt32(Fila.Stock)
            Row("cantidad") = Convert.ToString(1)
            Row("precio") = Convert.ToDecimal(Fila.Precio)
            Row("total") = Convert.ToDecimal(Fila.Precio)
            Me.DtDetalle.Rows.Add(Row)
            ' Me.CalcularTotales()
        End If

    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click

        If Me.ValidateChildren = True And TxtIdCliente.Text <> "" Then
            Dim obj As New Entidades.AsignacionPeriferico
            Dim neg As New Negocio.NAsignacionComputador

            obj.Idcomputador = TxtIdCliente.Text
            obj.IdAsignacionPeriferico = TxtId.Text
            obj.Iva = TxtImpuesto.Text
            obj.Total = TxtTotal.Text




            If (neg.Insertarprueba(obj)) Then
                MsgBox("Se ha regristado Correctamente", vbOKOnly + vbInformation, "Registro Correcto")
                'Me.limpiar()
                Me.Listar()
            Else
                MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro Incompleto")


            End If

        Else
            MsgBox("Rellene todos los datos Obligatorios (*)")

        End If




    End Sub
End Class