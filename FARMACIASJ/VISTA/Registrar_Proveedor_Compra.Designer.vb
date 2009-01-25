<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Proveedor_Compra
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Telefonos = New System.Windows.Forms.ListBox
        Me.TLF_Cod_Area = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TLF_Numero = New System.Windows.Forms.TextBox
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
        Me.Boton_Registrar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Telefonos)
        Me.GroupBox1.Controls.Add(Me.TLF_Cod_Area)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TLF_Numero)
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
        Me.GroupBox1.Location = New System.Drawing.Point(28, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(602, 411)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar Proveedor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 290)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 25)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Telefonos
        '
        Me.Telefonos.FormattingEnabled = True
        Me.Telefonos.ItemHeight = 16
        Me.Telefonos.Location = New System.Drawing.Point(124, 327)
        Me.Telefonos.Margin = New System.Windows.Forms.Padding(4)
        Me.Telefonos.Name = "Telefonos"
        Me.Telefonos.Size = New System.Drawing.Size(349, 68)
        Me.Telefonos.TabIndex = 20
        '
        'TLF_Cod_Area
        '
        Me.TLF_Cod_Area.Location = New System.Drawing.Point(124, 290)
        Me.TLF_Cod_Area.Margin = New System.Windows.Forms.Padding(4)
        Me.TLF_Cod_Area.MaxLength = 4
        Me.TLF_Cod_Area.Name = "TLF_Cod_Area"
        Me.TLF_Cod_Area.Size = New System.Drawing.Size(88, 22)
        Me.TLF_Cod_Area.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(435, 262)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "BsF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Teléfono:"
        '
        'TLF_Numero
        '
        Me.TLF_Numero.Location = New System.Drawing.Point(224, 290)
        Me.TLF_Numero.Margin = New System.Windows.Forms.Padding(4)
        Me.TLF_Numero.MaxLength = 7
        Me.TLF_Numero.Name = "TLF_Numero"
        Me.TLF_Numero.Size = New System.Drawing.Size(252, 22)
        Me.TLF_Numero.TabIndex = 15
        '
        'Saldo
        '
        Me.Saldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Saldo.Location = New System.Drawing.Point(124, 258)
        Me.Saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.Saldo.MaxLength = 18
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(301, 22)
        Me.Saldo.TabIndex = 13
        Me.Saldo.Text = "0"
        Me.Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Ciudad
        '
        Me.Ciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ciudad.Location = New System.Drawing.Point(124, 226)
        Me.Ciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.Size = New System.Drawing.Size(350, 22)
        Me.Ciudad.TabIndex = 12
        '
        'Dir
        '
        Me.Dir.Location = New System.Drawing.Point(124, 151)
        Me.Dir.Margin = New System.Windows.Forms.Padding(4)
        Me.Dir.MaxLength = 200
        Me.Dir.Name = "Dir"
        Me.Dir.Size = New System.Drawing.Size(350, 63)
        Me.Dir.TabIndex = 11
        Me.Dir.Text = ""
        '
        'Correo
        '
        Me.Correo.Location = New System.Drawing.Point(124, 119)
        Me.Correo.Margin = New System.Windows.Forms.Padding(4)
        Me.Correo.MaxLength = 20
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(350, 22)
        Me.Correo.TabIndex = 10
        '
        'Nombre
        '
        Me.Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Nombre.Location = New System.Drawing.Point(124, 87)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre.MaxLength = 30
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(350, 22)
        Me.Nombre.TabIndex = 9
        '
        'Rif
        '
        Me.Rif.Enabled = False
        Me.Rif.Location = New System.Drawing.Point(124, 55)
        Me.Rif.Margin = New System.Windows.Forms.Padding(4)
        Me.Rif.Name = "Rif"
        Me.Rif.Size = New System.Drawing.Size(350, 22)
        Me.Rif.TabIndex = 8
        '
        'Codigo
        '
        Me.Codigo.Enabled = False
        Me.Codigo.Location = New System.Drawing.Point(124, 23)
        Me.Codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(350, 22)
        Me.Codigo.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 262)
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
        Me.Label5.Location = New System.Drawing.Point(9, 230)
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
        Me.Label2.Location = New System.Drawing.Point(9, 59)
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
        'Boton_Registrar
        '
        Me.Boton_Registrar.Location = New System.Drawing.Point(518, 433)
        Me.Boton_Registrar.Margin = New System.Windows.Forms.Padding(4)
        Me.Boton_Registrar.Name = "Boton_Registrar"
        Me.Boton_Registrar.Size = New System.Drawing.Size(112, 28)
        Me.Boton_Registrar.TabIndex = 16
        Me.Boton_Registrar.Text = "Registrar"
        Me.Boton_Registrar.UseVisualStyleBackColor = True
        '
        'Registrar_Proveedor_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Boton_Registrar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Registrar_Proveedor_Compra"
        Me.Text = "Registrar Proveedor Compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Telefonos As System.Windows.Forms.ListBox
    Friend WithEvents TLF_Cod_Area As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TLF_Numero As System.Windows.Forms.TextBox
    Friend WithEvents Boton_Registrar As System.Windows.Forms.Button
    Friend WithEvents Saldo As System.Windows.Forms.TextBox
    Friend WithEvents Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Dir As System.Windows.Forms.RichTextBox
    Friend WithEvents Correo As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Rif As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
