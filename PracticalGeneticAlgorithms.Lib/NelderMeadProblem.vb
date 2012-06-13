Public Class NelderMeadProblem
    Property Simplex As Simplex

    Property XMin As Double
    Property XMax As Double
    Property YMin As Double
    Property YMax As Double

    Sub PrintOutput(ByVal XStep As Double, ByVal YStep As Double, ByVal Separator As String)
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
