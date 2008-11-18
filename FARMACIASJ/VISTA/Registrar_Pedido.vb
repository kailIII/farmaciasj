Public Class Registrar_Pedido

    Private Sub Numero_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Numero.KeyPress, Numero.TextChanged
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Numero.Text, Label1.Text) = True) And (validar.espacio_blanco(Numero.Text, Label1.Text) = True) And (validar.nulo(Numero.Text, Label1.Text))) Then
                Dim Pedido As Pedido_Frecuente = New Pedido_Frecuente
                If (Pedido.BuscarNumeroPedido(Me.Numero.Text) = True) Then
                    MsgBox("Error. No se puede ingresar un pedido que ya existe.", MsgBoxStyle.OkOnly, "Error")
                    Me.Numero.Text = ""
                Else
                    Dim Controlador_Pedido_Frecuente As Controlador_Pedido_Frecuente = New Controlador_Pedido_Frecuente
                    Controlador_Pedido_Frecuente.ActivarCampos(Me, False)
                    'Controlador_Ingresar_Producto.llenar_proveedores(Me, "") NO SIRVE ESTOOO!!!1
                End If
            End If
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Descripcion.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Descripcion.Text, Label4.Text) = True) And (validar.nulo(Descripcion.Text, Label4.Text))) Then

            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles nombreproducto.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(nombreproducto.Text, Label1.Text) = True) And (validar.espacio_blanco(nombreproducto.Text, Label1.Text) = True) And (validar.nulo(nombreproducto.Text, Label1.Text))) Then
                Dim Producto As Producto = New Producto
                If (Producto.BuscarCodigoBarras(Me.nombreproducto.Text) = False) Then
                    MsgBox("Error. El Producto no existe.", MsgBoxStyle.OkOnly, "Error")
                    Me.nombreproducto.Text = ""
                    Me.Crearproducto.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar.Click
        Dim validar As Validaciones_Generales
        validar = New Validaciones_Generales
        If ((validar.comillas(Descripcion.Text, Label4.Text) = True) And (validar.nulo(Descripcion.Text, Label4.Text))) Then
            Dim ingresar As Pedido_Frecuente = New Pedido_Frecuente
            ingresar.Ingresar_Pedido(Me.Numero.Text, Me.Finicio.Value, Me.Fin.Value, Me.Descripcion.Text, Integer.Parse(Me.Cantidad.Text), Me.nombreproducto.Text)
        End If
        Me.Close()
    End Sub

    Private Sub Crearproducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crearproducto.Click
        Dim producto As Ingresar_Producto = New Ingresar_Producto
        producto.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click

    End Sub
End Class