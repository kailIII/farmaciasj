Public Class Ingresar_Proveedor

    Private Sub Boton_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registrar.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        ' ATENCION
        'Acá pensé ponerle la parte del boton modificar cuando lo accionamos para habilitar los campos
        'pero a la final lo coloqué en controlador
        Controlador_Proveedor.Ingresando_Proveedor(Me, Codigo.Text, Rif.Text, Nombre.Text, Correo.Text, Dir.Text, Ciudad.Text, Saldo.Text)
        ''Me.Close()
    End Sub
End Class