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
                Compra.CODIGO.Text = Reder.Item(1).ToString
                Compra.NOMBRE_PRODUCTO.Text = Reder.Item(2).ToString
                Compra.DESCRIPCION_PRODUCTO.Text = Reder.Item(3).ToString
                If (Reder.Item(4).ToString = "GRAVADO") Then
                    Compra.GRABADO.SelectedIndex = 0
                Else
                    Compra.GRABADO.SelectedIndex = 1
                End If
                Compra.UPAQUETE.Text = Reder.Item(5).ToString
                Compra.ID_Linea = Integer.Parse(Reder.Item(6).ToString)
                Compra.NOMBRE_LINEA.Text = Reder.Item(7).ToString
                Compra.DESCRIPCION_LINEA.Text = Reder.Item(8).ToString
                Compra.DMaximo.Text = Reder.Item(9).ToString
                Compra.MUtil.Text = Reder.Item(10).ToString
            End If
        Else
            Reder = Producto.Buscar_CodigoBarras2(CODIGO_BARRAS)
            If (Reder.HasRows = True) Then
                If (Reder.Read = True) Then
                    If (MsgBox("El Producto: " & Reder.Item(1).ToString & " No esta asociado al Proveedor, �Desea Asociarlo?", MsgBoxStyle.YesNo, "Alert") = MsgBoxResult.Yes) Then
                        Compra.ID_Producto = Integer.Parse(Reder.Item(0).ToString)
                        Producto.Ingresar_Proveedor_Producto(Compra.ID_Producto, ID_Proveedor)
                        Compra.CODIGO.Text = Reder.Item(1).ToString
                        Compra.NOMBRE_PRODUCTO.Text = Reder.Item(2).ToString
                        Compra.DESCRIPCION_PRODUCTO.Text = Reder.Item(3).ToString
                        If (Reder.Item(4).ToString = "GRAVADO") Then
                            Compra.GRABADO.SelectedIndex = 0
                        Else
                            Compra.GRABADO.SelectedIndex = 1
                        End If
                        Compra.UPAQUETE.Text = Reder.Item(5).ToString
                        Compra.ID_Linea = Integer.Parse(Reder.Item(6).ToString)
                        Compra.NOMBRE_LINEA.Text = Reder.Item(7).ToString
                        Compra.DESCRIPCION_LINEA.Text = Reder.Item(8).ToString
                        Compra.DMaximo.Text = Reder.Item(9).ToString
                        Compra.MUtil.Text = Reder.Item(10).ToString
                    End If

                End If
            Else
                If (MsgBox("El Prodcuto No existe, �Desea Agregarlo?", MsgBoxStyle.YesNo, "Alert") = MsgBoxResult.Yes) Then
                    Compra.ID_Producto = -1
                    Compra.CODIGO.Enabled = True
                    Compra.NOMBRE_PRODUCTO.Enabled = True
                    Compra.DESCRIPCION_PRODUCTO.Enabled = True
                    Compra.GRABADO.Enabled = True
                    Compra.UPAQUETE.Enabled = True
                    Compra.NOMBRE_LINEA.Enabled = True
                End If
            End If
        End If
    End Sub
    Public Sub Buscar_CBarras(ByVal CODIGO_BARRAS As String, ByVal ID_Proveedor As Integer, ByVal Compra As Registrar_Compra)
        Dim Producto As Producto
        Dim Reder As Data.SqlClient.SqlDataReader
        Producto = New Producto
        Reder = Producto.Buscar_CodigoBarras2(CODIGO_BARRAS)
        If (Reder.HasRows = True) Then
            If (Reder.Read = True) Then
                Compra.ID_Producto = Integer.Parse(Reder.Item(0).ToString)
                Compra.ID_Producto = Integer.Parse(Reder.Item(0).ToString)
                Producto.Ingresar_Proveedor_Producto(Compra.ID_Producto, ID_Proveedor)
                Compra.CODIGO.Text = Reder.Item(1).ToString
                Compra.NOMBRE_PRODUCTO.Text = Reder.Item(2).ToString
                Compra.DESCRIPCION_PRODUCTO.Text = Reder.Item(3).ToString
                If (Reder.Item(4).ToString = "GRAVADO") Then
                    Compra.GRABADO.SelectedIndex = 0
                Else
                    Compra.GRABADO.SelectedIndex = 1
                End If
                Compra.UPAQUETE.Text = Reder.Item(5).ToString
                Compra.ID_Linea = Integer.Parse(Reder.Item(6).ToString)
                Compra.NOMBRE_LINEA.Text = Reder.Item(7).ToString
                Compra.DESCRIPCION_LINEA.Text = Reder.Item(8).ToString
                Compra.DMaximo.Text = Reder.Item(9).ToString
                Compra.MUtil.Text = Reder.Item(10).ToString
            End If
        Else
            If (MsgBox("El Prodcuto No existe, �Desea Agregarlo?", MsgBoxStyle.YesNo, "Alert") = MsgBoxResult.Yes) Then
                Compra.ID_Producto = -1
                Compra.CODIGO.Enabled = True
                Compra.NOMBRE_PRODUCTO.Enabled = True
                Compra.DESCRIPCION_PRODUCTO.Enabled = True
                Compra.GRABADO.Enabled = True
                Compra.UPAQUETE.Enabled = True
                Compra.NOMBRE_LINEA.Enabled = True
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
    Public Sub Ingresar_Lote(ByVal Cantidad As Integer, ByVal Fecha As Date, ByVal PVP As Double, ByVal Descuento As Double, ByVal ID_PRODUCTO As Integer)
        Dim Producto As New Producto
        Producto.Ingresar_Lote(Cantidad, Fecha, PVP, Descuento, ID_PRODUCTO)
    End Sub
    Public Sub Abrir_Venta(ByVal Padre As Windows.Forms.Form)
        Dim Producto As Ingresar_Producto
        Producto = New Ingresar_Producto
        Producto.MdiParent = Padre
        Producto.Show()
    End Sub
End Class
