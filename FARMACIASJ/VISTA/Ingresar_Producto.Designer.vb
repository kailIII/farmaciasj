<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Producto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label7 = New System.Windows.Forms.Label
        Me.Lineas = New System.Windows.Forms.ComboBox
        Me.LINEABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmaciaSJDataSet = New FARMACIASJ.FarmaciaSJDataSet
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Proveedores = New System.Windows.Forms.ListBox
        Me.PROVEEDORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Ingresar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Unidades_Producto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GE_Producto = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Desc_Producto = New System.Windows.Forms.RichTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Nom_Producto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cod_Producto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cod_Barras = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PROVEEDORTableAdapter = New FARMACIASJ.FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
        Me.LINEATableAdapter = New FARMACIASJ.FarmaciaSJDataSetTableAdapters.LINEATableAdapter
        CType(Me.LINEABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(528, 289)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Línea a la que pertence el producto:"
        '
        'Lineas
        '
        Me.Lineas.DataSource = Me.LINEABindingSource
        Me.Lineas.DisplayMember = "NOMBRE"
        Me.Lineas.Enabled = False
        Me.Lineas.FormattingEnabled = True
        Me.Lineas.Location = New System.Drawing.Point(532, 309)
        Me.Lineas.Margin = New System.Windows.Forms.Padding(4)
        Me.Lineas.Name = "Lineas"
        Me.Lineas.Size = New System.Drawing.Size(434, 24)
        Me.Lineas.TabIndex = 16
        Me.Lineas.ValueMember = "DESCRIPCION"
        '
        'LINEABindingSource
        '
        Me.LINEABindingSource.DataMember = "LINEA"
        Me.LINEABindingSource.DataSource = Me.FarmaciaSJDataSet
        '
        'FarmaciaSJDataSet
        '
        Me.FarmaciaSJDataSet.DataSetName = "FarmaciaSJDataSet"
        Me.FarmaciaSJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Proveedores)
        Me.GroupBox2.Location = New System.Drawing.Point(524, 53)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(450, 233)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedores del Producto"
        '
        'Proveedores
        '
        Me.Proveedores.DataSource = Me.PROVEEDORBindingSource
        Me.Proveedores.DisplayMember = "Nombre"
        Me.Proveedores.Enabled = False
        Me.Proveedores.FormattingEnabled = True
        Me.Proveedores.ItemHeight = 16
        Me.Proveedores.Location = New System.Drawing.Point(9, 23)
        Me.Proveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.Proveedores.MultiColumn = True
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.Proveedores.Size = New System.Drawing.Size(430, 196)
        Me.Proveedores.TabIndex = 0
        Me.Proveedores.ValueMember = "Nombre"
        '
        'PROVEEDORBindingSource
        '
        Me.PROVEEDORBindingSource.DataMember = "PROVEEDOR"
        Me.PROVEEDORBindingSource.DataSource = Me.FarmaciaSJDataSet
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(524, 353)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 26)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ingresar
        '
        Me.Ingresar.Enabled = False
        Me.Ingresar.Location = New System.Drawing.Point(384, 353)
        Me.Ingresar.Margin = New System.Windows.Forms.Padding(4)
        Me.Ingresar.Name = "Ingresar"
        Me.Ingresar.Size = New System.Drawing.Size(130, 26)
        Me.Ingresar.TabIndex = 13
        Me.Ingresar.Text = "Ingresar"
        Me.Ingresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Unidades_Producto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GE_Producto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Desc_Producto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Nom_Producto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Cod_Producto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(506, 282)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Producto"
        '
        'Unidades_Producto
        '
        Me.Unidades_Producto.Enabled = False
        Me.Unidades_Producto.Location = New System.Drawing.Point(183, 240)
        Me.Unidades_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.Unidades_Producto.MaxLength = 4
        Me.Unidades_Producto.Name = "Unidades_Producto"
        Me.Unidades_Producto.Size = New System.Drawing.Size(186, 22)
        Me.Unidades_Producto.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Unidades por paquete:"
        '
        'GE_Producto
        '
        Me.GE_Producto.Enabled = False
        Me.GE_Producto.FormattingEnabled = True
        Me.GE_Producto.Items.AddRange(New Object() {"EXENTO", "GRAVADO"})
        Me.GE_Producto.Location = New System.Drawing.Point(183, 196)
        Me.GE_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.GE_Producto.Name = "GE_Producto"
        Me.GE_Producto.Size = New System.Drawing.Size(186, 24)
        Me.GE_Producto.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 206)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gravado/Exento:"
        '
        'Desc_Producto
        '
        Me.Desc_Producto.Enabled = False
        Me.Desc_Producto.Location = New System.Drawing.Point(183, 100)
        Me.Desc_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.Desc_Producto.Name = "Desc_Producto"
        Me.Desc_Producto.Size = New System.Drawing.Size(312, 80)
        Me.Desc_Producto.TabIndex = 5
        Me.Desc_Producto.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción:"
        '
        'Nom_Producto
        '
        Me.Nom_Producto.Enabled = False
        Me.Nom_Producto.Location = New System.Drawing.Point(183, 60)
        Me.Nom_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.Nom_Producto.Name = "Nom_Producto"
        Me.Nom_Producto.Size = New System.Drawing.Size(312, 22)
        Me.Nom_Producto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del Producto:"
        '
        'Cod_Producto
        '
        Me.Cod_Producto.Enabled = False
        Me.Cod_Producto.Location = New System.Drawing.Point(183, 23)
        Me.Cod_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.Cod_Producto.Name = "Cod_Producto"
        Me.Cod_Producto.Size = New System.Drawing.Size(312, 22)
        Me.Cod_Producto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código Producto:"
        '
        'Cod_Barras
        '
        Me.Cod_Barras.Location = New System.Drawing.Point(393, 15)
        Me.Cod_Barras.Margin = New System.Windows.Forms.Padding(4)
        Me.Cod_Barras.MaxLength = 13
        Me.Cod_Barras.Name = "Cod_Barras"
        Me.Cod_Barras.Size = New System.Drawing.Size(307, 22)
        Me.Cod_Barras.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Código de Barras:"
        '
        'PROVEEDORTableAdapter
        '
        Me.PROVEEDORTableAdapter.ClearBeforeFill = True
        '
        'LINEATableAdapter
        '
        Me.LINEATableAdapter.ClearBeforeFill = True
        '
        'Ingresar_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 386)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Lineas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Ingresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cod_Barras)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ingresar_Producto"
        Me.Text = "Ingresar Producto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LINEABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PROVEEDORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Lineas As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Proveedores As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Ingresar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Unidades_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GE_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Desc_Producto As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nom_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cod_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cod_Barras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FarmaciaSJDataSet As FARMACIASJ.FarmaciaSJDataSet
    Friend WithEvents PROVEEDORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORTableAdapter As FARMACIASJ.FarmaciaSJDataSetTableAdapters.PROVEEDORTableAdapter
    Friend WithEvents LINEABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LINEATableAdapter As FARMACIASJ.FarmaciaSJDataSetTableAdapters.LINEATableAdapter
End Class
