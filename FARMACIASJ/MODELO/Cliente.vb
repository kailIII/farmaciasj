Public Class Cliente
    Public BasedeDatos As FarmaciaSJDataSet

    Public Function Ingresar(ByVal Nombre As String, ByVal Apellido As String, ByVal Documento_Identidad As String, ByVal Telefono As String, ByVal Direccion As String) As Boolean
        Dim ClienteTableAdapter As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            ClienteTableAdapter = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            ClienteTableAdapter.Insert(Documento_Identidad, Nombre, Apellido, Telefono, Direccion)
            ClienteTableAdapter.Update(BasedeDatos.CLIENTE)
            BasedeDatos.AcceptChanges()
            Return True
        Catch err As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function Ingresar(ByVal Nombre As String, ByVal Documento_Identidad As String, ByVal Telefono As String, ByVal Direccion As String) As Boolean
        Dim cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            Cliente = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            Conextion = Cliente.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "INSERT INTO [FarmaciaSJ].[dbo].[CLIENTE] ([IDENTIDAD] ,[NOMBRE] ,[TELEFONO] ,[DIRECCION]) VALUES ('" & Documento_Identidad & "','" & Nombre & "' ,'" & Telefono & "' ,'" & Direccion & "')"
            Reder = Consulta.ExecuteReader()
            Return True
        Catch err As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function buscar_identidad(ByVal Numero As String, ByVal Venta As Realizar_Venta) As Integer
        Dim Cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader

        Try
            Cliente = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            Conextion = Cliente.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT     ID_CLIENTE, ID_CLIENTE, IDENTIDAD, NOMBRE, APELLIDO, TELEFONO, DIRECCION FROM         CLIENTE WHERE     (IDENTIDAD = '" & Numero & "')"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Venta.ID_Cliente = Integer.Parse(Reder.Item(0).ToString)
                Venta.Identidad.Text = Reder.Item(2).ToString()
                If (Numero.Contains("J")) Then
                    Venta.Nombre.Text = Reder.Item(3).ToString()
                Else
                    Venta.Nombre.Text = Reder.Item(3).ToString() & " " & Reder.Item(4).ToString
                End If
                Return 0
            Else
                Return 1
            End If
        Catch e As Data.SqlClient.SqlException
            Return 2
        End Try
    End Function
    Public Function BuscarCliente(ByVal Codigo As String, ByVal Tipo As String) As Boolean
        Dim cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Try
            cliente = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            Conextion = cliente.Connection
            Consulta = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT documento_identidad FROM cliente WHERE ('" & Codigo & "' = documento_identidad and '" & TIPO & "'= TIPO_IDENTIDAD)"
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
