Public Class Solution2D
    Property P As Point2D
    Property Searcher As Searcher2D

    Sub New(ByVal p As Point2D, ByVal searcher As Searcher2D)
        Me.P = p
        Me.Searcher = searcher
    End Sub

    ReadOnly Property Cost As Double
        Get
            Return Searcher.F(P)
        End Get
    End Property
End Class
