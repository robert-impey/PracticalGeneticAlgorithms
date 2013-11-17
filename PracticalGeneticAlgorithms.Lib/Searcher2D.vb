Public MustInherit Class Searcher2D
    Property XMin As Double
    Property XMax As Double
    Property YMin As Double
    Property YMax As Double

    Property Granularity As Double

    Public Delegate Function FunctionToMinimise(ByVal p As Point2D) As Double
    Public Property F As FunctionToMinimise

    MustOverride Function Solve() As Solution2D

    Sub PrintOutput()
        Dim solution = New Solution2D(New Point2D(XMin, YMin), Me)

        Dim X = XMin
        While X <= XMax
            Dim Y = YMin
            While Y <= YMax
                solution.P = New Point2D(X, Y)
                Console.WriteLine(String.Format("{0},{1},{2}", solution.P.X, solution.P.Y, solution.Cost))
                Y += Granularity
            End While
            X += Granularity
        End While
    End Sub
End Class
