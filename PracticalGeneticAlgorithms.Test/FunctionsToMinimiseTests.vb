Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture()> Public Class FunctionsToMinimiseTests
    <Test()> Public Sub F_1_1_Sample()
        Dim X = 14.6
        Dim Y = 7.7

        Dim Expected = 16.5967
        Dim Result = FunctionsToMinimise.F_1_1(New Point2D(X, Y))

        Dim Tolerance = Math.Pow(10, -4)

        Assert.That(Expected, [Is].EqualTo(Result).Within(Tolerance))
    End Sub
End Class
