Public Class time
    Private hourvalue As Integer
    Private minutevalue As Integer
    Private secondvalue As Integer

    Public Sub New(Optional ByVal h As Integer = 12, Optional ByVal m As Integer = 0, Optional ByVal s As Integer = 0)
        settime(h, m, s)
    End Sub

    Public Sub New(ByVal t As time)
        settime(t.hourvalue, t.minutevalue, t.secondvalue)
    End Sub
    Public Sub settime(ByVal h As Integer, ByVal m As Integer, ByVal s As Integer)
        Hour = h
        Minute = m
        Second = s
    End Sub

    Public Property hour() As Integer
        Get
            Return hourvalue
        End Get
        Set(ByVal value As Integer)
            If (value >= 0 AndAlso value < 24) Then
                hourvalue = value
            Else
                Throw New ArgumentOutOfRangeException("hour must be 0-23")
            End If
        End Set
    End Property
    Public Property minute() As Integer
        Get
            Return minutevalue
        End Get
        Set(ByVal value As Integer)
            If (value >= 0 AndAlso value < 60) Then
                minutevalue = value
            Else
                Throw New ArgumentOutOfRangeException("hour must be 0-59")
            End If
        End Set
    End Property
    Public Property second() As Integer
        Get
            Return secondvalue
        End Get
        Set(ByVal value As Integer)
            If (value >= 0 AndAlso value < 60) Then
                secondvalue = value
            Else
                Throw New ArgumentOutOfRangeException("hour must be 0-59")
            End If
        End Set
    End Property

    Public Function touniversalstring() As String
        Return String.Format("{0}:{1:d2}:{2:d2}", hour, minute, second)
    End Function

    Public Overrides Function ToString() As String
        Dim suffix As String
        Dim standerdhour As Integer

        If hour < 12 Then
            suffix = "AM"
        Else
            suffix = "PM"
        End If

        If (hour = 12 OrElse hour = 0) Then
            standerdhour = 12
        Else
            standerdhour = hour Mod 12
        End If
        Return String.Format("{0}:{1:d2}:{2:d2} {3}", standerdhour, minute, second, suffix)
    End Function
End Class
