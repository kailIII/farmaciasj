Public Class TLF_Proveedor
    Public Id_Proveedor As Integer = 0

    Private Sub Asignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Asignar.Click
        Dim Controlador As Controlador_Proveedor = New Controlador_Proveedor
        If Controlador.AsignarTlfProveedor(Me.Codigo.Text, Me.Numero.Text, Id_Proveedor) Then
            Dim Respuesta As MsgBoxResult = MsgBox("El teléfono se registró con éxito. ¿Desea agregar otro Teléfono y/o Producto?", MsgBoxStyle.OkCancel, "Aviso")
            If Respuesta = MsgBoxResult.Ok Then
                Me.lista1.Items.Add("(" & Me.Codigo.Text & ") " & Me.Numero.Text)
                Me.Codigo.Text = ""
                Me.Numero.Text = ""
                Me.CodigoBarras.Text = ""
                Me.NombreProducto.Text = ""
                Me.Codigo.Focus()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Productos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Productos.Click
        Dim Controlador As Controlador_Producto = New Controlador_Producto
        If Controlador.AsignarProductoProveedor(Me.CodigoBarras.Text, Id_Proveedor) Then
            Dim Respuesta As MsgBoxResult = MsgBox("El Producto se registró con éxito. ¿Desea agregar otro Teléfono y/o Producto??", MsgBoxStyle.OkCancel, "Aviso")
            If Respuesta = MsgBoxResult.Ok Then
                Me.lista2.Items.Add(Me.NombreProducto.Text)
                Me.Codigo.Text = ""
                Me.Numero.Text = ""
                Me.CodigoBarras.Text = ""
                Me.NombreProducto.Text = ""
                Me.CodigoBarras.Focus()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub CodigoBarras_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles CodigoBarras.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador As Controlador_Producto
            Controlador = New Controlador_Producto
            If Controlador.Buscar_Nombre_Producto_Proveedor(Me.CodigoBarras.Text, Me) Then
                Me.Productos.Enabled = True
            Else
                Me.Productos.Enabled = False
            End If
        End If
    End Sub
End Class