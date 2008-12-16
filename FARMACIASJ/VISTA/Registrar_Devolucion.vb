Public Class Registrar_Devolucion

    Private Sub Numero_Control_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Numero_Control.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador_Venta_x As Controlador_Venta
            Controlador_Venta_x = New Controlador_Venta
            Controlador_Venta_x.Buscar_Info_Factura(Me.Numero_Control.Text, Me)
        End If
    End Sub


    Private Sub Codigo_Barras_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Codigo_Barras.KeyPress


        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador_Venta_x As Controlador_Venta
            Controlador_Venta_x = New Controlador_Venta
            Controlador_Venta_x.Devolucion_Productos(Me.Numero_Control.Text, Me.Codigo_Barras.Text, Me)


            'Controlador_Producto_x.idProductos(Me.Codigo_Barras.Text)
        End If
    End Sub


End Class