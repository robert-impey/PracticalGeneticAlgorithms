Imports PracticalGeneticAlgorithms.Lib

Module Program

    Sub Main()
        Try
            If 3 = My.Application.CommandLineArgs.Count Then
                Dim functionToSolve = My.Application.CommandLineArgs(0)
                Dim searcherType = My.Application.CommandLineArgs(1)
                Dim action = My.Application.CommandLineArgs(2)

                Const XMin = 0.0
                Const XMax = 10.0
                Const YMin = 0.0
                Const YMax = 10.0

                Const Granularity = 0.1

                Dim searcher As Searcher2D

                Select Case searcherType
                    Case "NelderMead"
                        searcher = New NelderMeadSearcher2D
                    Case "Exhaustive"
                        searcher = New ExhaustiveSearcher2D
                    Case Else
                        Throw New Exception("Unrecognised searcher!")
                End Select

                Select Case functionToSolve
                    Case "F_1_1"
                        searcher.F = AddressOf F_1_1
                    Case Else
                        Throw New Exception("Unrecognised function to solve!")
                End Select

                searcher.XMin = XMin
                searcher.XMax = XMax
                searcher.YMin = YMin
                searcher.YMax = YMax

                searcher.Granularity = Granularity

                DoAction(searcher, action)
            Else
                Throw New Exception("Tell me what to do!")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub DoAction(ByVal searcher As Searcher2D, ByVal action As String)
        Select Case action
            Case "Solve"
                Dim solution = searcher.Solve()

                Console.WriteLine(
                    String.Format("Solution found f({0}, {1}) = {2}", _
                                  solution.P.X, solution.P.Y, solution.Cost))
            Case "PrintOutput"
                searcher.PrintOutput()
            Case Else
                Throw New Exception("Unrecognised action!")
        End Select
    End Sub
End Module
