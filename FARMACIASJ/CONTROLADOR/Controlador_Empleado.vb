Public Class Controlador_Empleado
    Public Sub Buscando_Empleado(ByVal Cedula As String, ByVal Ventana As Despedir_Empleado)
        Dim Modelo As Empleado = New Empleado
        Dim Id_Cedula As Integer = Modelo.Existe_Empleado(Cedula)
        Try
            If Id_Cedula > 0 Then
                Dim ConsultaBD As Data.SqlClient.SqlDataReader
                ConsultaBD = Modelo.Buscar_Info_Empleado(ConsultaBD, Id_Cedula)
                Ventana.Nombres.Text = ConsultaBD.Item(0).ToString & " " & ConsultaBD.Item(1).ToString
                Ventana.Cargo_Actual.Text = ConsultaBD.Item(5).ToString
                Ventana.Justificacion.Enabled = True
                Ventana.Eliminando.Enabled = True
                Ventana.Justificacion.Focus()
                ConsultaBD.Close()
            Else
                Ventana.Cargo_Actual.Text = ""
                Ventana.Nombres.Text = ""
                Ventana.Justificacion.Text = ""
                Ventana.Justificacion.Enabled = False
                Ventana.Eliminando.Enabled = False
                MsgBox("El empleado no existe", MsgBoxStyle.OkOnly, "Error")
                Ventana.Cedula.Focus()
            End If
        Catch ex As Exception
            MsgBox("El empleado no existe", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Public Function Despedir_Empleado(ByVal Cedula As String) As Boolean
        Dim Modelo As Empleado = New Empleado
        Dim Id_Cedula As Integer = Modelo.Existe_Empleado(Cedula)
        Try
            If Id_Cedula > 0 Then


            End If
        Catch ex As Exception

        End Try
    End Function
End Class
