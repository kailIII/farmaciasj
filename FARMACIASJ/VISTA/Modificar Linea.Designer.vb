<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Linea
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Modificar_Boton = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.MargenUtil = New System.Windows.Forms.TextBox
        Me.DescripcionLinea = New System.Windows.Forms.RichTextBox
        Me.DescMax = New System.Windows.Forms.TextBox
        Me.NombreLinea = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Modificar_Boton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MargenUtil)
        Me.GroupBox1.Controls.Add(Me.DescripcionLinea)
        Me.GroupBox1.Controls.Add(Me.DescMax)
        Me.GroupBox1.Controls.Add(Me.NombreLinea)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 265)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar L�nea"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descuento m�ximo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(307, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "%"
        '
        'Modificar_Boton
        '
        Me.Modificar_Boton.Enabled = False
        Me.Modificar_Boton.Location = New System.Drawing.Point(241, 230)
        Me.Modificar_Boton.Name = "Modificar_Boton"
        Me.Modificar_Boton.Size = New System.Drawing.Size(75, 23)
        Me.Modificar_Boton.TabIndex = 7
        Me.Modificar_Boton.Text = "Modificar"
        Me.Modificar_Boton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Margen �til:"
        '
        'MargenUtil
        '
        Me.MargenUtil.Enabled = False
        Me.MargenUtil.Location = New System.Drawing.Point(201, 195)
        Me.MargenUtil.Name = "MargenUtil"
        Me.MargenUtil.Size = New System.Drawing.Size(100, 20)
        Me.MargenUtil.TabIndex = 4
        '
        'DescripcionLinea
        '
        Me.DescripcionLinea.Enabled = False
        Me.DescripcionLinea.Location = New System.Drawing.Point(75, 45)
        Me.DescripcionLinea.Name = "DescripcionLinea"
        Me.DescripcionLinea.Size = New System.Drawing.Size(241, 109)
        Me.DescripcionLinea.TabIndex = 2
        Me.DescripcionLinea.Text = ""
        '
        'DescMax
        '
        Me.DescMax.Enabled = False
        Me.DescMax.Location = New System.Drawing.Point(201, 165)
        Me.DescMax.Name = "DescMax"
        Me.DescMax.Size = New System.Drawing.Size(100, 20)
        Me.DescMax.TabIndex = 3
        '
        'NombreLinea
        '
        Me.NombreLinea.Location = New System.Drawing.Point(75, 19)
        Me.NombreLinea.Name = "NombreLinea"
        Me.NombreLinea.Size = New System.Drawing.Size(241, 20)
        Me.NombreLinea.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripci�n:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Modificar_Linea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 290)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Modificar_Linea"
        Me.Text = "Modificar_Linea"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Modificar_Boton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MargenUtil As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionLinea As System.Windows.Forms.RichTextBox
    Friend WithEvents DescMax As System.Windows.Forms.TextBox
    Friend WithEvents NombreLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class