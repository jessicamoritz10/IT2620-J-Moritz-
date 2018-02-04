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
        Me.btnMaine = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOhio
        '
        Me.btnOhio.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOhio.Location = New System.Drawing.Point(75, 70)
        Me.btnOhio.Name = "btnOhio"
        Me.btnOhio.Size = New System.Drawing.Size(100, 35)
        Me.btnOhio.TabIndex = 0
        Me.btnOhio.Text = "Ohio"
        Me.btnOhio.UseVisualStyleBackColor = True
        '
        'btnColorado
        '
        Me.btnColorado.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColorado.Location = New System.Drawing.Point(75, 121)
        Me.btnColorado.Name = "btnColorado"
        Me.btnColorado.Size = New System.Drawing.Size(100, 35)
        Me.btnColorado.TabIndex = 1
        Me.btnColorado.Text = "Colorado"
        Me.btnColorado.UseVisualStyleBackColor = True
        '
        'btnUtah
        '
        Me.btnUtah.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUtah.Location = New System.Drawing.Point(75, 174)
        Me.btnUtah.Name = "btnUtah"
        Me.btnUtah.Size = New System.Drawing.Size(100, 35)
        Me.btnUtah.TabIndex = 2
        Me.btnUtah.Text = "Utah"
        Me.btnUtah.UseVisualStyleBackColor = True
        '
        'btnCalifornia
        '
        Me.btnCalifornia.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalifornia.Location = New System.Drawing.Point(75, 226)
        Me.btnCalifornia.Name = "btnCalifornia"
        Me.btnCalifornia.Size = New System.Drawing.Size(100, 35)
        Me.btnCalifornia.TabIndex = 3
        Me.btnCalifornia.Text = "California"
        Me.btnCalifornia.UseVisualStyleBackColor = True
        '
        'btnArizona
        '
        Me.btnArizona.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArizona.Location = New System.Drawing.Point(75, 277)
        Me.btnArizona.Name = "btnArizona"
        Me.btnArizona.Size = New System.Drawing.Size(100, 35)
        Me.btnArizona.TabIndex = 4
        Me.btnArizona.Text = "Arizona"
        Me.btnArizona.UseVisualStyleBackColor = True
        '
        'btnMaine
        '
        Me.btnMaine.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaine.Location = New System.Drawing.Point(75, 330)
        Me.btnMaine.Name = "btnMaine"
        Me.btnMaine.Size = New System.Drawing.Size(100, 35)
        Me.btnMaine.TabIndex = 5
        Me.btnMaine.Text = "Maine"
        Me.btnMaine.UseVisualStyleBackColor = True
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblState.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblState.Location = New System.Drawing.Point(75, 18)
        Me.lblState.MinimumSize = New System.Drawing.Size(100, 35)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(100, 35)
        Me.lblState.TabIndex = 6
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(244, 377)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.btnMaine)
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
    Friend WithEvents btnMaine As Button
    Friend WithEvents lblState As Label
End Class
