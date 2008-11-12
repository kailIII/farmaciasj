Public Class Producto
    Public Function Buscar_CodigoBarras(ByVal Codigo As String, ByVal Venta As Realizar_Venta) As Data.SqlClient.SqlDataReader
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
        Return Reder.Item(0).ToString
    End Function
End Class
