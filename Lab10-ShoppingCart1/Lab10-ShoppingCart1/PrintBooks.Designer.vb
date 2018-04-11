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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPrint
        '
        Me.lstPrint.FormattingEnabled = True
        Me.lstPrint.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstPrint.Location = New System.Drawing.Point(48, 66)
        Me.lstPrint.Name = "lstPrint"
        Me.lstPrint.Size = New System.Drawing.Size(283, 95)
        Me.lstPrint.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.MinimumSize = New System.Drawing.Size(320, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 180)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select a Print Book"
        '
        'btnAddPrint
        '
        Me.btnAddPrint.Location = New System.Drawing.Point(79, 237)
        Me.btnAddPrint.Name = "btnAddPrint"
        Me.btnAddPrint.Size = New System.Drawing.Size(90, 40)
        Me.btnAddPrint.TabIndex = 3
        Me.btnAddPrint.Text = "Add Book to Cart"
        Me.btnAddPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(215, 237)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 40)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PrintBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 289)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddPrint)
        Me.Controls.Add(Me.lstPrint)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PrintBooks"
        Me.Text = "Print Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPrint As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddPrint As Button
    Friend WithEvents btnClose As Button
End Class
