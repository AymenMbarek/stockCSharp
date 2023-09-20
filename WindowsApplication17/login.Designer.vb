<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Button1_ok = New System.Windows.Forms.Button()
        Me.Button_Quittez = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 180)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "password"
        '
        'username
        '
        Me.username.AccessibleName = "txt_username"
        Me.username.Location = New System.Drawing.Point(267, 80)
        Me.username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.username.Name = "username"
        Me.username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.username.Size = New System.Drawing.Size(148, 26)
        Me.username.TabIndex = 0
        '
        'password
        '
        Me.password.AccessibleName = "txt_password"
        Me.password.Location = New System.Drawing.Point(267, 180)
        Me.password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(148, 26)
        Me.password.TabIndex = 1
        '
        'Button1_ok
        '
        Me.Button1_ok.Location = New System.Drawing.Point(118, 302)
        Me.Button1_ok.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1_ok.Name = "Button1_ok"
        Me.Button1_ok.Size = New System.Drawing.Size(112, 35)
        Me.Button1_ok.TabIndex = 2
        Me.Button1_ok.Text = "connexion"
        Me.Button1_ok.UseVisualStyleBackColor = True
        '
        'Button_Quittez
        '
        Me.Button_Quittez.Location = New System.Drawing.Point(267, 302)
        Me.Button_Quittez.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button_Quittez.Name = "Button_Quittez"
        Me.Button_Quittez.Size = New System.Drawing.Size(112, 35)
        Me.Button_Quittez.TabIndex = 3
        Me.Button_Quittez.Text = "quitter"
        Me.Button_Quittez.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication17.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(530, 389)
        Me.Controls.Add(Me.Button_Quittez)
        Me.Controls.Add(Me.Button1_ok)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Button1_ok As Button
    Friend WithEvents Button_Quittez As Button
End Class
