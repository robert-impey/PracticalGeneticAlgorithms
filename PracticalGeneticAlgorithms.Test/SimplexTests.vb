Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture()> Public Class SimplexTests
    <Test()> Public Sub Sorting()
        Dim simplex = New Simplex
        Dim searcher = New NelderMeadSearcher2D
        searcher.F = AddressOf F_1_1

        simplex.Solutions.Add(New Solution2D(New Point2D(4.2, 9.2), searcher)) ' Ouptput should be -8.1255856364
        simplex.Solutions.Add(New Solution2D(New Point2D(7.6, 8.4), searcher)) ' Ouptput should be -14.6608841390
        simplex.Solutions.Add(New Solution2D(New Point2D(1.4, 9.4), searcher)) ' Ouptput should be -1.3959718197

        Dim Tolerance = Math.Pow(10, -4)

        Assert.That(7.6, [Is].EqualTo(simplex.BestSolution.P.X).Within(Tolerance))
        Assert.That(8.4, [Is].EqualTo(simplex.BestSolution.P.Y).Within(Tolerance))

        Assert.That(4.2, [Is].EqualTo(simplex.MiddleSolution.P.X).Within(Tolerance))
        Assert.That(9.2, [Is].EqualTo(simplex.MiddleSolution.P.Y).Within(Tolerance))

        Assert.That(1.4, [Is].EqualTo(simplex.WorstSolution.P.X).Within(Tolerance))
        Assert.That(9.4, [Is].EqualTo(simplex.WorstSolution.P.Y).Within(Tolerance))
    End Sub
End Class
