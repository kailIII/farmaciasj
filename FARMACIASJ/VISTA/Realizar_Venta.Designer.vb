<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Realizar_Venta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Direccion = New System.Windows.Forms.RichTextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Telefono = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Apellido = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nombre = New System.Windows.Forms.TextBox
        Me.Identidad = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Tipo_Identidad = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Numero_Factura = New System.Windows.Forms.Label
        Me.Detalle_Venta = New System.Windows.Forms.DataGridView
        Me.FarmaciaSJDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmaciaSJDataSet = New FARMACIASJ.FarmaciaSJDataSet
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SubtotalP = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.RichTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Punitario = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.NombreP = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Codigo_Barras = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Total = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Impuesto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Sub_Total = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Detalle_Venta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmaciaSJDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Telefono)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Apellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Identidad)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Tipo_Identidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Direccion"
        '
        'Direccion
        '
        Me.Direccion.Enabled = False
        Me.Direccion.Location = New System.Drawing.Point(354, 19)
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(288, 128)
        Me.Direccion.TabIndex = 10
        Me.Direccion.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Telefono"
        '
        'Telefono
        '
        Me.Telefono.Enabled = False
        Me.Telefono.Location = New System.Drawing.Point(121, 127)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(109, 20)
        Me.Telefono.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Apellido"
        '
        'Apellido
        '
        Me.Apellido.Enabled = False
        Me.Apellido.Location = New System.Drawing.Point(121, 101)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(109, 20)
        Me.Apellido.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(121, 77)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(109, 20)
        Me.Nombre.TabIndex = 4
        '
        'Identidad
        '
        Me.Identidad.Location = New System.Drawing.Point(121, 51)
        Me.Identidad.Name = "Identidad"
        Me.Identidad.Size = New System.Drawing.Size(108, 20)
        Me.Identidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Numuero_Identidad"
        '
        'Tipo_Identidad
        '
        Me.Tipo_Identidad.FormattingEnabled = True
        Me.Tipo_Identidad.Items.AddRange(New Object() {"CEDULA", "PASAPORTE", "RIF"})
        Me.Tipo_Identidad.Location = New System.Drawing.Point(120, 19)
        Me.Tipo_Identidad.Name = "Tipo_Identidad"
        Me.Tipo_Identidad.Size = New System.Drawing.Size(110, 21)
        Me.Tipo_Identidad.TabIndex = 1
        Me.Tipo_Identidad.Text = "CEDULA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo_Identidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Numero_Factura)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 46)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Factura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(547, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Numero_Factura
        '
        Me.Numero_Factura.AutoSize = True
        Me.Numero_Factura.Location = New System.Drawing.Point(431, 22)
        Me.Numero_Factura.Name = "Numero_Factura"
        Me.Numero_Factura.Size = New System.Drawing.Size(44, 13)
        Me.Numero_Factura.TabIndex = 0
        Me.Numero_Factura.Text = "Numero"
        '
        'Detalle_Venta
        '
        Me.Detalle_Venta.AutoGenerateColumns = False
        Me.Detalle_Venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_Venta.DataSource = Me.FarmaciaSJDataSetBindingSource
        Me.Detalle_Venta.Location = New System.Drawing.Point(23, 221)
        Me.Detalle_Venta.Name = "Detalle_Venta"
        Me.Detalle_Venta.Size = New System.Drawing.Size(660, 125)
        Me.Detalle_Venta.TabIndex = 2
        '
        'FarmaciaSJDataSetBindingSource
        '
        Me.FarmaciaSJDataSetBindingSource.DataSource = Me.FarmaciaSJDataSet
        Me.FarmaciaSJDataSetBindingSource.Position = 0
        '
        'FarmaciaSJDataSet
        '
        Me.FarmaciaSJDataSet.DataSetName = "FarmaciaSJDataSet"
        Me.FarmaciaSJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.SubtotalP)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Cantidad)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Descripcion)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Punitario)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.NombreP)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Codigo_Barras)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 352)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 122)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SubtotalP
        '
        Me.SubtotalP.Location = New System.Drawing.Point(393, 67)
        Me.SubtotalP.Name = "SubtotalP"
        Me.SubtotalP.Size = New System.Drawing.Size(90, 20)
        Me.SubtotalP.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(338, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Sub-total"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(242, 67)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(90, 20)
        Me.Cantidad.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(193, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Cantiad"
        '
        'Descripcion
        '
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
        Me.Label14.Text = "Descripcion"
        '
        'Punitario
        '
        Me.Punitario.Location = New System.Drawing.Point(97, 70)
        Me.Punitario.Name = "Punitario"
        Me.Punitario.Size = New System.Drawing.Size(90, 20)
        Me.Punitario.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Prcio-Unitario"
        '
        'NombreP
        '
        Me.NombreP.Location = New System.Drawing.Point(97, 44)
        Me.NombreP.Name = "NombreP"
        Me.NombreP.Size = New System.Drawing.Size(90, 20)
        Me.NombreP.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Codigo_Barras"
        '
        'Codigo_Barras
        '
        Me.Codigo_Barras.Location = New System.Drawing.Point(97, 18)
        Me.Codigo_Barras.Name = "Codigo_Barras"
        Me.Codigo_Barras.Size = New System.Drawing.Size(90, 20)
        Me.Codigo_Barras.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Total)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Impuesto)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Sub_Total)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(516, 352)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(167, 122)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totales"
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(71, 80)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(83, 20)
        Me.Total.TabIndex = 5
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
        Me.Impuesto.Location = New System.Drawing.Point(71, 54)
        Me.Impuesto.Name = "Impuesto"
        Me.Impuesto.Size = New System.Drawing.Size(83, 20)
        Me.Impuesto.TabIndex = 3
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
        Me.Sub_Total.Location = New System.Drawing.Point(71, 28)
        Me.Sub_Total.Name = "Sub_Total"
        Me.Sub_Total.Size = New System.Drawing.Size(83, 20)
        Me.Sub_Total.TabIndex = 1
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(298, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Procesar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:MM:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Realizar_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 535)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Detalle_Venta)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Realizar_Venta"
        Me.Text = "RealizarVenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Detalle_Venta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmaciaSJDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tipo_Identidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Identidad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Numero_Factura As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Detalle_Venta As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Impuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Sub_Total As System.Windows.Forms.TextBox
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FarmaciaSJDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FarmaciaSJDataSet As FARMACIASJ.FarmaciaSJDataSet
    Friend WithEvents NombreP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Codigo_Barras As System.Windows.Forms.TextBox
    Friend WithEvents Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Punitario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents SubtotalP As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
