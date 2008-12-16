Public Class Compra

    Public Sub Ingresar_Compra(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal ID_proveedor As Integer)
        Dim BasedeDatos As New FarmaciaSJDataSet
        Dim CompraTableAdapter As New FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
        CompraTableAdapter.Insert(Fecha, Vence, 0, 0, 0, Numero, ID_proveedor)
        CompraTableAdapter.Update(BasedeDatos.COMPRA)
        BasedeDatos.AcceptChanges()
    End Sub

    Public Function buscar_Compra(ByVal Numero As String) As Data.SqlClient.SqlDataReader
        Dim Compra As FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Compra = New FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
        Conextion = Compra.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     ID_COMPRA, FECHA_COMPRA, VENCE, IMPUESTO, MONTO, DESCUENTO_GLOBAL, NUMERO_FACTURA_COMPRA, ID_PROVEEDOR FROM         COMPRA WHERE     (NUMERO_FACTURA_COMPRA = '" & Numero & "')"
        Reder = Consulta.ExecuteReader()
        Return Reder
    End Function

    Public Sub Ingresar_Detalle(ByVal ID_DETALLE As Integer, ByVal ID_COMPRA As Integer, ByVal Cantidad As Integer, ByVal Costo As Double, ByVal ID_PRODUCTO As Integer, ByVal COSTOUNIDAD As Double)
        Dim BasedeDatos As New FarmaciaSJDataSet
        Dim DetalleTableAdapter As New FarmaciaSJDataSetTableAdapters.DETALLE_COMPRATableAdapter
        DetalleTableAdapter.Insert(ID_DETALLE, ID_COMPRA, Cantidad, CDec(Costo), ID_PRODUCTO, CDec(COSTOUNIDAD))
        DetalleTableAdapter.Update(BasedeDatos.DETALLE_COMPRA)
        BasedeDatos.AcceptChanges()
    End Sub
    Public Function Traer_Detalle(ByVal ID_compra As Integer) As Data.DataTable
        Dim Bd As FarmaciaSJDataSet
        Bd = New FarmaciaSJDataSet
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_COMPRATableAdapter = New FarmaciaSJDataSetTableAdapters.DETALLE_COMPRATableAdapter
        Dim cn As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection(Detalle.Connection.ConnectionString)
        Dim sql As String = "SELECT     DETALLE_COMPRA.ID_DETALLE_COMPRA AS NUMERO, PRODUCTO.CODIGO_DE_BARRAS AS CODIGO, PRODUCTO.NOMBRE AS DESCRIPCION, DETALLE_COMPRA.COSTO_UNIDAD AS COSTO, DETALLE_COMPRA.CANTIDAD, DETALLE_COMPRA.COSTO_TOTAL AS SUBTOTAL FROM         DETALLE_COMPRA INNER JOIN PRODUCTO ON DETALLE_COMPRA.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO WHERE     DETALLE_COMPRA.ID_COMPRA =" & ID_compra
        Dim da As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sql, cn)
        Dim Table As Data.DataTable = New Data.DataTable("Detalle_Factura")
        da.Fill(Table)
        Return Table
    End Function
    Public Sub ProcesarC(ByVal Subtotal As String, ByVal IMPUESTO As String, ByVal DESCUENTO As String, ByVal Total As String, ByVal ID_FACTURA As Integer)
        Dim Compra As FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Stotal1(2) As String
        Dim Stotal As String
        Dim Impuesto1(2) As String
        Dim Impuestos As String
        Dim Descuento1(2) As String
        Dim Desc As String
        Dim Total1(2) As String
        Dim Ttl As String
        Try
            Compra = New FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
            Conextion = Compra.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Stotal1 = Subtotal.Split(Char.Parse(","))
            Stotal = Stotal1(0) & "." & Stotal1(1)
            Impuesto1 = IMPUESTO.Split(Char.Parse(","))
            Impuestos = Impuesto1(0) & "." & Impuesto1(1)
            Total1 = Total.Split(Char.Parse(","))
            Ttl = Total1(0) & "." & Total1(1)
            Descuento1 = CStr(DESCUENTO).Split(Char.Parse(","))
            Desc = Descuento1(0) & "." & Descuento1(1)
            Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[COMPRA] SET [IMPUESTO] = " & Impuestos & " ,[MONTO] =" & Ttl & " ,[DESCUENTO_GLOBAL] = " & Desc & " WHERE ID_COMPRA=" & ID_FACTURA
            Consulta.ExecuteNonQuery()
        Catch e As Data.SqlClient.SqlException
            MsgBox(e.Message, MsgBoxStyle.OkOnly, "Alert")
        End Try
    End Sub
    Public Function general(ByVal cadena As String) As Data.SqlClient.SqlDataReader
        Dim Compra As FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Compra = New FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
        Conextion = Compra.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = cadena
        Reder = Consulta.ExecuteReader()
        Return Reder
    End Function
End Class
