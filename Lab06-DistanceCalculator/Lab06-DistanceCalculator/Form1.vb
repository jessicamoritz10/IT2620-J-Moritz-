Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Define local variables
        Dim intTotal As Integer = 0
        Dim intDistance As Integer = 0
        Dim decSpeed As Decimal = 0
        Dim decTime As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim strSpeedInput As String
        Dim strTimeInput As String

        ' Get speed input from user
        strSpeedInput = InputBox("Enter the speed (mph) of traveling vehicle:")

        ' Confirm a numeric value was inputed
        If Decimal.TryParse(strSpeedInput, decSpeed) Then
            strTimeInput = InputBox("Enter the time (hours) that the vehicle is traveling:")

            ' Confirm a numeric value was inputed
            If Decimal.TryParse(strTimeInput, decTime) Then
                decTotal = decTime * decSpeed

                ' Displays speed
                strSpeedInput = "Vehicles Speed: " & decSpeed.ToString() & " MPH"
                lstDistance.Items.Add(strSpeedInput)

                ' Displays time traveled
                lstDistance.Items.Add("Time Traveled: " & decTime.ToString() & " Hours")

                ' Displays Hours and Distance Traveled column
                lstDistance.Items.Add("Hours           Distance Traveled")

                ' Displays line
                lstDistance.Items.Add("---------------------")

                For intTotal = 1 To 7
                    ' Calculate the distance
                    intDistance = CInt(intTotal * decSpeed)

                    lstDistance.Items.Add(intTotal.ToString() & "        " & intDistance.ToString())
                Next

                ' Display total distance
                lstDistance.Items.Add("Total Distance:  " & decTotal.ToString)
            Else
                MessageBox.Show("Error: Please enter a numeric valule for time.")
            End If
        Else
            MessageBox.Show("Error: Please enter a numeric value for speed.")
        End If




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
