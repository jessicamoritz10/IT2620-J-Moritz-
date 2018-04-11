<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintBooks
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
        Me.lstPrint = New System.Windows.Forms.ListBox()
        Me.BtnAddPrint = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstPrint
        '
        Me.lstPrint.FormattingEnabled = True
        Me.lstPrint.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus In One Day (Print)", "Feel the Stress (Print)"})
        Me.lstPrint.Location = New System.Drawing.Point(32, 62)
        Me.lstPrint.Name = "lstPrint"
        Me.lstPrint.Size = New System.Drawing.Size(300, 121)
        Me.lstPrint.TabIndex = 0
        '
        'BtnAddPrint
        '
        Me.BtnAddPrint.Location = New System.Drawing.Point(78, 228)
        Me.BtnAddPrint.Name = "BtnAddPrint"
        Me.BtnAddPrint.Size = New System.Drawing.Size(92, 40)
        Me.BtnAddPrint.TabIndex = 1
        Me.BtnAddPrint.Text = "Add Book to Cart"
        Me.BtnAddPrint.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(199, 228)
        Me.BtnClose.MinimumSize = New System.Drawing.Size(92, 40)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(92, 40)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.MinimumSize = New System.Drawing.Size(320, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 180)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a Print Book"
        '
        'PrintBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 289)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAddPrint)
        Me.Controls.Add(Me.lstPrint)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PrintBooks"
        Me.Text = "Print Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPrint As ListBox
    Friend WithEvents BtnAddPrint As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
End Class
