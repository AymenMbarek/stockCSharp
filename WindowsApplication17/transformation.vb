Imports MySql.Data.MySqlClient

Public Class ButtonModifier
    ' Chaine de connexion à la base de données
    Private cnx As New MySqlConnection("server=localhost; database=gestion_stock;user id=root;password=;persist security info=true;convert zero DateTime=true")

    Private Sub transformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirDataGridView() ' Appel de la fonction pour remplir le DataGridView au chargement du formulaire
    End Sub

    Private Sub RemplirDataGridView()
        Dim query As String = "SELECT MP, qte_MP, PF, qte_PF, date FROM transformation"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, cnx)
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DataGridView1.DataSource = dt
    End Sub

    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        Dim mp As String = TextBox1.Text
        Dim qteMP As Integer = Integer.Parse(TextBox2.Text)
        Dim pf As String = TextBox3.Text
        Dim qtePF As Integer = Integer.Parse(TextBox4.Text)
        Dim dateTransformation As Date = DateTimePicker1.Value

        ' Construction de la requête d'insertion
        Dim insertQuery As String = "INSERT INTO transformation (MP, qte_MP, PF, qte_PF, date) VALUES (@mp, @qteMP, @pf, @qtePF, @date)"

        Using cmd As New MySqlCommand(insertQuery, cnx)
            cmd.Parameters.AddWithValue("@mp", mp)
            cmd.Parameters.AddWithValue("@qteMP", qteMP)
            cmd.Parameters.AddWithValue("@pf", pf)
            cmd.Parameters.AddWithValue("@qtePF", qtePF)
            cmd.Parameters.AddWithValue("@date", dateTransformation)

            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
        End Using

        RemplirDataGridView() ' Actualisez le DataGridView après l'ajout

        ' Effacer le contenu des TextBox et du DateTimePicker après l'ajout
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        DateTimePicker1.Value = Date.Now
    End Sub


    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Code pour modifier une transformation ici
        ' Vous pouvez ouvrir un formulaire de modification de transformation ou effectuer les opérations directement ici
    End Sub

    Private Sub ButtonMenu_Click(sender As Object, e As EventArgs) Handles ButtonMenu.Click
        Dim menuForm As New Menu() ' Remplacez "Menu" par le nom de la classe de votre formulaire de menu
        menuForm.Show()
        Me.Close() ' Fermez la fenêtre actuelle pour retourner au menu principal
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close() ' Ferme la fenêtre actuelle
    End Sub
End Class
