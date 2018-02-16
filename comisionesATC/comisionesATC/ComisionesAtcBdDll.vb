Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Module ComisionesAtcBdDll
    'Variables para la conexión a la base de datos
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=; database=comisionesatc; port=3306")
    'Dim conexion As New MySqlConnection("server=187.189.152.4 ; user=xampp; password=marquesada?466; database=recargasatc; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim comando As MySqlCommand
    'Método para comprobar la existencia de un elemento en la base de datos comisionesatc
    Public Function ComprobrarExistenciaComisiones(sql As String) As Integer
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ComprobrarExistenciaComisiones = dt.Rows(0).Item("id")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function
    'Método para hacer inserción y actualización en la base de datos
    Public Sub InsertarComisiones(sql As String, mensaje As String, salida As Integer, titulo As String)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            conexion.Close()
            If salida = 1 Then
                MsgBox(mensaje, MsgBoxStyle.Information, Title:=titulo)
            End If
        Catch ex As Exception
            conexion.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Title:=titulo)
        End Try
    End Sub
    'Método que obtiene la comision solicitada ya sea maxima o la suma de la misma
    Public Function ObtenerComisionComisiones(sql As String) As Double
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtenerComisionComisiones = dt.Rows(0).Item("comision")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function

    Public Sub GenerarGraficaTipoPago(sql As String, ByVal grafica As Chart, ByVal LbGrafica As Label)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            grafica.Series(0).Points.Clear()
            grafica.Series(0).IsValueShownAsLabel = True
            grafica.Series(0).ChartType = SeriesChartType.Pie
            grafica.ChartAreas(0).Area3DStyle.Enable3D = True
            grafica.Series(0).Color = Color.RoyalBlue
            grafica.Series(0).XValueMember = "tipopago"
            grafica.Series(0).YValueMembers = "comision"
            grafica.DataSource = dt
            LbGrafica.Text = "Comparación de Tipo Pago"
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    Public Sub GenerarGraficaRuta(sql As String, ByVal grafica As Chart, ByVal LbGrafica As Label)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            grafica.Series(0).Points.Clear()
            grafica.Series(0).IsValueShownAsLabel = True
            grafica.Series(0).ChartType = SeriesChartType.Pie
            grafica.ChartAreas(0).Area3DStyle.Enable3D = True
            grafica.Series(0).Color = Color.RoyalBlue
            grafica.Series(0).XValueMember = "puntoventa"
            grafica.Series(0).YValueMembers = "comision"
            grafica.DataSource = dt
            LbGrafica.Text = "Comparación de Rutas"
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub

    Public Sub GenerarGraficaComisionesSemanales(sql As String, ByVal grafica As Chart, ByVal LbGrafica As Label)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            grafica.Series(0).Points.Clear()
            grafica.Series(0).IsValueShownAsLabel = True
            grafica.Series(0).ChartType = SeriesChartType.Pie
            grafica.ChartAreas(0).Area3DStyle.Enable3D = True
            grafica.Series(0).Color = Color.RoyalBlue
            grafica.Series(0).XValueMember = "tipo"
            grafica.Series(0).YValueMembers = "total"
            grafica.DataSource = dt
            LbGrafica.Text = "Comparación de Tipo Pago"
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
        End Try
    End Sub
    'Método para mostrar los resultados de una consulta en un DataGridView
    Public Sub mostrarDatosDataGridViewComisiones(sql As String, DGReporte As DataGridView)
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            DGReporte.DataSource = dt
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        End Try
    End Sub
    '
    Public Function ObtenerPermiso(sql As String) As Integer
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtenerPermiso = dt.Rows(0).Item("permiso_id")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox("Error en la compañia", MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function
End Module
