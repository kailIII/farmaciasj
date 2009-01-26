Public Class IngresarCliente
    Public Cliente As Controlador_Cliente


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (RIF.Text(0) = Char.Parse("J") Or RIF.Text(0) = Char.Parse("G")) Then
            If (NOMBRE.Text <> "" And RIF.Text <> "" And TELEFONO.Text <> "" And DIRECCION.Text <> "") Then
                If (MsgBox("Seguro que desea Ingresar al Cliente: " & NOMBRE.Text, MsgBoxStyle.YesNo, "Verificar") = MsgBoxResult.Yes) Then
                    If (Cliente.Ingresar_Cliente(RIF.Text, NOMBRE.Text, TELEFONO.Text, DIRECCION.Text)) Then
                        MsgBox("El Cliente se ingreso con éxito", MsgBoxStyle.OkOnly, "Informacion")
                        If (Cliente.condicion = 1) Then
                            Cliente.Buscar_Cliente(Me.RIF.Text, Cliente.Venta)
                            Me.Close()
                        End If
                    Else
                        MsgBox("El Cliente no se pudo Ingresar Verifique y vuelva a intentar", MsgBoxStyle.OkOnly, "Error")
                    End If
                End If
            Else
                MsgBox("Alguno de los campos esta vacio, Verifique y vuelva a intentar", MsgBoxStyle.OkOnly, "Error")
            End If
        ElseIf (RIF.Text(0) = Char.Parse("V") Or RIF.Text(0) = Char.Parse("E") Or RIF.Text(0) = Char.Parse("P")) Then
            If (NOMBRE.Text <> "" And APELLIDO.Text <> "" And RIF.Text <> "" And TELEFONO.Text <> "" And DIRECCION.Text <> "") Then
                If (MsgBox("Seguro que desea Ingresar al Cliente: " & NOMBRE.Text & " " & APELLIDO.Text, MsgBoxStyle.YesNo, "Verificar") = MsgBoxResult.Yes) Then
                    If (Cliente.Ingresar_Cliente(RIF.Text, NOMBRE.Text, APELLIDO.Text, TELEFONO.Text, DIRECCION.Text)) Then
                        MsgBox("El Cliente se ingreso con éxito", MsgBoxStyle.OkOnly, "Informacion")
                        If (Cliente.condicion = 1) Then
                            Cliente.Buscar_Cliente(Me.RIF.Text, Cliente.Venta)
                            Me.Close()
                        End If
                    Else
                        MsgBox("El Cliente no se pudo Ingresar Verifique y vuelva a intentar", MsgBoxStyle.OkOnly, "Error")
                    End If
                End If
            Else
                MsgBox("Alguno de los campos esta vacio, Verifique y vuelva a intentar", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Private Sub TELEFONO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TELEFONO.TextChanged
        If (Me.TELEFONO.Text.Length >= 1) Then
            If (Char.IsDigit(Me.TELEFONO.Text(Me.TELEFONO.Text.Length - 1)) = False) Then
                Dim A As String
                A = Me.TELEFONO.Text
                A = A.Substring(0, Me.TELEFONO.Text.Length)
                Me.TELEFONO.Text = A
                Me.TELEFONO.SelectionStart = Me.TELEFONO.Text.Length
            End If
        End If
    End Sub
End Class