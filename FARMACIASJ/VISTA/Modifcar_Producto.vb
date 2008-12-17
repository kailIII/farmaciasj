Public Class Modificar_Producto
    Public id_Producto As Integer
    Public proveedoresSelected(10000) As Integer
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cod_Barras.KeyPress
        Dim validar As Validaciones_Generales
        Dim producto As New Controlador_Producto
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(Cod_Barras.Text, Label1.Text) = True) And (validar.espacio_blanco(Cod_Barras.Text, Label1.Text) = True) And (validar.nulo(Cod_Barras.Text, Label1.Text))) Then
                If (validar.Validar_Codigo_Barras(Me.Cod_Barras.Text) = True) Then
                    producto.buscar_producto(Me.Cod_Barras.Text, Me)
                Else
                    Me.Cod_Barras.Text = ""
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
                If (validar.Validar_Nombre_Producto(Me.Nom_Producto.Text) = True) Then
                    Me.Cod_Barras.Text = ""
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
            Dim ingresa As New Controlador_Producto
            ingresa.modificar_producto(Str(id_Producto), Me.Desc_Producto.Text, Me.GE_Producto.Text, Me.Unidades_Producto.Text, Me.Proveedores, Me.Lineas.Text, Me.proveedoresSelected)
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Crear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim proveedor As Ingresar_Proveedor = New Ingresar_Proveedor
        proveedor.Show()
    End Sub

    Private Sub Ingresar_Producto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LINEATableAdapter.Fill(Me.FarmaciaSJDataSet.LINEA)
        'TODO: This line of code loads data into the 'FarmaciassjDataSet.PROVEEDOR' table. You can move, or remove it, as needed.
        Me.PROVEEDORTableAdapter.Fill(Me.FarmaciaSJDataSet.PROVEEDOR)
        Dim i As Integer = 0
        While (i < Me.Proveedores.Items.Count - 1)
            Me.Proveedores.SetSelected(i, False)
            i = i + 1
        End While
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PROVEEDORTableAdapter.Fill(Me.FarmaciaSJDataSet.PROVEEDOR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class