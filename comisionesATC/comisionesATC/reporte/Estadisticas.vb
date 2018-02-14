Public Class Estadisticas
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

            'For Each dgr1 As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMenor.Rows
            '    dt.Rows.Add(dgr1.Cells(0).Value, dgr1.Cells(1).Value, dgr1.Cells(2).Value, dgr1.Cells(3).Value)
            'Next
            ds.Tables.Add(dt)
            ds.WriteXmlSchema("%deActivacionesmas.xml")
            'Try
            Dim cr = New porcentaje()
            cr.SetDataSource(ds)
            CREstadisticas.ReportSource = cr
            CREstadisticas.Refresh()





            'dt1.Columns.Add("Cliente", GetType(String))
            'dt1.Columns.Add("Tota de Numeros", GetType(Int16))
            'dt1.Columns.Add("Activos", GetType(Int16))
            'dt1.Columns.Add("% de Activados", GetType(Double))


            'For Each dgr1 As DataGridViewRow In ReportesEstadisticosDlg.DGReporteMenor.Rows
            '    dt1.Rows.Add(dgr1.Cells(0).Value, dgr1.Cells(1).Value, dgr1.Cells(2).Value, dgr1.Cells(3).Value)
            'Next
            'ds1.Tables.Add(dt1)
            'ds1.WriteXmlSchema("%deActivacionesmenos.xml")
            'Dim cr1 = New porcentaje()
            'cr1.SetDataSource(ds1)
            'CREstadisticas.ReportSource = cr1
            'CREstadisticas.Refresh()

        End If
    End Sub


End Class