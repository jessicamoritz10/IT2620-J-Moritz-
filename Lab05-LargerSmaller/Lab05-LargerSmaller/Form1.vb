Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        ' Declare variables.
        Dim intA As Integer
        Dim intB As Integer
        lblResults.Text = String.Empty

        If Integer.TryParse(txtIntegerA.Text, intA) = False Then
            lblResults.Text = "Enter a valid integer."
        End If
        If Integer.TryParse(txtIntegerB.Text, intB) = False Then
            lblResults.Text = "Enter a valid integer."
        End If
        'Determine which number is greater
        If intA > intB Then
            lblResults.Text = "Integer A is greater."
        End If
        If intA < intB Then
                lblResults.Text = "Integer B is greater."
            End If

    End Sub
End Class
