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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Pedido"
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(192, 45)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 2
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Numero_Pedido
        '
        Me.Numero_Pedido.Location = New System.Drawing.Point(59, 19)
        Me.Numero_Pedido.Name = "Numero_Pedido"
        Me.Numero_Pedido.Size = New System.Drawing.Size(208, 20)
        Me.Numero_Pedido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
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
        Me.GroupBox2.Location = New System.Drawing.Point(13, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Pedido Frecuente"
        '
        'Suspender
        '
        Me.Suspender.Enabled = False
        Me.Suspender.Location = New System.Drawing.Point(147, 98)
        Me.Suspender.Name = "Suspender"
        Me.Suspender.Size = New System.Drawing.Size(120, 23)
        Me.Suspender.TabIndex = 6
        Me.Suspender.Text = "Suspender Pedido"
        Me.Suspender.UseVisualStyleBackColor = True
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(65, 72)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(60, 20)
        Me.Cantidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cantidad:"
        '
        'Producto
        '
        Me.Producto.Enabled = False
        Me.Producto.Location = New System.Drawing.Point(65, 46)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(202, 20)
        Me.Producto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Producto:"
        '
        'Cliente
        '
        Me.Cliente.Enabled = False
        Me.Cliente.Location = New System.Drawing.Point(65, 20)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(202, 20)
        Me.Cliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        '
        'Suspender_Pedido_frecuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 242)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Suspender_Pedido_frecuente"
        Me.Text = "Suspender Pedido Frecuente"
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
