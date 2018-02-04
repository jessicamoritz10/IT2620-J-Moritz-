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
        Me.btnOhio = New System.Windows.Forms.Button()
        Me.btnColorado = New System.Windows.Forms.Button()
        Me.btnUtah = New System.Windows.Forms.Button()
        Me.btnCalifornia = New System.Windows.Forms.Button()
        Me.btnArizona = New System.Windows.Forms.Button()
        Me.btnNewMexico = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOhio
        '
        Me.btnOhio.Location = New System.Drawing.Point(75, 66)
        Me.btnOhio.Name = "btnOhio"
        Me.btnOhio.Size = New System.Drawing.Size(100, 35)
        Me.btnOhio.TabIndex = 0
        Me.btnOhio.Text = "Ohio"
        Me.btnOhio.UseVisualStyleBackColor = True
        '
        'btnColorado
        '
        Me.btnColorado.Location = New System.Drawing.Point(75, 121)
        Me.btnColorado.Name = "btnColorado"
        Me.btnColorado.Size = New System.Drawing.Size(100, 35)
        Me.btnColorado.TabIndex = 1
        Me.btnColorado.Text = "Colorado"
        Me.btnColorado.UseVisualStyleBackColor = True
        '
        'btnUtah
        '
        Me.btnUtah.Location = New System.Drawing.Point(75, 174)
        Me.btnUtah.Name = "btnUtah"
        Me.btnUtah.Size = New System.Drawing.Size(100, 35)
        Me.btnUtah.TabIndex = 2
        Me.btnUtah.Text = "Utah"
        Me.btnUtah.UseVisualStyleBackColor = True
        '
        'btnCalifornia
        '
        Me.btnCalifornia.Location = New System.Drawing.Point(75, 226)
        Me.btnCalifornia.Name = "btnCalifornia"
        Me.btnCalifornia.Size = New System.Drawing.Size(100, 35)
        Me.btnCalifornia.TabIndex = 3
        Me.btnCalifornia.Text = "California"
        Me.btnCalifornia.UseVisualStyleBackColor = True
        '
        'btnArizona
        '
        Me.btnArizona.Location = New System.Drawing.Point(75, 277)
        Me.btnArizona.Name = "btnArizona"
        Me.btnArizona.Size = New System.Drawing.Size(100, 35)
        Me.btnArizona.TabIndex = 4
        Me.btnArizona.Text = "Arizona"
        Me.btnArizona.UseVisualStyleBackColor = True
        '
        'btnNewMexico
        '
        Me.btnNewMexico.Location = New System.Drawing.Point(75, 330)
        Me.btnNewMexico.Name = "btnNewMexico"
        Me.btnNewMexico.Size = New System.Drawing.Size(100, 35)
        Me.btnNewMexico.TabIndex = 5
        Me.btnNewMexico.Text = "New Mexico"
        Me.btnNewMexico.UseVisualStyleBackColor = True
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblState.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblState.Location = New System.Drawing.Point(83, 23)
        Me.lblState.MinimumSize = New System.Drawing.Size(80, 30)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(80, 30)
        Me.lblState.TabIndex = 6
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 377)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.btnNewMexico)
        Me.Controls.Add(Me.btnArizona)
        Me.Controls.Add(Me.btnCalifornia)
        Me.Controls.Add(Me.btnUtah)
        Me.Controls.Add(Me.btnColorado)
        Me.Controls.Add(Me.btnOhio)
        Me.Name = "Form1"
        Me.Text = "State Abbreviations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOhio As Button
    Friend WithEvents btnColorado As Button
    Friend WithEvents btnUtah As Button
    Friend WithEvents btnCalifornia As Button
    Friend WithEvents btnArizona As Button
    Friend WithEvents btnNewMexico As Button
    Friend WithEvents lblState As Label
End Class
