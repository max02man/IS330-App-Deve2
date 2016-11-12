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
        Me.depButton = New System.Windows.Forms.Button()
        Me.withButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.balaLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'depButton
        '
        Me.depButton.Location = New System.Drawing.Point(20, 60)
        Me.depButton.Name = "depButton"
        Me.depButton.Size = New System.Drawing.Size(82, 23)
        Me.depButton.TabIndex = 0
        Me.depButton.Text = "deposit"
        Me.depButton.UseVisualStyleBackColor = True
        '
        'withButton
        '
        Me.withButton.Location = New System.Drawing.Point(144, 60)
        Me.withButton.Name = "withButton"
        Me.withButton.Size = New System.Drawing.Size(82, 23)
        Me.withButton.TabIndex = 1
        Me.withButton.Text = "withdraw"
        Me.withButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter doposit or withdrawal amount:"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(214, 25)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.inputTextBox.TabIndex = 3
        '
        'balaLabel
        '
        Me.balaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.balaLabel.Location = New System.Drawing.Point(236, 97)
        Me.balaLabel.Name = "balaLabel"
        Me.balaLabel.Size = New System.Drawing.Size(78, 23)
        Me.balaLabel.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Account Balance:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 133)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.balaLabel)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.withButton)
        Me.Controls.Add(Me.depButton)
        Me.Name = "Form1"
        Me.Text = "testing class account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents depButton As System.Windows.Forms.Button
    Friend WithEvents withButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents balaLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
