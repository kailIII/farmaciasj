Public Class Controlador_Producto
    Public ID_Productos(1000) As String
    Public ID_LOTES(1000) As String
    Public Nombre(1000) As String
    Public Descripcion(1000) As String
    Public Codigos(1000) As String
    Public PVPs(1000) As String
    Public Descuentos(1000) As String
    Private Venta As Realizar_Venta

    Public Function Buscar_CodigoBarras(ByVal Codigo As String, ByVal Venta As Realizar_Venta) As Boolean
        Dim Producto As Producto
        Dim Lotes As Data.SqlClient.SqlDataReader
        Dim Impuestos As Data.SqlClient.SqlDataReader
        Dim CImpuestos As Integer
        Dim ELotes As Elegir_Lote
        Dim Cadena As String
        Producto = New Producto
        Dim i As Integer
        Dim filas As Integer
        Lotes = Producto.Buscar_CodigoBarras(Codigo)
        filas = Producto.Cantidad_Filas(Codigo)
        Impuestos = Producto.Impuestos(Codigo)
        CImpuestos = Producto.Cantidad_Impuestos(Codigo)
        If (filas = 1) Then
            If (Lotes.Read = True) Then
                Venta.ID_Producto = Integer.Parse(Lotes.Item(0).ToString)
                Venta.ID_Lote = Integer.Parse(Lotes.Item(1).ToString)
                Venta.NombreP.Text = Lotes.Item(2).ToString
                Venta.Descripcion.Text = Lotes.Item(3).ToString
                Venta.Codigo_Barras.Text = Lotes.Item(4).ToString
                Venta.Punitario.Text = Lotes.Item(6).ToString
                Venta.Descuento.Text = Lotes.Item(7).ToString
                Venta.Cantidad.Text = CStr(0.0)
                Venta.SubtotalP.Text = CStr(0.0)
                Venta.ImpuestoP = 0.0
                If (CImpuestos > 0) Then
                    i = 0
                    Do While (Impuestos.Read() = True)
                        Venta.ID_Impuesto(i) = Integer.Parse(Impuestos.Item(1).ToString)
                        Venta.ID_Historico_Impuesto(i) = Integer.Parse(Impuestos.Item(0).ToString)
                        Venta.ValorI(i) = Double.Parse(Impuestos.Item(2).ToString)
                        i = i + 1
                    Loop
                    Venta.CImpuestos = CImpuestos
                End If
                Return True
            End If
        ElseIf (filas > 1) Then
            Me.Venta = Venta
            i = 0
            ELotes = New Elegir_Lote

            Do While (Lotes.Read() = True)
                Cadena = Lotes.Item(2).ToString & " Vence: " & Lotes.Item(5).ToString
                ELotes.Lotes.Items.Insert(i, Cadena)
                ID_Productos(i) = Lotes.Item(0).ToString
                ID_LOTES(i) = Lotes.Item(1).ToString
                Nombre(i) = Lotes.Item(2).ToString
                Descripcion(i) = Lotes.Item(3).ToString
                Codigos(i) = Lotes.Item(4).ToString
                PVPs(i) = Lotes.Item(6).ToString
                Descuentos(i) = Lotes.Item(7).ToString
                i = i + 1
            Loop
            If (CImpuestos > 0) Then
                i = 0
                Do While (Impuestos.Read() = True)
                    Venta.ID_Impuesto(i) = Integer.Parse(Impuestos.Item(1).ToString)
                    Venta.ID_Historico_Impuesto(i) = Integer.Parse(Impuestos.Item(0).ToString)
                    Venta.ValorI(i) = Double.Parse(Impuestos.Item(2).ToString)
                    i = i + 1
                Loop
                Venta.CImpuestos = CImpuestos
            End If
            ELotes.ControladorP = Me
            ELotes.MdiParent = Venta.MdiParent
            ELotes.Show()
            Return True
        Else
                MsgBox("El producto Solicitado no existe", MsgBoxStyle.OkOnly, "Alert")
                Return False
        End If
    End Function

    Public Sub Regreso(ByVal I As Integer)
        Venta.ID_Producto = Integer.Parse(ID_Productos(I))
        Venta.ID_Lote = Integer.Parse(ID_LOTES(I))
        Venta.NombreP.Text = Nombre(I)
        Venta.Descripcion.Text = Descripcion(I)
        Venta.Codigo_Barras.Text = Codigos(I)
        Venta.Punitario.Text = PVPs(I)
        Venta.Descuento.Text = Descuentos(I)
        Venta.Cantidad.Text = CStr(0.0)
        Venta.SubtotalP.Text = CStr(0.0)
    End Sub

    Public Sub Buscar_CodigoBarras_IDPROVEEDOR(ByVal CODIGO_BARRAS As String, ByVal ID_Proveedor As Integer, ByVal Compra As Registrar_Compra)
        Dim Producto As Producto
        Dim Reder As Data.SqlClient.SqlDataReader
        Producto = New Producto
        Reder = Producto.Buscar_CodigoBarras_IDPROVEEDOR(CODIGO_BARRAS, ID_Proveedor)
        If (Reder.HasRows = True) Then
            If (Reder.Read = True) Then
                Compra.ID_Producto = Integer.Parse(Reder.Item(0).ToString)
                Compra.NOMBRE_PRODUCTO.Text = Reder.Item(2).ToString
                Compra.ID_Linea = Integer.Parse(Reder.Item(6).ToString)
                Compra.DescMax = Double.Parse(Reder.Item(9).ToString)
                Compra.MUtil = Double.Parse(Reder.Item(10).ToString)
            End If
        Else
            Reder = Producto.Buscar_CodigoBarras2(CODIGO_BARRAS)
            If (Reder.HasRows = True) Then
                If (Reder.Read = True) Then
                    If (MsgBox("El Producto: " & Reder.Item(1).ToString & " No esta asociado al Proveedor, ¿Desea Asociarlo?", MsgBoxStyle.YesNo, "Alert") = MsgBoxResult.Yes) Then
                        Compra.ID_Producto = Integer.Parse(Reder.Item(0).ToString)
                        Producto.Ingresar_Proveedor_Producto(Compra.ID_Producto, ID_Proveedor)
                        Compra.NOMBRE_PRODUCTO.Text = Reder.Item(2).ToString
                        Compra.ID_Linea = Integer.Parse(Reder.Item(6).ToString)
                        Compra.DescMax = Double.Parse(Reder.Item(9).ToString)
                        Compra.MUtil = Double.Parse(Reder.Item(10).ToString)
                    End If

                End If
            Else
                'If (MsgBox("El Prodcuto No existe, ¿Desea Agregarlo?", MsgBoxStyle.YesNo, "Alert") = MsgBoxResult.Yes) Then

                'End If
                MsgBox("El Prodcuto No existe", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Public Function Ingresar_Producto(ByVal NOMBRE_PRODUCTO As String, ByVal DESCRIPCION_PRODUCTO As String, ByVal GRABADO As String, ByVal UPAQUETE As Integer, ByVal Codigo_Barras As String, ByVal ID_LINEA As Integer) As Integer
        Dim Producto As New Producto
        Dim Codigo As String
        Dim Reder As Data.SqlClient.SqlDataReader
        Codigo = NOMBRE_PRODUCTO.Chars(0) & NOMBRE_PRODUCTO.Chars(2) & NOMBRE_PRODUCTO.Chars(4)
        Producto.Ingresar_Producto2(Codigo_Barras, Codigo, NOMBRE_PRODUCTO, DESCRIPCION_PRODUCTO, GRABADO, UPAQUETE, ID_LINEA)
        Reder = Producto.Buscar_CodigoBarras2(Codigo_Barras)
        If (Reder.Read = True) Then
            Return Integer.Parse(Reder.Item(0).ToString)
        End If
    End Function

    Public Sub Ingresar_Producto_Proveedor(ByVal ID_Producto As Integer, ByVal ID_Proveedor As Integer)
        Dim Producto As New Producto
        Producto.Ingresar_Proveedor_Producto(ID_Producto, ID_Proveedor)
    End Sub
    Public Sub Ingresar_Lote(ByVal Cantidad As Integer, ByVal Fecha As Date, ByVal PVP As Decimal, ByVal Descuento As Decimal, ByVal ID_PRODUCTO As Integer, ByVal ID_COMPRA As Integer, ByVal ID_DETALLE_COMPRA As Integer)
        Dim Producto As New Producto
        Producto.Ingresar_Lote(Cantidad, Fecha, PVP, Descuento, ID_PRODUCTO, ID_COMPRA, ID_DETALLE_COMPRA)
    End Sub
    Public Sub Abrir_Venta(ByVal Padre As Windows.Forms.Form)
        Dim Producto As Ingresar_Producto
        Producto = New Ingresar_Producto
        Producto.MdiParent = Padre
        Producto.Show()
    End Sub
    Public Sub Abrir_VentaM(ByVal Padre As Windows.Forms.Form)
        Dim Producto As Modificar_Producto
        Producto = New Modificar_Producto
        Producto.MdiParent = Padre
        Producto.Show()
    End Sub
    Public Sub buscar_producto(ByVal codigo_Barras As String, ByVal mProducto As Modificar_Producto)
        Dim producto As New Producto
        Dim a As Boolean
        a = producto.buscar_producto(codigo_barras, mProducto)
        If (a = True) Then
            producto.Buscar_producto_Proveedor(Str(mProducto.id_Producto), mProducto)
        Else
            MsgBox("El producto no existe", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Public Function modificar_producto(ByVal Id_producto As String, ByVal desc_producto As String, ByVal ge_producto As String, ByVal u_producto As String, ByVal proveedor As Windows.Forms.ListBox, ByVal linea As String, ByVal proveedores() As Integer) As Boolean
        Dim producto As New Producto
        Dim a As Boolean
        a = producto.modificar_producto(Id_producto, desc_producto, ge_producto, u_producto, linea)
        If (a = True) Then
            MsgBox("El producto se ha modificado con exito", MsgBoxStyle.OkOnly, "Informacion")
        Else
            MsgBox("Error, el producto no se ha podido modificar", MsgBoxStyle.OkOnly, "Error")
        End If
    End Function


    Public Function Buscar_Nombre_Producto_Proveedor(ByVal Codigo As String, ByVal Ventana As TLF_Proveedor) As Boolean
        Dim Modelo As Producto = New Producto
        Dim ConsultaBD As Data.SqlClient.SqlDataReader
        Try
            ConsultaBD = Modelo.Buscar_Info_Producto(Codigo)
            Ventana.NombreProducto.Text = ConsultaBD.Item(1).ToString
        Catch ex As Exception
            MsgBox("Error, el código del producto es inválido ", MsgBoxStyle.OkOnly, "Error")
            Ventana.CodigoBarras.Focus()
            Ventana.NombreProducto.Text = ""
        End Try
    End Function


    Public Function AsignarProductoProveedor(ByVal Codigo_Barra As String, ByVal Id_Proveedor As Integer) As Boolean
        Dim Modelo As Producto = New Producto
        Try
            Dim Id_Producto As Integer = 0
            Id_Producto = Modelo.idProductos(Codigo_Barra)
            Return Modelo.Ingresar_Producto_Proveedor(Id_Proveedor, Id_Producto)
        Catch ex As Exception
            MsgBox("Error, el código del producto es inválido ", MsgBoxStyle.OkOnly, "Error")
        End Try
        Return False
    End Function
End Class
