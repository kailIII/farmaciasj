Public Class Controlador_Proveedor

    Public Sub Ingresando_Proveedor(ByVal Arreglo As Array, ByVal Ventana As Ingresar_Proveedor, ByVal Codigo As String, ByVal Rif As String, ByVal Nombre As String, ByVal Correo As String, ByVal Dir As String, ByVal Ciudad As String, ByVal Saldo As Double)

        Dim Proveedor_x As Proveedor = New Proveedor

        If (Ventana.Boton_Registrar.Text = "Modificar") Then

            Estado_modificar(Ventana, True, True)

            'Actualizar_Datagrid(Ventana, Proveedor_x.Existe_Proveedor(Codigo, True))

        ElseIf (Ventana.Boton_Registrar.Text = "Guardar") Then
            If (Proveedor_x.Actualizar_Proveedor(Codigo, Rif, Nombre, Correo, Dir, Ciudad, Saldo)) Then
                MsgBox("El proveedor se actualizó con éxito.", MsgBoxStyle.OkOnly, "Aviso")

                Ventana.Close()
            Else
                MsgBox("No se pudo registrar el proveedor", MsgBoxStyle.OkOnly, "Error")
            End If
        Else
            If (Proveedor_x.Ingresar_Proveedor(Codigo, Rif, Nombre, Correo, Dir, Ciudad, Saldo)) Then
                MsgBox("El proveedor se registró con éxito.", MsgBoxStyle.OkOnly, "Aviso")
                ' Tenemos que buscar el último ID, ya 
                If Not Proveedor_x.Proveedor_Producto(Arreglo) Then
                    MsgBox("No se pudo registrar el producto a este Proveedor", MsgBoxStyle.OkOnly, "Error")
                End If
                Ventana.Close()
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


    Public Sub Actualizar_Datagrid(ByVal Ventana As Ingresar_Proveedor, ByVal Con_Id_De_Proveedor As Integer)
        Dim Proveedor_x As Proveedor = New Proveedor
        Ventana.Productos_asociados.DataSource = Proveedor_x.Mostrar_datagrid(Con_Id_De_Proveedor)
        Ventana.Productos_asociados.Update()
    End Sub

    Public Function Actualiza_Arreglo(ByVal Numero As Integer, ByVal Arreglo As Array) As Array

        Dim myEnumerator As System.Collections.IEnumerator = Arreglo.GetEnumerator()
        Dim i As Integer = 0

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
            ' Posible ingresar directo
            Return True
        Else
            'Aca podria ir el insertar producto...
            MsgBox("El código suministrado es inválido", MsgBoxStyle.OkOnly, "Error")
        End If
        Return False
    End Function


    Public Function Productos_Relacionados(ByVal Codigo As String, ByVal Id_Producto_x_codigo As String) As Boolean
        Dim Proveedor_y As Proveedor = New Proveedor

        Dim Producto_x As Producto = New Producto
        ' If (Producto_x.idProductos(Codigo) > 0) Then
        ' Actualiza_Arreglo(Producto_x.idProductos(Codigo), Arreglo)
        ' Posible ingresar directo

        If Not Proveedor_y.Proveedor_Producto(Proveedor_y.Existe_Proveedor(Codigo, True), Producto_x.idProductos(Id_Producto_x_codigo)) Then
            MsgBox("No se pudo registrar el producto a este Proveedor", MsgBoxStyle.OkOnly, "Error")
            Return False
        End If


        Return True
        'Else
        'Aca podria ir el insertar producto...
        'MsgBox("El código suministrado es inválido", MsgBoxStyle.OkOnly, "Error")
        'End If

    End Function




    Public Sub Estado_modificar(ByVal Ventana_Modificar_Proveedor As Ingresar_Proveedor, ByVal Estado As Boolean, ByVal Buscando As Boolean)
        Ventana_Modificar_Proveedor.Codigo.Enabled = False
        Ventana_Modificar_Proveedor.Rif.Enabled = False
        Ventana_Modificar_Proveedor.Nombre.Enabled = Estado
        Ventana_Modificar_Proveedor.Correo.Enabled = Estado
        Ventana_Modificar_Proveedor.Dir.Enabled = Estado
        Ventana_Modificar_Proveedor.Ciudad.Enabled = Estado
        Ventana_Modificar_Proveedor.Saldo.Enabled = Estado
        Ventana_Modificar_Proveedor.Cod_producto.Enabled = Estado
        Ventana_Modificar_Proveedor.Productos_asociados.Enabled = Estado

        If (Buscando) Then
            Ventana_Modificar_Proveedor.Boton_Registrar.Text = "Guardar"
        Else
            If (Estado) Then
                Ventana_Modificar_Proveedor.Boton_Registrar.Text = "Registrar"
                Ventana_Modificar_Proveedor.Codigo.Enabled = Estado
                Ventana_Modificar_Proveedor.Rif.Enabled = Estado
            Else
                Ventana_Modificar_Proveedor.Boton_Registrar.Text = "Modificar"
            End If
        End If

    End Sub


    Public Sub Buscando_Proveedor(ByVal Cadena As String, ByVal Codigo As Boolean, ByVal Ventana As Buscar_Proveedor)

        Dim Proveedor_x As Proveedor = New Proveedor
        Dim Ventana_Modificar_Proveedor As Ingresar_Proveedor = New Ingresar_Proveedor

        If (CBool(Proveedor_x.Existe_Proveedor(Cadena, Codigo))) Then
            Ventana_Modificar_Proveedor.Show()
            Proveedor_x.Buscar_Proveedor(Cadena, Codigo, Ventana_Modificar_Proveedor)
            Estado_modificar(Ventana_Modificar_Proveedor, False, False)
            Actualizar_Datagrid(Ventana_Modificar_Proveedor, Proveedor_x.Existe_Proveedor(Cadena, True))
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
        Reder = Proveedor.Buscar_Rif(RIF)
        If (Reder.HasRows = True) Then
            If (Reder.Read = True) Then

                'Compra.ID_Proveedor()
                'Compra.RIF_PROVEEDOR.Text()
                'Compra.CODIGO.Text()
                'Compra.NOMBRE_PROVEEDOR.Text()
                'Compra.Direccion.Text()
                'Compra.CIUDAD.Text()


            End If
        End If
    End Sub


End Class
