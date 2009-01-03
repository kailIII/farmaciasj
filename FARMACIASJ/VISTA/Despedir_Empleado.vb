Public Class Despedir_Empleado

    Private Sub Buscando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado
        Controlador.Buscando_Empleado(Me.Cedula.Text, Me)

    End Sub

    Private Sub Eliminando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado

    End Sub
End Class