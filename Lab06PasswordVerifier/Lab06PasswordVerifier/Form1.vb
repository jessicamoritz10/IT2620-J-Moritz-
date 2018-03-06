Public Class Form1
    Function IsValid(strPassword As String) As Boolean
        Dim pwPart As String
        Dim I As Integer
        Dim L As Integer
        Dim lengthOK, ContainsNumber, ContainsAlpha As Boolean
        L = strPassword.Length

        If L < 6 Then
            lengthOK = False
            Return False
        End If

        I = 0
        For I = 1 To L
            pwPart = Mid(strPassword, I, 1)
            If IsNumeric(pwPart) = True Then
                ContainsNumber = True
            End If
        Next
        I = 0
        For I = 1 To L
            pwPart = Mid(strPassword, I, 1)
            If IsNumeric(pwPart) = False Then
                ContainsAlpha = True
            End If
        Next
        If ContainsAlpha = True And ContainsNumber = True Then
            Return True
        End If

    End Function



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim password As String
        password = txtPassword.Text

        If IsValid(passWord) = True Then
            lblMessage.Text = "That password is valid"
        Else
            lblMessage.Text = "Password is invalid"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
