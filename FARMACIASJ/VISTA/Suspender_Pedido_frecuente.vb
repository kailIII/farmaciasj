Public Class Suspender_Pedido_frecuente

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim Controlador_Pedido_Frecuente_x As Controlador_Pedido_Frecuente
        Controlador_Pedido_Frecuente_x = New Controlador_Pedido_Frecuente
        Controlador_Pedido_Frecuente_x.Buscar_Info_Pedido(Me.Numero_Pedido.Text, Me)

        
    End Sub

    Private Sub Suspender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Suspender.Click
        Dim Controlador_Pedido_Frecuente_x As Controlador_Pedido_Frecuente
        Controlador_Pedido_Frecuente_x = New Controlador_Pedido_Frecuente
        Controlador_Pedido_Frecuente_x.Eliminacion_Pedido(Me.Numero_Pedido.Text, Me)



    End Sub

    Private Sub Numero_Pedido_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Numero_Pedido.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador_Pedido_Frecuente_x As Controlador_Pedido_Frecuente
            Controlador_Pedido_Frecuente_x = New Controlador_Pedido_Frecuente
            Controlador_Pedido_Frecuente_x.Buscar_Info_Pedido(Me.Numero_Pedido.Text, Me)
        End If
    End Sub
End Class