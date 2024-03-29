Imports System.Windows.Forms

Public Class Administrador

    Private Sub PuntoDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuntoDeVentaToolStripMenuItem.Click
        Dim ControladorV As New Controlador_Venta
        ControladorV.Abrir_Venta(Me)
    End Sub

    Private Sub IngresarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarProductoToolStripMenuItem.Click
        Dim ControladorP As New Controlador_Producto
        ControladorP.Abrir_Venta(Me)
    End Sub

    Private Sub RegistrarPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarPedidosToolStripMenuItem.Click
        Dim ControladorP As New Controlador_Pedido_Frecuente
        ControladorP.Abrir_Venta(Me)
    End Sub

    Private Sub IngresarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarToolStripMenuItem2.Click
        Dim ControladorL As New Controlador_Linea
        ControladorL.Abrir_Venta(Me)
    End Sub

    Private Sub IngresarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarToolStripMenuItem.Click
        Dim ControladorP As New Controlador_Proveedor
        ControladorP.Abrir_VentaI(Me)
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim ControladorP As New Controlador_Proveedor
        ControladorP.Abrir_VentaC(Me)
    End Sub

    Private Sub RegistrarCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarCompraToolStripMenuItem.Click
        Dim ControladorC As New Controlador_Compra
        ControladorC.Abrir_Venta(Me)
    End Sub

    Private Sub CERRARSESIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARSESIONToolStripMenuItem.Click
        Dim Ven As FARMACIASJ_SESION
        Ven = New FARMACIASJ_SESION
        Ven.Activate()
        Ven.Show()
        Me.Finalize()
        Me.Close()
    End Sub

    Private Sub CERRARPROGRAMAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARPROGRAMAToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ModificarToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem2.Click
        Dim ControladorL As New Controlador_Linea
        ControladorL.Abrir_VentaM(Me)
    End Sub

    Private Sub ModificarProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarProductoToolStripMenuItem.Click
        Dim ControladorP As New Controlador_Producto
        ControladorP.Abrir_VentaM(Me)
    End Sub

    Private Sub ReclamosProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReclamosProveedorToolStripMenuItem.Click
        Dim ControladorC As New Controlador_Compra
        ControladorC.Abrir_VentaM(Me)
    End Sub

    Private Sub SupenderPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupenderPedidosToolStripMenuItem.Click
        Dim ControladorP As New Controlador_Pedido_Frecuente
        ControladorP.Abrir_VentaS(Me)
    End Sub


    'LZ
    Private Sub DevolverFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolverFacturaToolStripMenuItem.Click
        Dim Controlador_Venta_x As New Controlador_Venta
        Controlador_Venta_x.Abrir_Ventana_Devolucion(Me)
    End Sub


    Private Sub AsignarSueldoCargoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarSueldoCargoToolStripMenuItem.Click
        Dim Ventana As New Controlador_Empleado
        Ventana.Abrir_Ventana_Modificar_Sueldo(Me)
    End Sub

    Private Sub ContratarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContratarToolStripMenuItem.Click
        Dim Ventana As New Controlador_Empleado
        Ventana.Abrir_Ventana_Contratar_Empleado(Me)
    End Sub

    Private Sub DespedirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespedirToolStripMenuItem1.Click
        Dim Ventana As New Controlador_Empleado
        Ventana.Abrir_Ventana_Despedir_Empleado(Me)
    End Sub


    'Fin LZ

    Private Sub ConfigurarFarmaciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurarFarmaciaToolStripMenuItem.Click
        Dim Configuracion As Configuracion
        Configuracion = New Configuracion
        Configuracion.MdiParent = Me
        Configuracion.Show()
    End Sub


    Private Sub IngresarOtrosGastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarOtrosGastosToolStripMenuItem.Click
        Dim Gastos As Controlador_OtrosGastos

        Gastos = New Controlador_OtrosGastos(Me)
        Gastos.Abrir_Ingresar_Gasto()
    End Sub

    Private Sub ReporteDeOtrosGastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeOtrosGastosToolStripMenuItem.Click
        Dim Gastos As Controlador_OtrosGastos

        Gastos = New Controlador_OtrosGastos(Me)
        Gastos.Abrir_Reporte()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim Ventana As New Controlador_Proveedor
        Ventana.Abrir_Ventana_Eliminar_Proveedor(Me)
    End Sub

    Private Sub ReporteDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDeEmpleadosToolStripMenuItem.Click
        Dim Proveedor As New Controlador_Empleado
        Proveedor.Abrir_Reporte(Me)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim About As New AboutBox1
        About.MdiParent = Me
        About.Show()
    End Sub

    Private Sub AplicarImpuestoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplicarImpuestoToolStripMenuItem.Click
        Dim Impuesto As Controlador_Impuesto

        Impuesto = New Controlador_Impuesto(Me)
        Impuesto.Abrir_Impuesto()
    End Sub
End Class
