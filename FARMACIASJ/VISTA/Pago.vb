Public Class Pago
    Public ID_Factura As Integer

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex = 0) Then
            LMonto.Visible = True
            Monto.Text = CStr(0)
            Monto.Visible = True
            Vuelto.Text = CStr(0)
            LNCT.Visible = False
            NCT.Visible = False
            Vuelto.Visible = True
            LVuelto.Visible = True
            LFVencimiento.Visible = False
            Vencimiento.Visible = False
        ElseIf (ComboBox1.SelectedIndex = 1) Then
            LMonto.Visible = False
            Monto.Visible = False
            Monto.Text = Total.Text
            LNCT.Visible = True
            Vuelto.Text = CStr(0)
            LNCT.Text = "Numero de Cheke"
            NCT.Visible = True
            Vuelto.Visible = False
            LVuelto.Visible = False
            LFVencimiento.Visible = False
            Vencimiento.Visible = False
        Else
            LMonto.Visible = False
            Monto.Visible = False
            Monto.Text = Total.Text
            Vuelto.Text = CStr(0)
            LNCT.Visible = True
            LNCT.Text = "Numero de Tarjeta"
            NCT.Visible = True
            Vuelto.Visible = False
            LVuelto.Visible = False
            LFVencimiento.Visible = True
            Vencimiento.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ControladorF As Controlador_Venta
        'Dim Factura As FACTURA
        ControladorF = New Controlador_Venta
        If (Stotal.Text.Contains(",") = False) Then
            Stotal.Text = Stotal.Text & ",00"
        End If
        If (Impuestos.Text.Contains(",") = False) Then
            Impuestos.Text = Impuestos.Text & ",00"
        End If
        If (Total.Text.Contains(",") = False) Then
            Total.Text = Total.Text & ",00"
        End If
        If (Monto.Text.Contains(",") = False) Then
            Monto.Text = Monto.Text & ",00"
        End If
        If (Vuelto.Text.Contains(",") = False) Then
            Vuelto.Text = Vuelto.Text & ",00"
        End If
        ControladorF.Actualizar_Pago(ID_Factura, Stotal.Text, Impuestos.Text, Total.Text, Me.ComboBox1.Text, Monto.Text, Vuelto.Text, NCT.Text, Vencimiento.Value.Year & "-" & Vencimiento.Value.Month & "-" & Vencimiento.Value.Day, Me)
    End Sub

   
    Private Sub Monto_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Monto.KeyPress
        Dim Total2 As Double
        Dim Monto2 As Double
        Dim Vuelto2 As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Total2 = Double.Parse(Total.Text)
            Monto2 = Double.Parse(Monto.Text)
            Vuelto2 = Math.Round(Monto2 - Total2, 2)
            Monto.Text = CStr(Monto2)
            Vuelto.Text = CStr(Vuelto2)
        End If
    End Sub

    


End Class