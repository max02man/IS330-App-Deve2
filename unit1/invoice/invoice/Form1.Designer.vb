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
        Me.numTextBox = New System.Windows.Forms.TextBox()
        Me.descTextBox = New System.Windows.Forms.TextBox()
        Me.quaTextBox = New System.Windows.Forms.TextBox()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.amountLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.calButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'numTextBox
        '
        Me.numTextBox.Location = New System.Drawing.Point(29, 39)
        Me.numTextBox.Name = "numTextBox"
        Me.numTextBox.Size = New System.Drawing.Size(100, 20)
        Me.numTextBox.TabIndex = 0
        '
        'descTextBox
        '
        Me.descTextBox.Location = New System.Drawing.Point(189, 39)
        Me.descTextBox.Name = "descTextBox"
        Me.descTextBox.Size = New System.Drawing.Size(100, 20)
        Me.descTextBox.TabIndex = 1
        '
        'quaTextBox
        '
        Me.quaTextBox.Location = New System.Drawing.Point(29, 95)
        Me.quaTextBox.Name = "quaTextBox"
        Me.quaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.quaTextBox.TabIndex = 2
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(189, 95)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.priceTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Part Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Part Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Price:"
        '
        'amountLabel
        '
        Me.amountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.amountLabel.Location = New System.Drawing.Point(202, 142)
        Me.amountLabel.Name = "amountLabel"
        Me.amountLabel.Size = New System.Drawing.Size(113, 19)
        Me.amountLabel.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total:"
        '
        'calButton
        '
        Me.calButton.Location = New System.Drawing.Point(34, 130)
        Me.calButton.Name = "calButton"
        Me.calButton.Size = New System.Drawing.Size(94, 30)
        Me.calButton.TabIndex = 10
        Me.calButton.Text = "calcalue"
        Me.calButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 170)
        Me.Controls.Add(Me.calButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.amountLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.quaTextBox)
        Me.Controls.Add(Me.descTextBox)
        Me.Controls.Add(Me.numTextBox)
        Me.Name = "Form1"
        Me.Text = "invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numTextBox As System.Windows.Forms.TextBox
    Friend WithEvents descTextBox As System.Windows.Forms.TextBox
    Friend WithEvents quaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents amountLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents calButton As System.Windows.Forms.Button

End Class
