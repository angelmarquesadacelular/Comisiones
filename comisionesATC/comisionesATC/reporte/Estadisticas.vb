﻿Public Class Estadisticas
    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ReportesEstadisticosDlg.CBTipoReporte.Text = "Porcentaje de Activación" Then
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            dt.Columns.Add("Cliente", GetType(String))
            dt.Columns.Add("Tota de Numeros", GetType(Int16))
            dt.Columns.Add("Activos", GetType(Int16))
            dt.Columns.Add("% de Activados", GetType(Double))

            If ReportesEstadisticosDlg.TabReporte.SelectedIndex = 0 Then
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMayor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value)
                Next
            Else
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMenor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value)
                Next
            End If

            ds.Tables.Add(dt)
            ds.WriteXmlSchema("%deActivacionesmas.xml")
            'Try
            Dim cr = New porcentaje()
            cr.SetDataSource(ds)
            CREstadisticas.ReportSource = cr
            CREstadisticas.Refresh()

        ElseIf ReportesEstadisticosDlg.CBTipoReporte.Text = "Comisiones" Then
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            dt.Columns.Add("Cliente", GetType(String))
            dt.Columns.Add("Total", GetType(Int16))


            If ReportesEstadisticosDlg.TabReporte.SelectedIndex = 0 Then
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMayor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value)
                Next
            Else
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMenor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value)
                Next
            End If

            ds.Tables.Add(dt)
            ds.WriteXmlSchema("Comisiones.xml")
            'Try
            Dim cr = New Comisiones()
            cr.SetDataSource(ds)
            CREstadisticas.ReportSource = cr
            CREstadisticas.Refresh()

        ElseIf ReportesEstadisticosDlg.CBTipoReporte.Text = "Utilidad" Then
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            dt.Columns.Add("Cliente", GetType(String))
            dt.Columns.Add("Recargas", GetType(Int16))
            dt.Columns.Add("Utilidad", GetType(Double))


            If ReportesEstadisticosDlg.TabReporte.SelectedIndex = 0 Then
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMayor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value)
                Next
            Else
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMenor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value)
                Next
            End If

            ds.Tables.Add(dt)
            ds.WriteXmlSchema("Utilidad.xml")
            'Try
            Dim cr = New Utilidad()
            cr.SetDataSource(ds)
            CREstadisticas.ReportSource = cr
            CREstadisticas.Refresh()

        ElseIf ReportesEstadisticosDlg.CBTipoReporte.Text = "Comparación Rutas" Then

            If ReportesEstadisticosDlg.TabReporte.SelectedIndex = 0 Then
                Dim ds As New DataSet()
                Dim dt As New DataTable()
                dt.Columns.Add("Ruta", GetType(String))
                dt.Columns.Add("Utilidad", GetType(Double))
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMayor.Rows


                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value)

                Next
                ds.Tables.Add(dt)
                ds.WriteXmlSchema("ComparacionRutasmas.xml")
                Dim cr = New ComparacionRutasmas()
                cr.SetDataSource(ds)
                CREstadisticas.ReportSource = cr
                CREstadisticas.Refresh()
            Else
                Dim ds As New DataSet()
                Dim dt As New DataTable()
                dt.Columns.Add("Ruta", GetType(String))
                dt.Columns.Add("Numeros", GetType(Int16))
                dt.Columns.Add("Activados", GetType(Int16))
                dt.Columns.Add("Porcentaje", GetType(Double))
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMenor.Rows


                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value)

                Next
                ds.Tables.Add(dt)
                ds.WriteXmlSchema("ComparacionRutasmenos.xml")
                Dim cr = New ComparacionRutasmenos()
                cr.SetDataSource(ds)
                CREstadisticas.ReportSource = cr
                CREstadisticas.Refresh()
            End If
        ElseIf ReportesEstadisticosDlg.CBTipoReporte.Text = "Comparación Utilidad Fuerzas de Venta" Then
            Dim ds As New DataSet()
            Dim dt As New DataTable()
            dt.Columns.Add("Lada", GetType(Int16))
            dt.Columns.Add("Utilidad", GetType(Double))

            If ReportesEstadisticosDlg.TabReporte.SelectedIndex = 0 Then
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMayor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value)
                Next
            Else
                For Each dgr As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMenor.Rows
                    dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value)
                Next
            End If

            ds.Tables.Add(dt)
            ds.WriteXmlSchema("ComparacionUtilidad.xml")
            'Try
            Dim cr = New ComparacionUtilidad()
            cr.SetDataSource(ds)
            CREstadisticas.ReportSource = cr
            CREstadisticas.Refresh()

        End If
    End Sub


End Class