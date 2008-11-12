Public Class Ingresar_Proveedor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        Controlador_Proveedor.Ingresando_Proveedor(Codigo.Text, Rif.Text, Nombre.Text, Correo.Text, Dir.Text, Ciudad.Text, Saldo.Text)

    End Sub
End Class