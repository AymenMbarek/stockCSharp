Imports System.Data
Imports MySql.Data.MySqlClient

Public Class client

    Public cnx As New MySqlConnection("server=localhost; database=gestion_stock;user id=root; passeword=;persist security info=true; convert zero DateTime=true")
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Public Sub vider_champ()
        TextBox_cin.Text = ""
        TextBox_nom.Text = ""
        TextBox_prenom.Text = ""
        TextBox_adress.Text = ""
        TextBox_telephone.Text = "" ' Ajout pour vider le champ de téléphone
    End Sub

    Public Sub remplir_dt()
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM client where cin_client!='00000000'"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        Dim dtrow(4) As String
        DataGridclient.Rows.Clear()
        While dr.Read
            dtrow(0) = dr(0)
            dtrow(1) = dr(1)
            dtrow(2) = dr(2)
            dtrow(3) = dr(3)
            dtrow(4) = dr(4) ' Ajoutez cette ligne pour le champ de téléphone
            DataGridclient.Rows.Add(dtrow)
        End While

        cnx.Close()
    End Sub

    Function verification_remplissage() As Boolean
        Dim bon As Boolean = True
        If TextBox_cin.Text = "" Then
            TextBox_cin.BackColor = Color.Red
            bon = False
            TextBox_cin.Focus()
        ElseIf Len(TextBox_cin.Text) < 8 Then
            MsgBox("le numéro de la carte d'identité doit etre composé de 8 chiffres")
        ElseIf TextBox_nom.Text = "" Then
            TextBox_nom.BackColor = Color.Red
            bon = False
            TextBox_nom.Focus()
        ElseIf TextBox_prenom.Text = "" Then
            TextBox_prenom.BackColor = Color.Red
            bon = False
            TextBox_prenom.Focus()
        ElseIf TextBox_adress.Text = "" Then
            TextBox_adress.BackColor = Color.Red
            bon = False
            TextBox_adress.Focus()
        End If
        verification_remplissage = bon
    End Function

    Function vérification_cle_primaire(requete As String)
        Dim bon2 As Boolean = False
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = requete
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.Read Then
            bon2 = True
        End If
        cnx.Close()
        vérification_cle_primaire = bon2
    End Function

    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplir_dt()
    End Sub

    Private Sub Button_ajouter_Click(sender As Object, e As EventArgs) Handles Button_ajouter.Click
        If verification_remplissage() Then
            If vérification_cle_primaire("Select `CIN_client` FROM `client` WHERE `CIN_client`='" & TextBox_cin.Text & "'") Then
                MsgBox("le client saisi existe déjà")
            Else
                cnx.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO `client`(`CIN_client`, `nom_client`, `prenom_client`, `adresse`, `telephone`) VALUES ('" & TextBox_cin.Text & "','" & TextBox_nom.Text & "','" & TextBox_prenom.Text & "','" & TextBox_adress.Text & "','" & TextBox_telephone.Text & "')"

                cmd.ExecuteNonQuery()
                MsgBox("client a été ajouté avec succès")
                vider_champ()
                cnx.Close()
                remplir_dt()
            End If
        End If
    End Sub

    Private Sub TextBox_cin_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cin.TextChanged
        TextBox_cin.BackColor = Color.White
    End Sub

    Private Sub TextBox_nom_TextChanged(sender As Object, e As EventArgs) Handles TextBox_nom.TextChanged
        TextBox_nom.BackColor = Color.White
    End Sub

    Private Sub TextBox_prenom_TextChanged(sender As Object, e As EventArgs) Handles TextBox_prenom.TextChanged
        TextBox_prenom.BackColor = Color.White
    End Sub

    Private Sub TextBox_adress_TextChanged(sender As Object, e As EventArgs) Handles TextBox_adress.TextChanged
        TextBox_adress.BackColor = Color.White
    End Sub

    Private Sub DataGridclient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridclient.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridclient.Rows(index)
        TextBox_cin.Text = selectedrow.Cells(0).Value.ToString
        TextBox_nom.Text = selectedrow.Cells(1).Value.ToString
        TextBox_prenom.Text = selectedrow.Cells(2).Value.ToString
        TextBox_adress.Text = selectedrow.Cells(3).Value.ToString
        TextBox_telephone.Text = selectedrow.Cells(4).Value.ToString() ' Ajoutez cette ligne pour le champ de téléphone
    End Sub

    Private Sub Button_supp_Click(sender As Object, e As EventArgs) Handles Button_supp.Click
        If verification_remplissage() Then
            Dim a = MsgBox("voulez vous vraiment supprimer le client", vbYesNo)
            If a = vbYes Then
                If vérification_cle_primaire("Select `CIN_client`FROM `client` WHERE `CIN_client`='" & TextBox_cin.Text & "'") Then
                    If vérification_cle_primaire("select *from vente where `CIN_client`='" & TextBox_cin.Text & "'") Then
                        cnx.Close()
                        cnx.Open()
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "UPDATE `vente` SET  `CIN_client`='00000000' WHERE  `CIN_client`='" & TextBox_cin.Text & "'"
                        cmd.Connection = cnx
                        cmd.ExecuteNonQuery()
                        cnx.Close()

                        cnx.Close()
                        cnx.Open()
                        cmd.CommandType = CommandType.Text
                        cmd.CommandText = "DELETE FROM `client` WHERE  `CIN_client`='" & TextBox_cin.Text & "'"
                        cmd.Connection = cnx
                        cmd.ExecuteNonQuery()
                        cnx.Close()
                        remplir_dt()
                        MsgBox(" client supprimé avec succès ")
                    End If
                Else MsgBox("le client n'existe pas veuillez vérifier votre saisie")
                End If
            End If
        End If
    End Sub

    Private Sub TextBox_cin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_cin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Exit Sub
        ElseIf Asc(e.KeyChar) = 8 Then
            Exit Sub
        ElseIf Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) < 48 Then
            MsgBox("donner seulement des numeros")
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuForm As New Menu() ' Remplacez "Menu" par le nom de la classe de votre formulaire de menu
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close() ' Ferme la fenêtre actuelle
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        remplir_dt() ' Appelle la fonction pour recharger les données
    End Sub

End Class
