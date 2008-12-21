Public Class Pedido_Frecuente

    Public Function Cargar_Datos_Pedido(Pedido_Numero as String) As Data.SqlClient.SqlDataReader
        Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
        Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
        Conextion.Open()
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT CLIENTE.APELLIDO+' '+ CLIENTE.NOMBRE as Nombre, PRODUCTO.NOMBRE AS Expr1, PEDIDO_FRECUENTE.CANTIDAD_DIARIA FROM CLIENTE INNER JOIN PEDIDO_FRECUENTE ON CLIENTE.ID_CLIENTE = PEDIDO_FRECUENTE.ID_CLIENTE INNER JOIN PRODUCTO ON PEDIDO_FRECUENTE.ID_PRODUCTO = PRODUCTO.ID_PRODUCTO WHERE ESTATUS='ACTIVO' AND ID_PEDIDO=" & Pedido_Numero
        Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
        'If (Reder.Read = True) Then
        Return Reder
    End Function

    Public Function Suspender_Pedido(ByVal Pedido_Numero As String) As Boolean

        Dim Adaptador As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Try
            Adaptador = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter()
            Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
            Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "UPDATE PEDIDO_FRECUENTE SET FECHA_FIN=GETDATE() , ESTATUS='INACTIVO' WHERE ID_PEDIDO=" & Pedido_Numero
            Consulta.ExecuteNonQuery()
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try

    End Function


    Public Sub Ingresar_Pedido(ByVal num_pedido As String, ByVal finicio As Date, ByVal fin As Date, ByVal descripcion As String, ByVal cantidad As Integer, ByVal codigoproducto As Integer, ByVal codigocliente As Integer)
        Dim pedido As FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
        Dim BasedeDatos As New FarmaciaSJDataSet
        Try
            pedido = New FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
            pedido.Insert(num_pedido, finicio, fin, finicio, descripcion, cantidad, codigoproducto, codigocliente, "ACTIVO")
            pedido.Update(BasedeDatos.PEDIDO_FRECUENTE)
            BasedeDatos.AcceptChanges()
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub

End Class