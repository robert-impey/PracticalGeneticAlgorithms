Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture()> Public Class MathsHelpersTest
    <Test()> Public Sub RandomDoublesAreInRange()
        Dim Min = 100.0
        Dim Max = 200.0

        Dim Result = MathsHelpers.RandomInRange(Min, Max)

        Assert.GreaterOrEqual(Result, Min)
        Assert.LessOrEqual(Result, Max)
    End Sub
End Class
