Public Class Simplex
    Property Solutions As List(Of Solution2D) = New List(Of Solution2D)

    Private Function GetSolution(ByVal I As Integer) As Solution2D
        SortSolutions()
        Return Solutions(I)
    End Function

    Public ReadOnly Property BestSolution As Solution2D
        Get
            Return GetSolution(0)
        End Get
    End Property

    Public ReadOnly Property MiddleSolution As Solution2D
        Get
            Return GetSolution(1)
        End Get
    End Property

    Public ReadOnly Property WorstSolution As Solution2D
        Get
            Return GetSolution(2)
        End Get
    End Property

    Private Sub SortSolutions()
        Solutions.Sort(Function(s1, s2) s1.Cost.CompareTo(s2.Cost))
    End Sub
End Class
