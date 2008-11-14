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
            VentaTablaAdapter.Insert(Numero, Fecha, Vence, 0, "", "", Id_Cliente)
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
        Dim sql As String = "Select Detalle_venta.ID_Detalle_Venta AS Numero,Producto.Nombre,Lote.PVP As Precio_Unitario,((Lote.Descuento/100)*(Lote.PVP*Detalle_Venta.Cantidad))As Descuento,Ip.Impuesto, Detalle_Venta.Cantidad, ((Lote.PVP*Detalle_Venta.Cantidad)+(1-((Lote.Descuento/100)*(Lote.PVP*Detalle_Venta.Cantidad)))+IP.Impuesto) As Sub_Total from (Select I.ID_Detalle_Venta,Sum(I.Impuesto)As Impuesto From (SELECT     DETALLE_VENTA.ID_DETALLE_VENTA, (HISTORICO_IMPUESTO.VALOR / 100 ) * (DETALLE_VENTA.Cantidad * LOTE.PVP) AS Impuesto FROM         DETALLE_VENTA INNER JOIN IMPUESTO_DETALLE_VENTA ON DETALLE_VENTA.ID_DETALLE_VENTA = IMPUESTO_DETALLE_VENTA.ID_DETALLE_VENTA AND DETALLE_VENTA.ID_VENTA = IMPUESTO_DETALLE_VENTA.ID_VENTA INNER JOIN HISTORICO_IMPUESTO ON IMPUESTO_DETALLE_VENTA.ID_HISTORICO_IMPUESTO = HISTORICO_IMPUESTO.ID_HISTORICO_IMPUESTO AND IMPUESTO_DETALLE_VENTA.ID_IMPUESTO = HISTORICO_IMPUESTO.ID_IMPUESTO INNER JOIN LOTE ON DETALLE_VENTA.ID_LOTE = LOTE.ID_LOTE AND DETALLE_VENTA.ID_PRODUCTO = LOTE.ID_PRODUCTO WHERE     (DETALLE_VENTA.ID_VENTA = " & ID_Venta & "))I Group By I.Id_Detalle_Venta)IP Inner Join Detalle_Venta ON IP.ID_Detalle_Venta=Detalle_Venta.ID_Detalle_Venta Inner Join Lote on Detalle_Venta.ID_Lote=Lote.ID_Lote and Detalle_Venta.ID_Producto=Lote.ID_Producto Inner Join Producto On Lote.ID_Producto=Producto.ID_Producto where Detalle_Venta.ID_Venta=" & ID_Venta
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
        Dim Consulta3 As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand("DELETE FROM [FarmaciaSJ].[dbo].[DETALLE_VENTA]where ID_VENTA=" & Id_Factura, Conextion)
        Conextion.Open()
        Consulta.ExecuteNonQuery()
        Consulta2.ExecuteNonQuery()
        Consulta3.ExecuteNonQuery()
    End Sub
End Class
