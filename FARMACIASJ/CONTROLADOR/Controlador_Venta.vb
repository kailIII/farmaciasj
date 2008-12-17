Public Class Controlador_Venta

    Public Function Ingresar_Factura(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal ID_Cliente As Integer) As Integer
        Dim Venta As Venta
        Dim ID As Integer
        Venta = New Venta
        ID = Venta.Ingresar_Venta(Numero, Fecha, Vence, ID_Cliente)
        If (ID <> -1) Then
            Return ID
        Else
            MsgBox("Se pudo Ingresar la Factura Revise e Intente de nuevo", MsgBoxStyle.OkOnly, "Alert")
            Return -1
        End If
    End Function

    Public Sub Ingresar_Detalle(ByVal ID_Detalle As Integer, ByVal ID_VENTA As Integer, ByVal ID_Producto As Integer, ByVal ID_Lote As Integer, ByVal Cantidad As Integer, ByVal ID_Impuesto() As Integer, ByVal Id_Historico_Impuesto() As Integer, ByVal N As Integer)
        Dim Venta As Venta

        Venta = New Venta
        Venta.Ingresar_Detalle(ID_Detalle, ID_VENTA, ID_Producto, ID_Lote, ID_Impuesto, Id_Historico_Impuesto, Cantidad, N)

    End Sub
    Public Function Traer_Detalle(ByVal Id_Factura As Integer) As Data.DataTable
        Dim Venta As Venta
        Venta = New Venta
        Return Venta.Traer_Detalle(Id_Factura)
    End Function
    Public Sub Borrar_Factura(ByVal ID_Factura As Integer, ByVal RVenta As Realizar_Venta)
        Dim Venta As Venta
        Dim Factura As Realizar_Venta
        Venta = New Venta()
        Venta.Borrar_Factura(ID_Factura)
        Factura = New Realizar_Venta()
        Factura.MdiParent = RVenta.MdiParent
        Factura.Show()
        RVenta.Close()
    End Sub

    Public Function CantidadF() As Integer
        Dim Venta As Venta
        Venta = New Venta
        Return Venta.CantidadF()
    End Function
    Public Sub Abrir_Venta(ByVal Padre As Windows.Forms.Form)
        Dim Realizar_Venta As Realizar_Venta
        Realizar_Venta = New Realizar_Venta
        Realizar_Venta.MdiParent = Padre
        Realizar_Venta.Show()
    End Sub
    Public Sub Descontar_Inventario(ByVal ID_Venta As Integer)
        Dim Venta As Venta
        Venta = New Venta
        Venta.Descontar_Inventario(ID_Venta)
    End Sub
    Public Sub Procesar_Venta(ByVal ID_FACTURA As Integer, ByVal Venta As Realizar_Venta)
        Dim Pago As Pago
        Pago = New Pago
        Pago.ID_Factura = ID_FACTURA
        Pago.Numero_Factura.Text = Venta.Numero.Text
        Pago.Numero_ID.Text = Venta.Identidad.Text
        Pago.Stotal.Text = Venta.Sub_Total.Text
        Pago.Impuestos.Text = Venta.Impuesto.Text
        Pago.Total.Text = Venta.Total.Text
        Pago.MdiParent = Venta.MdiParent
        Venta.Close()
        Pago.Show()
    End Sub
    Public Sub Actualizar_Pago(ByVal ID_Factura As Integer, ByVal Stotal As String, ByVal Impuestos As String, ByVal Total As String, ByVal Tipo_Pago As String, ByVal Monto As String, ByVal Vuelto As String, ByVal NCT As String, ByVal Vencimiento As String, ByVal Pago As Pago)
        Dim Venta As Venta
        Dim Realizar_Venta As Realizar_Venta
        Dim FarmaciaSJ As FarmaciaSJDataSet
        Venta = New Venta
        Venta.Pago(ID_Factura, Stotal, Impuestos, Total, Tipo_Pago, Monto, Vuelto, NCT, Vencimiento)
        Realizar_Venta = New Realizar_Venta
        Realizar_Venta.MdiParent = Pago.MdiParent
        FarmaciaSJ = Venta.Cargar_Reporte(ID_Factura)
        Pago.Close()
        Realizar_Venta.Show()
    End Sub
    Public Function combrobarcantidad(ByVal ID_Lote As Integer, ByVal ID_Producto As Integer, ByVal Cantidad As Integer) As Boolean
        Dim Venta As Venta
        Dim C As Integer
        Venta = New Venta
        C = Venta.combrobarcantidad(ID_Lote, ID_Producto)
        If (Cantidad <= C) Then
            Return True
        Else
            Return False

        End If
    End Function

    Public Function combrobarcantidaddetalle(ByVal ID_detalle_venta As Integer, ByVal ID_factura As Integer, ByVal Cantidad As Integer) As Boolean
        Dim Venta As Venta
        Dim C As Integer
        Venta = New Venta
        C = Venta.combrobarcantidaddetalle(ID_detalle_venta, ID_factura)
        If (Cantidad <= C) Then
            Return True
        Else
            Return False

        End If
    End Function



    'LZ
    Public Sub Buscar_Info_Factura(ByVal Control_Numero As String, ByVal Ventana As Registrar_Devolucion)
        Dim Venta_x As Venta = New Venta
        Dim Id_Cliente As Integer = Venta_x.Buscar_id_Cliente_Factura(Control_Numero)
        Dim ControladorF As Controlador_Venta = New Controlador_Venta

        If (Id_Cliente > 0) Then
            Venta_x.Buscar_Info_Cliente(Id_Cliente, Ventana)
            Ventana.DETALLE_VENTA.DataSource = ControladorF.Traer_Detalle(Venta_x.Buscar_Id_Venta_Factura(Control_Numero))
            Ventana.DETALLE_VENTA.Update()
            Ventana.Codigo_Barras.Focus()

        Else
            MsgBox("N�mero de factura inv�lido", MsgBoxStyle.OkOnly, "Error")
            Ventana.Razon_Social.Text = ""
            Ventana.Rif.Text = ""
            Ventana.Telefono.Text = ""
            Ventana.Direccion.Text = ""
            Ventana.DETALLE_VENTA.DataSource = DBNull.Value
            Ventana.DETALLE_VENTA.Update()
        End If
    End Sub

    Public Function Traer_Detalle_Devolucion(ByVal Id_Factura As Integer) As Data.DataTable
        Dim Venta As Venta
        Venta = New Venta
        Return Venta.Traer_Detalle_Devolucion(Id_Factura)
    End Function

    Public Sub Devolucion_Productos(ByVal Control_Numero As String, ByVal Codigo_Barras As String, ByVal Ventana As Registrar_Devolucion)
        Dim Producto_x As Producto = New Producto

        Dim Venta_x As Venta = New Venta
        Dim ControladorF As Controlador_Venta = New Controlador_Venta
        Dim Id_Venta As Integer = Venta_x.Buscar_Id_Venta_Factura(Control_Numero)
        Dim Id_Producto As Integer = Producto_x.idProductos(Codigo_Barras)

        If Venta_x.Existe_Producto_Venta(Id_Venta, Codigo_Barras) Then

            Venta_x.Consulta_Producto_Venta(Id_Venta, Codigo_Barras, Ventana)
            Venta_x.Calculo_Impuesto_Devolucion(Id_Venta, Ventana.ID_Detalle_Publico)
            'Insert de devoluciones
            Dim Id_Venta_Devolucion As Integer = Venta_x.Id_Venta_Devolucion(Id_Venta)
            If Not (Id_Venta_Devolucion > 0) Then

                If Not (Venta_x.Crear_Devolucion(Id_Venta, Ventana.Id_Cliente_Publico, Ventana)) Then
                    MsgBox("El producto no se pudo procesar", MsgBoxStyle.OkOnly, "Error")
                Else

                    Id_Venta_Devolucion = Venta_x.Ultima_Devolucion((Venta_x.Buscar_Id_Venta_Factura(Control_Numero)))
                End If

            End If

            If Not Venta_x.Ingresar_Det_Venta(Id_Venta_Devolucion, Ventana, Id_Producto) Then
                MsgBox("El producto no se pudo procesar", MsgBoxStyle.OkOnly, "Error")
            End If

            Ventana.Cantidad.Enabled = True
            Ventana.Cantidad.Focus()
            Ventana.Devolver.Enabled = True
            Ventana.Detalle_DEV.DataSource = ControladorF.Traer_Detalle_Devolucion(Venta_x.Ultima_Devolucion(Venta_x.Buscar_Id_Venta_Factura(Control_Numero)))
            Ventana.Detalle_DEV.Update()
            ' Calcular el total a devolver....
        Else
            MsgBox("El producto no est� en la venta", MsgBoxStyle.OkOnly, "Error")
            Ventana.Devolver.Enabled = False

        End If

    End Sub



    Public Sub Abrir_Ventana_Devolucion(ByVal Padre As Windows.Forms.Form)
        Dim Venta_Devolucion As Registrar_Devolucion
        Venta_Devolucion = New Registrar_Devolucion
        Venta_Devolucion.MdiParent = Padre
        Venta_Devolucion.Show()
    End Sub

    'Fin LZ


End Class
