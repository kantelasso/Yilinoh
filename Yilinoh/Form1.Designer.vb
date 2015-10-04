<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ylinohyada = New System.Windows.Forms.TextBox()
        Me.CheckTopMost = New System.Windows.Forms.CheckBox()
        Me.CheckTransparence = New System.Windows.Forms.CheckBox()
        Me.alignRight = New System.Windows.Forms.CheckBox()
        Me.alignLeft = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ylinohyada
        '
        Me.ylinohyada.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ylinohyada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ylinohyada.Location = New System.Drawing.Point(0, 28)
        Me.ylinohyada.Multiline = True
        Me.ylinohyada.Name = "ylinohyada"
        Me.ylinohyada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ylinohyada.Size = New System.Drawing.Size(399, 356)
        Me.ylinohyada.TabIndex = 0
        '
        'CheckTopMost
        '
        Me.CheckTopMost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckTopMost.AutoSize = True
        Me.CheckTopMost.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckTopMost.Location = New System.Drawing.Point(203, 5)
        Me.CheckTopMost.Name = "CheckTopMost"
        Me.CheckTopMost.Size = New System.Drawing.Size(47, 21)
        Me.CheckTopMost.TabIndex = 1
        Me.CheckTopMost.Text = "ߢߊߞߊ߲߬"
        Me.CheckTopMost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckTopMost.UseVisualStyleBackColor = True
        '
        'CheckTransparence
        '
        Me.CheckTransparence.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckTransparence.AutoSize = True
        Me.CheckTransparence.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckTransparence.Location = New System.Drawing.Point(132, 5)
        Me.CheckTransparence.Name = "CheckTransparence"
        Me.CheckTransparence.Size = New System.Drawing.Size(68, 21)
        Me.CheckTransparence.TabIndex = 1
        Me.CheckTransparence.Text = "ߢߊߘߐߛߊ߲"
        Me.CheckTransparence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckTransparence.UseVisualStyleBackColor = True
        '
        'alignRight
        '
        Me.alignRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.alignRight.AutoSize = True
        Me.alignRight.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alignRight.Location = New System.Drawing.Point(325, 5)
        Me.alignRight.Name = "alignRight"
        Me.alignRight.Size = New System.Drawing.Size(74, 21)
        Me.alignRight.TabIndex = 1
        Me.alignRight.Text = "ߞߌߣߌ߲ ߝߍ߬"
        Me.alignRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.alignRight.UseVisualStyleBackColor = True
        '
        'alignLeft
        '
        Me.alignLeft.AutoSize = True
        Me.alignLeft.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alignLeft.Location = New System.Drawing.Point(7, 5)
        Me.alignLeft.Name = "alignLeft"
        Me.alignLeft.Size = New System.Drawing.Size(66, 21)
        Me.alignLeft.TabIndex = 1
        Me.alignLeft.Text = "ߡߊ߬ߙߊ߲ ߝߍ߬"
        Me.alignLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.alignLeft.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(399, 384)
        Me.Controls.Add(Me.alignLeft)
        Me.Controls.Add(Me.CheckTransparence)
        Me.Controls.Add(Me.alignRight)
        Me.Controls.Add(Me.CheckTopMost)
        Me.Controls.Add(Me.ylinohyada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "ߦߟߌߣߐ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ylinohyada As System.Windows.Forms.TextBox
    Friend WithEvents CheckTopMost As System.Windows.Forms.CheckBox
    Friend WithEvents CheckTransparence As System.Windows.Forms.CheckBox
    Friend WithEvents alignRight As System.Windows.Forms.CheckBox
    Friend WithEvents alignLeft As System.Windows.Forms.CheckBox

End Class
