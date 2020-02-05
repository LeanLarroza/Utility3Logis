<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitle.AutoEllipsis = True
        Me.LabelTitle.BackColor = System.Drawing.Color.White
        Me.LabelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTitle.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(2, 1)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(786, 97)
        Me.LabelTitle.TabIndex = 24
        Me.LabelTitle.Text = "Utility 3Logis"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Utility3Logis.My.Resources.Resources.Bordes2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(790, 550)
        Me.Controls.Add(Me.LabelTitle)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Utility3Logis"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelTitle As Label
End Class
