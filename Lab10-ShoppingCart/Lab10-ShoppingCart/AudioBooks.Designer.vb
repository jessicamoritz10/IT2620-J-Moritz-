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
        Me.lstAudio = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAddAudio = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAudio
        '
        Me.lstAudio.FormattingEnabled = True
        Me.lstAudio.Items.AddRange(New Object() {"Learn Calculus in One Day (Audio)", "Relaxation Techniques (Audio)", "The History of Scotland (Audio)", "The Science of Body Language (Audio)"})
        Me.lstAudio.Location = New System.Drawing.Point(32, 62)
        Me.lstAudio.Name = "lstAudio"
        Me.lstAudio.Size = New System.Drawing.Size(300, 121)
        Me.lstAudio.TabIndex = 0
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
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select an Audio Book"
        '
        'BtnAddAudio
        '
        Me.BtnAddAudio.Location = New System.Drawing.Point(78, 228)
        Me.BtnAddAudio.Name = "BtnAddAudio"
        Me.BtnAddAudio.Size = New System.Drawing.Size(92, 40)
        Me.BtnAddAudio.TabIndex = 5
        Me.BtnAddAudio.Text = "Add Book to Cart"
        Me.BtnAddAudio.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(199, 228)
        Me.BtnClose.MinimumSize = New System.Drawing.Size(92, 40)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(92, 40)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'AudioBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 284)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnAddAudio)
        Me.Controls.Add(Me.lstAudio)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AudioBooks"
        Me.Text = "Audio Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAudio As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAddAudio As Button
    Friend WithEvents BtnClose As Button
End Class
