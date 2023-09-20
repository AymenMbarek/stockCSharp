<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class achat
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
        Me.ComboBox_desig = New System.Windows.Forms.ComboBox()
        Me.TextBox_quantite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_modif = New System.Windows.Forms.Button()
        Me.Button_supp = New System.Windows.Forms.Button()
        Me.Button_ajouter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.destingation_article = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designation2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_desig
        '
        Me.ComboBox_desig.FormattingEnabled = True
        Me.ComboBox_desig.Location = New System.Drawing.Point(242, 48)
        Me.ComboBox_desig.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox_desig.Name = "ComboBox_desig"
        Me.ComboBox_desig.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox_desig.TabIndex = 0
        '
        'TextBox_quantite
        '
        Me.TextBox_quantite.Location = New System.Drawing.Point(242, 117)
        Me.TextBox_quantite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_quantite.Name = "TextBox_quantite"
        Me.TextBox_quantite.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_quantite.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "designation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "quantite"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "date"
        '
        'Button_modif
        '
        Me.Button_modif.Location = New System.Drawing.Point(500, 168)
        Me.Button_modif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_modif.Name = "Button_modif"
        Me.Button_modif.Size = New System.Drawing.Size(112, 35)
        Me.Button_modif.TabIndex = 5
        Me.Button_modif.Text = "modifier"
        Me.Button_modif.UseVisualStyleBackColor = True
        '
        'Button_supp
        '
        Me.Button_supp.Location = New System.Drawing.Point(500, 105)
        Me.Button_supp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_supp.Name = "Button_supp"
        Me.Button_supp.Size = New System.Drawing.Size(112, 35)
        Me.Button_supp.TabIndex = 4
        Me.Button_supp.Text = "supprimer"
        Me.Button_supp.UseVisualStyleBackColor = True
        '
        'Button_ajouter
        '
        Me.Button_ajouter.Location = New System.Drawing.Point(500, 52)
        Me.Button_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_ajouter.Name = "Button_ajouter"
        Me.Button_ajouter.Size = New System.Drawing.Size(112, 35)
        Me.Button_ajouter.TabIndex = 3
        Me.Button_ajouter.Text = "ajouter"
        Me.Button_ajouter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.destingation_article, Me.quantite, Me.datee, Me.designation2})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 269)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(772, 378)
        Me.DataGridView1.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(183, 195)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = "Menu"
        Me.Button1.AccessibleName = "Menu"
        Me.Button1.Location = New System.Drawing.Point(500, 225)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'destingation_article
        '
        Me.destingation_article.DataPropertyName = "ComboBox_desig"
        Me.destingation_article.HeaderText = "designation"
        Me.destingation_article.MinimumWidth = 8
        Me.destingation_article.Name = "destingation_article"
        Me.destingation_article.Width = 150
        '
        'quantite
        '
        Me.quantite.HeaderText = "quantite"
        Me.quantite.MinimumWidth = 8
        Me.quantite.Name = "quantite"
        Me.quantite.Width = 150
        '
        'datee
        '
        Me.datee.HeaderText = "date"
        Me.datee.MinimumWidth = 8
        Me.datee.Name = "datee"
        Me.datee.Width = 150
        '
        'designation2
        '
        Me.designation2.HeaderText = "designation2"
        Me.designation2.MinimumWidth = 8
        Me.designation2.Name = "designation2"
        Me.designation2.Width = 150
        '
        'achat
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.WindowsApplication17.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1011, 685)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_modif)
        Me.Controls.Add(Me.Button_supp)
        Me.Controls.Add(Me.Button_ajouter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_quantite)
        Me.Controls.Add(Me.ComboBox_desig)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "achat"
        Me.Text = "achat mp"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox_desig As ComboBox
    Friend WithEvents TextBox_quantite As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_modif As Button
    Friend WithEvents Button_supp As Button
    Friend WithEvents Button_ajouter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents destingation_article As DataGridViewTextBoxColumn
    Friend WithEvents quantite As DataGridViewTextBoxColumn
    Friend WithEvents datee As DataGridViewTextBoxColumn
    Friend WithEvents designation2 As DataGridViewTextBoxColumn
End Class
