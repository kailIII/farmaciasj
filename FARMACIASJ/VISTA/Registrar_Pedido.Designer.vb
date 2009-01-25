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
        Me.ingresar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Descripcion = New System.Windows.Forms.RichTextBox
        Me.Fecha_Fin = New System.Windows.Forms.DateTimePicker
        Me.Fecha_Inicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.RIF = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Razon_Social = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Nombre_Producto = New System.Windows.Forms.TextBox
        Me.Codigo_Barras = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ingresar
        '
        Me.ingresar.Enabled = False
        Me.ingresar.Location = New System.Drawing.Point(338, 449)
        Me.ingresar.Margin = New System.Windows.Forms.Padding(4)
        Me.ingresar.Name = "ingresar"
        Me.ingresar.Size = New System.Drawing.Size(160, 28)
        Me.ingresar.TabIndex = 12
        Me.ingresar.Text = "Ingresar"
        Me.ingresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Descripcion)
        Me.GroupBox1.Controls.Add(Me.Fecha_Fin)
        Me.GroupBox1.Controls.Add(Me.Fecha_Inicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(486, 224)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Pedido"
        '
        'Cantidad
        '
        Me.Cantidad.Location = New System.Drawing.Point(150, 186)
        Me.Cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(88, 22)
        Me.Cantidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cantidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descripción:"
        '
        'Descripcion
        '
        Me.Descripcion.Location = New System.Drawing.Point(150, 87)
        Me.Descripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(312, 90)
        Me.Descripcion.TabIndex = 6
        Me.Descripcion.Text = ""
        '
        'Fecha_Fin
        '
        Me.Fecha_Fin.Location = New System.Drawing.Point(150, 55)
        Me.Fecha_Fin.Margin = New System.Windows.Forms.Padding(4)
        Me.Fecha_Fin.Name = "Fecha_Fin"
        Me.Fecha_Fin.Size = New System.Drawing.Size(313, 22)
        Me.Fecha_Fin.TabIndex = 5
        '
        'Fecha_Inicio
        '
        Me.Fecha_Inicio.Location = New System.Drawing.Point(150, 23)
        Me.Fecha_Inicio.Margin = New System.Windows.Forms.Padding(4)
        Me.Fecha_Inicio.Name = "Fecha_Inicio"
        Me.Fecha_Inicio.Size = New System.Drawing.Size(313, 22)
        Me.Fecha_Inicio.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha Fin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Inicio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "R.I.F:"
        '
        'RIF
        '
        Me.RIF.Location = New System.Drawing.Point(150, 23)
        Me.RIF.Margin = New System.Windows.Forms.Padding(4)
        Me.RIF.Name = "RIF"
        Me.RIF.Size = New System.Drawing.Size(312, 22)
        Me.RIF.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Razón Social:"
        '
        'Razon_Social
        '
        Me.Razon_Social.Enabled = False
        Me.Razon_Social.Location = New System.Drawing.Point(150, 55)
        Me.Razon_Social.Margin = New System.Windows.Forms.Padding(4)
        Me.Razon_Social.Name = "Razon_Social"
        Me.Razon_Social.Size = New System.Drawing.Size(312, 22)
        Me.Razon_Social.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Razon_Social)
        Me.GroupBox2.Controls.Add(Me.RIF)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 246)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(486, 94)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Nombre_Producto)
        Me.GroupBox3.Controls.Add(Me.Codigo_Barras)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 347)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(486, 95)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 59)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Nombre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Código de Barra:"
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.Enabled = False
        Me.Nombre_Producto.Location = New System.Drawing.Point(150, 55)
        Me.Nombre_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.Size = New System.Drawing.Size(312, 22)
        Me.Nombre_Producto.TabIndex = 11
        '
        'Codigo_Barras
        '
        Me.Codigo_Barras.Location = New System.Drawing.Point(150, 23)
        Me.Codigo_Barras.Margin = New System.Windows.Forms.Padding(4)
        Me.Codigo_Barras.Name = "Codigo_Barras"
        Me.Codigo_Barras.Size = New System.Drawing.Size(312, 22)
        Me.Codigo_Barras.TabIndex = 10
        '
        'Registrar_Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 486)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ingresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Registrar_Pedido"
        Me.Text = "Registrar Pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ingresar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RIF As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Descripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Fecha_Fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Razon_Social As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Nombre_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Codigo_Barras As System.Windows.Forms.TextBox
End Class
