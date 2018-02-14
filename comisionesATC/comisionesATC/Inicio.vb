Public Class Inicio
    Dim sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadísticasToolStripMenuItem.Enabled = False
        CargarReportesToolStripMenuItem.Enabled = False
        SalirToolStripMenuItem.Enabled = False
    End Sub

    Private Sub CargarReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarReportesToolStripMenuItem.Click
        CargarArchivosComisionesDlg.Visible = True
    End Sub

    Private Sub EstadísticasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísticasToolStripMenuItem.Click
        ReportesEstadisticosDlg.Visible = True
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        LoginDlg.Visible = True
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        EstadísticasToolStripMenuItem.Enabled = False
        CargarReportesToolStripMenuItem.Enabled = False
        SalirToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
    End Sub
End Class
