﻿Public Class Form1

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs)
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display a simple about box.
        MessageBox.Show("A shopping cart for print and audio books that you would like to purchase.")
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ' Clear all fields
        lstCart.Text = String.Empty
        lblShipping.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        ' Display the form in modal style.
        frmPrintBooks.ShowDialog()
    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        ' Display the form in modal style.
        frmAudioBooks.ShowDialog()
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstCart.Items.Clear()
        lblSubtotal.Text = 0
        lblTax.Text = 0
        lblShipping.Text = 0
        lblTotal.Text = 0
    End Sub
End Class