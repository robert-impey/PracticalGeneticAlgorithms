Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture()> Public Class SimplexTests
    <Test()> Public Sub Sorting()
        Dim Simplex = New Simplex
        Simplex.F = AddressOf FunctionsToMinimise.F_1_1

        Simplex.Points.Add(New Point(4.2, 9.2)) ' Ouptput should be -8.1255856364
        Simplex.Points.Add(New Point(7.6, 8.4)) ' Ouptput should be -14.6608841390
        Simplex.Points.Add(New Point(1.4, 9.4)) ' Ouptput should be -1.3959718197

        Dim Tolerance = Math.Pow(10, -4)

        Assert.That(7.6, [Is].EqualTo(Simplex.BestPoint.X).Within(Tolerance))
        Assert.That(8.4, [Is].EqualTo(Simplex.BestPoint.Y).Within(Tolerance))

        Assert.That(4.2, [Is].EqualTo(Simplex.MiddlePoint.X).Within(Tolerance))
        Assert.That(9.2, [Is].EqualTo(Simplex.MiddlePoint.Y).Within(Tolerance))

        Assert.That(1.4, [Is].EqualTo(Simplex.WorstPoint.X).Within(Tolerance))
        Assert.That(9.4, [Is].EqualTo(Simplex.WorstPoint.Y).Within(Tolerance))
    End Sub
End Class
