﻿Public Class Simplex
    Property Points As List(Of Point) = New List(Of Point)

    Public Delegate Function FunctionToMinimise(ByVal X As Double, ByVal Y As Double) As Double
    Public Property F As FunctionToMinimise

    Private Function GetPoint(ByVal I As Integer) As Point
        SortPoints()
        Return Points(I)
    End Function

    Public ReadOnly Property BestPoint As Point
        Get
            Return GetPoint(0)
        End Get
    End Property

    Public ReadOnly Property MiddlePoint As Point
        Get
            Return GetPoint(1)
        End Get
    End Property

    Public ReadOnly Property WorstPoint As Point
        Get
            Return GetPoint(2)
        End Get
    End Property

    Private Sub SortPoints()
        Points.Sort(Function(p1, p2) F(p1.X, p1.Y).CompareTo(F(p2.X, p2.Y)))
    End Sub
End Class
