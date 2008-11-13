Public Class Buscar_Proveedor

    Private Sub Boton_Codigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Codigo.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        Controlador_Proveedor.Buscando_Proveedor(Codigo.Text, True, Me)

    End Sub

    Private Sub Boton_Rif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Rif.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        Controlador_Proveedor.Buscando_Proveedor(Rif.Text, False, Me)
    End Sub
End Class