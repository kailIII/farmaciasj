Public Class Proveedor
    Public BasedeDatos As FarmaciaSJDataSet

    Public Function Ingresar_Proveedor(ByVal Codigo As String, ByVal Rif As String, ByVal Nombre As String, ByVal Correo As String, ByVal Dir As String, ByVal Ciudad As String, ByVal Saldo As Double) As Boolean

        Dim Adaptador As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Adaptador = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
            'insert bd
            Adaptador.Insert(Codigo, Rif, Nombre, Correo, Ciudad, Dir, Saldo, "Activa")
            ' Commit
            Adaptador.Update(BasedeDatos.PROVEEDOR)
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function Buscar_Proveedor(ByVal Cadena As String, ByVal Codigo As Boolean) As Boolean

        
    End Function

End Class




