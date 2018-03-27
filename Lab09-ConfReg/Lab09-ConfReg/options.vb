Public Class frmOptions
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        chkConference.Checked = False
        chkOpening.Checked = False
        lstSelect.SelectedIndex = -1
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim conferencecost As Integer
        Dim subtotal As Integer
        Dim basecost As Integer
        Dim opt1cost As Integer
        Dim opt2cost As Integer
        Dim opt3cost As Integer
        basecost = 895
        opt1cost = 30
        opt2cost = 295
        opt3cost = 395
        If lstSelect.SelectedIndex = 0 Then
            subtotal = opt2cost
        ElseIf lstSelect.SelectedIndex = 1 Then
            subtotal = opt2cost
        ElseIf lstSelect.SelectedIndex = 2 Then
            subtotal = opt3cost
        ElseIf lstSelect.SelectedIndex = 3 Then
            subtotal = opt3cost
        End If
        If chkOpening.Checked = True Then
            conferencecost = opt1cost + subtotal + basecost
        Else
            conferencecost = subtotal + basecost
        End If
        If lstSelect.SelectedIndex = -1 Then
            frmMain.lblPreconferenceWorkshop.Text = "None Selected"
        Else
            frmMain.lblPreconferenceWorkshop.Text = CStr(lstSelect.SelectedItem)
        End If
        frmMain.lblTotal.Text = CStr(conferencecost)
        Me.Hide()
        frmMain.Show()
        frmMain.BringToFront()
    End Sub

End Class
