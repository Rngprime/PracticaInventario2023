Public Class FrmIngresoComputadores
    Private Sub FrmIngresoComputadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CargaCentrodeCosto()
        Me.CargaAreas()
        Me.Formato()
    End Sub

    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NComputador
            DgvListado.DataSource = Neg.Listar()
            lblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count

            ' Me.Formato()
            Me.limpiar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False

        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False

        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
        ChbSeleccionar.CheckState = False

    End Sub


    Private Sub CargaCentrodeCosto()

        Try
            Dim Neg As New Negocio.NCentrodeCostos
            CboCentrodecosto.DataSource = Neg.Seleccionar
            CboCentrodecosto.ValueMember = "idcentrodecosto"
            CboCentrodecosto.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargaAreas()

        Try
            Dim Neg As New Negocio.NArea
            CboArea.DataSource = Neg.Seleccionar
            CboArea.ValueMember = "idarea"
            CboArea.DisplayMember = "nombre"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If Me.ValidateChildren = True And TxtEquipo.Text <> "" And TxtPrecio.Text <> "" Then
            Dim obj As New Entidades.Computador
            Dim neg As New Negocio.NComputador

            obj.Idcentrodecosto = CboCentrodecosto.SelectedValue
            obj.Idarea = CboArea.SelectedValue
            obj.Equipo = TxtEquipo.Text
            obj.Precio = TxtPrecio.Text
            obj.Usuario = TxtUsuario.Text
            obj.Componentes = TxtComponentes.Text
            obj.VersionMicrosoft = TxtVersionWindows.Text
            obj.Microsof = TxtMicorosSerial.Text
            obj.Oficce = TxtOfficeSerial.Text
            obj.Anydesk = TxtAnydesk.Text
            obj.IpEquipo = TxtIp.Text
            obj.Fecha_ingreso = DtpFechaEntregs.Text
            obj.Fecha_traspaso = DtpFechaIngreso.Text



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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        BUSCAR()
    End Sub

    Private Sub BUSCAR()
        Try
            Dim Neg As New Negocio.NComputador
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            lblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            'Me.Formato()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        BtnInsertar.Visible = True
        BtnActualizar.Visible = False



        TxtEquipo.Text = ""
        TxtPrecio.Text = ""
        TxtUsuario.Text = ""
        TxtComponentes.Text = ""
        TxtVersionWindows.Text = ""
        TxtMicorosSerial.Text = ""
        TxtOfficeSerial.Text = ""
        TxtAnydesk.Text = ""
        TxtIp.Text = ""
        DtpFechaEntregs.Text = ""
        DtpFechaIngreso.Text = ""

    End Sub

    Private Sub DgvListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentDoubleClick


        CboArea.Text = DgvListado.SelectedCells.Item(3).Value
        CboCentrodecosto.Text = DgvListado.SelectedCells.Item(2).Value
        TxtEquipo.Text = DgvListado.SelectedCells.Item(4).Value
        TxtUsuario.Text = DgvListado.SelectedCells.Item(5).Value
        TxtPrecio.Text = DgvListado.SelectedCells.Item(6).Value
        TxtComponentes.Text = DgvListado.SelectedCells.Item(7).Value
        TxtVersionWindows.Text = DgvListado.SelectedCells.Item(13).Value
        TxtMicorosSerial.Text = DgvListado.SelectedCells.Item(12).Value
        TxtOfficeSerial.Text = DgvListado.SelectedCells.Item(11).Value
        TxtAnydesk.Text = DgvListado.SelectedCells.Item(10).Value
        TxtIp.Text = DgvListado.SelectedCells.Item(14).Value
        DtpFechaIngreso.Text = DgvListado.SelectedCells.Item(8).Value
        DtpFechaEntregs.Text = DgvListado.SelectedCells.Item(9).Value


        TxtId.Text = DgvListado.SelectedCells.Item(1).Value

        TabGneral.SelectedIndex = 1
        BtnActualizar.Visible = True
        BtnInsertar.Visible = False



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.limpiar()
        TabGneral.SelectedIndex = 0
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtPrecio.Text <> "" Then
            Dim obj As New Entidades.Computador
            Dim neg As New Negocio.NComputador


            obj.Idcomputador = TxtId.Text
            obj.Equipo = TxtEquipo.Text
            obj.Precio = TxtPrecio.Text
            obj.Idarea = CboArea.SelectedValue
            obj.Idcentrodecosto = CboCentrodecosto.SelectedValue
            obj.Usuario = TxtUsuario.Text
            obj.Componentes = TxtComponentes.Text
            obj.VersionMicrosoft = TxtVersionWindows.Text
            obj.Microsof = TxtMicorosSerial.Text
            obj.Oficce = TxtOfficeSerial.Text
            obj.Anydesk = TxtAnydesk.Text
            obj.IpEquipo = TxtIp.Text

            obj.Fecha_ingreso = DtpFechaEntregs.Text
            obj.Fecha_traspaso = DtpFechaIngreso.Text


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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Estas seguro de eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registros") = vbYes) Then
            Try
                Dim Neg As New Negocio.NComputador
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
                Dim Neg As New Negocio.NComputador
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
                Dim Neg As New Negocio.NComputador
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


End Class