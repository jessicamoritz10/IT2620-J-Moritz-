﻿Public Class PrintBooks

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnAddPrint_Click(sender As Object, e As EventArgs) Handles btnAddPrint.Click
        ' Declare Variables and Constants
        Dim objectForm1 As New Form1
        If lstPrint.SelectedIndex <> -1 Then
            Form1.lstCart.Items.Add(lstPrint.SelectedItem.ToString())
            Form1.lblSubtotal.Text = (CDbl(Form1.lblSubtotal.Text) +
                objectForm1.Print_Cost(lstPrint.SelectedIndex)).ToString()
            Form1.lblTax.Text = ((CDbl(Form1.lblSubtotal.Text)) * 6 / 100).ToString()
            Form1.lblTotal.Text = (Form1.lblSubtotal.Text) + (Form1.lblTax.Text) + (Form1.lblShipping.Text).ToString()

        End If
    End Sub


End Class