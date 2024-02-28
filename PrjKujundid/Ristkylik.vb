Public Class Ristkylik
    Inherits Nelinurk

    Public Sub New(ByVal alus As Double, ByVal korgus As Double)
        MyBase.New("Ristkylik", alus, korgus, alus, korgus)
    End Sub
    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function
End Class
