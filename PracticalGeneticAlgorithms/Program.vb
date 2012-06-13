Imports PracticalGeneticAlgorithms.Lib

Module Program

    Sub Main()
        If 2 = My.Application.CommandLineArgs.Count Then
            Dim Method = My.Application.CommandLineArgs(0)
            Dim Tool = My.Application.CommandLineArgs(1)

            Const XMin = 0.0
            Const XMax = 10.0
            Const YMin = 0.0
            Const YMax = 10.0

            Select Case Method
                Case "NelderMead"
                    Dim NelderMeadProblem = New NelderMeadProblem
                    NelderMeadProblem.XMin = XMin
                    NelderMeadProblem.XMax = XMax
                    NelderMeadProblem.YMin = YMin
                    NelderMeadProblem.YMax = YMax

                    Select Case Tool
                        Case "Solve"
                            NelderMeadProblem.Solve()
                        Case "PrintOutput"
                            Const XStep = 0.1
                            Const YStep = 0.1
                            Const Separator = ","

                            NelderMeadProblem.PrintOutput(XStep, YStep, Separator)
                    End Select


            End Select
        Else
            Console.WriteLine("Tell me what to do!")
        End If
    End Sub
End Module
