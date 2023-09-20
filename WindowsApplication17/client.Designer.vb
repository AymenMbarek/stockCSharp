<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.TextBox_cin = New System.Windows.Forms.TextBox()
        Me.TextBox_nom = New System.Windows.Forms.TextBox()
        Me.TextBox_prenom = New System.Windows.Forms.TextBox()
        Me.TextBox_adress = New System.Windows.Forms.TextBox()
        Me.Cin2 = New System.Windows.Forms.Label()
        Me.nom2 = New System.Windows.Forms.Label()
        Me.prenom2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridclient = New System.Windows.Forms.DataGridView()
        Me._cin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telephone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_modif = New System.Windows.Forms.Button()
        Me.Button_supp = New System.Windows.Forms.Button()
        Me.Button_ajouter = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_telephone = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_cin
        '
        Me.TextBox_cin.Location = New System.Drawing.Point(213, 51)
        Me.TextBox_cin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_cin.MaxLength = 8
        Me.TextBox_cin.Name = "TextBox_cin"
        Me.TextBox_cin.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_cin.TabIndex = 0
        '
        'TextBox_nom
        '
        Me.TextBox_nom.Location = New System.Drawing.Point(213, 117)
        Me.TextBox_nom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_nom.Name = "TextBox_nom"
        Me.TextBox_nom.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_nom.TabIndex = 1
        '
        'TextBox_prenom
        '
        Me.TextBox_prenom.Location = New System.Drawing.Point(213, 185)
        Me.TextBox_prenom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_prenom.Name = "TextBox_prenom"
        Me.TextBox_prenom.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_prenom.TabIndex = 2
        '
        'TextBox_adress
        '
        Me.TextBox_adress.Location = New System.Drawing.Point(213, 251)
        Me.TextBox_adress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_adress.Name = "TextBox_adress"
        Me.TextBox_adress.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_adress.TabIndex = 3
        '
        'Cin2
        '
        Me.Cin2.AutoSize = True
        Me.Cin2.Location = New System.Drawing.Point(38, 55)
        Me.Cin2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Cin2.Name = "Cin2"
        Me.Cin2.Size = New System.Drawing.Size(36, 20)
        Me.Cin2.TabIndex = 4
        Me.Cin2.Text = "CIN"
        '
        'nom2
        '
        Me.nom2.AutoSize = True
        Me.nom2.Location = New System.Drawing.Point(38, 122)
        Me.nom2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nom2.Name = "nom2"
        Me.nom2.Size = New System.Drawing.Size(42, 20)
        Me.nom2.TabIndex = 5
        Me.nom2.Text = "Nom"
        '
        'prenom2
        '
        Me.prenom2.AutoSize = True
        Me.prenom2.Location = New System.Drawing.Point(38, 191)
        Me.prenom2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.prenom2.Name = "prenom2"
        Me.prenom2.Size = New System.Drawing.Size(64, 20)
        Me.prenom2.TabIndex = 6
        Me.prenom2.Text = "Prenom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 255)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Adresse"
        '
        'DataGridclient
        '
        Me.DataGridclient.AllowUserToOrderColumns = True
        Me.DataGridclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridclient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me._cin, Me._nom, Me._prenom, Me.adresse, Me.Telephone})
        Me.DataGridclient.Location = New System.Drawing.Point(7, 329)
        Me.DataGridclient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridclient.Name = "DataGridclient"
        Me.DataGridclient.RowHeadersWidth = 62
        Me.DataGridclient.Size = New System.Drawing.Size(718, 168)
        Me.DataGridclient.TabIndex = 9
        '
        '_cin
        '
        Me._cin.HeaderText = "cin"
        Me._cin.MinimumWidth = 8
        Me._cin.Name = "_cin"
        Me._cin.Width = 150
        '
        '_nom
        '
        Me._nom.HeaderText = "nom"
        Me._nom.MinimumWidth = 8
        Me._nom.Name = "_nom"
        Me._nom.Width = 150
        '
        '_prenom
        '
        Me._prenom.HeaderText = "prenom"
        Me._prenom.MinimumWidth = 8
        Me._prenom.Name = "_prenom"
        Me._prenom.Width = 150
        '
        'adresse
        '
        Me.adresse.HeaderText = "adresse"
        Me.adresse.MinimumWidth = 8
        Me.adresse.Name = "adresse"
        Me.adresse.Width = 150
        '
        'Telephone
        '
        Me.Telephone.HeaderText = "Telephone"
        Me.Telephone.MinimumWidth = 8
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Width = 150
        '
        'Button_modif
        '
        Me.Button_modif.Location = New System.Drawing.Point(477, 165)
        Me.Button_modif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_modif.Name = "Button_modif"
        Me.Button_modif.Size = New System.Drawing.Size(112, 35)
        Me.Button_modif.TabIndex = 7
        Me.Button_modif.Text = "modifier"
        Me.Button_modif.UseVisualStyleBackColor = True
        '
        'Button_supp
        '
        Me.Button_supp.Location = New System.Drawing.Point(477, 106)
        Me.Button_supp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_supp.Name = "Button_supp"
        Me.Button_supp.Size = New System.Drawing.Size(112, 35)
        Me.Button_supp.TabIndex = 6
        Me.Button_supp.Text = "supprimer"
        Me.Button_supp.UseVisualStyleBackColor = True
        '
        'Button_ajouter
        '
        Me.Button_ajouter.Location = New System.Drawing.Point(477, 48)
        Me.Button_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_ajouter.Name = "Button_ajouter"
        Me.Button_ajouter.Size = New System.Drawing.Size(112, 35)
        Me.Button_ajouter.TabIndex = 5
        Me.Button_ajouter.Text = "ajouter"
        Me.Button_ajouter.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 252)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 289)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Telephone"
        '
        'TextBox_telephone
        '
        Me.TextBox_telephone.Location = New System.Drawing.Point(213, 289)
        Me.TextBox_telephone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_telephone.Name = "TextBox_telephone"
        Me.TextBox_telephone.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_telephone.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 210)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "actualiser"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(477, 289)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "quitter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication17.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(738, 511)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox_telephone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_modif)
        Me.Controls.Add(Me.Button_supp)
        Me.Controls.Add(Me.Button_ajouter)
        Me.Controls.Add(Me.DataGridclient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.prenom2)
        Me.Controls.Add(Me.nom2)
        Me.Controls.Add(Me.Cin2)
        Me.Controls.Add(Me.TextBox_adress)
        Me.Controls.Add(Me.TextBox_prenom)
        Me.Controls.Add(Me.TextBox_nom)
        Me.Controls.Add(Me.TextBox_cin)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "client"
        Me.Text = "client"
        CType(Me.DataGridclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_cin As TextBox
    Friend WithEvents TextBox_nom As TextBox
    Friend WithEvents TextBox_prenom As TextBox
    Friend WithEvents TextBox_adress As TextBox
    Friend WithEvents Cin2 As Label
    Friend WithEvents nom2 As Label
    Friend WithEvents prenom2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridclient As DataGridView
    Friend WithEvents Button_modif As Button
    Friend WithEvents Button_supp As Button
    Friend WithEvents Button_ajouter As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_telephone As TextBox
    Friend WithEvents _cin As DataGridViewTextBoxColumn
    Friend WithEvents _nom As DataGridViewTextBoxColumn
    Friend WithEvents _prenom As DataGridViewTextBoxColumn
    Friend WithEvents adresse As DataGridViewTextBoxColumn
    Friend WithEvents Telephone As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
