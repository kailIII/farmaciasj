Public Class Venta
    Public BasedeDatos As FarmaciaSJDataSet
    Public Function Ingresar_Venta(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal Id_Cliente As String) As Integer
        Dim VentaTablaAdapter As FarmaciaSJDataSetTableAdapters.VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim ID As Integer
        Dim Conextion As Data.SqlClient.SqlConnection = VentaTablaAdapter.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT     ID_VENTA FROM         VENTA WHERE     (NUMERO_FACTURA = '" & Numero & "')", Conextion)
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            BasedeDatos = New FarmaciaSJDataSet
            'VentaTablaAdapter()
            VentaTablaAdapter.Insert(Numero, Fecha, Vence, 0, "", "", Id_Cliente, 0, 0, 0, 0, 0, Vence)
            ' Commit
            VentaTablaAdapter.Update(BasedeDatos.VENTA)
            Conextion.Open()
            Reder = Consulta.ExecuteReader
            If (Reder.Read = True) Then
                ID = Reder.Item(0).ToString
            End If
            Return ID
        Catch err As ArgumentNullException
            Return -1
        End Try
    End Function
    Public Function Ingresar_Detalle(ByVal ID_Detalle As String, ByVal ID_Venta As String, ByVal ID_Producto As String, ByVal ID_LOTE As String, ByVal ID_Impuesto() As String, ByVal ID_Historico_Impuesto() As String, ByVal Cantidad As String, ByVal N As Integer) As Integer
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim Impuesto As FarmaciaSJDataSetTableAdapters.IMPUESTO_DETALLE_VENTATableAdapter
        Dim I As Integer
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Detalle = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
            Impuesto = New FarmaciaSJDataSetTableAdapters.IMPUESTO_DETALLE_VENTATableAdapter
            Detalle.Insert(ID_Detalle, ID_Venta, Cantidad, ID_LOTE, ID_Producto)
            If (N > 0) Then
                I = 0
                Do While (I < N)
                    Impuesto.Insert(ID_Historico_Impuesto(I), ID_Impuesto(I), ID_Venta, ID_Detalle)
                Loop
            End If
        Catch ex As Exception

        End Try

    End Function

    Public Function Traer_Detalle(ByVal ID_Venta As String) As Data.DataTable
        Dim Bd As FarmaciaSJDataSet
        Bd = New FarmaciaSJDataSet
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim cn As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection(Detalle.Connection.ConnectionString)
        Dim sql As String = "SELECT     DETALLE_VENTA.ID_DETALLE_VENTA AS NUMERO, PRODUCTO.CODIGO, PRODUCTO.NOMBRE, LOTE.PVP, (LOTE.DESCUENTO / 100) * (LOTE.PVP * DETALLE_VENTA.Cantidad) AS DESCUENTO, DETALLE_VENTA.Cantidad, (LOTE.PVP * DETALLE_VENTA.Cantidad) * (1 - LOTE.DESCUENTO / 100) AS SUB_TOTAL FROM         DETALLE_VENTA INNER JOIN LOTE ON DETALLE_VENTA.ID_LOTE = LOTE.ID_LOTE AND DETALLE_VENTA.ID_PRODUCTO = LOTE.ID_PRODUCTO INNER JOIN PRODUCTO ON LOTE.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO WHERE DETALLE_VENTA.ID_VENTA =" & ID_Venta
        Dim da As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sql, cn)
        Dim Table As Data.DataTable = New Data.DataTable("Detalle_Factura")
        da.Fill(Table)
        Return Table
    End Function

    Public Sub Borrar_Factura(ByVal Id_Factura As String)
        Dim VentaTablaAdapter As FarmaciaSJDataSetTableAdapters.VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = VentaTablaAdapter.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE FROM [FarmaciaSJ].[dbo].[IMPUESTO_DETALLE_VENTA]WHERE ID_VENTA=" & Id_Factura, Conextion)
        Dim Consulta2 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE FROM [FarmaciaSJ].[dbo].[DETALLE_VENTA] where ID_VENTA=" & Id_Factura, Conextion)
        Dim Consulta3 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE FROM [FarmaciaSJ].[dbo].[VENTA]WHERE ID_VENTA=" & Id_Factura, Conextion)
        Conextion.Open()
        Consulta.ExecuteNonQuery()
        Consulta2.ExecuteNonQuery()
        Consulta3.ExecuteNonQuery()
    End Sub

    Public Function CantidadF() As Integer
        Dim Venta As FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim C As Integer
        Venta = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Conextion = Venta.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     COUNT(ID_VENTA) AS Cantidad FROM         VENTA"
        Reder = Consulta.ExecuteReader()
        If (Reder.Read = True) Then
            C = Reder.Item(0).ToString
        End If
        Return C
    End Function

    Public Sub Descontar_Inventario(ByVal ID_Venta As Integer)
        Dim Venta As FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Consulta2 As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim ID_Lote(1000) As Integer
        Dim ID_Producto(1000) As Integer
        Dim Cantidad(1000) As Integer
        Dim C As Integer
        Dim I As Integer
        Venta = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Conextion = Venta.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Consulta.Connection = Conextion
        Consulta.Connection.Open()
        Consulta.CommandText = "SELECT     Cantidad, ID_LOTE, ID_PRODUCTO FROM         DETALLE_VENTA WHERE     (ID_VENTA = " & ID_Venta & ")"
        Reder = Consulta.ExecuteReader()
        I = 0
        Do While (Reder.Read = True)
            ID_Lote(I) = Reder.Item(1).ToString
            ID_Producto(I) = Reder.Item(2).ToString
            Cantidad(I) = Reder.Item(0).ToString
            I = I + 1
        Loop
        Reder.Close()
        C = I
        I = 0
        Do While (I < C)
            Consulta2 = New Data.SqlClient.SqlCommand
            Consulta2.Connection = Conextion
            Consulta2.CommandText = "UPDATE [FarmaciaSJ].[dbo].[LOTE] SET [CANTIDAD] = CANTIDAD-" & Cantidad(I) & " WHERE ID_LOTE=" & ID_Lote(I) & " and ID_PRODUCTO=" & ID_Producto(I)
            Consulta2.ExecuteNonQuery()
            I = I + 1
        Loop
    End Sub

    Public Sub Pago(ByVal ID_Factura As Integer, ByVal Stotal As String, ByVal Impuestos As String, ByVal Total As String, ByVal TIPO_PAGO As String, ByVal Monto As String, ByVal Vuelto As String, ByVal NCT As String, ByVal Vencimiento As String)
        Dim Venta As FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Stotal1(2) As String
        Dim Impuesto1(2) As String
        Dim Total1(2) As String
        Dim Monto1(2) As String
        Dim Vuelto1(2) As String
        Dim Fecha(3) As String
        Try
            Venta = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
            Conextion = Venta.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Stotal1 = Stotal.Split(",")
            Stotal = Stotal1(0) & "." & Stotal1(1)
            Impuesto1 = Impuestos.Split(",")
            Impuestos = Impuesto1(0) & "." & Impuesto1(1)
            Total1 = Total.Split(",")
            Total = Total1(0) & "." & Total1(1)
            Monto1 = Monto.Split(",")
            Monto = Monto1(0) & "." & Monto1(1)
            Vuelto1 = Vuelto.Split(",")
            Vuelto = Vuelto1(0) & "." & Vuelto1(1)
            If (TIPO_PAGO = "EFECTIVO") Then
                Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[VENTA] SET [SUB-TOTAL] = " & Stotal & " ,[IMPUESTO] = " & Impuestos & ",[TOTAL] = " & Total & " ,[MONTO] = " & Monto & " ,[VUELTO] = " & Vuelto & " ,[TIPO_PAGO] = '" & TIPO_PAGO & "' ,[NUMERO_T_CHEQ] = null, [FVENCIMIENTO_T]=null WHERE ID_VENTA=" & ID_Factura
            ElseIf (TIPO_PAGO = "CHEKE") Then
                Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[VENTA] SET [SUB-TOTAL] = " & Stotal & " ,[IMPUESTO] = " & Impuestos & ",[TOTAL] = " & Total & " ,[MONTO] = " & Monto & " ,[VUELTO] = " & Vuelto & " ,[TIPO_PAGO] = '" & TIPO_PAGO & "' ,[NUMERO_T_CHEQ] = '" & NCT & "', [FVENCIMIENTO_T]=null WHERE ID_VENTA=" & ID_Factura
            Else
                Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[VENTA] SET [SUB-TOTAL] = " & Stotal & " ,[IMPUESTO] = " & Impuestos & ",[TOTAL] = " & Total & " ,[MONTO] = " & Monto & " ,[VUELTO] = " & Vuelto & " ,[TIPO_PAGO] = '" & TIPO_PAGO & "' ,[NUMERO_T_CHEQ] = '" & NCT & "', [FVENCIMIENTO_T]=convert(datetime,'" & Vencimiento & "',102) WHERE ID_VENTA=" & ID_Factura
            End If

            Consulta.ExecuteNonQuery()
        Catch e As Data.SqlClient.SqlException
            MsgBox(e.Message, MsgBoxStyle.OkOnly, "Alert")
        End Try
    End Sub
    Public Function combrobarcantidad(ByVal ID_Lote As Integer, ByVal ID_Producto As Integer) As Integer
        Dim Venta As FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim C As Integer
        Venta = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Conextion = Venta.Connection
        Consulta = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     CANTIDAD, ID_LOTE, ID_PRODUCTO FROM         LOTE WHERE     (ID_LOTE = " & ID_Lote & ") AND (ID_PRODUCTO = " & ID_Producto & ")"
        Reder = Consulta.ExecuteReader()
        If (Reder.Read = True) Then
            C = Reder.Item(0).ToString
        End If
        Return C
    End Function

    Public Function Cargar_Reporte(ByVal ID_Factura As Integer) As FarmaciaSJDataSet
        Dim FarmaciaSJ As FarmaciaSJDataSet = New FarmaciaSJDataSet
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim Connection As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection
        Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Dim Control2 As New Data.DataSet
        Dim Factura As Factura = New Factura
        Dim BD As Data.SqlClient.SqlDataAdapter
        Connection = Detalle.Connection
        Command.Connection = Connection
        Command.CommandText = "SELECT     ID_Farmacia, Razon_Social, RIF, Telefono, Direccion, Logo FROM         FARMACIA WHERE     (ID_Farmacia = 1)"
        BD = New Data.SqlClient.SqlDataAdapter(Command)
        BD.Fill(FarmaciaSJ, "FARMACIA")
        Command.CommandText = "SELECT     ID_VENTA, NUMERO_FACTURA, FECHA, VENCE, DESCUENTO, [SUB-TOTAL], TOTAL, IMPUESTO, MONTO, TIPO_PAGO, VUELTO, NUMERO_T_CHEQ, FVENCIMIENTO_T, ID_CLIENTE FROM         VENTA WHERE     (ID_VENTA = " & ID_Factura & ")"
        BD = New Data.SqlClient.SqlDataAdapter(Command)
        BD.Fill(FarmaciaSJ, "VENTA")
        Command.CommandText = "SELECT     ID_DETALLE_VENTA, Cantidad, ID_VENTA, ID_LOTE, ID_PRODUCTO FROM         DETALLE_VENTA WHERE     (ID_VENTA = " & ID_Factura & ")"
        BD = New Data.SqlClient.SqlDataAdapter(Command)
        BD.Fill(FarmaciaSJ, "DETALLE_VENTA")
        Command.CommandText = "SELECT     ID_LOTE, CANTIDAD, FECHA_VENCIMIENTO, PVP, DESCUENTO, ID_PRODUCTO FROM         LOTE"
        BD = New Data.SqlClient.SqlDataAdapter(Command)
        BD.Fill(FarmaciaSJ, "LOTE")
        Command.CommandText = "SELECT     ID_PRODUCTO, NOMBRE, CODIGO_DE_BARRAS, CODIGO, DESCRIPCION, GRAVADO_EXENTO, UNIDADES_POR_PAQUETE, ID_LINEA FROM         PRODUCTO"
        BD = New Data.SqlClient.SqlDataAdapter(Command)
        BD.Fill(FarmaciaSJ, "PRODUCTO")
        Command.CommandText = "SELECT     ID_CLIENTE, TIPO_IDENTIDAD, DOCUMENTO_IDENTIDAD, NOMBRE, APELLIDO, TELEFONO, DIRECCION FROM         CLIENTE"
        BD = New Data.SqlClient.SqlDataAdapter(Command)
        BD.Fill(FarmaciaSJ, "CLIENTE")
        Factura.SetDataSource(FarmaciaSJ)
        Factura.PrintToPrinter(1, True, 1, 2)
        Return FarmaciaSJ
    End Function
End Class