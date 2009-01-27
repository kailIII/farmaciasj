Public Class Venta
    Public BasedeDatos As FarmaciaSJDataSet
    Public Function Ingresar_Venta(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal Id_Cliente As Integer) As Integer
        Dim VentaTablaAdapter As FarmaciaSJDataSetTableAdapters.VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim ID As Integer
        Dim Conextion As Data.SqlClient.SqlConnection = VentaTablaAdapter.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("SELECT     ID_VENTA FROM         VENTA WHERE     (NUMERO_FACTURA = '" & Numero & "')", Conextion)
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            BasedeDatos = New FarmaciaSJDataSet
            VentaTablaAdapter.Insert(Numero, Fecha, Vence, 0, 0, 0, 0, 0, 0, "", "", Vence, Id_Cliente, 0)
            VentaTablaAdapter.Update(BasedeDatos.VENTA)
            Conextion.Open()
            Reder = Consulta.ExecuteReader
            If (Reder.Read = True) Then
                ID = Integer.Parse(Reder.Item(0).ToString)
            End If
            Return ID
        Catch err As ArgumentNullException
            Return -1
        End Try
    End Function
    Public Function Ingresar_Detalle(ByVal ID_Detalle As Integer, ByVal ID_Venta As Integer, ByVal ID_Producto As Integer, ByVal ID_LOTE As Integer, ByVal ID_Impuesto() As Integer, ByVal ID_Historico_Impuesto() As Integer, ByVal Cantidad As Integer, ByVal N As Integer) As Integer
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

    Public Function Traer_Detalle(ByVal ID_Venta As Integer) As Data.DataTable
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

    Public Sub Borrar_Factura(ByVal Id_Factura As Integer)
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
            C = Integer.Parse(Reder.Item(0).ToString)
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
            ID_Lote(I) = Integer.Parse(Reder.Item(1).ToString)
            ID_Producto(I) = Integer.Parse(Reder.Item(2).ToString)
            Cantidad(I) = Integer.Parse(Reder.Item(0).ToString)
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
            Stotal1 = Stotal.Split(Char.Parse(","))
            Stotal = Stotal1(0) & "." & Stotal1(1)
            Impuesto1 = Impuestos.Split(Char.Parse(","))
            Impuestos = Impuesto1(0) & "." & Impuesto1(1)
            Total1 = Total.Split(Char.Parse(","))
            Total = Total1(0) & "." & Total1(1)
            Monto1 = Monto.Split(Char.Parse(","))
            Monto = Monto1(0) & "." & Monto1(1)
            Vuelto1 = Vuelto.Split(Char.Parse(","))
            Vuelto = Vuelto1(0) & "." & Vuelto1(1)
            If (TIPO_PAGO = "EFECTIVO") Then
                Consulta.CommandText = "UPDATE [FarmaciaSJ].[dbo].[VENTA] SET [SUB-TOTAL] = " & Stotal & " ,[IMPUESTO] = " & Impuestos & ",[TOTAL] = " & Total & " ,[MONTO] = " & Monto & " ,[VUELTO] = " & Vuelto & " ,[TIPO_PAGO] = '" & TIPO_PAGO & "' ,[NUMERO_T_CHEQ] = null, [FVENCIMIENTO_T]=null WHERE ID_VENTA=" & ID_Factura
            ElseIf (TIPO_PAGO = "CHEQUE") Then
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
            C = Integer.Parse(Reder.Item(0).ToString)
        End If
        Return C
    End Function

    Public Function Cargar_Reporte(ByVal ID_Factura As Integer) As FarmaciaSJDataSet
        Dim FarmaciaSJ As New FarmaciaSJDataSet
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim Connection As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection
        Dim Command As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Dim Control2 As New Data.DataSet
        Dim Factura As Factura = New Factura
        Dim BD As Data.SqlClient.SqlDataAdapter
        Try
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
            Command.CommandText = "SELECT     LOTE.* FROM         LOTE INNER JOIN DETALLE_VENTA ON LOTE.ID_LOTE = DETALLE_VENTA.ID_LOTE AND LOTE.ID_PRODUCTO = DETALLE_VENTA.ID_PRODUCTO WHERE     (DETALLE_VENTA.ID_VENTA = " & ID_Factura & ")"
            BD = New Data.SqlClient.SqlDataAdapter(Command)
            BD.Fill(FarmaciaSJ, "LOTE")
            Command.CommandText = "SELECT     PRODUCTO.* FROM         DETALLE_VENTA INNER JOIN PRODUCTO ON DETALLE_VENTA.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO WHERE     (DETALLE_VENTA.ID_VENTA = " & ID_Factura & ")"
            BD = New Data.SqlClient.SqlDataAdapter(Command)
            BD.Fill(FarmaciaSJ, "PRODUCTO")
            Command.CommandText = "SELECT     ID_CLIENTE,IDENTIDAD, NOMBRE, APELLIDO, TELEFONO, DIRECCION FROM         CLIENTE"
            BD = New Data.SqlClient.SqlDataAdapter(Command)
            BD.Fill(FarmaciaSJ, "CLIENTE")
            Factura.SetDataSource(FarmaciaSJ)
            Factura.PrintToPrinter(1, True, 1, 2)
            MsgBox("La factura se procesó con éxito", MsgBoxStyle.OkOnly, "Aviso")
            Return FarmaciaSJ
        Catch E As Exception
            MsgBox("La Factura se procesó con éxito, pero existen problemas con la Impresora", MsgBoxStyle.OkOnly, "Error")
            Return FarmaciaSJ
        End Try
    End Function



    'LZ

    Public Function Buscar_id_Cliente_Factura(ByVal Control_Numero As String) As Integer
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT ID_CLIENTE FROM VENTA WHERE NUMERO_FACTURA='" & Control_Numero & "'"
        Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
        Dim Id_Cliente As Integer = 0
        If (Reder.Read) Then
            Id_Cliente = CInt(Reder.Item(0).ToString)
        End If
        Reder.Close()
        Return Id_Cliente
    End Function

    Public Function Buscar_Id_Venta_Factura(ByVal Control_Numero As String) As Integer
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT ID_VENTA FROM VENTA WHERE NUMERO_FACTURA='" & Control_Numero & "'"
        Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
        Dim Id_Cliente As Integer = 0
        If (Reder.Read) Then
            Id_Cliente = CInt(Reder.Item(0).ToString)
        End If
        Reder.Close()
        Return Id_Cliente
    End Function





    Public Sub Buscar_Info_Cliente(ByVal Id_Cliente As Integer, ByVal Venta As Devolucion_Venta)

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
            Consulta.CommandText = "SELECT APELLIDO+', '+NOMBRE, IDENTIDAD, TELEFONO, DIRECCION, ID_CLIENTE FROM CLIENTE WHERE ID_CLIENTE=" & Id_Cliente
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Venta.Nombre.Text = Reder.Item(0).ToString()
                Venta.Identidad.Text = Reder.Item(1).ToString()
                Venta.ID_Cliente = CInt(Reder.Item(4).ToString())
                Reder.Close()
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub

    Public Sub Buscar_Info_Venta_Producto(ByVal Id_Cliente As Integer, ByVal Venta As Devolucion_Venta)

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
            Consulta.CommandText = "SELECT APELLIDO+', '+NOMBRE, IDENTIDAD, TELEFONO, DIRECCION, ID_CLIENTE FROM CLIENTE WHERE ID_CLIENTE=" & Id_Cliente
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Venta.Nombre.Text = Reder.Item(0).ToString()
                Venta.Identidad.Text = Reder.Item(1).ToString()
                Venta.ID_Cliente = CInt(Reder.Item(4).ToString())
                Reder.Close()
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub



    Public Function Traer_Detalle_Devolucion(ByVal ID_Venta As Integer) As Data.DataTable
        Dim Bd As FarmaciaSJDataSet
        Bd = New FarmaciaSJDataSet
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim cn As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection(Detalle.Connection.ConnectionString)
        Dim sql As String = "SELECT PRODUCTO.CODIGO_DE_BARRAS AS CODIGO, PRODUCTO.NOMBRE, LOTE.PVP, (LOTE.DESCUENTO / 100) * (LOTE.PVP * DETALLE_VENTA.Cantidad) AS DESCUENTO, DETALLE_VENTA.Cantidad, (LOTE.PVP * DETALLE_VENTA.Cantidad) * (1 - LOTE.DESCUENTO / 100) AS SUB_TOTAL FROM         DETALLE_VENTA INNER JOIN LOTE ON DETALLE_VENTA.ID_LOTE = LOTE.ID_LOTE AND DETALLE_VENTA.ID_PRODUCTO = LOTE.ID_PRODUCTO INNER JOIN PRODUCTO ON LOTE.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO WHERE DETALLE_VENTA.ID_VENTA =" & ID_Venta
        Dim da As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sql, cn)
        Dim Table As Data.DataTable = New Data.DataTable("Detalle_Factura")
        da.Fill(Table)
        Return Table
    End Function


    Public Function Ultima_Devolucion(ByVal Id_Venta As Integer) As Integer

        Dim Cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim Resultado As Integer = 0
        Try
            Cliente = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            Conextion = Cliente.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT ID_VENTA FROM VENTA WHERE VENTA.ID_DEVOLUCION_ID_VENTA=" & Id_Venta
            Reder = Consulta.ExecuteReader()

            If (Reder.Read = True) Then
                Resultado = CInt(Reder.Item(0).ToString())
                Reder.Close()

            End If
        Catch e As Data.SqlClient.SqlException
        End Try
        Return Resultado
    End Function



    Public Function Existe_Producto_Venta(ByVal Id_Venta As Integer, ByVal Numero_Control As String) As Boolean

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
            Consulta.CommandText = "SELECT     PRODUCTO.ID_PRODUCTO FROM PRODUCTO INNER JOIN DETALLE_VENTA ON PRODUCTO.ID_PRODUCTO = DETALLE_VENTA.ID_PRODUCTO WHERE PRODUCTO.CODIGO_DE_BARRAS='" & Numero_Control & "' AND DETALLE_VENTA.ID_VENTA=" & Id_Venta
            Reder = Consulta.ExecuteReader()

            If (Reder.Read = True) Then
                Return True

            End If
        Catch e As Data.SqlClient.SqlException
        End Try
        Return False
    End Function




    Public Function Id_Venta_Devolucion(ByVal Id_Venta As Integer) As Integer

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

            Consulta.CommandText = "SELECT     VENTA.ID_VENTA FROM VENTA INNER JOIN DETALLE_VENTA ON VENTA.ID_VENTA = DETALLE_VENTA.ID_VENTA WHERE     VENTA.ID_DEVOLUCION_ID_VENTA = " & Id_Venta
            Reder = Consulta.ExecuteReader()

            If (Reder.Read = True) Then
                Return CInt(Reder.Item(0).ToString)
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
        Return 0
    End Function




    Public Sub Consulta_Producto_Venta(ByVal Id_Venta As Integer, ByVal Numero_Control As String, ByVal Ventana As Devolucion_Venta)

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
            Consulta.CommandText = "SELECT     PRODUCTO.NOMBRE, LOTE.PVP, LOTE.DESCUENTO, DETALLE_VENTA.Cantidad, VENTA.[SUB-TOTAL], VENTA.IMPUESTO, VENTA.TOTAL, PRODUCTO.ID_PRODUCTO, LOTE.ID_LOTE, DETALLE_VENTA.ID_DETALLE_VENTA FROM DETALLE_VENTA INNER JOIN VENTA ON DETALLE_VENTA.ID_VENTA = VENTA.ID_VENTA INNER JOIN PRODUCTO ON DETALLE_VENTA.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO INNER JOIN LOTE ON DETALLE_VENTA.ID_LOTE = LOTE.ID_LOTE AND DETALLE_VENTA.ID_PRODUCTO = LOTE.ID_PRODUCTO AND PRODUCTO.ID_PRODUCTO = LOTE.ID_PRODUCTO WHERE PRODUCTO.CODIGO_DE_BARRAS='" & Numero_Control & "' AND DETALLE_VENTA.ID_VENTA=" & Id_Venta
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then

                Ventana.NombreP.Text = Reder.Item(0).ToString
                Ventana.Punitario.Text = Reder.Item(1).ToString
                Ventana.Descuento.Text = Reder.Item(2).ToString
                Ventana.Cantidad.Text = Reder.Item(3).ToString
                Ventana.Sub_Total.Text = Reder.Item(4).ToString
                Ventana.Impuesto.Text = Reder.Item(5).ToString
                Ventana.Total.Text = Reder.Item(6).ToString
                Ventana.ID_Lote = CInt(Reder.Item(8).ToString)
                Ventana.ID_Producto = CInt(Reder.Item(7).ToString)
                Ventana.ID_Detalle = CInt(Reder.Item(9).ToString)

            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub


    Public Sub Calculo_Impuesto_Devolucion(ByVal Id_Venta As Integer, ByVal Id_Detalle_Venta As Integer)

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
            Consulta.CommandText = "SELECT     HISTORICO_IMPUESTO.VALOR FROM         IMPUESTO_DETALLE_VENTA INNER JOIN HISTORICO_IMPUESTO ON IMPUESTO_DETALLE_VENTA.ID_HISTORICO_IMPUESTO = HISTORICO_IMPUESTO.ID_HISTORICO_IMPUESTO AND IMPUESTO_DETALLE_VENTA.ID_IMPUESTO = HISTORICO_IMPUESTO.ID_IMPUESTO WHERE     (IMPUESTO_DETALLE_VENTA.ID_DETALLE_VENTA = " & Id_Detalle_Venta & ") AND (IMPUESTO_DETALLE_VENTA.ID_VENTA = " & Id_Venta & ")"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then

                'Ventana.NombreP.Text = Reder.Item(0).ToString
                'Ventana.Punitario.Text = Reder.Item(1).ToString
                'Ventana.Descuento.Text = Reder.Item(2).ToString
                'Ventana.Cantidad.Text = Reder.Item(3).ToString
                'Ventana.Sub_Total.Text = Reder.Item(4).ToString
                'Ventana.Impuesto.Text = Reder.Item(5).ToString
                'Ventana.Total.Text = Reder.Item(6).ToString
                'Ventana.Id_Lote_Publico = CInt(Reder.Item(8).ToString)
                'Ventana.Id_Producto_Publico = CInt(Reder.Item(7).ToString)
                'Ventana.ID_Detalle_Publico = CInt(Reder.Item(9).ToString)
                'Ventana.Id_Detalle_Venta.Text = Reder.Item(9).ToString
            End If

        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub

    Public Function Tamano_Det_Venta() As Integer


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
            Consulta.CommandText = "SELECT COUNT(*) FROM DETALLE_VENTA"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Return CInt(Reder.Item(0).ToString) + 1
            End If
        Catch e As Data.SqlClient.SqlException
        End Try

        Return 0

    End Function



    Public Function Ingresar_Det_Venta(ByVal Id_Venta As Integer, ByVal Ventana As Devolucion_Venta, ByVal Id_Producto As Integer) As Boolean
        Dim Conexion As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Conexion = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
            Conexion.Insert(Tamano_Det_Venta(), Id_Venta, CInt(Ventana.Cantidad.Text), Ventana.ID_Lote, Id_Producto)
            Conexion.Update(BasedeDatos.DETALLE_VENTA)
            Return True
        Catch err As ArgumentNullException
            Return False
        End Try
    End Function


    Public Function Crear_Devolucion(ByVal Id_Devolucion_Id_Venta As Integer, ByVal Id_Cliente As Integer, ByVal Ventana As Devolucion_Venta) As Boolean
        Dim Conexion As FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Conexion = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
            Conexion.Insert("F" & Tamano_Det_Venta(), Ventana.Fecha_Compra.Value, Ventana.Vence.Value, 0, 0, 0, 0, 0, 0, "", "", Ventana.Fecha_Compra.Value, Id_Cliente, Id_Devolucion_Id_Venta)
            Conexion.Update(BasedeDatos.VENTA)
            Return True
        Catch err As ArgumentNullException
            Return False
        End Try
    End Function
    Public Function combrobarcantidaddetalle(ByVal ID_detalle As Integer, ByVal ID_factura As Integer) As Integer
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
        Consulta.CommandText = "SELECT     CANTIDAD FROM         Detalle_Venta WHERE     (ID_detalle_venta = " & ID_detalle & ") AND (ID_venta = " & ID_factura & ")"
        Reder = Consulta.ExecuteReader()
        If (Reder.Read = True) Then
            C = Integer.Parse(Reder.Item(0).ToString)
        End If
        Return C
    End Function

    'Fin LZ

End Class