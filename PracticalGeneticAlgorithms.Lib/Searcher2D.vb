Public MustInherit Class Searcher2D
    Property XMin As Double
    Property XMax As Double
    Property YMin As Double
    Property YMax As Double

    Property XStep As Double
    Property YStep As Double

    Public Delegate Function FunctionToMinimise(ByVal p As Point2D) As Double
    Public Property F As FunctionToMinimise

    MustOverride Function Solve() As Solution2D

    Sub PrintOutput(ByVal Separator As String)
        Dim solution = New Solution2D(New Point2D(XMin, YMin), Me)

        Dim X = XMin
        While X <= XMax
            Dim Y = YMin
            While Y <= YMax
                solution.P = New Point2D(X, Y)
                Console.Write(solution.Cost & Separator)
                Y += YStep
            End While
            X += XStep
            Console.WriteLine()
        End While
    End Sub
End Class
