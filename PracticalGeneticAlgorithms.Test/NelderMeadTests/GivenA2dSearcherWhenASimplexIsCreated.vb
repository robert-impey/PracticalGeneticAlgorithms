Imports NUnit.Framework
Imports PracticalGeneticAlgorithms.Lib

<TestFixture()>
Public Class GivenA2dSearcherWhenASimplexIsCreated
    Inherits AssertionHelper

    Private Const XMin = 0.0
    Private Const XMax = 10.0
    Private Const YMin = 0.0
    Private Const YMax = 10.0

    Private Simplex As Simplex
    Private Searcher As NelderMeadSearcher2D

    <SetUp()> Public Sub SetUp()
        Searcher = New NelderMeadSearcher2D

        With Searcher
            .XMin = XMin
            .XMax = XMax
            .YMin = YMin
            .YMax = YMax

            .F = AddressOf F_1_1
        End With

        Simplex = Searcher.CreateSimplex()
    End Sub

    <TearDown()> Public Sub TearDown()
        Simplex = Nothing
        Searcher = Nothing
    End Sub

    <Test>
    Public Sub ThenTheXValueOfTheBestSolultionIsGreaterThanOrEqualToTheMin()
        Expect(Simplex.BestSolution.P.X, [Is].GreaterThanOrEqualTo(XMin))
    End Sub

    <Test>
    Public Sub ThenTheXValueOfTheBestSolultionIsLessThanTheMax()
        Expect(Simplex.BestSolution.P.X, [Is].LessThan(XMax))
    End Sub

    <Test>
    Public Sub ThenTheYValueOfTheBestSolultionIsGreaterThanOrEqualToTheMin()
        Expect(Simplex.BestSolution.P.Y, [Is].GreaterThanOrEqualTo(YMin))
    End Sub

    <Test>
    Public Sub ThenTheYValueOfTheBestSolultionIsLessThanMax()
        Expect(Simplex.BestSolution.P.Y, [Is].LessThan(YMax))
    End Sub
End Class
