Public Class Controlador_Cliente
    Public Venta As Realizar_Venta
    Public Pedido As Registrar_Pedido
    Public condicion As Integer
    Public Sub Buscar_Cliente(ByVal Numero As String, ByVal Venta As Realizar_Venta)
        Dim Cliente As Cliente
        Dim IngresarCliente As IngresarCliente
        Dim a As Integer
        Cliente = New Cliente
        a = Cliente.buscar_identidad(Numero, Venta)
        If (a = 1) Then
            If (MsgBox("EL Cliente no existe en la BD, ¿Desea Ingresarlo?", MsgBoxStyle.YesNo, "Error") = MsgBoxResult.Yes) Then
                IngresarCliente = New IngresarCliente
                IngresarCliente.MdiParent = Venta.MdiParent
                If (Numero(0) = Char.Parse("V") Or Numero(0) = Char.Parse("E")) Then
                    IngresarCliente.LNOMBRE.Text = "Nombre"
                    IngresarCliente.LIdentidad.Text = "Cedula"
                    IngresarCliente.NOMBRE.Enabled = True
                    IngresarCliente.RIF.Enabled = False
                    IngresarCliente.TELEFONO.Enabled = True
                    IngresarCliente.DIRECCION.Enabled = True
                    IngresarCliente.LApellido.Visible = True
                    IngresarCliente.APELLIDO.Visible = True
                    IngresarCliente.RIF.MaxLength = 9
                ElseIf (Numero(0) = Char.Parse("J") Or Numero(0) = Char.Parse("G")) Then
                    IngresarCliente.LNOMBRE.Text = "Razon Social"
                    IngresarCliente.LIdentidad.Text = "Rif"
                    IngresarCliente.NOMBRE.Enabled = True
                    IngresarCliente.RIF.Enabled = False
                    IngresarCliente.TELEFONO.Enabled = True
                    IngresarCliente.DIRECCION.Enabled = True
                    IngresarCliente.LApellido.Visible = False
                    IngresarCliente.APELLIDO.Visible = False
                    IngresarCliente.RIF.MaxLength = 10
                ElseIf (Numero(0) = Char.Parse("P")) Then
                    IngresarCliente.LNOMBRE.Text = "Nombre"
                    IngresarCliente.LIdentidad.Text = "PASSAPORTE"
                    IngresarCliente.NOMBRE.Enabled = True
                    IngresarCliente.RIF.Enabled = False
                    IngresarCliente.TELEFONO.Enabled = True
                    IngresarCliente.DIRECCION.Enabled = True
                    IngresarCliente.LApellido.Visible = True
                    IngresarCliente.APELLIDO.Visible = True
                    IngresarCliente.RIF.MaxLength = 12
                End If
                IngresarCliente.RIF.Text = Numero
                condicion = 1
                Me.Venta = Venta
                IngresarCliente.Cliente = Me
                IngresarCliente.Show()
            End If
        ElseIf (a = 2) Then
            MsgBox("Se presentaron problemas en la conexion con la Base de Datos, intente de nuevo", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Public Function Ingresar_Cliente(ByVal Numero As String, ByVal Nombre As String, ByVal Apellido As String, ByVal Telefono As String, ByVal Direccion As String) As Boolean
        Dim Cliente As Cliente
        Dim a As Boolean
        Cliente = New Cliente

        a = Cliente.Ingresar(Nombre, Apellido, Numero, Telefono, Direccion)
        If (a = True) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function Ingresar_Cliente(ByVal Numero As String, ByVal Nombre As String, ByVal Telefono As String, ByVal Direccion As String) As Boolean
        Dim Cliente As Cliente
        Dim a As Boolean
        Cliente = New Cliente

        a = Cliente.Ingresar(Nombre, Numero, Telefono, Direccion)
        If (a = True) Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
