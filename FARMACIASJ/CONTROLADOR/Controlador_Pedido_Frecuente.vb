Public Class Controlador_Pedido_Frecuente
    Public Sub ActivarCampos(ByVal pantalla As Registrar_Pedido, ByVal respuesta As Boolean)
        If respuesta = False Then
            pantalla.finicio.Enabled = True
            pantalla.Fin.Enabled = True
            pantalla.Descripcion.Enabled = True
            pantalla.TIPO.Enabled = True
            pantalla.Cantidad.Enabled = True
            pantalla.NombreCliente.Enabled = True
            pantalla.nombreproducto.Enabled = True
            pantalla.Numero.Enabled = False
            pantalla.ingresar.Enabled = True
        End If
    End Sub
    Public Sub Abrir_Venta(ByVal Padre As Windows.Forms.Form)
        Dim Pedido As Registrar_Pedido
        Pedido = New Registrar_Pedido
        Pedido.MdiParent = Padre
        Pedido.Show()
    End Sub
End Class

