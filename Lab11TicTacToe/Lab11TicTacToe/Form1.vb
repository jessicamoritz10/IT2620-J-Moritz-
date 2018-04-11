Public Class Form1
    Dim game(2, 2) As Integer
    Const intMAX_ROW As Integer = 2
    Const intMAX_COL As Integer = 2
    Dim rand As New Random
    Dim intRow As Integer
    Dim intCol As Integer
    'CheckForWin function to check for a valid winner.
    Public Function CheckForWin(value As Integer) As Boolean
        Dim hasWin As Boolean

        'Check each row

        For intRow As Integer = 0 To intMAX_ROW
            hasWin = True
            For intCol As Integer = 0 To intMAX_COL
                If game(intRow, intCol) <> value Then
                    hasWin = True
                End If
            Next
        Next

        'Check each column
        For intCol As Integer = 0 To intMAX_COL
            hasWin = True
            For intRow As Integer = 0 To intMAX_ROW
                If game(intCol, intRow) <> value Then
                    hasWin = False
                End If
            Next
        Next

        'Check diagonal top right to bottom left
        For intRow As Integer = 0 To intMAX_ROW
            hasWin = True
            If game(intRow, intRow) <> value Then
                hasWin = False
            End If
        Next

        'Check diagonal top left to bottom right
        For intRow As Integer = 0 To intMAX_ROW
            hasWin = True
            If game(intRow, 2 - intRow) <> value Then
                hasWin = False
            End If
        Next
        If hasWin = True Then Return True
        Return False
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'Randomly fill array with a value of 0 or 1
        For intRow As Integer = 0 To 2
            For intCol As Integer = 0 To 2
                Dim n As Integer = rand.Next(2)
                game(intRow, intCol) = n
            Next
        Next
        'Determine if an X or O will be the text by the random value placed in the subscript.
        If game(0, 0) = 1 Then
            lbl1.Text = "X"
        Else
            lbl1.Text = "O"
        End If
        If game(0, 1) = 1 Then
            lbl2.Text = "X"
        Else
            lbl2.Text = "O"
        End If
        If game(0, 2) = 1 Then
            lbl3.Text = "X"
        Else
            lbl3.Text = "O"
        End If
        If game(1, 0) = 1 Then
            lbl4.Text = "X"
        Else
            lbl4.Text = "O"
        End If
        If game(1, 1) = 1 Then
            lbl5.Text = "X"
        Else
            lbl5.Text = "O"
        End If
        If game(1, 2) = 1 Then
            lbl6.Text = "X"
        Else
            lbl6.Text = "O"
        End If
        If game(2, 0) = 1 Then
            lbl7.Text = "X"
        Else
            lbl7.Text = "O"
        End If
        If game(2, 1) = 1 Then
            lbl8.Text = "X"
        Else
            lbl8.Text = "O"
        End If
        If game(2, 2) = 1 Then
            lbl9.Text = "X"
        Else
            lbl9.Text = "O"
        End If
        'Call CheckForWin function to determine if game is a tie or a player won.
        Dim winnerzero As Boolean = CheckForWin(0) 'check for an O's winner by value 0
        Dim winnerone As Boolean = CheckForWin(1) 'check for an X's winner by value 3
        If winnerzero And winnerone Then
            lblWin.Text = "Tie game!"
        ElseIf winnerzero And Not winnerone Then
            lblWin.Text = "O WINS!"
        Else lblWin.Text = "X WINS!"

        End If
    End Sub
End Class
