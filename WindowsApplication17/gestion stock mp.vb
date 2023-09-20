Imports MySql.Data.MySqlClient

Public Class Form1
    Public cnx As New MySqlConnection("server=localhost;database=gestion_stock;user id=root;password=")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualiserDataGridView()
    End Sub

    Private Sub ActualiserDataGridView()
        Dim query As String = "SELECT destingation, quantite_stock FROM vente"

        Try
            cnx.Open()
            Using adapter As New MySqlDataAdapter(query, cnx)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la récupération des données : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cnx.Close()
        End Try
    End Sub

    Private Sub ButtonActualiser_Click(sender As Object, e As EventArgs) Handles ButtonActualiser.Click
        ActualiserDataGridView()
    End Sub

    Private Sub ButtonActualiser_Click_1(sender As Object, e As EventArgs) Handles ButtonActualiser.Click

    End Sub
End Class