Public Class Aplicar_Impuesto
    Public Controlador As Controlador_Impuesto
    Public Contador As Integer
    Private Sub Nombre_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Nombre.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controlador = New Controlador_Impuesto(Nombre.Text, Me)
            Controlador.Existe_Impuesto()
        End If
    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        Me.Valor.Enabled = True
        Me.Justificacion.Enabled = True
        Me.Modificar.Visible = False
        Contador = 2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Contador = 1) Then
            Dim Lineas() As Integer
            Controlador = New Controlador_Impuesto(Me.Nombre.Text, Me.Descripcion.Text, Double.Parse(Me.Valor.Text), "Creacion del Impuesto", Lineas, Me)
        ElseIf (Contador = 2) Then
            Me.Controlador.set_Justificacion(Me.Justificacion.Text)
            Me.Controlador.set_Valor(Double.Parse(Me.Valor.Text))
        End If
        Controlador.ir_a_Lineas()
    End Sub
End Class