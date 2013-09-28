Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture()> Public Class MathsHelpersTest
    Private Const min = 100.0
    Private Const max = 200.0

    Private Property Result As Double

    <SetUp()> Public Sub SetUp()
        Result = MathsHelpers.RandomInRange(min, max)
    End Sub

    <Test()> Public Sub RandomDoublesAreBigEnough()
        Assert.GreaterOrEqual(Result, min)
    End Sub

    <Test()> Public Sub RandomDoublesAreSmallEnough()
        Assert.LessOrEqual(Result, max)
    End Sub
End Class
