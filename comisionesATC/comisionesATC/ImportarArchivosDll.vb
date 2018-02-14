Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Module ImportarArchivosDll
    'Metodo que permite abrir un archuivo de tipo excel y mostrar su contenido en un Datagridview
    Public Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With

        If myFileDialog.FileName.ToString <> "" Then
            tabla.Visible = True
            Dim ExcelFile As String = myFileDialog.FileName.ToString
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            'xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            xSheet = "hoja1"
            conn = New OleDbConnection(
                              "Provider=Microsoft.ACE.OLEDB.12.0;" &
                              "data source=" & ExcelFile & "; " &
                             "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)
                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                'MsgBox(dt.Rows.Count)
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
                MsgBox("Se ha cargado el documento correctamente", MsgBoxStyle.Information, "Comisiones")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Información")
            Finally
                conn.Close()
            End Try
        End If
        'MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub
End Module
