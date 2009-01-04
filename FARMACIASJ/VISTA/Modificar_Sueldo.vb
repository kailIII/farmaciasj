Public Class Modificar_Sueldo
    Public Id_Empleado As Integer = 0


    Private Sub Registrando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registrando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado



        If Id_Empleado > 0 Then
            ' EN caso de uso donde se llama a esta ventana para asignarle 
            ' un sueldo a alguien que se inscribiendo
            Controlador.Modificar_Cargo_Sueldo(Id_Empleado, Me.Cargo.Text, Me.Sueldo.Text)
            Me.Close()

        Else
            'En caso de uso Actual, Solo Modificar Sueldo y/o Cargo

        End If
    End Sub
End Class