Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare a variable to store user input string from the input box
        Dim strInputString As String = InputBox(
            "Enter a positive integer value.", "Input Needed", "10")

        ' Declare a variable to store the user input.
        Dim intInputNumber As Integer

        ' Initialize a variable to store sum of the numberse.
        Dim intSum As Integer = 0

        If Integer.TryParse(strInputString, intInputNumber) And
             intInputNumber >= 0 Then

            'Use For Loop ro sum of all values from 1 through the value entered by user.
            Dim intCounter As Integer
            For intCounter = 1 To intInputNumber
                intSum += intCounter
            Next
            ' Display a message to the user indicating sum.
            MessageBox.Show("The sum of numbers 1 through" &
                            strInputString & " is " &
                            intSum.ToString("d"), "Sum of Numbers")

        Else
            ' Error message for invalid input.
            MessageBox.Show("Enter a positive integer value.", "Invalid Input")
        End If

    End Sub
End Class
