Imports System.Data
Imports MySql.Data.MySqlClient

Public Class achat
    Public cnx As New MySqlConnection("server=localhost; database=gestion_stock;user id=root; passeword=;persist security info=true; convert zero DateTime=true")
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Dim code_art As String
    Public Sub remplir_dt()
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT achat.code_achat, article.destingation_article, achat.date_achat, achat.quantite FROM `achat`, article WHERE article.code_article = achat.code_article"

        cmd.Connection = cnx
        dr = cmd.ExecuteReader

        DataGridView1.Rows.Clear()

        While dr.Read
            Dim dtrow(4) As String
            dtrow(0) = dr(0)
            dtrow(1) = dr(1)
            dtrow(2) = dr(2)
            dtrow(3) = dr(3)

            DataGridView1.Rows.Add(dtrow)
        End While

        cnx.Close()
    End Sub

    Public Sub vider_champ()

        TextBox_quantite.Text = ""
        ComboBox_desig.Text = ""
        DateTimePicker1.Text = ""

    End Sub


    Function verification_remplissage() As Boolean
        Dim bon As Boolean = True
        If TextBox_quantite.Text = "" Then
            TextBox_quantite.BackColor = Color.Red
            bon = False
            TextBox_quantite.Focus()

            bon = False


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
    Private Sub achat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT destingation_article FROM `article`"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader

        While dr.Read
            ComboBox_desig.Items.Add(dr(0))
        End While

        cnx.Close()
        remplir_dt()
    End Sub

    Private Sub TextBox_quantite_TextChanged(sender As Object, e As EventArgs) Handles TextBox_quantite.TextChanged
        TextBox_quantite.BackColor = Color.White
    End Sub

    Private Sub TextBox_date_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_ajouter_Click(sender As Object, e As EventArgs) Handles Button_ajouter.Click
        Dim qte_s As Integer
        If Not Integer.TryParse(TextBox_quantite.Text, qte_s) OrElse qte_s <= 0 Then
            MessageBox.Show("le quantité ne doit pas etre modifier.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox_quantite.BackColor = Color.Red
            TextBox_quantite.Focus()
            Return
        End If
        If verification_remplissage() Then
            cnx.Close()
            cnx.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO `achat`( `code_article`, `date_achat`, `quantite`) VALUES ('" & code_art & " ','" & DateTimePicker1.Value.ToString("yyyy-M-d") & "','" & TextBox_quantite.Text & " ')"
            cmd.ExecuteReader()
            cnx.Close()

            cnx.Open()
            cmd.CommandText = "SELECT `quantite_stock` FROM `stock` WHERE code_article ='" & code_art & "'"
            dr = cmd.ExecuteReader



            If dr.Read Then ' le produit existe en stcok 

                qte_s = dr(0)
                cnx.Close()
                cnx.Open()
                cmd.CommandText = "Update `stock` Set `quantite_stock`=" & (qte_s + CInt(TextBox_quantite.Text)) & " WHERE `code_article`='" & code_art & "'"
                cmd.ExecuteReader()

                cnx.Close()

            Else
                cnx.Close()
                cnx.Open()
                cmd.CommandText = "inSERT INTO `stock`(`code_article`, `quantite_stock`) VALUES ('" & code_art & " ','" & TextBox_quantite.Text & "')"

                cmd.ExecuteNonQuery()
                cnx.Close()
            End If


            MsgBox("l'achat de votre produit est effectue avec succes")
            vider_champ()
            cnx.Close()
            remplir_dt()

        End If


    End Sub

    Private Sub ComboBox_desig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_desig.SelectedIndexChanged
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT `code_article` FROM `article` WHERE destingation_article='" & ComboBox_desig.Text & "'"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            code_art = dr(0)
        End While
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button_supp_Click(sender As Object, e As EventArgs) Handles Button_supp.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuForm As New Menu() ' Remplacez "Menu" par le nom de la classe de votre formulaire de menu
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button_modif_Click(sender As Object, e As EventArgs) Handles Button_modif.Click
        Dim qte_s As Integer
        If Not Integer.TryParse(TextBox_quantite.Text, qte_s) OrElse qte_s <= 0 Then
            MessageBox.Show("modification effectué avec succes.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox_quantite.BackColor = Color.Red
            TextBox_quantite.Focus()
            Return
        End If

        If verification_remplissage() Then
            ' Autres parties de votre code pour ajouter l'achat et mettre à jour le stock

            If dr.Read Then ' Le produit existe en stock
                qte_s = dr(0)
                cnx.Close()
                cnx.Open()
                cmd.CommandText = "UPDATE `stock` SET `quantite_stock`=" & (qte_s + CInt(TextBox_quantite.Text)) & " WHERE `code_article`='" & code_art & "'"
                cmd.ExecuteNonQuery()
                cnx.Close()

                MsgBox("L'achat de votre produit est effectué avec succès et le stock a été mis à jour.")
                vider_champ()
                remplir_dt()
            Else
                cnx.Close()
                cnx.Open()
                cmd.CommandText = "INSERT INTO `stock`(`code_article`, `quantite_stock`) VALUES ('" & code_art & "','" & TextBox_quantite.Text & "')"
                cmd.ExecuteNonQuery()
                cnx.Close()

                MsgBox("L'achat de votre produit est effectué avec succès et le produit a été ajouté au stock.")
                vider_champ()
                remplir_dt()
            End If
        End If
    End Sub
End Class