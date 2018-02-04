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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOhio
        '
        Me.btnOhio.Location = New System.Drawing.Point(105, 64)
        Me.btnOhio.Name = "btnOhio"
        Me.btnOhio.Size = New System.Drawing.Size(75, 23)
        Me.btnOhio.TabIndex = 0
        Me.btnOhio.Text = "Ohio"
        Me.btnOhio.UseVisualStyleBackColor = True
        '
        'btnColorado
        '
        Me.btnColorado.Location = New System.Drawing.Point(105, 102)
        Me.btnColorado.Name = "btnColorado"
        Me.btnColorado.Size = New System.Drawing.Size(75, 23)
        Me.btnColorado.TabIndex = 1
        Me.btnColorado.Text = "Colorado"
        Me.btnColorado.UseVisualStyleBackColor = True
        '
        'btnUtah
        '
        Me.btnUtah.Location = New System.Drawing.Point(105, 142)
        Me.btnUtah.Name = "btnUtah"
        Me.btnUtah.Size = New System.Drawing.Size(75, 23)
        Me.btnUtah.TabIndex = 2
        Me.btnUtah.Text = "Utah"
        Me.btnUtah.UseVisualStyleBackColor = True
        '
        'btnCalifornia
        '
        Me.btnCalifornia.Location = New System.Drawing.Point(105, 185)
        Me.btnCalifornia.Name = "btnCalifornia"
        Me.btnCalifornia.Size = New System.Drawing.Size(100, 35)
        Me.btnCalifornia.TabIndex = 3
        Me.btnCalifornia.Text = "California"
        Me.btnCalifornia.UseVisualStyleBackColor = True
        '
        'btnArizona
        '
        Me.btnArizona.Location = New System.Drawing.Point(105, 229)
        Me.btnArizona.Name = "btnArizona"
        Me.btnArizona.Size = New System.Drawing.Size(100, 35)
        Me.btnArizona.TabIndex = 4
        Me.btnArizona.Text = "Arizona"
        Me.btnArizona.UseVisualStyleBackColor = True
        '
        'btnNewMexico
        '
        Me.btnNewMexico.Location = New System.Drawing.Point(93, 269)
        Me.btnNewMexico.Name = "btnNewMexico"
        Me.btnNewMexico.Size = New System.Drawing.Size(100, 35)
        Me.btnNewMexico.TabIndex = 5
        Me.btnNewMexico.Text = "New Mexico"
        Me.btnNewMexico.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 316)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewMexico)
        Me.Controls.Add(Me.btnArizona)
        Me.Controls.Add(Me.btnCalifornia)
        Me.Controls.Add(Me.btnUtah)
        Me.Controls.Add(Me.btnColorado)
        Me.Controls.Add(Me.btnOhio)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOhio As Button
    Friend WithEvents btnColorado As Button
    Friend WithEvents btnUtah As Button
    Friend WithEvents btnCalifornia As Button
    Friend WithEvents btnArizona As Button
    Friend WithEvents btnNewMexico As Button
    Friend WithEvents Label1 As Label
End Class
