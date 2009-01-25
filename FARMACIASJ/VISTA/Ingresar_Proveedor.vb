Public Class Ingresar_Proveedor

    Public Arreglo As Array = Array.CreateInstance(GetType(Int32), 10)

    Private Sub Boton_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registrar.Click
        Dim Controlador_Proveedor As Controlador_Proveedor = New Controlador_Proveedor
        ' ATENCION
        'Acá pensé ponerle la parte del boton modificar cuando lo accionamos para habilitar los campos
        'pero a la final lo coloqué en controlador
        Controlador_Proveedor.Ingresando_Proveedor(Arreglo, Me, Codigo.Text, Rif.Text, Nombre.Text, Correo.Text, Dir.Text, Ciudad.Text, Saldo.Text)
        'Registrando los productos_proveedor

    End Sub





    Private Sub Cod_producto_TextChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs)
        ' Dim Proveedor_x As Controlador_Proveedor = New Controlador_Proveedor

        If (e.KeyChar = Char.ConvertFromUtf32(13)) Then
            'Si existe el codigo de barras lo deberia insertar en el datagrid
            If (Me.Boton_Registrar.Text = "Registrar") Then


            ElseIf Me.Boton_Registrar.Text = "Guardar" Then
                Dim Proveedor_y As Proveedor = New Proveedor
                Dim Numero As Integer = Proveedor_y.Existe_Proveedor(Me.Codigo.Text, True)
            End If
        End If
    End Sub

    Private Sub Rif_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rif.TextChanged
        If (Me.Rif.Text.Length = 1) Then
            If (Me.Rif.Text(0) = Char.Parse("J") Or Me.Rif.Text(0) = Char.Parse("G")) Then
                Me.Rif.MaxLength = 10
            ElseIf (Me.Rif.Text(0) = Char.Parse("V") Or Me.Rif.Text(0) = Char.Parse("E")) Then
                Me.Rif.MaxLength = 9
            ElseIf (Me.Rif.Text(0) = Char.Parse("P")) Then
                Me.Rif.MaxLength = 12
            Else
                Me.Rif.Text = ""
            End If
        ElseIf (Me.Rif.Text.Length > 1) Then
            Dim count As Integer
            count = Me.Rif.Text.Length - 1
            If (Char.IsDigit(Me.Rif.Text(count)) = False) Then
                Dim A As String
                A = Me.Rif.Text
                A = A.Substring(0, count)
                Me.Rif.Text = A
                Me.Rif.SelectionStart = Me.Rif.Text.Length
            End If
        End If
    End Sub

    Private Sub Ingresar_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ControladorF As Controlador_Proveedor
        ControladorF = New Controlador_Proveedor
        Dim C As Integer
        C = ControladorF.CantidadP()
        C = C + 1
        If (C < 10) Then
            Me.Codigo.Text = "Pr00" & C
        ElseIf (C < 100) Then
            Me.Codigo.Text = "Pr0" & C
        Else
            Me.Codigo.Text = "Pr" & C
        End If
    End Sub
End Class