﻿Public Class Usernameinfo
    Private userNameValue As String
    Public Property UserName() As String

        Get

            ' Gets the property value.

            Return userNameValue

        End Get
        Set(ByVal Value As String)

            ' Sets the property value.

            userNameValue = Value

        End Set

    End Property
    Public Sub Capitalize()

        ' Capitalize the value of the property.

        userNameValue = UCase(userNameValue)

    End Sub
    Public Sub New(ByVal UserName As String)

        ' Set the property value.

        Me.UserName = UserName

    End Sub

End Class
