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
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(9, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(948, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PuntoDeVentaToolStripMenuItem, Me.DeToolStripMenuItem, Me.RegToolStripMenuItem})
        Me.VentaToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.VentaToolStripMenuItem.Text = "&Venta"
        '
        'PuntoDeVentaToolStripMenuItem
        '
        Me.PuntoDeVentaToolStripMenuItem.Name = "PuntoDeVentaToolStripMenuItem"
        Me.PuntoDeVentaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PuntoDeVentaToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.PuntoDeVentaToolStripMenuItem.Text = "Punto_De_Venta"
        '
        'DeToolStripMenuItem
        '
        Me.DeToolStripMenuItem.Name = "DeToolStripMenuItem"
        Me.DeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.DeToolStripMenuItem.Text = "&Devolucion_Venta"
        '
        'RegToolStripMenuItem
        '
        Me.RegToolStripMenuItem.Name = "RegToolStripMenuItem"
        Me.RegToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.RegToolStripMenuItem.Text = "Registrar Pedidos"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarClienteToolStripMenuItem, Me.ConsultarClienteToolStripMenuItem, Me.ModificarClienteToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ClienteToolStripMenuItem.Text = "&Cliente"
        '
        'IngresarClienteToolStripMenuItem
        '
        Me.IngresarClienteToolStripMenuItem.Name = "IngresarClienteToolStripMenuItem"
        Me.IngresarClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.IngresarClienteToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.IngresarClienteToolStripMenuItem.Text = "Ingresar_Cliente"
        '
        'ConsultarClienteToolStripMenuItem
        '
        Me.ConsultarClienteToolStripMenuItem.Name = "ConsultarClienteToolStripMenuItem"
        Me.ConsultarClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConsultarClienteToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ConsultarClienteToolStripMenuItem.Text = "Consultar_Cliente"
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(253, 22)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar_Cliente"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosFarmaciaToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "C&onfiguracion"
        '
        'DatosFarmaciaToolStripMenuItem
        '
        Me.DatosFarmaciaToolStripMenuItem.Name = "DatosFarmaciaToolStripMenuItem"
        Me.DatosFarmaciaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DatosFarmaciaToolStripMenuItem.Text = "Datos_Farmacia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.CerrarProgramaToolStripMenuItem})
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar_Sesion"
        '
        'CerrarProgramaToolStripMenuItem
        '
        Me.CerrarProgramaToolStripMenuItem.Name = "CerrarProgramaToolStripMenuItem"
        Me.CerrarProgramaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.CerrarProgramaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.CerrarProgramaToolStripMenuItem.Text = "Cerrar_Programa"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 542)
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
        'Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 564)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosFarmaciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
