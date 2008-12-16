Public Class Producto

    Public Function idProductos(ByVal Codigo As String) As Integer
        Try
            Dim Producto_x As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection = Producto_x.Connection
            Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT ID_PRODUCTO FROM PRODUCTO where CODIGO_DE_BARRAS='" & Codigo & "'"
            Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Return CInt(Reder.Item(0).ToString())
            Else
                Return 0
            End If
        Catch e As Data.SqlClient.SqlException
            Return 0
        End Try
    End Function

    Public Function Buscar_CodigoBarras(ByVal Codigo As String) As Data.SqlClient.SqlDataReader
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Conextion = Producto.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     PRODUCTO.ID_PRODUCTO, LOTE.ID_LOTE, PRODUCTO.NOMBRE, PRODUCTO.DESCRIPCION, PRODUCTO.CODIGO, LOTE.FECHA_VENCIMIENTO, LOTE.PVP, LOTE.DESCUENTO FROM         LOTE INNER JOIN PRODUCTO ON LOTE.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO WHERE     (LOTE.FECHA_VENCIMIENTO > GETDATE()) AND (LOTE.CANTIDAD > 0) AND (PRODUCTO.CODIGO_DE_BARRAS = '" & Codigo & "')"
        Reder = Consulta.ExecuteReader()
        Return Reder
    End Function

    Public Function Cantidad_Filas(ByVal Codigo As String) As Integer
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader


        Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Conextion = Producto.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "select count(*) from (SELECT     PRODUCTO.ID_PRODUCTO, LOTE.ID_LOTE, PRODUCTO.NOMBRE, PRODUCTO.DESCRIPCION, PRODUCTO.CODIGO, LOTE.FECHA_VENCIMIENTO, LOTE.PVP, LOTE.DESCUENTO FROM         LOTE INNER JOIN PRODUCTO ON LOTE.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO WHERE     (LOTE.FECHA_VENCIMIENTO > GETDATE()) AND (LOTE.CANTIDAD > 0) AND (PRODUCTO.CODIGO_DE_BARRAS = '" & Codigo & "'))Tabla"
        Reder = Consulta.ExecuteReader()
        Reder.Read()
        Return CInt(Reder.Item(0).ToString)
    End Function

    Public Function Impuestos(ByVal Codigo As String) As Data.SqlClient.SqlDataReader
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Conextion = Producto.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     HISTORICO_IMPUESTO.ID_HISTORICO_IMPUESTO, HISTORICO_IMPUESTO.ID_IMPUESTO, HISTORICO_IMPUESTO.VALOR FROM         Linea_Impuesto INNER JOIN LINEA ON Linea_Impuesto.ID_LINEA = LINEA.ID_LINEA INNER JOIN IMPUESTO ON Linea_Impuesto.ID_IMPUESTO = IMPUESTO.ID_IMPUESTO INNER JOIN HISTORICO_IMPUESTO ON IMPUESTO.ID_IMPUESTO = HISTORICO_IMPUESTO.ID_IMPUESTO INNER JOIN PRODUCTO ON LINEA.ID_LINEA = PRODUCTO.ID_LINEA WHERE     (PRODUCTO.CODIGO_DE_BARRAS = '" & Codigo & "') AND (HISTORICO_IMPUESTO.FECHA_FIN IS NULL) AND (PRODUCTO.GRAVADO_EXENTO = 'GRAVADO')"
        Reder = Consulta.ExecuteReader()
        Return Reder
    End Function

    Public Function Cantidad_Impuestos(ByVal Codigo As String) As Integer
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader


        Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Conextion = Producto.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "select count(*) from (SELECT     HISTORICO_IMPUESTO.ID_HISTORICO_IMPUESTO, HISTORICO_IMPUESTO.ID_IMPUESTO, HISTORICO_IMPUESTO.VALOR FROM         Linea_Impuesto INNER JOIN LINEA ON Linea_Impuesto.ID_LINEA = LINEA.ID_LINEA INNER JOIN IMPUESTO ON Linea_Impuesto.ID_IMPUESTO = IMPUESTO.ID_IMPUESTO INNER JOIN HISTORICO_IMPUESTO ON IMPUESTO.ID_IMPUESTO = HISTORICO_IMPUESTO.ID_IMPUESTO INNER JOIN PRODUCTO ON LINEA.ID_LINEA = PRODUCTO.ID_LINEA WHERE     (PRODUCTO.CODIGO_DE_BARRAS = '" & Codigo & "') AND (HISTORICO_IMPUESTO.FECHA_FIN IS NULL) AND (PRODUCTO.GRAVADO_EXENTO = 'GRAVADO'))LHI"
        Reder = Consulta.ExecuteReader()
        Reder.Read()
        Return CInt(Reder.Item(0).ToString)
    End Function
    Public Function BuscarCodigoBarras(ByVal Codigo As String) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT CODIGO_DE_BARRAS FROM PRODUCTO WHERE ('" & Codigo & "' = CODIGO_DE_BARRAS)"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                If (Reder.HasRows = True) Then
                    Return True
                Else
                    Return (False)
                End If
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Function
    Public Function BuscarNombreProducto(ByVal nombre As String) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT NOMBRE FROM PRODUCTO WHERE ('" & nombre & "' = NOMBRE)"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                If (Reder.HasRows = True) Then
                    Return True
                Else
                    Return (False)
                End If
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Function
    Public Function BuscarCodigoProducto(ByVal codigo As String) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT Codigo FROM PRODUCTO WHERE ('" & codigo & "' = codigo)"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                If (Reder.HasRows = True) Then
                    Return True
                Else
                    Return (False)
                End If
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Function

    Public Function Ingresar_Producto(ByVal codigo_barras As String, ByVal codigo As String, ByVal nombre_producto As String, ByVal desc_producto As String, ByVal ge_producto As String, ByVal u_producto As Integer, ByVal linea As String) As Integer
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim mars As Data.SqlClient.SqlDataReader
        Dim codigoproducto, codigoproveedor, codigolinea As Integer
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "select id_linea from linea where NOMBRE = '" & linea & "'"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigolinea = Integer.Parse(mars.Item(0).ToString)
            End If
            mars.Close()
            Consulta.CommandText = "INSERT INTO PRODUCTO (NOMBRE,CODIGO_DE_BARRAS,CODIGO,DESCRIPCION,GRAVADO_EXENTO,UNIDADES_POR_PAQUETE,ID_LINEA) VALUES ('" & nombre_producto & "','" & codigo_barras & "','" & codigo & "','" & desc_producto & "','" & ge_producto & "','" & u_producto & "','" & codigolinea & "')"
            Consulta.ExecuteNonQuery()
            Consulta.CommandText = "select id_producto from producto where CODIGO_DE_BARRAS = '" & codigo_barras & "'"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigoproducto = Integer.Parse(mars.Item(0).ToString)
            End If
            mars.Close()
            Return codigoproducto
        Catch e As Data.SqlClient.SqlException
            Return 0
        End Try
    End Function
    Public Function Buscar_CodigoBarras_IDPROVEEDOR(ByVal CODIGO_BARRAS As String, ByVal ID_Proveedor As Integer) As Data.SqlClient.SqlDataReader
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Conextion = Producto.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     PRODUCTO.ID_PRODUCTO, PRODUCTO.CODIGO, PRODUCTO.NOMBRE, PRODUCTO.DESCRIPCION, PRODUCTO.GRAVADO_EXENTO, PRODUCTO.UNIDADES_POR_PAQUETE, LINEA.ID_LINEA, LINEA.NOMBRE AS LINEA, LINEA.DESCRIPCION AS LDESCRIPCION, LINEA.DESCUENTO_MAXIMO, LINEA.MARGEN_UTIL FROM         PRODUCTO INNER JOIN LINEA ON PRODUCTO.ID_LINEA = LINEA.ID_LINEA INNER JOIN PROVEEDOR_PRODUCTO ON PRODUCTO.ID_PRODUCTO = PROVEEDOR_PRODUCTO.ID_PRODUCTO WHERE     (PROVEEDOR_PRODUCTO.ID_PROVEEDOR = " & ID_Proveedor & ") AND (PRODUCTO.CODIGO_DE_BARRAS = '" & CODIGO_BARRAS & "')"
        Reder = Consulta.ExecuteReader()
        Return Reder
    End Function

    Public Function Buscar_producto(ByVal CODIGO_BARRAS As String, ByVal mproducto As Modificar_Producto) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim i As Integer
        Dim j As Integer
        Dim index As Integer
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     PRODUCTO.ID_PRODUCTO, PRODUCTO.NOMBRE, PRODUCTO.CODIGO, PRODUCTO.DESCRIPCION, PRODUCTO.GRAVADO_EXENTO,  PRODUCTO.UNIDADES_POR_PAQUETE, LINEA.NOMBRE AS Expr1 FROM         PRODUCTO INNER JOIN LINEA ON PRODUCTO.ID_LINEA = LINEA.ID_LINEA WHERE     (PRODUCTO.CODIGO_DE_BARRAS = '" & CODIGO_BARRAS & "') "
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                mproducto.Id_producto = Integer.Parse(Reder.Item(0).ToString)
                mproducto.Cod_Producto.Text = Reder.Item(2).ToString
                mproducto.Nom_Producto.Text = Reder.Item(1).ToString
                mproducto.Desc_Producto.Text = Reder.Item(3).ToString
                If (Reder.Item(4).ToString = "GRAVADO") Then
                    mproducto.GE_Producto.SelectedIndex = 1
                Else
                    mproducto.GE_Producto.SelectedIndex = 0
                End If
                mproducto.Unidades_Producto.Text = Reder.Item(5).ToString
                Dim A As String
                A = Reder.Item(0).ToString
                J = 0
                While (j < mproducto.Lineas.Items.Count)
                    Dim b As String
                    b = mproducto.Lineas.GetItemText(mproducto.Lineas.Items(j))
                    If (b = A) Then
                        index = j
                        j = mproducto.Proveedores.Items.Count - 1
                    End If
                    j = j + 1
                End While
                mproducto.Lineas.SelectedIndex = index
                mproducto.Desc_Producto.Enabled = True
                mproducto.GE_Producto.Enabled = True
                mproducto.Lineas.Enabled = True
                mproducto.Proveedores.Enabled = True
                mproducto.Ingresar.Enabled = True
                Return True
            End If
            Return False
        Catch e As Data.SqlClient.SqlException
            Return False
        End Try
    End Function
    Public Function Buscar_CodigoBarras2(ByVal CODIGO_BARRAS As String) As Data.SqlClient.SqlDataReader
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     PRODUCTO.ID_PRODUCTO, PRODUCTO.CODIGO, PRODUCTO.NOMBRE, PRODUCTO.DESCRIPCION, PRODUCTO.GRAVADO_EXENTO, PRODUCTO.UNIDADES_POR_PAQUETE, LINEA.ID_LINEA, LINEA.NOMBRE AS LINEA, LINEA.DESCRIPCION AS LDESCRIPCION, LINEA.DESCUENTO_MAXIMO, LINEA.MARGEN_UTIL FROM         PRODUCTO INNER JOIN LINEA ON PRODUCTO.ID_LINEA = LINEA.ID_LINEA WHERE     (PRODUCTO.CODIGO_DE_BARRAS = '" & CODIGO_BARRAS & "')"
            Reder = Consulta.ExecuteReader()
            Return Reder
        Catch e As Data.SqlClient.SqlException
            Return Reder
        End Try
    End Function
    Public Sub Ingresar_Proveedor_Producto(ByVal ID_PRODUCTO As Integer, ByVal ID_Proveedor As Integer)
        Dim BasedeDatos As New FarmaciaSJDataSet
        Dim ProductoProveedorTableAdapter As New FarmaciaSJDataSetTableAdapters.PROVEEDOR_PRODUCTOTableAdapter
        ProductoProveedorTableAdapter.Insert(ID_Proveedor, ID_PRODUCTO)
        ProductoProveedorTableAdapter.Update(BasedeDatos.PROVEEDOR_PRODUCTO)
        BasedeDatos.AcceptChanges()
    End Sub
    Public Sub Ingresar_Producto2(ByVal Codigo_Barras As String, ByVal Codigo As String, ByVal NOMBRE_PRODUCTO As String, ByVal DESCRIPCION_PRODUCTO As String, ByVal GRABADO As String, ByVal UPAQUETE As Integer, ByVal ID_LINEA As Integer)
        Dim BasedeDatos As New FarmaciaSJDataSet
        Dim ProductoTableAdapter As New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        ProductoTableAdapter.Insert(NOMBRE_PRODUCTO, Codigo_Barras, Codigo, DESCRIPCION_PRODUCTO, GRABADO, UPAQUETE, ID_LINEA)
        ProductoTableAdapter.Update(BasedeDatos.PRODUCTO)
        BasedeDatos.AcceptChanges()
    End Sub
    Public Sub Ingresar_Lote(ByVal Cantidad As Integer, ByVal Fecha As Date, ByVal PVP As Decimal, ByVal Descuento As Decimal, ByVal ID_PRODUCTO As Integer, ByVal ID_COMPRA As Integer, ByVal ID_DETALLE_COMPRA As Integer)
        Dim BasedeDatos As New FarmaciaSJDataSet
        Dim LOTETableAdapter As New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        LOTETableAdapter.Insert(Cantidad, Fecha, PVP, Descuento, ID_PRODUCTO, ID_DETALLE_COMPRA, ID_COMPRA)
        LOTETableAdapter.Update(BasedeDatos.LOTE)
        BasedeDatos.AcceptChanges()
    End Sub
    Public Function total_productos() As Integer
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "select count(*) from producto"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Return Integer.Parse(Reder.Item(0).ToString)
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Function

    Public Function Buscar_producto_Proveedor(ByVal ID_PRoducto As String, ByVal mProducto As Modificar_Producto) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Lote As FarmaciaSJDataSetTableAdapters.LOTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim i As Integer = 0
        Dim J As Integer = 0
        Dim INDEX As Integer = 0
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Lote = New FarmaciaSJDataSetTableAdapters.LOTETableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     PROVEEDOR.Nombre FROM         PROVEEDOR_PRODUCTO INNER JOIN PROVEEDOR ON PROVEEDOR_PRODUCTO.ID_PROVEEDOR = PROVEEDOR.ID_PROVEEDOR WHERE     (PROVEEDOR_PRODUCTO.ID_PRODUCTO = " & ID_PRoducto & ")"
            Reder = Consulta.ExecuteReader()
            While (Reder.Read = True)
                Dim A As String
                A = Reder.Item(0).ToString
                J = 0
                While (J < mProducto.Proveedores.Items.Count)
                    Dim b As String
                    b = mProducto.Proveedores.GetItemText(mProducto.Proveedores.Items(J))
                    If (b = A) Then
                        INDEX = J
                        J = mProducto.Proveedores.Items.Count - 1
                    End If
                    J = J + 1
                End While
                mProducto.Proveedores.SetSelected(INDEX, True)
                mProducto.proveedoresSelected(i) = mProducto.Proveedores.Items.IndexOf(Reder.Item(0).ToString)
                i = i + 1
                Return True
            End While
            Return False
        Catch e As Data.SqlClient.SqlException
            Return False
        End Try
    End Function
    Public Function modificar_producto(ByVal id_producto As String, ByVal descripcion As String, ByVal gravado As String, ByVal upaquete As String, ByVal Linea As String) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim mars As Data.SqlClient.SqlDataReader
        Dim codigolinea As String
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "select id_linea from linea where NOMBRE = '" & Linea & "'"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigolinea = mars.Item(0).ToString
            End If
            mars.Close()
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[PRODUCTO] SET [DESCRIPCION] = '" & descripcion & "' ,[GRAVADO_EXENTO] = '" & gravado & "' ,[UNIDADES_POR_PAQUETE] = " & upaquete & " ,[ID_LINEA] = " & codigolinea & " WHERE ID_PRODUCTO=" & id_producto
            Consulta.ExecuteNonQuery()
            Return True
        Catch e As Data.SqlClient.SqlException
            Return False
        End Try
    End Function
End Class
