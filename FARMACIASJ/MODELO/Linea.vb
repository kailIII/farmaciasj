Public Class Linea
    Public BasedeDatos As FarmaciaSJDataSet
    Public Function Ingresar_Linea(ByVal Nombre As String, ByVal Descuento As Double, ByVal Descripcion As String, ByVal Margen As Double) As Boolean
        
        Dim LineaTablaAdapter As FarmaciaSJDataSetTableAdapters.LINEATableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            LineaTablaAdapter = New FarmaciaSJDataSetTableAdapters.LINEATableAdapter
            LineaTablaAdapter.Insert(Nombre, Descripcion, Descuento, Margen)
            ' Commit
            LineaTablaAdapter.Update(BasedeDatos.LINEA)
            Return True
        Catch err As ArgumentNullException
            Return False
        End Try

    End Function
End Class
