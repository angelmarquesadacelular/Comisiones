Imports System.Threading
Public Class ReportesEstadisticosDlg
    'Declarar los hilos
    Public reporteHilo As Threading.Thread
    Public cargandoHilo As Threading.Thread
    Public Tarea3 As Threading.Thread
    Dim bandera As Integer = 0
    Dim estado As Integer = 1
    Private Sub ReportesEstadisticosDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbRuta.Visible = True
        CBRuta.Visible = True
        LbRango.Visible = True
        CBRango.Visible = True
        CBTipoReporte.SelectedIndex = 0
        TabReporte.Visible = False
        DGReporteMayor.AllowUserToAddRows = False
        DGReporteMenor.AllowUserToAddRows = False
        BtnImprimir.Visible = False
        'Declaracion de hilos
        Control.CheckForIllegalCrossThreadCalls = False
        reporteHilo = New System.Threading.Thread(AddressOf Reporte)
        cargandoHilo = New System.Threading.Thread(AddressOf Cargando)
        bandera = 1
        ProgressBar1.Visible = 0
        BtnGenerar.Visible = False
    End Sub

    Private Sub CBTipoReporte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipoReporte.SelectedIndexChanged
        If CBTipoReporte.Text <> "-- Seleccione --" Then
            If CBTipoReporte.Text = "Comparación Rutas" Then
                CBRuta.Visible = False
                LbRuta.Visible = False
                CBRuta.SelectedIndex = 0
                CBRango.Visible = False
                LbRango.Visible = False
                CBRango.SelectedIndex = 0
                BtnGenerar.Visible = True
            Else
                If CBTipoReporte.Text = "Comparación Utilidad Fuerzas de Venta" Then
                    CBRango.Visible = True
                    LbRango.Visible = True
                    CBRuta.Visible = False
                    LbRuta.Visible = False
                    CBRango.SelectedIndex = 0
                    BtnGenerar.Visible = True
                Else
                    CBRuta.Visible = True
                    LbRuta.Visible = True
                    CBRuta.SelectedIndex = 0
                    CBRango.Visible = True
                    LbRango.Visible = True
                    CBRango.SelectedIndex = 0
                    BtnGenerar.Visible = True
                End If
            End If
        Else
            CBRuta.Visible = False
            LbRuta.Visible = False
            CBRango.Visible = False
            LbRango.Visible = False
            BtnGenerar.Visible = False
            BtnImprimir.Visible = False
        End If

    End Sub

    Private Sub CBRuta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRuta.SelectedIndexChanged
        If CBRuta.Text <> "-- Seleccione--" Then
            CBRango.Visible = True
            LbRango.Visible = True
            CBRango.SelectedIndex = 0
        Else
            CBRango.Visible = False
            LbRango.Visible = False
            BtnGenerar.Visible = False
            BtnImprimir.Visible = False
        End If
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Estadisticas.Visible = True
    End Sub

    Private Sub CBRango_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRango.SelectedIndexChanged
        If CBRango.Text <> "-- Seleccione--" Then
            BtnGenerar.Visible = True
        Else
            BtnGenerar.Visible = False
            BtnImprimir.Visible = False
        End If
    End Sub

    Private Sub Reporte()
        TabReporte.Visible = False
        BtnImprimir.Visible = False
        estado = GenerarReporte(CBTipoReporte, CBRuta, DGReporteMayor, DGReporteMenor, LbRuta, TabReporte, TabMayor, TabMenor, BtnImprimir, LbRango, CBRango)
        reporteHilo.Abort()
    End Sub

    Private Sub Cargando()
        'MsgBox("Tarea1")
        'Iniciar los valores de la porgress bar
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 10
        ProgressBar1.Value = 0
        Dim i As Integer = 0
        ProgressBar1.Visible = True
        While (i < 10 And TabReporte.Visible = False)
            Thread.Sleep(200)
            ProgressBar1.Value = i
            i = i + 1
            If i = 10 Then
                i = 0
            End If
        End While
        ProgressBar1.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Try
            If bandera > 0 Then
                cargandoHilo = New System.Threading.Thread(AddressOf Cargando)
                cargandoHilo.Start()
                reporteHilo = New System.Threading.Thread(AddressOf Reporte)
                reporteHilo.Start()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class