﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesEstadisticosDlg
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
        Me.LbTipoReporte = New System.Windows.Forms.Label()
        Me.CBTipoReporte = New System.Windows.Forms.ComboBox()
        Me.LbRuta = New System.Windows.Forms.Label()
        Me.CBRuta = New System.Windows.Forms.ComboBox()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.TabMenor = New System.Windows.Forms.TabPage()
        Me.DGReporteMenor = New System.Windows.Forms.DataGridView()
        Me.TabMayor = New System.Windows.Forms.TabPage()
        Me.DGReporteMayor = New System.Windows.Forms.DataGridView()
        Me.TabReporte = New System.Windows.Forms.TabControl()
        Me.TabMenor.SuspendLayout()
        CType(Me.DGReporteMenor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMayor.SuspendLayout()
        CType(Me.DGReporteMayor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbTipoReporte
        '
        Me.LbTipoReporte.AutoSize = True
        Me.LbTipoReporte.Location = New System.Drawing.Point(12, 9)
        Me.LbTipoReporte.Name = "LbTipoReporte"
        Me.LbTipoReporte.Size = New System.Drawing.Size(111, 17)
        Me.LbTipoReporte.TabIndex = 0
        Me.LbTipoReporte.Text = "Tipo de Reporte"
        '
        'CBTipoReporte
        '
        Me.CBTipoReporte.FormattingEnabled = True
        Me.CBTipoReporte.Items.AddRange(New Object() {"-- Seleccione --", "Porcentaje de Activación", "Comisiones", "Utilidad", "Comparación Rutas", "Comparación Utilidad Fuerzas de Venta"})
        Me.CBTipoReporte.Location = New System.Drawing.Point(143, 6)
        Me.CBTipoReporte.Name = "CBTipoReporte"
        Me.CBTipoReporte.Size = New System.Drawing.Size(303, 24)
        Me.CBTipoReporte.TabIndex = 1
        '
        'LbRuta
        '
        Me.LbRuta.AutoSize = True
        Me.LbRuta.Location = New System.Drawing.Point(452, 9)
        Me.LbRuta.Name = "LbRuta"
        Me.LbRuta.Size = New System.Drawing.Size(38, 17)
        Me.LbRuta.TabIndex = 2
        Me.LbRuta.Text = "Ruta"
        '
        'CBRuta
        '
        Me.CBRuta.FormattingEnabled = True
        Me.CBRuta.Items.AddRange(New Object() {"-- Seleccione--", "R0", "R1", "R2", "R3", "RA"})
        Me.CBRuta.Location = New System.Drawing.Point(498, 6)
        Me.CBRuta.Name = "CBRuta"
        Me.CBRuta.Size = New System.Drawing.Size(121, 24)
        Me.CBRuta.TabIndex = 3
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Location = New System.Drawing.Point(648, 9)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(75, 31)
        Me.BtnImprimir.TabIndex = 5
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'TabMenor
        '
        Me.TabMenor.Controls.Add(Me.DGReporteMenor)
        Me.TabMenor.Location = New System.Drawing.Point(4, 25)
        Me.TabMenor.Name = "TabMenor"
        Me.TabMenor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMenor.Size = New System.Drawing.Size(754, 637)
        Me.TabMenor.TabIndex = 1
        Me.TabMenor.Text = "Menor"
        Me.TabMenor.UseVisualStyleBackColor = True
        '
        'DGReporteMenor
        '
        Me.DGReporteMenor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGReporteMenor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReporteMenor.Location = New System.Drawing.Point(6, 12)
        Me.DGReporteMenor.Name = "DGReporteMenor"
        Me.DGReporteMenor.RowTemplate.Height = 24
        Me.DGReporteMenor.Size = New System.Drawing.Size(742, 612)
        Me.DGReporteMenor.TabIndex = 1
        '
        'TabMayor
        '
        Me.TabMayor.Controls.Add(Me.DGReporteMayor)
        Me.TabMayor.Location = New System.Drawing.Point(4, 25)
        Me.TabMayor.Name = "TabMayor"
        Me.TabMayor.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMayor.Size = New System.Drawing.Size(754, 637)
        Me.TabMayor.TabIndex = 0
        Me.TabMayor.Text = "Mayor"
        Me.TabMayor.UseVisualStyleBackColor = True
        '
        'DGReporteMayor
        '
        Me.DGReporteMayor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGReporteMayor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReporteMayor.Location = New System.Drawing.Point(6, 19)
        Me.DGReporteMayor.Name = "DGReporteMayor"
        Me.DGReporteMayor.RowTemplate.Height = 24
        Me.DGReporteMayor.Size = New System.Drawing.Size(742, 612)
        Me.DGReporteMayor.TabIndex = 0
        '
        'TabReporte
        '
        Me.TabReporte.Controls.Add(Me.TabMayor)
        Me.TabReporte.Controls.Add(Me.TabMenor)
        Me.TabReporte.Location = New System.Drawing.Point(12, 62)
        Me.TabReporte.Name = "TabReporte"
        Me.TabReporte.SelectedIndex = 0
        Me.TabReporte.Size = New System.Drawing.Size(762, 666)
        Me.TabReporte.TabIndex = 4
        '
        'ReportesEstadisticosDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 740)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.TabReporte)
        Me.Controls.Add(Me.CBRuta)
        Me.Controls.Add(Me.LbRuta)
        Me.Controls.Add(Me.CBTipoReporte)
        Me.Controls.Add(Me.LbTipoReporte)
        Me.MaximizeBox = False
        Me.Name = "ReportesEstadisticosDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes Estadísticos"
        Me.TabMenor.ResumeLayout(False)
        CType(Me.DGReporteMenor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMayor.ResumeLayout(False)
        CType(Me.DGReporteMayor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReporte.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbTipoReporte As Label
    Friend WithEvents CBTipoReporte As ComboBox
    Friend WithEvents LbRuta As Label
    Friend WithEvents CBRuta As ComboBox
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents TabMenor As TabPage
    Friend WithEvents DGReporteMenor As DataGridView
    Friend WithEvents TabMayor As TabPage
    Friend WithEvents DGReporteMayor As DataGridView
    Friend WithEvents TabReporte As TabControl
End Class
