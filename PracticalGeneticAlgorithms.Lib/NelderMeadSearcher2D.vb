Public Class NelderMeadSearcher2D
    Inherits Searcher2D

    Public Overrides Function Solve() As Solution2D
        Dim simplex = CreateSimplex()
        Return Simplex.BestSolution
    End Function

    ''' <summary>
    ''' Creates a random simplex in range for the searcher.
    ''' </summary>
    ''' <returns>A random simplex</returns>
    ''' <remarks></remarks>
    Public Function CreateSimplex() As Simplex
        Dim simplex = New Simplex
        For I = 1 To 3
            simplex.Solutions.Add(New Solution2D(New Point2D(MathsHelpers.RandomInRange(XMin, XMax), _
                                   MathsHelpers.RandomInRange(YMin, YMax)), Me))
        Next
        Return simplex
    End Function
End Class
