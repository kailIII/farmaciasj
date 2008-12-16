Public Class Modificar_Linea
    Public id_linea As Integer = -1
    Private Sub NombreLinea_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles NombreLinea.KeyPress
        Dim Linea As Controlador_Linea
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Linea = New Controlador_Linea
            Linea.buscar_linea(Me.NombreLinea.Text, Me)
        End If
    End Sub

    Private Sub Modificar_Boton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar_Boton.Click
        Dim Linea As New Controlador_Linea
        Linea.Modificar_Linea(id_linea, Me.DescripcionLinea.Text, Me.DescMax.Text, Me.MargenUtil.Text, Me)
    End Sub
End Class