Public Class PrintBooks

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnAddPrint_Click(sender As Object, e As EventArgs) Handles btnAddPrint.Click
        ' Declare Variables and Constants
        Dim decBook1Subtotal As Decimal
        Dim decTax As Decimal
        Dim decShipping As Decimal
        Dim decTotal As Decimal
        Const decTaxTotal As Decimal = 0.6
        Const decShippingRate As Decimal = 2 *

        If lstPrint.SelectedIndex = 0 Then
            decBook1Subtotal = CDec(11.95)
            decTax = CDec(11.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If
        If lstPrint.SelectedIndex = 1 Then
            decSubtotal = CDec(14.5)
            decTax = CDec(14.5 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If
        If lstPrint.SelectedIndex = 2 Then
            decSubtotal = CDec(29.95)
            decTax = CDec(29.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If
        If lstPrint.SelectedIndex = 3 Then
                decSubtotal = CDec(18.5)
                decTax = CDec(18.5 * decTaxTotal)
                decShipping = decShippingRate * 1
                decTotal = decSubtotal + decTax + decShipping
            End If



            ' Show total due
            Form1.lblSubtotal.Text = decSubtotal.ToString("c")
        Form1.lblTax.Text = decTax.ToString("c")
        Form1.lblShipping.Text = decShipping.ToString("c")
        Form1.lblTotal.Text = decTotal.ToString("c")
    End Sub
End Class