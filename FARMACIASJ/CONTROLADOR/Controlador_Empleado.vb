Public Class Controlador_Empleado
    Public Sub Buscando_Empleado(ByVal Cedula As String, ByVal Ventana As Despedir_Empleado)
        Dim Modelo As Empleado = New Empleado
        Dim Id_Empleado As Integer = Modelo.Existe_Empleado(Cedula)
        Try
            If Id_Empleado > 0 Then
                Dim ConsultaBD As Data.SqlClient.SqlDataReader
                ConsultaBD = Modelo.Buscar_Info_Empleado(ConsultaBD, Id_Empleado)
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

    Public Sub Despedir_Empleado(ByVal Cedula As String, ByVal Justificacion As String, ByVal Ventana As Despedir_Empleado)
        Dim Modelo As Empleado = New Empleado
        Dim Id_Empleado As Integer = Modelo.Existe_Empleado(Cedula)
        Try
            If Id_Empleado > 0 Then
                Try
                    Dim Id_Historico_Empleado As Integer = Modelo.Id_Ultimo_Cargo(Id_Empleado)
                    If Id_Historico_Empleado > 0 Then
                        If Modelo.Despedir_Empleado_Ultimo_Cargo(Id_Historico_Empleado, Justificacion) Then
                            MsgBox("El empleado ha sido despedido", MsgBoxStyle.OkOnly, "Información")
                            Ventana.Close()
                        Else
                            MsgBox("Error al despedir empleado", MsgBoxStyle.OkOnly, "Error")
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
