Public Class Form1
    Private account As New account()
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        balaLabel.Text = String.Format("{0:c}", account.balance)
    End Sub

    Private Sub depButton_Click(sender As System.Object, e As System.EventArgs) Handles depButton.Click
        Try
            Dim depositamount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            account.deposit(depositamount)
            balaLabel.Text = String.Format("{0:c}", account.balance)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Deposit amount must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        inputTextBox.Clear()
        inputTextBox.Focus()
    End Sub

    Private Sub withButton_Click(sender As System.Object, e As System.EventArgs) Handles withButton.Click
        Try
            Dim withamount As Decimal = Convert.ToDecimal(inputTextBox.Text)
            account.withdraw(withamount)
            balaLabel.Text = String.Format("{0:c}", account.balance)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("withdraw amount must be less than or equal to the account balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        inputTextBox.Clear()
        inputTextBox.Focus()
    End Sub
End Class
