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
        Me.picFive = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFive
        '
        Me.picFive.Image = Global.Lab02_ClickableNumbers.My.Resources.Resources.Five
        Me.picFive.Location = New System.Drawing.Point(400, 152)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(80, 144)
        Me.picFive.TabIndex = 4
        Me.picFive.TabStop = False
        '
        'picFour
        '
        Me.picFour.Image = Global.Lab02_ClickableNumbers.My.Resources.Resources.Four
        Me.picFour.Location = New System.Drawing.Point(305, 152)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(80, 144)
        Me.picFour.TabIndex = 3
        Me.picFour.TabStop = False
        '
        'picThree
        '
        Me.picThree.Image = Global.Lab02_ClickableNumbers.My.Resources.Resources.Three
        Me.picThree.Location = New System.Drawing.Point(207, 152)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(80, 144)
        Me.picThree.TabIndex = 2
        Me.picThree.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Image = Global.Lab02_ClickableNumbers.My.Resources.Resources.Two
        Me.picTwo.Location = New System.Drawing.Point(110, 152)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(80, 144)
        Me.picTwo.TabIndex = 1
        Me.picTwo.TabStop = False
        '
        'picOne
        '
        Me.picOne.Image = Global.Lab02_ClickableNumbers.My.Resources.Resources.One
        Me.picOne.Location = New System.Drawing.Point(12, 152)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(80, 144)
        Me.picOne.TabIndex = 0
        Me.picOne.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(175, 45)
        Me.lblMessage.MaximumSize = New System.Drawing.Size(200, 200)
        Me.lblMessage.MinimumSize = New System.Drawing.Size(150, 85)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(150, 85)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(491, 314)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Name = "Form1"
        Me.Text = "Clickable Numbers"
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picOne As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picThree As PictureBox
    Friend WithEvents picFour As PictureBox
    Friend WithEvents picFive As PictureBox
    Friend WithEvents lblMessage As Label
End Class
