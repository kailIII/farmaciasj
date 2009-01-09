Public Class Registrar_Pedido

    Public Id_Cliente As Integer
    Public Id_Producto As Integer

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
        Dim Controlador As Controlador_Pedido_Frecuente
        Controlador = New Controlador_Pedido_Frecuente


        Dim validar As Validaciones_Generales
        validar = New Validaciones_Generales
        If ((validar.comillas(Descripcion.Text, Label4.Text) = True) And (validar.nulo(Descripcion.Text, Label4.Text))) Then
            Controlador.Ingresar_Pedido(Me)

        End If

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

    Private Sub RIF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIF.TextChanged
        If (Me.RIF.Text.Length = 1) Then
            If (Me.RIF.Text(0) = Char.Parse("J") Or Me.RIF.Text(0) = Char.Parse("G")) Then
                Me.RIF.MaxLength = 10
            ElseIf (Me.RIF.Text(0) = Char.Parse("V") Or Me.RIF.Text(0) = Char.Parse("E")) Then
                Me.RIF.MaxLength = 9
            ElseIf (Me.RIF.Text(0) = Char.Parse("P")) Then
                Me.RIF.MaxLength = 12
            Else
                Me.RIF.Text = ""
            End If
        ElseIf (Me.RIF.Text.Length > 1) Then
            Dim count As Integer
            count = Me.RIF.Text.Length - 1
            If (Char.IsDigit(Me.RIF.Text(count)) = False) Then
                Dim A As String
                A = Me.RIF.Text
                A = A.Substring(0, count)
                Me.RIF.Text = A
                Me.RIF.SelectionStart = Me.RIF.Text.Length
            End If
        End If
    End Sub
End Class