Public Class Controlador_Devolucion

    Public Sub DevolverPorCantidades(ByVal Control_Numero As String, ByVal Codigo_Barras As String, ByVal Ventana As Devolucion_Venta)
        Dim ControladorF As Controlador_Venta = New Controlador_Venta
        Dim Venta_x As Venta = New Venta
        Ventana.DETALLE_VENTA.DataSource = ControladorF.Traer_Detalle_Devolucion(Venta_x.Ultima_Devolucion(Venta_x.Buscar_Id_Venta_Factura(Control_Numero)))
        Ventana.DETALLE_VENTA.Update()
        ' Calcular el total a devolver....
    End Sub

End Class
