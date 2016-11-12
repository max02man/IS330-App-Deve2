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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sethourTextBox = New System.Windows.Forms.TextBox()
        Me.setminTextBox = New System.Windows.Forms.TextBox()
        Me.setsecondTextBox = New System.Windows.Forms.TextBox()
        Me.setButton = New System.Windows.Forms.Button()
        Me.incrementButton = New System.Windows.Forms.Button()
        Me.output1Label = New System.Windows.Forms.Label()
        Me.output2Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "set hour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "set minute"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "set second"
        '
        'sethourTextBox
        '
        Me.sethourTextBox.Location = New System.Drawing.Point(88, 20)
        Me.sethourTextBox.Name = "sethourTextBox"
        Me.sethourTextBox.Size = New System.Drawing.Size(53, 20)
        Me.sethourTextBox.TabIndex = 3
        '
        'setminTextBox
        '
        Me.setminTextBox.Location = New System.Drawing.Point(222, 20)
        Me.setminTextBox.Name = "setminTextBox"
        Me.setminTextBox.Size = New System.Drawing.Size(53, 20)
        Me.setminTextBox.TabIndex = 4
        '
        'setsecondTextBox
        '
        Me.setsecondTextBox.Location = New System.Drawing.Point(366, 20)
        Me.setsecondTextBox.Name = "setsecondTextBox"
        Me.setsecondTextBox.Size = New System.Drawing.Size(53, 20)
        Me.setsecondTextBox.TabIndex = 5
        '
        'setButton
        '
        Me.setButton.Location = New System.Drawing.Point(88, 55)
        Me.setButton.Name = "setButton"
        Me.setButton.Size = New System.Drawing.Size(98, 22)
        Me.setButton.TabIndex = 6
        Me.setButton.Text = "Set time"
        Me.setButton.UseVisualStyleBackColor = True
        '
        'incrementButton
        '
        Me.incrementButton.Location = New System.Drawing.Point(242, 55)
        Me.incrementButton.Name = "incrementButton"
        Me.incrementButton.Size = New System.Drawing.Size(98, 22)
        Me.incrementButton.TabIndex = 7
        Me.incrementButton.Text = "Increment second"
        Me.incrementButton.UseVisualStyleBackColor = True
        '
        'output1Label
        '
        Me.output1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.output1Label.Location = New System.Drawing.Point(38, 89)
        Me.output1Label.Name = "output1Label"
        Me.output1Label.Size = New System.Drawing.Size(356, 23)
        Me.output1Label.TabIndex = 8
        '
        'output2Label
        '
        Me.output2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.output2Label.Location = New System.Drawing.Point(38, 121)
        Me.output2Label.Name = "output2Label"
        Me.output2Label.Size = New System.Drawing.Size(359, 23)
        Me.output2Label.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 153)
        Me.Controls.Add(Me.output2Label)
        Me.Controls.Add(Me.output1Label)
        Me.Controls.Add(Me.incrementButton)
        Me.Controls.Add(Me.setButton)
        Me.Controls.Add(Me.setsecondTextBox)
        Me.Controls.Add(Me.setminTextBox)
        Me.Controls.Add(Me.sethourTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "useing class time's"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents sethourTextBox As System.Windows.Forms.TextBox
    Friend WithEvents setminTextBox As System.Windows.Forms.TextBox
    Friend WithEvents setsecondTextBox As System.Windows.Forms.TextBox
    Friend WithEvents setButton As System.Windows.Forms.Button
    Friend WithEvents incrementButton As System.Windows.Forms.Button
    Friend WithEvents output1Label As System.Windows.Forms.Label
    Friend WithEvents output2Label As System.Windows.Forms.Label

End Class
