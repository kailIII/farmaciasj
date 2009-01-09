Public Class Contratar_Empleado

    Private Sub Contratando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contratando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado
        Controlador.Contratar_Empleado(Me.Cedula.Text, Me)

    End Sub

    Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cedula.TextChanged
        If (Cedula.Text.Length = 1) Then
            If (Cedula.Text(0) = Char.Parse("V") Or Cedula.Text(0) = Char.Parse("E")) Then
                Cedula.MaxLength = 9
            ElseIf (Cedula.Text(0) = Char.Parse("P")) Then
                Cedula.MaxLength = 12
            Else
                Cedula.Text = ""
            End If
        ElseIf (Cedula.Text.Length > 1) Then
            Dim count As Integer
            count = Cedula.Text.Length - 1
            If (Char.IsDigit(Cedula.Text(count)) = False) Then
                Dim A As String
                A = Cedula.Text
                A = A.Substring(0, count)
                Cedula.Text = A
                Cedula.SelectionStart = Cedula.Text.Length
            End If
        End If
    End Sub
End Class