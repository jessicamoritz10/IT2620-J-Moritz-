Public Class AudioBooks

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close the form
        Me.Close()
    End Sub

    Private Sub btnAddAudio_Click(sender As Object, e As EventArgs) Handles btnAddAudio.Click
        'Declare Variables and Constants
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decShipping As Decimal
        Dim decTotal As Decimal
        Const decTaxTotal As Decimal = 0.6D
        Const decShippingRate As Decimal = 2D

        If lstAudio.SelectedIndex = 0 Then
            decSubtotal = CDec(29.95)
            decTax = CDec(29.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If
        If lstAudio.SelectedIndex = 1 Then
            decSubtotal = CDec(14.5)
            decTax = CDec(14.5 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If
        If lstAudio.SelectedIndex = 2 Then
            decSubtotal = CDec(12.95)
            decTax = CDec(12.95 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If
        If lstAudio.SelectedIndex = 3 Then
            decSubtotal = CDec(11.5)
            decTax = CDec(11.5 * decTaxTotal)
            decShipping = decShippingRate * 1
            decTotal = decSubtotal + decTax + decShipping
        End If

        If lstAudio.SelectedIndex >= 0 Then
            Form1.lstCart.Items.Add(lstAudio.SelectedItem)
        End If

        ' Show total due
        Form1.lblSubtotal.Text = decSubtotal.ToString("c")
        Form1.lblTax.Text = decTax.ToString("c")
        Form1.lblShipping.Text = decShippingRate.ToString("c")
        Form1.lblTotal.Text = decTotal.ToString("c")
    End Sub
End Class