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

    Public Function Buscar_id_Proveedor_Factura(ByVal Control_Numero As String) As Integer
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     PROVEEDOR.ID_PROVEEDOR FROM         COMPRA INNER JOIN PROVEEDOR ON COMPRA.ID_PROVEEDOR = PROVEEDOR.ID_PROVEEDOR WHERE     (COMPRA.NUMERO_FACTURA_COMPRA = '" & Control_Numero & "')"
        Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
        Dim Id_Proveedor As Integer = 0
        If (Reder.Read) Then
            Id_Proveedor = CInt(Reder.Item(0).ToString)
        End If
        Reder.Close()
        Return Id_Proveedor
    End Function

    Public Function Buscar_Id_Compra_Factura(ByVal Control_Numero As String) As Integer
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     ID_COMPRA FROM         COMPRA WHERE     (NUMERO_FACTURA_COMPRA = '" & Control_Numero & "')"
        Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
        Dim Id_Compra As Integer = 0
        If (Reder.Read) Then
            Id_Compra = CInt(Reder.Item(0).ToString)
        End If
        Reder.Close()
        Return Id_Compra
    End Function


    Public Sub Buscar_Info_Proveedor(ByVal Id_Proveedor As Integer, ByVal Compra As Modificar_compra)

        Dim Cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Cliente = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            Conextion = Cliente.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     RIF, Nombre FROM         PROVEEDOR WHERE     ID_PROVEEDOR = " & Id_Proveedor
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Compra.NOMBRE_PROVEEDOR.Text = Reder.Item(1).ToString()
                Compra.RIF_PROVEEDOR.Text = Reder.Item(0).ToString()
                Reder.Close()
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub

    Public Function Buscar_Info_Detalle(ByVal NDetalle As String, ByVal ID_Factura As Integer, ByVal Compra As Modificar_compra) As Boolean
        Dim Cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Cliente = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            Conextion = Cliente.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     PRODUCTO.NOMBRE, PRODUCTO.CODIGO_DE_BARRAS, DETALLE_COMPRA.CANTIDAD, DETALLE_COMPRA.COSTO_TOTAL,  DETALLE_COMPRA.COSTO_UNIDAD, LOTE.FECHA_VENCIMIENTO, LOTE.PVP, LOTE.DESCUENTO, LOTE.ID_PRODUCTO, LOTE.ID_LOTE,  LINEA.DESCUENTO_MAXIMO, LINEA.MARGEN_UTIL FROM         LINEA INNER JOIN PRODUCTO ON LINEA.ID_LINEA = PRODUCTO.ID_LINEA INNER JOIN DETALLE_COMPRA ON PRODUCTO.ID_PRODUCTO = DETALLE_COMPRA.ID_PRODUCTO INNER JOIN LOTE ON PRODUCTO.ID_PRODUCTO = LOTE.ID_PRODUCTO AND DETALLE_COMPRA.ID_DETALLE_COMPRA = LOTE.ID_DETALLE_COMPRA AND  DETALLE_COMPRA.ID_COMPRA = LOTE.ID_COMPRA WHERE     (DETALLE_COMPRA.ID_DETALLE_COMPRA = " & NDetalle & ") AND (DETALLE_COMPRA.ID_COMPRA = " & ID_Factura & ")"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Compra.CODIGO_BARRAS.Text = Reder.Item(0).ToString()
                Compra.NOMBRE_PRODUCTO.Text = Reder.Item(1).ToString
                Compra.Cantidad.Text = Reder.Item(2).ToString
                Compra.CTotal.Text = Reder.Item(3).ToString
                Compra.CUnidad.Text = Reder.Item(4).ToString
                Compra.FVENCE.Text = Reder.Item(5).ToString
                Compra.PVP.Text = Reder.Item(6).ToString
                Compra.DESCUENTO.Text = Reder.Item(7).ToString
                Compra.ID_Producto = Integer.Parse(Reder.Item(8).ToString)
                Compra.ID_Lote = Integer.Parse(Reder.Item(9).ToString)
                Compra.MUtil = Double.Parse(Reder.Item(10).ToString)
                Compra.DescMax = Double.Parse(Reder.Item(11).ToString)
                Compra.CRestar.Enabled = True
                Compra.Cantidad.Enabled = False
                Compra.Button1.Enabled = True
                Reder.Close()
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Function
    Public Function Modificar_Compra(ByVal CRestar As Integer, ByVal CTotal As Double, ByVal NDETALLE As Integer, ByVal Id_Compra As Integer) As Boolean
        Try
            Dim Compra As FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection
            Dim Consulta As Data.SqlClient.SqlCommand
            Dim Reder As Data.SqlClient.SqlDataReader
            Dim Cantidad As Integer
            Dim Monto As Double
            Compra = New FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
            Conextion = Compra.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     CANTIDAD, COSTO_TOTAL FROM         DETALLE_COMPRA WHERE     (ID_DETALLE_COMPRA = " & NDETALLE & ") AND (ID_COMPRA = " & Id_Compra & ") "
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Cantidad = Integer.Parse(Reder.Item(0).ToString)
            End If
            Reder.Close()
            Cantidad = Cantidad - CRestar
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[DETALLE_COMPRA] SET [CANTIDAD] = " & Cantidad & " ,[COSTO_TOTAL] = " & CTotal & " WHERE ID_COMPRA=" & Id_Compra & " and ID_DETALLE_COMPRA= " & NDETALLE
            Consulta.ExecuteNonQuery()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     MONTO FROM         COMPRA WHERE     (ID_COMPRA = " & Id_Compra & ")"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Monto = Double.Parse(Reder.Item(0).ToString)
            End If
            Monto = Math.Round(Monto - CTotal)
            Reder.Close()
            Cantidad = Cantidad - CRestar
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[COMPRA] SET [MONTO] = " & Monto & " WHERE ID_COMPRA=" & Id_Compra
            Consulta.ExecuteNonQuery()
            Return True
        Catch ex As Data.SqlClient.SqlException
            Return False
        End Try
    End Function
    Public Function Modificar_Lote(ByVal CRestar As Integer, ByVal ID_Lote As Integer, ByVal Id_Producto As Integer) As Boolean
        Try
            Dim Compra As FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection
            Dim Consulta As Data.SqlClient.SqlCommand
            Dim Reder As Data.SqlClient.SqlDataReader
            Dim Cantidad As Integer
            Compra = New FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
            Conextion = Compra.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     CANTIDAD FROM         LOTE WHERE     (ID_LOTE = " & ID_Lote & ") AND (ID_PRODUCTO = " & Id_Producto & ")"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Cantidad = Integer.Parse(Reder.Item(0).ToString)
            End If
            Reder.Close()
            Cantidad = Cantidad - CRestar
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[LOTE] SET [CANTIDAD] = " & Cantidad & " WHERE ID_PRODUCTO=" & Id_Producto & " and ID_LOTE=" & ID_Lote
            Consulta.ExecuteNonQuery()
            Return True
        Catch ex As Data.SqlClient.SqlException
            Return False
        End Try
    End Function
    Public Function Modificar_Proveedor(ByVal CTotal As Double, ByVal Id_Proveedor As Integer) As Boolean
        Try
            Dim Compra As FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection
            Dim Consulta As Data.SqlClient.SqlCommand
            Dim Reder As Data.SqlClient.SqlDataReader
            Dim Saldo As Double
            Compra = New FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
            Conextion = Compra.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     Saldo FROM         PROVEEDOR WHERE     (ID_PROVEEDOR = " & Id_Proveedor & ") "
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Saldo = Double.Parse(Reder.Item(0).ToString)
            End If
            Reder.Close()
            Saldo = Saldo - CTotal
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[PROVEEDOR] SET	[Saldo] = " & Saldo & " WHERE ID_PROVEEDOR=" & Id_Proveedor
            Consulta.ExecuteNonQuery()
            Return True
        Catch ex As Data.SqlClient.SqlException
            Return False
        End Try
    End Function
End Class
