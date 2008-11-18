Public Class Controlador_Proveedor

    Public Sub Ingresando_Proveedor(ByVal Arreglo As Array, ByVal Ventana As Ingresar_Proveedor, ByVal Codigo As String, ByVal Rif As String, ByVal Nombre As String, ByVal Correo As String, ByVal Dir As String, ByVal Ciudad As String, ByVal Saldo As Double)

        Dim Proveedor_x As Proveedor = New Proveedor

        If (Ventana.Boton_Registrar.Text = "Modificar") Then
            Estado_modificar(Ventana, True)
        Else
            If (Proveedor_x.Ingresar_Proveedor(Codigo, Rif, Nombre, Correo, Dir, Ciudad, Saldo)) Then
                MsgBox("El proveedor se registró con éxito.", MsgBoxStyle.OkOnly, "Aviso")
                If Not Proveedor_x.Ingresar_Proveedor_Producto(Arreglo) Then
                    MsgBox("No se pudo registrar el producto a este Proveedor", MsgBoxStyle.OkOnly, "Error")
                End If
            Else
                MsgBox("No se pudo registrar el proveedor", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Public Sub Actualizar_Datagrid(ByVal Ventana As Ingresar_Proveedor, ByVal Arreglo As Array)
        Dim Proveedor_x As Proveedor = New Proveedor
        Ventana.Productos_asociados.DataSource = Proveedor_x.Mostrar_datagrid(Arreglo)
        Ventana.Productos_asociados.Update()
    End Sub

    Public Function Actualiza_Arreglo(ByVal Numero As Integer, ByVal Arreglo As Array) As Array

        Dim myEnumerator As System.Collections.IEnumerator = Arreglo.GetEnumerator()
        Dim Cadena As String = ""
        Dim i As Integer = 0
        Dim cols As Integer = Arreglo.GetLength((Arreglo.Rank - 1))
        If CInt(Arreglo.GetValue(i)) = 0 Then
            Arreglo.SetValue(Numero, 0)
        Else
            While myEnumerator.MoveNext()
                If (CInt(Arreglo.GetValue(i)) = 0) Then
                    Arreglo.SetValue(Numero, i)
                    Return Arreglo
                End If
                i += 1
            End While
        End If
        Return Arreglo
    End Function




    Public Function Productos_Relacionados(ByVal Codigo As String, ByVal Arreglo As Array) As Boolean

        Dim Producto_x As Producto = New Producto
        If (Producto_x.idProductos(Codigo) > 0) Then
            Actualiza_Arreglo(Producto_x.idProductos(Codigo), Arreglo)
            Return True
        Else
            MsgBox("El código suministrado es inválido", MsgBoxStyle.OkOnly, "Error")
        End If
        Return False
    End Function



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

        If (CBool(Proveedor_x.Existe_Proveedor(Cadena, Codigo))) Then
            Ventana_Modificar_Proveedor.Show()
            Proveedor_x.Buscar_Proveedor(Cadena, Codigo, Ventana_Modificar_Proveedor)
            Estado_modificar(Ventana_Modificar_Proveedor, False)

            'Ventana.Close()
        ElseIf (CBool(Proveedor_x.Existe_Proveedor(Cadena, Codigo))) Then
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


    Public Sub Buscar_Rif(ByVal RIF As String, ByVal Compra As Registrar_Compra)
        Dim Proveedor As Proveedor
        Dim Reder As Data.SqlClient.SqlDataReader
        Proveedor = New Proveedor
        Reder = Proveedor.Buscar_RIF(RIF)
        If (Reder.HasRows = True) Then
            If (Reder.Read = True) Then
                Compra.ID_Proveedor()
                Compra.RIF_PROVEEDOR.Text()
                Compra.CODIGO.Text()
                Compra.NOMBRE_PROVEEDOR.Text()
                Compra.Direccion.Text()
                Compra.CIUDAD.Text()


            End If
        End If
    End Sub


End Class
