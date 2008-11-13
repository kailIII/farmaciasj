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
                Return Reder.Item(0).ToString
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
                    Ventana_Modificar_Proveedor.Codigo.Text = Reder.Item(0).ToString
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


End Class




