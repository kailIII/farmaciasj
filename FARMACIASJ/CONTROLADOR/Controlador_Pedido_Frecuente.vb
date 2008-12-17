Public Class Controlador_Pedido_Frecuente
    Public Sub ActivarCampos(ByVal pantalla As Registrar_Pedido, ByVal respuesta As Boolean)
        If respuesta = False Then
            pantalla.Fecha_Inicio.Enabled = True
            pantalla.Fecha_Fin.Enabled = True
            pantalla.Descripcion.Enabled = True
            pantalla.Cantidad.Enabled = True
            pantalla.RIF.Enabled = True
            pantalla.Codigo_Barras.Enabled = False
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

    Public Sub Buscar_Cargar_Cliente(ByVal Rif As String, ByVal Ventana As Registrar_Pedido)
        Dim Cliente As Cliente = New Cliente
        Ventana.Id_Cliente = Cliente.BuscarCliente(Rif)
        If (Ventana.Id_Cliente > 0) Then
            Cliente.buscar_identidad(Ventana, Rif)
            Ventana.Codigo_Barras.Enabled = True
            Ventana.Codigo_Barras.Focus()
        Else
            MsgBox("Error. El cliente no existe.", MsgBoxStyle.OkOnly, "Error")
            Ventana.RIF.Text = ""
            Ventana.Razon_Social.Text = ""
            Ventana.Id_Cliente = 0
        End If
    End Sub
    Public Sub Buscar_Cargar_Proveedor(ByVal Codigo_Barras As String, ByVal Ventana As Registrar_Pedido)

        Dim Controlador As Producto = New Producto
        Try
            If Controlador.Buscar_Info_Productos(Codigo_Barras, Ventana) Then

            Else
                MsgBox("Error. El Producto no existe.", MsgBoxStyle.OkOnly, "Error")
                Ventana.Codigo_Barras.Text = ""
                Ventana.Nombre_Producto.Text = ""
                Ventana.Id_Producto = 0

            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub Ingresar_Pedido(ByVal Ventana As Registrar_Pedido)
        Dim ingresar As Pedido_Frecuente = New Pedido_Frecuente
        Try
            ingresar.Ingresar_Pedido("", Ventana.Fecha_Inicio.Value, Ventana.Fecha_Fin.Value, Ventana.Descripcion.Text, CInt(Ventana.Cantidad.Text), Ventana.Id_Producto, Ventana.Id_Cliente)
            MsgBox("El Pedido se ha registrado con Éxito.", MsgBoxStyle.OkOnly, "Información")
            Ventana.Close()
        Catch ex As Exception
            MsgBox("Error. No se ingresó el pedido.", MsgBoxStyle.OkOnly, "Error")
        End Try


    End Sub


End Class