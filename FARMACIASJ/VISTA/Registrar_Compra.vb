Public Class Registrar_Compra
    Public ID_Proveedor As Integer = -1
    Public ID_Producto As Integer = -1
    Public ID_Linea As Integer = -1
    Public ID_Factura As Integer = -1
    Private Sub RIF_PROVEEDOR_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles RIF_PROVEEDOR.KeyPress
        Dim ControladorP As Controlador_Proveedor
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            ControladorP = New Controlador_Proveedor
            ControladorP.Buscar_Rif(RIF_PROVEEDOR.Text, Me)
        End If
    End Sub

End Class