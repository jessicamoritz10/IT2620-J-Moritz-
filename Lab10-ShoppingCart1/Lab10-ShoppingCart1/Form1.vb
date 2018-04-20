Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display a simple about box.
        MessageBox.Show("A shopping cart for print and audio books that you would like to purchase.")
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ' Clear all fields
        lstCart.Text = ""
        lblShipping.Text = ""
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click

        Dim PrintBookList As New PrintBooks
        PrintBookList.Show()

    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        ' Display the form in modal style.

        Dim AudioBooklist As New AudioBooks
        AudioBooklist.Show()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSubtotal.Text = "0"
    End Sub

    Public Print_Cost() As Double = {11.95, 14.5, 29.95, 18.5}
    Public Audio_Cost() As Double = {29.95, 11.5, 14.5, 12.95}
    Public Print() As String = {"I Did it Your Way (Print)", "The History of Scotland (Print)",
       "Learn Calculus in Onr Day (Print)", "Feel the Stress (Print)"}
    Public Audio() As String = {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)",
        "The History of Scotland (Audio)", "The Science of Body Language (Audio)"}

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstCart.SelectedIndex <> -1 Then
            Dim i As Integer = 0
            Const Shipping As Single = 2.0

            For Each p As String In Print
                If p = lstCart.SelectedItem.ToString() Then
                    lblSubtotal.Text = CDbl(lblSubtotal.Text) - Print_Cost(i)
                    lblTax.Text = CDbl(lblSubtotal.Text) * 6 / 100
                    lblShipping.Text = CDbl(lstCart.Items.Count) * Shipping
                    lblTotal.Text = CDbl(lblSubtotal.Text) +
                        CDbl(lblTax.Text) + CDbl(lblShipping.Text)
                End If
                i = i + 1
            Next

            i = 0

            For Each d As String In Audio
                If d = lstCart.SelectedItem.ToString() Then
                    lblSubtotal.Text = CDbl(lblSubtotal.Text) - Audio_Cost(i)
                    lblTax.Text = CDbl(lblSubtotal.Text) * 6 / 100
                    lblShipping.Text = CDbl(lblShipping.Text) - 2
                    lblTotal.Text = CDbl(lblSubtotal.Text) +
                        CDbl(lblTax.Text) + CDbl(lblShipping.Text)
                End If

                i = i + 1
            Next

            lstCart.Items.RemoveAt(lstCart.SelectedIndex)
        End If
    End Sub


End Class