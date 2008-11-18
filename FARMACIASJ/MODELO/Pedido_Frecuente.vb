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
    Public Sub Ingresar_Pedido(ByVal num_pedido As String, ByVal finicio As Date, ByVal fin As Date, ByVal descripcion As String, ByVal cantidad As Integer, ByVal producto As String, ByVal Tipo As String, ByVal Identidad As String)
        Dim pedido As FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim mars As Data.SqlClient.SqlDataReader
        Dim codigoproducto, codigocliente As Integer
        Dim BasedeDatos As New FarmaciaSJDataSet

        Try
            pedido = New FarmaciaSJDataSetTableAdapters.PEDIDO_FRECUENTETableAdapter
            Conextion = pedido.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     ID_PRODUCTO FROM         PRODUCTO WHERE     CODIGO_DE_BARRAS  = '" & producto & "'"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigoproducto = Integer.Parse(mars.Item(0).ToString)
            End If
            mars.Close()
            Consulta.CommandText = "SELECT     ID_CLIENTE FROM         CLIENTE WHERE     (TIPO_IDENTIDAD = '" & Tipo & "') AND (DOCUMENTO_IDENTIDAD = '" & Identidad & "')"
            mars = Consulta.ExecuteReader()
            If (mars.Read = True) Then
                codigocliente = Integer.Parse(mars.Item(0).ToString)
            End If
            mars.Close()
            pedido.Insert(num_pedido, finicio, fin, finicio, descripcion, cantidad, codigoproducto, codigocliente, "ACTIVO")
            pedido.Update(BasedeDatos.PEDIDO_FRECUENTE)
            BasedeDatos.AcceptChanges()
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub

End Class
