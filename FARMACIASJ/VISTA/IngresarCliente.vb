Public Class IngresarCliente
    Public Cliente As Controlador_Cliente
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "JURIDICO") Then
            Me.LNOMBRE.Text = "Razon Social"
            Me.LIdentidad.Text = "Rif"
            Me.LApellido.Visible = False
            Me.APELLIDO.Visible = False
            Me.RIF.MaxLength = 10
        ElseIf (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "NATURAL") Then
            Me.LNOMBRE.Text = "Nombre"
            Me.LIdentidad.Text = "Cedula"
            Me.LApellido.Visible = True
            Me.APELLIDO.Visible = True
            Me.RIF.MaxLength = 9
        ElseIf (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "EXTRANJERO") Then
            Me.LNOMBRE.Text = "Nombre"
            Me.LIdentidad.Text = "PASSAPORTE"
            Me.LApellido.Visible = True
            Me.APELLIDO.Visible = True
            Me.RIF.MaxLength = 12
        End If
    End Sub

    Private Sub RIF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RIF.TextChanged
        If (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "JURIDICO") Then
            If (Me.RIF.Text.Length = 1) Then
                If (Me.RIF.Text(0) <> Char.Parse("J") Or Me.RIF.Text(0) <> Char.Parse("G")) Then
                    Me.RIF.Text = ""
                End If
            ElseIf (Me.RIF.Text.Length > 1) Then
                Dim count As Integer = Me.RIF.Text.Length - 1
                If (Char.IsDigit(Me.RIF.Text(count)) = False) Then
                    Me.RIF.TabIndex = Me.RIF.Text.Length - 1
                End If
            End If
        ElseIf (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "NATURAL") Then
            If (Me.RIF.Text.Length = 1) Then
                If (Me.RIF.Text(0) <> Char.Parse("V") Or Me.RIF.Text(0) <> Char.Parse("E")) Then
                    Me.RIF.Text = ""
                End If
            ElseIf (Me.RIF.Text.Length > 1) Then
                Dim count As Integer = Me.RIF.Text.Length - 1
                If (Char.IsDigit(Me.RIF.Text(count)) = False) Then
                    Me.RIF.TabIndex = Me.RIF.Text.Length - 1
                End If
            End If
        ElseIf (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "EXTRANJERO") Then
            If (Me.RIF.Text.Length = 1) Then
                If (Me.RIF.Text(0) <> Char.Parse("P")) Then
                    Me.RIF.Text = ""
                End If
            ElseIf (Me.RIF.Text.Length > 1) Then
                Dim count As Integer = Me.RIF.Text.Length - 1
                If (Char.IsDigit(Me.RIF.Text(count)) = False) Then
                    Me.RIF.TabIndex = Me.RIF.Text.Length - 1
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "JURIDICO") Then
            If (NOMBRE.Text <> "" And RIF.Text <> "" And TELEFONO.Text <> "" And DIRECCION.Text <> "") Then
                If (MsgBox("Seguro que desea Ingresar al Cliente: " & NOMBRE.Text, MsgBoxStyle.YesNo, "Verificar") = MsgBoxResult.Yes) Then
                    If (Cliente.Ingresar_Cliente(RIF.Text, NOMBRE.Text, TELEFONO.Text, DIRECCION.Text)) Then
                        MsgBox("El Cliente se ingreso con Exito", MsgBoxStyle.OkOnly, "Informacion")
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
        ElseIf (ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "NATURAL" Or ComboBox1.Items().Item(ComboBox1.SelectedIndex).ToString = "EXTRANJERO") Then
            If (NOMBRE.Text <> "" And APELLIDO.Text <> "" And RIF.Text <> "" And TELEFONO.Text <> "" And DIRECCION.Text <> "") Then
                If (MsgBox("Seguro que desea Ingresar al Cliente: " & NOMBRE.Text & " " & APELLIDO.Text, MsgBoxStyle.YesNo, "Verificar") = MsgBoxResult.Yes) Then
                    If (Cliente.Ingresar_Cliente(RIF.Text, NOMBRE.Text, APELLIDO.Text, TELEFONO.Text, DIRECCION.Text)) Then
                        MsgBox("El Cliente se ingreso con Exito", MsgBoxStyle.OkOnly, "Informacion")
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
End Class