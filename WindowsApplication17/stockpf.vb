Imports MySql.Data.MySqlClient

Public Class stockpf
    ' Chaine de connexion à la base de données
    Private cnx As New MySqlConnection("server=localhost; database=gestion_stock;user id=root;password=;persist security info=true;convert zero DateTime=true")

    Private Sub stockpf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirComboBox() ' Appel de la fonction pour remplir la ComboBox au chargement du formulaire
        RemplirDataGridView() ' Appel de la fonction pour remplir le DataGridView au chargement du formulaire
    End Sub

    Private Sub RemplirComboBox()
        Dim query As String = "SELECT destingation FROM stock_pf"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, cnx)
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "destingation" ' Le nom de la colonne que vous voulez afficher
        ComboBox1.ValueMember = "destingation" ' Le nom de la colonne que vous voulez utiliser comme valeur
    End Sub

    Private Sub RemplirDataGridView()
        Dim query As String = "SELECT * FROM stock_pf"
        Dim dt As New DataTable()

        Using cmd As New MySqlCommand(query, cnx)
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        DataGridView1.DataSource = dt
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedDestingation As String = ComboBox1.SelectedValue.ToString()
        ' Afficher la valeur sélectionnée dans une boîte de message
        MessageBox.Show("Vous avez sélectionné : " & selectedDestingation)
    End Sub

    Private Sub ButtonActualiser_Click(sender As Object, e As EventArgs) Handles ButtonActualiser.Click
        RemplirDataGridView() ' Appel de la fonction pour actualiser le DataGridView
    End Sub
End Class
