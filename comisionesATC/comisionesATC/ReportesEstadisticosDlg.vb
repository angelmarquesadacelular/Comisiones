Public Class ReportesEstadisticosDlg
    Private Sub ReportesEstadisticosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbRuta.Visible = False
        CBRuta.Visible = False
        CBTipoReporte.SelectedIndex = 0
        TabReporte.Visible = False
        DGReporteMayor.AllowUserToAddRows = False
        DGReporteMenor.AllowUserToAddRows = False
        BtnImprimir.Visible = False
    End Sub

    Private Sub CBTipoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoReporte.SelectedIndexChanged
        CBRuta.SelectedIndex = 0
        TabReporte.Visible = False
        BtnImprimir.Visible = False
        GenerarReporte(CBTipoReporte, CBRuta, DGReporteMayor, DGReporteMenor, LbRuta, TabReporte, TabMayor, TabMenor, BtnImprimir)
    End Sub

    Private Sub CBRuta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRuta.SelectedIndexChanged
        BtnImprimir.Visible = False
        TabReporte.Visible = False
        GenerarReporte(CBTipoReporte, CBRuta, DGReporteMayor, DGReporteMenor, LbRuta, TabReporte, TabMayor, TabMenor, BtnImprimir)
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Estadisticas.Visible = True
    End Sub
End Class