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
        Me.lblJoke = New System.Windows.Forms.Label()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.btnPunch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJoke
        '
        Me.lblJoke.AutoSize = True
        Me.lblJoke.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblJoke.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblJoke.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJoke.Location = New System.Drawing.Point(73, 38)
        Me.lblJoke.MinimumSize = New System.Drawing.Size(300, 50)
        Me.lblJoke.Name = "lblJoke"
        Me.lblJoke.Size = New System.Drawing.Size(300, 50)
        Me.lblJoke.TabIndex = 0
        Me.lblJoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSetup
        '
        Me.btnSetup.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetup.ForeColor = System.Drawing.Color.Navy
        Me.btnSetup.Location = New System.Drawing.Point(73, 127)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(126, 41)
        Me.btnSetup.TabIndex = 1
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'btnPunch
        '
        Me.btnPunch.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPunch.ForeColor = System.Drawing.Color.Navy
        Me.btnPunch.Location = New System.Drawing.Point(247, 127)
        Me.btnPunch.Name = "btnPunch"
        Me.btnPunch.Size = New System.Drawing.Size(126, 41)
        Me.btnPunch.TabIndex = 2
        Me.btnPunch.Text = "Punch Line"
        Me.btnPunch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(462, 261)
        Me.Controls.Add(Me.btnPunch)
        Me.Controls.Add(Me.btnSetup)
        Me.Controls.Add(Me.lblJoke)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Joke and Punch Line"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJoke As Label
    Friend WithEvents btnSetup As Button
    Friend WithEvents btnPunch As Button
End Class
