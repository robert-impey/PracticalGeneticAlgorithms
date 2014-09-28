Public Module MathsHelpers
    Private Rnd As Random = New Random()

    Public Function RandomInRange(ByVal Min As Double, ByVal Max As Double) As Double
        Return (Max - Min) * Rnd.NextDouble + Min
    End Function
End Module
