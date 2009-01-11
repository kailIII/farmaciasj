Public Class Buscar_Proveedor

    Private Sub Boton_Codigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Codigo.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        Controlador_Proveedor.Buscando_Proveedor(Codigo.Text, True, Me)

    End Sub

    Private Sub Boton_Rif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Rif.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        Controlador_Proveedor.Buscando_Proveedor(Rif.Text, False, Me)
        
    End Sub

    Private Sub Rif_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Rif.KeyPress
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controlador_Proveedor.Buscando_Proveedor(Rif.Text, False, Me)
        End If
    End Sub

    Private Sub Rif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rif.TextChanged
        If (Rif.Text.Length = 1) Then
            If (Rif.Text(0) = Char.Parse("J") Or Rif.Text(0) = Char.Parse("G")) Then
                Rif.MaxLength = 10
            ElseIf (Rif.Text(0) = Char.Parse("V") Or Rif.Text(0) = Char.Parse("E")) Then
                Rif.MaxLength = 9
            ElseIf (Rif.Text(0) = Char.Parse("P")) Then
                Rif.MaxLength = 12
            Else
                Rif.Text = ""
            End If
        ElseIf (Rif.Text.Length > 1) Then
            Dim count As Integer
            count = Rif.Text.Length - 1
            If (Char.IsDigit(Rif.Text(count)) = False) Then
                Dim A As String
                A = Rif.Text
                A = A.Substring(0, count)
                Rif.Text = A
                Rif.SelectionStart = Rif.Text.Length
            End If
        End If
    End Sub

End Class