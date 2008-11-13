Public Class Ingresar_Producto

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(TextBox1.Text, Label1.Text) = True) And (validar.espacio_blanco(TextBox1.Text, Label1.Text) = True) And (validar.nulo(TextBox1.Text, Label1.Text))) Then

            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(TextBox2.Text, Label2.Text) = True) And (validar.espacio_blanco(TextBox2.Text, Label2.Text) = True) And (validar.nulo(TextBox2.Text, Label2.Text))) Then

            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(TextBox3.Text, Label3.Text) = True) And (validar.nulo(TextBox3.Text, Label3.Text))) Then

            End If
        End If
    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles RichTextBox1.KeyPress
        Dim validar As Validaciones_Generales
        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            validar = New Validaciones_Generales
            If ((validar.comillas(RichTextBox1.Text, Label4.Text) = True) And (validar.nulo(RichTextBox1.Text, Label4.Text))) Then

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class