<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TLF_Proveedor
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
        Me.Asignar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Codigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Nombre = New System.Windows.Forms.TextBox
        Me.Rif = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Productos = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.NombreProducto = New System.Windows.Forms.TextBox
        Me.CodigoBarras = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Asignar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Numero)
        Me.GroupBox1.Controls.Add(Me.Codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 99)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asignar teléfonos a proveedor"
        '
        'Asignar
        '
        Me.Asignar.Location = New System.Drawing.Point(305, 51)
        Me.Asignar.Name = "Asignar"
        Me.Asignar.Size = New System.Drawing.Size(91, 28)
        Me.Asignar.TabIndex = 4
        Me.Asignar.Text = "Asignar"
        Me.Asignar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número"
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(236, 22)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(161, 22)
        Me.Numero.TabIndex = 2
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(78, 22)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(72, 22)
        Me.Codigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Nombre)
        Me.GroupBox2.Controls.Add(Me.Rif)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(414, 93)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedor"
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(131, 51)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(266, 22)
        Me.Nombre.TabIndex = 13
        '
        'Rif
        '
        Me.Rif.Enabled = False
        Me.Rif.Location = New System.Drawing.Point(131, 22)
        Me.Rif.Margin = New System.Windows.Forms.Padding(4)
        Me.Rif.Name = "Rif"
        Me.Rif.Size = New System.Drawing.Size(266, 22)
        Me.Rif.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Razón social:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "R.I.F:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Productos)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.NombreProducto)
        Me.GroupBox3.Controls.Add(Me.CodigoBarras)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(414, 120)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Asignar productos a proveedor"
        '
        'Productos
        '
        Me.Productos.Location = New System.Drawing.Point(306, 85)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(91, 28)
        Me.Productos.TabIndex = 4
        Me.Productos.Text = "Asignar"
        Me.Productos.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nombre"
        '
        'NombreProducto
        '
        Me.NombreProducto.Enabled = False
        Me.NombreProducto.Location = New System.Drawing.Point(76, 50)
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.Size = New System.Drawing.Size(321, 22)
        Me.NombreProducto.TabIndex = 2
        '
        'CodigoBarras
        '
        Me.CodigoBarras.Location = New System.Drawing.Point(76, 22)
        Me.CodigoBarras.Name = "CodigoBarras"
        Me.CodigoBarras.Size = New System.Drawing.Size(320, 22)
        Me.CodigoBarras.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Código"
        '
        'TLF_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 350)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TLF_Proveedor"
        Me.Text = "Proveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Rif As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Asignar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Productos As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents CodigoBarras As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
