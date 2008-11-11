Public Class Venta
    Public BasedeDatos As FarmaciaSJDataSet
    Public Function Ingresar_Venta(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal Id_Cliente As String) As Integer
        Dim VentaTablaAdapter As FarmaciaSJDataSetTableAdapters.VENTATableAdapter
        Dim Descuento As System.Nullable(Of Double)
        Dim ID As Integer

        Try
            BasedeDatos = New FarmaciaSJDataSet
            VentaTablaAdapter = New FarmaciaSJDataSetTableAdapters.VENTATableAdapter
            ID = VentaTablaAdapter.Insert(Numero, Fecha, Vence, Descuento.Value, "", "", Id_Cliente)
            ' Commit
            VentaTablaAdapter.Update(BasedeDatos.VENTA)
            Return ID
        Catch err As ArgumentNullException
            Return -1
        End Try


    End Function
End Class
