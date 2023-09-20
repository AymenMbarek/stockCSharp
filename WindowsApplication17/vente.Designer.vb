<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vente
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_quantite = New System.Windows.Forms.TextBox()
        Me.TextBox_remise = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox_design = New System.Windows.Forms.ComboBox()
        Me.ComboBox_client = New System.Windows.Forms.ComboBox()
        Me.Button_modif = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.bouton_ajouter = New System.Windows.Forms.Button()
        Me.total_commande = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "designation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "quantite"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 182)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 662)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "remise"
        '
        'TextBox_quantite
        '
        Me.TextBox_quantite.Location = New System.Drawing.Point(213, 117)
        Me.TextBox_quantite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_quantite.Name = "TextBox_quantite"
        Me.TextBox_quantite.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_quantite.TabIndex = 1
        '
        'TextBox_remise
        '
        Me.TextBox_remise.Location = New System.Drawing.Point(160, 657)
        Me.TextBox_remise.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_remise.Name = "TextBox_remise"
        Me.TextBox_remise.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_remise.TabIndex = 3
        Me.TextBox_remise.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.designation, Me.client, Me.quantite, Me.prix})
        Me.DataGridView1.Location = New System.Drawing.Point(74, 334)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(842, 231)
        Me.DataGridView1.TabIndex = 8
        '
        'ComboBox_design
        '
        Me.ComboBox_design.BackColor = System.Drawing.SystemColors.Info
        Me.ComboBox_design.FormattingEnabled = True
        Me.ComboBox_design.Location = New System.Drawing.Point(213, 58)
        Me.ComboBox_design.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox_design.Name = "ComboBox_design"
        Me.ComboBox_design.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox_design.TabIndex = 0
        '
        'ComboBox_client
        '
        Me.ComboBox_client.FormattingEnabled = True
        Me.ComboBox_client.Items.AddRange(New Object() {"ahmed"})
        Me.ComboBox_client.Location = New System.Drawing.Point(213, 177)
        Me.ComboBox_client.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox_client.Name = "ComboBox_client"
        Me.ComboBox_client.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox_client.TabIndex = 2
        '
        'Button_modif
        '
        Me.Button_modif.Location = New System.Drawing.Point(610, 174)
        Me.Button_modif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_modif.Name = "Button_modif"
        Me.Button_modif.Size = New System.Drawing.Size(112, 35)
        Me.Button_modif.TabIndex = 6
        Me.Button_modif.Text = "modifier"
        Me.Button_modif.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 242)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "date_vente"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(213, 242)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(298, 26)
        Me.DateTimePicker1.TabIndex = 13
        '
        'bouton_ajouter
        '
        Me.bouton_ajouter.Location = New System.Drawing.Point(610, 58)
        Me.bouton_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.bouton_ajouter.Name = "bouton_ajouter"
        Me.bouton_ajouter.Size = New System.Drawing.Size(112, 35)
        Me.bouton_ajouter.TabIndex = 14
        Me.bouton_ajouter.Text = "ajouter"
        Me.bouton_ajouter.UseVisualStyleBackColor = True
        '
        'total_commande
        '
        Me.total_commande.Location = New System.Drawing.Point(610, 649)
        Me.total_commande.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.total_commande.Name = "total_commande"
        Me.total_commande.Size = New System.Drawing.Size(148, 26)
        Me.total_commande.TabIndex = 15
        Me.total_commande.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(610, 113)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(546, 652)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 20)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "prix"
        '
        'designation
        '
        Me.designation.HeaderText = "designation"
        Me.designation.MinimumWidth = 8
        Me.designation.Name = "designation"
        Me.designation.Width = 150
        '
        'client
        '
        Me.client.HeaderText = "client"
        Me.client.MinimumWidth = 8
        Me.client.Name = "client"
        Me.client.Width = 150
        '
        'quantite
        '
        Me.quantite.HeaderText = "quantite"
        Me.quantite.MinimumWidth = 8
        Me.quantite.Name = "quantite"
        Me.quantite.Width = 150
        '
        'prix
        '
        Me.prix.HeaderText = "prix"
        Me.prix.MinimumWidth = 8
        Me.prix.Name = "prix"
        Me.prix.Width = 150
        '
        'vente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication17.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(993, 760)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total_commande)
        Me.Controls.Add(Me.bouton_ajouter)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button_modif)
        Me.Controls.Add(Me.ComboBox_client)
        Me.Controls.Add(Me.ComboBox_design)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox_remise)
        Me.Controls.Add(Me.TextBox_quantite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "vente"
        Me.Text = "vente pf"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_quantite As TextBox
    Friend WithEvents TextBox_remise As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox_design As ComboBox
    Friend WithEvents ComboBox_client As ComboBox
    Friend WithEvents Button_modif As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents bouton_ajouter As Button
    Friend WithEvents total_commande As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents designation As DataGridViewTextBoxColumn
    Friend WithEvents client As DataGridViewTextBoxColumn
    Friend WithEvents quantite As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
End Class
