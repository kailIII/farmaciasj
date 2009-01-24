<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PuntoDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevolverFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrarPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupenderPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LineaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrarCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReclamosProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ContratarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignarSueldoCargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DespedirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReporteDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarOtrosGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReporteDeOtrosGastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigurarFarmaciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CERRARSESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CERRARPROGRAMAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.CompraToolStripMenuItem, Me.EmpleadoToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(948, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuntoDeVentaToolStripMenuItem, Me.DevolverFacturaToolStripMenuItem, Me.RegistrarPedidosToolStripMenuItem, Me.SupenderPedidosToolStripMenuItem})
        Me.VentaToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'PuntoDeVentaToolStripMenuItem
        '
        Me.PuntoDeVentaToolStripMenuItem.Name = "PuntoDeVentaToolStripMenuItem"
        Me.PuntoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.PuntoDeVentaToolStripMenuItem.Text = "Punto de Venta"
        '
        'DevolverFacturaToolStripMenuItem
        '
        Me.DevolverFacturaToolStripMenuItem.Name = "DevolverFacturaToolStripMenuItem"
        Me.DevolverFacturaToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.DevolverFacturaToolStripMenuItem.Text = "Devolver Factura"
        '
        'RegistrarPedidosToolStripMenuItem
        '
        Me.RegistrarPedidosToolStripMenuItem.Name = "RegistrarPedidosToolStripMenuItem"
        Me.RegistrarPedidosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.RegistrarPedidosToolStripMenuItem.Text = "Registrar Pedidos"
        '
        'SupenderPedidosToolStripMenuItem
        '
        Me.SupenderPedidosToolStripMenuItem.Name = "SupenderPedidosToolStripMenuItem"
        Me.SupenderPedidosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SupenderPedidosToolStripMenuItem.Text = "Supender Pedidos"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductoToolStripMenuItem, Me.LineaToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarProductoToolStripMenuItem, Me.ModificarProductoToolStripMenuItem})
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'IngresarProductoToolStripMenuItem
        '
        Me.IngresarProductoToolStripMenuItem.Name = "IngresarProductoToolStripMenuItem"
        Me.IngresarProductoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.IngresarProductoToolStripMenuItem.Text = "Ingresar Producto"
        '
        'ModificarProductoToolStripMenuItem
        '
        Me.ModificarProductoToolStripMenuItem.Name = "ModificarProductoToolStripMenuItem"
        Me.ModificarProductoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ModificarProductoToolStripMenuItem.Text = "Modificar Producto"
        '
        'LineaToolStripMenuItem
        '
        Me.LineaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem2, Me.ModificarToolStripMenuItem2})
        Me.LineaToolStripMenuItem.Name = "LineaToolStripMenuItem"
        Me.LineaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LineaToolStripMenuItem.Text = "Linea"
        '
        'IngresarToolStripMenuItem2
        '
        Me.IngresarToolStripMenuItem2.Name = "IngresarToolStripMenuItem2"
        Me.IngresarToolStripMenuItem2.Size = New System.Drawing.Size(148, 22)
        Me.IngresarToolStripMenuItem2.Text = "Ingresar"
        '
        'ModificarToolStripMenuItem2
        '
        Me.ModificarToolStripMenuItem2.Name = "ModificarToolStripMenuItem2"
        Me.ModificarToolStripMenuItem2.Size = New System.Drawing.Size(148, 22)
        Me.ModificarToolStripMenuItem2.Text = "Modificar"
        '
        'CompraToolStripMenuItem
        '
        Me.CompraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedorToolStripMenuItem, Me.RegistrarCompraToolStripMenuItem, Me.ReclamosProveedorToolStripMenuItem})
        Me.CompraToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        Me.CompraToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CompraToolStripMenuItem.Text = "Compra"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'IngresarToolStripMenuItem
        '
        Me.IngresarToolStripMenuItem.Name = "IngresarToolStripMenuItem"
        Me.IngresarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.IngresarToolStripMenuItem.Text = "Ingresar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ConsultarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'RegistrarCompraToolStripMenuItem
        '
        Me.RegistrarCompraToolStripMenuItem.Name = "RegistrarCompraToolStripMenuItem"
        Me.RegistrarCompraToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.RegistrarCompraToolStripMenuItem.Text = "Registrar Compra"
        '
        'ReclamosProveedorToolStripMenuItem
        '
        Me.ReclamosProveedorToolStripMenuItem.Name = "ReclamosProveedorToolStripMenuItem"
        Me.ReclamosProveedorToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ReclamosProveedorToolStripMenuItem.Text = "Modificar Compra"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContratarToolStripMenuItem, Me.AsignarSueldoCargoToolStripMenuItem, Me.DespedirToolStripMenuItem1, Me.ReporteDeEmpleadosToolStripMenuItem, Me.IngresarOtrosGastosToolStripMenuItem, Me.ReporteDeOtrosGastosToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.EmpleadoToolStripMenuItem.Text = "Otros"
        '
        'ContratarToolStripMenuItem
        '
        Me.ContratarToolStripMenuItem.Name = "ContratarToolStripMenuItem"
        Me.ContratarToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.ContratarToolStripMenuItem.Text = "Contratar Empleado"
        '
        'AsignarSueldoCargoToolStripMenuItem
        '
        Me.AsignarSueldoCargoToolStripMenuItem.Name = "AsignarSueldoCargoToolStripMenuItem"
        Me.AsignarSueldoCargoToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.AsignarSueldoCargoToolStripMenuItem.Text = "Modificar Sueldo - Cargo Empleado"
        '
        'DespedirToolStripMenuItem1
        '
        Me.DespedirToolStripMenuItem1.Name = "DespedirToolStripMenuItem1"
        Me.DespedirToolStripMenuItem1.Size = New System.Drawing.Size(312, 22)
        Me.DespedirToolStripMenuItem1.Text = "Despedir Empleado"
        '
        'ReporteDeEmpleadosToolStripMenuItem
        '
        Me.ReporteDeEmpleadosToolStripMenuItem.Name = "ReporteDeEmpleadosToolStripMenuItem"
        Me.ReporteDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.ReporteDeEmpleadosToolStripMenuItem.Text = "Reporte de Empleados"
        '
        'IngresarOtrosGastosToolStripMenuItem
        '
        Me.IngresarOtrosGastosToolStripMenuItem.Name = "IngresarOtrosGastosToolStripMenuItem"
        Me.IngresarOtrosGastosToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.IngresarOtrosGastosToolStripMenuItem.Text = "Ingresar Otros Gastos"
        '
        'ReporteDeOtrosGastosToolStripMenuItem
        '
        Me.ReporteDeOtrosGastosToolStripMenuItem.CheckOnClick = True
        Me.ReporteDeOtrosGastosToolStripMenuItem.Name = "ReporteDeOtrosGastosToolStripMenuItem"
        Me.ReporteDeOtrosGastosToolStripMenuItem.Size = New System.Drawing.Size(312, 22)
        Me.ReporteDeOtrosGastosToolStripMenuItem.Text = "Reporte de Otros Gastos"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarFarmaciaToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuración"
        '
        'ConfigurarFarmaciaToolStripMenuItem
        '
        Me.ConfigurarFarmaciaToolStripMenuItem.Name = "ConfigurarFarmaciaToolStripMenuItem"
        Me.ConfigurarFarmaciaToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ConfigurarFarmaciaToolStripMenuItem.Text = "Configurar Farmacia"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CERRARSESIONToolStripMenuItem, Me.CERRARPROGRAMAToolStripMenuItem})
        Me.SALIRToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'CERRARSESIONToolStripMenuItem
        '
        Me.CERRARSESIONToolStripMenuItem.Name = "CERRARSESIONToolStripMenuItem"
        Me.CERRARSESIONToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CERRARSESIONToolStripMenuItem.Text = "CERRAR SESIÓN"
        '
        'CERRARPROGRAMAToolStripMenuItem
        '
        Me.CERRARPROGRAMAToolStripMenuItem.Name = "CERRARPROGRAMAToolStripMenuItem"
        Me.CERRARPROGRAMAToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.CERRARPROGRAMAToolStripMenuItem.Text = "CERRAR PROGRAMA"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 536)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(948, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Administrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 558)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Administrador"
        Me.Text = "ADMINISTRADOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuntoDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolverFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReclamosProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurarFarmaciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARSESIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARPROGRAMAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupenderPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContratarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarSueldoCargoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DespedirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarOtrosGastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteDeOtrosGastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
