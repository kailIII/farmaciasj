Public Class Controlador_Ingresar_Producto
    Public Function BuscarCodigoBarras(ByVal Codigo As String) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT CODIGO_DE_BARRAS FROM PRODUCTO WHERE ('" & Codigo & "' = CODIGO_DE_BARRAS)"
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
    Public Sub ActivarCampos(ByVal pantalla As Ingresar_Producto, ByVal respuesta As Boolean)
        If respuesta = False Then
            pantalla.Nom_Producto.Enabled = True
            pantalla.Unidades_Producto.Enabled = True
            pantalla.GE_Producto.Enabled = True
            pantalla.Desc_Producto.Enabled = True
            pantalla.Cod_Producto.Enabled = True
            pantalla.Ingresar.Enabled = True
            pantalla.Riff.Enabled = True
            pantalla.Linea.Enabled = True
            pantalla.Cod_Barras.Enabled = False
        End If
    End Sub
    Public Sub llenar_proveedores(ByVal ventana As Ingresar_Producto, ByVal proveedordado As String)
        'If (proveedordado = "") Then
        'Dim Proveedor As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        'Dim Conextion As Data.SqlClient.SqlConnection
        'Dim Consulta As Data.SqlClient.SqlCommand
        'Dim Reder As Data.SqlClient.SqlDataReader
        'Proveedor = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        'Conextion = Proveedor.Connection
        'Consulta = New Data.SqlClient.SqlCommand
        'Conextion.Open()
        'Consulta.Connection = Conextion
        'Consulta.CommandText = "select nombre from proveedor"
        'Reder = Consulta.ExecuteReader()
        'ventana.Riff.Items.Add(Reder)
        'else
        'ventana.Proveedores.Items.Add(proveedordado)
        'ventana.Proveedores.Enabled = False
        'End If
    End Sub
    Public Function BuscarNombreProducto(ByVal nombre As String) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT NOMBRE FROM PRODUCTO WHERE ('" & nombre & "' = NOMBRE)"
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
    Public Function BuscarCodigoProducto(ByVal codigo As String) As Boolean
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT Codigo FROM PRODUCTO WHERE ('" & codigo & "' = codigo)"
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
    Public Sub Ingresar_Producto(ByVal codigo_barras As String, ByVal codigo As String, ByVal nombre_producto As String, ByVal desc_producto As String, ByVal ge_producto As String, ByVal u_producto As Integer, ByVal proveedor As Integer, ByVal linea As String)
        Dim Producto As FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim mars As Data.SqlClient.SqlDataReader
        Dim codigoproducto, codigoproveedor, codigolinea As Integer
        Try
            Producto = New FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
            Conextion = Producto.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "select id_proveedor from proveedor where riff = '" & proveedor & "'"
            mars = Consulta.ExecuteReader()
            codigoproveedor = Integer.Parse(mars.Item(0).ToString)
            Consulta.CommandText = "select id_linea from linea where id_linea = '" & linea & "'"
            mars = Consulta.ExecuteReader()
            codigolinea = Integer.Parse(mars.Item(0).ToString)
            Consulta.CommandText = "INSERT INTO PRODUCTO (NOMBRE,CODIGO_DE_BARRAS,CODIGO,DESCRIPCION,GRAVADO_EXENTO,UNIDADES_POR_PAQUETE,ID_LINEA) VALUES ('" & codigo_barras & "','" & codigo & "','" & nombre_producto & "','" & desc_producto & "','" & ge_producto & "','" & u_producto & "','" & codigolinea & "')"
            Consulta.ExecuteReader()
            Consulta.CommandText = "select id_producto from producto where codigo = '" & codigo & "'"
            mars = Consulta.ExecuteReader()
            codigoproducto = Integer.Parse(mars.Item(0).ToString)
            Consulta.CommandText = "insert into proveedor_producto (id_proveedor,id_producto) values '" & codigoproveedor & "','" & codigoproducto & "'"
            Consulta.ExecuteReader()
        Catch e As Data.SqlClient.SqlException
        End Try
    End Sub
    Public Function BuscarRiff(ByVal nombre As String) As Boolean
        Dim Proveedor As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Proveedor = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
            Conextion = Proveedor.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT RIF FROM PROVEEDOR WHERE ('" & nombre & "' = RIF)"
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
End Class