Public Class Cliente
    Public BasedeDatos As FarmaciaSJDataSet

    Public Sub Ingresar(ByVal Nombre As String, ByVal Apellido As String, ByVal Tipo_cliente As String, ByVal Tipo_Identidad As String, ByVal Documento_Identidad As String, ByVal Telefono As String, ByVal Direccion As String)
        Dim Cliente As FarmaciaSJDataSet.CLIENTEDataTable
        Dim ClienteRow As FarmaciaSJDataSet.CLIENTERow
        Dim ClienteTableAdapter As FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
        Try
            BasedeDatos = New FarmaciaSJDataSet
            Cliente = New FarmaciaSJDataSet.CLIENTEDataTable
            ClienteTableAdapter = New FarmaciaSJDataSetTableAdapters.CLIENTETableAdapter
            ClienteRow = Cliente.NewCLIENTERow()
            ClienteRow.NOMBRE = Nombre
            ClienteRow.APELLIDO = Apellido
            ClienteRow.TIPO_CLIENTE = Tipo_cliente
            ClienteRow.TIPO_IDENTIDAD = Tipo_Identidad
            ClienteRow.DOCUMENTO_IDENTIDAD = Documento_Identidad
            ClienteRow.TELEFONO = Telefono
            ClienteRow.DIRECCION = Direccion
            Cliente.AddCLIENTERow(ClienteRow)
            ClienteTableAdapter.Update(BasedeDatos.CLIENTE)
            MsgBox("El Cliente se Agrego con Exito", MsgBoxStyle.OkOnly, "Aviso")
        Catch err As ArgumentNullException
            MsgBox("El Cliente no se pudo Agregar", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

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
