Public Class usernamephone
    Private phonenum As Integer
    Public Property num() As Integer
        Get

            ' Gets the property value.

            Return phonenum

        End Get

        Set(ByVal Value As Integer)

            ' Sets the property value.

            phonenum = Value

        End Set

    End Property
    Public Sub New(ByVal num As Integer)

        ' Set the property value.

        Me.phonenum = num

    End Sub
End Class