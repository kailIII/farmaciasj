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

    Public Sub Abrir_VentaM(ByVal Padre As Windows.Forms.Form)
        Dim Compra As Modificar_compra
        Compra = New Modificar_compra
        Compra.MdiParent = Padre
        Compra.Show()
    End Sub

    Public Sub Buscar_Info_Factura(ByVal Control_Numero As String, ByVal Compra As Modificar_compra)
        Dim Compra_x As New Compra
        Dim Id_proveedor As Integer = Compra_x.Buscar_id_Proveedor_Factura(Control_Numero)
        Dim ControladorF As Controlador_Compra = New Controlador_Compra

        If (Id_proveedor > 0) Then
            Compra_x.Buscar_Info_Proveedor(Id_proveedor, Compra)
            Compra.DETALLE_COMPRA.DataSource = ControladorF.Traer_Detalle(Compra_x.Buscar_Id_Compra_Factura(Control_Numero))
            Compra.DETALLE_COMPRA.Update()
            Compra.NDETALLE.Focus()
            Compra.NDETALLE.Enabled = True

        Else
            MsgBox("Número de factura inválido", MsgBoxStyle.OkOnly, "Error")
            Compra.NOMBRE_PROVEEDOR.Text = ""
            Compra.RIF_PROVEEDOR.Text = ""
            Compra.DETALLE_COMPRA.DataSource = DBNull.Value
            Compra.DETALLE_COMPRA.Update()
        End If
    End Sub

    Public Sub Buscar_Info_Detalle(ByVal NDETALLE As String, ByVal Numero As String, ByVal Compra As Modificar_compra)
        Dim Compra_x As New Compra
        Dim Id_Compra As Integer = Compra_x.Buscar_Id_Compra_Factura(Numero)
        Dim a As Boolean

        a = Compra_x.Buscar_Info_Detalle(NDETALLE, Id_Compra, Compra)
        If (a = False) Then
            MsgBox("El Detalle no se consigue verifique el numero y vuelva a intentar", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Public Sub Modificar_Compra(ByVal CRestar As Integer, ByVal CTotal As Double, ByVal NDETALLE As Integer, ByVal ID_Lote As Integer, ByVal Id_Producto As Integer, ByVal RIF As String, ByVal Numero As String, ByVal Compra As Modificar_compra)
        Dim Compra_x As New Compra
        Dim Id_Compra As Integer = Compra_x.Buscar_Id_Compra_Factura(Numero)
        Dim Id_Proveedor As Integer = Compra_x.Buscar_id_Proveedor_Factura(Numero)
        Dim a As Boolean
        Dim ControladorF As Controlador_Compra = New Controlador_Compra

        a = Compra_x.Modificar_Compra(CRestar, CTotal, NDETALLE, Id_Compra)
        If (a = True) Then
            a = Compra_x.Modificar_Lote(CRestar, ID_Lote, Id_Producto)
            If (a = True) Then
                a = Compra_x.Modificar_Proveedor(CTotal, Id_Proveedor)
                Compra.DETALLE_COMPRA.DataSource = ControladorF.Traer_Detalle(Compra_x.Buscar_Id_Compra_Factura(Numero))
                Compra.DETALLE_COMPRA.Update()
                MsgBox("La Compra se Modifico con Exito", MsgBoxStyle.OkOnly, "Informa")
            End If
        Else
            MsgBox("No se pudo modificar la Compra, Verifique e Itente de nuevo", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

End Class
