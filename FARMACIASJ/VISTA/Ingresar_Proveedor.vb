Public Class Ingresar_Proveedor

    Public Arreglo As Array = Array.CreateInstance(GetType(Int32), 10)

    Private Sub Boton_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registrar.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        ' ATENCION
        'Acá pensé ponerle la parte del boton modificar cuando lo accionamos para habilitar los campos
        'pero a la final lo coloqué en controlador
        Controlador_Proveedor.Ingresando_Proveedor(Arreglo, Me, Codigo.Text, Rif.Text, Nombre.Text, Correo.Text, Dir.Text, Ciudad.Text, Saldo.Text)
        'Registrando los productos_proveedor

    End Sub





    Private Sub Cod_producto_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
        Dim Proveedor_x As Controlador_Proveedor = New Controlador_Proveedor

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            'Si existe el codigo de barras lo deberia insertar en el datagrid
            'If (Me.Boton_Registrar.Text = "Registrar" And Proveedor_x.Productos_Relacionados(Me.Cod_producto.Text, Arreglo)) Then
            If (Me.Boton_Registrar.Text = "Registrar") Then
                Proveedor_x.Actualizar_Datagrid(Me, Arreglo)
                ' Me.Cod_producto.Text = ""

                'ElseIf Me.Boton_Registrar.Text = "Guardar" And Proveedor_x.Productos_Relacionados(Me.Codigo.Text, Me.Cod_producto.Text) Then
            ElseIf Me.Boton_Registrar.Text = "Guardar" Then
                Dim Proveedor_y As Proveedor = New Proveedor
                Dim Numero As Integer = Proveedor_y.Existe_Proveedor(Me.Codigo.Text, True)
                Proveedor_x.Actualizar_Datagrid(Me, Numero)
                'Me.Cod_producto.Text = ""
            End If
        End If
    End Sub

End Class