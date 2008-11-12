<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Linea
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
        Me.Ingresar_Boton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.MargenUtil = New System.Windows.Forms.TextBox
        Me.DescripcionLinea = New System.Windows.Forms.RichTextBox
        Me.DescMax = New System.Windows.Forms.TextBox
        Me.NombreLinea = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ingresar_Boton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MargenUtil)
        Me.GroupBox1.Controls.Add(Me.DescripcionLinea)
        Me.GroupBox1.Controls.Add(Me.DescMax)
        Me.GroupBox1.Controls.Add(Me.NombreLinea)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Línea"
        '
        'Ingresar_Boton
        '
        Me.Ingresar_Boton.Location = New System.Drawing.Point(242, 223)
        Me.Ingresar_Boton.Name = "Ingresar_Boton"
        Me.Ingresar_Boton.Size = New System.Drawing.Size(75, 23)
        Me.Ingresar_Boton.TabIndex = 7
        Me.Ingresar_Boton.Text = "Ingresar"
        Me.Ingresar_Boton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Margen útil"
        '
        'MargenUtil
        '
        Me.MargenUtil.Location = New System.Drawing.Point(100, 197)
        Me.MargenUtil.Name = "MargenUtil"
        Me.MargenUtil.Size = New System.Drawing.Size(217, 20)
        Me.MargenUtil.TabIndex = 4
        '
        'DescripcionLinea
        '
        Me.DescripcionLinea.Location = New System.Drawing.Point(100, 58)
        Me.DescripcionLinea.Name = "DescripcionLinea"
        Me.DescripcionLinea.Size = New System.Drawing.Size(217, 100)
        Me.DescripcionLinea.TabIndex = 2
        Me.DescripcionLinea.Text = ""
        '
        'DescMax
        '
        Me.DescMax.Location = New System.Drawing.Point(100, 167)
        Me.DescMax.Name = "DescMax"
        Me.DescMax.Size = New System.Drawing.Size(217, 20)
        Me.DescMax.TabIndex = 3
        '
        'NombreLinea
        '
        Me.NombreLinea.Location = New System.Drawing.Point(100, 32)
        Me.NombreLinea.Name = "NombreLinea"
        Me.NombreLinea.Size = New System.Drawing.Size(217, 20)
        Me.NombreLinea.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "máximo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Ingresar_Linea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 280)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Ingresar_Linea"
        Me.Text = "Ingresar_Linea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NombreLinea As System.Windows.Forms.TextBox
    Friend WithEvents DescMax As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionLinea As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MargenUtil As System.Windows.Forms.TextBox
    Friend WithEvents Ingresar_Boton As System.Windows.Forms.Button
End Class
