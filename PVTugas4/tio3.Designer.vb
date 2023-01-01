<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tio3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tio3))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SubarrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubenumerationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubconstantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubstructuresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbrClear = New System.Windows.Forms.ToolStripButton()
        Me.tbrRed = New System.Windows.Forms.ToolStripButton()
        Me.tbrBlue = New System.Windows.Forms.ToolStripButton()
        Me.tbrUpperCase = New System.Windows.Forms.ToolStripButton()
        Me.tbrLowerCase = New System.Windows.Forms.ToolStripButton()
        Me.tbrHelpAbout = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubarrayToolStripMenuItem, Me.SubenumerationsToolStripMenuItem, Me.SubconstantsToolStripMenuItem, Me.SubstructuresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SubarrayToolStripMenuItem
        '
        Me.SubarrayToolStripMenuItem.Name = "SubarrayToolStripMenuItem"
        Me.SubarrayToolStripMenuItem.Size = New System.Drawing.Size(149, 20)
        Me.SubarrayToolStripMenuItem.Text = "TIO: Using Button Events"
        '
        'SubenumerationsToolStripMenuItem
        '
        Me.SubenumerationsToolStripMenuItem.Name = "SubenumerationsToolStripMenuItem"
        Me.SubenumerationsToolStripMenuItem.Size = New System.Drawing.Size(181, 20)
        Me.SubenumerationsToolStripMenuItem.Text = "TIO: Counting Char and Words"
        '
        'SubconstantsToolStripMenuItem
        '
        Me.SubconstantsToolStripMenuItem.Name = "SubconstantsToolStripMenuItem"
        Me.SubconstantsToolStripMenuItem.Size = New System.Drawing.Size(234, 20)
        Me.SubconstantsToolStripMenuItem.Text = "TIO: Creating More Complex Application"
        '
        'SubstructuresToolStripMenuItem
        '
        Me.SubstructuresToolStripMenuItem.Name = "SubstructuresToolStripMenuItem"
        Me.SubstructuresToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.SubstructuresToolStripMenuItem.Text = "substructures"
        '
        'txtEdit
        '
        Me.txtEdit.Location = New System.Drawing.Point(12, 97)
        Me.txtEdit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEdit.Size = New System.Drawing.Size(560, 295)
        Me.txtEdit.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 30)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "TIO 3 : Creating the Text Editor Project"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrClear, Me.tbrRed, Me.tbrBlue, Me.tbrUpperCase, Me.tbrLowerCase, Me.tbrHelpAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(584, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tbrClear
        '
        Me.tbrClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrClear.Image = CType(resources.GetObject("tbrClear.Image"), System.Drawing.Image)
        Me.tbrClear.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrClear.Name = "tbrClear"
        Me.tbrClear.Size = New System.Drawing.Size(23, 22)
        Me.tbrClear.ToolTipText = "New"
        '
        'tbrRed
        '
        Me.tbrRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrRed.Image = CType(resources.GetObject("tbrRed.Image"), System.Drawing.Image)
        Me.tbrRed.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrRed.Name = "tbrRed"
        Me.tbrRed.Size = New System.Drawing.Size(23, 22)
        Me.tbrRed.ToolTipText = " Red"
        '
        'tbrBlue
        '
        Me.tbrBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrBlue.Image = CType(resources.GetObject("tbrBlue.Image"), System.Drawing.Image)
        Me.tbrBlue.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrBlue.Name = "tbrBlue"
        Me.tbrBlue.Size = New System.Drawing.Size(23, 22)
        Me.tbrBlue.ToolTipText = "Blue"
        '
        'tbrUpperCase
        '
        Me.tbrUpperCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrUpperCase.Image = CType(resources.GetObject("tbrUpperCase.Image"), System.Drawing.Image)
        Me.tbrUpperCase.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrUpperCase.Name = "tbrUpperCase"
        Me.tbrUpperCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrUpperCase.ToolTipText = "Upper Case"
        '
        'tbrLowerCase
        '
        Me.tbrLowerCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrLowerCase.Image = CType(resources.GetObject("tbrLowerCase.Image"), System.Drawing.Image)
        Me.tbrLowerCase.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrLowerCase.Name = "tbrLowerCase"
        Me.tbrLowerCase.Size = New System.Drawing.Size(23, 22)
        Me.tbrLowerCase.ToolTipText = "Lower Case"
        '
        'tbrHelpAbout
        '
        Me.tbrHelpAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrHelpAbout.Image = CType(resources.GetObject("tbrHelpAbout.Image"), System.Drawing.Image)
        Me.tbrHelpAbout.ImageTransparentColor = System.Drawing.Color.Black
        Me.tbrHelpAbout.Name = "tbrHelpAbout"
        Me.tbrHelpAbout.Size = New System.Drawing.Size(23, 22)
        Me.tbrHelpAbout.ToolTipText = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 399)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(584, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(39, 17)
        Me.sslStatus.Text = "Ready"
        '
        'tio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 421)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.Label2)
        Me.Name = "tio3"
        Me.Text = "Text Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SubarrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubenumerationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubconstantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubstructuresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtEdit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tbrClear As ToolStripButton
    Friend WithEvents tbrRed As ToolStripButton
    Friend WithEvents tbrBlue As ToolStripButton
    Friend WithEvents tbrUpperCase As ToolStripButton
    Friend WithEvents tbrLowerCase As ToolStripButton
    Friend WithEvents tbrHelpAbout As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslStatus As ToolStripStatusLabel
End Class
