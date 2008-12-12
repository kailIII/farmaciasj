<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Dim Razon_SocialLabel As System.Windows.Forms.Label
        Dim RIFLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.FarmaciaSJDataSet = New FARMACIASJ.FarmaciaSJDataSet
        Me.FARMACIABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FARMACIATableAdapter = New FARMACIASJ.FarmaciaSJDataSetTableAdapters.FARMACIATableAdapter
        Me.FARMACIABindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.FARMACIABindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Razon_SocialTextBox = New System.Windows.Forms.TextBox
        Me.RIFTextBox = New System.Windows.Forms.TextBox
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox
        Me.DireccionTextBox = New System.Windows.Forms.TextBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Razon_SocialLabel = New System.Windows.Forms.Label
        RIFLabel = New System.Windows.Forms.Label
        TelefonoLabel = New System.Windows.Forms.Label
        DireccionLabel = New System.Windows.Forms.Label
        LogoLabel = New System.Windows.Forms.Label
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FARMACIABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FARMACIABindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FARMACIABindingNavigator.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Buscar_Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 31)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FarmaciaSJDataSet
        '
        Me.FarmaciaSJDataSet.DataSetName = "FarmaciaSJDataSet"
        Me.FarmaciaSJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FARMACIABindingSource
        '
        Me.FARMACIABindingSource.DataMember = "FARMACIA"
        Me.FARMACIABindingSource.DataSource = Me.FarmaciaSJDataSet
        '
        'FARMACIATableAdapter
        '
        Me.FARMACIATableAdapter.ClearBeforeFill = True
        '
        'FARMACIABindingNavigator
        '
        Me.FARMACIABindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FARMACIABindingNavigator.BindingSource = Me.FARMACIABindingSource
        Me.FARMACIABindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FARMACIABindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FARMACIABindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FARMACIABindingNavigatorSaveItem})
        Me.FARMACIABindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FARMACIABindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FARMACIABindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FARMACIABindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FARMACIABindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FARMACIABindingNavigator.Name = "FARMACIABindingNavigator"
        Me.FARMACIABindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FARMACIABindingNavigator.Size = New System.Drawing.Size(377, 25)
        Me.FARMACIABindingNavigator.TabIndex = 13
        Me.FARMACIABindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FARMACIABindingNavigatorSaveItem
        '
        Me.FARMACIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FARMACIABindingNavigatorSaveItem.Image = CType(resources.GetObject("FARMACIABindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FARMACIABindingNavigatorSaveItem.Name = "FARMACIABindingNavigatorSaveItem"
        Me.FARMACIABindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.FARMACIABindingNavigatorSaveItem.Text = "Save Data"
        '
        'Razon_SocialLabel
        '
        Razon_SocialLabel.AutoSize = True
        Razon_SocialLabel.Location = New System.Drawing.Point(40, 59)
        Razon_SocialLabel.Name = "Razon_SocialLabel"
        Razon_SocialLabel.Size = New System.Drawing.Size(73, 13)
        Razon_SocialLabel.TabIndex = 13
        Razon_SocialLabel.Text = "Razon Social:"
        '
        'Razon_SocialTextBox
        '
        Me.Razon_SocialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FARMACIABindingSource, "Razon_Social", True))
        Me.Razon_SocialTextBox.Location = New System.Drawing.Point(119, 56)
        Me.Razon_SocialTextBox.Name = "Razon_SocialTextBox"
        Me.Razon_SocialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Razon_SocialTextBox.TabIndex = 14
        '
        'RIFLabel
        '
        RIFLabel.AutoSize = True
        RIFLabel.Location = New System.Drawing.Point(40, 85)
        RIFLabel.Name = "RIFLabel"
        RIFLabel.Size = New System.Drawing.Size(27, 13)
        RIFLabel.TabIndex = 14
        RIFLabel.Text = "RIF:"
        '
        'RIFTextBox
        '
        Me.RIFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FARMACIABindingSource, "RIF", True))
        Me.RIFTextBox.Location = New System.Drawing.Point(119, 82)
        Me.RIFTextBox.Name = "RIFTextBox"
        Me.RIFTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RIFTextBox.TabIndex = 15
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(40, 111)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 15
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FARMACIABindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(119, 108)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTextBox.TabIndex = 16
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(40, 137)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 16
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FARMACIABindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(119, 134)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 17
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.Location = New System.Drawing.Point(40, 160)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(34, 13)
        LogoLabel.TabIndex = 17
        LogoLabel.Text = "Logo:"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.FARMACIABindingSource, "Logo", True))
        Me.LogoPictureBox.Location = New System.Drawing.Point(119, 160)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(100, 105)
        Me.LogoPictureBox.TabIndex = 18
        Me.LogoPictureBox.TabStop = False
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 341)
        Me.Controls.Add(LogoLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(RIFLabel)
        Me.Controls.Add(Me.RIFTextBox)
        Me.Controls.Add(Razon_SocialLabel)
        Me.Controls.Add(Me.Razon_SocialTextBox)
        Me.Controls.Add(Me.FARMACIABindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        CType(Me.FarmaciaSJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FARMACIABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FARMACIABindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FARMACIABindingNavigator.ResumeLayout(False)
        Me.FARMACIABindingNavigator.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FarmaciaSJDataSet As FARMACIASJ.FarmaciaSJDataSet
    Friend WithEvents FARMACIABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FARMACIATableAdapter As FARMACIASJ.FarmaciaSJDataSetTableAdapters.FARMACIATableAdapter
    Friend WithEvents FARMACIABindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FARMACIABindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Razon_SocialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RIFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
End Class
