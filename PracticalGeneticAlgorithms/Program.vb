Imports PracticalGeneticAlgorithms.Lib

Module Program

    Sub Main()
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim Tool = My.Application.CommandLineArgs(0)

            Const XMin = 0.0
            Const XMax = 10.0
            Const YMin = 0.0
            Const YMax = 10.0

            Select Case Tool
                Case "NelderMead"
                    Dim A = New Point(MathsHelpers.RandomInRange(XMin, XMax), MathsHelpers.RandomInRange(YMin, YMax))

                    Console.WriteLine(String.Format("A is at ({0}, {1})", A.X, A.Y))
                Case "Print"
                    Const XStep = 0.1

                    Const YStep = 0.1

                    Const Separator = ","

                    Dim X = XMin
                    While X <= XMax
                        Dim Y = YMin
                        While Y <= YMax
                            Console.Write(F(X, Y) & Separator)
                            Y += YStep
                        End While
                        X += XStep
                        Console.WriteLine()
                    End While
            End Select
        Else
            Console.WriteLine("Tell me what to do!")
        End If
    End Sub

    Function F(ByVal X As Double, ByVal Y As Double) As Double
        Return (X * Math.Sin(4 * X)) + (1.1 * Y * Math.Sin(2 * Y))
    End Function



End Module
