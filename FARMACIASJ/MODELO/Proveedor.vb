Public Class Proveedor
    Public BasedeDatos As FarmaciaSJDataSet

    Public Function Id_Ultimo_Proveedor() As Integer

        Try
            Dim Proveedor_x As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection = Proveedor_x.Connection
            Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            Consulta.CommandText = "SELECT ID_PROVEEDOR FROM PROVEEDOR ORDER BY ID_PROVEEDOR DESC"
            Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Return CInt(Reder.Item(0).ToString())
            Else
                Return 0
            End If
        Catch e As Data.SqlClient.SqlException
            Return 0
        End Try
    End Function

    Public Function Ingresar_Proveedor_Producto(ByVal Arreglo As Array) As Boolean
        Dim myEnumerator As System.Collections.IEnumerator = Arreglo.GetEnumerator()
        Dim i As Integer = 0

        Dim Adaptador As FarmaciaSJDataSetTableAdapters.PROVEEDOR_PRODUCTOTableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Adaptador = New FarmaciaSJDataSetTableAdapters.PROVEEDOR_PRODUCTOTableAdapter()
            While myEnumerator.MoveNext() And CInt(Arreglo.GetValue(i)) <> 0
                ' Insert BD
                Dim Numero As Integer = Id_Ultimo_Proveedor()
                Adaptador.Insert(Numero, CInt(Arreglo.GetValue(i)))
                ' Commit
                Adaptador.Update(BasedeDatos.PROVEEDOR_PRODUCTO)
                i += 1
            End While
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function



    Public Function Actualizar_Proveedor(ByVal Codigo As String, ByVal Rif As String, ByVal Nombre As String, ByVal Correo As String, ByVal Dir As String, ByVal Ciudad As String, ByVal Saldo As Double) As Boolean
        Dim Adaptador As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Adaptador = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter()
            ' Commit
            Dim Id_proveedor As Integer = Existe_Proveedor(Codigo, True)
            Adaptador.Update(Codigo, Rif, Nombre, Correo, Ciudad, Dir, Saldo, "Activa", Id_proveedor, Saldo)

            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function Ingresar_Proveedor(ByVal Codigo As String, ByVal Rif As String, ByVal Nombre As String, ByVal Correo As String, ByVal Dir As String, ByVal Ciudad As String, ByVal Saldo As Double) As Boolean

        Dim Adaptador As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Adaptador = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
            ' Insert BD
            Adaptador.Insert(Codigo, Rif, Nombre, Correo, Ciudad, Dir, Saldo, "Activa")
            ' Commit
            Adaptador.Update(BasedeDatos.PROVEEDOR)
            Return True
        Catch ex As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function Existe_Proveedor(ByVal Cadena As String, ByVal Codigo As Boolean) As Integer
        Try
            Dim Cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            Dim Conextion As Data.SqlClient.SqlConnection = Cliente.Connection
            Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
            Conextion.Open()
            Consulta.Connection = Conextion
            If (Codigo) Then
                Consulta.CommandText = "SELECT ID_PROVEEDOR FROM PROVEEDOR where Codigo='" & Cadena & "'"
            Else
                Consulta.CommandText = "SELECT ID_PROVEEDOR FROM PROVEEDOR where RIF='" & Cadena & "'"
            End If

            Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Return CInt(Reder.Item(0).ToString())
            Else
                Return 0
            End If

        Catch e As Data.SqlClient.SqlException
            Return 0
        End Try
    End Function

    Public Sub Buscar_Proveedor(ByVal Cadena As String, ByVal Codigo As Boolean, ByVal Ventana_Modificar_Proveedor As Ingresar_Proveedor)

        Dim Id_Proveedor As Integer = Existe_Proveedor(Cadena, Codigo)

        If (Id_Proveedor <> 0) Then
            Try
                Dim Cliente As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
                Dim Conextion As Data.SqlClient.SqlConnection = Cliente.Connection
                Dim Consulta As Data.SqlClient.SqlCommand = New Data.SqlClient.SqlCommand
                Conextion.Open()
                Consulta.Connection = Conextion
                Consulta.CommandText = "SELECT Codigo, RIF, Nombre, Mail, Ciudad, Direccion, Saldo, Estatus FROM PROVEEDOR where ID_PROVEEDOR=" & Id_Proveedor

                Dim Reder As Data.SqlClient.SqlDataReader = Consulta.ExecuteReader()
                If (Reder.Read = True) Then
                    Ventana_Modificar_Proveedor.Codigo.Text = Reder.Item(0).ToString()
                    Ventana_Modificar_Proveedor.Rif.Text = Reder.Item(1).ToString()
                    Ventana_Modificar_Proveedor.Nombre.Text = Reder.Item(2).ToString()
                    Ventana_Modificar_Proveedor.Correo.Text = Reder.Item(3).ToString()
                    Ventana_Modificar_Proveedor.Ciudad.Text = Reder.Item(4).ToString()
                    Ventana_Modificar_Proveedor.Dir.Text = Reder.Item(5).ToString()
                    Ventana_Modificar_Proveedor.Saldo.Text = Reder.Item(6).ToString()
                End If
            Catch e As Data.SqlClient.SqlException
            End Try
        End If

    End Sub



    Public Function Arreglo_Productos(ByVal Arreglo As Array) As String
        Dim myEnumerator As System.Collections.IEnumerator = Arreglo.GetEnumerator()
        Dim Cadena As String = ""
        Dim i As Integer = 0
        Dim cols As Integer = Arreglo.GetLength((Arreglo.Rank - 1))
        While myEnumerator.MoveNext() And CInt(Arreglo.GetValue(i)) <> 0

            If i < cols Then
                If (i <> 0) Then
                    Cadena = Cadena & "," & CStr(Arreglo.GetValue(i))
                Else
                    Cadena = CStr(Arreglo.GetValue(i))
                End If
            Else
                Cadena = CStr(Arreglo.GetValue(i))
            End If
            i += 1
        End While
        Return Cadena
    End Function



    Public Function Mostrar_datagrid(ByVal Arreglo As Array) As Data.DataTable
        Dim Bd As FarmaciaSJDataSet = New FarmaciaSJDataSet
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter = New FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim cn As Data.SqlClient.SqlConnection = New Data.SqlClient.SqlConnection(Detalle.Connection.ConnectionString)
        Dim sql As String = "SELECT CODIGO_DE_BARRAS as CODIGO, NOMBRE, DESCRIPCION FROM PRODUCTO WHERE ID_PRODUCTO IN (" & Arreglo_Productos(Arreglo) & ")"
        Dim da As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sql, cn)
        Dim Table As Data.DataTable = New Data.DataTable("Productos_asociados")
        da.Fill(Table)
        Return Table
    End Function



    Public Function Buscar_Rif(ByVal RIF As String) As Data.SqlClient.SqlDataReader
        Dim Proveedor As FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Dim Conextion As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Proveedor = New FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Conextion = Proveedor.Connection
        Conextion.Open()
        Consulta = New Data.SqlClient.SqlCommand
        Consulta.Connection = Conextion
        Consulta.CommandText = "SELECT     ID_PROVEEDOR,Codigo, RIF, Nombre, Mail, Ciudad, Direccion FROM         PROVEEDOR WHERE     (Estatus = 'ACTIVO') AND (RIF = '" & RIF & "')"
        Reder = Consulta.ExecuteReader
        Return Reder
    End Function
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




End Class