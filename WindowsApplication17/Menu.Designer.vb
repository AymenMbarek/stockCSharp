<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.button_article = New System.Windows.Forms.Button()
        Me.Button_vente = New System.Windows.Forms.Button()
        Me.Button_achat = New System.Windows.Forms.Button()
        Me.Button_client = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "menu"
        '
        'button_article
        '
        Me.button_article.Location = New System.Drawing.Point(158, 125)
        Me.button_article.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.button_article.Name = "button_article"
        Me.button_article.Size = New System.Drawing.Size(112, 35)
        Me.button_article.TabIndex = 0
        Me.button_article.Text = "article"
        Me.button_article.UseVisualStyleBackColor = True
        '
        'Button_vente
        '
        Me.Button_vente.Location = New System.Drawing.Point(158, 197)
        Me.Button_vente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_vente.Name = "Button_vente"
        Me.Button_vente.Size = New System.Drawing.Size(112, 35)
        Me.Button_vente.TabIndex = 1
        Me.Button_vente.Text = "vente"
        Me.Button_vente.UseVisualStyleBackColor = True
        '
        'Button_achat
        '
        Me.Button_achat.Location = New System.Drawing.Point(158, 268)
        Me.Button_achat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_achat.Name = "Button_achat"
        Me.Button_achat.Size = New System.Drawing.Size(112, 35)
        Me.Button_achat.TabIndex = 2
        Me.Button_achat.Text = "achat"
        Me.Button_achat.UseVisualStyleBackColor = True
        '
        'Button_client
        '
        Me.Button_client.Location = New System.Drawing.Point(158, 345)
        Me.Button_client.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_client.Name = "Button_client"
        Me.Button_client.Size = New System.Drawing.Size(112, 35)
        Me.Button_client.TabIndex = 3
        Me.Button_client.Text = "client"
        Me.Button_client.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(419, 156)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 55)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "stock mp"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(419, 237)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Produit Fini"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(419, 307)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 40)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "stock produit final"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(419, 364)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 40)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Transformation"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication17.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(632, 425)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_client)
        Me.Controls.Add(Me.Button_achat)
        Me.Controls.Add(Me.Button_vente)
        Me.Controls.Add(Me.button_article)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Menu"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents button_article As Button
    Friend WithEvents Button_vente As Button
    Friend WithEvents Button_achat As Button
    Friend WithEvents Button_client As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
