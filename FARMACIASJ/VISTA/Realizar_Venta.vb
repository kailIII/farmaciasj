Public Class Realizar_Venta
    Public ID_Cliente As Integer
    Public ID_Factura As Integer = -1
    Public ID_Detalle As Integer = 0
    Public ID_Producto As Integer
    Public ID_Lote As Integer

    Private Sub Identidad_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Identidad.KeyPress
        Dim Controlador As Controlador_Cliente
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controlador = New Controlador_Cliente
            Controlador.Buscar_Cliente(Me.Tipo_Identidad.Text, Me.Identidad.Text, Me)
        End If
    End Sub

    Private Sub Codigo_Barras_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Codigo_Barras.KeyPress
        Dim ControladorF As Controlador_Venta
        Dim ControladorC As Controlador_Cliente
        Dim a As Boolean
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            ControladorF = New Controlador_Venta
            ControladorC = New Controlador_Cliente
            If (ID_Factura = -1) Then
                If (ID_Cliente = -1) Then
                    a = ControladorC.Ingresar_Cliente(Tipo_Identidad.Text, Identidad.Text, Nombre.Text, Apellido.Text, Telefono.Text, Direccion.Text)
                    If (a = True) Then
                        ControladorC.Buscar_Cliente(Tipo_Identidad.Text, Identidad.Text, Me)
                    End If

                End If
                If (ID_Cliente <> -1) Then
                    ID_Factura = ControladorF.Ingresar_Factura(Numero.Text, Fecha_Compra.Value, Vence.Value, ID_Cliente)
                    If (ID_Factura <> -1) Then
                        ID_Detalle = ID_Detalle + 1
                        'ControladorF.Ingresar_Detalle(ID_Factura, ID_Lote, ID_producto, Cantidad.Text, ID_Detalle)

                    End If
                End If
            End If
        End If
    End Sub

End Class