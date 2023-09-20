<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stockpf
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonActualiser = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "designation"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(186, 92)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(299, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'ButtonActualiser
        '
        Me.ButtonActualiser.Location = New System.Drawing.Point(612, 130)
        Me.ButtonActualiser.Name = "ButtonActualiser"
        Me.ButtonActualiser.Size = New System.Drawing.Size(137, 171)
        Me.ButtonActualiser.TabIndex = 2
        Me.ButtonActualiser.Text = "actualiser"
        Me.ButtonActualiser.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.designation, Me.qte})
        Me.DataGridView1.Location = New System.Drawing.Point(70, 186)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(435, 150)
        Me.DataGridView1.TabIndex = 3
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
        Me.qte.DataPropertyName = "qte"
        Me.qte.HeaderText = "qte"
        Me.qte.MinimumWidth = 8
        Me.qte.Name = "qte"
        Me.qte.Width = 150
        '
        'stockpf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonActualiser)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "stockpf"
        Me.Text = "stockpf"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ButtonActualiser As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents designation As DataGridViewTextBoxColumn
    Friend WithEvents qte As DataGridViewTextBoxColumn
End Class
