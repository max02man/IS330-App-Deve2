Public Class account
    Private balavalue As Decimal

    Public Sub New(Optional ByVal initialbala As Decimal = 0D)
        If initialbala < 0D Then
            Throw New ArgumentOutOfRangeException("Initial blance must be greater than or equal to 0 ")
        End If
        balavalue = initialbala
    End Sub
    Public Sub deposit(ByVal depositamount As Decimal)
        If depositamount <= 0D Then
            Throw New ArgumentOutOfRangeException("Deposit amount must be positive")
        End If
        balavalue += depositamount
    End Sub
    Public Sub withdraw(ByVal withdrawamount As Decimal)
        If withdrawamount > balance Then
            Throw New ArgumentOutOfRangeException("Withdraw amount must be less than or equal to balance")
        ElseIf withdrawamount <= 0D Then
            Throw New ArgumentOutOfRangeException("Deposit amount must be positive")
        End If
        balavalue -= withdrawamount
    End Sub
    Public ReadOnly Property balance As Decimal
        Get
            Return balavalue
        End Get
    End Property
End Class
