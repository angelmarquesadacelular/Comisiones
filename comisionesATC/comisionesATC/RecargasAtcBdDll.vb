Imports MySql.Data.MySqlClient
Module RecargasAtcBdDll
    'Variables para la conexión a la base de datos
    Dim conexion As New MySqlConnection("server=localhost ; user=root; password=; database=recargasatc; port=3306")
    'Dim conexion As New MySqlConnection("server=187.189.152.4 ; user=xampp; password=marquesada?466; database=recargasatc; port=3306")
    Dim ds As MySqlDataAdapter
    Dim dt As DataTable
    Dim comando As MySqlCommand

    'Método para comprobar la existencia de un elemento en la base de datos recargas atc
    Public Function ComprobrarExistenciaRecargas(sql As String) As Integer
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ComprobrarExistenciaRecargas = dt.Rows(0).Item("id")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox(ex.Message, MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function

    'Metodo para obtener el cliente al que pertenece un número en la base de datos recargas atc
    Public Function ObtenerClienteRecargas(sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtenerClienteRecargas = dt.Rows(0).Item("clave")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox(ex.Message, MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function

    'Metodo para obtener la fecha de activacion de un numero en la base de datos recargasatc
    Public Function ObtenerFechaActivacionRecargas(sql As String) As String
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtenerFechaActivacionRecargas = dt.Rows(0).Item("fecha")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox(ex.Message, MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function

    'Metodo para obtener el monto de activacion de un numero en la base de datos recargasatc
    Public Function ObtenerMontoRecargas(sql As String) As Double
        Try
            conexion.Open()
            comando = New MySqlCommand(sql, conexion)
            comando.ExecuteNonQuery()
            ds = New MySqlDataAdapter(comando)
            dt = New DataTable
            ds.Fill(dt)
            ObtenerMontoRecargas = dt.Rows(0).Item("cantidad")
            conexion.Close()
        Catch ex As Exception
            conexion.Close()
            'MsgBox(ex.Message, MsgBoxStyle.Information, Title:="¡¡ATENCIÓN!!")
        End Try
    End Function

    'Método para mostrar los resultados de una consulta en un DataGridView
    Public Sub mostrarDatosDataGridViewRecargas(sql As String, DGReporte As DataGridView)
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
End Module
