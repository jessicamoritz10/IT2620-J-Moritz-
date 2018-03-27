<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.chkConference = New System.Windows.Forms.CheckBox()
        Me.chkOpening = New System.Windows.Forms.CheckBox()
        Me.lstSelect = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkConference
        '
        Me.chkConference.AutoSize = True
        Me.chkConference.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkConference.Location = New System.Drawing.Point(65, 87)
        Me.chkConference.Name = "chkConference"
        Me.chkConference.Size = New System.Drawing.Size(233, 19)
        Me.chkConference.TabIndex = 0
        Me.chkConference.Text = "Conference Registration                       $895"
        Me.chkConference.UseVisualStyleBackColor = True
        '
        'chkOpening
        '
        Me.chkOpening.AutoSize = True
        Me.chkOpening.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOpening.Location = New System.Drawing.Point(65, 142)
        Me.chkOpening.Name = "chkOpening"
        Me.chkOpening.Size = New System.Drawing.Size(236, 19)
        Me.chkOpening.TabIndex = 1
        Me.chkOpening.Text = "Opening Night Dinner and Keynote       $30"
        Me.chkOpening.UseVisualStyleBackColor = True
        '
        'lstSelect
        '
        Me.lstSelect.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelect.FormattingEnabled = True
        Me.lstSelect.ItemHeight = 16
        Me.lstSelect.Items.AddRange(New Object() {"Intro to E-Commerce                               $295", "The Future of the Web                              $295", "Advanced Visial Basic                            $395", "Network Security                                   $395"})
        Me.lstSelect.Location = New System.Drawing.Point(351, 103)
        Me.lstSelect.Name = "lstSelect"
        Me.lstSelect.Size = New System.Drawing.Size(234, 68)
        Me.lstSelect.TabIndex = 2
        Me.lstSelect.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 46)
        Me.Label1.MinimumSize = New System.Drawing.Size(260, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 140)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Conference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(337, 46)
        Me.Label2.MinimumSize = New System.Drawing.Size(260, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 140)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Preconference Workshop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Select One:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(372, 213)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 40)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(490, 213)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 271)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lstSelect)
        Me.Controls.Add(Me.chkOpening)
        Me.Controls.Add(Me.chkConference)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmOptions"
        Me.Text = "Conference Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkConference As CheckBox
    Friend WithEvents chkOpening As CheckBox
    Friend WithEvents lstSelect As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
End Class
