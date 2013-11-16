Public Class NelderMeadSearcher2D
    Inherits Searcher2D

    Public Overrides Function Solve() As Solution2D
        ' Create a random simplex
        Dim Simplex = New Simplex
        For I = 1 To 3
            Simplex.Solutions.Add(New Solution2D(New Point2D(MathsHelpers.RandomInRange(XMin, XMax), _
                                   MathsHelpers.RandomInRange(YMin, YMax)), Me))
        Next
        Return Simplex.BestSolution
    End Function
End Class
