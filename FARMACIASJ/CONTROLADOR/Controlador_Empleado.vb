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

    Public Sub Contratar_Empleado(ByVal Cedula As String, ByVal Ventana As Contratar_Empleado)
        Dim Modelo As Empleado = New Empleado
        Dim Id_Empleado As Integer = Modelo.Existe_Empleado(Cedula)
        Try
            If Id_Empleado > 0 Then
                MsgBox("Error, el empleado ya existe.", MsgBoxStyle.OkOnly, "Error")
            Else
                If Modelo.Ingresar_Empleado(Ventana.Cedula.Text, Ventana.Nombre.Text, Ventana.Apellido.Text, Ventana.Telefono.Text, Ventana.Correo.Text) Then
                    Dim Id_Empleado_Nuevo As Integer = Modelo.Existe_Empleado(Cedula)
                    Dim Ventana_Asignar_Cargo As Modificar_Sueldo = New Modificar_Sueldo
                    'Asignar_Cargo.MdiParent = Ventana.MdiParent
                    Ventana_Asignar_Cargo.Show()
                    Ventana_Asignar_Cargo.Cedula.Text = Ventana.Cedula.Text
                    Ventana_Asignar_Cargo.Nombres.Text = Ventana.Nombre.Text & " " & Ventana.Apellido.Text
                    Ventana_Asignar_Cargo.Cargo.Enabled = True
                    Ventana_Asignar_Cargo.Sueldo.Enabled = True
                    Ventana_Asignar_Cargo.Registrando.Enabled = True
                    Ventana_Asignar_Cargo.Id_Empleado = Id_Empleado_Nuevo
                    'Asignar_Cargo.Close()
                    Ventana.Nombre.Enabled = False
                    Ventana.Apellido.Enabled = False
                    Ventana.Telefono.Enabled = False
                    Ventana.Correo.Enabled = False
                    Ventana.Contratando.Enabled = False
                    Ventana.Usuario.Enabled = True
                    Ventana.Contrasena.Enabled = True
                    Ventana.Registrando.Enabled = True
                    Ventana.Usuario.Focus()

                    Ventana_Asignar_Cargo.Cargo.Focus()
                    If Modelo.Existe_Usuario(Ventana.Usuario.Text) > 0 Then
                        MsgBox("Error, el nombre de usuario ya existe.", MsgBoxStyle.OkOnly, "Error")
                    ElseIf (Modelo.Modificar_Usuario_Contrasena(Id_Empleado_Nuevo, Ventana.Usuario.Text, Ventana.Contrasena.Text)) Then
                        MsgBox("El usuario fue registrado exitosamente!.", MsgBoxStyle.OkOnly, "Información")
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function Modificar_Cargo_Sueldo(ByVal Id_Empleado_Nuevo As Integer, ByVal Cargo As String, ByVal Sueldo As String) As Boolean
        Dim Modelo As Empleado = New Empleado
        Dim Validacion As Validaciones_Generales = New Validaciones_Generales
        If (Validacion.Tamano_Aceptable_Cadena(Sueldo, 8, "Introduzca un sueldo válido")) Then
            If Modelo.Modificar_Historico_Empleado(Id_Empleado_Nuevo, Cargo, Sueldo, False) Then
                MsgBox("El Empleado fue contratado exitosamente!.", MsgBoxStyle.OkOnly, "Información")
                'Venatana modificar sueldo

            End If
        End If
    End Function

    Public Sub Modificar_Cargo_Sueldo(ByVal Cedula As String, ByVal Ventana As Modificar_Sueldo)

    End Sub

End Class
