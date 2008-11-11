Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Cliente As Cliente
        Cliente = New Cliente
        If (MsgBox("Seguro que desea Ingresar a: " & Nombre.Text & " " & Apellido.Text & " en la Base de Datos ", MsgBoxStyle.YesNo, "Confirmacion ") = MsgBoxResult.Yes) Then
            Cliente.Ingresar(Nombre.Text, Apellido.Text, Tipo_Identidad.Text, Numero_Identidad.Text, Telefono.Text, Direccion.Text)
            Me.Close()
        End If
    End Sub


    Private Sub CLIENTEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTEBindingNavigatorSaveItem.Click
        Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.CLIENTETableAdapter.Update(Me.FarmaciaSJDataSet.CLIENTE)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.CLIENTE' table. You can move, or remove it, as needed.
        Me.CLIENTETableAdapter.Fill(Me.FarmaciaSJDataSet.CLIENTE)

    End Sub
End Class