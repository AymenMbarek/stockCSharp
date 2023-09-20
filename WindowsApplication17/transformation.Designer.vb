<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonModifier
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.mp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtepf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "mp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "qte mp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "pf"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "qte pf"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "date vente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 26)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(212, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(189, 26)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(212, 151)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(189, 26)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(212, 209)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(189, 26)
        Me.TextBox4.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(212, 261)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 9
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Location = New System.Drawing.Point(555, 26)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(166, 40)
        Me.ButtonAjouter.TabIndex = 10
        Me.ButtonAjouter.Text = "ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(555, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 40)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonMenu
        '
        Me.ButtonMenu.Location = New System.Drawing.Point(555, 171)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(166, 40)
        Me.ButtonMenu.TabIndex = 12
        Me.ButtonMenu.Text = "menu"
        Me.ButtonMenu.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(555, 234)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(166, 40)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "quitter"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mp, Me.qtemp, Me.pf, Me.qtepf, Me.datee})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(762, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'mp
        '
        Me.mp.HeaderText = "mp"
        Me.mp.MinimumWidth = 8
        Me.mp.Name = "mp"
        Me.mp.Width = 150
        '
        'qtemp
        '
        Me.qtemp.HeaderText = "qtemp"
        Me.qtemp.MinimumWidth = 8
        Me.qtemp.Name = "qtemp"
        Me.qtemp.Width = 150
        '
        'pf
        '
        Me.pf.HeaderText = "pf"
        Me.pf.MinimumWidth = 8
        Me.pf.Name = "pf"
        Me.pf.Width = 150
        '
        'qtepf
        '
        Me.qtepf.HeaderText = "qtepf"
        Me.qtepf.MinimumWidth = 8
        Me.qtepf.Name = "qtepf"
        Me.qtepf.Width = 150
        '
        'datee
        '
        Me.datee.HeaderText = "datee"
        Me.datee.MinimumWidth = 8
        Me.datee.Name = "datee"
        Me.datee.Width = 150
        '
        'ButtonModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonAjouter)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ButtonModifier"
        Me.Text = "transformation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents mp As DataGridViewTextBoxColumn
    Friend WithEvents qtemp As DataGridViewTextBoxColumn
    Friend WithEvents pf As DataGridViewTextBoxColumn
    Friend WithEvents qtepf As DataGridViewTextBoxColumn
    Friend WithEvents datee As DataGridViewTextBoxColumn
End Class
