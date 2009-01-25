<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar_Proveedor
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
        Me.Codigo = New System.Windows.Forms.TextBox
        Me.textcodifo = New System.Windows.Forms.Label
        Me.Boton_Codigo = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Rif = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Boton_Rif = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Codigo)
        Me.GroupBox1.Controls.Add(Me.textcodifo)
        Me.GroupBox1.Controls.Add(Me.Boton_Codigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 133)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(456, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar proveedor - Código"
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(111, 26)
        Me.Codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(318, 22)
        Me.Codigo.TabIndex = 3
        '
        'textcodifo
        '
        Me.textcodifo.AutoSize = True
        Me.textcodifo.Location = New System.Drawing.Point(9, 30)
        Me.textcodifo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.textcodifo.Name = "textcodifo"
        Me.textcodifo.Size = New System.Drawing.Size(62, 16)
        Me.textcodifo.TabIndex = 1
        Me.textcodifo.Text = "Código:"
        '
        'Boton_Codigo
        '
        Me.Boton_Codigo.Location = New System.Drawing.Point(318, 60)
        Me.Boton_Codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.Boton_Codigo.Name = "Boton_Codigo"
        Me.Boton_Codigo.Size = New System.Drawing.Size(112, 28)
        Me.Boton_Codigo.TabIndex = 4
        Me.Boton_Codigo.Text = "Buscar"
        Me.Boton_Codigo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rif)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Boton_Rif)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(456, 111)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar proveedor - RIF"
        '
        'Rif
        '
        Me.Rif.Location = New System.Drawing.Point(111, 26)
        Me.Rif.Margin = New System.Windows.Forms.Padding(4)
        Me.Rif.Name = "Rif"
        Me.Rif.Size = New System.Drawing.Size(318, 22)
        Me.Rif.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "R.I.F:"
        '
        'Boton_Rif
        '
        Me.Boton_Rif.Location = New System.Drawing.Point(318, 60)
        Me.Boton_Rif.Margin = New System.Windows.Forms.Padding(4)
        Me.Boton_Rif.Name = "Boton_Rif"
        Me.Boton_Rif.Size = New System.Drawing.Size(112, 28)
        Me.Boton_Rif.TabIndex = 2
        Me.Boton_Rif.Text = "Buscar"
        Me.Boton_Rif.UseVisualStyleBackColor = True
        '
        'Buscar_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 256)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Buscar_Proveedor"
        Me.Text = "Buscar_Proveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Codigo As System.Windows.Forms.TextBox
    Friend WithEvents textcodifo As System.Windows.Forms.Label
    Friend WithEvents Boton_Codigo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rif As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Boton_Rif As System.Windows.Forms.Button
End Class
