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
        Me.Boton_Registrar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
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
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Boton_Registrar)
        Me.GroupBox1.Controls.Add(Me.Label10)
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
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(521, 349)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Proveedor"
        '
        'Boton_Registrar
        '
        Me.Boton_Registrar.Location = New System.Drawing.Point(397, 304)
        Me.Boton_Registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.Boton_Registrar.Name = "Boton_Registrar"
        Me.Boton_Registrar.Size = New System.Drawing.Size(112, 28)
        Me.Boton_Registrar.TabIndex = 15
        Me.Boton_Registrar.Text = "Registrar"
        Me.Boton_Registrar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(474, 278)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "BsF"
        '
        'Saldo
        '
        Me.Saldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Saldo.Location = New System.Drawing.Point(134, 274)
        Me.Saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(329, 22)
        Me.Saldo.TabIndex = 13
        Me.Saldo.Text = "0"
        Me.Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Ciudad
        '
        Me.Ciudad.Location = New System.Drawing.Point(134, 242)
        Me.Ciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(376, 22)
        Me.Ciudad.TabIndex = 12
        '
        'Dir
        '
        Me.Dir.Location = New System.Drawing.Point(134, 151)
        Me.Dir.Margin = New System.Windows.Forms.Padding(4)
        Me.Dir.Name = "Dir"
        Me.Dir.Size = New System.Drawing.Size(376, 83)
        Me.Dir.TabIndex = 11
        Me.Dir.Text = ""
        '
        'Correo
        '
        Me.Correo.Location = New System.Drawing.Point(134, 119)
        Me.Correo.Margin = New System.Windows.Forms.Padding(4)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(376, 22)
        Me.Correo.TabIndex = 10
        '
        'Nombre
        '
        Me.Nombre.Location = New System.Drawing.Point(134, 87)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(376, 22)
        Me.Nombre.TabIndex = 9
        '
        'Rif
        '
        Me.Rif.Location = New System.Drawing.Point(134, 55)
        Me.Rif.Margin = New System.Windows.Forms.Padding(4)
        Me.Rif.Name = "Rif"
        Me.Rif.Size = New System.Drawing.Size(376, 22)
        Me.Rif.TabIndex = 8
        '
        'Codigo
        '
        Me.Codigo.Enabled = False
        Me.Codigo.Location = New System.Drawing.Point(134, 23)
        Me.Codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(376, 22)
        Me.Codigo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 278)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Saldo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 155)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 246)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ciudad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Razón social:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "R.I.F:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'Ingresar_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 382)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ingresar_Proveedor"
        Me.Text = "Proveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Boton_Registrar As System.Windows.Forms.Button
End Class
