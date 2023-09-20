<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonActualiser = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonActualiser
        '
        Me.ButtonActualiser.Location = New System.Drawing.Point(628, 132)
        Me.ButtonActualiser.Name = "ButtonActualiser"
        Me.ButtonActualiser.Size = New System.Drawing.Size(117, 113)
        Me.ButtonActualiser.TabIndex = 0
        Me.ButtonActualiser.Text = "actualiser"
        Me.ButtonActualiser.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.designation, Me.qte})
        Me.DataGridView1.Location = New System.Drawing.Point(131, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(476, 281)
        Me.DataGridView1.TabIndex = 1
        '
        'designation
        '
        Me.designation.DataPropertyName = "destingation"
        Me.designation.HeaderText = "designation"
        Me.designation.MinimumWidth = 8
        Me.designation.Name = "designation"
        Me.designation.Width = 150
        '
        'qte
        '
        Me.qte.DataPropertyName = "quantite_stock"
        Me.qte.HeaderText = "qte"
        Me.qte.MinimumWidth = 8
        Me.qte.Name = "qte"
        Me.qte.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonActualiser)
        Me.Name = "Form1"
        Me.Text = "gestion stock mp"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonActualiser As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents designation As DataGridViewTextBoxColumn
    Friend WithEvents qte As DataGridViewTextBoxColumn
End Class
