Imports MySql.Data.MySqlClient

Public Class produit_fini
    ' Chaine de connexion à la base de données
    Private cnx As New MySqlConnection("server=localhost; database=gestion_stock;user id=root;password=;persist security info=true;convert zero DateTime=true")

    Private Sub produit_fini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirComboBox() ' Appel de la fonction pour remplir la ComboBox au chargement du formulaire
        RemplirDataGridView() ' Appel de la fonction pour remplir le DataGridView au chargement du formulaire
    End Sub

    Private Sub RemplirComboBox()
        Dim query As String = "SELECT destingation FROM produit_fini"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, cnx)
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "destingation"
        ComboBox1.ValueMember = "destingation"
    End Sub

    Private Sub RemplirDataGridView()
        Dim query As String = "SELECT destingation, qte FROM produit_fini"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, cnx)
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DataGridView1.DataSource = dt
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Vous pouvez accéder à la valeur sélectionnée dans ComboBox1 comme ceci :
        Dim selectedDestingation As String = ComboBox1.SelectedValue.ToString()
        ' Afficher la valeur sélectionnée dans une boîte de message
        MessageBox.Show("Vous avez sélectionné : " & selectedDestingation)
    End Sub

    Private Sub ButtonActualiser_Click(sender As Object, e As EventArgs) Handles ButtonActualiser.Click
        RemplirDataGridView() ' Appel de la fonction pour actualiser le DataGridView
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
