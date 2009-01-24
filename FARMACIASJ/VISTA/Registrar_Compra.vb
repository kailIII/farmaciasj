Public Class Registrar_Compra
    Public ID_Proveedor As Integer = -1
    Public ID_Producto As Integer = -1
    Public ID_Linea As Integer = -1
    Public ID_Factura As Integer = -1
    Public ID_DETALLE As Integer = 0
    Public MUtil As Double
    Public DescMax As Double
    Private Sub RIF_PROVEEDOR_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles RIF_PROVEEDOR.KeyPress
        Dim ControladorP As Controlador_Proveedor
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            ControladorP = New Controlador_Proveedor
            ControladorP.Buscar_Rif(RIF_PROVEEDOR.Text, Me)
        End If
    End Sub
    Private Sub RIF_PROVEEDOR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIF_PROVEEDOR.TextChanged
        If (Me.RIF_PROVEEDOR.Text.Length = 1) Then
            If (Me.RIF_PROVEEDOR.Text(0) = Char.Parse("J") Or Me.RIF_PROVEEDOR.Text(0) = Char.Parse("V") Or Me.RIF_PROVEEDOR.Text(0) = Char.Parse("E") Or Me.RIF_PROVEEDOR.Text(0) = Char.Parse("G")) Then
                Me.RIF_PROVEEDOR.MaxLength = 10
            Else
                Me.RIF_PROVEEDOR.Text = ""
            End If
        ElseIf (Me.RIF_PROVEEDOR.Text.Length > 1) Then
            Dim count As Integer
            count = Me.RIF_PROVEEDOR.Text.Length - 1
            If (Char.IsDigit(Me.RIF_PROVEEDOR.Text(count)) = False) Then
                Dim A As String
                A = Me.RIF_PROVEEDOR.Text
                A = A.Substring(0, count)
                Me.RIF_PROVEEDOR.Text = A
                Me.RIF_PROVEEDOR.SelectionStart = Me.RIF_PROVEEDOR.Text.Length
            End If
        End If
    End Sub

    Private Sub CODIGO_BARRAS_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles CODIGO_BARRAS.KeyPress
        Dim Producto As Controlador_Producto
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Producto = New Controlador_Producto
            If (ID_Proveedor <> -1) Then
                Producto.Buscar_CodigoBarras_IDPROVEEDOR(CODIGO_BARRAS.Text, ID_Proveedor, Me)
            Else
                MsgBox("Debe seleccionar Proveedor", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub


    Private Sub Cantidad_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cantidad.KeyPress
        Dim Cantidad As Integer
        Dim Costo As Double
        Dim Costo_Total As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Cantidad = Integer.Parse(Me.Cantidad.Text)
            Costo = Double.Parse(Me.CUnidad.Text)
            Costo_Total = Cantidad * Costo
            Me.CTotal.Text = CStr(Costo_Total)
        End If

    End Sub

    Private Sub CUnidad_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles CUnidad.KeyPress
        Dim Cantidad As Integer
        Dim COSTO As Double
        Dim PVP As Double
        Dim MUtil As Double
        Dim Costo_Total As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Cantidad = Integer.Parse(Me.Cantidad.Text)
            COSTO = Double.Parse(Me.CUnidad.Text)
            Costo_Total = Cantidad * COSTO
            Me.CTotal.Text = CStr(Costo_Total)
            PVP = COSTO * (1 + (15 / 100))
            MUtil = Me.MUtil
            If (PVP > (COSTO * (1 + (MUtil / 100)))) Then
                PVP = COSTO * (1 + (MUtil / 100))
            End If
            Me.PVP.Text = CStr(PVP)
        End If
    End Sub

    Private Sub PVP_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles PVP.KeyPress
        Dim COSTO As Double
        Dim PVP As Double
        Dim MUtil As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            MUtil = Me.MUtil
            PVP = Double.Parse(Me.PVP.Text)
            COSTO = Double.Parse(Me.CUnidad.Text)
            If (PVP > (COSTO * (1 + (MUtil / 100)))) Then
                MsgBox("La Ganancia no puede superar el " & Me.MUtil & "%", MsgBoxStyle.OkOnly, "ALERT")
                PVP = COSTO * (1 + (15 / 100))
                Me.PVP.Text = CStr(PVP)
            End If
        End If
    End Sub

    Private Sub DESCUENTO_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles DESCUENTO.KeyPress
        Dim Descuento As Double
        Dim DMax As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Descuento = Double.Parse(Me.DESCUENTO.Text)
            DMax = Me.DescMax
            If (Descuento > DMax) Then
                MsgBox("El Descuento no puede ser menor que: " & DMax & "%", MsgBoxStyle.OkOnly, "ALERT")
                Descuento = 0
            End If
            Me.DESCUENTO.Text = CStr(Descuento)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ControladorL As New Controlador_Linea
        Dim ControladorPT As New Controlador_Producto
        Dim ControladorPV As New Controlador_Proveedor
        Dim ControladorC As New Controlador_Compra
        Dim Subtotal As Double
        Dim Ctotal As Double

        If (ID_Producto = -1) Then
            MsgBox("No ha seleccionado el Producto que ha comprado", MsgBoxStyle.OkOnly, "Error")
        End If
        If (ID_Producto <> -1) Then
            If (ID_Factura = -1 And Me.Numero.Text <> "") Then
                ID_Factura = ControladorC.Ingresar_Compra(Me.Numero.Text, Me.Fecha.Value, Me.Vence.Value, ID_Proveedor)
            Else
                MsgBox("No ha ingresado el numero de la factura", MsgBoxStyle.OkOnly, "Error")
            End If
            If (ID_Factura <> -1) Then
                ID_DETALLE = ID_DETALLE + 1
                ControladorC.Ingresar_Detalle(ID_DETALLE, ID_Factura, Integer.Parse(Me.Cantidad.Text), Double.Parse(Me.CTotal.Text), ID_Producto, Double.Parse(Me.CUnidad.Text))
                ControladorPT.Ingresar_Lote(Integer.Parse(Me.Cantidad.Text), Me.FVENCE.Value, Decimal.Parse(Me.PVP.Text), Decimal.Parse(Me.DESCUENTO.Text), ID_Producto, ID_Factura, ID_DETALLE)
                Me.DETALLE_COMPRA.DataSource = ControladorC.Traer_Detalle(ID_Factura)
                Me.DETALLE_COMPRA.Update()
                Ctotal = Double.Parse(Me.CTotal.Text)
                Subtotal = Double.Parse(Me.Subtotal.Text)
                Subtotal = Subtotal + Ctotal
                Me.Subtotal.Text = CStr(Subtotal)
                Me.NOMBRE_PRODUCTO.Enabled = False
                Me.NOMBRE_PRODUCTO.Text = ""
                Me.CODIGO_BARRAS.Text = ""
                Me.Cantidad.Text = "0"
                Me.CUnidad.Text = "0"
                Me.CTotal.Text = "0"
                Me.PVP.Text = "0"
                Me.DESCUENTO.Text = "0"
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ControladorC As Controlador_Compra
        If (ID_Factura <> -1) Then
            ControladorC = New Controlador_Compra
            ControladorC.Procesar_COMPRA(ID_Factura, Me)
        Else
            MsgBox("No a Ingresado nada en la factura, no continuar", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

End Class