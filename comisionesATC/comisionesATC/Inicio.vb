﻿Public Class Inicio
    Dim sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
