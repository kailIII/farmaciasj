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
            Controlador.Modificar_Cargo_Sueldo(Me.Cedula.Text, Me)
         
        End If
    End Sub



    Private Sub Buscando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscando.Click
        Dim Controlador As Controlador_Empleado = New Controlador_Empleado
        Controlador.Buscando_Empleado(Me.Cedula.Text, Me)
    End Sub

    Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cedula.KeyPress

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador As Controlador_Empleado = New Controlador_Empleado
            Controlador.Buscando_Empleado(Me.Cedula.Text, Me)
        End If
    End Sub

    Private Sub Cedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Cedula.Text.Length = 1) Then
            If (Cedula.Text(0) = Char.Parse("J") Or Cedula.Text(0) = Char.Parse("G")) Then
                Cedula.MaxLength = 10
            ElseIf (Cedula.Text(0) = Char.Parse("V") Or Cedula.Text(0) = Char.Parse("E")) Then
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