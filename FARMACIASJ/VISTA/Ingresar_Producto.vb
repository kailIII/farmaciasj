Public Class Ingresar_Producto
    'Dim proveedor As String: esto es para ver como le meto el proveedor
    'a la ventana
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cod_Barras.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Cod_Barras.Text, Label1.Text) = True) And (validar.espacio_blanco(Cod_Barras.Text, Label1.Text) = True) And (validar.nulo(Cod_Barras.Text, Label1.Text))) Then
                Dim Producto As Producto = New Producto
                If (Producto.BuscarCodigoBarras(Me.Cod_Barras.Text) = True) Then
                    MsgBox("Error. No se puede ingresar un producto que ya existe.", MsgBoxStyle.OkOnly, "Error")
                    Me.Cod_Barras.Text = ""
                Else
                    Dim Controlador_Ingresar_Producto As Controlador_Ingresar_Producto = New Controlador_Ingresar_Producto
                    Controlador_Ingresar_Producto.ActivarCampos(Me, False)
                    'Controlador_Ingresar_Producto.llenar_proveedores(Me, "") NO SIRVE ESTOOO!!!1
                End If
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cod_Producto.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Cod_Producto.Text, Label2.Text) = True) And (validar.espacio_blanco(Cod_Producto.Text, Label2.Text) = True) And (validar.nulo(Cod_Producto.Text, Label2.Text))) Then
                Dim Producto As Producto = New Producto
                If (Producto.BuscarCodigoProducto(Me.Cod_Producto.Text) = True) Then
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
                Dim Producto As Producto = New Producto
                If (Producto.BuscarNombreProducto(Me.Nom_Producto.Text) = True) Then
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
            Dim ingresar As Producto = New Producto
            ingresar.Ingresar_Producto(Me.Cod_Barras.Text, Me.Cod_Producto.Text, Me.Nom_Producto.Text, Me.Desc_Producto.Text, Me.GE_Producto.Text, Integer.Parse(Me.Unidades_Producto.Text), Me.Riff.Text, Me.Linea.Text)

        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Riff_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Riff.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Riff.Text, "Riff") = True) And (validar.espacio_blanco(Riff.Text, "Riff") = True) And (validar.nulo(Riff.Text, "Riff"))) Then
                Dim Proveedor As Proveedor = New Proveedor
                If (Proveedor.BuscarRiff(Me.Riff.Text) = False) Then
                    MsgBox("Error. No existe un Proveedor con ese Riff. Cree un nuevo Proveedor", MsgBoxStyle.OkOnly, "Error")
                    Me.Riff.Text = ""
                    Me.Crear.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Crear.Click
        Dim proveedor As Ingresar_Proveedor = New Ingresar_Proveedor
        proveedor.Show()
    End Sub
    Private Sub Linea_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Linea.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Linea.Text, "Linea de Producto") = True) And (validar.nulo(Linea.Text, "Linea de Producto"))) Then
                Dim Linea As Linea = New Linea
                If (Linea.BuscarLinea(Me.Linea.Text) = False) Then
                    MsgBox("Error. No existe una Linea de producto con ese nombre. Cree una nueva linea", MsgBoxStyle.OkOnly, "Error")
                    Me.Linea.Text = ""
                    Me.CrearLinea.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub CrearLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearLinea.Click
        Dim linea As Ingresar_Linea = New Ingresar_Linea
        linea.Show()
    End Sub
End Class