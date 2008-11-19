Public Class Controlador_Compra
    Public Function Ingresar_Compra(ByVal Numero As String, ByVal Fecha As Date, ByVal Vence As Date, ByVal ID_Proveedor As Integer) As Integer
        Dim Compra As New Compra
        Dim reder As Data.SqlClient.SqlDataReader
        Compra.Ingresar_Compra(Numero, Fecha, Vence, ID_Proveedor)
        reder = Compra.buscar_Compra(Numero)
        If (reder.Read = True) Then
            Return Integer.Parse(reder.Item(0).ToString)
        End If
    End Function
    Public Sub Ingresar_Detalle(ByVal ID_DETALLE As Integer, ByVal ID_COMPRA As Integer, ByVal Cantidad As Integer, ByVal Costo As Double, ByVal ID_PRODUCTO As Integer, ByVal COSTOUNIDAD As Double)
        Dim Compra As New Compra
        Compra.Ingresar_Detalle(ID_DETALLE, ID_COMPRA, Cantidad, Costo, ID_PRODUCTO, COSTOUNIDAD)
    End Sub
    Public Function Traer_Detalle(ByVal Id_COMPRA As Integer) As Data.DataTable
        Dim COMPRA As Compra
        COMPRA = New Compra
        Return COMPRA.Traer_Detalle(Id_COMPRA)
    End Function
    Public Sub Procesar_COMPRA(ByVal ID_Factura As Integer, ByVal Compra As Registrar_Compra)
        Dim Compra2 As New Compra2
        Compra2.Numero_Factura.Text = Compra.Numero.Text
        Compra2.RIF_PROVEEDOR.Text = Compra.RIF_PROVEEDOR.Text
        Compra2.SUB_TOTAL.Text = Compra.Subtotal.Text
        Compra2.Total.Text = Compra.Subtotal.Text
        Compra2.ID_FACTURA = Compra.ID_Factura
        Compra2.MdiParent = Compra.MdiParent
        Compra2.Show()
        Compra.Close()
    End Sub

    Public Sub ProcesarC(ByVal SUB_TOTAL As String, ByVal IMPUESTO As String, ByVal DESCUENTO As String, ByVal Total As String, ByVal ID_FACTURA As Integer)
        Dim Compra As New Compra
        Compra.ProcesarC(SUB_TOTAL, IMPUESTO, DESCUENTO, Total, ID_FACTURA)

    End Sub

    Public Sub Abrir_Venta(ByVal Padre As Windows.Forms.Form)
        Dim Compra As Registrar_Compra
        Compra = New Registrar_Compra
        Compra.MdiParent = Padre
        Compra.Show()
    End Sub


End Class
