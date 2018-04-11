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
        Me.lblArray = New System.Windows.Forms.Label()
        Me.lblRandomIntegers = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMedian = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblArray
        '
        Me.lblArray.AutoSize = True
        Me.lblArray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArray.Location = New System.Drawing.Point(43, 75)
        Me.lblArray.MinimumSize = New System.Drawing.Size(200, 18)
        Me.lblArray.Name = "lblArray"
        Me.lblArray.Size = New System.Drawing.Size(200, 18)
        Me.lblArray.TabIndex = 0
        '
        'lblRandomIntegers
        '
        Me.lblRandomIntegers.AutoSize = True
        Me.lblRandomIntegers.Location = New System.Drawing.Point(40, 34)
        Me.lblRandomIntegers.MinimumSize = New System.Drawing.Size(200, 18)
        Me.lblRandomIntegers.Name = "lblRandomIntegers"
        Me.lblRandomIntegers.Size = New System.Drawing.Size(200, 18)
        Me.lblRandomIntegers.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Median:"
        '
        'lblMedian
        '
        Me.lblMedian.AutoSize = True
        Me.lblMedian.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMedian.Location = New System.Drawing.Point(93, 185)
        Me.lblMedian.MinimumSize = New System.Drawing.Size(60, 18)
        Me.lblMedian.Name = "lblMedian"
        Me.lblMedian.Size = New System.Drawing.Size(60, 18)
        Me.lblMedian.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(43, 122)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(43, 262)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(168, 262)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 309)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblMedian)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblRandomIntegers)
        Me.Controls.Add(Me.lblArray)
        Me.Name = "Form1"
        Me.Text = "Calculate the Median"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArray As Label
    Friend WithEvents lblRandomIntegers As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMedian As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
