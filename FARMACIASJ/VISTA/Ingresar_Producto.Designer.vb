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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cod_Barras = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CrearLinea = New System.Windows.Forms.Button
        Me.Linea = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Crear = New System.Windows.Forms.Button
        Me.Riff = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
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
        Me.Ingresar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Barras:"
        '
        'Cod_Barras
        '
        Me.Cod_Barras.Location = New System.Drawing.Point(141, 15)
        Me.Cod_Barras.Name = "Cod_Barras"
        Me.Cod_Barras.Size = New System.Drawing.Size(206, 20)
        Me.Cod_Barras.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CrearLinea)
        Me.GroupBox1.Controls.Add(Me.Linea)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Crear)
        Me.GroupBox1.Controls.Add(Me.Riff)
        Me.GroupBox1.Controls.Add(Me.Label7)
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
        Me.GroupBox1.Location = New System.Drawing.Point(19, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 289)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Producto"
        '
        'CrearLinea
        '
        Me.CrearLinea.Enabled = False
        Me.CrearLinea.Location = New System.Drawing.Point(253, 255)
        Me.CrearLinea.Name = "CrearLinea"
        Me.CrearLinea.Size = New System.Drawing.Size(75, 23)
        Me.CrearLinea.TabIndex = 15
        Me.CrearLinea.Text = "Crear..."
        Me.CrearLinea.UseVisualStyleBackColor = True
        '
        'Linea
        '
        Me.Linea.Enabled = False
        Me.Linea.Location = New System.Drawing.Point(122, 257)
        Me.Linea.Name = "Linea"
        Me.Linea.Size = New System.Drawing.Size(125, 20)
        Me.Linea.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Linea del Producto:"
        '
        'Crear
        '
        Me.Crear.Enabled = False
        Me.Crear.Location = New System.Drawing.Point(253, 227)
        Me.Crear.Name = "Crear"
        Me.Crear.Size = New System.Drawing.Size(75, 23)
        Me.Crear.TabIndex = 12
        Me.Crear.Text = "Crear..."
        Me.Crear.UseVisualStyleBackColor = True
        '
        'Riff
        '
        Me.Riff.Enabled = False
        Me.Riff.Location = New System.Drawing.Point(122, 229)
        Me.Riff.Name = "Riff"
        Me.Riff.Size = New System.Drawing.Size(125, 20)
        Me.Riff.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Riff del Proveedor:"
        '
        'Unidades_Producto
        '
        Me.Unidades_Producto.Enabled = False
        Me.Unidades_Producto.Location = New System.Drawing.Point(122, 195)
        Me.Unidades_Producto.Name = "Unidades_Producto"
        Me.Unidades_Producto.Size = New System.Drawing.Size(125, 20)
        Me.Unidades_Producto.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Unidades por paquete:"
        '
        'GE_Producto
        '
        Me.GE_Producto.Enabled = False
        Me.GE_Producto.FormattingEnabled = True
        Me.GE_Producto.Items.AddRange(New Object() {"EXENTO", "GRAVADO"})
        Me.GE_Producto.Location = New System.Drawing.Point(122, 159)
        Me.GE_Producto.Name = "GE_Producto"
        Me.GE_Producto.Size = New System.Drawing.Size(125, 21)
        Me.GE_Producto.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Gravado/Exento:"
        '
        'Desc_Producto
        '
        Me.Desc_Producto.Enabled = False
        Me.Desc_Producto.Location = New System.Drawing.Point(122, 81)
        Me.Desc_Producto.Name = "Desc_Producto"
        Me.Desc_Producto.Size = New System.Drawing.Size(206, 66)
        Me.Desc_Producto.TabIndex = 5
        Me.Desc_Producto.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripcion:"
        '
        'Nom_Producto
        '
        Me.Nom_Producto.Enabled = False
        Me.Nom_Producto.Location = New System.Drawing.Point(122, 49)
        Me.Nom_Producto.Name = "Nom_Producto"
        Me.Nom_Producto.Size = New System.Drawing.Size(206, 20)
        Me.Nom_Producto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del Producto:"
        '
        'Cod_Producto
        '
        Me.Cod_Producto.Enabled = False
        Me.Cod_Producto.Location = New System.Drawing.Point(122, 19)
        Me.Cod_Producto.Name = "Cod_Producto"
        Me.Cod_Producto.Size = New System.Drawing.Size(206, 20)
        Me.Cod_Producto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo Producto:"
        '
        'Ingresar
        '
        Me.Ingresar.Enabled = False
        Me.Ingresar.Location = New System.Drawing.Point(102, 358)
        Me.Ingresar.Name = "Ingresar"
        Me.Ingresar.Size = New System.Drawing.Size(87, 21)
        Me.Ingresar.TabIndex = 3
        Me.Ingresar.Text = "Ingresar"
        Me.Ingresar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(195, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 21)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ingresar_Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 393)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Ingresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cod_Barras)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ingresar_Producto"
        Me.Text = "Ingresar Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cod_Barras As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cod_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Nom_Producto As System.Windows.Forms.TextBox
    Friend WithEvents GE_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Desc_Producto As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Unidades_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ingresar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Riff As System.Windows.Forms.TextBox
    Friend WithEvents Crear As System.Windows.Forms.Button
    Friend WithEvents CrearLinea As System.Windows.Forms.Button
    Friend WithEvents Linea As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
