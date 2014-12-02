<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PracticalGeneticAlgorithmsForm
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
        Me.XTextBox = New System.Windows.Forms.TextBox()
        Me.YTextBox = New System.Windows.Forms.TextBox()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.YLabel = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'XTextBox
        '
        Me.XTextBox.Location = New System.Drawing.Point(59, 6)
        Me.XTextBox.Name = "XTextBox"
        Me.XTextBox.Size = New System.Drawing.Size(100, 20)
        Me.XTextBox.TabIndex = 0
        '
        'YTextBox
        '
        Me.YTextBox.Location = New System.Drawing.Point(59, 49)
        Me.YTextBox.Name = "YTextBox"
        Me.YTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YTextBox.TabIndex = 1
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.Location = New System.Drawing.Point(12, 9)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(14, 13)
        Me.XLabel.TabIndex = 2
        Me.XLabel.Text = "X"
        '
        'YLabel
        '
        Me.YLabel.AutoSize = True
        Me.YLabel.Location = New System.Drawing.Point(12, 52)
        Me.YLabel.Name = "YLabel"
        Me.YLabel.Size = New System.Drawing.Size(14, 13)
        Me.YLabel.TabIndex = 3
        Me.YLabel.Text = "Y"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(12, 133)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(39, 13)
        Me.OutputLabel.TabIndex = 4
        Me.OutputLabel.Text = "F(X, Y)"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(15, 91)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Location = New System.Drawing.Point(59, 133)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.ReadOnly = True
        Me.OutputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OutputTextBox.TabIndex = 6
        '
        'PracticalGeneticAlgorithmsForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.YLabel)
        Me.Controls.Add(Me.XLabel)
        Me.Controls.Add(Me.YTextBox)
        Me.Controls.Add(Me.XTextBox)
        Me.Name = "PracticalGeneticAlgorithmsForm"
        Me.Text = "Practical Genetic Algorithms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YTextBox As System.Windows.Forms.TextBox
    Friend WithEvents XLabel As System.Windows.Forms.Label
    Friend WithEvents YLabel As System.Windows.Forms.Label
    Friend WithEvents OutputLabel As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents OutputTextBox As System.Windows.Forms.TextBox

End Class
