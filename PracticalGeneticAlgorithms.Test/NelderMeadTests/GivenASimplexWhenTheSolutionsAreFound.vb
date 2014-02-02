Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture()> Public Class GivenASimplexWhenTheSolutionsAreFound
    Private Tolerance As Double = Math.Pow(10, -4)

    Private Simplex As Simplex
    Private Searcher As Searcher2D

    <SetUp()> Public Sub SetUp()
        Simplex = New Simplex
        Searcher = New NelderMeadSearcher2D
        Searcher.F = AddressOf F_1_1

        Simplex.Solutions.Add(New Solution2D(New Point2D(4.2, 9.2), Searcher)) ' Ouptput should be -8.1255856364
        Simplex.Solutions.Add(New Solution2D(New Point2D(7.6, 8.4), Searcher)) ' Ouptput should be -14.6608841390
        Simplex.Solutions.Add(New Solution2D(New Point2D(1.4, 9.4), Searcher)) ' Ouptput should be -1.3959718197
    End Sub

    <TearDown()> Public Sub TearDown()
        Simplex = Nothing
        Searcher = Nothing
    End Sub

    <Test()> Public Sub ThenTheBestSolutionsXValueShouldBeCorrect()
        Assert.That(7.6, [Is].EqualTo(Simplex.BestSolution.P.X).Within(Tolerance))
    End Sub

    <Test()> Public Sub ThenTheBestSolutionsYValueShouldBeCorrect()
        Assert.That(8.4, [Is].EqualTo(Simplex.BestSolution.P.Y).Within(Tolerance))
    End Sub

    <Test()> Public Sub ThenTheMiddleSolutionsXValueShouldBeCorrect()
        Assert.That(4.2, [Is].EqualTo(Simplex.MiddleSolution.P.X).Within(Tolerance))
    End Sub

    <Test()> Public Sub ThenTheMiddleSolutionsYValueShouldBeCorrect()
        Assert.That(9.2, [Is].EqualTo(Simplex.MiddleSolution.P.Y).Within(Tolerance))
    End Sub

    <Test()> Public Sub ThenTheWorstSolutionsXValueShouldBeCorrect()
        Assert.That(1.4, [Is].EqualTo(Simplex.WorstSolution.P.X).Within(Tolerance))
    End Sub

    <Test()> Public Sub ThenTheWorstSolutionsYValueShouldBeCorrect()
        Assert.That(9.4, [Is].EqualTo(Simplex.WorstSolution.P.Y).Within(Tolerance))
    End Sub
End Class
