Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture> Public Class ExhaustiveSearcher2DF1_1Tests
    Inherits AssertionHelper

    Private expectedX As Double
    Private expectedY As Double
    Private expectedCost As Double

    Private exhaustiveSearcher As ExhaustiveSearcher2D

    Private Const Tolerance = 0.01

    Private solution As Solution2D

    <TestFixtureSetUp> Public Sub TestFixtureSetUp()
        ' These are the values that appear in the book on page 6.
        ' However, they appear to be typoes.
        'expectedX = 0.9039
        'expectedY = 0.8668
        expectedX = 9.039
        expectedY = 8.668

        ' This cost (from the book) is found.
        expectedCost = -18.5547

        exhaustiveSearcher = New ExhaustiveSearcher2D
        exhaustiveSearcher.F = AddressOf F_1_1

        exhaustiveSearcher.XMin = 0
        exhaustiveSearcher.YMin = 0
        exhaustiveSearcher.XMax = 10
        exhaustiveSearcher.YMax = 10

        ' 4 d.p. was way too slow (unsurprisingly)
        exhaustiveSearcher.XStep = 0.01
        exhaustiveSearcher.YStep = 0.01

        solution = exhaustiveSearcher.Solve()
    End Sub

    <TestFixtureTearDown> Public Sub TestFixtureTearDown()
        exhaustiveSearcher = Nothing
    End Sub

    <Test> Public Sub FindsX()
        Expect(solution.P.X, [Is].EqualTo(expectedX).Within(Tolerance))
    End Sub

    <Test> Public Sub FindsY()
        Expect(solution.P.Y, [Is].EqualTo(expectedY).Within(Tolerance))
    End Sub

    <Test> Public Sub FindsCost()
        Expect(solution.Cost, [Is].EqualTo(expectedCost).Within(Tolerance))
    End Sub
End Class
