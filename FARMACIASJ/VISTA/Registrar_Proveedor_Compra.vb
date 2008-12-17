Public Class Registrar_Proveedor_Compra
    Public Proveedor As Controlador_Proveedor
    Private Sub Ciudad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ciudad.TextChanged
        If (Char.IsDigit(Me.Ciudad.Text(Me.Ciudad.Text.Length - 1)) = True) Then
            Dim A As String
            A = Me.Ciudad.Text
            A = A.Substring(0, Me.Ciudad.Text.Length)
            Me.Ciudad.Text = A
            Me.Ciudad.SelectionStart = Me.Ciudad.Text.Length
        End If
    End Sub

    Private Sub Saldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Saldo.TextChanged
        If (Char.IsDigit(Me.Saldo.Text(Me.Saldo.Text.Length - 1)) = False) Then
            Dim A As String
            A = Me.Saldo.Text
            A = A.Substring(0, Me.Saldo.Text.Length)
            Me.Saldo.Text = A
            Me.Saldo.SelectionStart = Me.Saldo.Text.Length
        End If
    End Sub

    Private Sub TLF_Cod_Area_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLF_Cod_Area.TextChanged
        If (Me.TLF_Cod_Area.Text.Length = 1) Then
            If (Me.TLF_Cod_Area.Text(0) <> Char.Parse("0")) Then
                Me.TLF_Cod_Area.Text = ""
            End If
        ElseIf (Me.TLF_Cod_Area.Text.Length > 1) Then
            If (Char.IsDigit(Me.TLF_Cod_Area.Text(Me.TLF_Cod_Area.Text.Length - 1)) = False Or Me.TLF_Cod_Area.Text(Me.TLF_Cod_Area.Text.Length - 1) = Char.Parse("0")) Then
                Dim A As String
                A = Me.TLF_Cod_Area.Text
                A = A.Substring(0, Me.TLF_Cod_Area.Text.Length)
                Me.TLF_Cod_Area.Text = A
                Me.TLF_Cod_Area.SelectionStart = Me.TLF_Cod_Area.Text.Length
            End If
        End If
    End Sub

    Private Sub TLF_Numero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLF_Numero.TextChanged
        If (Me.TLF_Numero.Text.Length >= 1) Then
            If (Char.IsDigit(Me.TLF_Numero.Text(Me.TLF_Numero.Text.Length - 1)) = False) Then
                Dim A As String
                A = Me.TLF_Numero.Text
                A = A.Substring(0, Me.TLF_Numero.Text.Length)
                Me.TLF_Numero.Text = A
                Me.TLF_Numero.SelectionStart = Me.TLF_Numero.Text.Length
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Telefono As String
        Telefono = Me.TLF_Cod_Area.Text & "-" & Me.TLF_Numero.Text
        Telefonos.Items.Add(Telefono)
        Me.TLF_Cod_Area.Text = ""
        Me.TLF_Numero.Text = ""
    End Sub

    Private Sub Boton_Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Registrar.Click
        Dim a As Boolean
        If (MsgBox("Esta seguro de Ingresar al Proveedor: " & Me.Nombre.Text, MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.Yes) Then
            a = Proveedor.Ingresando_Proveedor2(Me.Rif.Text, Me.Nombre.Text, Me.Ciudad.Text, Me.Dir.Text, Me.Telefonos, Codigo.Text, Me.Correo.Text, Me.Saldo.Text, Me)
            If (a = True) Then
                MsgBox("Se Ingreso el proveedor con Exito", MsgBoxStyle.OkOnly, "Informacion")
                Proveedor.Buscar_Rif(Rif.Text, Proveedor.Compra)
            Else
                MsgBox("El proveedor no se pudo ingresar, verifique e intente de nuevo", MsgBoxStyle.OkOnly, "Error")
            End If
        End If
    End Sub

    Private Sub Registrar_Proveedor_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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