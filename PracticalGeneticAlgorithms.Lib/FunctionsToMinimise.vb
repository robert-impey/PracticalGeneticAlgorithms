Public Module FunctionsToMinimise
    ''' <summary>
    ''' This function is given in listing 1.1 on page 6.
    ''' </summary>
    Function F_1_1(ByVal p As Point2D) As Double
        Return (p.X * Math.Sin(4 * p.X)) + (1.1 * p.Y * Math.Sin(2 * p.Y))
    End Function
End Module
