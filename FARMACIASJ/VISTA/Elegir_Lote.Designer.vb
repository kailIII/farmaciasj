<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elegir_Lote
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
        Me.Lotes = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Lotes
        '
        Me.Lotes.FormattingEnabled = True
        Me.Lotes.Location = New System.Drawing.Point(12, 12)
        Me.Lotes.Name = "Lotes"
        Me.Lotes.Size = New System.Drawing.Size(248, 199)
        Me.Lotes.TabIndex = 0
        '
        'Elegir_Lote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 224)
        Me.Controls.Add(Me.Lotes)
        Me.Name = "Elegir_Lote"
        Me.Text = "Elegir_Lote"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lotes As System.Windows.Forms.ListBox
End Class
