Public Class Compra2
    Public ID_FACTURA As Integer
    Private Sub Procesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Procesar.Click
        Dim ControladorC As New Controlador_Compra
        If (Me.SUB_TOTAL.Text.Contains(",") = False) Then
            Me.SUB_TOTAL.Text = Me.SUB_TOTAL.Text & ",00"
        End If
        If (Me.IMPUESTO.Text.Contains(",") = False) Then
            Me.IMPUESTO.Text = Me.IMPUESTO.Text & ",00"
        End If
        If (Me.DESCUENTO.Text.Contains(",") = False) Then
            Me.DESCUENTO.Text = Me.DESCUENTO.Text & ",00"
        End If
        If (Me.Total.Text.Contains(",") = False) Then
            Me.Total.Text = Me.Total.Text & ",00"
        End If
        ControladorC.ProcesarC(Me.SUB_TOTAL.Text, Me.IMPUESTO.Text, Me.DESCUENTO.Text, Me.Total.Text, ID_FACTURA)
        Me.Close()
    End Sub

    Private Sub IMPUESTO_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles IMPUESTO.KeyPress
        Dim Impuestos As Double
        Dim Total As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Impuestos = Double.Parse(Me.IMPUESTO.Text)
            Total = Double.Parse(Me.Total.Text)
            Total = Total + Impuestos
            Me.Total.Text = CStr(Total)
        End If
    End Sub

    Private Sub DESCUENTO_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles DESCUENTO.KeyPress
        Dim Descuento As Double
        Dim Total As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Descuento = Double.Parse(Me.DESCUENTO.Text)
            Total = Double.Parse(Me.Total.Text)
            Total = Total - Descuento
            Me.Total.Text = CStr(Total)
        End If

    End Sub
End Class