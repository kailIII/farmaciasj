<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedor
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PuntoDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasswordUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatosFarmaciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuntoDeVentaToolStripMenuItem, Me.DeToolStripMenuItem, Me.RegToolStripMenuItem})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.VentaToolStripMenuItem.Text = "&Venta"
        '
        'PuntoDeVentaToolStripMenuItem
        '
        Me.PuntoDeVentaToolStripMenuItem.Name = "PuntoDeVentaToolStripMenuItem"
        Me.PuntoDeVentaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PuntoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.PuntoDeVentaToolStripMenuItem.Text = "Punto_De_Venta"
        '
        'DeToolStripMenuItem
        '
        Me.DeToolStripMenuItem.Name = "DeToolStripMenuItem"
        Me.DeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.DeToolStripMenuItem.Text = "&Devolucion_Venta"
        '
        'RegToolStripMenuItem
        '
        Me.RegToolStripMenuItem.Name = "RegToolStripMenuItem"
        Me.RegToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.RegToolStripMenuItem.Text = "Registrar Pedidos"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarClienteToolStripMenuItem, Me.ConsultarClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ClienteToolStripMenuItem.Text = "&Cliente"
        '
        'IngresarClienteToolStripMenuItem
        '
        Me.IngresarClienteToolStripMenuItem.Name = "IngresarClienteToolStripMenuItem"
        Me.IngresarClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.IngresarClienteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.IngresarClienteToolStripMenuItem.Text = "Ingresar_Cliente"
        '
        'ConsultarClienteToolStripMenuItem
        '
        Me.ConsultarClienteToolStripMenuItem.Name = "ConsultarClienteToolStripMenuItem"
        Me.ConsultarClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultarClienteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ConsultarClienteToolStripMenuItem.Text = "Consultar_Cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar_Cliente"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasswordUsuarioToolStripMenuItem, Me.FacturaToolStripMenuItem, Me.DatosFarmaciaToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "C&onfiguracion"
        '
        'PasswordUsuarioToolStripMenuItem
        '
        Me.PasswordUsuarioToolStripMenuItem.Name = "PasswordUsuarioToolStripMenuItem"
        Me.PasswordUsuarioToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PasswordUsuarioToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.PasswordUsuarioToolStripMenuItem.Text = "Password_Usuario"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.FacturaToolStripMenuItem.Text = "Factura"
        '
        'DatosFarmaciaToolStripMenuItem
        '
        Me.DatosFarmaciaToolStripMenuItem.Name = "DatosFarmaciaToolStripMenuItem"
        Me.DatosFarmaciaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DatosFarmaciaToolStripMenuItem.Text = "Datos_Farmacia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.CerrarProgramaToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar_Sesion"
        '
        'CerrarProgramaToolStripMenuItem
        '
        Me.CerrarProgramaToolStripMenuItem.Name = "CerrarProgramaToolStripMenuItem"
        Me.CerrarProgramaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.CerrarProgramaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CerrarProgramaToolStripMenuItem.Text = "Cerrar_Programa"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 436)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 458)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Vendedor"
        Me.Text = "VENDEDOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuntoDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosFarmaciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
