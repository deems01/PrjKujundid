Public Class Roopkylik
    Inherits Nelinurk
    Public Sub New(ByVal laius As Double, ByVal pikkus As Double, ByVal korgus As Double)
        MyBase.New("Roopkylik", laius, pikkus, laius, pikkus)
        Me.korgus = korgus
    End Sub
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
