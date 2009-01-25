Public Class Eliminar_proveedor
    Private Sub Rif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rif.TextChanged
        If (Me.Rif.Text.Length = 1) Then
            If (Me.Rif.Text(0) = Char.Parse("J") Or Me.Rif.Text(0) = Char.Parse("G")) Then
                Me.Rif.MaxLength = 10
            ElseIf (Me.Rif.Text(0) = Char.Parse("V") Or Me.Rif.Text(0) = Char.Parse("E")) Then
                Me.Rif.MaxLength = 9
            ElseIf (Me.Rif.Text(0) = Char.Parse("P")) Then
                Me.Rif.MaxLength = 12
            Else
                Me.Rif.Text = ""
            End If
        ElseIf (Me.Rif.Text.Length > 1) Then
            Dim count As Integer
            count = Me.Rif.Text.Length - 1
            If (Char.IsDigit(Me.Rif.Text(count)) = False) Then
                Dim A As String
                A = Me.Rif.Text
                A = A.Substring(0, count)
                Me.Rif.Text = A
                Me.Rif.SelectionStart = Me.Rif.Text.Length
            End If
        End If
    End Sub



    Private Sub Rif_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Rif.KeyPress
        Dim Controlador As Controlador_Proveedor = New Controlador_Proveedor
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then

            If Controlador.Buscando_Info_Para_Eliminar(Me, Me.Rif.Text) Then
                Me.Eliminar.Enabled = True
            Else
                Me.Eliminar.Enabled = False
            End If

        End If
    End Sub



    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        Dim Controlador As Controlador_Proveedor = New Controlador_Proveedor
        Controlador.Eliminando_Proveedor(Me, Me.Rif.Text)
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim Controlador As Controlador_Proveedor = New Controlador_Proveedor
        If Controlador.Buscando_Info_Para_Eliminar(Me, Me.Rif.Text) Then
            Me.Eliminar.Enabled = True
        Else
            Me.Eliminar.Enabled = False
        End If

    End Sub
End Class