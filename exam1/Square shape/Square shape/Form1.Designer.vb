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
        Me.areaButton = New System.Windows.Forms.Button()
        Me.DiagonalButton = New System.Windows.Forms.Button()
        Me.PerimeterButton = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.TextBox()
        Me.perLabel = New System.Windows.Forms.Label()
        Me.diLabel = New System.Windows.Forms.Label()
        Me.arLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'areaButton
        '
        Me.areaButton.Location = New System.Drawing.Point(190, 113)
        Me.areaButton.Name = "areaButton"
        Me.areaButton.Size = New System.Drawing.Size(81, 21)
        Me.areaButton.TabIndex = 0
        Me.areaButton.Text = "area"
        Me.areaButton.UseVisualStyleBackColor = True
        '
        'DiagonalButton
        '
        Me.DiagonalButton.Location = New System.Drawing.Point(103, 113)
        Me.DiagonalButton.Name = "DiagonalButton"
        Me.DiagonalButton.Size = New System.Drawing.Size(81, 21)
        Me.DiagonalButton.TabIndex = 1
        Me.DiagonalButton.Text = "Diagonal"
        Me.DiagonalButton.UseVisualStyleBackColor = True
        '
        'PerimeterButton
        '
        Me.PerimeterButton.Location = New System.Drawing.Point(16, 113)
        Me.PerimeterButton.Name = "PerimeterButton"
        Me.PerimeterButton.Size = New System.Drawing.Size(81, 21)
        Me.PerimeterButton.TabIndex = 2
        Me.PerimeterButton.Text = "Perimeter"
        Me.PerimeterButton.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(87, 43)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(106, 20)
        Me.input.TabIndex = 3
        '
        'perLabel
        '
        Me.perLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.perLabel.Location = New System.Drawing.Point(25, 172)
        Me.perLabel.Name = "perLabel"
        Me.perLabel.Size = New System.Drawing.Size(61, 23)
        Me.perLabel.TabIndex = 4
        '
        'diLabel
        '
        Me.diLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.diLabel.Location = New System.Drawing.Point(112, 172)
        Me.diLabel.Name = "diLabel"
        Me.diLabel.Size = New System.Drawing.Size(61, 23)
        Me.diLabel.TabIndex = 5
        '
        'arLabel
        '
        Me.arLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.arLabel.Location = New System.Drawing.Point(210, 172)
        Me.arLabel.Name = "arLabel"
        Me.arLabel.Size = New System.Drawing.Size(61, 23)
        Me.arLabel.TabIndex = 6
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(96, 215)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(101, 27)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.arLabel)
        Me.Controls.Add(Me.diLabel)
        Me.Controls.Add(Me.perLabel)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.PerimeterButton)
        Me.Controls.Add(Me.DiagonalButton)
        Me.Controls.Add(Me.areaButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents areaButton As System.Windows.Forms.Button
    Friend WithEvents DiagonalButton As System.Windows.Forms.Button
    Friend WithEvents PerimeterButton As System.Windows.Forms.Button
    Friend WithEvents input As System.Windows.Forms.TextBox
    Friend WithEvents perLabel As System.Windows.Forms.Label
    Friend WithEvents diLabel As System.Windows.Forms.Label
    Friend WithEvents arLabel As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
