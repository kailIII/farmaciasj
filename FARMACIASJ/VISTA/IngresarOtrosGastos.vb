Public Class IngresarOtrosGastos
    Private contador As Integer = 0
    Private Sub Monto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Monto.TextChanged
        If (Me.Monto.Text.Length = 1) Then
            If (Char.IsDigit(Me.Monto.Text(0)) = False) Then
                Me.Monto.Text = ""
            End If
        ElseIf (Me.Monto.Text.Length > 1) Then
            Dim count As Integer = Me.Monto.Text.Length - 1
            If (Char.IsDigit(Me.Monto.Text(count)) = False) Then
                If (Char.Parse(",") <> Me.Monto.Text(count) Or contador > 0) Then
                    Dim A As String
                    A = Monto.Text
                    A = A.Substring(0, count)
                    Monto.Text = A
                    Monto.SelectionStart = Monto.Text.Length
                Else
                    contador = 1
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Gastos As Controlador_OtrosGastos

        Gastos = New Controlador_OtrosGastos(Double.Parse(Me.Monto.Text), Me.Fecha.Value, Me.Descripcion.Text, Me)
        Gastos.Insertar_Otro_Gasto()
    End Sub
End Class