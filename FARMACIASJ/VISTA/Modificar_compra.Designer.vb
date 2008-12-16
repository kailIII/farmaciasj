<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_compra
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
        Me.Cerrar = New System.Windows.Forms.Button
        Me.Guardar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.costo_unidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Costo_Total = New System.Windows.Forms.TextBox
        Me.producto = New System.Windows.Forms.ComboBox
        Me.Vencimiento = New System.Windows.Forms.TextBox
        Me.Fecha_compra = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Proveedor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Buscar = New System.Windows.Forms.Button
        Me.factura = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FarmaciaSJDataSet = New FARMACIASJ.FarmaciaSJDataSet
        Me.COMPRABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPRATableAdapter = New FARMACIASJ.FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
        Me.PRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTOTableAdapter = New FARMACIASJ.FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPRABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cerrar
        '
        Me.Cerrar.Location = New System.Drawing.Point(190, 336)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Cerrar.TabIndex = 20
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(109, 336)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 19
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.producto)
        Me.GroupBox1.Controls.Add(Me.Vencimiento)
        Me.GroupBox1.Controls.Add(Me.Fecha_compra)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Proveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 279)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de La Compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.costo_unidad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Cantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Costo_Total)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 115)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de la Compra"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Costo Unidad:"
        '
        'costo_unidad
        '
        Me.costo_unidad.Enabled = False
        Me.costo_unidad.Location = New System.Drawing.Point(96, 30)
        Me.costo_unidad.Name = "costo_unidad"
        Me.costo_unidad.Size = New System.Drawing.Size(187, 20)
        Me.costo_unidad.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad:"
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(96, 53)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(187, 20)
        Me.Cantidad.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Costo Total:"
        '
        'Costo_Total
        '
        Me.Costo_Total.Enabled = False
        Me.Costo_Total.Location = New System.Drawing.Point(96, 76)
        Me.Costo_Total.Name = "Costo_Total"
        Me.Costo_Total.Size = New System.Drawing.Size(187, 20)
        Me.Costo_Total.TabIndex = 14
        '
        'producto
        '
        Me.producto.DataSource = Me.PRODUCTOBindingSource
        Me.producto.DisplayMember = "NOMBRE"
        Me.producto.Enabled = False
        Me.producto.FormattingEnabled = True
        Me.producto.Location = New System.Drawing.Point(108, 117)
        Me.producto.Name = "producto"
        Me.producto.Size = New System.Drawing.Size(218, 21)
        Me.producto.TabIndex = 19
        Me.producto.ValueMember = "NOMBRE"
        '
        'Vencimiento
        '
        Me.Vencimiento.Enabled = False
        Me.Vencimiento.Location = New System.Drawing.Point(108, 56)
        Me.Vencimiento.Name = "Vencimiento"
        Me.Vencimiento.Size = New System.Drawing.Size(218, 20)
        Me.Vencimiento.TabIndex = 18
        '
        'Fecha_compra
        '
        Me.Fecha_compra.Enabled = False
        Me.Fecha_compra.Location = New System.Drawing.Point(108, 27)
        Me.Fecha_compra.Name = "Fecha_compra"
        Me.Fecha_compra.Size = New System.Drawing.Size(218, 20)
        Me.Fecha_compra.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vencimiento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha de Compra:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto:"
        '
        'Proveedor
        '
        Me.Proveedor.Enabled = False
        Me.Proveedor.Location = New System.Drawing.Point(108, 90)
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Size = New System.Drawing.Size(218, 20)
        Me.Proveedor.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Proveedor:"
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(287, 11)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 17
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'factura
        '
        Me.factura.DataSource = Me.COMPRABindingSource
        Me.factura.DisplayMember = "NUMERO_FACTURA_COMPRA"
        Me.factura.FormattingEnabled = True
        Me.factura.Location = New System.Drawing.Point(107, 13)
        Me.factura.Name = "factura"
        Me.factura.Size = New System.Drawing.Size(174, 21)
        Me.factura.TabIndex = 16
        Me.factura.ValueMember = "NUMERO_FACTURA_COMPRA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Numero Factura:"
        '
        'FarmaciaSJDataSet
        '
        Me.FarmaciaSJDataSet.DataSetName = "FarmaciaSJDataSet"
        Me.FarmaciaSJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMPRABindingSource
        '
        Me.COMPRABindingSource.DataMember = "COMPRA"
        Me.COMPRABindingSource.DataSource = Me.FarmaciaSJDataSet
        '
        'COMPRATableAdapter
        '
        Me.COMPRATableAdapter.ClearBeforeFill = True
        '
        'PRODUCTOBindingSource
        '
        Me.PRODUCTOBindingSource.DataMember = "PRODUCTO"
        Me.PRODUCTOBindingSource.DataSource = Me.FarmaciaSJDataSet
        '
        'PRODUCTOTableAdapter
        '
        Me.PRODUCTOTableAdapter.ClearBeforeFill = True
        '
        'Modificar_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 371)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.factura)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Modificar_compra"
        Me.Text = "Modificar_compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPRABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUCTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cerrar As System.Windows.Forms.Button
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents costo_unidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Costo_Total As System.Windows.Forms.TextBox
    Friend WithEvents producto As System.Windows.Forms.ComboBox
    Friend WithEvents Vencimiento As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents factura As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FarmaciaSJDataSet As FARMACIASJ.FarmaciaSJDataSet
    Friend WithEvents COMPRABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPRATableAdapter As FARMACIASJ.FarmaciaSJDataSetTableAdapters.COMPRATableAdapter
    Friend WithEvents PRODUCTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUCTOTableAdapter As FARMACIASJ.FarmaciaSJDataSetTableAdapters.PRODUCTOTableAdapter
End Class
