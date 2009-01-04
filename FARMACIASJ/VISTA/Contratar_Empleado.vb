Public Class Contratar_Empleado

    Private Sub Contratando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contratando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado
        Controlador.Contratar_Empleado(Me.Cedula.Text, Me)

    End Sub

    Private Sub Registrando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registrando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado

    End Sub

    'Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cedula.KeyPress, Cedula.TextChanged
    '    If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
    '        Dim Controlador_Venta_x As Controlador_Venta
    '        Controlador_Venta_x = New Controlador_Venta
    '        Controlador_Venta_x.Buscar_Info_Factura(Me.Cedula.Text, Me)
    '    End If
    'End Sub

End Class