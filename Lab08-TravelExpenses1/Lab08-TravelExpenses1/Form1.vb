Public Class Form1
    Const dblMEALS As Double = 37
    Const dblPARKING_PER_DAY As Double = 10
    Const dblTAXI_PER_DAY As Double = 20
    Const dblLODGING_PER_DAY As Double = 95
    Const dblPER_MILE As Double = 0.27

    Private Sub btnCalc_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles btnCalc.Click
        ' This procedure calculates the travel expenses for a single person.

        Dim intDays As Integer
        Dim dblMilesDriven As Double
        Dim dblParkingFees As Double
        Dim dblTaxiFees As Double
        Dim dblLodgingFees As Double
        Dim dblNights As Double
        Dim dblAllMeals As Double
        Dim dblAllParkingFees As Double
        Dim dblAllTaxiFees As Double
        Dim dblAllLodgingFees As Double
        Dim dblAllMileageFees As Double
        Dim dblTotalFees As Double
        Dim dblTotalReimbursed As Double

        intDays = CInt(txtDays.Text)
        dblMilesDriven = CDbl(txtMiles.Text)
        dblParkingFees = CDbl(txtParking.Text)
        dblTaxiFees = CDbl(txtTaxi.Text)
        dblLodgingFees = CDbl(txtLodging.Text)
        dblNights = CDbl(txtNights.Text)

        dblAllLodgingFees = dblNights * dblLodgingFees
        dblAllMeals = intDays * dblMEALS
        dblAllParkingFees = dblParkingFees * intDays
        dblAllMileageFees = dblMilesDriven * dblPER_MILE
        dblAllTaxiFees = dblTaxiFees * intDays
        dblTotalFees = (dblAllLodgingFees + dblAllMeals + dblAllParkingFees + dblAllTaxiFees)
        dblTotalReimbursed = dblAllMileageFees + (intDays * dblPARKING_PER_DAY) _
        + (intDays * dblTAXI_PER_DAY) + (dblNights * dblLODGING_PER_DAY) + (dblAllMeals)






    End Sub

    Function CalcMeals(ByVal intDays As Integer) As Double
        ' This function calculates the amount reimbursed for meals.
        Return intDays * dblMEALS
    End Function

    Function CalcMileage(ByVal dblMilesDriven As Double) As Double
        ' This function calculates the amount reimbursed for miles driven.
        Return dblMilesDriven * dblPER_MILE
    End Function

    Function CalcParkingFees(ByVal intDays As Integer) As Double
        ' This function calculates the amount reimbursed for parking fees.
        Return dblPARKING_PER_DAY * intDays
    End Function

    Function CalcTaxiFees(ByVal intDays As Integer) As Double
        ' This function calculates the amount reimbursed for taxi fees.
        Return intDays * dblTAXI_PER_DAY
    End Function

    Function CalcLodging(ByVal dblNights As Double) As Double
        ' This function calculates the amount reimbursed for lodging expenses.
        Return dblNights * dblLODGING_PER_DAY
    End Function

    Function CalcTotalReimbursement(ByVal intDays, ByVal dblMilesDriven, ByVal dblNights) As Double
        ' This function calculates the total reimbursement for the trip.
        Dim dblTotalReimbursed As Double
        lblMessage.Text = dblTotalReimbursed.ToString("c")
        Return dblTotalReimbursed


    End Function

    Function CalcTotalUnallowed(ByVal dblTotalFees, ByVal dblTotalReimbursed) As Double
        Dim dblTotalUnallowed As Double

        dblTotalUnallowed = dblTotalFees - dblTotalReimbursed

        'If the amount that was paid is more than was spent then there is

        'no unallowed amount and a zero is returned else return the

        'unallowed amount

        If dblTotalUnallowed < 0.0 Then

            lblMessage.Text = ("You broke even.")

            Return 0

        Else

            lblMessage.Text = dblTotalUnallowed.ToString("c")

            Return dblTotalUnallowed

        End If

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
