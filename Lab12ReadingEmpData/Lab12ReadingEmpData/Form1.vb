Imports System.IO

Public Class Form1

    Dim txtFile As StreamReader
    Dim fileName As String
    Dim recordno As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fileName = InputBox("Enter the File Name", "File Name")
        txtFile = File.OpenText(fileName)
        setData()
    End Sub

    Public Sub setData()
        recordno += 1

        If Not txtFile.EndOfStream Then
            txtRecordNo.Text = recordno

            txtFirstName.Text = txtFile.ReadLine()
            txtMiddleName.Text = txtFile.ReadLine()
            txtLastName.Text = txtFile.Readline()
            txtEmpNumber.Text = txtFile.Readline()
            txtDepartment.Text = txtFile.Readline()
            txtPhoneNumber.Text = txtFile.Readline()
            txtPhoneExt.Text = txtFile.ReadLine()
            txtEmail.Text = txtFile.Readline()

        Else
            MessageBox.Show("End of file reached")


        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmpNumber.Text = ""
        txtDepartment.Text = ""
        txtPhoneNumber.Text = ""
        txtPhoneExt.Text = ""
        txtEmail.Text = ""


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
