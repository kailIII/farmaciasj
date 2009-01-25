<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suspender_Pedido_frecuente
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
        Me.Buscar = New System.Windows.Forms.Button
        Me.Numero_Pedido = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Suspender = New System.Windows.Forms.Button
        Me.Cantidad = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Producto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.Numero_Pedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(426, 98)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Pedido"
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(288, 55)
        Me.Buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(112, 28)
        Me.Buscar.TabIndex = 2
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Numero_Pedido
        '
        Me.Numero_Pedido.Location = New System.Drawing.Point(88, 23)
        Me.Numero_Pedido.Margin = New System.Windows.Forms.Padding(4)
        Me.Numero_Pedido.Name = "Numero_Pedido"
        Me.Numero_Pedido.Size = New System.Drawing.Size(310, 22)
        Me.Numero_Pedido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Suspender)
        Me.GroupBox2.Controls.Add(Me.Cantidad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Producto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Cliente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 122)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(426, 161)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Pedido Frecuente"
        '
        'Suspender
        '
        Me.Suspender.Enabled = False
        Me.Suspender.Location = New System.Drawing.Point(220, 121)
        Me.Suspender.Margin = New System.Windows.Forms.Padding(4)
        Me.Suspender.Name = "Suspender"
        Me.Suspender.Size = New System.Drawing.Size(180, 28)
        Me.Suspender.TabIndex = 6
        Me.Suspender.Text = "Suspender Pedido"
        Me.Suspender.UseVisualStyleBackColor = True
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(98, 89)
        Me.Cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(88, 22)
        Me.Cantidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 92)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cantidad:"
        '
        'Producto
        '
        Me.Producto.Enabled = False
        Me.Producto.Location = New System.Drawing.Point(98, 57)
        Me.Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(301, 22)
        Me.Producto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Producto:"
        '
        'Cliente
        '
        Me.Cliente.Enabled = False
        Me.Cliente.Location = New System.Drawing.Point(98, 25)
        Me.Cliente.Margin = New System.Windows.Forms.Padding(4)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(301, 22)
        Me.Cliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        '
        'Suspender_Pedido_frecuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 298)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Suspender_Pedido_frecuente"
        Me.Text = "Suspender Pedido Frecuente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Numero_Pedido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Suspender As System.Windows.Forms.Button
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
