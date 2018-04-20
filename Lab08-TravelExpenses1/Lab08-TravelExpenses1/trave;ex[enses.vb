Public Class Form1

    Const dblMEALS As Double = 37
    Const dblMIlES As Double = 0.27
    Const dblPARKING As Double = 10
    Const dblTAXI As Double = 20
    Const dblLODGE As Double = 95





    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click


        Dim dblTotal As Double
        Dim dblSaved As Double
        Dim dblReimbursed As Double
        Dim dblUnallowed As Double
        Dim dblAirfare As Double
        Dim dblCar As Double
        Dim dblRegistration As Double

        dblAirfare = CDbl(txtAirfare.Text)
        dblCar = CDbl(txtCar.Text)
        dblRegistration = CDbl(txtRegistration.Text)


        dblTotal = CalcMeals() + CalcLodging() + CalcParkingFees() + CalcTaxiFees() + CalcMileage() + dblAirfare + dblCar + dblRegistration




        lblCustomerTotal.Text = FormatCurrency(dblTotal.ToString)

        dblReimbursed = CalcTotalReimbursement()

        lblAllowed.Text = FormatCurrency(dblReimbursed.ToString)

        dblSaved = CalcSaved()

        lblSaved.Text = FormatCurrency(dblSaved.ToString)

        dblUnallowed = CalcUnallowed()

        lblOverage.Text = FormatCurrency(dblUnallowed.ToString)




    End Sub

    Function CalcMeals() As Double

        Dim dblTotalMeal As Double

        If Not txtDaysTrip.Text = String.Empty Then

            If Double.TryParse(txtDaysTrip.Text, dblTotalMeal) Then

                dblTotalMeal = dblMEALS * CDbl(txtDaysTrip.Text)
            End If
        End If
        Return (dblTotalMeal)


    End Function

    Function CalcMileage() As Double


        Dim dblTotalMiles As Double

        If Not txtMiles.Text = String.Empty Then
            If Double.TryParse(txtMiles.Text, dblTotalMiles) Then
                dblTotalMiles = dblMIlES * CDbl(txtMiles.Text)
            End If
        End If


        Return (dblTotalMiles)

    End Function

    Function CalcParkingFees() As Double


        Dim dblParkingTotal As Double

        If Not txtParking.Text = String.Empty Then

            If Double.TryParse(txtParking.Text, dblParkingTotal) Then

                dblParkingTotal = dblPARKING * CDbl(txtDaysTrip.Text)

            End If
        End If


        Return (dblParkingTotal)

    End Function
    Function CalcTaxiFees() As Double

        Dim dblTaxiTotal As Double

        If Not txtTaxi.Text = String.Empty Then

            If Double.TryParse(txtTaxi.Text, dblTaxiTotal) Then

                dblTaxiTotal = dblTAXI * CDbl(txtDaysTrip.Text)

            End If

        End If

        Return (dblTaxiTotal)

    End Function
    Function CalcLodging() As Double


        Dim dblLodgeTotal As Double

        If Not txtLodge.Text = String.Empty Then
            If Double.TryParse(txtLodge.Text, dblLodgeTotal) Then

                dblLodgeTotal = dblLODGE * CDbl(txtDaysTrip.Text)

            End If
        End If

        Return (dblLodgeTotal)

    End Function
    Function CalcTotalReimbursement() As Double



        Dim dblTotalReimbursed As Double

        If Not txtMeals.Text = String.Empty Then
            If Double.TryParse(txtMeals.Text, dblTotalReimbursed) Then

                If (CalcMeals() / CDbl(txtMeals.Text)) < dblMEALS Then

                    dblTotalReimbursed += CalcMeals()
                Else
                    dblTotalReimbursed += dblMEALS * CDbl(txtDaysTrip.Text)

                End If
            End If
        End If


        If Not txtMiles.Text = String.Empty Then
            If Double.TryParse(txtMiles.Text, dblTotalReimbursed) Then

                If (CalcMileage() / CDbl(txtMiles.Text)) < dblMIlES Then

                    dblTotalReimbursed += CalcMileage()
                Else
                    dblTotalReimbursed += dblMIlES * CDbl(txtMiles.Text)

                End If
            End If
        End If


        If Not txtParking.Text = String.Empty Then
            If Double.TryParse(txtParking.Text, dblTotalReimbursed) Then

                If (CalcParkingFees() / CDbl(txtParking.Text)) < dblPARKING Then

                    dblTotalReimbursed += CalcParkingFees()
                Else
                    dblTotalReimbursed += dblPARKING * CDbl(txtDaysTrip.Text)

                End If
            End If
        End If

        If Not txtTaxi.Text = String.Empty Then
            If Double.TryParse(txtTaxi.Text, dblTotalReimbursed) Then

                If (CalcTaxiFees() / CDbl(txtTaxi.Text)) < dblTAXI Then

                    dblTotalReimbursed += CalcTaxiFees()
                Else
                    dblTotalReimbursed += dblTAXI * CDbl(txtDaysTrip.Text)

                End If
            End If
        End If

        If Not txtLodge.Text = String.Empty Then
            If Double.TryParse(txtLodge.Text, dblTotalReimbursed) Then

                If (CalcLodging() / CDbl(txtLodge.Text)) < dblLODGE Then

                    dblTotalReimbursed += CalcLodging()
                Else
                    dblTotalReimbursed += dblLODGE * CDbl(txtDaysTrip.Text)

                End If
            End If
        End If


        Return dblTotalReimbursed

    End Function

    Function CalcUnallowed() As Double


        Dim dblUnallowed As Double


        If Not txtParking.Text = String.Empty Then
            If Double.TryParse(txtParking.Text, dblUnallowed) Then
                If ((CDbl(txtParking.Text) * CDbl(txtDaysTrip.Text)) - CalcParkingFees()) > 0 Then

                    dblUnallowed += ((CDbl(txtParking.Text) * CDbl(txtDaysTrip.Text)) - CalcParkingFees())

                End If
            End If
        End If

        If Not txtTaxi.Text = String.Empty Then
            If Double.TryParse(txtTaxi.Text, dblUnallowed) Then
                If ((CDbl(txtTaxi.Text) * CDbl(txtDaysTrip.Text)) - CalcTaxiFees()) > 0 Then

                    dblUnallowed += ((CDbl(txtTaxi.Text) * CDbl(txtDaysTrip.Text)) - CalcTaxiFees())

                End If
            End If
        End If

        If Not txtLodge.Text = String.Empty Then
            If Double.TryParse(txtLodge.Text, dblUnallowed) Then
                If ((CDbl(txtLodge.Text) * CDbl(txtDaysTrip.Text)) - CalcLodging()) > 0 Then

                    dblUnallowed += ((CDbl(txtLodge.Text) * CDbl(txtDaysTrip.Text)) - CalcLodging())
                End If
            End If
        End If

        If Not txtMeals.Text = String.Empty Then
            If Double.TryParse(txtMeals.Text, dblUnallowed) Then
                If ((CDbl(txtMeals.Text) * CDbl(txtDaysTrip.Text)) - CalcMeals()) > 0 Then

                    dblUnallowed += ((CDbl(txtMeals.Text) * CDbl(txtDaysTrip.Text)) - CalcMeals())
                End If
            End If
        End If


        Return dblUnallowed

    End Function

    Function CalcSaved() As Double



        Dim dblSaved As Double

        If Not txtParking.Text = String.Empty Then
            If Double.TryParse(txtParking.Text, dblSaved) Then
                If CalcParkingFees() - (CDbl(txtDaysTrip.Text) * CDbl(txtParking.Text)) > 0 Then

                    dblSaved += CalcParkingFees() - (CDbl(txtDaysTrip.Text) * CDbl(txtParking.Text))

                End If
            End If
        End If

        If Not txtTaxi.Text = String.Empty Then
            If Double.TryParse(txtTaxi.Text, dblSaved) Then
                If CalcTaxiFees() - (CDbl(txtDaysTrip.Text) * CDbl(txtTaxi.Text)) > 0 Then

                    dblSaved += CalcTaxiFees() - (CDbl(txtDaysTrip.Text) * CDbl(txtTaxi.Text))


                End If
            End If
        End If

        If Not txtLodge.Text = String.Empty Then
            If Double.TryParse(txtLodge.Text, dblSaved) Then
                If CalcLodging() - (CDbl(txtDaysTrip.Text) * CDbl(txtLodge.Text)) > 0 Then

                    dblSaved += CalcLodging() - (CDbl(txtDaysTrip.Text) * CDbl(txtLodge.Text))

                End If
            End If
        End If


        Return dblSaved


    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class