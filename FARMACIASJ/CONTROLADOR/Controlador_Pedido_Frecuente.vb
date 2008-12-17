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
    Public Sub Abrir_VentaS(ByVal Padre As Windows.Forms.Form)
        Dim Pedido As Suspender_Pedido_frecuente
        Pedido = New Suspender_Pedido_frecuente
        Pedido.MdiParent = Padre
        Pedido.Show()
    End Sub

    Public Sub Buscar_Info_Pedido(ByVal Pedido_Numero As String, ByVal Ventana As Suspender_Pedido_frecuente)
        Dim Pedido_Frecuente_x As Pedido_Frecuente = New Pedido_Frecuente
        Dim Consulta As Data.SqlClient.SqlDataReader = Pedido_Frecuente_x.Cargar_Datos_Pedido(Pedido_Numero)
        If (Consulta.Read) Then
            Ventana.Suspender.Enabled = True
            Ventana.Cliente.Text = Consulta.Item(0).ToString
            Ventana.Producto.Text = Consulta.Item(1).ToString
            Ventana.Cantidad.Text = Consulta.Item(2).ToString
        Else
            Ventana.Cliente.Text = ""
            Ventana.Producto.Text = ""
            Ventana.Cantidad.Text = ""
            MsgBox("No existe el pedido bajo el número suministrado", MsgBoxStyle.OkOnly, "Error")
            Ventana.Suspender.Enabled = False
        End If
    End Sub

    Public Sub Eliminacion_Pedido(ByVal Pedido_Numero As String, ByVal Ventana As Suspender_Pedido_frecuente)
        Dim Pedido_Frecuente_x As Pedido_Frecuente = New Pedido_Frecuente
        If Pedido_Frecuente_x.Suspender_Pedido(Pedido_Numero) Then
            MsgBox("Se ha suspendido el Pedido", MsgBoxStyle.OkOnly, "Aviso")
            Ventana.Cliente.Text = ""
            Ventana.Producto.Text = ""
            Ventana.Cantidad.Text = ""
            Ventana.Numero_Pedido.Text = ""
        Else
            MsgBox("No se pudo suspender el Pedido", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

End Class