Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()
        BindData()
    End Sub
    Private Sub BindData()
        Dim dt As New DataTable()
        Using con As New MySqlConnection("server=127.0.0.1;database=empresa;user id=root;password=;")
            con.Open()
            Dim cmd As New MySqlCommand("Select * from detalle where codigoVenta = '" & Me.txtbuscar.Text & "' and codigoProducto = '" & Me.TextBox1.Text & "'", con)
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            con.Close()
        End Using
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindData()
        Dim ds As New DataSet()
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Int16))
        dt.Columns.Add("codigoVenta", GetType(Int16))
        dt.Columns.Add("codigoProducto", GetType(Int16))
        dt.Columns.Add("cantidad", GetType(Int16))
        dt.Columns.Add("importe", GetType(Int16))
        For Each dgr As DataGridViewRow In DataGridView1.Rows
            dt.Rows.Add(dgr.Cells(0).Value, dgr.Cells(1).Value, dgr.Cells(2).Value, dgr.Cells(3).Value, dgr.Cells(4).Value)
        Next
        ds.Tables.Add(dt)
        ds.WriteXmlSchema("Sample.xml")
        Try
            Dim cr = reporte
            cr.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = cr
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("seleciona un reporte")
        End Try

    End Sub
    Public modo As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        Dim ObjReporte As New CrystalReport1
        Dim ObjReporte2 As New CrystalReport2
        If modo = 1 Then
            CrystalReportViewer1.ReportSource = ObjReporte
        End If
        If modo = 2 Then
            CrystalReportViewer1.ReportSource = ObjReporte2
        End If
    End Sub

    Public reporte
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        reporte = New CrystalReport1()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        reporte = New CrystalReport2()
    End Sub

End Class
