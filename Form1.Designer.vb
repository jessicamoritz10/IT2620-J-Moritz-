<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDecimalInteger = New System.Windows.Forms.TextBox()
        Me.lblRomanNumeral = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.MinimumSize = New System.Drawing.Size(100, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a decimal integer in the range of 1 -10:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(55, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equivalent Roman Numeral:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(79, 175)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(87, 31)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(213, 175)
        Me.btnExit.MinimumSize = New System.Drawing.Size(87, 31)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 31)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtDecimalInteger
        '
        Me.txtDecimalInteger.Location = New System.Drawing.Point(180, 32)
        Me.txtDecimalInteger.MinimumSize = New System.Drawing.Size(120, 10)
        Me.txtDecimalInteger.Name = "txtDecimalInteger"
        Me.txtDecimalInteger.Size = New System.Drawing.Size(120, 20)
        Me.txtDecimalInteger.TabIndex = 4
        '
        'lblRomanNumeral
        '
        Me.lblRomanNumeral.AutoSize = True
        Me.lblRomanNumeral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRomanNumeral.Location = New System.Drawing.Point(180, 101)
        Me.lblRomanNumeral.MinimumSize = New System.Drawing.Size(120, 25)
        Me.lblRomanNumeral.Name = "lblRomanNumeral"
        Me.lblRomanNumeral.Size = New System.Drawing.Size(120, 25)
        Me.lblRomanNumeral.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 261)
        Me.Controls.Add(Me.lblRomanNumeral)
        Me.Controls.Add(Me.txtDecimalInteger)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Roman Numeral Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDecimalInteger As TextBox
    Friend WithEvents lblRomanNumeral As Label
End Class
