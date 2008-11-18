<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Pedido
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
        Me.Cerrar = New System.Windows.Forms.Button
        Me.ingresar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Crearproducto = New System.Windows.Forms.Button
        Me.nombreproducto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Crearcliente = New System.Windows.Forms.Button
        Me.NombreCliente = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.RichTextBox
        Me.Fin = New System.Windows.Forms.DateTimePicker
        Me.Finicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Numero = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cerrar
        '
        Me.Cerrar.Location = New System.Drawing.Point(175, 304)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(109, 23)
        Me.Cerrar.TabIndex = 17
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'ingresar
        '
        Me.ingresar.Enabled = False
        Me.ingresar.Location = New System.Drawing.Point(62, 304)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(107, 23)
        Me.ingresar.TabIndex = 16
        Me.ingresar.Text = "Ingresar"
        Me.ingresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Crearproducto)
        Me.GroupBox1.Controls.Add(Me.nombreproducto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Crearcliente)
        Me.GroupBox1.Controls.Add(Me.NombreCliente)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Controls.Add(Me.Fin)
        Me.GroupBox1.Controls.Add(Me.Finicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(324, 261)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pedido"
        '
        'Crearproducto
        '
        Me.Crearproducto.Enabled = False
        Me.Crearproducto.Location = New System.Drawing.Point(247, 231)
        Me.Crearproducto.Name = "Crearproducto"
        Me.Crearproducto.Size = New System.Drawing.Size(63, 20)
        Me.Crearproducto.TabIndex = 15
        Me.Crearproducto.Text = "Crear..."
        Me.Crearproducto.UseVisualStyleBackColor = True
        '
        'nombreproducto
        '
        Me.nombreproducto.Enabled = False
        Me.nombreproducto.Location = New System.Drawing.Point(100, 231)
        Me.nombreproducto.Name = "nombreproducto"
        Me.nombreproducto.Size = New System.Drawing.Size(141, 20)
        Me.nombreproducto.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Producto:"
        '
        'Crearcliente
        '
        Me.Crearcliente.Enabled = False
        Me.Crearcliente.Location = New System.Drawing.Point(248, 201)
        Me.Crearcliente.Name = "Crearcliente"
        Me.Crearcliente.Size = New System.Drawing.Size(62, 21)
        Me.Crearcliente.TabIndex = 12
        Me.Crearcliente.Text = "Crear..."
        Me.Crearcliente.UseVisualStyleBackColor = True
        '
        'NombreCliente
        '
        Me.NombreCliente.Enabled = False
        Me.NombreCliente.Location = New System.Drawing.Point(100, 202)
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Size = New System.Drawing.Size(142, 20)
        Me.NombreCliente.TabIndex = 11
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 205)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(42, 13)
        Me.label6.TabIndex = 10
        Me.label6.Text = "Cliente:"
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(100, 174)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(60, 20)
        Me.Cantidad.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad Diaria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripción:"
        '
        'Descripcion
        '
        Me.Descripcion.Enabled = False
        Me.Descripcion.Location = New System.Drawing.Point(100, 88)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(210, 74)
        Me.Descripcion.TabIndex = 6
        Me.Descripcion.Text = ""
        '
        'Fin
        '
        Me.Fin.Enabled = False
        Me.Fin.Location = New System.Drawing.Point(100, 52)
        Me.Fin.Name = "Fin"
        Me.Fin.Size = New System.Drawing.Size(210, 20)
        Me.Fin.TabIndex = 5
        '
        'Finicio
        '
        Me.Finicio.Enabled = False
        Me.Finicio.Location = New System.Drawing.Point(100, 22)
        Me.Finicio.Name = "Finicio"
        Me.Finicio.Size = New System.Drawing.Size(210, 20)
        Me.Finicio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Fin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Inicio:"
        '
        'Numero
        '
        Me.Numero.Location = New System.Drawing.Point(134, 11)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(202, 20)
        Me.Numero.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Número del Pedido:"
        '
        'Registrar_Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 337)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.ingresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Numero)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registrar_Pedido"
        Me.Text = "Registrar_Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cerrar As System.Windows.Forms.Button
    Friend WithEvents ingresar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Crearproducto As System.Windows.Forms.Button
    Friend WithEvents nombreproducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Crearcliente As System.Windows.Forms.Button
    Friend WithEvents NombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Finicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
