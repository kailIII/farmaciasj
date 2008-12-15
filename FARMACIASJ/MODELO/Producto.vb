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

    Public Sub Ingresar_Producto(ByVal codigo_barras As String, ByVal codigo As String, ByVal nombre_producto As String, ByVal desc_producto As String, ByVal ge_producto As String, ByVal u_producto As Integer, ByVal proveedor As String, ByVal linea As String)
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
            Consulta.CommandText = "select id_proveedor from proveedor where RIF = '" & proveedor & "'"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigoproveedor = Integer.Parse(mars.Item(0).ToString)
            End If
            mars.Close()
            Consulta.CommandText = "select id_linea from linea where NOMBRE = '" & linea & "'"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigolinea = Integer.Parse(mars.Item(0).ToString)
            End If
            mars.Close()
            Consulta.CommandText = "INSERT INTO PRODUCTO (NOMBRE,CODIGO_DE_BARRAS,CODIGO,DESCRIPCION,GRAVADO_EXENTO,UNIDADES_POR_PAQUETE,ID_LINEA) VALUES ('" & nombre_producto & "','" & codigo_barras & "','" & codigo & "','" & desc_producto & "','" & ge_producto & "','" & u_producto & "','" & codigolinea & "')"
            Consulta.ExecuteNonQuery()
            Consulta.CommandText = "select id_producto from producto where codigo = '" & codigo & "'"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigoproducto = Integer.Parse(mars.Item(0).ToString)
            End If
            mars.Close
            Consulta.CommandText = "insert into proveedor_producto (id_proveedor,id_producto) values (" & codigoproveedor & "," & codigoproducto & ")"
            Consulta.ExecuteNonQuery()
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub
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
    Public Function Buscar_CodigoBarras2(ByVal CODIGO_BARRAS As String) As Data.SqlClient.SqlDataReader
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
        Consulta.CommandText = "SELECT     PRODUCTO.ID_PRODUCTO, PRODUCTO.CODIGO, PRODUCTO.NOMBRE, PRODUCTO.DESCRIPCION, PRODUCTO.GRAVADO_EXENTO, PRODUCTO.UNIDADES_POR_PAQUETE, LINEA.ID_LINEA, LINEA.NOMBRE AS LINEA, LINEA.DESCRIPCION AS LDESCRIPCION, LINEA.DESCUENTO_MAXIMO, LINEA.MARGEN_UTIL FROM         PRODUCTO INNER JOIN LINEA ON PRODUCTO.ID_LINEA = LINEA.ID_LINEA WHERE     (PRODUCTO.CODIGO_DE_BARRAS = '" & CODIGO_BARRAS & "')"
        Reder = Consulta.ExecuteReader()
        Return Reder
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
End Class
