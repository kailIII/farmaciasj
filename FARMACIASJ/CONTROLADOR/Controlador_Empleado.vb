Public Class Controlador_Empleado
    Public Sub Buscando_Empleado(ByVal Cedula As String, ByVal Ventana As Despedir_Empleado)
        Dim Modelo As Empleado = New Empleado
        Dim Id_Empleado As Integer = Modelo.Existe_Empleado(Cedula)
        Try
            If Id_Empleado > 0 Then
                Dim ConsultaBD As Data.SqlClient.SqlDataReader
                ConsultaBD = Modelo.Buscar_Info_Empleado(ConsultaBD, Id_Empleado, False)
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
            MsgBox("El empleado no posee ningún cargo asignado", MsgBoxStyle.OkOnly, "Error")
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
                    '  While (Ventana_Asignar_Cargo.Contratado = False)

                    Ventana_Asignar_Cargo.Show()
                    Ventana_Asignar_Cargo.Cedula.Text = Ventana.Cedula.Text
                    Ventana_Asignar_Cargo.Nombres.Text = Ventana.Nombre.Text & " " & Ventana.Apellido.Text
                    Ventana_Asignar_Cargo.Cargo.Enabled = True
                    Ventana_Asignar_Cargo.Sueldo.Enabled = True
                    Ventana_Asignar_Cargo.Cedula.Enabled = False
                    Ventana_Asignar_Cargo.Buscando.Enabled = False

                    Ventana_Asignar_Cargo.Registrando.Enabled = True
                    Ventana_Asignar_Cargo.Id_Empleado = Id_Empleado_Nuevo

                    Ventana.Nombre.Enabled = False
                    Ventana.Apellido.Enabled = False
                    Ventana.Telefono.Enabled = False
                    Ventana.Correo.Enabled = False
                    Ventana.Contratando.Enabled = False


                    Ventana_Asignar_Cargo.Cargo.Focus()
                    ' End While

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Function Modificar_Cargo_Sueldo(ByVal Id_Empleado_Nuevo As Integer, ByVal Cargo As String, ByVal Sueldo As String) As Boolean
        Dim Modelo As Empleado = New Empleado
        Dim Validacion As Validaciones_Generales = New Validaciones_Generales
        If (Validacion.Tamano_Aceptable_Cadena(Sueldo, 8, "Introduzca un sueldo válido")) Then
            If Modelo.Modificar_Historico_Empleado(Id_Empleado_Nuevo, Cargo, CDbl(Sueldo), False) Then
                MsgBox("El Empleado fue contratado exitosamente!.", MsgBoxStyle.OkOnly, "Información")
                'Venatana modificar sueldo
                Return True
            End If
        End If
        Return False
    End Function


    Public Sub Modificar_Cargo_Sueldo(ByVal Cedula As String, ByVal Ventana As Modificar_Sueldo)
        Dim Modelo As Empleado = New Empleado
        Dim Validacion As Validaciones_Generales = New Validaciones_Generales
        Dim Id_Empleado As Integer = Modelo.Existe_Empleado(Cedula)
        Dim Id_Historico_Empleado As Integer = Modelo.Id_Ultimo_Cargo(Id_Empleado)
        If Id_Historico_Empleado > 0 Then
            If (Validacion.Tamano_Aceptable_Cadena(Ventana.Sueldo.Text, 8, "Introduzca un sueldo válido")) Then
                If Modelo.Modificar_Historico_Empleado(Id_Empleado, Ventana.Cargo.Text, CDbl(Ventana.Sueldo.Text), True) Then
                    MsgBox("Se le asignó un sueldo al empleado", MsgBoxStyle.OkOnly, "Información")
                    Borrado_Texto_Ventana_Modificar_Sueldo(Ventana)
                End If
            End If
        Else
            If (Validacion.Tamano_Aceptable_Cadena(Ventana.Sueldo.Text, 8, "Introduzca un sueldo válido")) Then
                If Modelo.Modificar_Historico_Empleado(Id_Empleado, Ventana.Cargo.Text, CDbl(Ventana.Sueldo.Text), False) Then
                    MsgBox("Se le ha asignado un cargo y un sueldo al empleado", MsgBoxStyle.OkOnly, "Información")
                    Borrado_Texto_Ventana_Modificar_Sueldo(Ventana)
                End If
            End If
        End If
    End Sub

    Public Sub Borrado_Texto_Ventana_Modificar_Sueldo(ByVal Ventana As Modificar_Sueldo)
        Ventana.Nombres.Text = ""
        Ventana.Cargo.Text = ""
        Ventana.Sueldo.Text = ""
        Ventana.Cedula.Focus()
        Ventana.Registrando.Enabled = False
        Ventana.Cedula.Text = ""
    End Sub



    Public Sub Buscando_Empleado(ByVal Cedula As String, ByVal Ventana As Modificar_Sueldo)
        Dim Modelo As Empleado = New Empleado
        Dim Id_Empleado As Integer = Modelo.Existe_Empleado(Cedula)
        Try
            If Id_Empleado > 0 Then
                Dim ConsultaBD As Data.SqlClient.SqlDataReader
                ConsultaBD = Modelo.Buscar_Info_Empleado(ConsultaBD, Id_Empleado, False)
                Ventana.Nombres.Text = ConsultaBD.Item(0).ToString & " " & ConsultaBD.Item(1).ToString
                Dim Cargo_Temporal As String = ConsultaBD.Item(5).ToString
                Dim Sueldo_Temporal As String = ConsultaBD.Item(6).ToString
                ConsultaBD.Close()
                Dim Id_Historico_Empleado As Integer = Modelo.Id_Ultimo_Cargo(Id_Empleado)
                If Id_Historico_Empleado > 0 Then
                    ' cambio de sueldo
                    Ventana.Cargo.Text = Cargo_Temporal
                    Ventana.Sueldo.Text = Sueldo_Temporal
                    Ventana.Cargo.Enabled = False
                    Ventana.Sueldo.Enabled = True
                    Ventana.Sueldo.Focus()
                    Ventana.Registrando.Enabled = True
                End If
            Else
                Ventana.Nombres.Text = ""
                Ventana.Cargo.Text = ""
                Ventana.Sueldo.Text = ""
                MsgBox("El empleado no existe", MsgBoxStyle.OkOnly, "Error")
                Ventana.Cedula.Focus()
                Ventana.Registrando.Enabled = False
            End If
        Catch ex As Exception
            If Id_Empleado > 0 Then
                ' se asigna cargo y sueldo. (INGRESAR)
                Dim ConsultaBD As Data.SqlClient.SqlDataReader
                ConsultaBD = Modelo.Buscar_Info_Empleado(ConsultaBD, Id_Empleado, True)
                Ventana.Nombres.Text = ConsultaBD.Item(0).ToString & " " & ConsultaBD.Item(1).ToString
                MsgBox("El empleado no tiene asignado ningún cargo ni sueldo", MsgBoxStyle.OkOnly, "Información")
                Ventana.Sueldo.Enabled = True
                Ventana.Cargo.Enabled = True
                Ventana.Cargo.Focus()
                Ventana.Registrando.Enabled = True
            Else
                Ventana.Cedula.Focus()
                Ventana.Registrando.Enabled = False
                MsgBox("El empleado no existe", MsgBoxStyle.OkOnly, "Error")
            End If
        End Try
    End Sub

    'Abriendo Ventanas desde la barra de menú del administrador:

    Public Sub Abrir_Ventana_Contratar_Empleado(ByVal Padre As Windows.Forms.Form)
        Dim Ventana As Contratar_Empleado
        Ventana = New Contratar_Empleado
        Ventana.MdiParent = Padre
        Ventana.Show()
    End Sub

    Public Sub Abrir_Ventana_Despedir_Empleado(ByVal Padre As Windows.Forms.Form)
        Dim Ventana As Despedir_Empleado
        Ventana = New Despedir_Empleado
        Ventana.MdiParent = Padre
        Ventana.Show()
    End Sub


    Public Sub Abrir_Ventana_Modificar_Sueldo(ByVal Padre As Windows.Forms.Form)
        Dim Ventana As Modificar_Sueldo
        Ventana = New Modificar_Sueldo
        Ventana.MdiParent = Padre
        Ventana.Show()
    End Sub



End Class
