Imports System.Threading
Public Class CargarArchivosComisionesDlg
    Public tipoReporte As Integer
    Private Sub ImportarArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarArchivoToolStripMenuItem.Click
        CargarReportes()
    End Sub

    Private Sub CargarArchivosComisionesDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PBCargar.Visible = False
        PBCargando.Visible = False
        DGImportacion.Visible = False
        TabReporte.Visible = False
        DGGraficaVolumenVenta.AllowUserToAddRows = False
        DGGraficaReporteSemanales.AllowUserToAddRows = False
        DGGraficaVolumenVenta.Visible = False
        DGGraficaReporteSemanales.Visible = False
        GenerarReporteToolStripMenuItem.Enabled = False
        DGConComision.Enabled = False
        DGSinComision.Enabled = False
        DGVolumenVentaCredito.Enabled = False
        DGVolumenVentaEfectivo.Enabled = False
    End Sub

    Private Sub CargarReportes()
        ImportarArchivoToolStripMenuItem.Enabled = False
        TabReporte.Visible = False
        DGSinComision.Rows.Clear()
        DGConComision.Rows.Clear()
        DGVolumenVentaCredito.Rows.Clear()
        DGVolumenVentaEfectivo.Rows.Clear()
        PBCargando.Visible = True
        importarExcel(DGImportacion)
        PBCargando.Visible = False
        tipoReporte = CapturarRegistros(DGImportacion, PBCargar, DGSinComision, DGConComision, TabReporte, DGVolumenVentaEfectivo, DGVolumenVentaCredito, TabConComision, TabSinComision, GraficaUno, GraficaDos, LbGraficaUno, LbGraficaDos, DGGraficaVolumenVenta, DGGraficaReporteSemanales)
        PBCargando.Visible = False
        GenerarReporteToolStripMenuItem.Enabled = True
        ImportarArchivoToolStripMenuItem.Enabled = True
    End Sub

    Private Sub GenerarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem.Click
        Reportes.Visible = True
    End Sub
End Class