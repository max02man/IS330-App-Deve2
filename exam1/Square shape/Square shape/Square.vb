Public Class Square
   
    Private sidevalue As Integer

    Public Sub New(ByVal length As Integer)
        side = length
    End Sub

    Public Property side() As Integer
        Get
            Return sidevalue
        End Get
        Set(value As Integer)
            sidevalue = value
        End Set
    End Property
    Public Function CalculatePerimeter() As Integer
        Return 4 * side
    End Function
    Public Function Calculatearea() As Integer
        Return side * side
    End Function
    Public Function CalculateDiagonal() As Integer
        Return Math.Sqrt(2.0 * Math.Pow(side, 2.0))
    End Function
End Class
