Public Class employee
    Private firstnamevalue As String
    Private lastniamevalue As String
    Private Shared countvalue As Integer
    Public Sub New(ByVal first As String, ByVal last As String)
        firstnamevalue = first
        lastniamevalue = last
        countvalue += 1
    End Sub
    Public ReadOnly Property firstname() As String
        Get
            Return firstnamevalue
        End Get
    End Property
    Public ReadOnly Property lastname() As String
        Get
            Return lastniamevalue
        End Get
    End Property
    Public Shared ReadOnly Property count() As Integer
        Get
            Return countvalue
        End Get
    End Property

End Class
