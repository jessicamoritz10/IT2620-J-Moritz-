<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KayakBrowser
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
        Me.components = New System.ComponentModel.Container()
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstKayakTypes = New System.Windows.Forms.ListBox()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet = New Lab10_KayakBrowser.KayaksDataSet()
        Me.DescriptionLabel1 = New System.Windows.Forms.Label()
        Me.KayaksDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Lab10_KayakBrowser.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.TableAdapterManager = New Lab10_KayakBrowser.KayaksDataSetTableAdapters.TableAdapterManager()
        Me.KayakTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet1 = New Lab10_KayakBrowser.KayaksDataSet()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(333, 23)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 2
        DescriptionLabel.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a kayak type to view a description"
        '
        'lstKayakTypes
        '
        Me.lstKayakTypes.DataBindings.Add(New System.Windows.Forms.Binding("ValueMember", Me.KayakTypesBindingSource, "Name", True))
        Me.lstKayakTypes.DataBindings.Add(New System.Windows.Forms.Binding("DisplayMember", Me.KayakTypesBindingSource, "Name", True))
        Me.lstKayakTypes.DataSource = Me.KayakTypesBindingSource
        Me.lstKayakTypes.DisplayMember = "Name"
        Me.lstKayakTypes.FormattingEnabled = True
        Me.lstKayakTypes.Location = New System.Drawing.Point(15, 50)
        Me.lstKayakTypes.Name = "lstKayakTypes"
        Me.lstKayakTypes.Size = New System.Drawing.Size(256, 173)
        Me.lstKayakTypes.TabIndex = 1
        Me.lstKayakTypes.ValueMember = "Name"
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescriptionLabel1
        '
        Me.DescriptionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DescriptionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.DescriptionLabel1.Location = New System.Drawing.Point(336, 50)
        Me.DescriptionLabel1.MaximumSize = New System.Drawing.Size(256, 173)
        Me.DescriptionLabel1.MinimumSize = New System.Drawing.Size(156, 173)
        Me.DescriptionLabel1.Name = "DescriptionLabel1"
        Me.DescriptionLabel1.Size = New System.Drawing.Size(256, 173)
        Me.DescriptionLabel1.TabIndex = 3
        Me.DescriptionLabel1.Text = "Label2"
        '
        'KayaksDataSetBindingSource
        '
        Me.KayaksDataSetBindingSource.DataSource = Me.KayaksDataSet
        Me.KayaksDataSetBindingSource.Position = 0
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KayakTypesTableAdapter = Me.KayakTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Lab10_KayakBrowser.KayaksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KayakTypesBindingSource1
        '
        Me.KayakTypesBindingSource1.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource1.DataSource = Me.KayaksDataSetBindingSource
        '
        'KayakTypesBindingSource2
        '
        Me.KayakTypesBindingSource2.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource2.DataSource = Me.KayaksDataSetBindingSource
        '
        'KayaksDataSet1
        '
        Me.KayaksDataSet1.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 281)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionLabel1)
        Me.Controls.Add(Me.lstKayakTypes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KayakBrowser"
        Me.Text = "Kayak Browser"
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstKayakTypes As ListBox
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayaksDataSetBindingSource As BindingSource
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents TableAdapterManager As KayaksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescriptionLabel1 As Label
    Friend WithEvents KayakTypesBindingSource1 As BindingSource
    Friend WithEvents KayakTypesBindingSource2 As BindingSource
    Friend WithEvents KayaksDataSet1 As KayaksDataSet
End Class
