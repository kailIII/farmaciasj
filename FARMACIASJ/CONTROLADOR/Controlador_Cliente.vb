Public Class Controlador_Cliente


    Public Sub Buscar_Cliente(ByVal Tipo_Identidad As String, ByVal Numero As String, ByVal Venta As Realizar_Venta)
        Dim Cliente As Cliente
        Dim a As Integer
        Cliente = New Cliente
        a = Cliente.buscar_identidad(Tipo_Identidad, Numero, Venta)
        If (a = 1) Then
            If (MsgBox("EL Cliente no existe en la BD, ¿Desea Ingresarlo?", MsgBoxStyle.YesNo, "Error") = MsgBoxResult.Yes) Then
                Venta.ID_Cliente = -1
                Venta.Nombre.Enabled = True
                Venta.Apellido.Enabled = True
                Venta.Telefono.Enabled = True
                Venta.Direccion.Enabled = True
            End If
        ElseIf (a = 2) Then
            MsgBox("Se presentaron problemas en la conexion con la Base de Datos, intente de nuevo", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
End Class
