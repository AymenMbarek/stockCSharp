<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticleForm4
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
        Me.Button_ajouter = New System.Windows.Forms.Button()
        Me.Button_supp = New System.Windows.Forms.Button()
        Me.Button_modif = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Quitt = New System.Windows.Forms.Button()
        Me.TextBox_prix = New System.Windows.Forms.TextBox()
        Me.TextBox_designa = New System.Windows.Forms.TextBox()
        Me.TextBox_cod_art = New System.Windows.Forms.TextBox()
        Me.TextBox_vente = New System.Windows.Forms.TextBox()
        Me.prix_vente = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "code article"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "designation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 263)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "prix achat"
        '
        'Button_ajouter
        '
        Me.Button_ajouter.Location = New System.Drawing.Point(380, 75)
        Me.Button_ajouter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_ajouter.Name = "Button_ajouter"
        Me.Button_ajouter.Size = New System.Drawing.Size(112, 35)
        Me.Button_ajouter.TabIndex = 5
        Me.Button_ajouter.Text = "ajouter"
        Me.Button_ajouter.UseVisualStyleBackColor = True
        '
        'Button_supp
        '
        Me.Button_supp.Location = New System.Drawing.Point(380, 135)
        Me.Button_supp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_supp.Name = "Button_supp"
        Me.Button_supp.Size = New System.Drawing.Size(112, 35)
        Me.Button_supp.TabIndex = 4
        Me.Button_supp.Text = "supprimer"
        Me.Button_supp.UseVisualStyleBackColor = True
        '
        'Button_modif
        '
        Me.Button_modif.Location = New System.Drawing.Point(380, 198)
        Me.Button_modif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_modif.Name = "Button_modif"
        Me.Button_modif.Size = New System.Drawing.Size(112, 35)
        Me.Button_modif.TabIndex = 5
        Me.Button_modif.Text = "modifier"
        Me.Button_modif.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.code, Me.designation, Me.prix})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 343)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(516, 200)
        Me.DataGridView1.TabIndex = 7
        '
        'code
        '
        Me.code.HeaderText = "code"
        Me.code.MinimumWidth = 8
        Me.code.Name = "code"
        Me.code.Width = 150
        '
        'designation
        '
        Me.designation.HeaderText = "designation"
        Me.designation.MinimumWidth = 8
        Me.designation.Name = "designation"
        Me.designation.Width = 150
        '
        'prix
        '
        Me.prix.HeaderText = "prix"
        Me.prix.MinimumWidth = 8
        Me.prix.Name = "prix"
        Me.prix.Width = 150
        '
        'Button_Quitt
        '
        Me.Button_Quitt.Location = New System.Drawing.Point(584, 508)
        Me.Button_Quitt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Quitt.Name = "Button_Quitt"
        Me.Button_Quitt.Size = New System.Drawing.Size(112, 35)
        Me.Button_Quitt.TabIndex = 8
        Me.Button_Quitt.Text = "Quittez"
        Me.Button_Quitt.UseVisualStyleBackColor = True
        '
        'TextBox_prix
        '
        Me.TextBox_prix.Location = New System.Drawing.Point(160, 258)
        Me.TextBox_prix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_prix.Name = "TextBox_prix"
        Me.TextBox_prix.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_prix.TabIndex = 2
        '
        'TextBox_designa
        '
        Me.TextBox_designa.Location = New System.Drawing.Point(160, 168)
        Me.TextBox_designa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_designa.Name = "TextBox_designa"
        Me.TextBox_designa.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_designa.TabIndex = 1
        '
        'TextBox_cod_art
        '
        Me.TextBox_cod_art.Location = New System.Drawing.Point(160, 86)
        Me.TextBox_cod_art.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_cod_art.Name = "TextBox_cod_art"
        Me.TextBox_cod_art.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_cod_art.TabIndex = 0
        '
        'TextBox_vente
        '
        Me.TextBox_vente.Location = New System.Drawing.Point(160, 298)
        Me.TextBox_vente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox_vente.Name = "TextBox_vente"
        Me.TextBox_vente.Size = New System.Drawing.Size(148, 26)
        Me.TextBox_vente.TabIndex = 3
        '
        'prix_vente
        '
        Me.prix_vente.AutoSize = True
        Me.prix_vente.Location = New System.Drawing.Point(56, 309)
        Me.prix_vente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.prix_vente.Name = "prix_vente"
        Me.prix_vente.Size = New System.Drawing.Size(76, 20)
        Me.prix_vente.TabIndex = 10
        Me.prix_vente.Text = "prix vente"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 258)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ArticleForm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication17.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(740, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.prix_vente)
        Me.Controls.Add(Me.TextBox_vente)
        Me.Controls.Add(Me.Button_Quitt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_modif)
        Me.Controls.Add(Me.Button_supp)
        Me.Controls.Add(Me.Button_ajouter)
        Me.Controls.Add(Me.TextBox_prix)
        Me.Controls.Add(Me.TextBox_designa)
        Me.Controls.Add(Me.TextBox_cod_art)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ArticleForm4"
        Me.Text = "ArticleForm4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_ajouter As Button
    Friend WithEvents Button_supp As Button
    Friend WithEvents Button_modif As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Quitt As Button
    Friend WithEvents TextBox_prix As TextBox
    Friend WithEvents TextBox_designa As TextBox
    Friend WithEvents TextBox_cod_art As TextBox
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents designation As DataGridViewTextBoxColumn
    Friend WithEvents prix As DataGridViewTextBoxColumn
    Friend WithEvents TextBox_vente As TextBox
    Friend WithEvents prix_vente As Label
    Friend WithEvents Button1 As Button
End Class
