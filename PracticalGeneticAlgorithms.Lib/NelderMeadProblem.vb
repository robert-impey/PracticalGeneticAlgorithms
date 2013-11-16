Public Class NelderMeadProblem
    Property XMin As Double
    Property XMax As Double
    Property YMin As Double
    Property YMax As Double

    Sub Solve()
        ' Create a random simplex
        Dim Simplex = New Simplex
        Simplex.F = AddressOf F
        For I = 1 To 3
            Simplex.Points.Add(New Point(MathsHelpers.RandomInRange(XMin, XMax), _
                                   MathsHelpers.RandomInRange(YMin, YMax)))
        Next

    End Sub

    Sub PrintOutput(ByVal XStep As Double, _
                    ByVal YStep As Double, _
                    ByVal Separator As String)
        Dim X = XMin
        While X <= XMax
            Dim Y = YMin
            While Y <= YMax
                Console.Write(F(New Point(X, Y)) & Separator)
                Y += YStep
            End While
            X += XStep
            Console.WriteLine()
        End While
    End Sub

    ''' <summary>
    ''' This is the function for whose minimum we are searching.
    ''' </summary>
    Public Shared Function F(ByVal p As Point) As Double
        Return F_1_1(p)
    End Function
End Class
