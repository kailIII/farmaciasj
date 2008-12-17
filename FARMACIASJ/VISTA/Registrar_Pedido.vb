Public Class Registrar_Pedido

    Public Id_Cliente As Integer
    Public Id_Producto As Integer


    Private Sub Numero_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Numero.KeyPress
        Dim validar As Validaciones_Generales
        Dim Controlador_Pedido_Frecuente As Controlador_Pedido_Frecuente = New Controlador_Pedido_Frecuente
        Dim Pedido As Pedido_Frecuente = New Pedido_Frecuente
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales



            If ((validar.comillas(Numero.Text, Label1.Text) = True) And (validar.espacio_blanco(Numero.Text, Label1.Text) = True) And (validar.nulo(Numero.Text, Label1.Text))) Then

                If (Pedido.BuscarNumeroPedido(Me.Numero.Text) = True) Then
                    MsgBox("Error. No se puede ingresar un pedido que ya existe.", MsgBoxStyle.OkOnly, "Error")
                    Me.Numero.Text = ""
                Else
                    Controlador_Pedido_Frecuente.ActivarCampos(Me, False)
                    Me.Fecha_Fin.Focus()
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
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Codigo_Barras.Text, Label1.Text) = True) And (validar.espacio_blanco(Codigo_Barras.Text, Label1.Text) = True) And (validar.nulo(Codigo_Barras.Text, Label1.Text))) Then
                Dim Producto As Producto = New Producto
                If (Producto.BuscarCodigoBarras(Me.Codigo_Barras.Text) = False) Then
                    MsgBox("Error. El Producto no existe.", MsgBoxStyle.OkOnly, "Error")
                    Me.Codigo_Barras.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingresar.Click
        Dim validar As Validaciones_Generales
        validar = New Validaciones_Generales
        If ((validar.comillas(Descripcion.Text, Label4.Text) = True) And (validar.nulo(Descripcion.Text, Label4.Text))) Then




        End If
        Me.Close()
    End Sub



    Private Sub NombreCliente_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles RIF.KeyPress
        Dim validar As Validaciones_Generales

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(RIF.Text, Label1.Text) = True) And (validar.espacio_blanco(RIF.Text, Label1.Text) = True) And (validar.nulo(RIF.Text, Label1.Text))) Then
                Dim Controlador As Controlador_Pedido_Frecuente = New Controlador_Pedido_Frecuente
                Controlador.Buscar_Cargar_Cliente(Me.RIF.Text, Me)
            End If
        End If
    End Sub


    Private Sub Codigo_Barras_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Codigo_Barras.KeyPress
        Dim Controlador As Controlador_Pedido_Frecuente = New Controlador_Pedido_Frecuente

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controlador.Buscar_Cargar_Proveedor(Me.Codigo_Barras.Text, Me)

        End If
    End Sub
End Class