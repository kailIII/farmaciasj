Public Class Contratar_Empleado

    Private Sub Contratando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contratando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado
        Controlador.Contratar_Empleado(Me.Cedula.Text, Me)

    End Sub

    Private Sub Registrando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registrando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado

    End Sub
End Class