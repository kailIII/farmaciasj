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
    Public Function BuscarLinea(ByVal nombre As String) As Boolean
        Dim Linea As FarmaciaSJDataSetTableAdapters.LINEATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Linea = New FarmaciaSJDataSetTableAdapters.LINEATableAdapter
            Conextion = Linea.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT NOMBRE FROM LINEA WHERE ('" & nombre & "' = NOMBRE)"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                If (Reder.HasRows = True) Then
                    Return True
                Else
                    Return (False)
                End If
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Function
    Public Function BuscarLinea2(ByVal NOMBRE As String) As Data.SqlClient.SqlDataReader
        Dim Linea As FarmaciaSJDataSetTableAdapters.LINEATableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Linea = New FarmaciaSJDataSetTableAdapters.LINEATableAdapter
        Conextion = Linea.Connection
        Conextion.Open()
        Consulta = New Data.SqlClient.SqlCommand
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     ID_LINEA, NOMBRE, DESCRIPCION, DESCUENTO_MAXIMO, MARGEN_UTIL FROM         LINEA WHERE     (NOMBRE = '" & NOMBRE & "')"
        Reder = Consulta.ExecuteReader
        Return Reder
    End Function
 
End Class
