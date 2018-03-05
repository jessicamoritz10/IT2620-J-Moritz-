Public Class Form1

    Function CalculateRetail(ByVal dblWholesaleCost As Double,
             ByVal dblMarkupPercentage As Double) As Double

        Return dblWholesaleCost + dblWholesaleCost * (dblMarkupPercentage * 0.01)

    End Function


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Local variables
        Dim dblWholesaleCost As Double
        Dim dblMarkupPercentage As Double
        Dim dblRetailPrice As Double

        lblMessage.Text = String.Empty

        If Double.TryParse(txtWholesale.Text, dblWholesaleCost) Then

            If Double.TryParse(txtMarkup.Text, dblMarkupPercentage) Then


                dblRetailPrice = CalculateRetail(dblWholesaleCost, dblMarkupPercentage)
                lblPrice.Text = dblRetailPrice.ToString("c")

            Else
                lblMessage.Text = "Please enter a positive markup percentage"
            End If

        Else
            lblMessage.Text = "Please enter positive wholesale cost"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
