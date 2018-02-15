Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Reportes
    Inherits Form
    Public Sub New()
        InitializeComponent()
        'BindData()
    End Sub
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CargarArchivosComisionesDlg.tipoReporte = 1 Then
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            dt.Columns.Add("Ruta", GetType(String))
            dt.Columns.Add("Cliente", GetType(String))
            dt.Columns.Add("Numero", GetType(String))
            dt.Columns.Add("Comision", GetType(Double))
            dt.Columns.Add("Tipo", GetType(String))

            For Each dgr As DataGridViewRow In CargarArchivosComisionesDlg.DGGraficaVolumenVenta.Rows
                dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value)
            Next
            ds.Tables.Add(dt)
            ds.WriteXmlSchema("ResumenDeVolumenDeVenta.xml")
            'Try
            Dim cr = New resumenDeVolumenDeVenta()
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()
        Else
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            dt.Columns.Add("Ruta", GetType(String))
            dt.Columns.Add("Cliente", GetType(String))
            dt.Columns.Add("Numero", GetType(String))
            dt.Columns.Add("Comision", GetType(Double))
            dt.Columns.Add("Comision Total", GetType(String))
            dt.Columns.Add("Tipo", GetType(String))

            For Each dgr As DataGridViewRow In CargarArchivosComisionesDlg.DGGraficaReporteSemanales.Rows
                dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value, dgr.Cells(5).Value)
            Next
            ds.Tables.Add(dt)
            ds.WriteXmlSchema("ComisionesSemanales.xml")
            'Try
            Dim cr = New DGGraficaReporteSemanales()
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'BindData()
        Dim ds As New DataSet()
        Dim dt As New DataTable()
        dt.Columns.Add("Ruta", GetType(String))
        dt.Columns.Add("Cliente", GetType(String))
        dt.Columns.Add("Numero", GetType(String))
        dt.Columns.Add("Comision", GetType(Double))
        dt.Columns.Add("Tipo", GetType(String))

        For Each dgr As DataGridViewRow In CargarArchivosComisionesDlg.DGGraficaVolumenVenta.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value)
        Next
        ds.Tables.Add(dt)
        ds.WriteXmlSchema("Sample.xml")
        'Try
        Dim cr = New resumenDeVolumenDeVenta()
        cr.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Refresh()
        'Catch ex As Exception
        '    MsgBox("seleciona un reporte")
        'End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox(CargarArchivosComisionesDlg.tipoReporte)
    End Sub

End Class