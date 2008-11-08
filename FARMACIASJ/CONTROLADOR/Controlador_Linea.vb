Public Class Controlador_Linea

    Public Sub Ingresando_Linea(ByVal Nombre As String, ByVal Descuento As Double, ByVal Descripcion As String, ByVal Margen As Double)

        Dim BasedeDatos As FarmaciaSJDataSet
        Dim Linea As FarmaciaSJDataSet.LINEADataTable
        Dim LineaFila As FarmaciaSJDataSet.LINEARow
        Dim LineaTablaAdapter As FarmaciaSJDataSetTableAdapters.LINEATableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Linea = New FarmaciaSJDataSet.LINEADataTable
            LineaTablaAdapter = New FarmaciaSJDataSetTableAdapters.LINEATableAdapter
            LineaFila = Linea.NewLINEARow()
            LineaFila.NOMBRE = Nombre
            LineaFila.DESCUENTO_MAXIMO = Descuento
            LineaFila.DESCRIPCION = Descripcion
            LineaFila.MARGEN_UTIL = Margen
            'Anade fila
            Linea.AddLINEARow(LineaFila)
            ' Commit
            LineaTablaAdapter.Update(BasedeDatos.LINEA)
            MsgBox("La Línea se insertó con éxito.", MsgBoxStyle.OkOnly, "Aviso")
        Catch err As ArgumentNullException
            MsgBox("La Línea no se pudo insertar", MsgBoxStyle.OkOnly, "Error")
        End Try

    End Sub

End Class

