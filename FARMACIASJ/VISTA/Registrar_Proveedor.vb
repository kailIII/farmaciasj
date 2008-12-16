Public Class Registrar_Proveedor

    Public Arreglo As Array = Array.CreateInstance(GetType(Int32), 10)

    Private Sub Boton_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registrar.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        Controlador_Proveedor.Registrando_Proveedor(Arreglo, Me, Codigo.Text, Rif.Text, Nombre.Text, Correo.Text, Dir.Text, Ciudad.Text, Saldo.Text)
        
    End Sub

    Private Sub Cod_producto_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TLF_Numero.KeyPress
        Dim Proveedor_x As Controlador_Proveedor = New Controlador_Proveedor

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            'Si existe el codigo de barras lo deberia insertar en el datagrid
            If (Me.Boton_Registrar.Text = "Registrar") Then

                Proveedor_x.Actualizar_Datagrid(Me, Arreglo)
                Me.TLF_Numero.Text = ""

            End If
        End If
    End Sub

End Class