Public Class FrmComputadorAsinadorPuersto
    Private Sub FrmComputadorAsinadorPuersto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub



    Private Sub Listar()
        Try
            Dim Neg As New Negocio.NComputador
            DgvListado.DataSource = Neg.Listar()
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            'Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.NComputador
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            Lbltotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            ' Me.Formato()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick

        variables.idcomputador = DgvListado.SelectedCells.Item(1).Value

        variables.equipo = DgvListado.SelectedCells.Item(4).Value
        variables.area = DgvListado.SelectedCells.Item(3).Value
        variables.precio = DgvListado.SelectedCells.Item(6).Value

        'variables.equipo
        'variables.usuario
        'variables.precio

        Me.Close()

        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub
End Class