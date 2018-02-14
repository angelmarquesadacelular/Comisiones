<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarArchivosComisionesDlg
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MenuComisiones = New System.Windows.Forms.MenuStrip()
        Me.ImportarArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DGImportacion = New System.Windows.Forms.DataGridView()
        Me.PBCargar = New System.Windows.Forms.ProgressBar()
        Me.PBCargando = New System.Windows.Forms.PictureBox()
        Me.TabReporte = New System.Windows.Forms.TabControl()
        Me.TabConComision = New System.Windows.Forms.TabPage()
        Me.DGGraficaReporteSemanales = New System.Windows.Forms.DataGridView()
        Me.RutaGraficaSemanales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteGraficaSemanales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroGraficaSemanales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionGrafciaSemanales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionTotalGrafica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoGraficaSemanales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVolumenVentaEfectivo = New System.Windows.Forms.DataGridView()
        Me.Clientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Digitos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comisiones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGConComision = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaActivacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionAcumulada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGGraficaVolumenVenta = New System.Windows.Forms.DataGridView()
        Me.RutaDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabSinComision = New System.Windows.Forms.TabPage()
        Me.DGVolumenVentaCredito = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivadoCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGSinComision = New System.Windows.Forms.DataGridView()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasinComision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComisionTotalSC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabGraficas = New System.Windows.Forms.TabPage()
        Me.LbGraficaDos = New System.Windows.Forms.Label()
        Me.LbGraficaUno = New System.Windows.Forms.Label()
        Me.GraficaDos = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GraficaUno = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MenuComisiones.SuspendLayout()
        CType(Me.DGImportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCargando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReporte.SuspendLayout()
        Me.TabConComision.SuspendLayout()
        CType(Me.DGGraficaReporteSemanales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVolumenVentaEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGConComision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGGraficaVolumenVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSinComision.SuspendLayout()
        CType(Me.DGVolumenVentaCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGSinComision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGraficas.SuspendLayout()
        CType(Me.GraficaDos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraficaUno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuComisiones
        '
        Me.MenuComisiones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuComisiones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarArchivoToolStripMenuItem, Me.GenerarReporteToolStripMenuItem})
        Me.MenuComisiones.Location = New System.Drawing.Point(0, 0)
        Me.MenuComisiones.Name = "MenuComisiones"
        Me.MenuComisiones.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuComisiones.Size = New System.Drawing.Size(1753, 28)
        Me.MenuComisiones.TabIndex = 0
        Me.MenuComisiones.Text = "MenuStrip1"
        '
        'ImportarArchivoToolStripMenuItem
        '
        Me.ImportarArchivoToolStripMenuItem.Name = "ImportarArchivoToolStripMenuItem"
        Me.ImportarArchivoToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.ImportarArchivoToolStripMenuItem.Text = "Importar Archivo"
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar Reporte"
        '
        'DGImportacion
        '
        Me.DGImportacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGImportacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGImportacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGImportacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGImportacion.ColumnHeadersVisible = False
        Me.DGImportacion.Location = New System.Drawing.Point(16, 54)
        Me.DGImportacion.Margin = New System.Windows.Forms.Padding(4)
        Me.DGImportacion.Name = "DGImportacion"
        Me.DGImportacion.Size = New System.Drawing.Size(1721, 823)
        Me.DGImportacion.TabIndex = 1
        '
        'PBCargar
        '
        Me.PBCargar.Location = New System.Drawing.Point(1604, 885)
        Me.PBCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.PBCargar.Name = "PBCargar"
        Me.PBCargar.Size = New System.Drawing.Size(133, 28)
        Me.PBCargar.TabIndex = 40
        '
        'PBCargando
        '
        Me.PBCargando.Image = Global.comisionesATC.My.Resources.Resources.IllinformedMeaslyKoi_max_1mb
        Me.PBCargando.Location = New System.Drawing.Point(615, 449)
        Me.PBCargando.Margin = New System.Windows.Forms.Padding(4)
        Me.PBCargando.Name = "PBCargando"
        Me.PBCargando.Size = New System.Drawing.Size(308, 183)
        Me.PBCargando.TabIndex = 41
        Me.PBCargando.TabStop = False
        '
        'TabReporte
        '
        Me.TabReporte.Controls.Add(Me.TabConComision)
        Me.TabReporte.Controls.Add(Me.TabSinComision)
        Me.TabReporte.Controls.Add(Me.TabGraficas)
        Me.TabReporte.Location = New System.Drawing.Point(16, 54)
        Me.TabReporte.Name = "TabReporte"
        Me.TabReporte.SelectedIndex = 0
        Me.TabReporte.Size = New System.Drawing.Size(1130, 823)
        Me.TabReporte.TabIndex = 42
        '
        'TabConComision
        '
        Me.TabConComision.Controls.Add(Me.DGGraficaReporteSemanales)
        Me.TabConComision.Controls.Add(Me.DGVolumenVentaEfectivo)
        Me.TabConComision.Controls.Add(Me.DGConComision)
        Me.TabConComision.Controls.Add(Me.DGGraficaVolumenVenta)
        Me.TabConComision.Location = New System.Drawing.Point(4, 25)
        Me.TabConComision.Name = "TabConComision"
        Me.TabConComision.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConComision.Size = New System.Drawing.Size(1122, 794)
        Me.TabConComision.TabIndex = 0
        Me.TabConComision.Text = "Con Comisión"
        Me.TabConComision.UseVisualStyleBackColor = True
        '
        'DGGraficaReporteSemanales
        '
        Me.DGGraficaReporteSemanales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGraficaReporteSemanales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutaGraficaSemanales, Me.ClienteGraficaSemanales, Me.NumeroGraficaSemanales, Me.ComisionGrafciaSemanales, Me.ComisionTotalGrafica, Me.TipoGraficaSemanales})
        Me.DGGraficaReporteSemanales.Location = New System.Drawing.Point(420, 60)
        Me.DGGraficaReporteSemanales.Name = "DGGraficaReporteSemanales"
        Me.DGGraficaReporteSemanales.RowTemplate.Height = 24
        Me.DGGraficaReporteSemanales.Size = New System.Drawing.Size(646, 572)
        Me.DGGraficaReporteSemanales.TabIndex = 49
        '
        'RutaGraficaSemanales
        '
        Me.RutaGraficaSemanales.HeaderText = "Ruta"
        Me.RutaGraficaSemanales.Name = "RutaGraficaSemanales"
        '
        'ClienteGraficaSemanales
        '
        Me.ClienteGraficaSemanales.HeaderText = "Cliente"
        Me.ClienteGraficaSemanales.Name = "ClienteGraficaSemanales"
        '
        'NumeroGraficaSemanales
        '
        Me.NumeroGraficaSemanales.HeaderText = "Número"
        Me.NumeroGraficaSemanales.Name = "NumeroGraficaSemanales"
        '
        'ComisionGrafciaSemanales
        '
        Me.ComisionGrafciaSemanales.HeaderText = "Comisión"
        Me.ComisionGrafciaSemanales.Name = "ComisionGrafciaSemanales"
        '
        'ComisionTotalGrafica
        '
        Me.ComisionTotalGrafica.HeaderText = "Comisión Total"
        Me.ComisionTotalGrafica.Name = "ComisionTotalGrafica"
        '
        'TipoGraficaSemanales
        '
        Me.TipoGraficaSemanales.HeaderText = "Tipo"
        Me.TipoGraficaSemanales.Name = "TipoGraficaSemanales"
        '
        'DGVolumenVentaEfectivo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVolumenVentaEfectivo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVolumenVentaEfectivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVolumenVentaEfectivo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVolumenVentaEfectivo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVolumenVentaEfectivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVolumenVentaEfectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVolumenVentaEfectivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clientes, Me.Digitos, Me.Fecha, Me.Comisiones})
        Me.DGVolumenVentaEfectivo.Location = New System.Drawing.Point(13, 6)
        Me.DGVolumenVentaEfectivo.Name = "DGVolumenVentaEfectivo"
        Me.DGVolumenVentaEfectivo.RowTemplate.Height = 24
        Me.DGVolumenVentaEfectivo.Size = New System.Drawing.Size(1105, 790)
        Me.DGVolumenVentaEfectivo.TabIndex = 48
        '
        'Clientes
        '
        Me.Clientes.HeaderText = "Cliente"
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Width = 80
        '
        'Digitos
        '
        Me.Digitos.HeaderText = "Número"
        Me.Digitos.Name = "Digitos"
        Me.Digitos.Width = 87
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Activado"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 91
        '
        'Comisiones
        '
        Me.Comisiones.HeaderText = "Comisión"
        Me.Comisiones.Name = "Comisiones"
        Me.Comisiones.Width = 94
        '
        'DGConComision
        '
        Me.DGConComision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGConComision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGConComision.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGConComision.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGConComision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGConComision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.FechaActivacion, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.ComisionAcumulada})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGConComision.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGConComision.Location = New System.Drawing.Point(13, 6)
        Me.DGConComision.Name = "DGConComision"
        Me.DGConComision.RowTemplate.Height = 24
        Me.DGConComision.Size = New System.Drawing.Size(1097, 782)
        Me.DGConComision.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 87
        '
        'FechaActivacion
        '
        Me.FechaActivacion.HeaderText = "Activado"
        Me.FechaActivacion.Name = "FechaActivacion"
        Me.FechaActivacion.Width = 91
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Monto 30"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 96
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monto 60"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 96
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Monto 90"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 96
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Comisión"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 94
        '
        'ComisionAcumulada
        '
        Me.ComisionAcumulada.HeaderText = "Comision Total"
        Me.ComisionAcumulada.Name = "ComisionAcumulada"
        Me.ComisionAcumulada.Width = 130
        '
        'DGGraficaVolumenVenta
        '
        Me.DGGraficaVolumenVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGraficaVolumenVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutaDG, Me.ClienteDG, Me.NumeroDG, Me.ComisionDG, Me.TipoDG})
        Me.DGGraficaVolumenVenta.Location = New System.Drawing.Point(575, 219)
        Me.DGGraficaVolumenVenta.Name = "DGGraficaVolumenVenta"
        Me.DGGraficaVolumenVenta.RowTemplate.Height = 24
        Me.DGGraficaVolumenVenta.Size = New System.Drawing.Size(535, 569)
        Me.DGGraficaVolumenVenta.TabIndex = 46
        '
        'RutaDG
        '
        Me.RutaDG.HeaderText = "Ruta"
        Me.RutaDG.Name = "RutaDG"
        '
        'ClienteDG
        '
        Me.ClienteDG.HeaderText = "Cliente"
        Me.ClienteDG.Name = "ClienteDG"
        '
        'NumeroDG
        '
        Me.NumeroDG.HeaderText = "Número"
        Me.NumeroDG.Name = "NumeroDG"
        '
        'ComisionDG
        '
        Me.ComisionDG.HeaderText = "Comisión"
        Me.ComisionDG.Name = "ComisionDG"
        '
        'TipoDG
        '
        Me.TipoDG.HeaderText = "Tipo"
        Me.TipoDG.Name = "TipoDG"
        '
        'TabSinComision
        '
        Me.TabSinComision.Controls.Add(Me.DGVolumenVentaCredito)
        Me.TabSinComision.Controls.Add(Me.DGSinComision)
        Me.TabSinComision.Location = New System.Drawing.Point(4, 25)
        Me.TabSinComision.Name = "TabSinComision"
        Me.TabSinComision.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSinComision.Size = New System.Drawing.Size(1122, 794)
        Me.TabSinComision.TabIndex = 1
        Me.TabSinComision.Text = "Sin Comisión"
        Me.TabSinComision.UseVisualStyleBackColor = True
        '
        'DGVolumenVentaCredito
        '
        Me.DGVolumenVentaCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVolumenVentaCredito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVolumenVentaCredito.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVolumenVentaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVolumenVentaCredito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.ActivadoCredito, Me.DataGridViewTextBoxColumn9})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVolumenVentaCredito.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGVolumenVentaCredito.Location = New System.Drawing.Point(13, 6)
        Me.DGVolumenVentaCredito.Name = "DGVolumenVentaCredito"
        Me.DGVolumenVentaCredito.RowTemplate.Height = 24
        Me.DGVolumenVentaCredito.Size = New System.Drawing.Size(1105, 790)
        Me.DGVolumenVentaCredito.TabIndex = 47
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 87
        '
        'ActivadoCredito
        '
        Me.ActivadoCredito.HeaderText = "Activado"
        Me.ActivadoCredito.Name = "ActivadoCredito"
        Me.ActivadoCredito.Width = 91
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Comisión"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 94
        '
        'DGSinComision
        '
        Me.DGSinComision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGSinComision.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGSinComision.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSinComision.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGSinComision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSinComision.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.Numero, Me.FechasinComision, Me.MontoA, Me.MontoB, Me.MontoC, Me.Comision, Me.ComisionTotalSC})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGSinComision.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGSinComision.Location = New System.Drawing.Point(13, 6)
        Me.DGSinComision.Name = "DGSinComision"
        Me.DGSinComision.RowTemplate.Height = 24
        Me.DGSinComision.Size = New System.Drawing.Size(1097, 782)
        Me.DGSinComision.TabIndex = 44
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Width = 80
        '
        'Numero
        '
        Me.Numero.HeaderText = "Número"
        Me.Numero.Name = "Numero"
        Me.Numero.Width = 87
        '
        'FechasinComision
        '
        Me.FechasinComision.HeaderText = "Activado"
        Me.FechasinComision.Name = "FechasinComision"
        Me.FechasinComision.Width = 91
        '
        'MontoA
        '
        Me.MontoA.HeaderText = "Monto 30"
        Me.MontoA.Name = "MontoA"
        Me.MontoA.Width = 96
        '
        'MontoB
        '
        Me.MontoB.HeaderText = "Monto 60"
        Me.MontoB.Name = "MontoB"
        Me.MontoB.Width = 96
        '
        'MontoC
        '
        Me.MontoC.HeaderText = "Monto 90"
        Me.MontoC.Name = "MontoC"
        Me.MontoC.Width = 96
        '
        'Comision
        '
        Me.Comision.HeaderText = "Comisión"
        Me.Comision.Name = "Comision"
        Me.Comision.Width = 94
        '
        'ComisionTotalSC
        '
        Me.ComisionTotalSC.HeaderText = "Comisión Total"
        Me.ComisionTotalSC.Name = "ComisionTotalSC"
        Me.ComisionTotalSC.Width = 130
        '
        'TabGraficas
        '
        Me.TabGraficas.Controls.Add(Me.LbGraficaDos)
        Me.TabGraficas.Controls.Add(Me.LbGraficaUno)
        Me.TabGraficas.Controls.Add(Me.GraficaDos)
        Me.TabGraficas.Controls.Add(Me.GraficaUno)
        Me.TabGraficas.Location = New System.Drawing.Point(4, 25)
        Me.TabGraficas.Name = "TabGraficas"
        Me.TabGraficas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabGraficas.Size = New System.Drawing.Size(1122, 794)
        Me.TabGraficas.TabIndex = 2
        Me.TabGraficas.Text = "Graficas"
        Me.TabGraficas.UseVisualStyleBackColor = True
        '
        'LbGraficaDos
        '
        Me.LbGraficaDos.AutoSize = True
        Me.LbGraficaDos.Location = New System.Drawing.Point(796, 32)
        Me.LbGraficaDos.Name = "LbGraficaDos"
        Me.LbGraficaDos.Size = New System.Drawing.Size(54, 17)
        Me.LbGraficaDos.TabIndex = 3
        Me.LbGraficaDos.Text = "Grafica"
        '
        'LbGraficaUno
        '
        Me.LbGraficaUno.AutoSize = True
        Me.LbGraficaUno.Location = New System.Drawing.Point(175, 32)
        Me.LbGraficaUno.Name = "LbGraficaUno"
        Me.LbGraficaUno.Size = New System.Drawing.Size(54, 17)
        Me.LbGraficaUno.TabIndex = 2
        Me.LbGraficaUno.Text = "Grafica"
        '
        'GraficaDos
        '
        ChartArea1.Name = "ChartArea1"
        Me.GraficaDos.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.GraficaDos.Legends.Add(Legend1)
        Me.GraficaDos.Location = New System.Drawing.Point(612, 52)
        Me.GraficaDos.Name = "GraficaDos"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.GraficaDos.Series.Add(Series1)
        Me.GraficaDos.Size = New System.Drawing.Size(462, 548)
        Me.GraficaDos.TabIndex = 1
        Me.GraficaDos.Text = "Chart1"
        '
        'GraficaUno
        '
        ChartArea2.Name = "ChartArea1"
        Me.GraficaUno.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.GraficaUno.Legends.Add(Legend2)
        Me.GraficaUno.Location = New System.Drawing.Point(20, 52)
        Me.GraficaUno.Name = "GraficaUno"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.GraficaUno.Series.Add(Series2)
        Me.GraficaUno.Size = New System.Drawing.Size(462, 548)
        Me.GraficaUno.TabIndex = 0
        Me.GraficaUno.Text = "Chart1"
        '
        'CargarArchivosComisionesDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1753, 918)
        Me.Controls.Add(Me.TabReporte)
        Me.Controls.Add(Me.PBCargando)
        Me.Controls.Add(Me.PBCargar)
        Me.Controls.Add(Me.DGImportacion)
        Me.Controls.Add(Me.MenuComisiones)
        Me.MainMenuStrip = Me.MenuComisiones
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "CargarArchivosComisionesDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Archivos de Comisiones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuComisiones.ResumeLayout(False)
        Me.MenuComisiones.PerformLayout()
        CType(Me.DGImportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCargando, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReporte.ResumeLayout(False)
        Me.TabConComision.ResumeLayout(False)
        CType(Me.DGGraficaReporteSemanales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVolumenVentaEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGConComision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGGraficaVolumenVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSinComision.ResumeLayout(False)
        CType(Me.DGVolumenVentaCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGSinComision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGraficas.ResumeLayout(False)
        Me.TabGraficas.PerformLayout()
        CType(Me.GraficaDos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraficaUno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuComisiones As MenuStrip
    Friend WithEvents ImportarArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGImportacion As DataGridView
    Friend WithEvents PBCargar As ProgressBar
    Friend WithEvents PBCargando As PictureBox
    Friend WithEvents TabReporte As TabControl
    Friend WithEvents TabConComision As TabPage
    Friend WithEvents TabSinComision As TabPage
    Friend WithEvents TabGraficas As TabPage
    Friend WithEvents GraficaDos As DataVisualization.Charting.Chart
    Friend WithEvents GraficaUno As DataVisualization.Charting.Chart
    Friend WithEvents LbGraficaDos As Label
    Friend WithEvents LbGraficaUno As Label
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DGGraficaVolumenVenta As DataGridView
    Friend WithEvents RutaDG As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDG As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDG As DataGridViewTextBoxColumn
    Friend WithEvents ComisionDG As DataGridViewTextBoxColumn
    Friend WithEvents TipoDG As DataGridViewTextBoxColumn
    Friend WithEvents DGVolumenVentaEfectivo As DataGridView
    Friend WithEvents Clientes As DataGridViewTextBoxColumn
    Friend WithEvents Digitos As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Comisiones As DataGridViewTextBoxColumn
    Friend WithEvents DGConComision As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FechaActivacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ComisionAcumulada As DataGridViewTextBoxColumn
    Friend WithEvents DGVolumenVentaCredito As DataGridView
    Friend WithEvents DGSinComision As DataGridView
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents FechasinComision As DataGridViewTextBoxColumn
    Friend WithEvents MontoA As DataGridViewTextBoxColumn
    Friend WithEvents MontoB As DataGridViewTextBoxColumn
    Friend WithEvents MontoC As DataGridViewTextBoxColumn
    Friend WithEvents Comision As DataGridViewTextBoxColumn
    Friend WithEvents ComisionTotalSC As DataGridViewTextBoxColumn
    Friend WithEvents DGGraficaReporteSemanales As DataGridView
    Friend WithEvents RutaGraficaSemanales As DataGridViewTextBoxColumn
    Friend WithEvents ClienteGraficaSemanales As DataGridViewTextBoxColumn
    Friend WithEvents NumeroGraficaSemanales As DataGridViewTextBoxColumn
    Friend WithEvents ComisionGrafciaSemanales As DataGridViewTextBoxColumn
    Friend WithEvents ComisionTotalGrafica As DataGridViewTextBoxColumn
    Friend WithEvents TipoGraficaSemanales As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ActivadoCredito As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
