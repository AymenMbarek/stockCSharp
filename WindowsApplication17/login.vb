Imports System.Data
Imports MySql.Data.MySqlClient

Public Class login
    Private cnx As New MySqlConnection("server=localhost;database=gestion_stock;user id=root;password=")

    Private Sub Button1_ok_Click(sender As Object, e As EventArgs) Handles Button1_ok.Click
        Dim usernameValue As String = Me.username.Text.Trim()
        Dim passwordValue As String = Me.password.Text.Trim()

        If AuthenticateUser(usernameValue, passwordValue) Then
            ' L'utilisateur est authentifié, ouvrir le formulaire Menu
            Dim menuForm As New Menu() ' Remplacez "Menu" par le nom de la classe de votre formulaire de menu
            menuForm.Show()
            Me.Hide()  ' Cacher le formulaire de connexion
        Else
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Try
            cnx.Open()
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM `users` WHERE `username` = @username AND `password` = @password", cnx)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'authentification : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            cnx.Close()
        End Try
    End Function

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Au chargement du formulaire, on rend la fenêtre de connexion visible
        Me.Visible = True
    End Sub

    Private Sub username_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged
        ' Peux laisser vide ou ajouter des validations si nécessaire
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        ' Peux laisser vide ou ajouter des validations si nécessaire
    End Sub

    Private Sub Button_Quittez_Click(sender As Object, e As EventArgs) Handles Button_Quittez.Click
        Me.Close() ' Ferme la fenêtre actuelle
    End Sub
End Class
