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
                condicion = 1
                IngresarCliente.Cliente = Me
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
