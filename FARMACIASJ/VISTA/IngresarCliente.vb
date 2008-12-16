Public Class IngresarCliente

    Private Sub CLIENTEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.CLIENTETableAdapter.Update(Me.FarmaciaSJDataSet.CLIENTE)

    End Sub

    Private Sub IngresarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.CLIENTE' table. You can move, or remove it, as needed.
        Me.CLIENTETableAdapter.Fill(Me.FarmaciaSJDataSet.CLIENTE)
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.CLIENTE' table. You can move, or remove it, as needed.
        Me.CLIENTETableAdapter.Fill(Me.FarmaciaSJDataSet.CLIENTE)
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.CLIENTE' table. You can move, or remove it, as needed.
        Me.CLIENTETableAdapter.Fill(Me.FarmaciaSJDataSet.CLIENTE)
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.CLIENTE' table. You can move, or remove it, as needed.
        Me.CLIENTETableAdapter.Fill(Me.FarmaciaSJDataSet.CLIENTE)

    End Sub

    Private Sub CLIENTEBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.CLIENTETableAdapter.Update(Me.FarmaciaSJDataSet.CLIENTE)

    End Sub

    Private Sub CLIENTEBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.CLIENTETableAdapter.Update(Me.FarmaciaSJDataSet.CLIENTE)

    End Sub

    Private Sub CLIENTEBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CLIENTEBindingSource.EndEdit()
        Me.CLIENTETableAdapter.Update(Me.FarmaciaSJDataSet.CLIENTE)

    End Sub
End Class