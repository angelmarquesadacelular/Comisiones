Public Class ReportesEstadisticosDlg
    Private Sub ReportesEstadisticosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbRuta.Visible = False
        CBRuta.Visible = False
        CBTipoReporte.SelectedIndex = 0
        TabReporte.Visible = False
        DGReporteMayor.AllowUserToAddRows = False
        DGReporteMenor.AllowUserToAddRows = False
    End Sub

    Private Sub CBTipoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoReporte.SelectedIndexChanged
        CBRuta.SelectedIndex = 0
        GenerarReporte(CBTipoReporte, CBRuta, DGReporteMayor, DGReporteMenor, LbRuta, TabReporte)
    End Sub

    Private Sub CBRuta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRuta.SelectedIndexChanged
        GenerarReporte(CBTipoReporte, CBRuta, DGReporteMayor, DGReporteMenor, LbRuta, TabReporte)
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Estadisticas.Visible = True
    End Sub
End Class