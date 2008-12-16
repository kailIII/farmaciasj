Public Class Controlador_Modificar_compra
    Public Sub habilitar_compra(ByVal todo As Modificar_compra)
        Dim reder, rede As Data.SqlClient.SqlDataReader
        Dim compra As Compra = New Compra
        Dim proveedor As Proveedor = New Proveedor
        Dim cadena As String
        reder = compra.buscar_Compra(todo.factura.Text)
        If reder.Read = True Then
            todo.Fecha_compra.Text = reder.Item(1).ToString
            todo.Vencimiento.Text = reder.Item(2).ToString
            cadena = reder.Item(7).ToString
            rede = proveedor.Buscar_id_proveedor(cadena)
            If rede.Read = True Then
                todo.Proveedor.Text = rede.Item(3).ToString
            End If
        End If
        Try
            todo.PRODUCTOTableAdapter.FillBy(todo.FarmaciaSJDataSet.PRODUCTO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        todo.producto.Enabled = True
    End Sub
    Public Sub habilitar_cantidad(ByVal todo As Modificar_compra)
        todo.Cantidad.Enabled = True
        todo.costo_unidad.Enabled = True
        Dim reder As Data.SqlClient.SqlDataReader
        Dim compra As Compra = New Compra
        Dim consulta As String
        consulta = "select a.cantidad, a.costo_unidad, a.costo_total from detalle_compra as a, producto as b, compra as c where a.id_compra = c.id_compra and a.id_producto = b.id_producto and c.numero_factura_compra= '" & todo.factura.Text & "' and b.nombre = '" & todo.producto.Text & "'"
        reder = compra.general(consulta)
        If reder.Read = True Then
            todo.costo_unidad.Text = reder.Item(1).ToString
            todo.Costo_Total.Text = reder.Item(2).ToString
            todo.Cantidad.Text = reder.Item(0).ToString
        End If
    End Sub
    Public Sub guardar_cambio(ByVal todo As Modificar_compra)
        Dim consulta As String
        Dim reder As Data.SqlClient.SqlDataReader
        Dim compra As Compra = New Compra
        If (todo.Cantidad.Text <> "") And (todo.costo_unidad.Text <> "") Then
            consulta = "update detalle_compra set cantidad ='" & todo.Cantidad.Text & "', costo_unidad='" & todo.costo_unidad.Text & "',costo_total='" & todo.Costo_Total.Text & "' from detalle_compra as a, producto as b, compra as c where a.id_compra = c.id_compra and a.id_producto = b.id_producto and c.numero_factura_compra='" & todo.factura.Text & "' and b.nombre = '" & todo.producto.Text & "'"
            reder = compra.general(consulta)
            MsgBox("Los cambios han sido guardados", MsgBoxStyle.OkOnly, "Exito!")
        Else
            MsgBox("Los campos Cantidad y costo unidad no deben estar vacios", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
End Class