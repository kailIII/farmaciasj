Public Class Controlador_Devolucion

    Public Sub DevolverPorCantidades(ByVal Control_Numero As String, ByVal Codigo_Barras As String, ByVal Ventana As Registrar_Devolucion)
        Dim ControladorF As Controlador_Venta = New Controlador_Venta
        Dim Venta_x As Venta = New Venta
        Ventana.Detalle_DEV.DataSource = ControladorF.Traer_Detalle_Devolucion(Venta_x.Ultima_Devolucion(Venta_x.Buscar_Id_Venta_Factura(Control_Numero)))
        Ventana.Detalle_DEV.Update()
        ' Calcular el total a devolver....
    End Sub

End Class
