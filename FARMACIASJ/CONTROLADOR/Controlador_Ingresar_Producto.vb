Public Class Controlador_Ingresar_Producto

    Public Sub ActivarCampos(ByVal pantalla As Ingresar_Producto, ByVal respuesta As Boolean)
        If respuesta = False Then
            pantalla.Nom_Producto.Enabled = True
            pantalla.Unidades_Producto.Enabled = True
            pantalla.GE_Producto.Enabled = True
            pantalla.Desc_Producto.Enabled = True
            pantalla.Cod_Producto.Text = Me.Generar_Codigo_Producto
            pantalla.Lineas.Enabled = True
            pantalla.Ingresar.Enabled = True
            pantalla.Cod_Barras.Enabled = False
            pantalla.Proveedores.Enabled = True
        End If
    End Sub

    Public Function Generar_Codigo_Producto() As String
        Dim producto As Producto = New Producto
        Dim nuevocodigo As Integer
        Dim codigo As String
        nuevocodigo = producto.total_productos + 1
        codigo = "P" & nuevocodigo.ToString
        Return codigo
    End Function

    Public Sub preingreso_producto(ByVal codigo_barras As String, ByVal codigo As String, ByVal nombre_producto As String, ByVal desc_producto As String, ByVal ge_producto As String, ByVal u_producto As Integer, ByVal proveedor As Windows.Forms.ListBox, ByVal linea As String)
        Dim contador As Integer = 0
        Dim prueba As String
        Dim validar As Validaciones_Generales = New Validaciones_Generales
        If (validar.Validar_Ingresar_Producto(codigo_barras, codigo, nombre_producto, desc_producto, ge_producto, u_producto, proveedor, linea) = True) Then
            Dim ingresar As Producto = New Producto
            While (contador < proveedor.SelectedItems.Count)
                'aca va la opcion de buscar la situacion con una consulta
                prueba = proveedor.GetItemText(proveedor.SelectedItems.Item(contador))
                ingresar.Ingresar_Producto(codigo_barras, codigo, nombre_producto, desc_producto, ge_producto, u_producto, prueba, linea)
                contador = contador + 1
            End While
        End If
    End Sub
End Class