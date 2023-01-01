<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tio1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSayHello = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SubarrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubenumerationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubconstantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(23, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TIO 1 : Using Button Events"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSayHello
        '
        Me.btnSayHello.Location = New System.Drawing.Point(23, 107)
        Me.btnSayHello.Name = "btnSayHello"
        Me.btnSayHello.Size = New System.Drawing.Size(283, 23)
        Me.btnSayHello.TabIndex = 8
        Me.btnSayHello.Text = "HELLO WORLD !"
        Me.btnSayHello.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubarrayToolStripMenuItem, Me.SubenumerationsToolStripMenuItem, Me.SubconstantsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(583, 24)
        Me.MenuStrip1.TabIndex = 29
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
        'tio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 224)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSayHello)
        Me.Controls.Add(Me.Label2)
        Me.Name = "tio1"
        Me.Text = "Windows Forms Button Events"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnSayHello As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SubarrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubenumerationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubconstantsToolStripMenuItem As ToolStripMenuItem
End Class
