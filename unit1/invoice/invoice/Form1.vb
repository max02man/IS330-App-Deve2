'alaa hawsawi
Public Class Form1
    Private invoice As New invoice()

    Private Sub calButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calButton.Click


        Try
            Dim total As Integer
            Dim qual As Integer = quaTextBox.Text
            Dim price As Integer = priceTextBox.Text
            invoice.displayinvoiceamount(price, qual, total)
            amountLabel.Text = invoice.total

        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Initial price or qaulity must be greater than or equal to 0. ",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        MessageBox.Show("Part number: " & numTextBox.Text & vbCrLf & "Part description: " & descTextBox.Text & vbCrLf &
                         "Quantity: " & quaTextBox.Text & vbCrLf & "price: " & priceTextBox.Text & vbCrLf & "Total: " & invoice.total, "Invoice information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
