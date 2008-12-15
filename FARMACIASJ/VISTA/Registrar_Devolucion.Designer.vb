<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Devolucion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DETALLE_VENTA = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Impuesto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Sub_Total = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SubtotalP = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Descuento = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.RichTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Punitario = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.NombreP = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Codigo_Barras = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Identidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Nombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Telefono = New System.Windows.Forms.TextBox
        Me.Direccion = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.DETALLE_VENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(555, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de control"
        '
        'DETALLE_VENTA
        '
        Me.DETALLE_VENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_VENTA.Location = New System.Drawing.Point(12, 142)
        Me.DETALLE_VENTA.Name = "DETALLE_VENTA"
        Me.DETALLE_VENTA.Size = New System.Drawing.Size(660, 144)
        Me.DETALLE_VENTA.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(521, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Procesar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Total)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Impuesto)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Sub_Total)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(506, 292)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(167, 122)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'Total
        '
        Me.Total.Enabled = False
        Me.Total.Location = New System.Drawing.Point(71, 80)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(83, 20)
        Me.Total.TabIndex = 5
        Me.Total.Text = "0,0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total"
        '
        'Impuesto
        '
        Me.Impuesto.Enabled = False
        Me.Impuesto.Location = New System.Drawing.Point(71, 54)
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Size = New System.Drawing.Size(83, 20)
        Me.Impuesto.TabIndex = 3
        Me.Impuesto.Text = "0,0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Impuesto"
        '
        'Sub_Total
        '
        Me.Sub_Total.Enabled = False
        Me.Sub_Total.Location = New System.Drawing.Point(71, 28)
        Me.Sub_Total.Name = "Sub_Total"
        Me.Sub_Total.Size = New System.Drawing.Size(83, 20)
        Me.Sub_Total.TabIndex = 1
        Me.Sub_Total.Text = "0,0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sub-Total"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cantidad)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.SubtotalP)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Descuento)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Descripcion)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Punitario)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.NombreP)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Codigo_Barras)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 122)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(266, 66)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(69, 20)
        Me.Cantidad.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Descuento"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(393, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SubtotalP
        '
        Me.SubtotalP.Enabled = False
        Me.SubtotalP.Location = New System.Drawing.Point(393, 66)
        Me.SubtotalP.Name = "SubtotalP"
        Me.SubtotalP.Size = New System.Drawing.Size(90, 20)
        Me.SubtotalP.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(340, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Sub-Total"
        '
        'Descuento
        '
        Me.Descuento.Enabled = False
        Me.Descuento.Location = New System.Drawing.Point(71, 97)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(116, 20)
        Me.Descuento.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(199, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Cantidad"
        '
        'Descripcion
        '
        Me.Descripcion.Enabled = False
        Me.Descripcion.Location = New System.Drawing.Point(266, 18)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(217, 39)
        Me.Descripcion.TabIndex = 7
        Me.Descripcion.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(199, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Descripción"
        '
        'Punitario
        '
        Me.Punitario.Enabled = False
        Me.Punitario.Location = New System.Drawing.Point(71, 71)
        Me.Punitario.Name = "Punitario"
        Me.Punitario.Size = New System.Drawing.Size(116, 20)
        Me.Punitario.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Precio"
        '
        'NombreP
        '
        Me.NombreP.Enabled = False
        Me.NombreP.Location = New System.Drawing.Point(71, 45)
        Me.NombreP.Name = "NombreP"
        Me.NombreP.Size = New System.Drawing.Size(116, 20)
        Me.NombreP.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Código"
        '
        'Codigo_Barras
        '
        Me.Codigo_Barras.Location = New System.Drawing.Point(71, 19)
        Me.Codigo_Barras.Name = "Codigo_Barras"
        Me.Codigo_Barras.Size = New System.Drawing.Size(116, 20)
        Me.Codigo_Barras.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Identidad)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Nombre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Telefono)
        Me.GroupBox2.Controls.Add(Me.Direccion)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 70)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'Identidad
        '
        Me.Identidad.Location = New System.Drawing.Point(454, 13)
        Me.Identidad.Name = "Identidad"
        Me.Identidad.Size = New System.Drawing.Size(200, 20)
        Me.Identidad.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(415, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "R.I.F:"
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(80, 13)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(329, 20)
        Me.Nombre.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Razón social:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Teléfono"
        '
        'Telefono
        '
        Me.Telefono.Enabled = False
        Me.Telefono.Location = New System.Drawing.Point(80, 39)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(126, 20)
        Me.Telefono.TabIndex = 8
        '
        'Direccion
        '
        Me.Direccion.Enabled = False
        Me.Direccion.Location = New System.Drawing.Point(270, 39)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(384, 20)
        Me.Direccion.TabIndex = 6
        '
        'Registrar_Devolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 450)
        Me.Controls.Add(Me.DETALLE_VENTA)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registrar_Devolucion"
        Me.Text = "Registrar Devolución"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DETALLE_VENTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DETALLE_VENTA As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Impuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Sub_Total As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SubtotalP As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Descuento As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Punitario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NombreP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Codigo_Barras As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Identidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
End Class
