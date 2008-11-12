Public Class Elegir_Lote
    Public ControladorP As Controlador_Producto
    Private Sub Lotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lotes.DoubleClick
        ControladorP.Regreso(Me.Lotes.SelectedIndex)
        Me.Close()
    End Sub
End Class