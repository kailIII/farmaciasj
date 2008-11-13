Public Class Controlador_Proveedor

    Public Sub Ingresando_Proveedor(ByVal Ventana As Ingresar_Proveedor, ByVal Codigo As String, ByVal Rif As String, ByVal Nombre As String, ByVal Correo As String, ByVal Dir As String, ByVal Ciudad As String, ByVal Saldo As Double)

        Dim Proveedor_x As Proveedor = New Proveedor
        If (Ventana.Boton_Registrar.Text = "Modificar") Then
            Estado_modificar(Ventana, True)
        Else
            If (Proveedor_x.Ingresar_Proveedor(Codigo, Rif, Nombre, Correo, Dir, Ciudad, Saldo)) Then
                MsgBox("El proveedor se registró con éxito.", MsgBoxStyle.OkOnly, "Aviso")
            Else
                MsgBox("No se pudo registrar el proveedor", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Public Sub Estado_modificar(ByVal Ventana_Modificar_Proveedor As Ingresar_Proveedor, ByVal Estado As Boolean)
        Ventana_Modificar_Proveedor.Codigo.Enabled = Estado
        Ventana_Modificar_Proveedor.Rif.Enabled = Estado
        Ventana_Modificar_Proveedor.Nombre.Enabled = Estado
        Ventana_Modificar_Proveedor.Correo.Enabled = Estado
        Ventana_Modificar_Proveedor.Dir.Enabled = Estado
        Ventana_Modificar_Proveedor.Ciudad.Enabled = Estado
        Ventana_Modificar_Proveedor.Saldo.Enabled = Estado
        If (Estado) Then
            Ventana_Modificar_Proveedor.Boton_Registrar.Text = "Registrar"
        Else
            Ventana_Modificar_Proveedor.Boton_Registrar.Text = "Modificar"
        End If
    End Sub


    Public Sub Buscando_Proveedor(ByVal Cadena As String, ByVal Codigo As Boolean, ByVal Ventana As Buscar_Proveedor)

        Dim Proveedor_x As Proveedor = New Proveedor
        Dim Ventana_Modificar_Proveedor As Ingresar_Proveedor = New Ingresar_Proveedor

        If (Proveedor_x.Existe_Proveedor(Cadena, Codigo)) Then
            Ventana_Modificar_Proveedor.Show()
            Proveedor_x.Buscar_Proveedor(Cadena, Codigo, Ventana_Modificar_Proveedor)
            Estado_modificar(Ventana_Modificar_Proveedor, False)

            'Ventana.Close()
        ElseIf (Proveedor_x.Existe_Proveedor(Cadena, Codigo)) Then
            Ventana_Modificar_Proveedor.Show()
            Proveedor_x.Buscar_Proveedor(Cadena, Codigo, Ventana_Modificar_Proveedor)
            Estado_modificar(Ventana_Modificar_Proveedor, False)
            'Ventana.Close()
        Else
            If Codigo = True Then
                MsgBox("El Código introducido es inválido o no existe", MsgBoxStyle.OkOnly, "Error")
            Else
                MsgBox("El RIF introducido es inválido o no existe", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub


End Class
