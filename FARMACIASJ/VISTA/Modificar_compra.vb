Public Class Modificar_compra

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim control As Controlador_Modificar_Compra = New Controlador_Modificar_Compra
        control.habilitar_compra(Me)
    End Sub

    Private Sub producto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles producto.SelectedIndexChanged
        Dim control As Controlador_Modificar_compra = New Controlador_Modificar_compra
        control.habilitar_cantidad(Me)
    End Sub

    Private Sub Generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Costo_Total.Text = (Double.Parse(Me.costo_unidad.Text) * Double.Parse(Me.Cantidad.Text)).ToString
    End Sub

    Private Sub Cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cantidad.TextChanged
        If Me.Cantidad.Text <> "" And Me.costo_unidad.Text <> "" Then
            Try
                Me.Costo_Total.Text = (Double.Parse(Me.costo_unidad.Text) * Double.Parse(Me.Cantidad.Text)).ToString
            Catch
                MsgBox("Los campos Cantidad y costo unidad no denen tener letras o simbolos", MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim control As Controlador_Modificar_compra = New Controlador_Modificar_compra
        Try
            control.guardar_cambio(Me)
        Catch
            MsgBox("Los campos Cantidad y costo unidad no denen tener letras o simbolos", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cerrar.Click
        Me.Close()
    End Sub

    Private Sub costo_unidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles costo_unidad.TextChanged
        If Me.Cantidad.Text <> "" And Me.costo_unidad.Text <> "" Then
            Try
                Me.Costo_Total.Text = (Double.Parse(Me.costo_unidad.Text) * Double.Parse(Me.Cantidad.Text)).ToString
            Catch
                MsgBox("Los campos Cantidad y costo unidad no denen tener letras o simbolos", MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub Modificar_compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.PRODUCTO' table. You can move, or remove it, as needed.
        Me.PRODUCTOTableAdapter.Fill(Me.FarmaciaSJDataSet.PRODUCTO)
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.COMPRA' table. You can move, or remove it, as needed.
        Me.COMPRATableAdapter.Fill(Me.FarmaciaSJDataSet.COMPRA)

    End Sub
End Class