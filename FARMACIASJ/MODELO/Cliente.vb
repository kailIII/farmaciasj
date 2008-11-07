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

End Class
