Imports PracticalGeneticAlgorithms.Lib

Public Class PracticalGeneticAlgorithmsForm

    Private Sub CalculateButton_Click(sender As System.Object, e As System.EventArgs) Handles CalculateButton.Click
        Dim X, Y As Integer

        If Integer.TryParse(XTextBox.Text, X) AndAlso Integer.TryParse(YTextBox.Text, Y) Then
            OutputTextBox.Text = NelderMeadProblem.F(X, Y)
        End If
    End Sub
End Class
