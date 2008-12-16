Public Class Registrar_Devolucion
    Public Id_Lote_Publico As Integer
    Public Id_Producto_Publico As Integer
    Public ValorI(1000) As Double
    Public CImpuestos As Integer
    Public ImpuestoP As Double
    Public ID_Detalle_Publico As Integer
    Public Id_Cliente_Publico As Integer

    Private Sub Numero_Control_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Numero_Control.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador_Venta_x As Controlador_Venta
            Controlador_Venta_x = New Controlador_Venta
            Controlador_Venta_x.Buscar_Info_Factura(Me.Numero_Control.Text, Me)
        End If
    End Sub


    Private Sub Codigo_Barras_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Codigo_Barras.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador_Venta_x As Controlador_Venta
            Controlador_Venta_x = New Controlador_Venta
            Controlador_Venta_x.Devolucion_Productos(Me.Numero_Control.Text, Me.Codigo_Barras.Text, Me)

        End If
    End Sub


    Private Sub Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Procesar.Click
        Dim Venta_x As Venta
        Dim Realizar_Venta As Realizar_Venta
        Dim FarmaciaSJ As FarmaciaSJDataSet
        Venta_x = New Venta
        Realizar_Venta = New Realizar_Venta
        FarmaciaSJ = Venta_x.Cargar_Reporte(Venta_x.Ultima_Devolucion(Venta_x.Buscar_Id_Venta_Factura(Me.Numero_Control.Text)))
    End Sub

    Private Sub Devolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Devolver.Click
        Me.Devolver.Enabled = False
        Me.Codigo_Barras.Focus()
        Me.Codigo_Barras.Text = ""
        Me.Punitario.Text = ""
        Me.Descuento.Text = ""
        Me.NombreP.Text = ""
        Me.Cantidad.Text = ""
        Me.Cantidad.Enabled = False
        Me.Procesar.Enabled = True


    End Sub

    Private Sub Cantidad_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cantidad.KeyPress
        Dim Pu As Double
        Dim Descuento As Double
        Dim Cantidad As Integer
        Dim Subtotal As Double
        Dim Impuesto As Double = 0
        Dim Impuesto1 As Double
        Dim Controladorf As Controlador_Venta
        Dim i As Integer

        Dim Venta_x As Venta = New Venta
        Dim Id_Venta As Integer = Venta_x.Buscar_Id_Venta_Factura(Me.Numero_Control.Text)

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controladorf = New Controlador_Venta
            If (Controladorf.combrobarcantidadDetalle(ID_Detalle_Publico, Id_Venta, Integer.Parse(Me.Cantidad.Text)) = True) Then
                Pu = Double.Parse(Me.Punitario.Text)
                Descuento = Double.Parse(Me.Descuento.Text)
                Cantidad = Integer.Parse(Me.Cantidad.Text)
                Subtotal = Pu * Cantidad
                Descuento = Descuento / 100
                Descuento = 1 - Descuento
                Subtotal = (Subtotal * Descuento)
                i = 0
                Do While (i < CImpuestos)
                    Impuesto1 = Math.Round((ValorI(i) / 100), 2)
                    Impuesto1 = Math.Round(Subtotal * Impuesto1, 2)
                    Impuesto = Math.Round(Impuesto + Impuesto1, 2)
                    i = i + 1
                Loop
                'Me.SubtotalP.Text = CStr(Subtotal)
                ImpuestoP = Impuesto
            Else
                MsgBox("La Cantidad supera la cantidad disponible", MsgBoxStyle.OkOnly, "Alert")
            End If
        End If
    End Sub

End Class