Public Class General
    Public Function hacer_consulta(ByVal sentencia As String) As Data.SqlClient.SqlDataReader
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            consulta.Connection = Conextion
            consulta.CommandText = sentencia
            Reder = consulta.ExecuteReader()
            If (Reder.Read = True) Then
                If (Reder.HasRows = True) Then
                    Return Reder
                End If
            End If
        Catch e As Data.SqlClient.SqlException
        End Try
    End Function
End Class
