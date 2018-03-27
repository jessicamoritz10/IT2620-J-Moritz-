
Public Class frmMain

    Private Sub btnSelectConference_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectConference.Click
        frmOptions.Show()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblTotal.Text = String.Empty
        lblPreconferenceWorkshop.Text = String.Empty
        txtName.Clear()
        txtCompany.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtState.Clear()
        txtZip.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
