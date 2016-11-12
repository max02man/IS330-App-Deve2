'Alaa Hawsawi
Public Class Form1
    Dim time As New time()
    Private Sub addsecondButton_Click(sender As System.Object, e As System.EventArgs) Handles incrementButton.Click
        time.second = (time.second + 1) Mod 60

        If time.second = 0 Then
            time.minute = (time.minute + 1) Mod 60

            If time.minute = 0 Then
                time.hour = (time.hour + 1) Mod 24
            End If
        End If
        updatedisplay()
    End Sub
    Private Sub setButton_Click(sender As System.Object, e As System.EventArgs) Handles setButton.Click
        Try
            If sethourTextBox.Text <> String.Empty Then
                time.hour = Convert.ToInt32(sethourTextBox.Text)
            End If
            If setminTextBox.Text <> String.Empty Then
                time.minute = Convert.ToInt32(setminTextBox.Text)
            End If
            If setsecondTextBox.Text <> String.Empty Then
                time.second = Convert.ToInt32(setsecondTextBox.Text)
            End If
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("the hour, mintue or second was out of range", "out of rande", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        updatedisplay()
    End Sub
    Private Sub updatedisplay()
        sethourTextBox.Text = Convert.ToString(time.hour)
        setminTextBox.Text = Convert.ToString(time.minute)
        setsecondTextBox.Text = Convert.ToString(time.second)
        output1Label.Text = ("hour: " & time.hour & "; minute: " & time.minute & ";second: " & time.second)
        output2Label.Text = ("Stamdard time is: " & time.ToString() & "; Universal time is : " & time.touniversalstring())
    End Sub
End Class
