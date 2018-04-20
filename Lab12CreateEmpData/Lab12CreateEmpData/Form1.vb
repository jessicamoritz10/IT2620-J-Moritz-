Imports System.IO
Public Class Form1

    Dim txtFile As StreamWriter
    Dim fileName As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileName = InputBox("Enter the File Name:", "File Name")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtFile = File.AppendText(fileName)

        Try
            txtFile.WriteLine(txtFirstName.Text)
            txtFile.WriteLine(txtMiddleName.Text)
            txtFile.WriteLine(txtLastName.Text)
            txtFile.WriteLine(Convert.ToInt32(txtEmpNumber.Text))
            txtFile.WriteLine(cboDepartment.SelectedItem.ToString())
            txtFile.WriteLine(txtPhoneNumber.Text)
            txtFile.WriteLine(Convert.ToInt32(txtPhoneExt.Text))
            txtFile.WriteLine(txtEmail.Text)
txtFile:    Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmpNumber.Text = ""
        cboDepartment.SelectedIndex = -1
        txtPhoneNumber.Text = ""
        txtPhoneExt.Text = ""
        txtEmail.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class