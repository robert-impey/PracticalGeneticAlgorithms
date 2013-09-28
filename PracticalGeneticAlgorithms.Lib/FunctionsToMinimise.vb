Public Module FunctionsToMinimise
    ''' <summary>
    ''' This function is given in listing 1.1 on page 6.
    ''' </summary>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function F_1_1(ByVal X As Double, ByVal Y As Double) As Double
        Return (X * Math.Sin(4 * X)) + (1.1 * Y * Math.Sin(2 * Y))
    End Function
End Module
