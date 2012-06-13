Public Class NelderMeadProblem
    Property XMin As Double
    Property XMax As Double
    Property YMin As Double
    Property YMax As Double

    Sub Solve()
        ' Create a random simplex
        Dim Simplex = New Simplex
        For I = 1 To 3
            Simplex.Points.Add(New Point(MathsHelpers.RandomInRange(XMin, XMax), _
                                   MathsHelpers.RandomInRange(YMin, YMax)))
        Next

        Simplex.Points.Sort(Function(p1, p2) F(p1.X, p1.Y).CompareTo(F(p2.X, p2.Y)))
    End Sub

    Sub PrintOutput(ByVal XStep As Double, _
                    ByVal YStep As Double, _
                    ByVal Separator As String)
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
    End Sub

    ''' <summary>
    ''' This is the function for whose minimum we are searching.
    ''' </summary>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function F(ByVal X As Double, ByVal Y As Double) As Double
        Return (X * Math.Sin(4 * X)) + (1.1 * Y * Math.Sin(2 * Y))
    End Function
End Class
