Public Class Realizar_Venta
    Public ID_Cliente As Integer
    Public ID_Factura As Integer = -1
    Public ID_Detalle As Integer = 0
    Public ID_Producto As Integer
    Public ID_Lote As Integer
    Public ID_Historico_Impuesto(1000) As String
    Public ID_Impuesto(1000) As String
    Public ValorI(1000) As Double
    Public CImpuestos As Integer
    Public ImpuestoP As Double

    Private Sub Identidad_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Identidad.KeyPress
        Dim Controlador As Controlador_Cliente
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Controlador = New Controlador_Cliente
            Controlador.Buscar_Cliente(Me.Tipo_Identidad.Text, Me.Identidad.Text, Me)
        End If
    End Sub

    Private Sub Codigo_Barras_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Codigo_Barras.KeyPress
        Dim ControladorP As Controlador_Producto
        ControladorP = New Controlador_Producto
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            ControladorP.Buscar_CodigoBarras(Me.Codigo_Barras.Text, Me)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ControladorF As Controlador_Venta
        Dim ControladorC As Controlador_Cliente
        Dim Detalle As FarmaciaSJDataSetTableAdapters.DETALLE_VENTATableAdapter
        Dim a As Boolean
        Dim subt As Double
        Dim Total As Double
        Dim impuesto As Double
        Dim conection As Data.SqlClient.SqlConnection
        Dim Consulta As Data.SqlClient.SqlCommand
        Dim Reder As Data.SqlClient.SqlDataReader
        Dim Coman As Data.SqlClient.SqlDataAdapter

        ControladorF = New Controlador_Venta
        ControladorC = New Controlador_Cliente
        If (ID_Factura = -1) Then
            If (ID_Cliente = -1) Then
                a = ControladorC.Ingresar_Cliente(Tipo_Identidad.Text, Identidad.Text, Nombre.Text, Apellido.Text, Telefono.Text, Direccion.Text)
                If (a = True) Then
                    ControladorC.Buscar_Cliente(Tipo_Identidad.Text, Identidad.Text, Me)
                End If

            End If
            If (ID_Cliente <> -1) Then
                ID_Factura = ControladorF.Ingresar_Factura(Numero.Text, Fecha_Compra.Value, Vence.Value, ID_Cliente)
                If (ID_Factura <> -1) Then
                    ID_Detalle = ID_Detalle + 1
                    ControladorF.Ingresar_Detalle(ID_Detalle, ID_Factura, ID_Producto, ID_Lote, Cantidad.Text, ID_Impuesto, ID_Historico_Impuesto, CImpuestos)
                    Me.Detalle_Venta.DataMember = "Select Detalle_venta.ID_Detalle_Venta AS Numero,Producto.Nombre,Lote.PVP As Precio_Unitario,((Lote.Descuento/100)*(Lote.PVP*Detalle_Venta.Cantidad))As Descuento,Ip.Impuesto, Detalle_Venta.Cantidad, ((Lote.PVP*Detalle_Venta.Cantidad)+(1-((Lote.Descuento/100)*(Lote.PVP*Detalle_Venta.Cantidad)))+IP.Impuesto) As Sub_Total from (Select I.ID_Detalle_Venta,Sum(I.Impuesto)As Impuesto From (SELECT     DETALLE_VENTA.ID_DETALLE_VENTA, (HISTORICO_IMPUESTO.VALOR / 100 ) * (DETALLE_VENTA.Cantidad * LOTE.PVP) AS Impuesto FROM         DETALLE_VENTA INNER JOIN IMPUESTO_DETALLE_VENTA ON DETALLE_VENTA.ID_DETALLE_VENTA = IMPUESTO_DETALLE_VENTA.ID_DETALLE_VENTA AND DETALLE_VENTA.ID_VENTA = IMPUESTO_DETALLE_VENTA.ID_VENTA INNER JOIN HISTORICO_IMPUESTO ON IMPUESTO_DETALLE_VENTA.ID_HISTORICO_IMPUESTO = HISTORICO_IMPUESTO.ID_HISTORICO_IMPUESTO AND IMPUESTO_DETALLE_VENTA.ID_IMPUESTO = HISTORICO_IMPUESTO.ID_IMPUESTO INNER JOIN LOTE ON DETALLE_VENTA.ID_LOTE = LOTE.ID_LOTE AND DETALLE_VENTA.ID_PRODUCTO = LOTE.ID_PRODUCTO WHERE     (DETALLE_VENTA.ID_VENTA = " & ID_Factura & "))I Group By I.Id_Detalle_Venta)IP Inner Join Detalle_Venta ON IP.ID_Detalle_Venta=Detalle_Venta.ID_Detalle_Venta Inner Join Lote on Detalle_Venta.ID_Lote=Lote.ID_Lote and Detalle_Venta.ID_Producto=Lote.ID_Producto Inner Join Producto On Lote.ID_Producto=Producto.ID_Producto where Detalle_Venta.ID_Venta=" & ID_Factura
                    Me.Detalle_Venta.Refresh()
                    Me.Detalle_Venta.Update()
                    subt = Me.Sub_Total.Text
                    subt = subt + Me.SubtotalP.Text
                    Me.Sub_Total.Text = subt
                    impuesto = Me.Impuesto.Text
                    impuesto = impuesto + ImpuestoP
                    Me.Impuesto.Text = impuesto
                    Total = subt + impuesto
                    Me.Total.Text = Total
                End If
            End If
        End If
    End Sub

    Private Sub Cantidad_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Cantidad.KeyPress
        Dim Pu As Double
        Dim Descuento As Double
        Dim Cantidad As Integer
        Dim Subtotal As Double
        Dim Impuesto As Double = 0
        Dim Impuesto1 As Double
        Dim i As Integer
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Pu = Me.Punitario.Text
            Descuento = Me.Descuento.Text
            Cantidad = Me.Cantidad.Text
            Subtotal = Pu * Cantidad
            Descuento = Descuento / 100
            Descuento = 1 - Descuento
            Subtotal = (Subtotal * Descuento)
            i = 0
            Do While (i < CImpuestos)
                Impuesto1 = (ValorI(i) / 100)
                Impuesto1 = Subtotal * Impuesto1
                Impuesto = Impuesto + Impuesto1
                i = i + 1
            Loop
            Me.SubtotalP.Text = Subtotal
            ImpuestoP = Impuesto
        End If
    End Sub

End Class