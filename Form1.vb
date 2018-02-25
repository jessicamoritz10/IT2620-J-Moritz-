Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intDecimalInteger As Integer

        If Integer.TryParse(txtDecimalInteger.Text, intDecimalInteger) Then
        End If
        ' Display Roman Numeral.
        Select Case intDecimalInteger
                Case 1
                    lblRomanNumeral.Text = "I"
                Case 2
                    lblRomanNumeral.Text = "II"
                Case 3
                    lblRomanNumeral.Text = "III"
                Case 4
                    lblRomanNumeral.Text = "IV"
                Case 5
                    lblRomanNumeral.Text = "V"
                Case 6
                    lblRomanNumeral.Text = "VI"
                Case 7
                    lblRomanNumeral.Text = "VII"
                Case 8
                    lblRomanNumeral.Text = "VIII"
                Case 9
                    lblRomanNumeral.Text = "IX"
                Case 10
                    lblRomanNumeral.Text = "X"
                    'Display error message.
                Case Else
                    lblRomanNumeral.Text = "Not in range 1 - 10"
            End Select
    End Sub
End Class
