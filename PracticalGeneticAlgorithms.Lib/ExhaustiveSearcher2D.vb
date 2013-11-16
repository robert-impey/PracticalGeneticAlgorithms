Public Class ExhaustiveSearcher2D
    Inherits Searcher2D

    Public Overrides Function Solve() As Solution2D
        Dim minimalSolution = New Solution2D(New Point2D(XMin, YMin), Me)

        Dim x = XMin
        Do While x <= XMax
            Dim y = YMin
            Do While y <= YMax
                Dim candidateSolution = New Solution2D(New Point2D(x, y), Me)

                If candidateSolution.Cost < minimalSolution.Cost Then
                    minimalSolution = candidateSolution
                End If

                y += YStep
            Loop
            x += XStep
        Loop

        Return minimalSolution
    End Function
End Class
