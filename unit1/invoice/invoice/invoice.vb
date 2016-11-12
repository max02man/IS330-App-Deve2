Public Class invoice
    Private partnumvalue As String
    Private partdescriptionvalue As String
    Private quantityvalue As Integer
    Private pricevalue As Integer
    Private totalvalue As Integer


    Public Sub displayinvoiceamount(ByVal price As Integer, ByVal quantity As Integer, ByVal total As Integer)

        If (price >= 0) Then
            pricevalue = price
        Else
            Throw New ArgumentOutOfRangeException(
            "Initial price must be greater than or equal to 0. ")
        End If
        If (quantity >= 0) Then
            quantityvalue = quantity
        Else
            Throw New ArgumentOutOfRangeException(
                 "Initial quantity must be greater than or equal to 0. ")
        End If
        totalvalue = total
        totalvalue = pricevalue * quantityvalue
    End Sub

    Public Property partnum() As String
        Get
            Return partnumvalue
        End Get
        Set(ByVal value As String)
            partnumvalue = value
        End Set
    End Property

    Public Property partdescription() As String
        Get
            Return partdescriptionvalue
        End Get
        Set(ByVal value As String)
            partdescriptionvalue = value
        End Set
    End Property

    Public Property quantity() As Integer
        Get
            Return quantityvalue
        End Get
        Set(ByVal value As Integer)
            quantityvalue = value
        End Set
    End Property

    Public Property price() As Integer
        Get
            Return pricevalue
        End Get
        Set(ByVal value As Integer)
            pricevalue = value
        End Set
    End Property

    Public Property total() As Integer
        Get
            Return totalvalue
        End Get
        Set(ByVal value As Integer)
            totalvalue = value
        End Set
    End Property


    End Class
