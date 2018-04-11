<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioBooks
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
        Me.lstAudio = New System.Windows.Forms.ListBox()
        Me.btnAddAudio = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a Audio Book"
        '
        'lstAudio
        '
        Me.lstAudio.FormattingEnabled = True
        Me.lstAudio.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)"})
        Me.lstAudio.Location = New System.Drawing.Point(48, 66)
        Me.lstAudio.Name = "lstAudio"
        Me.lstAudio.Size = New System.Drawing.Size(283, 95)
        Me.lstAudio.TabIndex = 4
        '
        'btnAddAudio
        '
        Me.btnAddAudio.Location = New System.Drawing.Point(79, 237)
        Me.btnAddAudio.Name = "btnAddAudio"
        Me.btnAddAudio.Size = New System.Drawing.Size(90, 40)
        Me.btnAddAudio.TabIndex = 5
        Me.btnAddAudio.Text = "Add Book to Cart"
        Me.btnAddAudio.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(216, 237)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AudioBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 289)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddAudio)
        Me.Controls.Add(Me.lstAudio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AudioBooks"
        Me.Text = "Audio Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstAudio As ListBox
    Friend WithEvents btnAddAudio As Button
    Friend WithEvents btnClose As Button
End Class
