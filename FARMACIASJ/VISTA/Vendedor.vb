Imports System.Windows.Forms

Public Class Vendedor
    Private Sub PuntoDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuntoDeVentaToolStripMenuItem.Click
        Dim ControladorF As Controlador_Venta
        ControladorF = New Controlador_Venta
        ControladorF.Abrir_Venta(Me)
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim Ven As FARMACIASJ_SESION
        Ven = New FARMACIASJ_SESION
        Ven.Activate()
        Ven.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub CerrarProgramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarProgramaToolStripMenuItem.Click
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub DatosFarmaciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosFarmaciaToolStripMenuItem.Click
        Dim Configuracion As Configuracion
        Configuracion = New Configuracion
        Configuracion.MdiParent = Me
        Configuracion.Show()
    End Sub
End Class
