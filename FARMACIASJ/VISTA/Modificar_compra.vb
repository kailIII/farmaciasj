Public Class Modificar_compra
    Public ID_Producto As Integer
    Public ID_Lote As Integer
    Public MUtil As Double
    Public DescMax As Double
    Public Count As Integer = 0
    Private Sub Numero_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles Numero.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador_Compra_x As Controlador_Compra
            Controlador_Compra_x = New Controlador_Compra
            Controlador_Compra_x.Buscar_Info_Factura(Me.Numero.Text, Me)
        End If
    End Sub

    Private Sub NDETALLE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NDETALLE.TextChanged, NDETALLE.KeyPress
        If (Me.NDETALLE.Text.Length >= 1) Then
            If (Char.IsDigit(Me.NDETALLE.Text(Me.NDETALLE.Text.Length - 1)) = False) Then
                Dim A As String
                A = Me.NDETALLE.Text
                A = A.Substring(0, Me.NDETALLE.Text.Length)
                Me.NDETALLE.Text = A
                Me.NDETALLE.SelectionStart = Me.NDETALLE.Text.Length
            End If
        End If
    End Sub
    Private Sub NDETALLE_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles NDETALLE.KeyPress
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Dim Controlador_Compra_x As Controlador_Compra
            Controlador_Compra_x = New Controlador_Compra
            Controlador_Compra_x.Buscar_Info_Detalle(Me.NDETALLE.Text, Me.Numero.Text, Me)
        End If
    End Sub

    Private Sub CRestar_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CRestar.KeyPress
        Dim CRestar As Integer
        Dim CUnitario As Double
        Dim CTotal As Double
        Dim A As Double
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            Count = 1
            CRestar = Integer.Parse(Me.CRestar.Text)
            CUnitario = Double.Parse(Me.CUnidad.Text)
            CTotal = Double.Parse(Me.CTotal.Text)
            A = Math.Round(CRestar * CUnitario)
            CTotal = Math.Round(CTotal - A)
            Me.CTotal.Text = Str(CTotal)
        End If
    End Sub


    Private Sub CRestar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRestar.TextChanged, CRestar.KeyPress
        Count = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Compra As New Controlador_Compra

        Compra.Modificar_Compra(Integer.Parse(Me.CRestar.Text), Double.Parse(Me.CTotal.Text), Integer.Parse(NDETALLE.Text), ID_Lote, ID_Producto, Me.RIF_PROVEEDOR.Text, Me.Numero.Text, Me)
    End Sub
End Class