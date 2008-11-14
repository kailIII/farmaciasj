Public Class Venta
    Public BasedeDatos As FarmaciaSJDataSet
    Public Function Ingresar_Venta(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal Id_Cliente As String) As Integer
        Dim VentaTablaAdapter As FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim ID As Integer

        Try
            BasedeDatos = New FarmaciaSJDataSet
            VentaTablaAdapter = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
            ID = VentaTablaAdapter.Insert(Numero, Fecha, Vence, 0, "", "", Id_Cliente)
            ' Commit
            VentaTablaAdapter.Update(BasedeDatos.VENTA)
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
End Class
