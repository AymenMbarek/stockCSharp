

Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ArticleForm4
    Public cnx As New MySqlConnection("server=localhost;database=gestion_stock;user id=root;passeword=")
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public Function verification_remplir()
        Dim bon As Boolean = True
        If TextBox_cod_art.Text = "" Then
            TextBox_cod_art.BackColor = Color.Red
            bon = False
            TextBox_cod_art.Focus()
        ElseIf TextBox_designa.Text = "" Then
            TextBox_designa.BackColor = Color.Red
            bon = False
            TextBox_designa.Focus()
        ElseIf TextBox_prix.Text = "" Then
            TextBox_prix.BackColor = Color.Red
            bon = False
            TextBox_prix.Focus()
        ElseIf TextBox_vente.Text = "" Then
            TextBox_prix.BackColor = Color.Red
            bon = False
            TextBox_vente.Focus()
        End If
        verification_remplir = bon
    End Function
    Function verification_cle_primaire(requete As String) As Boolean
        Dim bon2 As Boolean = True
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = requete
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.Read Then
            bon2 = False
        End If
        cnx.Close()
        verification_cle_primaire = bon2
    End Function
    Sub remplir_dt()
        cnx.Open()
        cmd.CommandText = "SELECT * FROM `article`"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        Dim dtrow(4) As String
        DataGridView1.Rows.Clear()
        While dr.Read
            dtrow(0) = dr(0)
            dtrow(1) = dr(1)
            dtrow(2) = dr(2)
            dtrow(3) = dr(3)
            DataGridView1.Rows.Add(dtrow)
        End While
    End Sub
    Sub vider_champ()
        TextBox_cod_art.Text = ""
        TextBox_designa.Text = ""
        TextBox_prix.Text = ""
        TextBox_vente.Text = ""

    End Sub
    Private Sub ArticleForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        remplir_dt()
    End Sub

    Private Sub TextBox_cod_art_TextChanged(sender As Object, e As EventArgs) Handles TextBox_cod_art.TextChanged
        TextBox_cod_art.BackColor = Color.White
    End Sub

    Private Sub TextBox_designa_TextChanged(sender As Object, e As EventArgs) Handles TextBox_designa.TextChanged
        TextBox_designa.BackColor = Color.White
    End Sub

    Private Sub TextBox_prix_TextChanged(sender As Object, e As EventArgs) Handles TextBox_prix.TextChanged
        TextBox_designa.BackColor = Color.White
    End Sub

    Private Sub Button_ajouter_Click(sender As Object, e As EventArgs) Handles Button_ajouter.Click
        If verification_remplir() Then ' tous les champs sont remplis
            If verification_cle_primaire("Select * FROM `article` WHERE `code_article`='" & TextBox_cod_art.Text & "'") = False Then

                MsgBox("l'article existe déjà")
            Else
                cnx.Open()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "INSERT INTO `article`(`code_article`, `destingation_article`, `prix_achat`,prix_vente) VALUES ('" & TextBox_cod_art.Text & "','" & TextBox_designa.Text & "','" & TextBox_prix.Text & "','" & TextBox_vente.Text & "')"
                cmd.Connection = cnx
                cmd.ExecuteNonQuery()
                cnx.Close()
                MsgBox("le article a été ajouter avec succèes")

                remplir_dt()

                vider_champ()
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox_vente_TextChanged(sender As Object, e As EventArgs) Handles TextBox_vente.TextChanged
        TextBox_vente.BackColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuForm As New Menu() ' Remplacez "Menu" par le nom de la classe de votre formulaire de menu
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub Button_Quitt_Click(sender As Object, e As EventArgs) Handles Button_Quitt.Click
        Me.Close() ' Ferme la fenêtre actuelle
    End Sub
End Class