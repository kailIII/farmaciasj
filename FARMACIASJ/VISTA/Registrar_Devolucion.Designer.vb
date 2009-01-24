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
        Me.Procesar = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Impuesto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Sub_Total = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Devolver = New System.Windows.Forms.Button
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Descuento = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Punitario = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.NombreP = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Codigo_Barras = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Detalle_DEV = New System.Windows.Forms.DataGridView
        Me.Direccion = New System.Windows.Forms.TextBox
        Me.Telefono = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Razon_Social = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Rif = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DETALLE_VENTA = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Fecha_Compra = New System.Windows.Forms.DateTimePicker
        Me.Vence1 = New System.Windows.Forms.DateTimePicker
        Me.Numero_Control = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Detalle_DEV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DETALLE_VENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Procesar
        '
        Me.Procesar.Enabled = False
        Me.Procesar.Location = New System.Drawing.Point(760, 575)
        Me.Procesar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Procesar.Name = "Procesar"
        Me.Procesar.Size = New System.Drawing.Size(248, 28)
        Me.Procesar.TabIndex = 11
        Me.Procesar.Text = "Procesar"
        Me.Procesar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Total)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Impuesto)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Sub_Total)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(759, 439)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(250, 128)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'Total
        '
        Me.Total.Enabled = False
        Me.Total.Location = New System.Drawing.Point(106, 87)
        Me.Total.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(122, 22)
        Me.Total.TabIndex = 5
        Me.Total.Text = "0,0"
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 91)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total:"
        '
        'Impuesto
        '
        Me.Impuesto.Enabled = False
        Me.Impuesto.Location = New System.Drawing.Point(106, 55)
        Me.Impuesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Size = New System.Drawing.Size(122, 22)
        Me.Impuesto.TabIndex = 3
        Me.Impuesto.Text = "0,0"
        Me.Impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 59)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Impuesto:"
        '
        'Sub_Total
        '
        Me.Sub_Total.Enabled = False
        Me.Sub_Total.Location = New System.Drawing.Point(106, 23)
        Me.Sub_Total.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sub_Total.Name = "Sub_Total"
        Me.Sub_Total.Size = New System.Drawing.Size(122, 22)
        Me.Sub_Total.TabIndex = 1
        Me.Sub_Total.Text = "0,0"
        Me.Sub_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sub-Total:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Devolver)
        Me.GroupBox3.Controls.Add(Me.Cantidad)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Descuento)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Punitario)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.NombreP)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Codigo_Barras)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 439)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(734, 128)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Devolver
        '
        Me.Devolver.Enabled = False
        Me.Devolver.Location = New System.Drawing.Point(556, 87)
        Me.Devolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Devolver.Name = "Devolver"
        Me.Devolver.Size = New System.Drawing.Size(168, 28)
        Me.Devolver.TabIndex = 15
        Me.Devolver.Text = "Devolver"
        Me.Devolver.UseVisualStyleBackColor = True
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(556, 55)
        Me.Cantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cantidad.MaxLength = 3
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(166, 22)
        Me.Cantidad.TabIndex = 14
        Me.Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 91)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 16)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Descuento:"
        '
        'Descuento
        '
        Me.Descuento.Enabled = False
        Me.Descuento.Location = New System.Drawing.Point(106, 87)
        Me.Descuento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Descuento.Name = "Descuento"
        Me.Descuento.Size = New System.Drawing.Size(172, 22)
        Me.Descuento.TabIndex = 9
        Me.Descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(468, 59)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 16)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Cantidad:"
        '
        'Punitario
        '
        Me.Punitario.Enabled = False
        Me.Punitario.Location = New System.Drawing.Point(106, 55)
        Me.Punitario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Punitario.Name = "Punitario"
        Me.Punitario.Size = New System.Drawing.Size(172, 22)
        Me.Punitario.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 59)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Precio:"
        '
        'NombreP
        '
        Me.NombreP.Enabled = False
        Me.NombreP.Location = New System.Drawing.Point(364, 23)
        Me.NombreP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NombreP.Name = "NombreP"
        Me.NombreP.Size = New System.Drawing.Size(358, 22)
        Me.NombreP.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Nombre:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 27)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Código:"
        '
        'Codigo_Barras
        '
        Me.Codigo_Barras.Location = New System.Drawing.Point(106, 23)
        Me.Codigo_Barras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Codigo_Barras.Name = "Codigo_Barras"
        Me.Codigo_Barras.Size = New System.Drawing.Size(172, 22)
        Me.Codigo_Barras.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Detalle_DEV)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 272)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(988, 160)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Devolución"
        '
        'Detalle_DEV
        '
        Me.Detalle_DEV.AllowUserToAddRows = False
        Me.Detalle_DEV.AllowUserToDeleteRows = False
        Me.Detalle_DEV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_DEV.Location = New System.Drawing.Point(10, 23)
        Me.Detalle_DEV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Detalle_DEV.Name = "Detalle_DEV"
        Me.Detalle_DEV.ReadOnly = True
        Me.Detalle_DEV.Size = New System.Drawing.Size(968, 129)
        Me.Detalle_DEV.TabIndex = 15
        '
        'Direccion
        '
        Me.Direccion.Enabled = False
        Me.Direccion.Location = New System.Drawing.Point(405, 48)
        Me.Direccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(574, 22)
        Me.Direccion.TabIndex = 6
        '
        'Telefono
        '
        Me.Telefono.Enabled = False
        Me.Telefono.Location = New System.Drawing.Point(120, 48)
        Me.Telefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(187, 22)
        Me.Telefono.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Teléfono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 52)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Razón social:"
        '
        'Razon_Social
        '
        Me.Razon_Social.Enabled = False
        Me.Razon_Social.Location = New System.Drawing.Point(120, 16)
        Me.Razon_Social.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Razon_Social.Name = "Razon_Social"
        Me.Razon_Social.Size = New System.Drawing.Size(492, 22)
        Me.Razon_Social.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(622, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "R.I.F:"
        '
        'Rif
        '
        Me.Rif.Enabled = False
        Me.Rif.Location = New System.Drawing.Point(681, 16)
        Me.Rif.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rif.Name = "Rif"
        Me.Rif.Size = New System.Drawing.Size(298, 22)
        Me.Rif.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DETALLE_VENTA)
        Me.GroupBox2.Controls.Add(Me.Rif)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Razon_Social)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Telefono)
        Me.GroupBox2.Controls.Add(Me.Direccion)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 70)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(992, 194)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'DETALLE_VENTA
        '
        Me.DETALLE_VENTA.AllowUserToAddRows = False
        Me.DETALLE_VENTA.AllowUserToDeleteRows = False
        Me.DETALLE_VENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DETALLE_VENTA.Location = New System.Drawing.Point(14, 80)
        Me.DETALLE_VENTA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DETALLE_VENTA.Name = "DETALLE_VENTA"
        Me.DETALLE_VENTA.ReadOnly = True
        Me.DETALLE_VENTA.Size = New System.Drawing.Size(968, 100)
        Me.DETALLE_VENTA.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Fecha_Compra)
        Me.GroupBox1.Controls.Add(Me.Vence1)
        Me.GroupBox1.Controls.Add(Me.Numero_Control)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(992, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Factura"
        '
        'Fecha_Compra
        '
        Me.Fecha_Compra.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.Fecha_Compra.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fecha_Compra.Location = New System.Drawing.Point(24, 16)
        Me.Fecha_Compra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Fecha_Compra.Name = "Fecha_Compra"
        Me.Fecha_Compra.Size = New System.Drawing.Size(206, 22)
        Me.Fecha_Compra.TabIndex = 16
        Me.Fecha_Compra.Visible = False
        '
        'Vence1
        '
        Me.Vence1.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.Vence1.Enabled = False
        Me.Vence1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Vence1.Location = New System.Drawing.Point(242, 15)
        Me.Vence1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Vence1.Name = "Vence1"
        Me.Vence1.Size = New System.Drawing.Size(206, 22)
        Me.Vence1.TabIndex = 15
        Me.Vence1.Visible = False
        '
        'Numero_Control
        '
        Me.Numero_Control.Location = New System.Drawing.Point(772, 16)
        Me.Numero_Control.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Numero_Control.Name = "Numero_Control"
        Me.Numero_Control.Size = New System.Drawing.Size(208, 22)
        Me.Numero_Control.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(622, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de control:"
        '
        'Registrar_Devolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 615)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Procesar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Registrar_Devolucion"
        Me.Text = "Registrar Devolución"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Detalle_DEV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DETALLE_VENTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Procesar As System.Windows.Forms.Button
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
    Friend WithEvents Descuento As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Punitario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NombreP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Codigo_Barras As System.Windows.Forms.TextBox
    Friend WithEvents Devolver As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Detalle_DEV As System.Windows.Forms.DataGridView
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Razon_Social As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Rif As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DETALLE_VENTA As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Numero_Control As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Fecha_Compra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Vence1 As System.Windows.Forms.DateTimePicker
End Class
