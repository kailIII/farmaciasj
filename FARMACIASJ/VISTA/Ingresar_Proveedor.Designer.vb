<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Proveedor
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.Cod_producto = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Productos_asociados = New System.Windows.Forms.DataGridView
        Me.Boton_Registrar = New System.Windows.Forms.Button
        Me.Saldo = New System.Windows.Forms.TextBox
        Me.Ciudad = New System.Windows.Forms.TextBox
        Me.Dir = New System.Windows.Forms.RichTextBox
        Me.Correo = New System.Windows.Forms.TextBox
        Me.Nombre = New System.Windows.Forms.TextBox
        Me.Rif = New System.Windows.Forms.TextBox
        Me.Codigo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Productos_asociados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Cod_producto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Productos_asociados)
        Me.GroupBox1.Controls.Add(Me.Boton_Registrar)
        Me.GroupBox1.Controls.Add(Me.Saldo)
        Me.GroupBox1.Controls.Add(Me.Ciudad)
        Me.GroupBox1.Controls.Add(Me.Dir)
        Me.GroupBox1.Controls.Add(Me.Correo)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Rif)
        Me.GroupBox1.Controls.Add(Me.Codigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 487)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Proveedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Código de producto"
        '
        'Cod_producto
        '
        Me.Cod_producto.Location = New System.Drawing.Point(112, 249)
        Me.Cod_producto.Name = "Cod_producto"
        Me.Cod_producto.Size = New System.Drawing.Size(212, 20)
        Me.Cod_producto.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Productos asociados"
        '
        'Productos_asociados
        '
        Me.Productos_asociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Productos_asociados.Location = New System.Drawing.Point(6, 303)
        Me.Productos_asociados.Name = "Productos_asociados"
        Me.Productos_asociados.Size = New System.Drawing.Size(334, 145)
        Me.Productos_asociados.TabIndex = 15
        '
        'Boton_Registrar
        '
        Me.Boton_Registrar.Location = New System.Drawing.Point(266, 454)
        Me.Boton_Registrar.Name = "Boton_Registrar"
        Me.Boton_Registrar.Size = New System.Drawing.Size(75, 23)
        Me.Boton_Registrar.TabIndex = 15
        Me.Boton_Registrar.Text = "Registrar"
        Me.Boton_Registrar.UseVisualStyleBackColor = True
        '
        'Saldo
        '
        Me.Saldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Saldo.Location = New System.Drawing.Point(89, 223)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(235, 20)
        Me.Saldo.TabIndex = 13
        '
        'Ciudad
        '
        Me.Ciudad.Location = New System.Drawing.Point(89, 197)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(235, 20)
        Me.Ciudad.TabIndex = 12
        '
        'Dir
        '
        Me.Dir.Location = New System.Drawing.Point(89, 123)
        Me.Dir.Name = "Dir"
        Me.Dir.Size = New System.Drawing.Size(235, 68)
        Me.Dir.TabIndex = 11
        Me.Dir.Text = ""
        '
        'Correo
        '
        Me.Correo.Location = New System.Drawing.Point(89, 97)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(235, 20)
        Me.Correo.TabIndex = 10
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(89, 71)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(235, 20)
        Me.Nombre.TabIndex = 9
        '
        'Rif
        '
        Me.Rif.Location = New System.Drawing.Point(89, 45)
        Me.Rif.Name = "Rif"
        Me.Rif.Size = New System.Drawing.Size(235, 20)
        Me.Rif.TabIndex = 8
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(89, 19)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(235, 20)
        Me.Codigo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Saldo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ciudad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Razón social"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RIF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Ingresar_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 509)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ingresar_Proveedor"
        Me.Text = "Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Productos_asociados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Rif As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Saldo As System.Windows.Forms.TextBox
    Friend WithEvents Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Dir As System.Windows.Forms.RichTextBox
    Friend WithEvents Correo As System.Windows.Forms.TextBox
    Friend WithEvents Boton_Registrar As System.Windows.Forms.Button
    Friend WithEvents Productos_asociados As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cod_producto As System.Windows.Forms.TextBox
End Class
