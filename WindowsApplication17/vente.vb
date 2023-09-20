




Imports System.Data
Imports MySql.Data.MySqlClient

Public Class vente
    Public cnx As New MySqlConnection("server=127.0.0.1; database=gestion_stock;user id=root; password=;persist security info=true; convert zero DateTime=true"
)
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Dim code_art, code_v As String
    Dim cin As String
    Dim b, qte_s As Integer
    Dim prx As Integer
    Dim tot As Integer
    Dim total_c As Double


    Public Sub remplir_dt()
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " SELECT article.designation_article,vente.quantite_stock,article.prix_vente ,vente.date_vente FROM `vente`,article WHERE article.code_article=vente.code_article "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        Dim dtrow(5) As String
        DataGridView1.Rows.Clear()
        While dr.Read
            dtrow(0) = dr(0)
            dtrow(1) = dr(1)
            dtrow(2) = dr(2)
            dtrow(3) = dr(3)

            DataGridView1.Rows.Add(dtrow)
        End While

        cnx.Close()

    End Sub

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
    Private Sub vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select `destingation_article` FROM `article`"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader

        While dr.Read
            ComboBox_design.Items.Add(dr(0))
        End While

        cnx.Close()

        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select nom_client , prenom_client  FROM client"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader

        While dr.Read
            ComboBox_client.Items.Add(dr(0) & "  " & dr(1))
        End While

        cnx.Close()







    End Sub

    Private Sub TextBox_quantite_TextChanged(sender As Object, e As EventArgs) Handles TextBox_quantite.TextChanged
        TextBox_quantite.BackColor = Color.White
    End Sub

    Private Sub TextBox_prix_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub ComboBox_design_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_design.SelectedIndexChanged
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select `code_article` , `prix_vente` FROM `article` WHERE `destingation_article` ='" & ComboBox_design.Text & "'"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            code_art = dr(0)
            prx = dr(1)
        End While

    End Sub

    Private Sub ComboBox_client_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_client.SelectedIndexChanged
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select `CIN_client` FROM `client` WHERE concat(nom_client,'  ',prenom_client)='" & ComboBox_client.Text & "'"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            cin = dr(0)

        End While

    End Sub

    Private Sub TextBox_remise_TextChanged(sender As Object, e As EventArgs) Handles TextBox_remise.TextChanged
        Dim remise As Integer


        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If TextBox_remise.Text = "" Then
                remise = 0
            Else

                remise = CInt(TextBox_remise.Text)
            End If

        Next
        total_commande.Text = total_c * (1 - (remise / 100))



    End Sub

    Private Sub Button_ajouter_Click_1(sender As Object, e As EventArgs)
        code_v = 1

        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT `code_vente` FROM `vente` "
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        While dr.Read
            code_v = dr(0)
            code_v = code_v + 1
        End While

        MsgBox(code_v)
        For y As Double = 0 To DataGridView1.Rows.Count - 2

            cnx.Close()
            cnx.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select `code_article` FROM `article` WHERE destingation_article ='" & DataGridView1.Rows(y).Cells(0).Value & "'"
            cmd.Connection = cnx
            dr = cmd.ExecuteReader
            While dr.Read
                code_art = dr(0)

            End While







            cnx.Close()
            cnx.Open()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO `vente`(`code_vente`, code_article, `quantite_stock`,`CIN_client`, `remise`,date_vente) VALUES (" & code_v & " ,'" & code_art & " '," & DataGridView1.Rows(b).Cells(1).Value & ",'" & cin & "'," & CInt(TextBox_remise.Text) & ",'" & DateTimePicker1.Value.ToString("yyyy-M-d") & "')"
            cmd.ExecuteNonQuery()

            cnx.Close()
            cnx.Open()
            cmd.CommandText = "Update `stock` Set `quantite_stock`=" & (qte_s - CInt(TextBox_quantite.Text)) & " WHERE `code_article`='" & code_art & "'"
            cmd.ExecuteReader()


            cnx.Close()
            MsgBox("vente succes")







            DataGridView1.Rows(y).Cells(3).Value = DataGridView1.Rows(y).Cells(1).Value * DataGridView1.Rows(y).Cells(2).Value
        Next

    End Sub

    Private Sub Button_supp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_modif_Click(sender As Object, e As EventArgs) Handles Button_modif.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim menuForm As New Menu() ' Remplacez "Menu" par le nom de la classe de votre formulaire de menu
        menuForm.Show()
        Me.Close() '
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim a As Integer
        a = MsgBox("est ce que vous etes sur de supprimer cette article ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "confirmer")
        If a = vbYes Then
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DataGridView1.Rows(index)
            selectedrow.Cells(0).Value.ToString()
            If DataGridView1.SelectedRows.Count > 0 Then
                DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))

            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bouton_ajouter.Click

        b = 0
        cnx.Close()
        cnx.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT `quantite_stock` FROM `stock` WHERE code_article ='" & code_art & "'"
        cmd.Connection = cnx
        dr = cmd.ExecuteReader
        If dr.Read() Then
            qte_s = dr(0)

            cnx.Close()
        End If

        '''''test d'existance en dtg

        Dim test As Boolean



        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(x).Cells(0).Value = ComboBox_design.Text Then

                test = True
                b = x
                Exit For
            End If

        Next

        If test = True Then  '''''produit existe 


            If CInt(TextBox_quantite.Text) + DataGridView1.Rows(b).Cells(1).Value <= qte_s Then ''''ste en stocvk suffisante 
                DataGridView1.Rows(b).Cells(1).Value = DataGridView1.Rows(b).Cells(1).Value + CInt(TextBox_quantite.Text)
                DataGridView1.Rows(b).Cells(3).Value = DataGridView1.Rows(b).Cells(2).Value * DataGridView1.Rows(b).Cells(1).Value
            Else

                MsgBox("vous avez seulement " & qte_s & " " & code_art & "en stock")
            End If
        Else
            If CInt(TextBox_quantite.Text) > qte_s Then


                MsgBox("vous avez seulement " & qte_s & " " & code_art & "en stock")


            Else


                tot = TextBox_quantite.Text * prx
                Dim row As String() = New String() {ComboBox_design.Text, TextBox_quantite.Text, prx, tot}
                DataGridView1.Rows.Add(row)
            End If


        End If

        For x As Integer = 0 To DataGridView1.Rows.Count - 1
            total_commande.Text = (CInt(total_commande.Text) + DataGridView1.Rows(x).Cells(3).Value) * (1 - (CInt(TextBox_remise.Text) / 100))
            total_c = total_commande.Text
        Next




    End Sub





End Class

































