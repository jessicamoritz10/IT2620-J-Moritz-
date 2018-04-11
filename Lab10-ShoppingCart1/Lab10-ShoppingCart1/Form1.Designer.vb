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
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblShipping = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.Location = New System.Drawing.Point(27, 68)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(240, 147)
        Me.lstCart.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.MinimumSize = New System.Drawing.Size(440, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 260)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Products Selected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subtotal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Shipping:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(342, 61)
        Me.lblSubtotal.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(80, 20)
        Me.lblSubtotal.TabIndex = 6
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(342, 102)
        Me.lblTax.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(80, 20)
        Me.lblTax.TabIndex = 7
        '
        'lblShipping
        '
        Me.lblShipping.AutoSize = True
        Me.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShipping.Location = New System.Drawing.Point(342, 148)
        Me.lblShipping.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblShipping.Name = "lblShipping"
        Me.lblShipping.Size = New System.Drawing.Size(80, 20)
        Me.lblShipping.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(342, 195)
        Me.lblTotal.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 20)
        Me.lblTotal.TabIndex = 9
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(106, 237)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(90, 30)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(465, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBooksToolStripMenuItem, Me.AudioBooksToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'PrintBooksToolStripMenuItem
        '
        Me.PrintBooksToolStripMenuItem.Name = "PrintBooksToolStripMenuItem"
        Me.PrintBooksToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintBooksToolStripMenuItem.Text = "Print Books"
        '
        'AudioBooksToolStripMenuItem
        '
        Me.AudioBooksToolStripMenuItem.Name = "AudioBooksToolStripMenuItem"
        Me.AudioBooksToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AudioBooksToolStripMenuItem.Text = "Audio Books"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 312)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblShipping)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Shopping Cart"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCart As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblShipping As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AudioBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
