Public Class Ingresar_Producto
    'Dim proveedor As String: esto es para ver como le meto el proveedor
    'a la ventana
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cod_Barras.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Cod_Barras.Text, Label1.Text) = True) And (validar.espacio_blanco(Cod_Barras.Text, Label1.Text) = True) And (validar.nulo(Cod_Barras.Text, Label1.Text))) Then
                Dim Controlador_Ingresar_Producto As Controlador_Ingresar_Producto = New Controlador_Ingresar_Producto
                If (Controlador_Ingresar_Producto.BuscarCodigoBarras(Me.Cod_Barras.Text) = True) Then
                    MsgBox("Error. No se puede ingresar un producto que ya existe.", MsgBoxStyle.OkOnly, "Error")
                    Me.Cod_Barras.Text = ""
                Else
                    Controlador_Ingresar_Producto.ActivarCampos(Me, False)
                    Controlador_Ingresar_Producto.llenar_proveedores(Me, "")
                End If
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cod_Producto.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Cod_Producto.Text, Label2.Text) = True) And (validar.espacio_blanco(Cod_Producto.Text, Label2.Text) = True) And (validar.nulo(Cod_Producto.Text, Label2.Text))) Then
                Dim Controlador_Ingresar_Producto As Controlador_Ingresar_Producto = New Controlador_Ingresar_Producto
                If (Controlador_Ingresar_Producto.BuscarCodigoProducto(Me.Cod_Producto.Text) = True) Then
                    MsgBox("Error. Ya existe un Producto con ese codigo.", MsgBoxStyle.OkOnly, "Error")
                    Me.Cod_Producto.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Nom_Producto.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Nom_Producto.Text, Label3.Text) = True) And (validar.nulo(Nom_Producto.Text, Label3.Text))) Then
                Dim Controlador_Ingresar_Producto As Controlador_Ingresar_Producto = New Controlador_Ingresar_Producto
                If (Controlador_Ingresar_Producto.BuscarNombreProducto(Me.Nom_Producto.Text) = True) Then
                    MsgBox("Error. Ya existe un Producto con ese Codigo.", MsgBoxStyle.OkOnly, "Error")
                    Me.Nom_Producto.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Desc_Producto.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Desc_Producto.Text, Label4.Text) = True) And (validar.nulo(Desc_Producto.Text, Label4.Text))) Then

            End If
        End If
    End Sub

    Private Sub Ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ingresar.Click
        Dim validar As Validaciones_Generales
        validar = New Validaciones_Generales
        If ((validar.comillas(Cod_Producto.Text, Label2.Text) = True) And (validar.espacio_blanco(Cod_Producto.Text, Label2.Text) = True) And (validar.nulo(Cod_Producto.Text, Label2.Text)) And (validar.comillas(Nom_Producto.Text, Label3.Text) = True) And (validar.nulo(Nom_Producto.Text, Label3.Text)) And (validar.comillas(Nom_Producto.Text, Label3.Text) = True) And (validar.nulo(Nom_Producto.Text, Label3.Text)) And (validar.comillas(Desc_Producto.Text, Label4.Text) = True) And (validar.nulo(Desc_Producto.Text, Label4.Text))) Then
            Dim ingresar As Controlador_Ingresar_Producto = New Controlador_Ingresar_Producto
            ingresar.Ingresar_Producto(Me.Cod_Barras.Text, Me.Cod_Producto.Text, Me.Nom_Producto.Text, Me.Desc_Producto.Text, Me.GE_Producto.Text, Integer.Parse(Me.Unidades_Producto.Text), Me.Proveedores.SelectedText)
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


