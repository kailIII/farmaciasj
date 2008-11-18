Public Class Pedido_Frecuente
    Public Function BuscarNumeroPedido(ByVal codigo As String) As Boolean
        Dim Pedido As FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Pedido = New FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
            Conextion = Pedido.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT numero_pedido FROM pedido_frecuente WHERE ('" & codigo & "' = numero_pedido)"
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
    Public Sub Ingresar_Pedido(ByVal num_pedido As String, ByVal finicio As Date, ByVal fin As Date, ByVal descripcion As String, ByVal cantidad As Integer, ByVal producto As String)
        Dim pedido As FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim mars As Data.SqlClient.SqlDataReader
        Dim codigoproducto As Integer
        Try
            pedido = New FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
            Conextion = pedido.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "select id_producto from producto where codigo_barras = '" & producto & "'"
            mars = Consulta.ExecuteReader()
            codigoproducto = Integer.Parse(mars.Item(0).ToString)
            Consulta.CommandText = "INSERT INTO Pedido_frecuente (Numero_pedido,fecha_inicio,fecha_fin,descripcion,cantidad_diaria,ID_producto, estado) VALUES ('" & num_pedido & "','" & finicio & "','" & fin & "','" & descripcion & "','" & cantidad & "','" & producto & "','Activo')"
            Consulta.ExecuteReader()
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub

End Class
