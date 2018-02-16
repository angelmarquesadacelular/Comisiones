Imports System.Windows.Forms.DataVisualization.Charting

Module MetodosDll
    Dim sql As String = ""
    ' Metodo que captura los registros de los excel en la base de datos
    Public Function CapturarRegistros(ByVal DgDatos As DataGridView, ByVal PBCargrando As ProgressBar, ByVal DGSinComision As DataGridView, ByVal DGConComision As DataGridView,
                                      ByVal TabComisiones As TabControl, ByVal DGEfectivo As DataGridView, ByVal DGCredito As DataGridView, ByVal TabCon As TabPage, ByVal TabSin As TabPage,
                                      ByVal GraficaUno As Chart, ByVal GraficaDos As Chart, ByVal LbGraficaUno As Label, ByVal LbGrafciaDos As Label, ByVal DGGraficaVolumen As DataGridView,
                                      ByVal DGGraficaSemanal As DataGridView) As Integer
        'Obtener el periodo del informe de comisiones
        Dim periodo As String = DgDatos.Item(0, 1).Value
        Dim producto As String = DgDatos.Item(2, 4).Value
        Dim tipoReporte As Integer
        If producto = "0" Then
            producto = "COMISIONES DE VOLUMEN"
            tipoReporte = 1
        Else
            tipoReporte = 2
        End If
        Dim anio As String = Year(Now)
        periodo = Right(periodo, 6)
        'Obtener el id del tipo de producto del informe necesario
        sql = "SELECT id 
                FROM producto 
                WHERE nombre='" + producto.ToString + "'"
        Dim productoId As Integer = ComprobrarExistenciaComisiones(sql)
        'Obtener si el informa ha sido capturado anteriormente
        sql = "SELECT id 
                FROM periodo 
                WHERE clave='" + periodo.ToString + "' 
                AND anio='" + anio.ToString + "' 
                AND producto_id='" + productoId.ToString + "'"
        Dim periodoId As Integer = ComprobrarExistenciaComisiones(sql)
        'Validar que no se haya capturado el periodo
        If periodoId > 0 Then
            'Periodo ya capturado
            MsgBox("Periodo ya capturado", MsgBoxStyle.Exclamation, Title:="Comisiones")
        Else
            'Capturar nuevo periodo
            sql = "INSERT INTO periodo(clave,anio,producto_id)
                    VALUES('" + periodo.ToString + "','" + anio.ToString + "','" + productoId.ToString + "')"
            InsertarComisiones(sql, "", 2, "")
            'obtener el id del periodo
            sql = "SELECT id 
                    FROM periodo 
                    WHERE clave='" + periodo.ToString + "' 
                    AND anio='" + anio.ToString + "' 
                    AND producto_id='" + productoId.ToString + "'"
            periodoId = ComprobrarExistenciaComisiones(sql)
            'Iniciar los valores de la porgress bar
            PBCargrando.Minimum = 0
            PBCargrando.Maximum = DgDatos.RowCount
            PBCargrando.Value = 0
            PBCargrando.Visible = True
            'inicialización del contador de comisiones
            Dim totalComisiones As Double = 0.0
            Dim totalEfectivo As Double = 0.0
            Dim totalCredito As Double = 0.0
            'recorrer el datagridview
            For i As Integer = 4 To DgDatos.RowCount - 3
                'obtener los valores
                Try
                    'Reporte de volumen de venta
                    If producto = "COMISIONES DE VOLUMEN" Then
                        DGConComision.Visible = False
                        DGSinComision.Visible = False
                        DGEfectivo.Visible = True
                        DGCredito.Visible = True
                        TabCon.Text = "Efectivo"
                        TabSin.Text = "Crédito"
                        Dim telefono As String = DgDatos.Item(1, i).Value
                        Dim lada As String = Left(telefono, 3)
                        Dim comision As Double = DgDatos.Item(5, i).Value
                        Dim tipoPago As String = DgDatos.Item(6, i).Value
                        'Obtener el id del numero en la base de datos de recargas atc
                        sql = "SELECT id 
                                FROM numero 
                                WHERE digitos='" + telefono.ToString + "'"
                        Dim numero_id As Integer = ComprobrarExistenciaRecargas(sql)
                        If numero_id > 0 Then
                            'obtener el cliente al que pertenece el numero en recargas atc
                            sql = "SELECT CONCAT(pv.tipo,'-',cc.numero) AS clave
                                    FROM punto_venta pv,clave_cliente cc,numero num,cliente cli
                                    WHERE cc.puntoventa_id=pv.id
                                    AND cc.cliente_id=cli.id
                                    AND num.cliente_id=cli.id
                                    AND num.id='" + numero_id.ToString + "'"
                            Dim cliente As String = ObtenerClienteRecargas(sql)
                            Dim puntoVenta As String = Left(cliente, 2)
                            sql = "SELECT cantidad
                                    FROM activado
                                    WHERE numero_id='" + numero_id.ToString + "'"
                            Dim montoActivacion As Double = ObtenerMontoRecargas(sql)
                            Dim utilidad As Double = comision - montoActivacion
                            'Insertar la comisión en la base de datos
                            sql = "INSERT INTO volumenventa(lada,telefono,comision,tipopago,numero_id,puntoventa,cliente,recargaatc,utilidad,periodo_id)
                                    VALUES('" + lada.ToString + "','" + telefono.ToString + "','" + comision.ToString + "','" + tipoPago.ToString + "','" + numero_id.ToString + "','" + puntoVenta.ToString + "','" + cliente.ToString + "','" + montoActivacion.ToString + "','" + utilidad.ToString + "','" + periodoId.ToString + "')"
                            InsertarComisiones(sql, "", 2, "")
                            sql = "SELECT fecha
                                    FROM activado
                                    WHERE numero_id='" + numero_id.ToString + "'"
                            Dim fecha As String = ObtenerFechaActivacionRecargas(sql)
                            If tipoPago = "EFECTIVO" Then
                                DGEfectivo.Rows.Add(cliente, telefono, fecha, comision)
                                totalEfectivo = totalEfectivo + comision
                            Else
                                DGCredito.Rows.Add(cliente, telefono, fecha, comision)
                                totalCredito = totalCredito + comision
                            End If
                            DGGraficaVolumen.Rows.Add(puntoVenta, cliente, telefono, comision, tipoPago)
                        End If

                        'MsgBox(sql)

                    Else
                        'Comisiones semanales
                        DGConComision.Visible = True
                        DGSinComision.Visible = True
                        DGEfectivo.Visible = False
                        DGCredito.Visible = False
                        TabCon.Text = "Con Comisión"
                        TabSin.Text = "Sin Comisión"
                        Dim telefono As String = DgDatos.Item(1, i).Value
                        Dim lada As String = Left(telefono, 3)
                        Dim fuerza As String = DgDatos.Item(4, i).Value
                        Dim montoA As Double
                        Dim montoB As Double
                        Dim montoC As Double
                        Dim comision As Double
                        Dim tipo As String
                        'Obtener el id del numero en la base de datos de recargas atc
                        sql = "SELECT id 
                                FROM numero 
                                WHERE digitos='" + telefono.ToString + "'"
                        Dim numero_id As Integer = ComprobrarExistenciaRecargas(sql)
                        'Validar que el numero exista en la base de datos
                        If numero_id > 0 Then

                            'CHIP EXPRESS 29
                            If (productoId = 1) Then
                                montoA = DgDatos.Item(9, i).Value
                                montoB = DgDatos.Item(10, i).Value
                                montoC = DgDatos.Item(11, i).Value
                                comision = DgDatos.Item(12, i).Value
                                'CHIP X SEGUNDO
                            Else
                                montoA = DgDatos.Item(10, i).Value
                                montoB = DgDatos.Item(11, i).Value
                                montoC = DgDatos.Item(12, i).Value
                                comision = DgDatos.Item(13, i).Value
                            End If
                            'obtener el cliente al que pertenece el numero en recargas atc
                            sql = "SELECT CONCAT(pv.tipo,'-',cc.numero) AS clave
                                    FROM punto_venta pv,clave_cliente cc,numero num,cliente cli
                                    WHERE cc.puntoventa_id=pv.id
                                    AND cc.cliente_id=cli.id
                                    AND num.cliente_id=cli.id
                                    AND num.id='" + numero_id.ToString + "'"
                            Dim cliente As String = ObtenerClienteRecargas(sql)
                            Dim puntoVenta As String = Left(cliente, 2)

                            'Inserción en la base de datos
                            If comision > 0 Then
                                sql = "INSERT INTO comisionessemanales(lada,telefono,fuerza,montoA,montoB,montoC,comision,tipo,numero_id,puntoventa,cliente,periodo_id)
                                    VALUES('" + lada.ToString + "','" + telefono.ToString + "','" + fuerza.ToString + "','" + montoA.ToString + "','" + montoB.ToString + "','" + montoC.ToString + "','" + comision.ToString + "','COMISIONADO','" + numero_id.ToString + "','" + puntoVenta.ToString + "','" + cliente.ToString + "','" + periodoId.ToString + "')"
                                tipo = "COMISIONADO"
                            Else
                                sql = "INSERT INTO comisionessemanales(lada,telefono,fuerza,montoA,montoB,montoC,comision,tipo,numero_id,puntoventa,cliente,periodo_id)
                                    VALUES('" + lada.ToString + "','" + telefono.ToString + "','" + fuerza.ToString + "','" + montoA.ToString + "','" + montoB.ToString + "','" + montoC.ToString + "','" + comision.ToString + "','SIN COMISION','" + numero_id.ToString + "','" + puntoVenta.ToString + "','" + cliente.ToString + "','" + periodoId.ToString + "')"
                                tipo = "SIN COMISION"
                            End If

                            InsertarComisiones(sql, "", 2, "")
                            'MsgBox(sql)

                            'Mostrar la información del número en el reporte
                            sql = "SELECT MAX(montoA) as comision
                                    FROM comisionessemanales
                                    WHERE numero_id='" + numero_id.ToString + "'"
                            Dim montoAMaximo As Double = ObtenerComisionComisiones(sql)
                            sql = "SELECT MAX(montoB) as comision
                                    FROM comisionessemanales
                                    WHERE numero_id='" + numero_id.ToString + "'"
                            Dim montoBMaximo As Double = ObtenerComisionComisiones(sql)
                            sql = "SELECT MAX(montoC) as comision
                                    FROM comisionessemanales
                                    WHERE numero_id='" + numero_id.ToString + "'"
                            Dim montoCMaximo As Double = ObtenerComisionComisiones(sql)
                            sql = "SELECT SUM(comision) as comision
                                    FROM comisionessemanales
                                    WHERE numero_id='" + numero_id.ToString + "'"
                            Dim comisionTotal As Double = ObtenerComisionComisiones(sql)
                            sql = "SELECT fecha
                                    FROM activado
                                    WHERE numero_id='" + numero_id.ToString + "'"
                            Dim fechaActivado As String = ObtenerFechaActivacionRecargas(sql)
                            If comisionTotal > 0 Then
                                totalComisiones = totalComisiones + comisionTotal
                                DGConComision.Rows.Add(cliente, telefono, fechaActivado, montoAMaximo, montoBMaximo, montoCMaximo, comision, comisionTotal)
                            Else
                                DGSinComision.Rows.Add(cliente, telefono, fechaActivado, montoAMaximo, montoBMaximo, montoCMaximo, comision, comisionTotal)
                            End If
                            DGGraficaSemanal.Rows.Add(puntoVenta, cliente, telefono, comision, comisionTotal, tipo)
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'Aumentar los valores de la progress bar
                PBCargrando.Value = i
                DgDatos.FirstDisplayedScrollingRowIndex = i
            Next
            'Se agrega el total del reporte
            If producto = "COMISIONES DE VOLUMEN" Then
                DGEfectivo.Rows.Add("", "Total", totalEfectivo)
                DGCredito.Rows.Add("", "Total", totalCredito)
                sql = "SELECT tipopago,SUM(comision) AS comision
                                        FROM volumenventa
                                        WHERE periodo_id='" + periodoId.ToString + "'
                                        GROUP BY tipopago;"
                GenerarGraficaTipoPago(sql, GraficaUno, LbGraficaUno)
                sql = "SELECT puntoventa, SUM(comision) AS comision
                                        FROM volumenventa
                                        WHERE periodo_id='" + periodoId.ToString + "'
                                        GROUP BY puntoventa;"
                GenerarGraficaRuta(sql, GraficaDos, LbGrafciaDos)
            Else
                'Si hubo comisiones se agrega al final del data grid el total de las comisiones
                If totalComisiones > 0 Then
                    DGConComision.Rows.Add("", "", "", "", "Total", totalComisiones)
                    sql = "SELECT tipo, COUNT(*) as total
                            FROM comisionessemanales
                            WHERE periodo_id='" + periodoId.ToString + "'
                            GROUP BY tipo;"
                    GenerarGraficaComisionesSemanales(sql, GraficaUno, LbGraficaUno)
                    sql = "SELECT puntoventa, SUM(comision) as comision
                            FROM comisionessemanales
                            WHERE periodo_id='" + periodoId.ToString + "'
                            GROUP BY puntoventa;"
                    GenerarGraficaRuta(sql, GraficaDos, LbGrafciaDos)
                End If
            End If

            MsgBox("Se terminó la captura de comisiones", MsgBoxStyle.Information, Title:="Comisiones")
            CapturarRegistros = tipoReporte
            DgDatos.Visible = False
            TabComisiones.Visible = True
            PBCargrando.Visible = 0
        End If
    End Function

    '
    Public Sub GenerarReporte(ByVal CBTipoReporte As ComboBox, ByVal CBRuta As ComboBox, ByVal DGMayor As DataGridView, ByVal DGMenor As DataGridView, ByVal LbRuta As Label, ByVal Tabreporte As TabControl,
                              ByVal TabMayor As TabPage, ByVal TabMenor As TabPage, ByVal BtnReporte As Button, ByVal PBCargando As PictureBox, ByVal LbRango As Label, ByVal CBRango As ComboBox)
        'Reporte de porcentaje de activaciones
        If CBTipoReporte.Text = "Porcentaje de Activación" Then
            CBRuta.Visible = True
            LbRuta.Visible = True
            CBRango.Visible = True
            LbRango.Visible = True
            If CBRuta.Text = "-- Seleccione--" Then

            Else
                If CBRango.Text = "-- Seleccione--" Then

                Else
                    'Se muestra el resultado de una sola rutas
                    sql = "SELECT  CONCAT(pv.tipo,'-',cc.numero) as CLIENTE,COUNT(*) AS NUMEROS,
                        (SELECT COUNT(*)
                        FROM cliente clie,numero nume,activado act
                        WHERE act.numero_id=nume.id
                        AND nume.cliente_id=clie.id
                        AND clie.id=cli.id) AS ACTIVADOS,
                        (SELECT COUNT(*)
                        FROM cliente clien,numero nume,activado acti
                        WHERE acti.numero_id=nume.id
                        AND nume.cliente_id=clien.id
                        AND clien.id=cli.id) * 100 /
                        (SELECT COUNT(*)
                        FROM cliente clie,numero nume
                        WHERE nume.cliente_id=clie.id
                        AND clie.id=cli.id) as PORCENTAJE
                        FROM clave_cliente cc,cliente cli,punto_venta pv,numero num
                        WHERE num.cliente_id=cli.id
                        AND cc.cliente_id=cli.id
                        AND cc.puntoventa_id=pv.id
                        AND pv.tipo='" + CBRuta.Text.ToString + "'
                        GROUP BY cliente
                        ORDER BY PORCENTAJE DESC
                        LIMIT " + CBRango.Text.ToString + ";"
                    mostrarDatosDataGridViewRecargas(sql, DGMayor)
                    'Se muestra el resultado de una sola ruta
                    sql = "SELECT  CONCAT(pv.tipo,'-',cc.numero) as CLIENTE,COUNT(*) AS NUMEROS,
                        (SELECT COUNT(*)
                        FROM cliente clie,numero nume,activado act
                        WHERE act.numero_id=nume.id
                        AND nume.cliente_id=clie.id
                        AND clie.id=cli.id) AS ACTIVADOS,
                        (SELECT COUNT(*)
                        FROM cliente clien,numero nume,activado acti
                        WHERE acti.numero_id=nume.id
                        AND nume.cliente_id=clien.id
                        AND clien.id=cli.id) * 100 /
                        (SELECT COUNT(*)
                        FROM cliente clie,numero nume
                        WHERE nume.cliente_id=clie.id
                        AND clie.id=cli.id) as PORCENTAJE
                        FROM clave_cliente cc,cliente cli,punto_venta pv,numero num
                        WHERE num.cliente_id=cli.id
                        AND cc.cliente_id=cli.id
                        AND cc.puntoventa_id=pv.id
                        AND pv.tipo='" + CBRuta.Text.ToString + "'
                        GROUP BY cliente
                        ORDER BY PORCENTAJE ASC
                        LIMIT " + CBRango.Text.ToString + ";"
                    mostrarDatosDataGridViewRecargas(sql, DGMenor)
                    Tabreporte.Visible = True
                    TabMayor.Text = "MAYOR"
                    TabMenor.Text = "MENOR"
                    BtnReporte.Visible = True
                End If

            End If
        Else
            'Reporte de comisiones
            If CBTipoReporte.Text = "Comisiones" Then
                CBRuta.Visible = True
                LbRuta.Visible = True
                CBRango.Visible = True
                LbRango.Visible = True
                If CBRuta.Text = "-- Seleccione--" Then

                Else
                    If CBRango.Text = "-- Seleccione--" Then

                    Else
                        sql = "SELECT cliente AS CLIENTE, SUM(comision) AS TOTAL
                            FROM volumenventa
                            WHERE puntoventa='" + CBRuta.Text.ToString + "'
                            GROUP BY CLIENTE
                            ORDER BY TOTAL DESC
                            LIMIT " + CBRango.Text.ToString + ";"
                        mostrarDatosDataGridViewComisiones(sql, DGMayor)
                        sql = "SELECT cliente AS CLIENTE, SUM(comision) AS TOTAL
                            FROM volumenventa
                            WHERE puntoventa='" + CBRuta.Text.ToString + "'
                            GROUP BY CLIENTE
                            ORDER BY TOTAL ASC
                            LIMIT " + CBRango.Text.ToString + ";"
                        mostrarDatosDataGridViewComisiones(sql, DGMenor)
                        Tabreporte.Visible = True
                        TabMayor.Text = "MAYOR"
                        TabMenor.Text = "MENOR"
                        BtnReporte.Visible = True
                    End If

                End If
            Else
                'Reporte de utilidad
                If CBTipoReporte.Text = "Utilidad" Then
                    CBRuta.Visible = True
                    LbRuta.Visible = True
                    CBRango.Visible = True
                    LbRango.Visible = True
                    If CBRuta.Text = "-- Seleccione--" Then

                    Else
                        If CBRango.Text.ToString = "-- Seleccione--" Then
                        Else
                            sql = "SELECT cliente AS CLIENTE, COUNT(*) AS RECARGAS,SUM(utilidad) AS UTILIDAD
                            FROM volumenventa
                            WHERE puntoventa='" + CBRuta.Text.ToString + "'
                            GROUP BY CLIENTE
                            ORDER BY UTILIDAD DESC
                            LIMIT " + CBRango.Text.ToString + ";"
                            mostrarDatosDataGridViewComisiones(sql, DGMayor)
                            sql = "SELECT cliente AS CLIENTE,count(*) AS RECARGAS, SUM(utilidad) AS UTILIDAD
                            FROM volumenventa
                            WHERE puntoventa='" + CBRuta.Text.ToString + "'
                            GROUP BY CLIENTE
                            ORDER BY UTILIDAD ASC
                            LIMIT " + CBRango.Text.ToString + ";"
                            mostrarDatosDataGridViewComisiones(sql, DGMenor)
                            Tabreporte.Visible = True
                            TabMayor.Text = "MAYOR"
                            TabMenor.Text = "MENOR"
                            BtnReporte.Visible = True
                        End If

                    End If
                Else
                    'Reporte Comparación de Rutas
                    If CBTipoReporte.Text = "Comparación Rutas" Then
                        CBRuta.Visible = False
                        LbRuta.Visible = False
                        CBRango.Visible = False
                        LbRango.Visible = False
                        sql = "SELECT puntoventa AS RUTA,SUM(utilidad) as UTILIDAD
                                FROM volumenventa
                                GROUP BY puntoventa
                                ORDER BY UTILIDAD DESC;"
                        mostrarDatosDataGridViewComisiones(sql, DGMayor)
                        sql = "SELECT  pv.tipo as RUTA,COUNT(*) AS NUMEROS,
                                (SELECT COUNT(*)
                                FROM cliente clie,numero nume,activado act,clave_cliente ccl,punto_venta pvt
                                WHERE act.numero_id=nume.id
                                AND nume.cliente_id=clie.id
                                AND ccl.cliente_id=clie.id
                                AND ccl.puntoventa_id=pvt.id
                                AND pvt.id=pv.id) AS ACTIVADOS,
                                (SELECT COUNT(*)
                                FROM cliente clien,numero nume,activado acti,clave_cliente ccl,punto_venta pvt
                                WHERE acti.numero_id=nume.id
                                AND nume.cliente_id=clien.id
                                AND ccl.cliente_id=clien.id
                                AND ccl.puntoventa_id=pvt.id
                                AND pvt.id=pv.id)*100/
                                (SELECT COUNT(*)
                                FROM cliente clie,numero nume,clave_cliente ccl,punto_venta pvt 
                                WHERE nume.cliente_id=clie.id
                                AND ccl.cliente_id=clie.id
                                AND ccl.puntoventa_id=pvt.id
                                AND pvt.id=pv.id) as PORCENTAJE
                                FROM clave_cliente cc,cliente cli,punto_venta pv,numero num
                                WHERE num.cliente_id=cli.id
                                AND cc.cliente_id=cli.id
                                AND cc.puntoventa_id=pv.id
                                GROUP BY RUTA
                                ORDER BY PORCENTAJE DESC;"
                        mostrarDatosDataGridViewRecargas(sql, DGMenor)
                        Tabreporte.Visible = True
                        TabMayor.Text = "UTILIDAD"
                        TabMenor.Text = "% ACTIVACIÓN"
                        BtnReporte.Visible = True
                    Else
                        'Reporte Comparación de fuerzas de ventas
                        If CBTipoReporte.Text = "Comparación Utilidad Fuerzas de Venta" Then
                            CBRuta.Visible = False
                            LbRuta.Visible = False
                            CBRango.Visible = True
                            LbRango.Visible = True
                            If CBRango.Text.ToString = "-- Seleccione--" Then
                            Else
                                sql = "SELECT lada AS LADA,SUM(utilidad) as UTILIDAD
                                    FROM volumenventa
                                    GROUP BY LADA
                                    ORDER BY UTILIDAD DESC
                                    LIMIT " + CBRango.Text.ToString + ";"
                                mostrarDatosDataGridViewComisiones(sql, DGMayor)
                                sql = "SELECT lada AS LADA,SUM(utilidad) as UTILIDAD
                                    FROM volumenventa
                                    GROUP BY LADA
                                    ORDER BY UTILIDAD ASC
                                    LIMIT " + CBRango.Text.ToString + ";"
                                mostrarDatosDataGridViewComisiones(sql, DGMenor)
                                Tabreporte.Visible = True
                                TabMayor.Text = "MAYOR"
                                TabMenor.Text = "MENOR"
                                BtnReporte.Visible = True
                            End If

                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Module