<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoComputadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabGneral = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnDesactivar = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.ChbSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtOfficeSerial = New System.Windows.Forms.TextBox()
        Me.TxtMicorosSerial = New System.Windows.Forms.TextBox()
        Me.TxtVersionWindows = New System.Windows.Forms.TextBox()
        Me.TxtIp = New System.Windows.Forms.TextBox()
        Me.TxtAnydesk = New System.Windows.Forms.TextBox()
        Me.TxtComponentes = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtEquipo = New System.Windows.Forms.TextBox()
        Me.DtpFechaEntregs = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.CboCentrodecosto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Precio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboArea = New System.Windows.Forms.ComboBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TabGneral.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGneral
        '
        Me.TabGneral.Controls.Add(Me.TabPage1)
        Me.TabGneral.Controls.Add(Me.TabPage2)
        Me.TabGneral.Location = New System.Drawing.Point(12, 33)
        Me.TabGneral.Name = "TabGneral"
        Me.TabGneral.SelectedIndex = 0
        Me.TabGneral.Size = New System.Drawing.Size(1308, 415)
        Me.TabGneral.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.BtnDesactivar)
        Me.TabPage1.Controls.Add(Me.BtnActivar)
        Me.TabPage1.Controls.Add(Me.BtnEliminar)
        Me.TabPage1.Controls.Add(Me.ChbSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1300, 389)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'BtnDesactivar
        '
        Me.BtnDesactivar.Location = New System.Drawing.Point(423, 363)
        Me.BtnDesactivar.Name = "BtnDesactivar"
        Me.BtnDesactivar.Size = New System.Drawing.Size(135, 23)
        Me.BtnDesactivar.TabIndex = 8
        Me.BtnDesactivar.Text = "Desactivar"
        Me.BtnDesactivar.UseVisualStyleBackColor = True
        '
        'BtnActivar
        '
        Me.BtnActivar.Location = New System.Drawing.Point(267, 363)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(141, 23)
        Me.BtnActivar.TabIndex = 7
        Me.BtnActivar.Text = "Activar"
        Me.BtnActivar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(102, 363)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(150, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'ChbSeleccionar
        '
        Me.ChbSeleccionar.AutoSize = True
        Me.ChbSeleccionar.Location = New System.Drawing.Point(15, 366)
        Me.ChbSeleccionar.Name = "ChbSeleccionar"
        Me.ChbSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChbSeleccionar.TabIndex = 3
        Me.ChbSeleccionar.Text = "Seleccionar"
        Me.ChbSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(1100, 6)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(166, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(3, 6)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(577, 20)
        Me.TxtValor.TabIndex = 1
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(3, 42)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(1263, 305)
        Me.DgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtOfficeSerial)
        Me.TabPage2.Controls.Add(Me.TxtMicorosSerial)
        Me.TabPage2.Controls.Add(Me.TxtVersionWindows)
        Me.TabPage2.Controls.Add(Me.TxtIp)
        Me.TabPage2.Controls.Add(Me.TxtAnydesk)
        Me.TabPage2.Controls.Add(Me.TxtComponentes)
        Me.TabPage2.Controls.Add(Me.TxtPrecio)
        Me.TabPage2.Controls.Add(Me.TxtUsuario)
        Me.TabPage2.Controls.Add(Me.TxtEquipo)
        Me.TabPage2.Controls.Add(Me.DtpFechaEntregs)
        Me.TabPage2.Controls.Add(Me.DtpFechaIngreso)
        Me.TabPage2.Controls.Add(Me.CboCentrodecosto)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Precio)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.CboArea)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnInsertar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1300, 389)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingreso Computadores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtOfficeSerial
        '
        Me.TxtOfficeSerial.Location = New System.Drawing.Point(627, 101)
        Me.TxtOfficeSerial.Name = "TxtOfficeSerial"
        Me.TxtOfficeSerial.Size = New System.Drawing.Size(299, 20)
        Me.TxtOfficeSerial.TabIndex = 49
        '
        'TxtMicorosSerial
        '
        Me.TxtMicorosSerial.Location = New System.Drawing.Point(627, 68)
        Me.TxtMicorosSerial.Name = "TxtMicorosSerial"
        Me.TxtMicorosSerial.Size = New System.Drawing.Size(299, 20)
        Me.TxtMicorosSerial.TabIndex = 48
        '
        'TxtVersionWindows
        '
        Me.TxtVersionWindows.Location = New System.Drawing.Point(627, 38)
        Me.TxtVersionWindows.Name = "TxtVersionWindows"
        Me.TxtVersionWindows.Size = New System.Drawing.Size(299, 20)
        Me.TxtVersionWindows.TabIndex = 47
        '
        'TxtIp
        '
        Me.TxtIp.Location = New System.Drawing.Point(627, 166)
        Me.TxtIp.Name = "TxtIp"
        Me.TxtIp.Size = New System.Drawing.Size(299, 20)
        Me.TxtIp.TabIndex = 46
        '
        'TxtAnydesk
        '
        Me.TxtAnydesk.Location = New System.Drawing.Point(627, 134)
        Me.TxtAnydesk.Name = "TxtAnydesk"
        Me.TxtAnydesk.Size = New System.Drawing.Size(299, 20)
        Me.TxtAnydesk.TabIndex = 45
        '
        'TxtComponentes
        '
        Me.TxtComponentes.Location = New System.Drawing.Point(117, 206)
        Me.TxtComponentes.Multiline = True
        Me.TxtComponentes.Name = "TxtComponentes"
        Me.TxtComponentes.Size = New System.Drawing.Size(340, 114)
        Me.TxtComponentes.TabIndex = 44
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(117, 166)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(340, 20)
        Me.TxtPrecio.TabIndex = 43
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(117, 131)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(340, 20)
        Me.TxtUsuario.TabIndex = 42
        '
        'TxtEquipo
        '
        Me.TxtEquipo.Location = New System.Drawing.Point(117, 101)
        Me.TxtEquipo.Name = "TxtEquipo"
        Me.TxtEquipo.Size = New System.Drawing.Size(340, 20)
        Me.TxtEquipo.TabIndex = 41
        '
        'DtpFechaEntregs
        '
        Me.DtpFechaEntregs.Location = New System.Drawing.Point(1065, 71)
        Me.DtpFechaEntregs.Name = "DtpFechaEntregs"
        Me.DtpFechaEntregs.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaEntregs.TabIndex = 40
        '
        'DtpFechaIngreso
        '
        Me.DtpFechaIngreso.Location = New System.Drawing.Point(1065, 39)
        Me.DtpFechaIngreso.Name = "DtpFechaIngreso"
        Me.DtpFechaIngreso.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaIngreso.TabIndex = 39
        '
        'CboCentrodecosto
        '
        Me.CboCentrodecosto.FormattingEnabled = True
        Me.CboCentrodecosto.Location = New System.Drawing.Point(117, 70)
        Me.CboCentrodecosto.Name = "CboCentrodecosto"
        Me.CboCentrodecosto.Size = New System.Drawing.Size(340, 21)
        Me.CboCentrodecosto.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(523, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Version Windows"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(523, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "ip"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(523, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Microsoft Serial"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(523, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Oficce Serial"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(523, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Anydesk"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(971, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Fecha Entrega"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(971, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Fecha Ingreso"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Sectores"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Centro de Costo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Componentes"
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Location = New System.Drawing.Point(26, 169)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(37, 13)
        Me.Precio.TabIndex = 27
        Me.Precio.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Equipo"
        '
        'CboArea
        '
        Me.CboArea.FormattingEnabled = True
        Me.CboArea.Location = New System.Drawing.Point(117, 38)
        Me.CboArea.Name = "CboArea"
        Me.CboArea.Size = New System.Drawing.Size(340, 21)
        Me.CboArea.TabIndex = 17
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(1164, 296)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(96, 62)
        Me.BtnActualizar.TabIndex = 9
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(1223, 6)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(58, 20)
        Me.TxtId.TabIndex = 6
        Me.TxtId.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(1040, 296)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 62)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(1164, 296)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(96, 62)
        Me.BtnInsertar.TabIndex = 4
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(1188, 486)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(27, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "total"
        '
        'FrmIngresoComputadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TabGneral)
        Me.Controls.Add(Me.lblTotal)
        Me.Name = "FrmIngresoComputadores"
        Me.Text = "Ingreso Computadores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabGneral.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabGneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnDesactivar As Button
    Public WithEvents BtnActivar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents ChbSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CboArea As ComboBox
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Precio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CboCentrodecosto As ComboBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtEquipo As TextBox
    Friend WithEvents DtpFechaEntregs As DateTimePicker
    Friend WithEvents DtpFechaIngreso As DateTimePicker
    Friend WithEvents TxtOfficeSerial As TextBox
    Friend WithEvents TxtMicorosSerial As TextBox
    Friend WithEvents TxtVersionWindows As TextBox
    Friend WithEvents TxtIp As TextBox
    Friend WithEvents TxtAnydesk As TextBox
    Friend WithEvents TxtComponentes As TextBox
End Class
