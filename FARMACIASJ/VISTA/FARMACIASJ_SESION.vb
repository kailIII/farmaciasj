Public Class FARMACIASJ_SESION

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Admin As Administrador
        Dim Ven As Vendedor
        If (UsernameTextBox.Text = "VENDEDOR") Then
            If (PasswordTextBox.Text = "123") Then
                Ven = New Vendedor
                Ven.Activate()
                Ven.Show()
                Me.Finalize()
                Me.Close()
            Else
                MsgBox("EL Login o Password es incorrecto", MsgBoxStyle.OkOnly, "FarmaciaSJ-ERROR")
            End If
        Else If (UsernameTextBox.Text = "ADMINISTRADOR") Then
            If (PasswordTextBox.Text = "123") Then
                Admin = New Administrador
                Admin.Activate()
                Admin.Show()
                Me.Finalize()
                Me.Close()
            Else
                MsgBox("EL Login o Password es incorrecto", MsgBoxStyle.OkOnly, "FarmaciaSJ-ERROR")
            End If
        Else
            MsgBox("EL Login o Password es incorrecto", MsgBoxStyle.OkOnly, "FarmaciaSJ-ERROR")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub FARMACIABindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FARMACIABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FARMACIABindingSource.EndEdit()
        Me.FARMACIATableAdapter.Update(Me.FarmaciaSJDataSet.FARMACIA)

    End Sub

    Private Sub FARMACIASJ_SESION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FarmaciaSJDataSet.FARMACIA' table. You can move, or remove it, as needed.
        Me.FARMACIATableAdapter.Fill(Me.FarmaciaSJDataSet.FARMACIA)

    End Sub
End Class
