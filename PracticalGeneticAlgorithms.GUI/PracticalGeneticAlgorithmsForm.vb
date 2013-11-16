Imports PracticalGeneticAlgorithms.Lib

Public Class PracticalGeneticAlgorithmsForm

    Private Sub CalculateButton_Click(sender As System.Object, e As System.EventArgs) Handles CalculateButton.Click
        Dim X, Y As Double

        If Double.TryParse(XTextBox.Text, X) AndAlso Double.TryParse(YTextBox.Text, Y) Then
            OutputTextBox.Text = FunctionsToMinimise.F_1_1(New Point2D(X, Y))
        End If
    End Sub
End Class
