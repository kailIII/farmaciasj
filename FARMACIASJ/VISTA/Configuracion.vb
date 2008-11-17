Public Class Configuracion

    Private Sub FARMACIABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FARMACIABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FARMACIABindingSource.EndEdit()
        Me.FARMACIATableAdapter.Update(Me.FarmaciaSJDataSet.FARMACIA)

    End Sub

    Private Sub Configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.FARMACIA' table. You can move, or remove it, as needed.
        Me.FARMACIATableAdapter.Fill(Me.FarmaciaSJDataSet.FARMACIA)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        LogoPictureBox.ImageLocation = OpenFileDialog1.FileName.ToString
    End Sub
End Class