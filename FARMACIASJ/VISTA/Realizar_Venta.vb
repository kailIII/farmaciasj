Public Class Realizar_Venta
    Public ID_Cliente As Integer = -1
    Public ID_Factura As Integer = -1
    Public ID_Detalle As Integer = 0
    Public ID_Producto As Integer
    Public ID_Lote As Integer
    Public ID_Historico_Impuesto(1000) As Integer
    Public ID_Impuesto(1000) As Integer
    Public ValorI(1000) As Double
    Public CImpuestos As Integer
    Public ImpuestoP As Double


    Private Sub Identidad_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Identidad.KeyPress
        Dim Controlador As Controlador_Cliente
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controlador = New Controlador_Cliente
            Controlador.Buscar_Cliente(Me.Identidad.Text, Me)
        End If
    End Sub
    Private Sub Identidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Identidad.TextChanged
        If (Identidad.Text.Length = 1) Then
            If (Identidad.Text(0) = Char.Parse("J") Or Identidad.Text(0) = Char.Parse("G")) Then
                Identidad.MaxLength = 10
            ElseIf (Identidad.Text(0) = Char.Parse("V") Or Identidad.Text(0) = Char.Parse("E")) Then
                Identidad.MaxLength = 9
            ElseIf (Identidad.Text(0) = Char.Parse("P")) Then
                Identidad.MaxLength = 12
            Else
                Identidad.Text = ""
            End If
        ElseIf (Identidad.Text.Length > 1) Then
            Dim count As Integer
            count = Identidad.Text.Length - 1
            If (Char.IsDigit(Identidad.Text(count)) = False) Then
                Dim A As String
                A = Identidad.Text
                A = A.Substring(0, count)
                Identidad.Text = A
                Identidad.SelectionStart = Identidad.Text.Length
            End If
        End If
    End Sub

    Private Sub Codigo_Barras_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Codigo_Barras.KeyPress
        Dim ControladorP As Controlador_Producto
        ControladorP = New Controlador_Producto
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            ControladorP.Buscar_CodigoBarras(Me.Codigo_Barras.Text, Me, 0)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ControladorF As Controlador_Venta
        Dim ControladorC As Controlador_Cliente
        'Dim a As Boolean
        Dim subt As Double
        Dim Total As Double
        Dim impuesto As Double

        ControladorF = New Controlador_Venta
        ControladorC = New Controlador_Cliente
        If (ID_Factura = -1) Then
            If (ID_Cliente <> -1) Then
                If (ID_Factura = -1) Then
                    ID_Factura = ControladorF.Ingresar_Factura(Numero.Text, Fecha_Compra.Value, Vence.Value, ID_Cliente)
                End If
            Else
                MsgBox("Se debe seleccionar cliente para la venta", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
            If (ID_Factura <> -1) Then
                ID_Detalle = ID_Detalle + 1
                ControladorF.Ingresar_Detalle(ID_Detalle, ID_Factura, ID_Producto, ID_Lote, Integer.Parse(Cantidad.Text), ID_Impuesto, ID_Historico_Impuesto, CImpuestos)
                Me.DETALLE_VENTA.DataSource = ControladorF.Traer_Detalle(ID_Factura)
                Me.DETALLE_VENTA.Update()
                subt = Double.Parse(Me.Sub_Total.Text)
                subt = Math.Round(subt + Double.Parse(Me.SubtotalP.Text), 2)
                Me.Sub_Total.Text = CStr(subt)
                impuesto = Double.Parse(Me.Impuesto.Text)
                impuesto = Math.Round(impuesto + ImpuestoP, 2)
                Me.Impuesto.Text = CStr(impuesto)
                Total = Math.Round(subt + impuesto, 2)
                Me.Total.Text = CStr(Total)
                Me.Codigo_Barras.Text = ""
                Me.NombreP.Text = ""
                Me.Punitario.Text = ""
                Me.Descuento.Text = ""
                Me.Cantidad.Text = ""
                Me.Descripcion.Text = ""
                Me.SubtotalP.Text = ""
            End If
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
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controladorf = New Controlador_Venta
            If (Controladorf.combrobarcantidad(ID_Lote, ID_Producto, Integer.Parse(Me.Cantidad.Text)) = True) Then
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
                Me.SubtotalP.Text = CStr(Subtotal)
                ImpuestoP = Impuesto
            Else
                MsgBox("La Cantidad supera la cantidad disponible", MsgBoxStyle.OkOnly, "Alert")
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ControladorF As Controlador_Venta

        ControladorF = New Controlador_Venta
        ControladorF.Borrar_Factura(ID_Factura, Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ControladorF As Controlador_Venta
        If (ID_Factura <> -1) Then
            ControladorF = New Controlador_Venta
            ControladorF.Descontar_Inventario(ID_Factura)
            ControladorF.Procesar_Venta(ID_Factura, Me, 0)
        Else
            MsgBox("No se puede Facturar si la Facutra esta vacia", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub Realizar_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ControladorF As Controlador_Venta
        ControladorF = New Controlador_Venta
        'Fecha_Compra.Value = Date.Today
        ''Vence.Value = Date.Today
        Dim C As Integer
        C = ControladorF.CantidadF()
        C = C + 1
        If (C < 10) Then
            Numero.Text = "F00" & C
        ElseIf (C < 100) Then
            Numero.Text = "F0" & C
        Else
            Numero.Text = "F" & C
        End If
    End Sub

End Class