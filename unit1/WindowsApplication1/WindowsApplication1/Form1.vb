Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ' Create an instance of the class.

        Dim user As New Usernameinfo("Moore, Bobby")

        ' Capitalize the value of the property.

        user.Capitalize()

        ' Display the value of the property.

        MsgBox("The original UserName is: " & user.UserName)

        ' Change the value of the property.

        user.UserName = "Worden, Joe"

        ' Redisplay the value of the property.

        MsgBox("The new UserName is: " & user.UserName)
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim phone As New usernamephone("1234567890")
        MsgBox("Phone number is: " & phone.num)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
