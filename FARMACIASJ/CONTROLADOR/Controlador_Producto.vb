Public Class Controlador_Producto
    Public ID_Productos(1000) As String
    Public ID_LOTES(1000) As String
    Public Nombre(1000) As String
    Public Descripcion(1000) As String
    Public Codigos(1000) As String
    Public PVPs(1000) As String
    Public Descuentos(1000) As String
    Private Venta As Realizar_Venta

    Public Function Buscar_CodigoBarras(ByVal Codigo As String, ByVal Venta As Realizar_Venta) As Boolean
        Dim Producto As Producto
        Dim Lotes As Data.SqlClient.SqlDataReader
        Dim ELotes As Elegir_Lote
        Dim Cadena As String
        Producto = New Producto
        Dim i As Integer
        Dim filas As Integer
        Lotes = Producto.Buscar_CodigoBarras(Codigo, Venta)
        filas = Producto.Cantidad_Filas(Codigo)
        If (filas = 1) Then
            If (Lotes.Read = True) Then
                Venta.ID_Producto = Lotes.Item(0).ToString
                Venta.ID_Lote = Lotes.Item(1).ToString
                Venta.NombreP.Text = Lotes.Item(2).ToString
                Venta.Descripcion.Text = Lotes.Item(3).ToString
                Venta.Codigo_Barras.Text = Lotes.Item(4).ToString
                Venta.Punitario.Text = Lotes.Item(6).ToString
                Venta.Descuento.Text = Lotes.Item(7).ToString
                Venta.Cantidad.Text = 0.0
                Venta.SubtotalP.Text = 0.0
                Return True
            End If
        ElseIf (filas > 1) Then
            Me.Venta = Venta
            i = 0
            ELotes = New Elegir_Lote

            Do While (Lotes.Read() = True)
                Cadena = Lotes.Item(2).ToString & " Vence: " & Lotes.Item(5).ToString
                ELotes.Lotes.Items.Insert(i, Cadena)
                ID_Productos(i) = Lotes.Item(0).ToString
                ID_LOTES(i) = Lotes.Item(1).ToString
                Nombre(i) = Lotes.Item(2).ToString
                Descripcion(i) = Lotes.Item(3).ToString
                Codigos(i) = Lotes.Item(4).ToString
                PVPs(i) = Lotes.Item(6).ToString
                Descuentos(i) = Lotes.Item(7).ToString
                i = i + 1
            Loop
            ELotes.ControladorP = Me
            ELotes.Show()
            Return True
        Else
                MsgBox("El producto Solicitado no existe", MsgBoxStyle.OkOnly, "Alert")
                Return False
        End If
    End Function

    Public Sub Regreso(ByVal I As Integer)
        Venta.ID_Producto = ID_Productos(I)
        Venta.ID_Lote = ID_LOTES(I)
        Venta.NombreP.Text = Nombre(I)
        Venta.Descripcion.Text = Descripcion(I)
        Venta.Codigo_Barras.Text = Codigos(I)
        Venta.Punitario.Text = PVPs(I)
        Venta.Descuento.Text = Descuentos(I)
        Venta.Cantidad.Text = 0.0
        Venta.SubtotalP.Text = 0.0
    End Sub
End Class
