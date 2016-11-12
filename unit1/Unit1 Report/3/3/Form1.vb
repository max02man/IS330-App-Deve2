Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        outputTextBox.AppendText("Employees before instantiation: " & employee.count & vbCrLf)
        Dim employee1 As New employee("Susan", "Baker")
        outputTextBox.AppendText(vbCrLf & "created employee: " & employee1.firstname & " " & employee1.lastname & vbCrLf & "Current number of employees is : " &
                                 employee.count & vbCrLf)
        Dim employee2 As New employee("Bob", "blue")
        outputTextBox.AppendText(vbCrLf & "created employee: " & employee2.firstname & " " & employee2.lastname & vbCrLf & "Current number of employees is : " &
                                 employee.count & vbCrLf & vbCrLf)
        outputTextBox.AppendText(" Marking employees for garbage cooection")
        employee1 = Nothing
        employee2 = Nothing
    End Sub
End Class
