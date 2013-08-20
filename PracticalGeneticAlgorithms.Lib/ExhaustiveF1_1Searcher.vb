Public Class ExhaustiveF1_1Searcher
    Property XMin As Double
    Property XMax As Double
    Property YMin As Double
    Property YMax As Double

    Property XStep As Double
    Property YStep As Double

    Public Function Solve() As F1_1Solution
        Dim minimalSolution = New F1_1Solution

        Dim x = XMin
        Do While x <= XMax
            Dim y = YMin
            Do While y <= YMax
                Dim candidateCost = FunctionsToMinimise.F_1_1(x, y)

                If minimalSolution Is Nothing OrElse candidateCost < minimalSolution.Cost Then
                    minimalSolution.X = x
                    minimalSolution.Y = y
                    minimalSolution.Cost = candidateCost
                End If

                y += YStep
            Loop
            x += XStep
        Loop

        Return minimalSolution
    End Function
End Class
