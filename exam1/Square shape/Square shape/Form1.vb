Public Class Form1
    Private Sub PerimeterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerimeterButton.Click
        Dim len As Integer = input.Text
        Dim shape As New Square(len)
        shape.CalculatePerimeter()
        perLabel.Text = shape.CalculatePerimeter
    End Sub
    Private Sub DiagonalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagonalButton.Click
        Dim len As Integer = input.Text
        Dim shape As New Square(len)
        shape.CalculateDiagonal()
        diLabel.Text = shape.CalculateDiagonal

    End Sub
    Private Sub areaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles areaButton.Click
        Dim len As Integer = input.Text
        Dim shape As New Square(len)
        shape.Calculatearea()
        arLabel.Text = shape.Calculatearea
    End Sub
    Private Sub exitButton_Click(ByVal sender As System.Object, e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

End Class
