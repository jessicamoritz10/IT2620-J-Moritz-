Public Class Form1

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        lblRandomIntegers.Text = ""
        lblArray.Text = ""

        'Random class object creation
        Dim randValue As System.Random = New System.Random()
        'Random Array generation
        Dim ArrayLength = randValue.Next(5, 10)

        'Array length Declaration
        Dim myRandomArray(ArrayLength - 1) As Integer

        'Generates the numbers from 1 to 100
        For iter As Integer = 1 To ArrayLength
            myRandomArray(iter - 1) = randValue.Next(1, 100)
        Next

        Dim ValStr As String
        ValStr = "Randomly generated integer array: "
        lblRandomIntegers.Text = lblRandomIntegers.Text + ValStr

        ValStr = ""

        'Loop generates the array and the comma separated array elements
        For iter As Integer = 1 To ArrayLength
            ValStr = ValStr + myRandomArray(iter - 1).ToString()
            If (iter < ArrayLength) Then
                ValStr = ValStr + ", "
            End If
        Next

        'Shows the Array Label
        lblArray.Text = ValStr

        'Implements the bubble sort to perform sort
        For iter = 1 To ArrayLength - 1
            For jth = 0 To ArrayLength - 1 - iter
                If (myRandomArray(jth) > myRandomArray(jth + 1)) Then
                    Dim temp As Integer = myRandomArray(jth)
                    myRandomArray(jth) = myRandomArray(jth + 1)
                    myRandomArray(jth + 1) = temp
                End If
            Next
        Next

        'Declares the median and midterm variables
        Dim Findmedian As Double
        Dim Findmiddleterm As Integer

        'Checks the whether array length is even
        If ArrayLength Mod 2 = 0 Then
            'if condition true get the even index value
            Findmiddleterm = ((ArrayLength) / 2.0)
            'Calculate the median value Average
            Findmedian = (myRandomArray(Findmiddleterm - 1) + myRandomArray(Findmiddleterm)) / 2

        Else

            'odd Array length get the centre index value
            Findmiddleterm = ((ArrayLength) / 2.0)
            'FInding the array middle term
            Findmedian = myRandomArray(Findmiddleterm)

        End If

        'Shows the Median
        lblMedian.Text = Findmedian.ToString()
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'clears all the contents
        lblRandomIntegers.Text = ""
        lblArray.Text = ""
        lblMedian.Text = ""
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'closing the form
        Me.Close()
    End Sub

End Class
