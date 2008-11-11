Public Class Cliente
    Public BasedeDatos As FarmaciaSJDataSet

    Public Function Ingresar(ByVal Nombre As String, ByVal Apellido As String, ByVal Tipo_Identidad As String, ByVal Documento_Identidad As String, ByVal Telefono As String, ByVal Direccion As String) As Boolean
        Dim ClienteTableAdapter As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            ClienteTableAdapter = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            ClienteTableAdapter.Insert(Tipo_Identidad, Documento_Identidad, Nombre, Apellido, Telefono, Direccion)
            ClienteTableAdapter.Update(BasedeDatos.CLIENTE)
            BasedeDatos.AcceptChanges()
            Return True
        Catch err As ArgumentNullException
            Return False
        End Try
    End Function

    Public Function buscar_identidad(ByVal Tipo As String, ByVal Numero As String, ByVal Venta As Realizar_Venta) As Integer
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
            Consulta.CommandText = "SELECT     ID_CLIENTE, TIPO_IDENTIDAD, DOCUMENTO_IDENTIDAD, NOMBRE, APELLIDO, TELEFONO, DIRECCION FROM         CLIENTE WHERE     (TIPO_IDENTIDAD = '" & Tipo & "') AND (DOCUMENTO_IDENTIDAD = '" & Numero & "')"
            Reder = Consulta.ExecuteReader()
            If (Reder.Read = True) Then
                Venta.ID_Cliente = Reder.Item(0).ToString
                Venta.Tipo_Identidad.Text = Reder.Item(1).ToString()
                Venta.Identidad.Text = Reder.Item(2).ToString()
                Venta.Nombre.Text = Reder.Item(3).ToString()
                Venta.Apellido.Text = Reder.Item(4).ToString()
                Venta.Telefono.Text = Reder.Item(5).ToString()
                Venta.Direccion.Text = Reder.Item(6).ToString()
                Return 0
            Else
                Return 1
            End If
        Catch e As Data.SqlClient.SqlException
            Return 2
        End Try
    End Function

End Class
